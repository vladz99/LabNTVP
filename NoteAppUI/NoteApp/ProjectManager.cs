using System;
using System.IO;
using Newtonsoft.Json;

namespace NoteApp
{
    /// <summary>
    /// Класс, реализующий сохранение в файл и загрузку из файла.
    /// </summary>
    public static class ProjectManager
    {

        /// <summary>
        /// Хранит путь до файла.
        /// </summary>
        private static readonly string _pathToFile = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) +
        @"\NoteApp.notes";

        /// <summary>
        /// Сохраняет проект в файл.
        /// </summary>
        /// 
        public static void SaveToFile(Project data)
        {
            var serializer = new JsonSerializer { Formatting = Formatting.Indented };
            using (var sw = new StreamWriter(_pathToFile))
            using (JsonWriter writer = new JsonTextWriter(sw))
            {
                serializer.Serialize(writer, data);
            }
        }

        /// <summary>
        /// Загружает проект из файла.
        /// </summary>
        public static Project LoadToFile()
        {
            Project project = null;
            var serializer = new JsonSerializer { Formatting = Formatting.Indented };
            using (var sr = new StreamReader(_pathToFile))
            using (JsonReader reader = new JsonTextReader(sr))
            {
                project = serializer.Deserialize<Project>(reader);
            }

            return project;
        }
    }
}