using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using NoteApp;
using NUnit.Framework;

namespace NoteApp.UnitTests
{
    [TestFixture]
    class ProjectManagerTest
    {
        [Test(Description = "Тест сериализации")]
        public void TestSaveToFile_CorrectValue()
        {
            var list = new List<Note>();
            var note1 = new Note
            {
                Name = "Название заметки 1",
                CategoryNotes = NoteCategory.Work,
                TextNotes = "Текст заметки 1",
                CreationTime = new DateTime(2019, 11, 5),
                LastModifiedTime = new DateTime(2019, 12, 1)
            };
            list.Add(note1);

            var note2 = new Note
            {
                Name = "Название заметки 2",
                CategoryNotes = NoteCategory.Miscellanea,
                TextNotes = "Текст заметки 2",
                CreationTime = new DateTime(2019, 12, 2),
                LastModifiedTime = new DateTime(2019, 12, 2)
            };
            list.Add(note2);

            var project = new Project();
            project.Notes.Add(note1);
            project.Notes.Add(note2);

            string name1 = @"\expected.json";
            string path = Assembly.GetExecutingAssembly().Location;
            string ppath = Path.GetDirectoryName(path);
            string file1 = ppath + name1;
            string name2 = @"\example.json";
            string file2 = ppath + name2;

            ProjectManager.SaveToFile(project, file2);

            var expected = File.ReadAllText(file1);
            var actual = File.ReadAllText(file2);

            Assert.AreEqual(actual, expected);
        }

        [Test(Description = "Тест десериализации")]
        public void TestLoadFromFile_CorrectValue()
        {
            var list = new List<Note>();
            var note1 = new Note();
            note1.Name = "Название заметки 1";
            note1.CategoryNotes = NoteCategory.Work;
            note1.TextNotes = "Текст заметки 1";
            note1.CreationTime = new DateTime(2019, 11, 5);
            note1.LastModifiedTime = new DateTime(2019, 12, 1);
            list.Add(note1);            

            var note2 = new Note();
            note2.Name = "Название заметки 2";
            note2.CategoryNotes = NoteCategory.Miscellanea;
            note2.TextNotes = "Текст заметки 2";
            note2.CreationTime = new DateTime(2019, 12, 2);
            note2.LastModifiedTime = new DateTime(2019, 12, 2);
            list.Add(note2);

            var project = new Project();
            project.Notes.Add(note1);
            project.Notes.Add(note2);
            var actual = project.Notes;

            string name = @"\example.json";
            string path = Assembly.GetExecutingAssembly().Location;
            string ppath = Path.GetDirectoryName(path);
            string file = ppath + name;


            var expected = ProjectManager.LoadToFile(file);
                        
            for (int i = 0; i < actual.Count; i++)
            {                
                Assert.AreEqual(actual[i].Name, expected.Notes[i].Name);
                Assert.AreEqual(actual[i].TextNotes, expected.Notes[i].TextNotes);
                Assert.AreEqual(actual[i].LastModifiedTime, expected.Notes[i].LastModifiedTime);
                Assert.AreEqual(actual[i].CreationTime, expected.Notes[i].CreationTime);
                Assert.AreEqual(actual[i].CategoryNotes, expected.Notes[i].CategoryNotes);
            }
        }
    }
}
