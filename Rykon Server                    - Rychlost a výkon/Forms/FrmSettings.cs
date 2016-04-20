using RykonServer.Classes;
using RykonServer.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RykonServer
{
    public partial class FrmSettings : Form
    {
        public FrmSettings()
        {
            InitializeComponent();
        }

        public FrmSettings(XCompiler _MainCompiler_)
        {
            InitializeComponent();
            this.LangList = _MainCompiler_;
        }
        XCompiler LangList = new XCompiler();
        private void FrmSettings_Load(object sender, EventArgs e)
        {
            LoadSettings(true); 
            this.FormLoaded = true;
            LoadLangsToListBox();

        }

        private void LoadLangsToListBox()
        {
            lstbxLangs.Items.Clear();
            foreach (RykonLang r in this.LangList.LanguageList)
            {
                lstbxLangs.Items.Add(r.LangName);
            }
        }

       
        private void LoadSettings(bool SaveDefaults=false)
        {
            
            txbxRootDir.Text = SettingsEditor.GetRootDirectory();
            cbViewAppIntro.Checked =! SettingsEditor.GetDonotViewIntro();
            //labelRubyPath.Text = SettingsEditor.GetRubyPath();
            //labelPhpPath.Text = SettingsEditor.GetPHPPath();
            //labelPythonPath.Text = SettingsEditor.GetPythonPath();
            //labelRingPath.Text = SettingsEditor.GetRingPath();
            
            if (SaveDefaults)
            {
                this.OldRootDir = txbxRootDir.Text;
                this.OldViewIntro = this.cbViewAppIntro.Checked;
            }
        }

        public bool FormLoaded = false; 

        private void txbxRootDir_TextChanged(object sender, EventArgs e)
        {
            if(this.FormLoaded)
            SettingsEditor.setRootDirectory(txbxRootDir.Text,false);
        }

        private void cbViewAppIntro_CheckedChanged(object sender, EventArgs e)
        {
            if (this.FormLoaded)
                SettingsEditor.SetDonotViewIntro(!cbViewAppIntro.Checked, false);

        }

        private void btnBrowseRootDir_Click(object sender, EventArgs e)
        {

            FolderBrowserDialog f = new FolderBrowserDialog();
            if (f.ShowDialog() != DialogResult.OK)
                return;
            txbxRootDir.Text = f.SelectedPath;
        }

        public bool OldViewIntro { get; set; }

        public string OldRootDir { get; set; }

        private void btnResetDefaults_Click(object sender, EventArgs e)
        {
             ResetDefaults();
        }

        private void ResetDefaults()
        {
            this.txbxRootDir.Text = OldRootDir;
            this.cbViewAppIntro.Checked = this.OldViewIntro;
        }

        private void btnSaveSettings_Click(object sender, EventArgs e)
        {
            SettingsEditor.Save();
        }


        private void BrowsePath(  object sender, EventArgs e,Label l)
        {
            OpenFileDialog o = new OpenFileDialog();
            if (o.ShowDialog() != DialogResult.OK)
                return;
            l.Text = o.FileName;
        }

        private void btnBrowsePHp_Click(object sender, EventArgs e)
        {
        //    BrowsePath(sender, e,labelPhpPath);
        }
        private void btnBrowsePython_Click(object sender, EventArgs e)
        {
         //   BrowsePath(sender, e,labelPythonPath);

        }

        private void btnBrowseRuby_Click(object sender, EventArgs e)
        {
        //    BrowsePath(sender, e,labelRubyPath);

        }

        private void btnBrowseRing_Click(object sender, EventArgs e)
        {
         //   BrowsePath(sender, e, labelRingPath);

        }

        private void lstbxLangs_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnEditLang.Visible=(lstbxLangs.SelectedIndex>-1);
            ViewLanguage();
        }

        private void ViewLanguage()
        {
            if (lstbxLangs.SelectedIndex >= this.LangList.LanguageList.Count)
                return;
            ResetLangAtts();

            RykonLang r = this.LangList.LanguageList[lstbxLangs.SelectedIndex];
            
            txbxLangVer.Text = r.LangVersion;
            txbxLangName.Text = r.LangName;
            txbxLangPath.Text = r.CompilerPath;
            txbxLangArgs.Text = r.ProcessArgs;
            checkBox1.Checked = r.Enabled;
            foreach (string s in r.FileExts)
            {
                if (lstbxLangs.Items.Contains(s))
                    continue;
                lstbxLangs.Items.Add(s);

            }

        }

        private void ResetLangAtts()
        {
            txbxLangArgs.Text = txbxLangName.Text = txbxLangPath.Text = txbxLangVer.Text = "";
            checkBox1.Checked = false;
            lstbxExts.Items.Clear();
        }

        private void btnEditLang_Click(object sender, EventArgs e)
        {
            if (!(lstbxLangs.SelectedIndex >= this.LangList.LanguageList.Count && lstbxLangs.SelectedIndex > -1))
            {
                 
                FrmLanguageAdd f = new FrmLanguageAdd(LangList.LanguageList[lstbxLangs.SelectedIndex]);


                if (f.ShowDialog() != System.Windows.Forms.DialogResult.OK)
                    return;
                this.LangList.AddLanguage(f.SelectedLanguage);
            }
            LoadLangsToListBox();
        }

        private void btnNewLang_Click(object sender, EventArgs e)
        {

            FrmLanguageAdd f = new FrmLanguageAdd(LangList);
            if (f.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.LangList.AddLanguage(f.SelectedLanguage);

                SettingsEditor.SetLanguages(LangList.ToString(), true);
            }
            LoadLangsToListBox();


        }
    }
}
