namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 4, 9, 8, 1, 2, 4 };

            for (int i = 0; i < numbers.Length; i++)
            {
                bool isMultiple = true;

                // Проверяваме всички числа от масива
                for (int j = 0; j < numbers.Length; j++)
                {
                    if (numbers[j] < numbers[i])
                    {
                        if (numbers[i] % numbers[j] != 0)
                        {
                            isMultiple = false;
                            break; // спираме проверката веднага щом намерим число, което не дели
                        }
                    }
                }

                if (isMultiple)
                {
                    Console.WriteLine(numbers[i]);
                }
            }
        }
    }
}
