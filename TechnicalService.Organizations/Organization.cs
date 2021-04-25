using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechnicalService.Organizations
{
    public class Organization
    {
        public List<Auxiliary> Providers { get; set; }
        public List<Auxiliary> Partners { get; set; }
        public List<Auxiliary> PotentialClients { get; set; }
        public List<Auxiliary> Customers { get; set; }
        public List<Branch> Branches { get; set; }


        public static void ShowAllProviders(Organization organization)
        {
            Console.WriteLine("Поставщики:");
            foreach (var item in organization.Providers)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("-----------------------------------");
        }
        public static void ShowAllPartners(Organization organization)
        {
            Console.WriteLine("Партнёры:");
            foreach (var item in organization.Partners)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("-----------------------------------");
        }
        public static void ShowAllPotentialClients(Organization organization)
        {
            Console.WriteLine("Потенциальные клиенты:");
            foreach (var item in organization.PotentialClients)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("-----------------------------------");
        }
        public static void ShowAllCustomers(Organization organization)
        {
            Console.WriteLine("Клиенты:");
            foreach (var item in organization.Customers)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("-----------------------------------");
        }
        public static void ChangeContact(Organization organization)
        {
            Console.WriteLine("В какой базе вы хотите её изменить?\n1. Базе поставщиков" +
                            "\n2. Базе партнёров\n3. Базе покупателей\n4. Базе потенциальных клиентов");
            int choiseChange = int.Parse(Console.ReadLine());
            switch (choiseChange)
            {
                case 1:
                    {
                        foreach (Auxiliary item in organization.Providers)
                        {
                            Console.WriteLine(item);
                        }

                        Console.WriteLine("Введите ID поставщика: ");
                        string searchId = Console.ReadLine();

                        bool isFind = false;
                        foreach (Auxiliary item in organization.Providers)
                        {
                            if (searchId == item.Id)
                            {
                                isFind = true;
                                Console.WriteLine("Введите новую контактную информацию: ");
                                item.ContactInfo.Clear();
                                item.ContactInfo.Add(Console.ReadLine());
                                break;
                            }
                        }

                        Console.WriteLine("Новая контактная информация:");

                        foreach (Auxiliary item in organization.Providers)
                        {
                            Console.WriteLine(item);
                        }

                        if (isFind == false)
                            Console.WriteLine("Подобного поставщика у нас нет!");
                    }
                    break;
                case 2:
                    {
                        foreach (Auxiliary item in organization.Partners)
                        {
                            Console.WriteLine(item.Name);
                            foreach (var element in item.ContactInfo)
                            {
                                Console.WriteLine(element);
                            }
                            Console.WriteLine(item.Id);

                        }

                        Console.WriteLine("Введите ID партнёра: ");
                        string searchId = Console.ReadLine();

                        bool isFind = false;
                        foreach (Auxiliary item in organization.Partners)
                        {
                            if (searchId == item.Id)
                            {
                                isFind = true;
                                Console.WriteLine("Введите новую контактную информацию: ");
                                item.ContactInfo.Clear();
                                item.ContactInfo.Add(Console.ReadLine());
                                break;
                            }
                        }

                        Console.WriteLine("Новая контактная информация:");

                        foreach (Auxiliary item in organization.Partners)
                        {
                            Console.WriteLine(item);
                        }

                        if (isFind == false)
                            Console.WriteLine("Подобного партнёра у нас нет!");
                    }
                    break;
                case 3:
                    {
                        foreach (Auxiliary item in organization.Customers)
                        {
                            Console.WriteLine(item);
                        }

                        Console.WriteLine("Введите ID покупателя: ");
                        string searchId = Console.ReadLine();

                        bool isFind = false;
                        foreach (Auxiliary item in organization.Customers)
                        {
                            if (searchId == item.Id)
                            {
                                isFind = true;
                                Console.WriteLine("Введите новую контактную информацию: ");
                                item.ContactInfo.Clear();
                                item.ContactInfo.Add(Console.ReadLine());
                                break;
                            }
                        }

                        Console.WriteLine("Новая контактная информация:");

                        foreach (Auxiliary item in organization.Customers)
                        {
                            Console.WriteLine(item);
                        }

                        if (isFind == false)
                            Console.WriteLine("Подобного покупателя у нас нет!");
                    }
                    break;
                case 4:
                    {
                        foreach (Auxiliary item in organization.PotentialClients)
                        {
                            Console.WriteLine(item);
                        }

                        Console.WriteLine("Введите ID потенциального клиента: ");
                        string searchId = Console.ReadLine();

                        bool isFind = false;
                        foreach (Auxiliary item in organization.PotentialClients)
                        {
                            if (searchId == item.Id)
                            {
                                isFind = true;
                                Console.WriteLine("Введите новую контактную информацию: ");
                                item.ContactInfo.Clear();
                                item.ContactInfo.Add(Console.ReadLine());
                                break;
                            }
                        }

                        Console.WriteLine("Новая контактная информация:");

                        foreach (Auxiliary item in organization.PotentialClients)
                        {
                            Console.WriteLine(item);
                        }

                        if (isFind == false)
                            Console.WriteLine("Подобного клиента у нас нет!");
                    }
                    break;
                default:
                    break;
            }
        }
        public static void AddToProviders(Organization organization)
        {
            Random rnd = new Random();
            for (int i = 0; i < 2; i++)
            {
                Auxiliary something = new Auxiliary();
                something.ContactInfo = new List<string>();
                int num = rnd.Next(100, 999);
                int num2 = rnd.Next(10, 99);
                int num3 = rnd.Next(10, 99);

                string contactInfo = "+7 (707)" + " " + num.ToString() + " " + num2.ToString() + " " + num3.ToString();
                something.ContactInfo.Add(contactInfo);
                something.Name = string.Format("Name_{0}", rnd.Next(1, 100));
                something.Id = rnd.Next().ToString();

                organization.Providers.Add(something);
            }
        }
        public static void AddToPartners(Organization organization)
        {
            Random rnd = new Random();
            for (int i = 0; i < 2; i++)
            {
                Auxiliary something = new Auxiliary();
                something.ContactInfo = new List<string>();
                int num = rnd.Next(100, 999);
                int num2 = rnd.Next(10, 99);
                int num3 = rnd.Next(10, 99);

                string contactInfo = "+7 (707)" + " " + num.ToString() + " " + num2.ToString() + " " + num3.ToString();
                something.ContactInfo.Add(contactInfo);
                something.Name = string.Format("Name_{0}", rnd.Next(1, 100));
                something.Id = rnd.Next().ToString();

                organization.Partners.Add(something);
            }
        }
        public static void AddToCustomers(Organization organization)
        {
            Random rnd = new Random();
            for (int i = 0; i < 2; i++)
            {
                Auxiliary something = new Auxiliary();
                something.ContactInfo = new List<string>();
                int num = rnd.Next(100, 999);
                int num2 = rnd.Next(10, 99);
                int num3 = rnd.Next(10, 99);

                string contactInfo = "+7 (707)" + " " + num.ToString() + " " + num2.ToString() + " " + num3.ToString();
                something.ContactInfo.Add(contactInfo);
                something.Name = string.Format("Name_{0}", rnd.Next(1, 100));
                something.Id = rnd.Next().ToString();

                organization.Customers.Add(something);
            }
        }
        public static void AddToPotentialClients(Organization organization)
        {
            Random rnd = new Random();
            for (int i = 0; i < 2; i++)
            {
                Auxiliary something = new Auxiliary();
                something.ContactInfo = new List<string>();
                int num = rnd.Next(100, 999);
                int num2 = rnd.Next(10, 99);
                int num3 = rnd.Next(10, 99);

                string contactInfo = "+7 (707)" + " " + num.ToString() + " " + num2.ToString() + " " + num3.ToString();
                something.ContactInfo.Add(contactInfo);
                something.Name = string.Format("Name_{0}", rnd.Next(1, 100));
                something.Id = rnd.Next().ToString();

                organization.PotentialClients.Add(something);
            }
        }
        public static void AddContact(Organization organization)
        {
                        Console.WriteLine("В какой базе вы хотите её добавить?\n1. Базе поставщиков" +
                            "\n2. Базе партнёров\n3. Базе покупателей\n4. Базе потенциальных клиентов");
                        int choiseChange = int.Parse(Console.ReadLine());
                        switch (choiseChange)
                        {
                            case 1:
                                {
                        foreach (Auxiliary item in organization.Providers)
                        {
                            Console.WriteLine(item);
                        }

                        Console.WriteLine("Введите ID поставщика: ");
                        string searchId = Console.ReadLine();

                        bool isFind = false;
                        foreach (Auxiliary item in organization.Providers)
                        {
                            if (searchId == item.Id)
                            {
                                isFind = true;
                                Console.WriteLine("Введите новую контактную информацию: ");
                                item.ContactInfo.Add(Console.ReadLine());
                                break;
                            }
                        }

                        Console.WriteLine("Новая контактная информация:");

                        foreach (Auxiliary item in organization.Providers)
                        {
                            Console.WriteLine(item);
                        }

                        if (isFind == false)
                            Console.WriteLine("Подобного поставщика у нас нет!");
                    }
                                break;
                            case 2:
                                {
                                    foreach (Auxiliary item in organization.Partners)
                                    {
                                        Console.WriteLine(item);
                                    }

                                    Console.WriteLine("Введите ID партнёра: ");
                                    string searchId = Console.ReadLine();

                                    bool isFind = false;
                                    foreach (Auxiliary item in organization.Partners)
                                    {
                                        if (searchId == item.Id)
                                        {
                                            isFind = true;
                                            Console.WriteLine("Введите новую контактную информацию: ");
                                            item.ContactInfo.Add(Console.ReadLine());
                                            break;
                                        }
                                    }

                                    Console.WriteLine("Новая контактная информация:");

                                    foreach (Auxiliary item in organization.Partners)
                                    {
                                        Console.WriteLine(item);
                                    }

                                    if (isFind == false)
                                        Console.WriteLine("Подобного партнёра у нас нет!");
                                }
                                break;
                            case 3:
                                {
                                    foreach (Auxiliary item in organization.Customers)
                                    {
                                        Console.WriteLine(item);
                                    }

                                    Console.WriteLine("Введите ID покупателя: ");
                                    string searchId = Console.ReadLine();

                                    bool isFind = false;
                                    foreach (Auxiliary item in organization.Customers)
                                    {
                                        if (searchId == item.Id)
                                        {
                                            isFind = true;
                                            Console.WriteLine("Введите новую контактную информацию: ");
                                            item.ContactInfo.Add(Console.ReadLine());
                                            break;
                                        }
                                    }

                                    Console.WriteLine("Новая контактная информация:");

                                    foreach (Auxiliary item in organization.Customers)
                                    {
                                        Console.WriteLine(item);
                                    }

                                    if (isFind == false)
                                        Console.WriteLine("Подобного покупателя у нас нет!");
                                }
                                break;
                            case 4:
                                {
                                    foreach (Auxiliary item in organization.PotentialClients)
                                    {
                                        Console.WriteLine(item);
                                    }

                                    Console.WriteLine("Введите ID потенциального клиента: ");
                                    string searchId = Console.ReadLine();

                                    bool isFind = false;
                                    foreach (Auxiliary item in organization.PotentialClients)
                                    {
                                        if (searchId == item.Id)
                                        {
                                            isFind = true;
                                            Console.WriteLine("Введите новую контактную информацию: ");
                                            item.ContactInfo.Add(Console.ReadLine());
                                            break;
                                        }
                                    }

                                    Console.WriteLine("Новая контактная информация:");

                                    foreach (Auxiliary item in organization.PotentialClients)
                                    {
                                        Console.WriteLine(item);
                                    }

                                    if (isFind == false)
                                        Console.WriteLine("Подобного клиента у нас нет!");
                                }
                                break;
                            default:
                                break;
            }
        }
        public static void DeleteContact(Organization organization)
        {
            Console.WriteLine("В какой базе вы хотите её удалить?\n1. Базе поставщиков" +
                            "\n2. Базе партнёров\n3. Базе покупателей\n4. Базе потенциальных клиентов");
            int choiseChange = int.Parse(Console.ReadLine());
            switch (choiseChange)
            {
                case 1:
                    {
                        foreach (Auxiliary item in organization.Providers)
                        {
                            Console.WriteLine(item);
                        }

                        Console.WriteLine("Введите ID поставщика: ");
                        string searchId = Console.ReadLine();

                        bool isFind = false;
                        foreach (Auxiliary item in organization.Providers)
                        {
                            if (searchId == item.Id)
                            {
                                isFind = true;
                                int cnt = 1;
                                foreach (var element in item.ContactInfo)
                                {
                                    Console.WriteLine(cnt + ". \n" + element);
                                    cnt++;
                                }

                                Console.WriteLine("Введите цифру, которую хотите удалить: ");
                                int deleteInfo = int.Parse(Console.ReadLine());
                                item.ContactInfo.RemoveAt(cnt - 1);
                                Console.WriteLine("-------------------------------");
                                Console.WriteLine("Вот так теперь выглядит контактная информация: ");
                                Console.WriteLine(item.ContactInfo);
                                break;
                            }
                        }

                        if (isFind == false)
                            Console.WriteLine("Подобного поставщика у нас нет!");
                    }
                    break;
                case 2:
                    {
                        foreach (Auxiliary item in organization.Providers)
                        {
                            Console.WriteLine(item);
                        }

                        Console.WriteLine("Введите ID партнёра: ");
                        string searchId = Console.ReadLine();

                        bool isFind = false;
                        foreach (Auxiliary item in organization.Providers)
                        {
                            if (searchId == item.Id)
                            {
                                isFind = true;
                                int cnt = 1;
                                foreach (var element in item.ContactInfo)
                                {
                                    Console.WriteLine(cnt + ". \n" + element);
                                    cnt++;
                                }

                                Console.WriteLine("Введите цифру, которую хотите удалить: ");
                                int deleteInfo = int.Parse(Console.ReadLine());
                                item.ContactInfo.RemoveAt(cnt - 1);
                                Console.WriteLine("-------------------------------");
                                Console.WriteLine("Вот так теперь выглядит контактная информация: ");
                                Console.WriteLine(item.ContactInfo);
                                break;
                            }
                        }

                        if (isFind == false)
                            Console.WriteLine("Подобного партнёра у нас нет!");
                    }
                    break;
                case 3:
                    {
                        foreach (Auxiliary item in organization.Providers)
                        {
                            Console.WriteLine(item);
                        }

                        Console.WriteLine("Введите ID покупателя: ");
                        string searchId = Console.ReadLine();

                        bool isFind = false;
                        foreach (Auxiliary item in organization.Providers)
                        {
                            if (searchId == item.Id)
                            {
                                isFind = true;
                                int cnt = 1;
                                foreach (var element in item.ContactInfo)
                                {
                                    Console.WriteLine(cnt + ". \n" + element);
                                    cnt++;
                                }

                                Console.WriteLine("Введите цифру, которую хотите удалить: ");
                                int deleteInfo = int.Parse(Console.ReadLine());
                                item.ContactInfo.RemoveAt(cnt - 1);
                                Console.WriteLine("-------------------------------");
                                Console.WriteLine("Вот так теперь выглядит контактная информация: ");
                                Console.WriteLine(item.ContactInfo);
                                break;
                            }
                        }

                        if (isFind == false)
                            Console.WriteLine("Подобного покупателя у нас нет!");
                    }
                    break;
                case 4:
                    {
                        foreach (Auxiliary item in organization.Providers)
                        {
                            Console.WriteLine(item);
                        }

                        Console.WriteLine("Введите ID потенциального клиента: ");
                        string searchId = Console.ReadLine();

                        bool isFind = false;
                        foreach (Auxiliary item in organization.Providers)
                        {
                            if (searchId == item.Id)
                            {
                                isFind = true;
                                int cnt = 1;
                                foreach (var element in item.ContactInfo)
                                {
                                    Console.WriteLine(cnt + ". \n" + element);
                                    cnt++;
                                }

                                Console.WriteLine("Введите цифру, которую хотите удалить: ");
                                int deleteInfo = int.Parse(Console.ReadLine());
                                item.ContactInfo.RemoveAt(cnt - 1);
                                Console.WriteLine("-------------------------------");
                                Console.WriteLine("Вот так теперь выглядит контактная информация: ");
                                Console.WriteLine(item.ContactInfo);
                                break;
                            }
                        }

                        if (isFind == false)
                            Console.WriteLine("Подобного клиента у нас нет!");
                    }
                    break;
                default:
                    break;
            }
        }
        public static void ShowAllInfo(Organization organization)
        {
            Console.WriteLine("Поставщики:");
            foreach (var item in organization.Providers)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Партнёры:");
            foreach (var item in organization.Partners)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Покупатели:");
            foreach (var item in organization.Customers)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Потенциальные клиенты:");
            foreach (var item in organization.PotentialClients)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("-----------------------------------");
        }
        public static void SearchInContacts(Organization organization)
        {
            string Contact = Console.ReadLine();
            bool isFind = false;
            foreach (Auxiliary item in organization.Providers)
            {
                foreach (var element in item.ContactInfo)
                {
                    if(element == Contact)
                    {
                        Console.WriteLine(item);
                        isFind = true;
                    }
                }
            }

            if(isFind == false)
            {
                foreach (Auxiliary item in organization.Partners)
                {
                    foreach (var element in item.ContactInfo)
                    {
                        if (element == Contact)
                        {
                            Console.WriteLine(item);
                            isFind = true;
                        }
                    }
                }
            }
            if (isFind == false)
            {
                foreach (Auxiliary item in organization.Customers)
                {
                    foreach (var element in item.ContactInfo)
                    {
                        if (element == Contact)
                        {
                            Console.WriteLine(item);
                            isFind = true;
                        }
                    }
                }
            }
            if(isFind == false)
            {
                foreach (Auxiliary item in organization.PotentialClients)
                {
                    foreach (var element in item.ContactInfo)
                    {
                        if (element == Contact)
                        {
                            Console.WriteLine(item);
                            isFind = true;
                        }
                    }
                }
            }
            if(isFind == false)
                Console.WriteLine("Подобных контактов в нашей базе нет!");
        }
    }
}
