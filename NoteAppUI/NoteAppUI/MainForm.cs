using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NoteAppUI;
using NoteApp;

namespace NoteAppUI
{
    public partial class MainForm : Form
    {
        private Project _project;
        private List<Note> _currentCategory;
        
        public MainForm()
        {
            InitializeComponent();
            var listCategory = Enum.GetValues(typeof (NoteCategory));            
            CategoryComboBox.DataSource = listCategory;            
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            _project = ProjectManager.LoadToFile();            
            UpdateListNote(_project.Notes);            
        }

        private void UpdateListNote(List<Note> notes)
        {
            NoteListBox.Items.Clear();
            foreach(var note in notes)
            {
                NoteListBox.Items.Add(note.Name);
            }
            _currentCategory = notes;
        }

        private void CategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_project == null)
            {
                return;
            }
            List<Note> selectedNoteCategory = new List<Note>();
            foreach(var note in _project.Notes)
            {
                if (note.CategoryNotes == (NoteCategory)CategoryComboBox.SelectedItem)
                {
                    selectedNoteCategory.Add(note);
                }
            }
            UpdateListNote(selectedNoteCategory);
        }
        

        private void AddButton_Click(object sender, EventArgs e)
        {
            NoteForm noteForm = new NoteForm();
            DialogResult result = noteForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                Note newNote = noteForm.CurrentNote;                
                _project.Notes.Add(newNote);
                UpdateListNote(_project.Notes);
            }
        }
        private void EditButton_Click(object sender, EventArgs e)
        {
            var index = NoteListBox.SelectedIndex;
            if (index >= 0)
            {
                var selectedNoteIndex = _project.Notes.IndexOf(_currentCategory[index]);
                NoteForm noteForm = new NoteForm();
                noteForm.CurrentNote = _project.Notes[selectedNoteIndex];
                DialogResult result = noteForm.ShowDialog();
                if (result == DialogResult.OK)
                {
                    Note newNote = noteForm.CurrentNote;
                    _project.Notes.RemoveAt(selectedNoteIndex);
                    _project.Notes.Insert(selectedNoteIndex, newNote);                    
                    UpdateListNote(_project.Notes);
                }
            }
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            var index = NoteListBox.SelectedIndex;
            if (index >= 0)
            {
                var selectedNoteIndex = _project.Notes.IndexOf(_currentCategory[index]);
                var selectedNote = _project.Notes[selectedNoteIndex];
                DialogResult result = MessageBox.Show("Вы уверены что хотите удалить заметку: " + selectedNote.Name + " ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    _project.Notes.RemoveAt(selectedNoteIndex);
                    UpdateListNote(_project.Notes);
                }
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            ProjectManager.SaveToFile(_project);
        }

        private void NoteListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var index = NoteListBox.SelectedIndex;
            if (index >= 0)
            {
                var indexNote = _project.Notes.IndexOf(_currentCategory[index]);
                Note selectedNote = _project.Notes[indexNote];
                CurrentNoteLabel.Text = selectedNote.Name;
                SelectedCategoryLabel.Text = selectedNote.CategoryNotes.ToString();
                DateCreated.Value = selectedNote.CreationTime;
                ModifiedDate.Value = selectedNote.LastModifiedTime;
                RichTextBox.Text = selectedNote.TextNotes;

            }
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm about = new AboutForm();
            about.ShowDialog();
        }
    }
}
