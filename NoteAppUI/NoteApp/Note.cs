﻿using System;
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
        private DateTime _creationTime = DateTime.Today;

        /// <summary>
        /// Дата последней модификации заметки
        /// </summary>
        private DateTime _lastModifiedTime;

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
                    _name = value ;
            }
        }

        /// <summary>
        /// Возвращает и задает категорию заметки 
        /// </summary>
        public NoteCategory CategoryNotes { get; set; }

        /// <summary>
        /// Возвращает и задает текст заметки 
        /// </summary>
        public string TextNotes { get; set; }

        /// <summary>
        /// Возвращает время создания заметки 
        /// </summary>
        public DateTime CreationTime { get; set; }

        /// <summary>
        /// Возвращает и задает время последнего изменения 
        /// </summary>
        public DateTime LastModifiedTime
        {
            get
            { return _lastModifiedTime; }
            set
            {
                //if(value > DateTime.Now)
                //{
                //    throw new ArgumentException("Дата последнего изменения больше сегодняшней даты");
                //}
                //if (value < CreationTime)
                //{
                //    throw new ArgumentException("Дата последнего изменения меньше даты создания");
                //}                
                _lastModifiedTime = value;
            }
        }
    }
}