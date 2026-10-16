PrintHeader();
PrintHeader();
Console.WriteLine("Основная часть программы");
PrintFooter();

void PrintHeader()
{
    Console.WriteLine("^_^");
    Console.WriteLine("Лабораторная работа №13");
    Console.WriteLine("0_0");
    Console.WriteLine("Дата формирования отчета: 16.10.2026, 12:43");
}
void PrintFooter()
{
    Console.WriteLine(">_<");
    Console.WriteLine("Конец программы");
    Console.WriteLine("X_X");
}

void PrintStudentCard(string name, string groupName, int age)
{
    Console.WriteLine($"Студент: {name}, Номер группы: {groupName}, Возраст: {age}");
}
PrintStudentCard("Егор", "РУПО265", 18);
PrintStudentCard("Валерия", "РУПО253", 17);
