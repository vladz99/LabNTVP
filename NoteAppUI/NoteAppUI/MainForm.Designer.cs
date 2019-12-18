namespace NoteAppUI
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.RightPanel = new System.Windows.Forms.Panel();
            this.RichTextBox = new System.Windows.Forms.RichTextBox();
            this.ModifiedDate = new System.Windows.Forms.DateTimePicker();
            this.DateCreated = new System.Windows.Forms.DateTimePicker();
            this.ModifiedDateLabel = new System.Windows.Forms.Label();
            this.DateCreatedLabel = new System.Windows.Forms.Label();
            this.SelectedCategoryLabel = new System.Windows.Forms.Label();
            this.CategoryNoteLabel = new System.Windows.Forms.Label();
            this.CurrentNoteLabel = new System.Windows.Forms.Label();
            this.LeftPanel = new System.Windows.Forms.Panel();
            this.RemovePictureBox = new System.Windows.Forms.PictureBox();
            this.EditPictureBox = new System.Windows.Forms.PictureBox();
            this.AddPictureBox = new System.Windows.Forms.PictureBox();
            this.NoteListBox = new System.Windows.Forms.ListBox();
            this.CategoryComboBox = new System.Windows.Forms.ComboBox();
            this.ShowCategoryLabel = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.TableLayoutPanel.SuspendLayout();
            this.RightPanel.SuspendLayout();
            this.LeftPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RemovePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EditPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(731, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.editToolStripMenuItem1,
            this.removeToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.addToolStripMenuItem.Text = "Add";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.AddToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem1
            // 
            this.editToolStripMenuItem1.Name = "editToolStripMenuItem1";
            this.editToolStripMenuItem1.Size = new System.Drawing.Size(117, 22);
            this.editToolStripMenuItem1.Text = "Edit";
            this.editToolStripMenuItem1.Click += new System.EventHandler(this.EditToolStripMenuItem1_Click);
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.removeToolStripMenuItem.Text = "Remove";
            this.removeToolStripMenuItem.Click += new System.EventHandler(this.RemoveToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // TableLayoutPanel
            // 
            this.TableLayoutPanel.ColumnCount = 2;
            this.TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.TableLayoutPanel.Controls.Add(this.RightPanel, 1, 0);
            this.TableLayoutPanel.Controls.Add(this.LeftPanel, 0, 0);
            this.TableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableLayoutPanel.Location = new System.Drawing.Point(0, 24);
            this.TableLayoutPanel.Name = "TableLayoutPanel";
            this.TableLayoutPanel.RowCount = 1;
            this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableLayoutPanel.Size = new System.Drawing.Size(731, 397);
            this.TableLayoutPanel.TabIndex = 1;
            // 
            // RightPanel
            // 
            this.RightPanel.Controls.Add(this.RichTextBox);
            this.RightPanel.Controls.Add(this.ModifiedDate);
            this.RightPanel.Controls.Add(this.DateCreated);
            this.RightPanel.Controls.Add(this.ModifiedDateLabel);
            this.RightPanel.Controls.Add(this.DateCreatedLabel);
            this.RightPanel.Controls.Add(this.SelectedCategoryLabel);
            this.RightPanel.Controls.Add(this.CategoryNoteLabel);
            this.RightPanel.Controls.Add(this.CurrentNoteLabel);
            this.RightPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RightPanel.Location = new System.Drawing.Point(295, 3);
            this.RightPanel.Name = "RightPanel";
            this.RightPanel.Size = new System.Drawing.Size(433, 391);
            this.RightPanel.TabIndex = 1;
            // 
            // RichTextBox
            // 
            this.RichTextBox.Enabled = false;
            this.RichTextBox.Location = new System.Drawing.Point(3, 102);
            this.RichTextBox.Name = "RichTextBox";
            this.RichTextBox.Size = new System.Drawing.Size(427, 289);
            this.RichTextBox.TabIndex = 8;
            this.RichTextBox.Text = "";
            // 
            // ModifiedDate
            // 
            this.ModifiedDate.Enabled = false;
            this.ModifiedDate.Location = new System.Drawing.Point(276, 76);
            this.ModifiedDate.Name = "ModifiedDate";
            this.ModifiedDate.Size = new System.Drawing.Size(126, 20);
            this.ModifiedDate.TabIndex = 6;
            // 
            // DateCreated
            // 
            this.DateCreated.Enabled = false;
            this.DateCreated.Location = new System.Drawing.Point(78, 76);
            this.DateCreated.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.DateCreated.Name = "DateCreated";
            this.DateCreated.Size = new System.Drawing.Size(120, 20);
            this.DateCreated.TabIndex = 5;
            // 
            // ModifiedDateLabel
            // 
            this.ModifiedDateLabel.AutoSize = true;
            this.ModifiedDateLabel.Location = new System.Drawing.Point(220, 79);
            this.ModifiedDateLabel.Name = "ModifiedDateLabel";
            this.ModifiedDateLabel.Size = new System.Drawing.Size(50, 13);
            this.ModifiedDateLabel.TabIndex = 4;
            this.ModifiedDateLabel.Text = "Modified:";
            // 
            // DateCreatedLabel
            // 
            this.DateCreatedLabel.AutoSize = true;
            this.DateCreatedLabel.Location = new System.Drawing.Point(25, 79);
            this.DateCreatedLabel.Name = "DateCreatedLabel";
            this.DateCreatedLabel.Size = new System.Drawing.Size(47, 13);
            this.DateCreatedLabel.TabIndex = 3;
            this.DateCreatedLabel.Text = "Created:";
            // 
            // SelectedCategoryLabel
            // 
            this.SelectedCategoryLabel.AutoSize = true;
            this.SelectedCategoryLabel.Location = new System.Drawing.Point(89, 43);
            this.SelectedCategoryLabel.Name = "SelectedCategoryLabel";
            this.SelectedCategoryLabel.Size = new System.Drawing.Size(94, 13);
            this.SelectedCategoryLabel.TabIndex = 2;
            this.SelectedCategoryLabel.Text = "Selected Category";
            // 
            // CategoryNoteLabel
            // 
            this.CategoryNoteLabel.AutoSize = true;
            this.CategoryNoteLabel.Location = new System.Drawing.Point(25, 43);
            this.CategoryNoteLabel.Name = "CategoryNoteLabel";
            this.CategoryNoteLabel.Size = new System.Drawing.Size(52, 13);
            this.CategoryNoteLabel.TabIndex = 1;
            this.CategoryNoteLabel.Text = "Category:";
            // 
            // CurrentNoteLabel
            // 
            this.CurrentNoteLabel.AutoSize = true;
            this.CurrentNoteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CurrentNoteLabel.Location = new System.Drawing.Point(22, 10);
            this.CurrentNoteLabel.Name = "CurrentNoteLabel";
            this.CurrentNoteLabel.Size = new System.Drawing.Size(114, 24);
            this.CurrentNoteLabel.TabIndex = 0;
            this.CurrentNoteLabel.Text = "Current note";
            // 
            // LeftPanel
            // 
            this.LeftPanel.Controls.Add(this.RemovePictureBox);
            this.LeftPanel.Controls.Add(this.EditPictureBox);
            this.LeftPanel.Controls.Add(this.AddPictureBox);
            this.LeftPanel.Controls.Add(this.NoteListBox);
            this.LeftPanel.Controls.Add(this.CategoryComboBox);
            this.LeftPanel.Controls.Add(this.ShowCategoryLabel);
            this.LeftPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LeftPanel.Location = new System.Drawing.Point(3, 3);
            this.LeftPanel.Name = "LeftPanel";
            this.LeftPanel.Size = new System.Drawing.Size(286, 391);
            this.LeftPanel.TabIndex = 2;
            // 
            // RemovePictureBox
            // 
            this.RemovePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("RemovePictureBox.Image")));
            this.RemovePictureBox.Location = new System.Drawing.Point(91, 355);
            this.RemovePictureBox.Name = "RemovePictureBox";
            this.RemovePictureBox.Size = new System.Drawing.Size(34, 27);
            this.RemovePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.RemovePictureBox.TabIndex = 9;
            this.RemovePictureBox.TabStop = false;
            this.RemovePictureBox.Click += new System.EventHandler(this.RemovePictureBox_Click);
            // 
            // EditPictureBox
            // 
            this.EditPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("EditPictureBox.Image")));
            this.EditPictureBox.Location = new System.Drawing.Point(46, 355);
            this.EditPictureBox.Name = "EditPictureBox";
            this.EditPictureBox.Size = new System.Drawing.Size(39, 27);
            this.EditPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.EditPictureBox.TabIndex = 8;
            this.EditPictureBox.TabStop = false;
            this.EditPictureBox.Click += new System.EventHandler(this.EditPictureBox_Click);
            // 
            // AddPictureBox
            // 
            this.AddPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("AddPictureBox.Image")));
            this.AddPictureBox.Location = new System.Drawing.Point(9, 355);
            this.AddPictureBox.Name = "AddPictureBox";
            this.AddPictureBox.Size = new System.Drawing.Size(31, 27);
            this.AddPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.AddPictureBox.TabIndex = 7;
            this.AddPictureBox.TabStop = false;
            this.AddPictureBox.Click += new System.EventHandler(this.AddPictureBox_Click);
            // 
            // NoteListBox
            // 
            this.NoteListBox.FormattingEnabled = true;
            this.NoteListBox.Location = new System.Drawing.Point(6, 40);
            this.NoteListBox.Name = "NoteListBox";
            this.NoteListBox.Size = new System.Drawing.Size(277, 303);
            this.NoteListBox.TabIndex = 3;
            this.NoteListBox.SelectedIndexChanged += new System.EventHandler(this.NoteListBox_SelectedIndexChanged);
            // 
            // CategoryComboBox
            // 
            this.CategoryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CategoryComboBox.FormattingEnabled = true;
            this.CategoryComboBox.Location = new System.Drawing.Point(100, 10);
            this.CategoryComboBox.Name = "CategoryComboBox";
            this.CategoryComboBox.Size = new System.Drawing.Size(183, 21);
            this.CategoryComboBox.TabIndex = 2;
            this.CategoryComboBox.SelectedIndexChanged += new System.EventHandler(this.CategoryComboBox_SelectedIndexChanged);
            // 
            // ShowCategoryLabel
            // 
            this.ShowCategoryLabel.AutoSize = true;
            this.ShowCategoryLabel.Location = new System.Drawing.Point(3, 13);
            this.ShowCategoryLabel.Name = "ShowCategoryLabel";
            this.ShowCategoryLabel.Size = new System.Drawing.Size(82, 13);
            this.ShowCategoryLabel.TabIndex = 1;
            this.ShowCategoryLabel.Text = "Show Category:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 421);
            this.Controls.Add(this.TableLayoutPanel);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(747, 459);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Note App";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.TableLayoutPanel.ResumeLayout(false);
            this.RightPanel.ResumeLayout(false);
            this.RightPanel.PerformLayout();
            this.LeftPanel.ResumeLayout(false);
            this.LeftPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RemovePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EditPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel TableLayoutPanel;
        private System.Windows.Forms.Panel RightPanel;
        private System.Windows.Forms.Panel LeftPanel;
        private System.Windows.Forms.ComboBox CategoryComboBox;
        private System.Windows.Forms.Label ShowCategoryLabel;
        private System.Windows.Forms.DateTimePicker DateCreated;
        private System.Windows.Forms.Label ModifiedDateLabel;
        private System.Windows.Forms.Label DateCreatedLabel;
        private System.Windows.Forms.Label CategoryNoteLabel;
        private System.Windows.Forms.Label CurrentNoteLabel;
        private System.Windows.Forms.ListBox NoteListBox;
        private System.Windows.Forms.DateTimePicker ModifiedDate;
        private System.Windows.Forms.RichTextBox RichTextBox;
        private System.Windows.Forms.Label SelectedCategoryLabel;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.PictureBox AddPictureBox;
        private System.Windows.Forms.PictureBox EditPictureBox;
        private System.Windows.Forms.PictureBox RemovePictureBox;
    }
}

