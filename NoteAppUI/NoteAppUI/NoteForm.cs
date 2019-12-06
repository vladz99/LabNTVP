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
    /// <summary>
    /// Окно редактирования
    /// </summary>
    public partial class NoteForm : Form
    {
        /// <summary>
        /// Название заметки по умолчанию.
        /// </summary>
        private string _defaultName = "Без названия";

        /// <summary>
        /// Заметка
        /// </summary>
        private Note _currentNote;

        /// <summary>
        /// Задать и получить обработанную заметку
        /// </summary>
        public Note CurrentNote {
            get
            {
                if (_currentNote == null)
                {
                    _currentNote = new Note();                
                }                                                
                _currentNote.Name = TitleTextBox.Text;
                _currentNote.CategoryNotes = (NoteCategory)CategoryComboBox.SelectedItem;
                _currentNote.LastModifiedTime = DateTime.Now;
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

        /// <summary>
        /// Конструктор
        /// </summary>
        public NoteForm()
        {
            InitializeComponent();
            CategoryComboBox.DataSource = Enum.GetValues(typeof(NoteCategory));
            CategoryComboBox.SelectedIndex = 1;
            TitleTextBox.Text = _defaultName;
        }

        /// <summary>
        /// Реализация кнопки ОК
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OkButton_Click(object sender, EventArgs e)
        {
            if (CategoryComboBox.SelectedIndex == 0)
            {
                MessageBox.Show("Нельзя выбрать категорию : " + CategoryComboBox.SelectedItem.ToString() + " для создания заметки", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DialogResult = DialogResult.OK;           
            this.Close();
        }

        /// <summary>
        /// Реализация кнопки Cancel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        /// <summary>
        /// Событие, срабатывающие при покидании элемента Title Text Box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TitleTextBox_Leave(object sender, EventArgs e)
        {
            if (TitleTextBox.Text == "")
            {
                TitleTextBox.Text = _defaultName;
            }
        }

        /// <summary>
        /// Событие, срабатывающие при нажатии на Title Text Box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TitleTextBox_Enter(object sender, EventArgs e)
        {
            TitleTextBox.Text = "";
        }
    }
}
