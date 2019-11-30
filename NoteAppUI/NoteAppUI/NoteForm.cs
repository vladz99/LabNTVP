using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NoteApp;

namespace NoteAppUI
{
    public partial class NoteForm : Form
    {
        private Note _currentNote;
        public Note CurrentNote {
            get
            {
                if (_currentNote == null)
                {
                    _currentNote = new Note();                
                }                
                _currentNote.Name = TitleTextBox.Text;
                _currentNote.CategoryNotes = (NoteCategory)CategoryComboBox.SelectedItem;
                _currentNote.LastModifiedTime = ModifiedDateTimePicker.Value;
                _currentNote.CreationTime = CreatedDateTimePicker.Value;
                
                _currentNote.TextNotes = RichTextBox.Text;
                return _currentNote;
            }
            set
            {
                if (value == null)
                {
                    return;
                }
                TitleTextBox.Text = value.Name;
                CategoryComboBox.SelectedItem = value.CategoryNotes.ToString();
                RichTextBox.Text = value.TextNotes;
                CreatedDateTimePicker.Value = value.CreationTime;
                ModifiedDateTimePicker.Value = value.LastModifiedTime;
                _currentNote = value;
            }
        }
        public NoteForm()
        {
            InitializeComponent();
            CategoryComboBox.DataSource = Enum.GetValues(typeof(NoteCategory));
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
