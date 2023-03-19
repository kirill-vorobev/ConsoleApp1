namespace ConsoleApp1
{
    public static class Program
    {       
        public static void Main(string[] args)
        {
            Console.WriteLine("ВВедите размер массива:");
            int razmer = 0;
            //размер массива должен быть положительным числом
            try
            {
                razmer = Convert.ToInt32(Console.ReadLine());
            }
            catch(Exception)
            {
                Console.WriteLine("Ошибка: вы ввели НЕ положительное значение");
                return;
            }
            //Для поиска второго наибольшего значения массив должен состоять по меньшей мере из 2х элементов
            if (razmer>2)
                {
                Console.WriteLine($"Введите элементы массива, размерностью {razmer}");
                string numbersArray = Console.ReadLine();
                string[] arraySplit = numbersArray.Split(',', ' ');
                int checkArraySize = arraySplit.Count();
                if (checkArraySize <= razmer)
                {
                    for (int i = 0; i < arraySplit.Length; i++)
                    {
                        try
                        {
                            Int32.Parse(arraySplit[i]);
                        }
                        catch (Exception)
                        {
                            Console.Write("Ошибка! Проверьте правильность ввода значений массива.");
                            return;
                        }
                    }

                }
                else
                {
                    Console.Write("Oшибка! Количество введенных элементов превышает размер массива.");
                    return;
                }

                //преобразуем строчный массив в интовый
                int[] intArray = new int[arraySplit.Length];
                for (int i = 0; i < arraySplit.Length; i++)
                {
                    intArray[i] = Convert.ToInt32(arraySplit[i]);
                }
                //дублируем массив и удаляем, повторяющиеся значения
                int [] newArray = intArray.Distinct().ToArray();
             
                //сортировка
                Array.Sort(newArray);
                Array.Reverse(newArray);

                //Повторно определяем размер массива, т.к. после удаления повторяющихся элементов может остаться 1 згачение 
                int NewcheckArraySize = newArray.Count();

                //еще один if на предотвращение ошибки, в случае если все числа в массиве одинаковые.
                if (NewcheckArraySize > 1)
                {
                    Console.Write($"Второе наибольшее число в вашем массиве: {intArray[1]}");
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("Ошибка! Невозможно вывести второе наибольшее число. В данном массиве только одно наибольшее число.");
                }


            }
            else
            {
                Console.WriteLine("Ошибка, введите значение больше 2");
                return;
            }
            


        }
                     
    }
    
}