using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaHelper.Core
{
    /// <summary>
    /// Класс фильма. 
    /// >>Здесь представлен так называемый Primary конструктор(Доступен с .NET8) 
    /// с необязательным параметром title<<
    /// </summary>
    /// <param name="id">Уникальный идентификатор фильма</param>
    /// <param name="title">Название фильма</param>
    public class Cinema(int id, string title="Some cinema")
    {
        ///// <summary>
        ///// Обычный конструктор, до .NET8. В новых версиях доступны оба варианта
        ///// </summary>
        ///// <param name="id"></param>
        ///// <param name="title"></param>
        //public Cinema(int id, string title)
        //{
        //    Id = id; 
        //    Title = title;
        //}

        public int Id { get; set; } = id;

        public string Title { get; set; } = title;

        
        public override string ToString()
        {
            return Id+"|"+Title;
        }
    }
}
