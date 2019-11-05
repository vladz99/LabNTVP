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
        private List<Note> Note = new List<Note>();
        public List<Note> Notes
        {
            get
            {
                return Note;
            }
            set
            {
                Note = value;
            }
        }
    }
}
