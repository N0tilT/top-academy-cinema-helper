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
                var tmp = DataSerializer.Deserialize<List<Cinema>>(data) ?? [];
                Cinema._id_counter = tmp.Count > 0 ? tmp.Select(x => x.ItemId).Max() + 1 : 0;
                return tmp;
            }
            return [];
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
