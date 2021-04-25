using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechnicalService.Devices;
using TechnicalService.Organizations;
namespace TechnicalService
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            Organization organization = new Organization();
            List<Device> devices = new List<Device>();
            Device.AddDevice(devices);
            FillBranch(organization);
            FillAuxiliary(organization);
            Console.WriteLine("<---- Главное меню ---->");
            Console.WriteLine("1. База техники \n2. Все отделы и их сотрудники " +
                "\n3. Гарантийные сроки \n4. База партнёров и поставщиков");
            int choise = int.Parse(Console.ReadLine());
            switch (choise)
            {
                case 1:
                    {
                        bool exit = true;
                        while(exit == true)
                        {
                            Console.Clear();
                            Console.WriteLine("<---- База техники ---->");
                            Console.WriteLine("1. Добавить устройство \n2. Удалить устройство " +
                                "\n3. Изменить устройство \n4. Вывести все устройства\n5. Выход");
                            choise = int.Parse(Console.ReadLine());
                            switch (choise)
                            {
                                case 1:
                                    {
                                        Device.AddDevice(devices);
                                    }
                                    break;
                                case 2:
                                    {
                                        Device.DeleteDevice(devices);
                                    }
                                    break;
                                case 3:
                                    {
                                        Device.ChangeDevice(devices);
                                    }
                                    break;
                                case 4:
                                    {
                                        Device.ShowAllDevices(devices);
                                    }
                                    break;
                                case 5:
                                    {
                                        exit = false;
                                    }
                                    break;
                                default:
                                    break;
                            }
                            Console.WriteLine("<--- Нажмите любую клавишу для продолжения --->");
                            Console.ReadKey();
                        }
                        
                    }
                    break;
                case 2:
                    {
                        bool exit = true;
                        while (exit == true)
                        {
                            Console.Clear();
                            Console.WriteLine("<---- Отделы и их сотрудники ---->");
                            Console.WriteLine("1. Вывести все отделы \n2. Вывести сотрудников отдела " +
                                "\n3. Вывести всех сотрудников\n4. Выход");
                            choise = int.Parse(Console.ReadLine());
                            switch (choise)
                            {
                                case 1:
                                    {
                                        Branch.ShowAllBranches(organization);
                                    }
                                    break;
                                case 2:
                                    {
                                        Branch.ShowNameOnly(organization);
                                        Console.WriteLine();
                                        Console.WriteLine("Введите номер отдела");
                                        int br = int.Parse(Console.ReadLine());
                                        Console.WriteLine();
                                        Branch.ShowBranchesEmployees(organization, br);
                                    }
                                    break;
                                case 3:
                                    {
                                        Console.Clear();
                                        Console.WriteLine();
                                        Branch.ShowAllEmployee(organization);
                                    }
                                    break;
                                case 4:
                                    {
                                        exit = false;
                                    }
                                    break;
                                default:
                                    break;
                            }
                            Console.WriteLine("<--- Нажмите любую клавишу для продолжения --->");
                            Console.ReadKey();
                        }
                    }
                    break;
                case 3:
                    {
                        Console.WriteLine("<--- Все гарантийные сроки --->");
                        Device.ShowAllGuaratnees(devices);
                    }
                    break;
                case 4:
                    {
                        Console.WriteLine("1. Добавить новую информацию \n2. Посмотреть существующую");
                        int choiseBase = int.Parse(Console.ReadLine());
                        switch (choiseBase)
                        {
                            case 1:
                                {
                                    
                                    bool exit = true;
                                    while (exit == true)
                                    {
                                        Console.Clear();
                                        Console.WriteLine("1. В базу партнёров\n2. В базу поставщиков\n" +
                                        "3. В базу клиентов\n4. В базу потенциальных клиентов\n5. Выход");
                                        int chooseBase = int.Parse(Console.ReadLine());
                                        switch (chooseBase)
                                        {
                                            case 1:
                                                {
                                                    Organization.AddToPartners(organization);
                                                }
                                                break;
                                            case 2:
                                                {
                                                    Organization.AddToProviders(organization);
                                                }
                                                break;
                                            case 3:
                                                {
                                                    Organization.AddToCustomers(organization);
                                                }
                                                break;
                                            case 4:
                                                {
                                                    Organization.AddToPotentialClients(organization);
                                                }
                                                break;
                                            case 5:
                                                {
                                                    exit = false;
                                                }
                                                break;
                                            default:
                                                break;
                                        }
                                        Console.WriteLine("<--- Нажмите любую клавишу для продолжения --->");
                                        Console.ReadKey();
                                    }
                                    
                                }
                                break;
                            case 2:
                                {
                                    bool exit = true;
                                    while (exit == true)
                                    {
                                        Console.Clear();
                                        Console.WriteLine("<---- База партнёров и поставщиков ---->");
                                        Console.WriteLine("1. Вывести всю базу \n2. Вывести базу партнёров " +
                                            "\n3. Вывести базу поставщиков\n4. Вывести базу клиентов\n" +
                                            "5. Вывести базу потенциальных клиентов \n6. Выход");
                                        choise = int.Parse(Console.ReadLine());
                                        switch (choise)
                                        {
                                            case 1:
                                                {
                                                    Organization.ShowAllInfo(organization);
                                                }
                                                break;
                                            case 2:
                                                {
                                                    Organization.ShowAllPartners(organization);
                                                }
                                                break;
                                            case 3:
                                                {
                                                    Organization.ShowAllProviders(organization);
                                                }
                                                break;
                                            case 4:
                                                {
                                                    Organization.ShowAllCustomers(organization);
                                                }
                                                break;
                                            case 5:
                                                {
                                                    Organization.ShowAllPotentialClients(organization);
                                                }
                                                break;
                                            case 6:
                                                {
                                                    exit = false;
                                                }
                                                break;
                                            default:
                                                break;
                                        }
                                        Console.WriteLine("<--- Нажмите любую клавишу для продолжения --->");
                                        Console.ReadKey();
                                    }
                                }
                                break;
                            default:
                                break;
                        }
                        
                    }
                    break;
                default:
                    break;
            }
        }

        public static void FillBranch(Organization organization)
        {
            Random rnd = new Random();
            organization.Branches = new List<Branch>();
            for (int i = 0; i < 2; i++)
            {
                Branch branch = new Branch();
                branch.ContactInfo = new List<string>();
                branch.Staff = new List<Employee>();

                int num = rnd.Next(100, 999);
                int num2 = rnd.Next(10, 99);
                int num3 = rnd.Next(10, 99);
                int job = rnd.Next(1, 4);

                string contactInfo = "+7 (707)" + " " + num.ToString() + " " + num2.ToString() + " " + num3.ToString();
                branch.ContactInfo.Add(contactInfo);
                branch.Name = string.Format("Name_{0}", rnd.Next(1, 100));
                branch.Id = rnd.Next().ToString();

                for (int j = 0; j < 5; j++)
                {
                    Employee employee = new Employee();
                    employee.FullName = string.Format("FullName_{0}", rnd.Next(1, 100));
                    employee.Id = rnd.Next();
                    employee.WorkingPlace = branch;
                    employee.Job = string.Format("Job_{0}", rnd.Next(1, 5));
                    branch.Staff.Add(employee);
                }
                

                organization.Branches.Add(branch);
            }
        }
        public static void FillAuxiliary(Organization organization)
        {
            Random rnd = new Random();
            organization.Customers = new List<Auxiliary>();
            organization.Partners = new List<Auxiliary>();
            organization.PotentialClients = new List<Auxiliary>();
            organization.Providers = new List<Auxiliary>();
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
    }
}
