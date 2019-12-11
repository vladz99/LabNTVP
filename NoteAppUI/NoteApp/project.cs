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
        /// Создаем новый лист заметок
        /// </summary>
        private List<Note> _notes = new List<Note>();

        /// <summary>
        /// Свойство для работы с полем _notes
        /// </summary>
        public List<Note> Notes
        {
            get => _notes;
            set
            {
                _notes = value;
            }
        }        
    }
}
