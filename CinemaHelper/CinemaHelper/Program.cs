// Сценарий: Добавление нового фильма, изменение его параметров, удаление фильма
using CinemaHelper.Core;
using CinemaHelper.Core.Data;
using CinemaHelper.Core.Service;

CinemaService dataService = new CinemaService(new CinemaDataSource());

Console.WriteLine("Start");
Console.WriteLine(string.Join("\n", dataService.GetAll()));
dataService.Create(new Cinema("Интерстеллар"));
Console.WriteLine("Added Интерстеллар");
Console.WriteLine(string.Join("\n", dataService.GetAll()));

Cinema tmp = new Cinema("Вверх");
dataService.Create(tmp);
Console.WriteLine("Added Вверх");
Console.WriteLine(string.Join("\n", dataService.GetAll()));

Cinema tmp2 = new Cinema("Пираты");
dataService.Update(tmp2);
Console.WriteLine("Changed Интерстеллар to Пираты");
Console.WriteLine(string.Join("\n", dataService.GetAll()));

dataService.Delete(tmp.ItemId);
Console.WriteLine("Deleted Вверх");
Console.WriteLine(string.Join("\n", dataService.GetAll()));

dataService.Delete(tmp2.ItemId);
Console.WriteLine("Deleted Интерстеллар");
Console.WriteLine(string.Join("\n", dataService.GetAll()));
