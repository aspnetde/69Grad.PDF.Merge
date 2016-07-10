namespace _69Grad.PDF.Merge
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dateiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.beendenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Template = new System.Windows.Forms.TextBox();
            this.Document = new System.Windows.Forms.TextBox();
            this.BtnSelectTemplate = new System.Windows.Forms.Button();
            this.BtnSelectDocument = new System.Windows.Forms.Button();
            this.BtnPreview = new System.Windows.Forms.Button();
            this.BtnSaveDocument = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dateiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(377, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dateiToolStripMenuItem
            // 
            this.dateiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.beendenToolStripMenuItem});
            this.dateiToolStripMenuItem.Name = "dateiToolStripMenuItem";
            this.dateiToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.dateiToolStripMenuItem.Text = "Datei";
            // 
            // beendenToolStripMenuItem
            // 
            this.beendenToolStripMenuItem.Name = "beendenToolStripMenuItem";
            this.beendenToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.beendenToolStripMenuItem.Text = "Beenden";
            this.beendenToolStripMenuItem.Click += new System.EventHandler(this.beendenToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Template:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Dokument:";
            // 
            // Template
            // 
            this.Template.Enabled = false;
            this.Template.Location = new System.Drawing.Point(79, 35);
            this.Template.Name = "Template";
            this.Template.Size = new System.Drawing.Size(199, 20);
            this.Template.TabIndex = 3;
            // 
            // Document
            // 
            this.Document.Location = new System.Drawing.Point(79, 62);
            this.Document.Name = "Document";
            this.Document.Size = new System.Drawing.Size(199, 20);
            this.Document.TabIndex = 4;
            // 
            // BtnSelectTemplate
            // 
            this.BtnSelectTemplate.Enabled = false;
            this.BtnSelectTemplate.Location = new System.Drawing.Point(284, 35);
            this.BtnSelectTemplate.Name = "BtnSelectTemplate";
            this.BtnSelectTemplate.Size = new System.Drawing.Size(75, 23);
            this.BtnSelectTemplate.TabIndex = 5;
            this.BtnSelectTemplate.Text = "Auswählen";
            this.BtnSelectTemplate.UseVisualStyleBackColor = true;
            this.BtnSelectTemplate.Click += new System.EventHandler(this.BtnSelectTemplate_Click);
            // 
            // BtnSelectDocument
            // 
            this.BtnSelectDocument.Location = new System.Drawing.Point(284, 62);
            this.BtnSelectDocument.Name = "BtnSelectDocument";
            this.BtnSelectDocument.Size = new System.Drawing.Size(75, 23);
            this.BtnSelectDocument.TabIndex = 6;
            this.BtnSelectDocument.Text = "Auswählen";
            this.BtnSelectDocument.UseVisualStyleBackColor = true;
            this.BtnSelectDocument.Click += new System.EventHandler(this.BtnSelectDocument_Click);
            // 
            // BtnPreview
            // 
            this.BtnPreview.Location = new System.Drawing.Point(15, 88);
            this.BtnPreview.Name = "BtnPreview";
            this.BtnPreview.Size = new System.Drawing.Size(75, 23);
            this.BtnPreview.TabIndex = 7;
            this.BtnPreview.Text = "Vorschau";
            this.BtnPreview.UseVisualStyleBackColor = true;
            this.BtnPreview.Click += new System.EventHandler(this.BtnPreview_Click);
            // 
            // BtnSaveDocument
            // 
            this.BtnSaveDocument.Location = new System.Drawing.Point(96, 88);
            this.BtnSaveDocument.Name = "BtnSaveDocument";
            this.BtnSaveDocument.Size = new System.Drawing.Size(112, 23);
            this.BtnSaveDocument.TabIndex = 8;
            this.BtnSaveDocument.Text = "Dokument ersetzen";
            this.BtnSaveDocument.UseVisualStyleBackColor = true;
            this.BtnSaveDocument.Click += new System.EventHandler(this.BtnSaveDocument_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(214, 88);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Neues Dokument erstellen";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(377, 125);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BtnSaveDocument);
            this.Controls.Add(this.BtnPreview);
            this.Controls.Add(this.BtnSelectDocument);
            this.Controls.Add(this.BtnSelectTemplate);
            this.Controls.Add(this.Document);
            this.Controls.Add(this.Template);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "69° PDF Merge";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dateiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem beendenToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Template;
        private System.Windows.Forms.TextBox Document;
        private System.Windows.Forms.Button BtnSelectTemplate;
        private System.Windows.Forms.Button BtnSelectDocument;
        private System.Windows.Forms.Button BtnPreview;
        private System.Windows.Forms.Button BtnSaveDocument;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}

