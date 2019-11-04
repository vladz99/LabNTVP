using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteApp
{
    /// <summary>
    /// Класс хранящий информацию о заметках, такие как: Имя, категория, текст, 
    /// время создания, последнее время редактирования
    /// </summary>
public class Note
    {
        private string _name = "Без Названия";
        public string GetName()
        {
            return _name;
        }
        public void SetName(string name)
        {
            if (name.Length > 50)
            {
                throw new ArgumentException("Название должно быть меньше 50 символов, а было " + name);
            }
            else
                _name = name;
        }

        private string category_notes;
        private string text_notes;
        //private DateTime creation_time = DateTime.Now;
        //private DateTime last_modified_time;

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