using System;

namespace module7_indexators
{
    class Program
    {

        // Класс для объекта “Книга”
        class Book
        {
            public string Name;
            public string Author;
        }

        // Класс для объекта “Коллекция книг”
        class BookCollection
        {
            // Закрытое поле, хранящее книги в виде массива
            private Book[] collection;

            // Конструктор с добавлением массива книг
            public BookCollection(Book[] collection)
            {
                this.collection = collection;
            }

            // Индексатор по массиву
            public Book this[int index]
            {
                get
                {
                    // Проверяем, чтобы индекс был в диапазоне для массива
                    if (index >= 0 && index < collection.Length)
                    {
                        return collection[index];
                    }
                    else
                    {
                        return null;
                    }
                }

                private set
                {
                    // Проверяем, чтобы индекс был в диапазоне для массива
                    if (index >= 0 && index < collection.Length)
                    {
                        collection[index] = value;
                    }
                }
            }

            public Book this[string name]
            {
                get
                {
                    for (int i = 0; i < collection.Length; i++)
                    {
                        if (collection[i].Name == name)
                        {
                            return collection[i];
                        }
                    }

                    return null;
                }


            }

        }

        static void Main(string[] args)
        {
            var array = new Book[]
            {
                new Book
                {
                  Name = "Мастер и Маргарита",
                  Author = "М.А. Булгаков"
                },
                new Book
                {
                  Name = "Отцы и дети",
                  Author = "И.С. Тургенев"
                },
            };
            BookCollection collection = new BookCollection(array);

            Book book = collection[1];
            Console.WriteLine(book.Author);
            book = collection["Мастер и Маргарита"];
            Console.WriteLine(book.Author);
        }
    }
}
