using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteApp
{
    /// <summary>
    /// Список всех заметок
    /// </summary>

    public class Project
    {
        /// <summary>
        /// Список заметок
        /// </summary>
        private List<Note> _notes;

        /// <summary>
        /// Свойство "Текущая заметка"
        /// </summary>
        public int IndexCurrentNote
        {
            get;
            set;
        }

        /// <summary>
        /// Возвращает и задает список всех заметок
        /// </summary>
        public List<Note> Notes
        {
            get => _notes;
            set
            {
                _notes = value;
            }
        }

        /// <summary>
        /// Конструктор
        /// </summary>
        public Project()
        {
            Notes = new List<Note>();
        }

        /// <summary>
        /// Метод сортировки заметок по дате изменения
        /// </summary>
        public List<Note> SortNotes(List<Note> noteList = null)
        {
            var sortingList = noteList ?? Notes;
            sortingList.Sort(delegate (Note x, Note y)
            {
                if (x.LastModifiedTime == null && y.LastModifiedTime == null) return 0;
                else if (x.LastModifiedTime == null) return 1;
                else if (y.LastModifiedTime == null) return -1;
                else return y.LastModifiedTime.CompareTo(x.LastModifiedTime);
            });
            return sortingList;
        }

        /// <summary>
        /// Метод получения заметки для выбранной категории
        /// </summary>
        /// <param name="selectedCategory"></param>
        /// <returns></returns>
        public List<Note> GetNotesSelectedCategory(NoteCategory selectedCategory)
        {
            var selectedNoteCategory = new List<Note>();
            foreach (var note in Notes)
            {
                if (note.CategoryNotes == selectedCategory)
                {
                    selectedNoteCategory.Add(note);
                }
            }
            return selectedNoteCategory;
        }
    }
}
