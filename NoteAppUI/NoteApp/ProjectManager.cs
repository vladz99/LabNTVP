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
        "\\My Documents\\NoteApp.notes";

        /// <summary>
        /// Сохраняет объект проекта в файл.
        /// </summary>
        /// 
        public static void SaveFile(Project data, string filename)
        {
            File.WriteAllText(_pathToFile, JsonConvert.SerializeObject(data));
        }

        /// <summary>
        /// Загружает объект проекта из файла.
        /// </summary>
        public static Project LoadFile(string filename)
        {
            Project project;
            string data;

            try
            {
                data = File.ReadAllText(_pathToFile);
            }
            catch (DirectoryNotFoundException no)
            {
                throw no;
            }

            catch (FileNotFoundException no)
            {
                throw no;
            }

            project = JsonConvert.DeserializeObject<Project>(data);

            return project;
        }
    }
}