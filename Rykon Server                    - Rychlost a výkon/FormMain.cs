using RykonServer.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Net;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;
using RykonServer.Forms;
using System.Threading;
using ScreenTask;
using System.Drawing.Imaging;

namespace RykonServer
{
    public partial class FormMain : Form
    {
        private List<Tuple<string, string>> _Prefixs_;

        List<Color> _StartingColors = new List<Color> (){Color.Green,Color.GreenYellow};
        List<Color> _StoppingColors = new List<Color> (){Color.Red,Color.Pink};

        int _handled = 0;
        private int _StartErrorCounter=0;
        private int _StopErrorCounter=0;


        private _Mode_ ServerMode = _Mode_.off;
        private HttpListener _MainServer_;
        private XCompiler _MainCompiler_ = new XCompiler();


        public int _ShotEvery = 500;
        private object _mrlocker_ = new object();
        private ReaderWriterLock _rwlck_ = new ReaderWriterLock();
        private MemoryStream _imgstr_;


        private bool _isWorking;
        private bool _isPrivateTask;
        private bool _isPreview;
        private bool _isMouseCapture;
        public  bool _isTakingScreenshots = true;
        public  bool _StreamerEnabled = false;//


        public string _RootDirectory { get; set; } 

        public string _LogsFilePath ="\\logs.txt"; 
        public string _ErrorFilePath ="\\Errors.txt";
         
        public string _AssemblyName = "Rykon Server";
        public ServerConfig ServerConfiguration;
        private FrmSelfBrowser TestingForm = new FrmSelfBrowser();

        public int _Canceled = 0;
        public int  _Port = 9090;
         
        public int screened = 0;
        private async Task StartServer()
        {
            ServerMode = _Mode_.on;
            ViewLog("Staring server ...");
            SetStatue("Staring server ...");

            string TrimmedPrefex = this._Prefixs_[(cb_Prefixs.SelectedIndex)].Item2;
            string SelectedPrefix = txbxUrl.Text = "http://" + TrimmedPrefex + ":" + NumPort.Value.ToString() + "/";

            GenerateListenPlayer();
            GenerateMediaPlayer();
            GenerateControlIndex();

            ChangeControlerS();
            _MainServer_ = new HttpListener();
            _MainServer_.Prefixes.Add(SelectedPrefix);
            _MainServer_.Start();

            string xt = "Running on " + this._Port;
            Ballooon(xt);
            ViewLog(xt);
            if (this._StreamerEnabled)
                ViewLog("streamer on " + textBoxUrlStreamer.Text);
            SetStatue(xt);
            notifyIcon1.Text = "Rykon Online ";
            while (_isWorking)
            {
                try
                {
                    if (_MainServer_.IsListening == false)
                        break;

                    RykonProcess cp = new RykonProcess();
                    cp.Output_code= 200;
                    var ctx = await _MainServer_.GetContextAsync();
                 
                    string ad = ((!this._RootDirectory.EndsWith("\\") ? "\\" : ""));
                    cp.LocalPath = ctx.Request.Url.LocalPath;
                    cp.RequestPage = (this._RootDirectory + /*ad+*/ cp.LocalPath.Replace("/", "\\")).Replace("\\\\", "\\");
                    cp.Request_extn = AppHelper.LastPeice(cp.RequestPage, ".");
                    cp.Request_extn = AppHelper.removeSlashes(cp.Request_extn);
                    cp.Requesting_Host = AppHelper.FirstPieceof(ctx.Request.UserHostName, ':');
                    if (cp.RequestPage.EndsWith("\\/"))
                        cp.RequestPage = cp.RequestPage.Substring(0, cp.RequestPage.Length - 1);

                    bool AllowedTocontrol = false;
                   // cp.SaveRequestHeaders(ctx.Request.Headers);
                   string uroriginalString= ctx.Request.Url.ToString();
                    AllowedTocontrol = uroriginalString.Contains(this.AuthToke);//
                    cp.RequestPage = WebServer.DecodeUrlChars(cp.RequestPage);
                    try
                    { 
                      
                        if(cp.LocalPath.StartsWith("/Control"))
                        {
                            if (!AllowedTocontrol)
                            {
                                cp.Output_document = WebDesigner.ControlNotAllowed();//ControlLoginPage;
                                cp.OutPutData = Encoding.UTF8.GetBytes(cp.Output_document);
                                ctx.Response.ContentType = "text/html";
                                ctx.Response.StatusCode = 405;

                                await ctx.Response.OutputStream.WriteAsync(cp.OutPutData, 0, cp.Output_document.Length);

                                ctx.Response.OutputStream.Close();
                                ctx.Response.Close();
                            }
                            else if (uroriginalString.Contains("exec") && !uroriginalString.EndsWith(this.AuthToke))
                            {
                                // sending commands 
                                //"http://192.168.1.100:9090/Control/exec?jex&com=msgbx&title=hello+It"
                                string[] pcs = new string[] { };
                                if (uroriginalString.Contains("?"))
                                    pcs = uroriginalString.Split('?');
                               // "http://192.168.1.100:9090/Control/exec   jex&com=msgbx&title=hello+It"
                                string main = pcs[pcs.Length - 1];
                                if (main.StartsWith(this.AuthToke))
                                    main = main.Substring(this.AuthToke.Length);
                                RemoteCommandExecuter r = new RemoteCommandExecuter(main);
                                r.proceeed();
                               
                                cp.OutPutData = Encoding.UTF8.GetBytes(r.Result);
                                ctx.Response.ContentType = "text/html";
                                ctx.Response.StatusCode = 200;
                                cp.Processing_Type = ProcessingType.Text;

                                try
                                {
                                    await ctx.Response.OutputStream.WriteAsync(cp.OutPutData, 0, cp.OutPutData.Length);
                                }
                                catch (Exception ex)
                                {


                                }
                                ctx.Response.Close();
                                continue;


                            }
                            else  // List Command index
                            {
                                cp.Output_document = AppHelper.ReadFileText(_RootDirectory + "/Control/index.html");
                                cp.OutPutData = Encoding.UTF8.GetBytes(cp.Output_document);
                                ctx.Response.ContentType = "text/html";
                                ctx.Response.StatusCode = 200;
                                cp.Processing_Type = ProcessingType.Text;

                                try
                                {
                                    await ctx.Response.OutputStream.WriteAsync(cp.OutPutData, 0, cp.OutPutData.Length);
                                }
                                catch (Exception ex)
                                {


                                }
                                ctx.Response.Close();
                                continue;
                            }


                        }
                        if (cp.LocalPath.StartsWith("/Stream/LiveStream.jpg"))
                        {
                            var resPath = ctx.Request.Url.LocalPath;
                          
                            var page = _RootDirectory + resPath;
                            bool fileExist;
                            lock (_mrlocker_)
                                fileExist = File.Exists(page);

                            if (!fileExist)
                            {
                                var errorPage = Encoding.UTF8.GetBytes("<h1 style=\"color:red\">Error 404 , File Not Found </h1><hr><a href=\".\\\">Back to Home</a>");
                                ctx.Response.ContentType = "text/html";
                                ctx.Response.StatusCode = 404;
                                cp.Processing_Type = ProcessingType.NotFound;

                                try
                                {
                                    await ctx.Response.OutputStream.WriteAsync(errorPage, 0, errorPage.Length);
                                }
                                catch (Exception ex)
                                {


                                }
                                ctx.Response.Close();
                                continue;
                            }


                            //if (isPrivateTask)
                            //{
                            //    if (!ctx.Request.Headers.AllKeys.Contains("Authorization"))
                            //    {
                            //        ctx.Response.StatusCode = 401;
                            //        ctx.Response.AddHeader("WWW-Authenticate", "Basic realm=Screen Task Authentication : ");
                            //        ctx.Response.Close();
                            //        continue;
                            //    }
                            //    else
                            //    {
                            //        var auth1 = ctx.Request.Headers["Authorization"];
                            //        auth1 = auth1.Remove(0, 6); // Remove "Basic " From The Header Value
                            //        auth1 = Encoding.UTF8.GetString(Convert.FromBase64String(auth1));
                            //        var auth2 = string.Format("{0}:{1}", txtUser.Text, txtPassword.Text);
                            //        if (auth1 != auth2)
                            //        {
                            //            // MessageBox.Show(auth1+"\r\n"+auth2);
                            //            Log(string.Format("Bad Login from {0} using {1}", ctx.Request.RemoteEndPoint.Address.ToString(), auth1));
                            //            var errorPage = Encoding.UTF8.GetBytes("<h1 style=\"color:red\">Not Authorized !!! </h1><hr><a href=\"./\">Back to Home</a>");
                            //            ctx.Response.ContentType = "text/html";
                            //            ctx.Response.StatusCode = 401;
                            //            ctx.Response.AddHeader("WWW-Authenticate", "Basic realm=Screen Task Authentication : ");
                            //            try
                            //            {
                            //                await ctx.Response.OutputStream.WriteAsync(errorPage, 0, errorPage.Length);
                            //            }
                            //            catch (Exception ex)
                            //            {


                            //            }
                            //            ctx.Response.Close();
                            //            continue;
                            //        }

                            //    }
                            // }

                            //Everything OK! ??? Then Read The File From HDD as Bytes and Send it to the Client 
                            byte[] filedata;

                            // Required for One-Time Access of the file {Reader\Writer Problem in OS}
                            _rwlck_.AcquireReaderLock(Timeout.Infinite);
                            filedata = File.ReadAllBytes(page);
                            _rwlck_.ReleaseReaderLock();

                            var fileinfo = new FileInfo(page);
                            if (fileinfo.Extension == ".css") // important for IE -> Content-Type must be defiend for CSS files unless will ignored !!!
                                ctx.Response.ContentType = "text/css";
                            else if (fileinfo.Extension == ".html" || fileinfo.Extension == ".htm")
                                ctx.Response.ContentType = "text/html"; // Important For Chrome Otherwise will display the HTML as plain text.



                            ctx.Response.StatusCode = 200;
                            try
                            {
                                await ctx.Response.OutputStream.WriteAsync(filedata, 0, filedata.Length);
                            }
                            catch (Exception ex)
                            {

                                /*
                                    the specified network name is no longer available
                        
                                 */

                            }

                            ctx.Response.Close();
                        }

                        else if (AppHelper.IsFileExist(cp.RequestPage))                   //dynamic  static page  or bin 
                        {
                            cp.RequestPage = AppHelper.Correctpath(cp.RequestPage);
                            if (_MainCompiler_.IsCompilable(cp.RequestPage))   //dynamic page                         {
                                cp.Output_document= _MainCompiler_.ProcessCompilation(cp.RequestPage);

                            if (WebServer.IsBinFile(cp.RequestPage))           // binary 
                            {
                                cp.Output_document= (cp.RequestPage);
                                cp.Requesting_Binary_data = true;

                            }
                            else                                            // static  page
                            {
                                cp.Output_document = WebDesigner.ReadFile(cp.RequestPage);
                            }
                        }



                        else if (ctx.Request.Url.LocalPath.EndsWith("/") || AppHelper.ExistedDir(cp.RequestPage))
                        //default index or browse Dir
                        {
                            if (_MainCompiler_.IsFoundDefaultIndex(cp.RequestPage))
                                cp.Output_document= _MainCompiler_.GetDefaultIndex(cp.RequestPage);
                            else if (WebServer.IsDirectoryFound(cp.RequestPage))
                            {
                                cp.Output_document = WebDesigner.ListDirectory(cp.RequestPage, WebServer.ListDir(cp.RequestPage, this._RootDirectory, cp.Requesting_Host, this._Port.ToString()), ServerConfiguration);
                                if (cp.Output_document == "Empty Dir")
                                {
                                    /*
                                    _CurrentExceptionType_ = ExceptionType.Empty_dir_And_no_Default_index;
                                    body = WebDesigner.FileNotFoundTitle_Traditional(currentHost, this.Port);
                                    */
                                }
                            }

                            ctx.Response.ContentType = "text/html";

                        }
                        else                         // not found 
                        {
                            cp.Output_document = WebDesigner.FileNotFoundTitle_Traditional(cp.Requesting_Host, this._Port.ToString());
                            ctx.Response.ContentType = "text/html";
                            cp.Output_code = 404;
                        }
                    }
                    catch
                    {
                        cp.Output_document = WebDesigner._501InternalServerError(cp.Requesting_Host, this._Port.ToString(), this.ServerConfiguration);
                        cp.Output_code = 501;
                    }
                    try
                    {
                        ctx.Response.StatusCode = cp.Output_code;
                        if (cp.Requesting_Binary_data)
                        {
                            ctx.Response.Headers.Add("Accept-Ranges", "bytes");
                            ctx.Response.Headers.Add("Last-Modified", "");
                            ctx.Response.Headers.Add("Server", "Rykon");
                            ctx.Response.Headers.Add("Date", System.DateTime.Now.ToShortDateString());
                            ctx.Response.Headers.Add("Content-Type", "image/" + cp.Request_extn);
                            byte[] bts = System.IO.File.ReadAllBytes(cp.RequestPage);
                            await ctx.Response.OutputStream.WriteAsync(bts, 0, bts.Length);
                        }
                        else
                            await ctx.Response.OutputStream.WriteAsync(ASCIIEncoding.UTF8.GetBytes(cp.Output_document), 0, cp.Output_document.Length);



                    }
                    catch (HttpListenerException h)
                    {
                        string x = h.Message;

                        if (h.Message == "The I/O operation has been aborted because of either a thread exit or an application request" || h.Message == "The specified network name is no longer available")
                        {
                            this._Canceled++;
                            cp.exception = ExceptionType.CanceledByRequestor;
                            cp.Output_document = "Request Canceled by client";
                            cp.Canceled = true;
                        }
                        ViewLog("Exception " + h.Message);
                    }
                    catch (OutOfMemoryException o)
                    {
                        cp.Output_code = 501;
                        ctx.Response.StatusCode = cp.Output_code;
                        ctx.Response.ContentType = "text/html";
                        cp.Output_document = WebDesigner._501InternalServerError(cp.Requesting_Host, this._Port.ToString(), this.ServerConfiguration);
                        cp.exception = ExceptionType.OutOfMemory_;
                        ViewLog("Exception  " + o.Message);

                    }

                    if (cp.exception != ExceptionType.none_)
                    {


                        switch (cp.exception)
                        {
                            case ExceptionType.OutOfMemory_:
                                {

                                    cp.Output_document = WebServer.GetInternalErrorException(cp.exception);
                                    await ctx.Response.OutputStream.WriteAsync(ASCIIEncoding.UTF8.GetBytes(cp.Output_document), 0, cp.Output_document.Length);
                                    break;
                                }
                            case ExceptionType.Empty_dir_And_no_Default_index:
                                {
                                    cp.Output_document = WebDesigner.FileNotFoundTitle_Traditional(cp.Requesting_Host, this._Port.ToString());
                                    ctx.Response.ContentType = "text/html";
                                    cp.Output_code = 404; break;
                                }
                        }

                    }
                    if (!cp.Canceled)
                        _handled++;

                    ctx.Response.OutputStream.Close();
                    ctx.Response.Close();

                    ViewLog(ctx.Request.Url.AbsoluteUri + "    " + WebDesigner.StatueCode(cp.Output_code));
                    ShowCounters();
                }
                catch { }

            }
            if (!_isWorking)
                stopserver();
        }

        private void GenerateMediaPlayer()
        {

            string mp = this._RootDirectory + "\\Video\\index.html";
            mp = AppHelper.RepairPathSlashes(mp);
            AppHelper.RepairPath(mp);
            string d = WebDesigner.VideoDefaultIndex(this._RootDirectory, this._Prefixs_[(cb_Prefixs.SelectedIndex)].Item2, this._Port.ToString());
            bool b = AppHelper.writeToFile(mp, d);
        }
        private void GenerateControlIndex()
        {
            string mp = this._RootDirectory + "\\Control\\index.html";
            mp = AppHelper.RepairPathSlashes(mp);
            AppHelper.RepairPath(mp);

            string d = WebDesigner.ControlCommandListindex(this._RootDirectory, this._Prefixs_[(cb_Prefixs.SelectedIndex)].Item2, this._Port.ToString(),this.AuthToke);
            bool b = AppHelper.writeToFile(mp, d);

        }
        private void GenerateListenPlayer()
        {
            string mp = this._RootDirectory +"\\Listen\\index.html";
            mp = AppHelper.RepairPathSlashes(mp);
            AppHelper.RepairPath(mp);
            
            string d = WebDesigner.ListenDefaultIndex(this._RootDirectory, this._Prefixs_[(cb_Prefixs.SelectedIndex)].Item2, this._Port.ToString());
            bool b = AppHelper.writeToFile(mp,d);
        }
        private void stopserver()
        {
            try
            {
                _MainServer_.Stop();
                _MainServer_.Abort();
                _MainServer_ = new HttpListener();

                string xt = "Server stopped";
                Ballooon(xt);
                ViewLog(xt);

                SetStatue(xt);
                notifyIcon1.Text = "Rykon Offline ";
            }
            catch { }
        }
        public FormMain()
        {
            InitializeComponent();
            _MainServer_ = new HttpListener();

            this._LogsFilePath = Application.StartupPath + "\\Logs.txt";
            this._ErrorFilePath = Application.StartupPath + "\\Errors.txt";
     
            LoadServerConfiguration();
            this._StreamerEnabled = ServerConfiguration.EnableStream;
            this._ControlerEnabled_ = ServerConfiguration.EnableControler;

            LoadPrefixes();
            LoadFiles();


            LoadLanguages();
            LoadSettings();


            SetStatue("");
            _MainCompiler_ = new XCompiler();

        }

        private void LoadServerConfiguration()
        {
            string ServerConfigPath = Application.StartupPath + "\\Req\\httpd.conf".Replace("\\\\", "\\");
            
            this.ServerConfiguration = new ServerConfig(ServerConfigPath);
            ServerConfiguration.SaveChanges();
            txbxControlPasswd.Text = ServerConfiguration.ControlPassword;
        }
        private void FormMain_Load(object sender, EventArgs e)
        {
            //this.Size = new Size(this.Size.Width + 10, this.Size.Height + 10);
            this.MinimumSize = this.MaximumSize=this.Size;

            if (ServerConfiguration.AutoStartListening)
                btnSwitch.PerformClick();
            else
                ChangeControlerS();

            CloseTabPages();
          
        }

        private void CloseTabPages()
        {
            while (tabControlMain.TabCount > 1)
                tabControlMain.TabPages.RemoveAt(1);
        }
        private void LoadLanguages()
        {
            this._MainCompiler_.ClearList();

            string langs_Separator = SettingsEditor.Languages_Separator;
            string Att_Separator = SettingsEditor.Languages_AttributeSeparator;
            string Val_separator = SettingsEditor.Languages_ValueSeparator;
            string languagesCollectionString = SettingsEditor.GetLanguages();


            if (languagesCollectionString.Contains(langs_Separator))
            {
                // many languages
                string[] langsArr = languagesCollectionString.Split(new string[] { langs_Separator }, StringSplitOptions.RemoveEmptyEntries);

                foreach (string _l_ in langsArr)
                {
                    RykonLang r = RykonLang.Build(_l_, Att_Separator, Val_separator);
                    _MainCompiler_.AddLanguage(r);
                }
            }
            else if (!string.IsNullOrEmpty(languagesCollectionString))
            {
                // single language
                RykonLang r = RykonLang.Build(languagesCollectionString, Att_Separator, Val_separator);
                if(r.validLang())
                _MainCompiler_.AddLanguage(r);
            }

        }

     
        private void LoadXCompilers()
        {
            this._MainCompiler_.phpPAth = ServerConfiguration.phpPath;
        }

        private void LoadFiles()
        {
            this.logsoldData = AppHelper.ReadFileText(this._LogsFilePath, true);
            this.ErroroldData = AppHelper.ReadFileText(this._ErrorFilePath, true);

            txbxLogs.Text = logsoldData;
        }

        private void LoadPrefixes()
        {
            _Prefixs_ = DrNetwork.GetAllIPv4Addresses();
            foreach (var ip in _Prefixs_)
            {
                cb_Prefixs.Items.Add(ip.Item2 + " - " + ip.Item1);
            }

            if (!SelectIpIfFound(SettingsEditor.GetFavPrefix()))
                if (!SelectIpIfFound("192.168.1.1"))
                    cb_Prefixs.SelectedIndex = cb_Prefixs.Items.Count - 1;
               
        
        }

        //netsh http add urlacl url=http://vaidesg:8080/ user=everyone
        //httpcfg set urlacl /u http://vaidesg1:8080/ /a D:(A;;GX;;;WD)

        
        private Task AddFirewallRule(int port)
        {
            return Task.Run(() =>
            {

                string cmd = RunCMD("netsh advfirewall firewall show rule \"Rykon\"");
                if (cmd.StartsWith("\r\nNo rules match the specified criteria."))
                {
                    cmd = RunCMD("netsh advfirewall firewall add rule name=\"Rykon\" dir=in action=allow remoteip=localsubnet protocol=tcp localport=" + port);
                    if (cmd.Contains("Ok."))
                    {
                     //   SetLog("Rykon Rule added to your firewall");
                    }
                }
                else
                {
                    cmd = RunCMD("netsh advfirewall firewall delete rule name=\"Rykon\"");
                    cmd = RunCMD("netsh advfirewall firewall add rule name=\"Rykon\" dir=in action=allow remoteip=localsubnet protocol=tcp localport=" + port);
                    if (cmd.Contains("Ok."))
                    {
                      //  SetLog("Rykon Rule updated to your firewall");
                    }
                }
            });

        }
        private string RunCMD(string cmd)
        {
            Process proc = new Process();
            proc.StartInfo.FileName = "cmd.exe";
            proc.StartInfo.Arguments = "/C " + cmd;
            proc.StartInfo.CreateNoWindow = true;
            proc.StartInfo.UseShellExecute = false;
            proc.StartInfo.RedirectStandardOutput = true;
            proc.StartInfo.RedirectStandardError = true;
            proc.Start();
            string res = proc.StandardOutput.ReadToEnd();
            proc.StandardOutput.Close();

            proc.Close();
            return res;
        }
        
        private bool SelectIpIfFound(string p)
        {
            bool found = false;
            int i = -1;
            foreach (string s in cb_Prefixs.Items)
            {
                i++;
                if (s.Trim() == p.Trim())
                {
                    cb_Prefixs.SelectedIndex = i; found = true;
                }
            }
         
            
            return found;
        }

        private void LoadSettings()
        {

            txbxControlPasswd.Text = ServerConfiguration.ControlPassword;
            this._RootDirectory= txbxRootDir.Text = SettingsEditor.GetRootDirectory(Application.StartupPath);
            this.tstrpBtnStream.Checked = tstrpBtnStreamOn.Checked = _StreamerEnabled;
            tstrpBtnStreamOff.Checked = !_StreamerEnabled;

            this.Tsrtrp_controler.Checked = Tsrtrp_controler_on.Checked = _ControlerEnabled_;
            Tsrtrp_controler_off.Checked = !_ControlerEnabled_;

            int port = this.ServerConfiguration.Port;
            if (port > 0 && port < 65354)
                this.NumPort.Value = port;
        }

        private async void btnSwitch_Click(object sender, EventArgs e)
        {
            RegenerateAuthCode();
            btnSwitch.Enabled = false;
            onlineToolStripMenuItem.Enabled = offlineToolStripMenuItem.Enabled = false;
            if (ServerMode == _Mode_.on)//stop 
            {
                this._isWorking = false;
                this._isTakingScreenshots = false;
                ServerMode = _Mode_.off;
                stopserver (); 
            }
            else   if (ServerMode == _Mode_.off)//pressed start
            {
                try
                {

                    ViewLog("initiating , Please Wait...");

                    _MainServer_.IgnoreWriteExceptions = true;
                    _isTakingScreenshots = true;
                    _isWorking = true;

                    await AddFirewallRule((int)NumPort.Value);

                    if (_StreamerEnabled)
                        Task.Factory.StartNew(() => CaptureScreenEvery(this.ScreenTicks)).Wait();

                        
                    await StartServer();
                   

                }
                catch (ArgumentException ae)
                {
                    ServerMode = _Mode_.off;
                    string p=("Starting Server exception " + ae.Message);
                   
                    ViewLog(p);
                }

                catch (HttpListenerException ae)
                {
                    ServerMode = _Mode_.off;
                    string msg = "";
                    if (ae.Message.Contains("The process cannot access the file because it is being used by another process"))
                    {
                        msg = "Port in use ";
                        SetStatue("Can not listen on Port (" + NumPort.Value.ToString() + ") because it  is in use ");
                        if (MessageBox.Show("port is in use , Do you want to try another one?", "Error used port", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            Random r = new Random(23232);
                            NumPort.Value = (decimal)r.Next(1000, 64000);
                            btnSwitch_Click(null, null);
                            return;
                        }
                        else
                            msg = ae.Message;

                        string p=("Starting Server exception " + msg);

                        ViewLog(p);

                    }
                }
                catch (ObjectDisposedException disObj)
                {
                    _MainServer_= new HttpListener();
                    _MainServer_.IgnoreWriteExceptions = true;
                }
                catch (Exception ae)
                {
                    ServerMode = _Mode_.off;
                    string p=("Starting Server Error" + ae.Message);
                   // SetError(p);
                    ViewLog(p);
                }
            }
            ChangeControlerS();
        }

        private void RegenerateAuthCode()
        {
            return;
            this.AuthToke = now();
        }

        private void SavePrefix()
        {
            if (cb_Prefixs.SelectedIndex > -1)
                SettingsEditor.SetFavPrefix(cb_Prefixs.SelectedItem.ToString());
     
        }
        private void TakeScreenshot(bool captureMouse)
        {
            screened++;
            if (captureMouse)
            {
                var bmp = ScreenCapturePInvoke.CaptureFullScreen(true);
                _rwlck_.AcquireWriterLock(Timeout.Infinite);
                bmp.Save(this._RootDirectory + "/Stream/LiveStream.jpg", ImageFormat.Jpeg);
                _rwlck_.ReleaseWriterLock();
                if (_isPreview)
                {
                    _imgstr_ = new MemoryStream();
                    bmp.Save(_imgstr_, ImageFormat.Jpeg);
                    imgPreview.Image = new Bitmap(_imgstr_);
                }
                return;
            }
            Rectangle bounds = Screen.GetBounds(Point.Empty);
            using (Bitmap bitmap = new Bitmap(bounds.Width, bounds.Height))
            {
                using (Graphics g = Graphics.FromImage(bitmap))
                {
                    g.CopyFromScreen(Point.Empty, Point.Empty, bounds.Size);
                }
                _rwlck_.AcquireWriterLock(Timeout.Infinite);
                bitmap.Save(this._RootDirectory+ "/Stream/LiveStream.jpg", ImageFormat.Jpeg);
                _rwlck_.ReleaseWriterLock();
                if (_isPreview)
                {
                    _imgstr_ = new MemoryStream();
                    bitmap.Save(_imgstr_, ImageFormat.Jpeg);
                    imgPreview.Image = new Bitmap(_imgstr_);
                }


            }
        }
       
         private async Task CaptureScreenEvery(int msec)
        {

           while ( _isWorking)
            { 
                if (this._isTakingScreenshots && _StreamerEnabled)
                {
                    TakeScreenshot(_isMouseCapture);
                    msec = this.ScreenTicks;// (int)numShotEvery.Value;
                    await Task.Delay(msec);
                } 
            }

        }
        

     private string now()
        {
            return       DateTime.Now.ToShortDateString()+"-" + DateTime.Now.ToShortTimeString();
        }

        private void Ballooon(string p)
        {
            this.notifyIcon1.BalloonTipText = p;
            notifyIcon1.ShowBalloonTip(500);

        } 

     
        private void ShowCounters()
        {
            labelStatue.Text = "Handled {" + _handled + "}  Canceled {" + _Canceled + "} ";

        }
       

        private void ViewLog(string p)
        {
            if (this.lastlogline == p)
                return;

            this.lastlogline = p;
            string nh = (now() + "  " + p + "\r\n");
            LogsnewData += nh;
            txbxLogs.Text += nh;

            txbxLogs.SelectionStart = txbxLogs.Text.Length-1;
            txbxLogs.ScrollToCaret();
        }
     
        private void ChangeControlerS()
        {
            
            bool starting = ServerMode == _Mode_.Middle;
            _isWorking =_isTakingScreenshots= (ServerMode==_Mode_.on);

            btnSwitch.Enabled = onlineToolStripMenuItem.Enabled = offlineToolStripMenuItem.Enabled = true;
            onlineToolStripMenuItem.Checked = modeToolStripMenuItem.Checked = _isWorking;
            offlineToolStripMenuItem.Checked = !_isWorking;

            ServerConfiguration.EnableStream = this._StreamerEnabled;
            ServerConfiguration.EnableControler=this._ControlerEnabled_;

            string stat = ""; 
            if (_isWorking)
                stat = "Stop Server ";
            else if (starting)
                stat = "starting ..";
            else
                stat = "Start Server";
             btnSwitch.Text = stat;


            NumPort.Enabled = cb_Prefixs.Enabled = !_isWorking;
            gpxStreamer.Enabled = _StreamerEnabled;
            txbxUrl.Enabled = _isWorking;

            this.Text = this._AssemblyName + ((_isWorking) ? ("       (Running on " + NumPort.Value + ")") : (""));
            buttonTestSelfBrowser.Enabled = _isWorking;
            btnTestStreamer.Enabled = _isWorking && _StreamerEnabled;
            if (!_isWorking)
                txbxUrl.Text = "";

            tstrpBtnStream.Checked = tstrpBtnStreamOn.Checked = this._StreamerEnabled;
            tstrpBtnStreamOff.Checked = !this._StreamerEnabled;

            Tsrtrp_controler_on.Checked = Tsrtrp_controler.Checked = this._ControlerEnabled_;
            Tsrtrp_controler_off.Checked = !this._ControlerEnabled_;

            ServerConfiguration.SaveChanges();

            Tsrtrp_controler_on.Enabled =
            Tsrtrp_controler_off.Enabled =
            tstrpBtnStreamOff.Enabled =
            tstrpBtnStreamOn.Enabled = ServerMode == _Mode_.off;
            panelBottom.BackColor=(_isWorking)?Color.Yellow:Color.FromArgb(202,81,0);
        }

        private void SetStatue(string p)
        {
            labelStatue.Text = p;
        }

        private void SetLog(string p)
        {
            try
            {
                ViewLog(p);
                this.LogsnewData += p + "\r\n"; 
                
            }
            catch { }
        } 

        private void txbxRootDir_TextChanged(object sender, EventArgs e)
        {
            string _X_ =txbxRootDir.Text.Trim();
            bool new_dir = (this._RootDirectory != _X_);
            if(new_dir)
                SetStatue("Root Directory Changed ");

            if (AppHelper.ExistedDir(_X_))
            {
                this._RootDirectory = _X_;
                SettingsEditor.setRootDirectory(this._RootDirectory);

              if(!new_dir)
                  SetStatue("Directory is found");}
            else
            {
                SetStatue("Directory not found");
            }

        }

        private void btnBrowseDir_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog f = new FolderBrowserDialog();
            if (f.ShowDialog() != DialogResult.OK)
                return;
            txbxRootDir.Text = f.SelectedPath;
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            new FrmSettings(_MainCompiler_).ShowDialog();
            LoadSettings();
        }

        private void NumPort_ValueChanged(object sender, EventArgs e)
        {
            ServerConfiguration.Port =  this._Port =(int) NumPort.Value;
            

           // SettingsEditor.SetPort(NumPort.Value, true);
            ServerConfiguration.SaveChanges();
        }

        private void cb_Prefixs_SelectedIndexChanged(object sender, EventArgs e)
        {
            SavePrefix();
        }

      
        private void btnCopyUrl_Click(object sender, EventArgs e)
        {
            
        }

        
        private void buttonTestSelfBrowser_Click(object sender, EventArgs e)
        {
            if (txbxUrl.Text.Length < 2)
                return;

            TestingForm.ShowInTaskbar = true;
            if (TestingForm.IsDisposed)
                TestingForm = new FrmSelfBrowser();

            TestingForm.SetUrl(txbxUrl.Text);
            TestingForm.Show();
        }
      
        private void linkLabelOpenRootDir_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            if (System.IO.Directory.Exists(txbxRootDir.Text))
                AppHelper.StartProcess(txbxRootDir.Text);
        }


        private void FormMain_Resize(object sender, EventArgs e)
        {
            if (FormWindowState.Minimized == this.WindowState)
            {
                notifyIcon1.Visible = true;
                notifyIcon1.ShowBalloonTip(500);
                this.Hide();
            }
            else if (FormWindowState.Normal == this.WindowState)
            {
              //  notifyIcon1.Visible = false;
            }
        }

        private void notifyIcon1_MouseClick(object sender, MouseEventArgs e)
        {
            //notifyIcon1.Visible = false;
            this.Show();
            this.WindowState = FormWindowState.Normal;

            this.btnTestStreamer.Size = this.StreamBtnsize;
            this.btnTestStreamer.Location = this.StreamBtnLocation;


            this.buttonTestSelfBrowser.Size = this.serverBtnsize;
            this.buttonTestSelfBrowser.Location = this.serverBtnLocation;

        }


        private void cb_Streamer_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Switch_cb_Streamer_()//object sender, EventArgs e)
        {
            _StreamerEnabled = tstrpBtnStream.Checked;
            gpxStreamer.Enabled = _StreamerEnabled;

            ServerConfiguration.EnableStream = _StreamerEnabled;
            ServerConfiguration.SaveChanges();
        }

        private void txbxUrl_TextChanged(object sender, EventArgs e)
        {
            lnk_copyUrl.Visible = txbxUrl.TextLength > 1;
            textBoxUrlStreamer.Text = (txbxUrl.Text.Length < 1 || !_StreamerEnabled) ? "" : (txbxUrl.Text + "Stream");
        }

        private void buttonCopyStrmUrl_Click(object sender, EventArgs e)
        {
            
        }

        private void btnTestStreamer_Click(object sender, EventArgs e)
        {
            if (textBoxUrlStreamer.Text.Length < 2)
                return;

            TestingForm.ShowInTaskbar = true;
            if (TestingForm.IsDisposed)
                TestingForm = new FrmSelfBrowser();

            TestingForm.SetUrl(textBoxUrlStreamer.Text);
            TestingForm.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            string x = "";
            x += "mouscap = "+this._isMouseCapture+"\r";
            x += "iswork = " + this._isWorking + "\r";
            x += "shotev = " + this._ShotEvery + "\r";
            x += "mouscap = "+this._isMouseCapture+"\r";
            x += "istakscrs =" + this._isTakingScreenshots + "\r";
            x += "screentook " + screened;
            MessageBox.Show(x);
        }


        public int ScreenTicks =500;


        public string lastlogline = ""; 

        private void gpxStreamer_Enter(object sender, EventArgs e)
        {

        }

        private void lnk_copyUrl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (string.IsNullOrEmpty(txbxUrl.Text))
                return;
            Clipboard.SetText(txbxUrl.Text);
            SetStatue("Url Copied to Clipboard");
        }

        private void lnk_copyStreamUrl_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txbxUrl.Text))
                return;
            Clipboard.SetText(textBoxUrlStreamer.Text);
            SetStatue("Url Copied to Clipboard");
        }

        private void txbxUrl_TextChanged_1(object sender, EventArgs e)
        {
        }

        private void textBoxUrlStreamer_TextChanged(object sender, EventArgs e)
        {
            lnk_copyStreamUrl.Visible = textBoxUrlStreamer.TextLength > 1;
        }

        private void tstrpBtnStreamOn_Click(object sender, EventArgs e)
        {
           _StreamerEnabled= this.ServerConfiguration.EnableStream = true;
            ChangeControlerS();
        }

        private void tstrpBtnStreamOff_Click(object sender, EventArgs e)
        {
          _StreamerEnabled=  this.ServerConfiguration.EnableStream = false;
            ChangeControlerS();
        }

        private void Tsrtrp_controler_off_Click(object sender, EventArgs e)
        {
            _ControlerEnabled_= this.ServerConfiguration.EnableControler = true;
            ChangeControlerS();
        }

        private void Tsrtrp_controler_on_Click(object sender, EventArgs e)
        {
            this._ControlerEnabled_=this.ServerConfiguration.EnableControler = true;
            ChangeControlerS();
        }
        public bool _ControlerEnabled_=false;
        private void lnk_copyStreamUrl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (this.textBoxUrlStreamer.TextLength > 0)
                Clipboard.SetText(textBoxUrlStreamer.Text);
        }

        private void onlineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_isWorking)
                return;
            onlineToolStripMenuItem.Checked = modeToolStripMenuItem.Checked = true;
            offlineToolStripMenuItem.Checked = false;
           
            btnSwitch.PerformClick();
        }

        private void offlineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!_isWorking)
                return;

            onlineToolStripMenuItem.Checked = modeToolStripMenuItem.Checked = false;
            offlineToolStripMenuItem.Checked = true;
                btnSwitch.PerformClick();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();  
        }

        private void lnk_copyUrl_VisibleChanged(object sender, EventArgs e)
        {
            if (!lnk_copyUrl.Visible)
            {
                buttonTestSelfBrowser.Size = new Size(96, 23);
                buttonTestSelfBrowser.Location = new Point(424, 38);
            }
            else
            {
                buttonTestSelfBrowser.Size = new Size(64, 23);
                buttonTestSelfBrowser.Location = new Point(458, 38);
            }

            this.serverBtnLocation = buttonTestSelfBrowser.Location;
            this.serverBtnsize = buttonTestSelfBrowser.Size;
        }

        private void lnk_copyStreamUrl_VisibleChanged(object sender, EventArgs e)
        {

            if (!lnk_copyStreamUrl.Visible)
            {
                btnTestStreamer.Size = new Size(106, 23);
                btnTestStreamer.Location = new Point(424, 14);
            }
            else
            {
                btnTestStreamer.Size = new Size(64, 23);
                btnTestStreamer.Location = new Point(463, 14);
            }
            this.StreamBtnLocation = btnTestStreamer.Location;
            this.StreamBtnsize= btnTestStreamer.Size;

        }

        private void btnSwitch_EnabledChanged(object sender, EventArgs e)
        {
            btnTestStreamer.BackColor = (btnTestStreamer.Enabled) ? Color.FromArgb(225, 111, 9) : Color.FromArgb(250, 200, 150);
            buttonTestSelfBrowser.BackColor = (buttonTestSelfBrowser.Enabled) ? Color.FromArgb(225, 111, 9) : Color.FromArgb(250, 200, 150);
            btnSwitch.BackColor = (btnSwitch.Enabled) ? Color.FromArgb(225, 111, 9) : Color.FromArgb(250, 200, 150);


        }

        public Size StreamBtnsize =new Size(64, 23);

        public Point StreamBtnLocation =  new Point(424, 14);

        public Point serverBtnLocation = new Point(463, 38); 

        public System.Drawing.Size serverBtnsize =new Size(64, 23);

        private void timerWriter_Tick(object sender, EventArgs e)
        {
            ServerConfiguration.SaveChanges();
            SaveLogs();

        }

        private void SaveLogs()
        {
            AppHelper.writeToFile(this._LogsFilePath, (this.logsoldData+"\r\n"+this.LogsnewData).Trim());
        }

        public string logsoldData=""; 

        public string LogsnewData ="";



        internal void saveData()
        {
            this.ServerConfiguration.SaveChanges();
            SaveLogs();
            saveErrors();
        }

        private void saveErrors()
        {
            AppHelper.writeToFile(this._ErrorFilePath, this.ErroroldData + "\r\n" + this.ErrorsnewData);

        }

        public string ErroroldData ="";//{ get; set; }
        public string ErrorsnewData = "";

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {


            if (ServerMode == _Mode_.on)
            {
                DialogResult dg = MessageBox.Show("Server is online \r\n if you exited , it will not be able to process current connection \r\n Are you sure to exite ?", "warning server online ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dg == DialogResult.No)
                {
                    e.Cancel = true;
                    return;
                }


                btnSwitch.PerformClick();
            }
            saveData();

        }

        private void lnkcloseLogs_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CloseCurrentTabPage();
        }

        private void CloseCurrentTabPage()
        {
            int i = tabControlMain.SelectedIndex;
            tabControlMain.TabPages.RemoveAt(i);
            
                tabControlMain.SelectedIndex = ((i < tabControlMain.TabCount))?i:tabControlMain.TabCount-1;
        }

        private void logsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            LookForTabPAge(tabPageLogs);
        }

        private void LookForTabPAge(TabPage tpg)
        {
            for (int i = 0; i < tabControlMain.TabCount; i++)
                if (tabControlMain.TabPages[i].Text == tpg.Text)
                {
                    tabControlMain.SelectedIndex = i;
                    return;
                }
            tabControlMain.TabPages.Add(tpg);
            tabControlMain.SelectedIndex = tabControlMain.TabCount - 1;
           
        }

        private void settingsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            LookForTabPAge(tabPageSettings);

        }

        private void lnk_close_settings_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CloseCurrentTabPage();
        }

        private void viewControllerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LookForTabPAge(tabpage_Controller);
        }

        private void viewStreamerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LookForTabPAge(tabPage_streamer);

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LookForTabPAge(tabPageAbout);

        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LookForTabPAge(tabPageDesigner);

        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(Program.GithUbURl);
        }

        private void closeTabsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseTabPages();
        }

        private void cbswitch_streamerPreview_CheckedChanged(object sender, EventArgs e)
        {
            _isPreview = cbswitch_streamerPreview.Checked;
            if (_isPreview == false)
                this.imgPreview.BackgroundImage = global::RykonServer.Properties.Resources.Untitled;

        }

        private void reloadServerConfigurationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadServerConfiguration();
        }





        public string AuthToke { get; set; }

        private void txbxControlPasswd_TextChanged(object sender, EventArgs e)
        {
            this.AuthToke = txbxControlPasswd.Text;
        }
    }
}
