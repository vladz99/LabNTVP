using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NoteApp;
using NUnit.Framework;

namespace NoteApp.UnitTests
{
    [TestFixture]
    public class NoteTest
    {
        [Test(Description = "Позитивный тест геттера Name")]
        public void TestNameGet_CorrectValue()
        {
            var expected = "Название заметки";
            var note = new Note
            {
                Name = expected
            };
            var actual = note.Name;

            Assert.AreEqual(expected, actual, "Геттер Name возвращает неправильное название заметки");
        }


        [TestCase("111111111111111111111111111111111111111111111111111111111111",
           "Должно возникать исключение, если название заметки больше 50 символов",
           TestName = "Негативный тест сеттера Name: название заметки больше 50 символов")]
        [TestCase("", "Должно возникать исключение, если название заметки равно null",
           TestName = "Негативный тест сеттера Name: название заметки равно null")]
        public void TestNameSet_ArgumentExeption(string wrongTitle, string message)
        {
            var note = new Note();

            Assert.Throws<ArgumentException>(
            () => { note.Name = wrongTitle; },
            message);
        }

        [Test(Description = "Позитивный тест геттера CategoryNotes")]
        public void TestCategoryNotesGet_CorrectValue()
        {
            var expected = NoteCategory.House;
            var note = new Note
            {
                CategoryNotes = expected
            };
            var actual = note.CategoryNotes;

            Assert.AreEqual(expected, actual, "Геттер CategoryNotes возвращает неправильную категорию заметки");
        }

        [Test(Description = "Позитивный тест геттера TextNotes")]
        public void TestTextNotesGet_CorrectValue()
        {
            var expected = "Текст заметки";
            var note = new Note
            {
                TextNotes = expected
            };
            var actual = note.TextNotes;

            Assert.AreEqual(expected, actual, "Геттер TextNotes возвращает неправильный текст заметки");
        }

        [Test(Description = "Позитивный тест геттера CreationTime")]
        public void TestCreationTimeGet_CorrectValue()
        {
            var dateNow = DateTime.Now;
            var note = new Note();
            var actual = note.CreationTime;

            Assert.AreEqual(dateNow, actual, "Геттер CreationTime возвращает неправильую дату создания заметки");
        }

        [Test(Description = "Позитивный тест геттера LastModifiedTime")]
        public void TestLastModifiedTimeGet_CorrectValue()
        {
            var dateNow = DateTime.Now;
            var note = new Note
            {
                LastModifiedTime = dateNow
            };
            var expected = note.LastModifiedTime;
            var actual = note.LastModifiedTime;

            Assert.AreEqual(expected, actual, "Геттер LastModifiedTime возвращает неправильную дату редактирования");
        }
    }
}
