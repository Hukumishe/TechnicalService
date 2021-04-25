using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechnicalService.Devices
{
    public class Device
    {
        public string DeviceName { get; set; }
        public string SerialNumber { get; set; }
        public string TypeOfDevice { get; set; }
        public Software TypeOfSoftware { get; set; }
        public DateTime Guarantee { get; set; }
        public List<string> ResponsiblePersons { get; set; }
        public int Price { get; set; }

        public static void AddDevice(List<Device> devices)
        {
            //я решил заполнить так, потому что очень долго писать, извините :(
            for (int i = 0; i < 4; i++)
            {
                Random rnd = new Random();
                Device device = new Device();
                device.SerialNumber = string.Format("SerialNumber_{0}", rnd.Next(1, 100));
                device.TypeOfDevice = "PC";
                device.TypeOfSoftware = new Software();
                device.TypeOfSoftware.SoftwareName = "Microsoft";
                device.TypeOfSoftware.InstallationDate = DateTime.Now.AddDays(-rnd.Next(100, 600));
                device.TypeOfSoftware.Guarantee = DateTime.Now.AddDays(rnd.Next(100, 600)); ;
                device.TypeOfSoftware.Price = rnd.Next(15000, 30000);
                device.Guarantee = DateTime.Now.AddDays(rnd.Next(500, 800));
                device.ResponsiblePersons = new List<string>();
                device.ResponsiblePersons.Add(string.Format("Person_{0}", rnd.Next()));
                device.ResponsiblePersons.Add(string.Format("Person_{0}", rnd.Next()));
                device.Price = rnd.Next(50000, 500000);
                devices.Add(device);
            }
        }
        public static void DeleteDevice(List<Device> devices)
        {
            foreach (Device device in devices)
            {
                Console.WriteLine(device);
            }
            Console.WriteLine("Введите серийный номер устройства, которое хотите изменить:");
            string SerialNumber = Console.ReadLine();

            bool isFind = false;
            int deletePos = 0;

            for (int i = 0; i < devices.Count; i++)
            {
                if (devices[i].SerialNumber == SerialNumber)
                {
                    deletePos = i;
                    isFind = true;
                    break;
                }
            }
            if(isFind == false)
                Console.WriteLine("Подобных устройств у нас нет!");

            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("<--- УДАЛЕНИЕ ПРОШЛО УСПЕШНО --->");
            Console.WriteLine("--------------------------------------------");
            devices.RemoveAt(deletePos);
            foreach (Device device in devices)
            {
                Console.WriteLine(device);
            }
            
        }
        public static void ChangeDevice(List<Device> devices)
        {
            foreach (Device device in devices)
            {
                Console.WriteLine(device);
            }
            Console.WriteLine("Введите серийный номер устройства, которое хотите изменить:");
            string SerialNumber = Console.ReadLine();

            bool isFind = false;
            int changePos = 0;

            for (int i = 0; i < devices.Count; i++)
            {
                if (devices[i].SerialNumber == SerialNumber)
                {
                    changePos = i;
                    isFind = true;
                    break;
                }
            }

            if (isFind == true)
            {
                Console.WriteLine("Что вы хотите изменить?\n1. Серийный номер\n2. " +
                    "Тип устройства \n3. Гарантийный срок \n4. Отвественные лица \n5. Цена \n6. Выход");
                int choise = int.Parse(Console.ReadLine());

                switch (choise)
                {
                    case 1:
                        {
                            Console.WriteLine("Введите новый серийный номер: ");
                            string SerialNumberChange = Console.ReadLine();

                            bool noRepeat = true;
                            foreach (Device device in devices)
                            {
                                if (SerialNumberChange == device.SerialNumber)
                                    noRepeat = false;
                            }
                            if (noRepeat == true)
                                devices[changePos].SerialNumber = SerialNumberChange;
                        }
                        break;

                    case 2:
                        {
                            Console.WriteLine("<--- При смене типа устройства вы также должны сменить характеристики его ПО --->" +
                                "\nВыберите новый тип для данного устройства: \n1. Персональный компьютер\n2. Телефон\n3. Планшет");
                            string newTypeOfDevice = Console.ReadLine();
                            devices[changePos].TypeOfDevice = newTypeOfDevice;
                            Console.WriteLine("--------------------------------------");
                            Console.WriteLine("\nЗаполните свойства вашего ПО: \n1. Название\n2. Дата установки\n3. Гарантия\n4. Цена\n");
                            devices[changePos].TypeOfSoftware.SoftwareName = Console.ReadLine();
                            devices[changePos].TypeOfSoftware.InstallationDate = DateTime.Parse(Console.ReadLine());
                            devices[changePos].TypeOfSoftware.Guarantee = DateTime.Parse(Console.ReadLine());
                            devices[changePos].TypeOfSoftware.Price = int.Parse(Console.ReadLine());
                        }
                        break;

                    case 3:
                        {
                            Console.WriteLine("Введите новый гарантийный срок: ");
                            devices[changePos].Guarantee = DateTime.Parse(Console.ReadLine());
                        }
                        break;

                    case 4:
                        {
                            Console.WriteLine("Хотите заменить всех ответственных лиц? \n1. Да \n2. Нет");
                            int deleteAllPersons = int.Parse(Console.ReadLine());
                            switch (deleteAllPersons)
                            {
                                case 1:
                                    {
                                        devices[changePos].ResponsiblePersons.Clear();
                                        Console.WriteLine("Сколько лиц вы хотите добавить?");
                                        int responsiblePersons = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Введите ФИО отвественных лиц по очереди: ");
                                        for (int i = 0; i < responsiblePersons; i++)
                                        {
                                            devices[changePos].ResponsiblePersons.Add(Console.ReadLine());
                                        }
                                    }
                                    break;
                                case 2:
                                    {
                                        Console.WriteLine("Сколько лиц вы хотите добавить?");
                                        int responsiblePersons = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Введите ФИО отвественных лиц по очереди: ");
                                        for (int i = 0; i < responsiblePersons; i++)
                                        {
                                            devices[changePos].ResponsiblePersons.Add(Console.ReadLine());
                                        }
                                    }
                                    break;
                                default:
                                    break;
                            }

                        }
                        break;

                    case 5:
                        {
                            Console.WriteLine("Введите новую цену: ");
                            devices[changePos].Price = int.Parse(Console.ReadLine());
                        }
                        break;

                    case 6:
                        break;
                    default:
                        break;
                }

                Console.WriteLine("Вот как теперь выглядит данное устройство:");
                Console.WriteLine(devices[changePos]);
            }

            else
                Console.WriteLine("Устройства с подобным серийным номером у нас нет!");
        }
        public static void SearchByNumber(List<Device> devices)
        {
            Console.WriteLine("Введите название устройства, про которое хотите узнать побольше:");
            string DeviceName = Console.ReadLine();

            Device device = new Device();
            bool isFind = false;
            for (int i = 0; i < devices.Count; i++)
            {
                if (DeviceName == devices[i].DeviceName)
                {
                    Console.WriteLine(devices[i]);
                    isFind = true;
                }
            }

            if(isFind == false)
                Console.WriteLine("Подобного устойства у нас нет!");
        }
        public static void ShowAllDevices(List<Device> devices)
        {
            if (devices == null)
                Console.WriteLine("В базе нет ни одного устройства");
            else
            {
                foreach (Device item in devices)
                {
                    Console.WriteLine(item);
                }
            }
            
        }
        public static void ShowAllGuaratnees(List<Device> devices)
        {
            foreach (Device item in devices)
            {
                Console.WriteLine(item.Guarantee);
            }
        }
        public override string ToString()
        {
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("Название устройства: ");
            Console.WriteLine(DeviceName);
            Console.WriteLine("Серийный номер: ");
            Console.WriteLine(SerialNumber);
            Console.WriteLine();
            Console.WriteLine("Ответственные лица: ");
            foreach (var Person in ResponsiblePersons)
            {
                Console.WriteLine(Person);
            }
            return string.Format("\nТип устройства: {0}\n" +
                "ПО: {1}\nГарантия действует до: {2}\nСтоимость: {3}\n", TypeOfDevice, TypeOfSoftware, Guarantee, Price);
        }
    }
}
