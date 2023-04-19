//Кукушкин Егор 10 вариант
dynamic Смена = new System.Dynamic.ExpandoObject();
Console.WriteLine("смена: ");
Console.WriteLine("название: ");
Смена.название = Console.ReadLine();

Console.WriteLine($"Название - {Смена.название}");

dynamic Сотрудник = new System.Dynamic.ExpandoObject();
Console.WriteLine("сотрудник: ");
Console.WriteLine("Фамилия: ");
Сотрудник.Фамилия = Console.ReadLine();
Console.WriteLine("Имя: ");
Сотрудник.Имя = Console.ReadLine();
Console.WriteLine("Отчество: ");
Сотрудник.Отчество = Console.ReadLine();
Console.WriteLine("Руководитель: ");
Сотрудник.Руководитель = Console.ReadLine();

Console.WriteLine($"Фамилия - {Сотрудник.Фамилия}, имя - {Сотрудник.Имя}, отчество - {Сотрудник.Отчество}, руководитель - {Сотрудник.Руководитель}");

dynamic Должность = new System.Dynamic.ExpandoObject();
Console.WriteLine("должность: ");
Console.WriteLine("Название: ");
Должность.Название = Console.ReadLine();
Console.WriteLine("Оклад: ");
Должность.Оклад = Console.ReadLine();
Console.WriteLine("Подразделение: ");
Должность.Подразделение = Console.ReadLine();

Console.WriteLine($"Название - {Должность.Название}, оклад - {Должность.Оклад}, подразделение - {Должность.Подразделение}");

dynamic Подразделение = new System.Dynamic.ExpandoObject();
Console.WriteLine("Подразделение: ");
Console.WriteLine("Название: ");
Подразделение.Название = Console.ReadLine();
Console.WriteLine("Руководитель: ");
Подразделение.Руководитель = Console.ReadLine();
Console.WriteLine("Организация: ");
Подразделение.Организация = Console.ReadLine();

Console.WriteLine($"Название - {Подразделение.Название}, руководитель - {Подразделение.Руководитель}, организация - {Подразделение.Организация}");