
// Задача1
// void Rut(int num1, int num2)
//         {
//             Console.Write(" " + num1);
//             if (num1 < num2) Rut(num1 + 1, num2);
//         }
//         Rut(4, 8);

// Задача 2

// Console.Write("Введите значение M: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите значение N: ");
// int n = Convert.ToInt32(Console.ReadLine());

// int akkerman(int m, int n)
// {
// if (m == 0) return n + 1;
// else if (n == 0) return akkerman(m -1, 1);
// else return akkerman(m -1, akkerman(m, n -1));
// }

// Console.Write($"Функция Аккермана равно {akkerman(m, n)} ");

// Задача 3

static void PrintArray(int [] array, int size)
{
    if (size == 0);
    {
        System.Console.WriteLine(array[size]);
        PrintArray(array,size-1);
    }
}
int[] array = {1,5,6,7,9};
PrintArray(array);
