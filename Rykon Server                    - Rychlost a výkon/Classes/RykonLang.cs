using System;
using System.Collections.Generic;
using System.Text;

namespace RykonServer.Classes
{
  public  class RykonLang
    {
        public string LangName = "";
        public string CompilerPath = "";
        public string LangVersion = "";
        public string ProcessArgs = "";
        public List<string> FileExts = new List<string>();
        public string GetFileExtsString(string sep)
        {
            try
            {
                string res = "";
                foreach (string s in FileExts)
                    res += (s + sep);

                return res.Substring(0, res.Length - sep.Length);
            }
            catch { return ""; }
            }
        public RykonLang()
        {
                
        }


        internal static RykonLang Build(string lang, string AttSeparator,string ValSeparator)
        {
            // name=php AttSeparator path=c:\php AttSeparator version=3 AttSeparator arg=d
            RykonLang r = new RykonLang();

            if (lang.Contains(AttSeparator))
            {
                string[] attrs = lang.Split(new string[] { AttSeparator }, StringSplitOptions.RemoveEmptyEntries);
                foreach (string x in attrs)
                {
                    string name ="",val = "";

                    if (x.Contains(ValSeparator))
                    {
                        string [] pcs = x.Split(new string[] { ValSeparator }, StringSplitOptions.RemoveEmptyEntries);
                        name = pcs[0].Trim(); 
                    }
                    r.SetATrrAndVal(name, val);
                  


                }
            }

            return r;
        }
        public override string ToString()
        {
            string x = "";
            string valsp = SettingsEditor.Languages_ValueSeparator;
            string atrsp = SettingsEditor.Languages_AttributeSeparator;

            x += ("name"+valsp+this.LangName+atrsp);
            x += ("path" + valsp + this.CompilerPath + atrsp);
            x += ("version" + valsp + this.LangVersion + atrsp);
            x += ("arguments" + valsp + this.ProcessArgs + atrsp);
            x += ("exts" + valsp + this.GetFileExtsString(SettingsEditor.exts_Separator) + atrsp);
            x += ("enabled" + valsp + (this.Enabled ? "yes" : "no"));
            return x;
        
        }
        private void SetATrrAndVal(string name, string val)
        {
            name = name.ToLower();

            if (name == "name")
                this.LangName = val;

            else if (name == "version")
                this.LangVersion = val;

            else if (name == "path")
                this.CompilerPath = val;

            else if (name == "arguments")
                this.ProcessArgs = val;

        }
        
        public void AddAllowedExt(string ex)
        {
            ex = ex.Trim().ToLower();
            if (this.FileExts.Contains(ex))
                return;
            this.FileExts.Add(ex);
        }
        public void InitExts(string[] exs)
        {
            this.FileExts.Clear();
            foreach (string ex in exs)
            {
                string i = ex.ToLower().Trim();
                if (!this.FileExts.Contains(i))
                    this.FileExts.Add(i);
            }
        }
        internal bool CanCompile(string p)
        {
            if (p.Contains("."))
            {
                string[] seps = p.Split('.');
                string ex = seps[seps.Length - 1].ToLower();
                foreach (string ext in this.FileExts)
                    if (ex == ext)
                        return true;
            }
            return false;
        } 
        internal string ProcessCompilation(string RequestFile)
        {
            if (this.IsCompilerAvailable())
                return CompileNow();
            else
                return "Error Compilation";
        }

        private string CompileNow()
        {
            return "not implement compilenow";
        }

        private bool IsCompilerAvailable()
        {
            return (System.IO.File.Exists(this.CompilerPath));
        }

        internal bool IsMatch(RykonLang r)
        {
            return (this.CompilerPath.Trim() == r.CompilerPath.Trim()) ;
        }

        internal void Update(RykonLang r)
        {
            this.CompilerPath = r.CompilerPath;
            this.Enabled = r.Enabled;
            this.FileExts = r.FileExts;
            this.LangName = r.LangName;
            this.LangVersion = r.LangVersion;
            this.ProcessArgs = r.ProcessArgs;

        }

        internal void InitExts(System.Windows.Forms.ListBox.ObjectCollection objectCollection)
        {
            this.FileExts.Clear();
            foreach (string ss in objectCollection)
            {
                string s = ss.Trim();
                if (this.FileExts.Contains(s))
                    continue;
                else
                    this.FileExts.Add(s);
            }
        }

        internal bool validLang()
        {
            return string.IsNullOrEmpty(this.CompilerPath);
        }

        public bool Enabled = true;
    }
  public enum _Mode_ { on, off, Middle }
}
