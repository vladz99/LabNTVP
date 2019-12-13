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
        /// <summary>
        /// Название заметки
        /// </summary>
        private string _name = "Без Названия";

        /// <summary>
        /// Категории заметок
        /// </summary>
        private NoteCategory _categoryNotes;

        /// <summary>
        /// Текст заметок
        /// </summary>
        private string _textNotes;

        /// <summary>
        /// Дата создания заметки
        /// </summary>
        private DateTime _creationTime;

        /// <summary>
        /// Дата последней модификации заметки
        /// </summary>
        private DateTime _lastModifiedTime;

        public Note()
        {
            _creationTime = DateTime.Now;
            _lastModifiedTime = DateTime.Now;
        }

        /// <summary>
        /// Возвращает и задает название заметки 
        /// </summary>
        public string Name
        {
            get { return _name; }
            set
            {
                if (value.Length > 50)
                {
                    throw new ArgumentException("Название должно быть меньше 50 символов, а было " + value);
                }
                else if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Название заметки не может быть null!");
                }
                else
                {
                    _name = value;
                    _lastModifiedTime = DateTime.Now;
                }
            }
        }

        /// <summary>
        /// Возвращает и задает категорию заметки 
        /// </summary>
        public NoteCategory CategoryNotes
        {
            get
            {
                return _categoryNotes;
            }
            set
            {
                _categoryNotes = value;
                _lastModifiedTime = DateTime.Now;
            }
        }

        /// <summary>
        /// Возвращает и задает текст заметки 
        /// </summary>
        public string TextNotes
        {
            get
            {
                return _textNotes;
            }
            set
            {
                _textNotes = value;
                _lastModifiedTime = DateTime.Now;
            }
        }   

        /// <summary>
        /// Возвращает время создания заметки 
        /// </summary>
        public DateTime CreationTime
        {
            get
            {
                return _creationTime;
            }
            set
            {
                _creationTime = DateTime.Now;
            }

        }
        /// <summary>
        /// Возвращает и задает время последнего изменения 
        /// </summary>
        public DateTime LastModifiedTime
        {
            get
            {
                return _lastModifiedTime;
            }
            set
            {
                _lastModifiedTime = value;
                _lastModifiedTime = DateTime.Now;
            }
        }
    }
}