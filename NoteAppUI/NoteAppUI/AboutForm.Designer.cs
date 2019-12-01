namespace NoteAppUI
{
    partial class AboutForm
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
            this.NameApp = new System.Windows.Forms.Label();
            this.VersionLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.AutorLabel = new System.Windows.Forms.Label();
            this.GitHubLabel = new System.Windows.Forms.LinkLabel();
            this.MailLinkLabel = new System.Windows.Forms.LinkLabel();
            this.AuthorLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NameApp
            // 
            this.NameApp.AutoSize = true;
            this.NameApp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameApp.Location = new System.Drawing.Point(12, 9);
            this.NameApp.Name = "NameApp";
            this.NameApp.Size = new System.Drawing.Size(85, 24);
            this.NameApp.TabIndex = 0;
            this.NameApp.Text = "NoteApp";
            // 
            // VersionLabel
            // 
            this.VersionLabel.AutoSize = true;
            this.VersionLabel.Location = new System.Drawing.Point(12, 50);
            this.VersionLabel.Name = "VersionLabel";
            this.VersionLabel.Size = new System.Drawing.Size(43, 13);
            this.VersionLabel.TabIndex = 1;
            this.VersionLabel.Text = "v. 1.0.0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "GitHub";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 249);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "E-mail";
            // 
            // AutorLabel
            // 
            this.AutorLabel.AutoSize = true;
            this.AutorLabel.Location = new System.Drawing.Point(2, 322);
            this.AutorLabel.Name = "AutorLabel";
            this.AutorLabel.Size = new System.Drawing.Size(82, 13);
            this.AutorLabel.TabIndex = 4;
            this.AutorLabel.Text = "2019 Vlad Zorin";
            // 
            // GitHubLabel
            // 
            this.GitHubLabel.AutoSize = true;
            this.GitHubLabel.Location = new System.Drawing.Point(57, 208);
            this.GitHubLabel.Name = "GitHubLabel";
            this.GitHubLabel.Size = new System.Drawing.Size(96, 13);
            this.GitHubLabel.TabIndex = 5;
            this.GitHubLabel.TabStop = true;
            this.GitHubLabel.Text = "vladz99/LabNTVP";
            this.GitHubLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.GitHubLabel_LinkClicked);
            // 
            // MailLinkLabel
            // 
            this.MailLinkLabel.AutoSize = true;
            this.MailLinkLabel.Location = new System.Drawing.Point(52, 249);
            this.MailLinkLabel.Name = "MailLinkLabel";
            this.MailLinkLabel.Size = new System.Drawing.Size(118, 13);
            this.MailLinkLabel.TabIndex = 6;
            this.MailLinkLabel.TabStop = true;
            this.MailLinkLabel.Text = "Vladik.zorin@yandex.ru";
            this.MailLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.MailLinkLabel_LinkClicked);
            // 
            // AuthorLabel
            // 
            this.AuthorLabel.AutoSize = true;
            this.AuthorLabel.Location = new System.Drawing.Point(12, 136);
            this.AuthorLabel.Name = "AuthorLabel";
            this.AuthorLabel.Size = new System.Drawing.Size(92, 13);
            this.AuthorLabel.TabIndex = 7;
            this.AuthorLabel.Text = "Author: Vlad Zorin";
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 340);
            this.Controls.Add(this.AuthorLabel);
            this.Controls.Add(this.MailLinkLabel);
            this.Controls.Add(this.GitHubLabel);
            this.Controls.Add(this.AutorLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.VersionLabel);
            this.Controls.Add(this.NameApp);
            this.Name = "AboutForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "About";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NameApp;
        private System.Windows.Forms.Label VersionLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label AutorLabel;
        private System.Windows.Forms.LinkLabel GitHubLabel;
        private System.Windows.Forms.LinkLabel MailLinkLabel;
        private System.Windows.Forms.Label AuthorLabel;
    }
}