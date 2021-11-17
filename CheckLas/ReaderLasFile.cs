using System.Collections.Generic;
using GIS.Core;

namespace CheckLas
{
    /// <summary>
    /// класс для проверки качества las - файла
    /// </summary>
    public class ReaderLasFile
    {
        /// <summary>
        /// проверка качества las-файла 
        /// </summary>
        /// <param name="pathLasFile">путь к файлу</param>
        /// <returns>массив в кодами ошибок</returns>
        public Dictionary<LasReader.Errors, object> Reader(string pathLasFile)
        {
            Dictionary<LasReader.Errors, object> error = new Dictionary<LasReader.Errors, object>();
            LasReader reader = new LasReader();
            reader.Read(pathLasFile, ref error);
            return error;
        }
    }
}
