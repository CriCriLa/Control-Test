// Задача: Написать программу, которая из имеющегося массива строк 
// формирует новый массив из строк, длина которых меньше, либо равна 
// 3 символам. Первоначальный массив можно ввести с клавиатуры, либо 
// задать на старте выполнения алгоритма. При решении не рекомендуется 
// пользоваться коллекциями, лучше обойтись исключительно массивами.

Console.Clear();

string[] firstArray = {"Hello", "2", "world", ":-)"} ;

int lengthStrMax = 3;


bool CheckLength (string newString)
{
    return newString.Length <= lengthStrMax;
}

int GetLengthNewArray ()
{
    int newArrayLength = 0;
    for (int i = 0; i < firstArray.Length; i++)
    {
        if (firstArray[i].Length <= lengthStrMax) newArrayLength ++;
    }
    return newArrayLength;
} 

string[] newArray = new string[GetLengthNewArray()];

void FillNewArray ()
{
    int count = 0;
    for (int i=0; i < firstArray.Length; i++)
    {
        if (CheckLength(firstArray[i]))
        {
            newArray[count] = firstArray[i];
            count++;
        }
    }
}
FillNewArray();
Console.Write ("Новый массив: ");
for (int i =0; i<newArray.Length; i++ )
{
    Console.Write($"'{newArray[i]}' ");
}
Console.WriteLine();




