using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CinemaHelper.Core.Utility;

namespace CinemaHelper.Core.Data
{
    /// <summary>
    /// Класс для доступа к данным о фильмах
    /// </summary>
    public class CinemaDataSource
    {
        /// <summary>
        /// Относительный путь к файлу, где хранятся данные
        /// </summary>
        private readonly string path = ".\\cinema_data.json";

        /// <summary>
        /// Метод чтения данных в формате JSON 
        /// и их десериализация
        /// </summary>
        /// <returns></returns>
        public List<Cinema> Get()
        {
            if (File.Exists(path))
            {
                string data = File.ReadAllText(path);
                return DataSerializer.Deserialize<List<Cinema>>(data);
            }
            return null;
        }

        /// <summary>
        /// Метод записи данных в формате JSON 
        /// и их десериализация
        /// </summary>
        /// <returns></returns>
        public void Write(List<Cinema> data)
        {
            File.WriteAllText(path, DataSerializer.Serialize(data));
        }
    }
}
