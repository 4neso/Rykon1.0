using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RykonServer
{
    class WebDesigner
    {
        internal static string ReadFile(string RequestFile)
        {
            try
            {
                return System.IO.File.ReadAllText(RequestFile);
            }
            catch { return "Error reading file"; }
        }
        public static string FileNotFoundTitle()
        {
            string d = DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString();
            return "<h2 style=\"color:blue;\"><a href='"+Program.GithUbURl+"' >Rykon Server V1</a></h2><h4 style=\"color:red;\">404 File Not Found !!! at "+d+"</h4>";
        }
        internal static string StatueCode(int code)
        {

            if (code.BiggerThan_orEQ(200) && code.SmallerThan_orEQ(299))
                return code+" OK";

            if (code.BiggerThan_orEQ(300) && code.SmallerThan_orEQ(399))
                return code + " Redirection";

            if (code.BiggerThan_orEQ(400) && code.SmallerThan_orEQ(499))
                return code + " Request Error";
            if (code.BiggerThan_orEQ(500) && code.SmallerThan_orEQ(599))
                return code + " Server Error";



                return code.ToString();
        }

        internal static string FileNotFoundTitle_Traditional(string p1, string p2)
        {
            return string.Format("<center><h1>404</h1><h2>Not Found</h2><h4>The Request URL was not found on this Server </h4><hr /><a href='{2}'>Rykon</a> 2.0 (Windows) Server at Host {0} Port {1}  </center> </br>{3}", p1, p2, Program.GithUbURl, WebDesigner.TradeMark(" "));

        }

   
        public static string metaUtf="<meta http-equiv=\"Content-Type\" content=\"text/html; charset=UTF-8\" /> ";
        internal static string ListDirectory(string Dir , string[]f,ServerConfig Config)
        { 
            int i = 0;
            string doc = "<h2>\r\n";
            doc +=           " Index of \r\n";
            doc +=      " </h2><h4>\r\n";
            doc +=          WebServer.EncodeHtmlChars(Dir)+"\r\n";
            doc +=          "</h4>\r\n";
            doc +=      "<hr/><table>\r\n";

            if (f == null || f.Length<1)            // empty
                return "Empty Dir";
          
            string fic=(Config.ShowDirIcon?WebDesigner.FolderIcoTag:"");

                foreach (string p in f)
                {
                    string tr = "<span style=\"text-decoration:underline\">";
                    tr += "<tr>\r\n";
                    tr += "<td>"+fic+"\r\n";
                    tr += "<a style='text-decoration: underline;' draggable='true' href ='" + (p) + "/' >\r\n";
                    string name = WebServer.EncodeHtmlChars("          ") + WebServer.EncodeHtmlChars(AppHelper.LastPeice(p, "/"));
                    tr +=  ((i==0)?"Parent Directory":(i.ToString()+name));
                    tr += "</a>\r\n";
                    tr += "</td>\r\n";
                    tr += "</tr></span>\r\n";
                    i++;

                    if (p == "")
                        continue;
                    doc += tr;

                }
            //} 
            doc += "</table><hr />"+WebDesigner.PoweredBy(Config)+" ";
            return doc;
        }

        private static string PoweredBy(ServerConfig Config)
        {
            return PoweredByConstant.Replace("YasserGersy", Config.PoweredByEnd);
        }

        public static string TradeMark(string p ,string c = "center")
        { 
            return "<div align='"+c+"'   >"+p+"&reg; 2016</div> ";
        }

        public static string _501InternalServerError(string host , string port,ServerConfig s )
        {
            return string.Format(
                "<center><h1>501</h1><h2>Server Error</h2><h4>Internal Server Error Occured while proccessing your request </br> on this Server </h4><hr /><a href='{2}'>Rykon</a> 2.0 (Windows) Server at Host {0} Port {1}  </center> </br>{3}", host, port, Program.GithUbURl, WebDesigner.TradeMark(s.PoweredByEnd));

        }

        public static string PoweredByConstant = "<div> Powered by <a href='" + Program.GithUbURl + "' >Rykon </a> Server v 2.0 4Neso &reg; 2016 ";
        /*
        private static string IndexOfEmptyDirectory(string RequestPage)
        {
         
            string doc = "<h2>\r\n";
            doc += " Index of \r\n";
            doc += " </h2><h4>\r\n";
            doc += WebServer.EncodeHtmlChars(RequestPage) + "\r\n";
            doc += "</h4>\r\n";
            doc += "<hr/><table>\r\n";

            string p = AppHelper.GoUpAsDirectory(RequestPage);

            string tr = "";
                tr += "<tr>\r\n";
                tr += "<td>\r\n";
                tr += "<a draggable='true' href ='" + (p) + "' >\r\n";
                tr += "Parent Directory	 "; 
                tr += "</a>\r\n";
                tr += "</td>\r\n";
                tr += "</tr>\r\n";
                doc += tr;
          

            doc += "</table><hr />" + WebDesigner.PoweredBy;
            return doc;
        }
        */
        public static string FolderIcoTag ="<img height='22' width='22' src='http://findicons.com/files/icons/766/base_software/128/folderopened_yellow.png' />";

        internal static string ListenDefaultIndex(string rootdir , string prefx, string port_)
        {
            string[] files;
            try
            {
                files = System.IO.Directory.GetFiles(rootdir+"Listen");
                string doc = string.Format("<body background=\"bg.jpg\"><a href 'http://{0}:{1}'> Refresh page </a><br />", prefx, port_);
                doc +="<h2>Enjoy Listening  !!  Rykon Listen </h2><center>\r\n";
                if (files.Length < 1)
                {
                    doc += "<h3> sorry no files found on this app </h3>";
                }
                else 
                foreach (string f in files)
                {
                    if (!WebServer.isMediaFile(f))
                        continue;
                    string filmn = AppHelper.LastPeice(f, "\\");
                    doc += "<h2>"+filmn + "</h2><div class='header' ><br /><audio controls>\r\n";
                    doc += "  <source src=\"" + filmn + "\" type=\"audio/mpeg\">\r\n</audio>\r\n";
                    doc += "<hr /><br />\r\n\r\n</div><style>#header {    background-color:black;    color:white;    text-align:center;    padding:5px;}#nav {    line-height:30px;    background-color:#eeeeee;    height:300px;    width:100px;    float:left;    padding:5px;	      }#section {    width:350px;    float:left;    padding:10px;	  }#footer {    background-color:black;    color:white;    clear:both;    text-align:center;   padding:5px;	  }</style>";
                }
                return Htmlbeg+doc+"</center> </body><b><p style=\"color:red\">This page was created on "+AppHelper.ReturnAllTime()+"</p></b>"+WebDesigner.HtmlEnd;

            }
            catch { return "no media found "; }
        }
        internal static string VideoDefaultIndex(string rootdir, string prefx, string port_)
        {
            string[] files;
            try
            {
                files = System.IO.Directory.GetFiles(rootdir + "Video");
                string doc = string.Format("<body background=\"bg.jpg\"><a href 'http://{0}:{1}'> Refresh page </a><br />", prefx, port_);
                doc += "<h2>Enjoy watching  !!  Rykon Videos </h2><center>\r\n";

                if (files.Length < 1)
                {
                    doc += "<h3> sorry no files found on this app </h3>";
                }else 
                foreach (string f in files)
                {
                    if (!WebServer.isMediaFile(f))
                        continue;
                    string filmn = AppHelper.LastPeice(f, "\\");

                    doc += "<video width=\"220\" height=\"140\" controls>";
                    doc += "  <source src=\""+filmn+"\" type=\"video/mp4\">";
                    doc += "</video>";

                } return Htmlbeg + doc + "</center> </body><b><p style=\"color:red\">This page was created on " + AppHelper.ReturnAllTime() + "</p></b>" + WebDesigner.HtmlEnd;

            }
            catch { return "no media found "; }
        }

        public static string HtmlEnd ="</html>";
        public static string Htmlbeg = "<html>";



        public static string ControlLoginPage { get; set; }

        internal static string ControlNotAllowed()
        {
            return "<center><h2>not authorized</h2> <hr /><h3> Sorry You are not allowed </h3></center>";
        }

        internal static string ControlCommandListindex(string p1, string p2, string p3, string password)
        {
            string doc = "<a href='exec?passwd&com=msgbx&mbtitle=hello+It' >";
            doc += "message box </a><hr />";

            doc += "<a href='exec?passwd&com=procstr&procnm=notepad' > ";
            doc += "launch Process </a>";

            doc +="<hr /><a href='exec?passwd&com=closeprocess&procnm=chrome.exe' >";
            doc += "close process </a>";

            doc += "<hr /><a href='exec?passwd&com=procstr&procnm=explorer.exe&procpar="+WebServer.EncodeUrlChars("@\"c:\"")+"' >";
            doc += "start explorer  </a>";
            
            doc += "<hr /><a href='exec?passwd&com=closeprocess&procnm=explorer' >";
            doc += "close explorer </a>";

            doc += "<hr /><a href='exec?passwd&com=procstr&procnm=bg.jpg&proctype=pic' >";
            doc += "Display Pic </a>";

            doc += "<hr /><a href='exec?passwd&com=closeallprocess&procnm=chrome.exe' >";
            doc +="close all Process </a>";
            doc = doc.Replace("passwd", password);
            return doc;

        }
    }
}
