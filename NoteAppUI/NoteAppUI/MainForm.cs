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
            MessageBox.Show("asd");
            UpdateListNote(_project.Notes);
            
        }

        private void UpdateListNote(List<Note> notes)
        {
            foreach(var note in notes)
            {
                NoteListBox.Items.Add(note.Name);
            }
            _currentCategory = notes;
        }

        private void CategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void AddButton_Click(object sender, EventArgs e)
        {

        }
    }
}
