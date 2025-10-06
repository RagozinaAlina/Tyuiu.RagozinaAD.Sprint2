using Tyuiu.RagozinaAD.Sprint2.Task6.V9.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #2 | Выполнила: Рагозина А.Д | АСОиУБ-25-1";

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #2                                                               *");
        Console.WriteLine("* Тема: Создания итогового решения по спринту                             *");
        Console.WriteLine("* Задание #6                                                              *");
        Console.WriteLine("* Вариант #9                                                              *");
        Console.WriteLine("* Выполнила: Рагозина А.Д | АСОиУБ-25-1                                   *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Условие:                                                                *");
        Console.WriteLine("* Написать программу, которая использует сокращенную форму записи         *");
        Console.WriteLine("* оператора switch вычисляет требуемое значение и возвращает результа     *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДВННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");



        Console.WriteLine("Введите порядковый номер месяца: ");

        int n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите число: ");
        int m = Convert.ToInt32(Console.ReadLine());
        if ((n > 12) || (m > 31))
        {
            Console.WriteLine("Введены неправильные данные");
        }
        else
        {
            if ((n == 2) && (m > 28))
            {
                Console.WriteLine("Такого дня не существует");
            }
            else if ((n == 4) && (m > 30))
            {
                Console.WriteLine("Такого дня не существует");
            }
            else if ((n == 6) && (m > 30))
            {
                Console.WriteLine("Такого дня не существует");
            }
            else if ((n == 9) && (m > 30))
            {
                Console.WriteLine("Такого дня не существует");
            }
            else if ((n == 11) && (m > 30))
            {
                Console.WriteLine("Такого дня не существует");
            }
            else
            {
                Console.WriteLine("********************************************************************************************");
                Console.WriteLine("* РЕЗУЛЬТАТ:                                                                               *");
                Console.WriteLine("********************************************************************************************");
                Console.WriteLine("Следующий день будет " + ds.FindDateOfNextDay(m, n));

            }
        }
        Console.ReadKey();
    }
}
