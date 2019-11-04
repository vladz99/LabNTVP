using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteApp
{
    /// <summary>
    /// Список List
    /// </summary>
    public class Project
    {
        private List<Note> _listNotes = new List<Note>();
        public List<Note> ListNote
        {
            get
            {
                return _listNotes;
            }
            set
            {
                _listNotes = value;
            }
        }
    }
}
