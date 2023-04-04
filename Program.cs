
Console.WriteLine("Hello, World!");


string massage = "Tipi: {0,8} |.NET da nomi: {1,8} | O'lchami = {2} | MIN = {3,30}\t  |  MAX = {4}";

Console.Title = "C# dasturlash tilida ma'lumotlar turlari";

Console.WriteLine("\n\t\t\t Sonlar (butun sonlar) turlari: \n");

Console.WriteLine(string.Format(massage,"byte", typeof(byte).Name, sizeof(byte), byte.MinValue, byte.MaxValue));

Console.WriteLine(string.Format(massage,"sbyte", typeof(sbyte).Name, sizeof(sbyte), sbyte.MinValue, sbyte.MaxValue));

Console.WriteLine(string.Format(massage,"short", typeof(short).Name, sizeof(short), short.MinValue, short.MaxValue));

Console.WriteLine(string.Format(massage,"ushort", typeof(ushort).Name, sizeof(ushort), ushort.MinValue, ushort.MaxValue));

Console.WriteLine(string.Format(massage,"int", typeof(int).Name, sizeof(int), int.MinValue, int.MaxValue));

Console.WriteLine(string.Format(massage,"uint", typeof(uint).Name, sizeof(uint), uint.MinValue, uint.MaxValue));

Console.WriteLine(string.Format(massage,"long", typeof(long).Name, sizeof(long), long.MinValue, long.MaxValue));

Console.WriteLine(string.Format(massage,"ulong", typeof(ulong).Name, sizeof(ulong), ulong.MinValue, ulong.MaxValue));

Console.WriteLine("\n\t\t\t Sonlar (qabul qilish oraliqlari malumotlari) turlari: \n");

Console.WriteLine(string.Format(massage,"float", typeof(float).Name, sizeof(float), float.MinValue, float.MaxValue));

Console.WriteLine(string.Format(massage,"double", typeof(double).Name, sizeof(double), double.MinValue, double.MaxValue));

Console.WriteLine(string.Format(massage,"decimal", typeof(decimal).Name, sizeof(decimal), decimal.MinValue, decimal.MaxValue));