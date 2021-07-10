using System;

namespace massive
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isOpen = true;
            string[,] books = {
                {"Пушкин", "Лермонтов", "Глуховский" },
                {"Стивен кинг", "Говард Лавкрафт", "Брэм Стокер" },
                {"Донцова", "Ален Карр", "Игорь Прокопенко" }
            };

            while (isOpen)
            {
                Console.WriteLine("Библиотека.");
                Console.WriteLine("\n\n 1 - Узнать, что за книга, зная её индекс.\n\n 2 - Найти книгу по автору.\n\n 3 - Вывести все книги. \n\n 4 - Выход.");
                Console.Write("Введите пункт меню: ");
                switch (Convert.ToInt32(Console.ReadLine()))
                {
                    case 1:
                        int rows;
                        int cols;
                        Console.Write("Введите номер полки: ");
                        rows = Convert.ToInt32(Console.ReadLine()) - 1;
                        Console.Write("Введите номер: ");
                        cols = Convert.ToInt32(Console.ReadLine()) - 1;
                        Console.WriteLine("\n Это книга - " + books[rows, cols]);
                        break;
                    case 2:
                        string author;
                        bool authorIsFind = false;
                        Console.Write("Введите нужного вам автора: ");
                        author = Console.ReadLine();

                        for (int i = 0; i < books.GetLength(0); i++)
                        {
                            for (int j = 0; j < books.GetLength(1); j++)
                            {
                                if (author.ToLower() == books[i, j].ToLower())
                                {
                                    Console.Write("Автор - " + books[i, j] + " находится по адресу - " + (i + 1) + " | " + (j + 1));
                                    authorIsFind = true;
                                }
                            }
                        }
                        if(authorIsFind == false)
                        {
                            Console.WriteLine("Такого автора нет");
                        }
                        break;
                    case 3:
                        Console.WriteLine("\nВесь список авторов:\n ");
                        for (int i = 0; i < books.GetLength(0); i++)
                        {
                            for (int j = 0; j < books.GetLength(1); j++)
                            {
                                Console.WriteLine(books[i, j]);
                            }
                        }
                        break;
                    case 4:
                        isOpen = false;
                        break;
                }
                Console.Write("\nНажмите любую клавишу для продолжения...");
                Console.ReadKey();
                Console.Clear();

            }

            for (int i = 0; i < books.GetLength(0); i++)
            {
                for (int j = 0; j < books.GetLength(1); j++)
                {
                    Console.Write(books[i, j] + " | ");
                }
                Console.WriteLine();
            }
        }
    }
}
