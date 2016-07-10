using System;
using System.Configuration;
using System.IO;
using System.Windows.Forms;

namespace _69Grad.PDF.Merge
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            Template.Text = ConfigurationManager.AppSettings["Template"];
            Template.Enabled = true;
            BtnSelectTemplate.Enabled = true;
            Document.Text = ConfigurationManager.AppSettings["Document"];

            // Sauber machen
            try
            {
                foreach (
                    FileInfo file in new DirectoryInfo(Path.GetDirectoryName(Application.ExecutablePath)).GetFiles())
                {
                    if (file.Name.StartsWith("tmp_"))
                        File.Delete(file.FullName);
                }
            }
            catch
            {
            }

        }

        private void beendenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CleanUp();
            Application.Exit();
        }

        private void BtnSelectTemplate_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.CheckFileExists = true;
            ofd.CheckPathExists = true;
            ofd.Multiselect = false;
            ofd.Filter = "PDF-Dateien (*.pdf)|*.pdf";

            ofd.FileName = Template.Text;

            DialogResult result = ofd.ShowDialog();
            
            if (result == DialogResult.OK)
            {
                Template.Text = ofd.FileName;
                Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                config.AppSettings.Settings["Template"].Value = Template.Text;
                config.Save();
            }
        }

        private void BtnSelectDocument_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.CheckFileExists = true;
            ofd.CheckPathExists = true;
            ofd.Multiselect = false;
            ofd.Filter = "PDF-Dateien (*.pdf)|*.pdf";

            ofd.FileName = Document.Text;

            DialogResult result = ofd.ShowDialog();

            if (result == DialogResult.OK)
            {
                Document.Text = ofd.FileName;
                Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                config.AppSettings.Settings["Document"].Value = Document.Text;
                config.Save();
            }
        }

        private void BtnPreview_Click(object sender, EventArgs e)
        {
            PDF pdf = new PDF();
            pdf.DocumentPath = Document.Text;
            pdf.TemplatePath = Template.Text;
            pdf.Save(null);
        }


        private void BtnSaveDocument_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Original-Dokument wirklich ersetzen?", "Dokument ersetzen", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                PDF pdf = new PDF();
                pdf.DocumentPath = Document.Text;
                pdf.TemplatePath = Template.Text;
                pdf.Save(pdf.DocumentPath);
            }
        }

        /// <summary>
        /// Aufräumen
        /// </summary>
        private void CleanUp()
        {
            foreach (string tempFile in PDF.TempFiles)
            {
                string path = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), tempFile);
                try
                {
                    if (File.Exists(path)) File.Delete(path);
                }
                catch
                {
                }
            }
        }

        protected override void OnClosed(EventArgs e)
        {
            CleanUp();
            base.OnClosed(e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.AddExtension = true;
            sfd.Filter = "PDF-Dateien (*.pdf)|*.pdf";
            sfd.OverwritePrompt = true;
            sfd.SupportMultiDottedExtensions = true;
            DialogResult result = sfd.ShowDialog();
            
            if(result == DialogResult.OK)
            {
                PDF pdf = new PDF();
                pdf.DocumentPath = Document.Text;
                pdf.TemplatePath = Template.Text;
                pdf.Save(sfd.FileName);
            }

        }

    }
}
