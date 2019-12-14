using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NoteApp;

namespace NoteApp.UnitTests
{
    [TestFixture]
    class ProgectTest
    {
        [Test(Description = "Тест Note: Возвращение списка всех заметок")]
        public void TestNoteGet_CorrectValue()
        {
            var expected = new List<Note>();
            var note = new Note
            {
                Name = "Название заметки",
                CategoryNotes = NoteCategory.Work,
                TextNotes = "Текст заметки",
                CreationTime = DateTime.Now,
                LastModifiedTime = DateTime.Now
            };
            expected.Add(note);

            var project = new Project();
            project.Notes.Add(note);
            var actual = project.Notes;

            Assert.AreEqual(expected[0].Name, actual[0].Name);
            Assert.AreEqual(expected[0].CategoryNotes, actual[0].CategoryNotes);
            Assert.AreEqual(expected[0].TextNotes, actual[0].TextNotes);
            Assert.AreEqual(expected[0].CreationTime, actual[0].CreationTime);
            Assert.AreEqual(expected[0].LastModifiedTime, actual[0].LastModifiedTime);
        }
    }
}
