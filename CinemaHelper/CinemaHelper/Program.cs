// Сценарий: Добавление нового фильма, изменение его параметров, удаление фильма
using CinemaHelper.Core.Service;
using CinemaHelper.Core.Data;
using CinemaHelper.Core;

CinemaService dataService = new CinemaService(new CinemaDataSource());

Console.WriteLine("Start");
Console.WriteLine(string.Join("\n",dataService.GetAll()));
dataService.Create(new Cinema(0, "Интерстеллар"));
Console.WriteLine("Added Интерстеллар");
Console.WriteLine(string.Join("\n", dataService.GetAll()));

dataService.Create(new Cinema(1,"Вверх"));
Console.WriteLine("Added Вверх");
Console.WriteLine(string.Join("\n", dataService.GetAll()));

dataService.Update(new Cinema(0, "Пираты"));
Console.WriteLine("Changed Интерстеллар to Пираты");
Console.WriteLine(string.Join("\n", dataService.GetAll()));

dataService.Delete(1);
Console.WriteLine("Deleted Вверх");
Console.WriteLine(string.Join("\n", dataService.GetAll()));

dataService.Delete(0);
Console.WriteLine("Deleted Интерстеллар");
Console.WriteLine(string.Join("\n", dataService.GetAll()));
