Console.WriteLine("Введите число для проверки на соответствие");
string? inpVal = Console.ReadLine();
byte byteVal = 0;
if (byte.TryParse(inpVal, out byteVal))
{
    Console.WriteLine($"Ваше число в byte: {inpVal}");
}
else
{
    Console.WriteLine($"Для приведения числа  {inpVal} к типу byte число не может быть больше {byte.MaxValue} и меньше { byte.MinValue}");
}
sbyte sbyteVal = 0;
if (sbyte.TryParse(inpVal, out sbyteVal))
{
    Console.WriteLine($"Ваше число в sbyte: {inpVal}");
}
else
{
    Console.WriteLine($"Для приведения числа  {inpVal} к типу sbyte число не может быть больше {sbyte.MaxValue} и меньше {sbyte.MinValue}");
}
short shortVal = 0;
if (short.TryParse(inpVal, out shortVal))
{
    Console.WriteLine($"Ваше число в short: {inpVal}");
}
else
{
    Console.WriteLine($"Для приведения числа  {inpVal} к типу short число не может быть больше {short.MaxValue} и меньше {short.MinValue}");
}
ushort ushortVal = 0;
if (ushort.TryParse(inpVal, out ushortVal))
{
    Console.WriteLine($"Ваше число в ushort: {inpVal}");
}
else
{
    Console.WriteLine($"Для приведения числа  {inpVal} к типу ushort число не может быть больше {ushort.MaxValue} и меньше {ushort.MinValue}");
}
int intVal = 0;
if (int.TryParse(inpVal, out intVal))
{
    Console.WriteLine($"Ваше число в int: {inpVal}");
}
else
{
    Console.WriteLine($"Для приведения числа  {inpVal} к типу int число не может быть больше {int.MaxValue} и меньше {int.MinValue}");
}
uint uintVal = 0;
if (uint.TryParse(inpVal, out uintVal))
{
    Console.WriteLine($"Ваше число в uint: {inpVal}");
}
else
{
    Console.WriteLine($"Для приведения числа  {inpVal} к типу uint число не может быть больше {uint.MaxValue} и меньше {uint.MinValue}");
}
long longVal = 0;
if (long.TryParse(inpVal, out longVal))
{
    Console.WriteLine($"Ваше число в long: {inpVal}");
}
else
{
    Console.WriteLine($"Для приведения числа  {inpVal} к типу long число не может быть больше {long.MaxValue} и меньше {long.MinValue}");
}
ulong ulongVal = 0;
if (ulong.TryParse(inpVal, out ulongVal))
{
    Console.WriteLine($"Ваше число в ulong: {inpVal}");
}
else
{
    Console.WriteLine($"Для приведения числа  {inpVal} к типу ulong число не может быть больше {ulong.MaxValue} и меньше {ulong.MinValue}");
}
