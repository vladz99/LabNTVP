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
        private Notes _categoryNotes;
        private string _textNotes;
        private DateTime _creationTime = DateTime.Now;
        private DateTime _lastModifiedTime;
        public string Name
        {
            get { return _name; }
            set
            {
                if (value.Length > 50)
                {
                    throw new ArgumentException("Название должно быть меньше 50 символов, а было " + value);
                }
                    _name = value ;
            }
        }

        public Notes CategoryNotes { get; set; }

        public string TextNotes { get; set; }

        public DateTime CreationTime { get; set; }

        public DateTime LastModifiedTime
        {
            get
            { return _lastModifiedTime; }
            set
            {
                if(value > DateTime.Now)
                {
                    throw new ArgumentException("Дата последнего изменения больше сегодняшней даты");
                }
                if (value < CreationTime)
                {
                    throw new ArgumentException("Дата последнего изменения меньше даты создания");
                }
                else
                    _lastModifiedTime = value;

            }
        }
    }
}