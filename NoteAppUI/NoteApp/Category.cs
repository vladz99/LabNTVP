using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteApp
{
    /// <summary>
    /// Перечисление категорий заметок
    /// </summary>

    //Сделать all - сортировка по умолчанию
    public enum NoteCategory
    {
        All,
        Work,
        House,
        HealthAndSport,
        People,
        Documentation,
        Finance,
        Miscellanea
    }
}
