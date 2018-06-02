using Classes.LIB.Modules;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Soap;

/* Создать коллекцию элементов Book и заполнить тестовыми данными. 
 С помощью класса BinaryFormatter сохранить состояние приложения в двоичный файл.*/

namespace Classes.LIB
{
    public class Service
    {
        public string path = @"D:\ШАГ\06_C#\021_Занятие\books.dat";

        public void BookAddService() //Создать коллекцию элементов Book и заполнить тестовыми данными.
        {
            List<Book> listBooks = new List<Book>()
            {  new Book() { Author = "Гоголь Н.В.",
                            Name = "Вий",
                            Price = 2500,
                            Year = 2017 },
             new Book()
             {
                 Author = "Пушкин А.С.",
                 Name ="Руслан и Людмила",
                 Price = 3000,
                 Year = 2015
             },
             new Book()
             {
                 Author="Толстой Л.Н.",
                 Name="Анна Каренина",
                 Price = 4000,
                 Year = 2018
             }
            };


            BinaryFormatter formatter = new BinaryFormatter(); //С помощью класса BinaryFormatter сохранить состояние приложения в двоичный файл.
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, listBooks);
                Console.WriteLine("\n\t\t\tBinarySerialization is Successfully!");
                
            }

            Console.WriteLine("\t\t\t************************************");
            /*2.На основании задания 1 восстановить состояние приложения из двоичного файла.*/
            using (FileStream stream = new FileStream(path, FileMode.OpenOrCreate))
            {
                var bookList = (List<Book>)formatter.Deserialize(stream);
                 Console.WriteLine("\n\t\t\tDeserialization is Successfully!");
                Console.WriteLine("\t\t\t********************************");
                foreach (Book item in bookList)
                Console.WriteLine("\n\t\t\tAuthor - {0}\n\t\t\t Name - {1}\n\t\t\t Price - {2}\n\t\t\t Year - {3}",
                    item.Author, item.Name, item.Price, item.Year);
                        
            }

            Console.WriteLine("\t\t\t******************************");
        }
    }
}