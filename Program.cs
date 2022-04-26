using System;
using System.Linq;

namespace Домашка4
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine($"Space - Выйти!\nEnter - Продолжить!");

                string userspace = Console.ReadLine();
                if (userspace == " ")
                {
                    break;
                }

                int action;
                Console.WriteLine($"Выберите задание!\n" +
                    "\nЗадание 1)Случайная матрица." +
                    "\nЗадание 2)Наименьший элемент в последовательности" +
                    "\nЗадание 3)Игра «Угадай число»");                

                action = int.Parse(Console.ReadLine());                

                switch (action)
                {
                    #region case1
                    case 1:
                        Console.Clear();
                        Console.WriteLine($"Введите Количество Строк!");
                        int lines = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine($"Введите Количество Столбцов!");
                        int collumns = Convert.ToInt32(Console.ReadLine());

                        int[,] matrix = new int[lines, collumns];

                        int summ = 0;
                        int sourceArrayCounter = 0;
                        int sumCounter = 0;

                        Random random = new Random();
                        Console.WriteLine("Исходный Массив:");
                        for (int i = 0; i < lines; i++)
                        {
                            for (int j = 0; j < collumns; j++)
                            {
                                sourceArrayCounter++;
                                matrix[i, j] = random.Next(0, 11);
                                Console.Write($"{sourceArrayCounter}){matrix[i, j]}+\t");
                            }
                            Console.WriteLine();
                        }

                        Console.WriteLine();

                        for (int i = 0; i < matrix.GetLength(0); i++)
                        {
                            for (int j = 0; j < matrix.GetLength(1); j++)
                            {
                                sumCounter++;
                                summ += matrix[i, j];
                                Console.Write($"{sumCounter})Сумма: {summ}\t");
                            }

                            Console.WriteLine();
                        }
                        Console.WriteLine();
                        break;
                    #endregion
                    #region case2
                    case 2:
                        Console.Clear();
                        int minValue = 0;
                        int maxValue = 0;
                        //Random randomize = new Random();
                        Console.WriteLine($"Введите длину последовательности!");
                        int lenght = int.Parse(Console.ReadLine());
                        int[] arrayNumbs = new int[lenght];                        

                        for (int i = 0; i < arrayNumbs.Length; i++)
                        {   
                            Console.WriteLine($"Введите {i + 1} число!");
                            int enteredNumbers = int.Parse(Console.ReadLine());

                            arrayNumbs[i] = enteredNumbers;
                        }
                        Console.WriteLine($"{arrayNumbs[lenght - 1]}");                      

                        Console.WriteLine($"\nСортированный Массив");
                        Array.Sort(arrayNumbs);

                        for (int i = 0; i < arrayNumbs.Length; i++)
                        {                            
                            Console.Write($"{arrayNumbs[i]}");                            
                        }

                        Console.WriteLine($"\nОбратный Порядок");
                        Array.Reverse(arrayNumbs);
                        for (int i = 0; i < arrayNumbs.Length; i++)
                        {
                            Console.Write($"{arrayNumbs[i]}");

                        }
                        for (int i = 0; i < arrayNumbs.Length - 1; i++)
                        {
                            minValue = arrayNumbs[i];

                            if (arrayNumbs[i] < minValue)
                            {
                                minValue = arrayNumbs[i];
                            }
                            if (arrayNumbs[i] > maxValue)
                            {
                                maxValue = arrayNumbs[i];
                            }
                            //Array.IndexOf(arrayNumbs);
                            //Array.LastIndexOf(arrayNumbs);
                        }
                        Console.WriteLine($"\nМинимальное значние{minValue}");
                        Console.WriteLine($"Максимальное значение{maxValue}");




                        /*Random random1 = new Random();               //Выше введенного числа 10 - программа крашется?!
                        Console.WriteLine($"Enter the number!");
                        int n = int.Parse(Console.ReadLine());
                        int[] numbs = new int[n];

                        Console.WriteLine($"\nИсходный массив");

                        for (int i = 0; i < numbs.Length; i++)
                        {
                            numbs[i] = random1.Next(0,2);
                            Console.Write($"{numbs[i]}");
                        }

                        int head = 0;
                        int tail = numbs.Length - 1;

                        bool flag = true;

                        while (head < tail)
                        {
                            if (flag)
                            {
                                if (numbs[head] == 1)
                                {
                                    flag = false;
                                }
                                else
                                {
                                    head++;
                                }
                            }
                            else
                            {
                                if (numbs[tail] == 0)
                                {
                                    flag = false;
                                }
                                else
                                {
                                    tail--;
                                }                                        
                            }

                            if (numbs[head]==1 && numbs[tail]==0)
                            {
                                int temp = numbs[head];
                                numbs[head] = numbs[tail];
                                numbs[tail] = temp;

                                head++;
                                tail--;
                            }
                        }

                        Console.WriteLine($"\nПолучившийся Массив");

                        for (int i = 0; i < numbs.Length; i++)
                        {
                            Console.Write($"{numbs[i]}");
                        }*/
                        break;
                    #endregion
                    #region Case3
                    case 3:
                        Console.WriteLine($"Введите Макссимальное целое число, из которого будет угадывать загаданное число!");
                        int userMaxNumber = Convert.ToInt32(Console.ReadLine());
                        Random randomNumber = new Random();
                        int iiNumber = randomNumber.Next(0, userMaxNumber);
                        int counter = 0;

                        Console.WriteLine($"Попробуйте угадать загаданное число!");

                        
                        while (true)
                        {                            
                            counter++;

                            string userInput = Console.ReadLine();
                            if (userInput == " ")
                            {
                                break;
                            }
                            int userNumber = Convert.ToInt32(userInput);
                            Console.Clear();
                            
                            if (iiNumber > userNumber)
                            {
                                Console.WriteLine($"Загаданное число больше, чем - {userInput}");
                            }
                            else if (iiNumber < userNumber)
                            {
                                Console.WriteLine($"Загаданное число меньше, чем - {userInput}");
                            }
                            else if(iiNumber == userNumber)
                            {
                                Console.WriteLine($"Вы угадали! \nВаш ответ = {userInput}");
                                Console.WriteLine($"Число попыток = {counter}" +
                                    $"\nSpace - Продолжить!");
                                Console.ReadLine();
                            }                           
                        }
                        break;
                    #endregion
                    default:
                        Console.Clear();

                        Console.WriteLine($"\n{action}-Такого Задания не Существует!\n");
                        break;
                }
            }
            
        }
    }
}
