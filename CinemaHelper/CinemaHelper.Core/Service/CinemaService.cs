using CinemaHelper.Core.Data;

namespace CinemaHelper.Core.Service
{
    /// <summary>
    /// Класс, осуществляющий работу с фильмами 
    /// </summary>
    public class CinemaService
    {
        private CinemaDataSource _dataSource;
        private List<Cinema> _cinemas = new List<Cinema>();
        public CinemaService(CinemaDataSource dataSource)
        {
            _dataSource = dataSource;
            _cinemas = _dataSource.Get();
        }
        /// <summary>
        /// Получить все фильмы
        /// </summary>
        /// <returns></returns>
        public List<Cinema> GetAll()
        {
            return _cinemas;
        }
        /// <summary>
        /// Получить фильм по идентификатору
        /// </summary>
        /// <param name="id">Идентификатор фильма</param>
        /// <returns>null в случае, если фильм не найден</returns>
        public Cinema Get(int id)
        {
            foreach (Cinema cinema in _cinemas)
                if (cinema.ItemId == id)
                    return cinema;
            return null;
        }
        /// <summary>
        /// Добавить новый фильм
        /// </summary>
        /// <param name="cinema"></param>
        public void Create(Cinema cinema)
        {
            _cinemas.Add(cinema);
            _dataSource.Write(_cinemas);
        }
        /// <summary>
        /// Удалить фильм по идентификатору
        /// </summary>
        /// <param name="id"></param>
        public void Delete(int id)
        {
            foreach (Cinema cinema in _cinemas)
                if (cinema.ItemId == id)
                {
                    _cinemas.Remove(cinema);
                    break;
                }
            _dataSource.Write(_cinemas);
        }
        /// <summary>
        /// Обновить фильм
        /// </summary>
        /// <param name="cinema"></param>
        public void Update(Cinema cinema)
        {
            for (int i = 0; i < _cinemas.Count; i++)
                if (cinema.ItemId == _cinemas[i].ItemId)
                    _cinemas[i] = cinema;
            _dataSource.Write(_cinemas);
        }

    }
}
