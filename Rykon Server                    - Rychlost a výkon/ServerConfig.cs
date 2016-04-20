using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RykonServer
{
   public class ServerConfig
    {

        bool HasNewData = false;
        bool saved = false;

        public bool ShowDateTime = true;
        public bool ShowMessageError = true;
        public bool ShowDirIcon = false;
        public bool ShowHostAndPort = true;
        public bool ShowPoweredByEnd = true;
        public bool AutoStartListening = false;
        public int ScreenShotEvery = 500;

        public string PoweredByEnd = "4Neso  ";
        public bool ValidConfigFile = false;
        public bool EnableStream = false;

        public ServerConfig(string file)
        {
            this.FilePath = file;
            if(!AppHelper.IsFileExist(file))
                return;


            string [] data = new string []{};
            try
            {
                data = System.IO.File.ReadAllLines(file);
            }
            catch { ValidConfigFile = false; return; }
            if (data.Length < 1)
            { ValidConfigFile = false; return; }

            Create(data);


        } 
        private void Create(string[] data)
        {
            if (data.Length < 1)
                return;
            foreach (string s in data)
            {
                if (s.Contains('=') == false|| s.StartsWith("#"))
                    continue;
                string[] pcs = s.Split('=');
                string id = pcs[0].Trim().ToLower();
                string Value = pcs[1];

                switch (id)
                {

                    //ScreenShotEvery
                    
                    case "ShowDateTime":
                    case "showdatetime": this.Initiate(Value, ref this.ShowDateTime); break;
                    
                    case "ShowMessageError":
                    case "showmessageerror":   this.Initiate(Value, ref this.ShowMessageError); break;
                  
                    
                    case "ShowDirIco"     :
                    case "showdirico":
                    case "ShowDirIcon":
                    case "showdiricon"     :   this.Initiate(Value, ref this.ShowDirIcon); break;
                   
                    case "ShowHostAndPort":
                    case "showhostandport":        this.Initiate(Value, ref this.ShowHostAndPort); break;
                   
                    case "showpoweredbyEnd":
                    case "ShowPoweredByEnd": this.Initiate(Value, ref this.ShowPoweredByEnd); break;

                    case "poweredbyend":
                    case "PoweredByEnd": this.Initiate(Value, ref this.PoweredByEnd); break;



                    case "autostartlistening":
                    case "AutoStartListening": this.Initiate(Value, ref this.AutoStartListening); break;
                  
                    case "enablestream":
                    case "EnableStream": this.Initiate(Value, ref this.EnableStream); break;


                    case "Port":
                    case "port": this.Initiate(Value, ref this.Port); break;

                    case "ScreenShotEvery":
                    case "screenshotevery": this.Initiate(Value, ref this.ScreenShotEvery); break;


                    case "enablecontroler":
                    case "EnableControler": this.Initiate(Value, ref this.EnableControler); break;


                    case "ControlPassword":
                    case "controlpassword": this.Initiate(Value, ref this.ControlPassword); break;

                    case "phpath": this.Initiate(Value, ref this.phpPath); break;

                    // 
                    //

                }
            }
        }
        public int Port = 9090;
        private void Initiate(string Value, ref string p)
        {
            p = Value.Trim();
        }
        private void Initiate(string Value, ref int p)
        {
            try
            {
                p = int.Parse(Value.Trim());
            }
            catch { p = 9090; }
        } 
        private  void Initiate(string Value, ref bool p)
        {
            int i = AppHelper.BoolTrueUnkown(Value);
            if (i == 1)
                p = true;
            else if (i == 0)
                p = false; 
        }
        public string FilePath { get; set; }
        public bool SaveChanges()
        {
            string data = "#Rykon Server configuration file v 1.0 be carefull !!";
            data += "\r\nShowDateTime=" + Val(ShowDateTime);
            data += "\r\nShowMessageError=" + Val(ShowMessageError);
            data += "\r\nShowDirIcon=" + Val(ShowDirIcon);
            data += "\r\nShowHostAndPort=" + Val(ShowHostAndPort);
            data += "\r\nShowPoweredByEnd=" + Val(ShowPoweredByEnd);
            data += "\r\nPoweredByEnd=" + (PoweredByEnd);
           
            data += "\r\nAutoStartListening=" + Val(AutoStartListening);
            data += "\r\nEnableStream=" + (EnableStream);
            data += "\r\nPort=" + (Port);
            data += "\r\nScreenShotEvery=" +( ScreenShotEvery);
            data += "\r\nEnableControler=" + Val(EnableControler);
            data += "\r\nControlPassword=" + (ControlPassword);
            data += "\r\nphpPath=" + (phpPath);

            try
            {
                System.IO.File.WriteAllText(this.FilePath, data);
                saved = true;
            }
            catch { saved = false; }
            return saved;
        }

        private static  string Val(bool a)
        {
            if (a)
                return "Yes";
            else
                return "No";
        }

        public bool EnableControler =true;

        public string currentHost { get; set; }

        public string ControlPassword="12345";

        public string phpPath="";
    }
}
