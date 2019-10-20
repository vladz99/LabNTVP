using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteApp
{
public class Note
    {
        private string _name;
        public string GetName()
        {
            return _name;
        }
        public void SetName(string name)
        {
            if (name.Length < 50)
            {
                throw new ArgumentException("Название должно быть меньше 50 символов, а было " + name);
            }
            else
                _name = name;
        }

        private string category_notes;
        private string text_notes;
        private readonly int creation_time = 1;
        private int last_modified_time;

        enum Notes_category
        {
            work,
            house,
            health_and_sport,
            people,
            documentation,
            finance,
            miscellanea
        }
    }
}