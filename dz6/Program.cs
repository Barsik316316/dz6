int[] originalArray = { 10, 20, 30, 40, 50 };

Console.Write("Исходный массив: ");
for (int a = 0; a < originalArray.Length; a++)
{
    Console.WriteLine(originalArray[a] + " ");
}
Console.WriteLine(); 

int[] reversedArray = new int[originalArray.Length];

for (int a = 0; a < originalArray.Length; a++)
{
    reversedArray[a] = originalArray[originalArray.Length - 1 - a];
}

Console.WriteLine("Перевернутый массив: ");
for (int a = 0; a < reversedArray.Length; a++)
{
    Console.Write(reversedArray[a] + " ");
}

Console.ReadLine(); 

