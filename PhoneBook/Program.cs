using System;
using System.Collections.Generic;
using System.Linq;


namespace PhoneBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var phoneBook = new List<Contact>();

            // добавляем контакты
            phoneBook.Add(new Contact("Игорь", "Николаев", 79990000001, "igor@example.com"));
            phoneBook.Add(new Contact("Сергей", "Довлатов", 79990000010, "serge@example.com"));
            phoneBook.Add(new Contact("Анатолий", "Карпов", 79990000011, "anatoly@example.com"));
            phoneBook.Add(new Contact("Валерий", "Леонтьев", 79990000012, "valera@example.com"));
            phoneBook.Add(new Contact("Сергей", "Брин", 799900000013, "serg@example.com"));
            phoneBook.Add(new Contact("Иннокентий", "Смоктуновский", 799900000013, "innokentii@example.com"));

            while (true)
            {
                var res = false;
                var nomPage = 0;

                while (!res || nomPage < 1 || nomPage > 3)
                {
                    Console.WriteLine("Введите номер страницы в диапазоне от 1 до 3");
                    res = int.TryParse(Console.ReadLine(), out int nPage);

                    if (!res)

                    {
                        Console.WriteLine("Ведено не число.");

                    }
                    else
                    {
                        nomPage = nPage;
                        if (nomPage < 1 || nomPage > 3)
                        {
                            Console.WriteLine("Введен неправильный номер страницы.");
                        }
                    }
                }

                var sortPhone = phoneBook.OrderBy(p => p.Name).ThenBy(p => p.LastName);

                var pagePhone = sortPhone.Skip((nomPage - 1) * 2).Take(2);



                foreach (var pPhone in pagePhone)
                {
                    Console.WriteLine(pPhone.Name + " " + pPhone.LastName + " " + pPhone.PhoneNumber + " " + pPhone.Email);
                }
            }
        }
              
    }
}
