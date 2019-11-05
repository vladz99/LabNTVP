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
        private static readonly string _pathToFile = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) +
        "\\NoteApp.notes";

        /// <summary>
        /// Сохраняет проект в файл.
        /// </summary>
        /// 
        public static void SaveToFile(Project data, string filename)
        {
            File.WriteAllText(_pathToFile, JsonConvert.SerializeObject(data));
        }

        /// <summary>
        /// Загружает проект из файла.
        /// </summary>
        public static Project LoadToFile(string filename)
        {
            Project project;
            string data;

            try
            {
                data = File.ReadAllText(_pathToFile);
            }
            catch (DirectoryNotFoundException Exception)
            {
                throw Exception;
            }

            catch (FileNotFoundException Exception)
            {
                throw Exception;
            }

            project = JsonConvert.DeserializeObject<Project>(data);

            return project;
        }
    }
}