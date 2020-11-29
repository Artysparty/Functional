using System;
using System.Linq;

namespace Functional
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Task_3();
        }

        public static void Task_1()
        {
            var words = Console.ReadLine();
            Action<string> action = word => { Console.WriteLine(word); };
            foreach (var word in words.Split(' ')) action(word);
        }

        public static void Task_2()
        {
            var words = Console.ReadLine();
            Action<string> action = word => { Console.WriteLine(word + "(нет в наличии)"); };
            foreach (var word in words.Split(' ')) action(word);
        }

        public static void Task_3()
        {
            string[] inputNum = Console.ReadLine()?.Split(' ').ToArray();

            Func<string[], int> minimal = numbers =>
            {
                var nums = new int[numbers.Length];
                for (var i = 0; i < numbers.Length; i++) nums[i] = int.Parse(numbers[i]);

                return nums.Min();
            };

            Console.WriteLine(minimal(inputNum));
        }

        public static void Task_4()
        {

        }
    }
}