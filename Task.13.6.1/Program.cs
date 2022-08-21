using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

namespace Task._13._6._1
{
    class Program
    {
        static void Main(string[] args)
        {
            // читаем весь файл в строку текста
            string text = File.ReadAllText("D:\\Text1.txt");

            // Сохраняем символы-разделители в массив
            char[] delimiters = new char[] { ' ', '\r', '\n' };

            // разбиваем нашу строку текста, используя ранее перечисленные символы-разделители
            var words = text.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);

            var strings = new List<string>();

            var watch1 = Stopwatch.StartNew();

            for (int i = 0; i < words.Length; i++)
            {
                strings.Add(words[i]);
            }

            Console.WriteLine($"Вставка в List<T>: {watch1.Elapsed.TotalMilliseconds} мс");

            LinkedList<string> LinkedList = new LinkedList<string>();

            var watch2 = Stopwatch.StartNew();

            for (int i = 0; i < words.Length; i++)
            {
                LinkedList.AddFirst(words[i]);
            }

            Console.WriteLine($"Вставка в LinkedList<T>: {watch2.Elapsed.TotalMilliseconds} мс");
        }
    }
}
