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
        public Project()
        {
            Notes = new List<Note>();
        }
    }
}
