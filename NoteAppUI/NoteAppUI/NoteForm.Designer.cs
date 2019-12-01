namespace NoteAppUI
{
    partial class NoteForm
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
            this.AddEditPanel = new System.Windows.Forms.Panel();
            this.TitleTextBox = new System.Windows.Forms.TextBox();
            this.ModifiedDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.CreatedDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.RichTextBox = new System.Windows.Forms.RichTextBox();
            this.CategoryComboBox = new System.Windows.Forms.ComboBox();
            this.ModifiedLabel = new System.Windows.Forms.Label();
            this.CreatedLabel = new System.Windows.Forms.Label();
            this.CategoryLabel = new System.Windows.Forms.Label();
            this.TitleLable = new System.Windows.Forms.Label();
            this.CancelButton = new System.Windows.Forms.Button();
            this.OkButton = new System.Windows.Forms.Button();
            this.AddEditPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // AddEditPanel
            // 
            this.AddEditPanel.Controls.Add(this.TitleTextBox);
            this.AddEditPanel.Controls.Add(this.ModifiedDateTimePicker);
            this.AddEditPanel.Controls.Add(this.CreatedDateTimePicker);
            this.AddEditPanel.Controls.Add(this.RichTextBox);
            this.AddEditPanel.Controls.Add(this.CategoryComboBox);
            this.AddEditPanel.Controls.Add(this.ModifiedLabel);
            this.AddEditPanel.Controls.Add(this.CreatedLabel);
            this.AddEditPanel.Controls.Add(this.CategoryLabel);
            this.AddEditPanel.Controls.Add(this.TitleLable);
            this.AddEditPanel.Controls.Add(this.CancelButton);
            this.AddEditPanel.Controls.Add(this.OkButton);
            this.AddEditPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddEditPanel.Location = new System.Drawing.Point(0, 0);
            this.AddEditPanel.Name = "AddEditPanel";
            this.AddEditPanel.Size = new System.Drawing.Size(800, 450);
            this.AddEditPanel.TabIndex = 0;
            // 
            // TitleTextBox
            // 
            this.TitleTextBox.Location = new System.Drawing.Point(70, 6);
            this.TitleTextBox.Name = "TitleTextBox";
            this.TitleTextBox.Size = new System.Drawing.Size(310, 20);
            this.TitleTextBox.TabIndex = 10;
            // 
            // ModifiedDateTimePicker
            // 
            this.ModifiedDateTimePicker.Enabled = false;
            this.ModifiedDateTimePicker.Location = new System.Drawing.Point(322, 69);
            this.ModifiedDateTimePicker.Name = "ModifiedDateTimePicker";
            this.ModifiedDateTimePicker.Size = new System.Drawing.Size(158, 20);
            this.ModifiedDateTimePicker.TabIndex = 9;
            // 
            // CreatedDateTimePicker
            // 
            this.CreatedDateTimePicker.Enabled = false;
            this.CreatedDateTimePicker.Location = new System.Drawing.Point(70, 69);
            this.CreatedDateTimePicker.Name = "CreatedDateTimePicker";
            this.CreatedDateTimePicker.Size = new System.Drawing.Size(147, 20);
            this.CreatedDateTimePicker.TabIndex = 8;
            // 
            // RichTextBox
            // 
            this.RichTextBox.Location = new System.Drawing.Point(15, 95);
            this.RichTextBox.Name = "RichTextBox";
            this.RichTextBox.Size = new System.Drawing.Size(773, 314);
            this.RichTextBox.TabIndex = 7;
            this.RichTextBox.Text = "";
            // 
            // CategoryComboBox
            // 
            this.CategoryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CategoryComboBox.FormattingEnabled = true;
            this.CategoryComboBox.Location = new System.Drawing.Point(70, 35);
            this.CategoryComboBox.Name = "CategoryComboBox";
            this.CategoryComboBox.Size = new System.Drawing.Size(133, 21);
            this.CategoryComboBox.TabIndex = 6;
            // 
            // ModifiedLabel
            // 
            this.ModifiedLabel.AutoSize = true;
            this.ModifiedLabel.Location = new System.Drawing.Point(266, 75);
            this.ModifiedLabel.Name = "ModifiedLabel";
            this.ModifiedLabel.Size = new System.Drawing.Size(50, 13);
            this.ModifiedLabel.TabIndex = 5;
            this.ModifiedLabel.Text = "Modified:";
            // 
            // CreatedLabel
            // 
            this.CreatedLabel.AutoSize = true;
            this.CreatedLabel.Location = new System.Drawing.Point(12, 75);
            this.CreatedLabel.Name = "CreatedLabel";
            this.CreatedLabel.Size = new System.Drawing.Size(47, 13);
            this.CreatedLabel.TabIndex = 4;
            this.CreatedLabel.Text = "Created:";
            // 
            // CategoryLabel
            // 
            this.CategoryLabel.AutoSize = true;
            this.CategoryLabel.Location = new System.Drawing.Point(12, 38);
            this.CategoryLabel.Name = "CategoryLabel";
            this.CategoryLabel.Size = new System.Drawing.Size(52, 13);
            this.CategoryLabel.TabIndex = 3;
            this.CategoryLabel.Text = "Category:";
            // 
            // TitleLable
            // 
            this.TitleLable.AutoSize = true;
            this.TitleLable.Location = new System.Drawing.Point(12, 9);
            this.TitleLable.Name = "TitleLable";
            this.TitleLable.Size = new System.Drawing.Size(30, 13);
            this.TitleLable.TabIndex = 2;
            this.TitleLable.Text = "Title:";
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(713, 415);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 1;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // OkButton
            // 
            this.OkButton.Location = new System.Drawing.Point(632, 415);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(75, 23);
            this.OkButton.TabIndex = 0;
            this.OkButton.Text = "OK";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // NoteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AddEditPanel);
            this.Name = "NoteForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add/Edit Note";
            this.AddEditPanel.ResumeLayout(false);
            this.AddEditPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel AddEditPanel;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.Label TitleLable;
        private System.Windows.Forms.Label ModifiedLabel;
        private System.Windows.Forms.Label CreatedLabel;
        private System.Windows.Forms.Label CategoryLabel;
        private System.Windows.Forms.ComboBox CategoryComboBox;
        private System.Windows.Forms.RichTextBox RichTextBox;
        private System.Windows.Forms.DateTimePicker ModifiedDateTimePicker;
        private System.Windows.Forms.DateTimePicker CreatedDateTimePicker;
        private System.Windows.Forms.TextBox TitleTextBox;
    }
}