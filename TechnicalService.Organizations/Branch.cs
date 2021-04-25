using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechnicalService.Organizations
{
    public class Branch
    {
        public List<Employee> Staff { get; set; }
        public string Name { get; set; }
        public List<string> ContactInfo { get; set; }
        public string Id { get; set; }

        public static void AddBranch(Organization organization, string BranchId)
        {
            foreach (Branch item in organization.Branches)
            {
                if (item.Id == BranchId)
                {
                    Console.WriteLine("---------------------------------");
                    Console.WriteLine("---------------------------------");
                    Console.WriteLine(item);
                    Console.WriteLine("---------------------------------");
                    Console.WriteLine("---------------------------------");

                    Console.WriteLine("Что вы хотите дополнить?\n" +
                        "1. Контактную информацию");
                    int choise = int.Parse(Console.ReadLine());
                    switch (choise)
                    {
                        case 1:
                            {
                                Console.WriteLine("Введите дополнительную контактную информацию");
                                item.ContactInfo.Add(Console.ReadLine());
                            }
                            break;
                        default:
                            break;
                    }
                    Console.WriteLine("---------------------------------");
                    Console.WriteLine("---------------------------------");
                    Console.WriteLine(item);
                    Console.WriteLine("---------------------------------");
                    Console.WriteLine("---------------------------------");
                    break;
                }
            }
        }
        public static void DeleteBranch(Organization organization, string BranchId)
        {
            foreach (Branch item in organization.Branches)
            {
                if (item.Id == BranchId)
                {
                    Console.WriteLine("---------------------------------");
                    Console.WriteLine("---------------------------------");
                    Console.WriteLine(item);
                    Console.WriteLine("---------------------------------");
                    Console.WriteLine("---------------------------------");

                    Console.WriteLine("Что вы хотите удалить?\n1. Название\n" +
                        "2. Контактную информацию\n3. ID");
                    int choise = int.Parse(Console.ReadLine());
                    switch (choise)
                    {
                        case 1:
                            {
                                item.Name = "";
                            }
                            break;
                        case 2:
                            {
                                item.ContactInfo.Clear();
                            }
                            break;
                        case 3:
                            {
                                item.Id = "";
                            }
                            break;
                        default:
                            break;
                    }
                    Console.WriteLine("---------------------------------");
                    Console.WriteLine("---------------------------------");
                    Console.WriteLine(item);
                    Console.WriteLine("---------------------------------");
                    Console.WriteLine("---------------------------------");
                    break;
                }
            }
        }
        public static void ChangeBranch(Organization organization, string BranchId)
        {
            foreach (Branch item in organization.Branches)
            {
                if (item.Id == BranchId)
                {
                    Console.WriteLine("---------------------------------");
                    Console.WriteLine("---------------------------------");
                    Console.WriteLine(item);
                    Console.WriteLine("---------------------------------");
                    Console.WriteLine("---------------------------------");

                    Console.WriteLine("Что вы хотите изменить? \n1. Название " +
                        "\n2. Контактную информацию \n3. ID");
                    int choise = int.Parse(Console.ReadLine());
                    switch (choise)
                    {
                        case 1:
                            {
                                Console.WriteLine("Введите новое название");
                                item.Name = Console.ReadLine();

                            }
                            break;
                        case 2:
                            {
                                Console.WriteLine("Введите новую контактную информацию");
                                item.ContactInfo.Clear();
                                item.ContactInfo.Add(Console.ReadLine());
                            }
                            break;
                        case 3:
                            {
                                Console.WriteLine("Введите новое ID");
                                item.Id = Console.ReadLine();
                            }
                            break;

                        default:
                            break;
                    }
                    Console.WriteLine("---------------------------------");
                    Console.WriteLine("---------------------------------");
                    Console.WriteLine(item);
                    Console.WriteLine("---------------------------------");
                    Console.WriteLine("---------------------------------");
                    break;
                }
            }
        }
        public static void ShowAllBranches(Organization organization)
        {
            foreach (Branch item in organization.Branches)
            {
                Console.WriteLine(item);
            }
        }
        public static void CreateEmployee(Organization organization, string BranchId)
        {
            Random rnd = new Random();
            Employee employee = new Employee();
            employee.FullName = string.Format("FullName_{0}", rnd.Next(1, 100));
            employee.Job = string.Format("Job_{0}", rnd.Next(1, 10));
            employee.Id = rnd.Next();
            bool isFind = false;
            foreach (var item in organization.Branches)
            {
                if(item.Id == BranchId)
                {
                    employee.WorkingPlace = item;
                    item.Staff.Add(employee);
                    isFind = true;
                    break;
                }
            }

            if (isFind == false)
                Console.WriteLine("Отделения с подобным ID у нас нет!");
        }
        public static void ChangeEmployee(Organization organization, int Employeeid)
        {
            Random rnd = new Random();

            bool isFind = false;
            foreach (var item in organization.Branches)
            {
                foreach (var worker in item.Staff)
                {
                    if(worker.Id == Employeeid)
                    {
                        Console.WriteLine("Что вы хотите изменить?\n1. Имя \n2. Должность");
                        int choise = int.Parse(Console.ReadLine());

                        switch (choise)
                        {
                            case 1:
                                {
                                    worker.FullName = Console.ReadLine();
                                }
                                break;
                            case 2:
                                {
                                    worker.Job = Console.ReadLine();
                                }
                                break;
                            default:
                                break;
                        }
                    }
                }
            }

            if (isFind == false)
                Console.WriteLine("Отделения с подобным ID у нас нет!");
        }
        public static void DeleteEmployee(Organization organization, int Employeeid)
        {
            Random rnd = new Random();

            bool isFind = false;
            foreach (var item in organization.Branches)
            {
                foreach (var worker in item.Staff)
                {
                    if (worker.Id == Employeeid)
                    {
                        
                    }
                }
            }

            for (int i = 0; i < organization.Branches.Count; i++)
            {
                for (int j = 0; j < organization.Branches[i].Staff.Count; j++)
                {
                    if(organization.Branches[i].Staff[j].Id == Employeeid)
                    {
                        organization.Branches[i].Staff.RemoveAt(j);
                        isFind = true;
                        break;
                    }
                }
                if (isFind == true)
                    break;
            }

            if (isFind == false)
                Console.WriteLine("Отделения с подобным ID у нас нет!");
        }
        public static void ShowAllEmployee(Organization organization)
        {
            foreach (Branch item in organization.Branches)
            {
                foreach (Employee employee in item.Staff)
                {
                    Console.WriteLine(employee);
                }
            }
        }
        public static void ShowNameOnly(Organization organization)
        {
            int cnt = 1;
            foreach (Branch item in organization.Branches)
            {
                Console.WriteLine("--------------------");
                Console.WriteLine("--------------------");
                Console.WriteLine();
                Console.WriteLine("Отдел №" + cnt);
                Console.WriteLine(item.Name);
                cnt++;
            }
        }
        public static void ShowBranchesEmployees(Organization organization, int br)
        {
            for (int i = 0; i < organization.Branches[br-1].Staff.Count; i++)
            {
                Console.WriteLine(organization.Branches[br-1].Staff[i]);
            }
        }
        public override string ToString()
        {
            Console.WriteLine();
            Console.WriteLine("---------------------------");
            Console.WriteLine("---------------------------");

            Console.WriteLine("Информация по работникам: \n");
            foreach (Employee item in Staff)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\nКонтактная информация отдела: \n");
            foreach (var item in ContactInfo)
            {
                Console.WriteLine(item);
            }

            return string.Format("Название отдела: {0}\nID отдела: {1}", Name, Id);
        }
    }
}
