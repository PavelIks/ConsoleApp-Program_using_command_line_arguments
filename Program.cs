using System;
using System.IO;

namespace DirectoriesAndFilesOutput
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter path: ");
                string path = Console.ReadLine();
                Console.Write("Enter argument: ");
                string argument = Console.ReadLine(); Console.Write("\n");

                // Выводит все директории и файлы
                if (argument.Equals("-d-f"))
                {
                    foreach (var directories in Directory.GetDirectories(path))
                    {
                        Console.WriteLine(directories);
                    }
                    foreach (var files in Directory.GetFiles(path))
                    {
                        Console.WriteLine(files);
                    }
                }
                // Выводит все директории
                else if (argument.Equals("-d"))
                {
                    foreach (var directories in Directory.GetDirectories(path))
                    {
                        Console.WriteLine(directories);
                    }
                }
                // Выводит все файлы
                else if (argument.Equals("-f"))
                {
                    foreach (var files in Directory.GetFiles(path))
                    {
                        Console.WriteLine(files);
                    }
                }
                // Выводит все файлы c расширением .cpp
                else if (argument.Equals("-f--cpp"))
                {
                    string type = "*.cpp";
                    foreach (var files in Directory.GetFiles(path, type))
                    {
                        Console.WriteLine(files);
                    }
                }
                // Выводит все файлы c расширением .cpp или .hpp
                else if (argument.Equals("-f--cpp--hpp"))
                {
                    string type1 = "*.cpp";
                    foreach (var files in Directory.GetFiles(path, type1))
                    {
                        Console.WriteLine(files);
                    }

                    string type2 = "*.hpp";
                    foreach (var files in Directory.GetFiles(path, type2))
                    {
                        Console.WriteLine(files);
                    }
                }
                else
                {
                    Console.WriteLine("Нет такого аргумента!");
                }
            }

            catch (Exception exception)
            {
                Console.Write
                    (
                        $"Исключение: {exception.Message}\n" +
                        $"Метод: {exception.TargetSite}\n" +
                        $"Трассировка стека: {exception.StackTrace}\n"
                    );
            }
            Console.Read();
        }
    }
}