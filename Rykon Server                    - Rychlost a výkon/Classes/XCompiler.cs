using RykonServer.Classes;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;

namespace RykonServer
{
    public class XCompiler
    {
        public static string RailsDownloader = "https://s3.amazonaws.com/railsinstaller/Windows/railsinstaller-3.2.0.exe";
        public static string PHPDownloader = "http://windows.php.net/downloads/releases/php-7.0.3-nts-Win32-VC14-x86.zip";
        public static string PythonDownloader = "https://www.python.org/ftp/python/2.7.10/python-2.7.10.msi";
        public static string RingDownloader = "http://netix.dl.sourceforge.net/project/ring-lang/Ring%201.0/Fayed_Ring_1.0_win32_binary_release.zip";

        public List<RykonLang> LanguageList = new List<RykonLang>();
        public static string ProcessWebAppPage(string cp, string page)
        {
            return "";
        }
        public override string ToString()
        {
            string x = "";
            foreach (RykonLang r in this.LanguageList)
            {
                x += (r.ToString()+SettingsEditor.Languages_Separator);
            }
            return x.Substring(0,x.Length-SettingsEditor.Languages_Separator.Length);

        }
        internal bool IsCompilable(string p)
        {
            try
            {
                if (!AppHelper.IsFileExist(this.phpPAth))
                    return false;

                if (!p.ToLower().EndsWith(".php"))
                    return false;
            }
            catch { }

            return true;
            var ext = new FileInfo(p);
            foreach (RykonLang r in this.LanguageList)
                if (r.CanCompile(p))
                    return true;
            return false;
        }
        public string CompilePage(string CompilerPath, string pageFilePath, string argumnts = "")
        {
            try
            {
                Process proc = new Process();
                proc.StartInfo.FileName = CompilerPath;
                proc.StartInfo.Arguments = "-d \"display_errors=1\" -d \"error_reporting=E_PARSE\" \"" + pageFilePath + "\"";
                proc.StartInfo.CreateNoWindow = true;
                proc.StartInfo.UseShellExecute = false;
                proc.StartInfo.RedirectStandardOutput = true;
                proc.StartInfo.RedirectStandardError = true;
                proc.Start();
                string res = proc.StandardOutput.ReadToEnd();
                if (string.IsNullOrEmpty(res))
                {
                    res = proc.StandardError.ReadToEnd();
                    res = "<h2 style=\"color:red;\">Error!</h2><hr/> <h4>Error Details :</h4> <pre>" + res + "</pre>";
                    proc.StandardError.Close();
                }
                if (res.StartsWith("\n Parse error: syntax error"))
                    res = "<h2 style=\"color:red;\">Error!</h2><hr/> <h4>Error Details :</h4> <pre>" + res + "</pre>";


                proc.StandardOutput.Close();

                proc.Close();
                return res;
            }
            catch (Exception s) { return s.Message; }
        }

        internal string ProcessCompilation(string RequestFile)
        {
            return CompilePage(phpPAth, RequestFile);
            return "";
            foreach (RykonLang lang in this.LanguageList)
                if (lang.CanCompile(RequestFile))
                    return lang.ProcessCompilation(RequestFile);

            return "Invalid Compiler ";
        }

        internal void AddLanguage(Classes.RykonLang r)
        {
            int count=-1;
            foreach (RykonLang rl in this.LanguageList)
            {
                count++;

                if (rl.IsMatch(r))
                {
                    this.LanguageList[count].Update(r);
                    return;
                }
            }
            this.LanguageList.Add(r);
        }

        internal void ClearList()
        {
            this.LanguageList.Clear();
        }

       

        internal string GetDefaultIndex(string RequestFile)
        {
            string x = RequestFile + "\\index.html";
            x = AppHelper.RepairPathSlashes(x);
            string res = "";

            try
            {
                res =  AppHelper.ReadFileText(x);
                return res;
            }
            catch(Exception es) {return es.Message; }
        }

        internal bool IsFoundDefaultIndex(string RequestFile)
        {
            string x = RequestFile + "\\index.html";
            x=x.Replace("\\\\","\\");
            return AppHelper.IsFileExist(x);
        }

        public string phpPAth=""; 
    }
    
}
