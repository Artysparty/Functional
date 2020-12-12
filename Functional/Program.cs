using System;
using System.Collections.Generic;
using System.Linq;

namespace Functional
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Task_4();
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
            var inputNum = Console.ReadLine()?.Split(' ').ToArray();

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
            var inputInterval = Console.ReadLine()?.Split(' ');
            var command = Console.ReadLine();

            var interval = new int[inputInterval.Length];
            for (var i = 0; i < inputInterval.Length; i++) interval[i] = int.Parse(inputInterval[i]);

            Func<int, int, bool, int[]> findOddOrEven = (first, last, com) =>
            {
                var massive = new int[(last - first) / 2 + 1];
                if (com)
                {
                    if (first % 2 == 0)
                    {
                        massive[0] = first;
                        for (var i = 1; i < massive.Length; i++) massive[i] = massive[i - 1] + 2;
                    }
                    else
                    {
                        massive[0] = first + 1;
                        for (var i = 1; i < massive.Length; i++) massive[i] = massive[i - 1] + 2;
                    }
                }
                else
                {
                    if (first % 2 == 0)
                    {
                        massive[0] = first + 1;
                        for (var i = 1; i < massive.Length; i++) massive[i] = massive[i - 1] + 2;
                    }
                    else
                    {
                        massive[0] = first;
                        for (var i = 1; i < massive.Length; i++) massive[i] = massive[i - 1] + 2;
                    }
                }

                return massive;
            };
            var com = command == "odd";
            Console.WriteLine(string.Join(' ', findOddOrEven(interval[0], interval[1], com)));
        }

        public static void Task_5()
        {
            var inputCollection = Console.ReadLine()?.Split(' ');
            var listInput = new List<int>();
            for (var i = 0; i < inputCollection.Length; i++) listInput.Add(int.Parse(inputCollection[i]));

            Func<List<int>, List<int>> arifmFunc = input =>
            {
                var end = false;
                while (end == false)
                {
                    var com = Console.ReadLine();

                    if (com == "add")
                        for (var i = 0; i < input.Count; i++)
                            input[i] = input[i] + 1;
                    if (com == "print")
                        Console.WriteLine(string.Join(' ', input));
                    if (com == "multiply")
                        for (var i = 0; i < input.Count; i++)
                            input[i] = input[i] * 2;
                    if (com == "subtract")
                        for (var i = 0; i < input.Count; i++)
                            input[i] = input[i] - 1;
                    if (com == "end")
                        end = true;
                }

                return input;
            };

            arifmFunc(listInput);
        }

        public static void Task_6()
        {
            var input = Console.ReadLine().Split(" ");

            var myInput = new List<int>();

            var n = int.Parse(Console.ReadLine());

            for (var i = 0; i < input.Length; i++) myInput.Add(int.Parse(input[i]));

            Func<List<int>, int, List<int>> reverse = (input, n) =>
            {
                var result = new List<int>();
                for (var i = 0; i < input.Count - 1; i++)
                    if (input[i] % 2 != 0)
                        result.Add(input[i]);
                result.Reverse();
                Console.WriteLine(string.Join(' ', result));
                return result;
            };

            reverse(myInput, n);
        }

        public static void Task_7()
        {
            var names = Console.ReadLine()?.Split(' ');
            var myNames = new List<string>();

            for (var i = 0; i < names.Length; i++) myNames.Add(names[i]);

            var nameLength = int.Parse(Console.ReadLine());

            Func<List<string>, int, List<string>> nameFilter = (namesParam, nameLengthParam) =>
            {
                var result = new List<string>();
                for (var i = 0; i < namesParam.Count; i++)
                    if (namesParam[i].Length <= nameLengthParam)
                        result.Add(namesParam[i]);
                Console.WriteLine(string.Join(' ', result));
                return result;
            };
            nameFilter(myNames, nameLength);
        }

        public static void Task_8()
        {
            var input = Console.ReadLine().Split(' ');
            var inputCollection = new List<int>();

            for (var i = 0; i < input.Length; i++) inputCollection.Add(int.Parse(input[i]));
        }
    }
}