using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace LinqQueries
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>()
            {
                new Employee(){Id = 1,Name = "Tom", Email = "tom@gmail.com",Programming = new (){"C#","Java","C++" } },
                new Employee(){Id = 2,Name = "John", Email = "john@gmail.com",Programming = new (){"html","css","Javascript"} },
                new Employee(){Id = 3,Name = "Mark", Email = "mark@gmail.com",Programming = new (){"C#","Java","C++" } },
                new Employee(){Id = 4,Name = "Kim", Email = "kim@gmail.com",Programming = new (){"html","css","Javascript"} },
                new Employee(){Id = 5,Name = "Adam", Email = "adam@gmail.com",Programming = new (){"html","css","Javascript"} }

            };

            List<string> lists = new List<string>
            {
                "Soner",
                "Mehmet"
            };

            List<int> values = new List<int>()
            {
                1,32,3,4,5,88,7,8,9
            };

            var dataSource = new List<object>() { "Soner", "Ahmet", "Mehmet", 1, 12, 2, 3, 5, 78 };

            Student[] students =
            {
                new Student {Name = "Soner", Mark = 90},
                new Student{Name="Bob",Mark = 80},
                new Student{Name="John",Mark = 75},

            };

            Student[] stdList =
            {
                new Student {StudentId  = 1,Name = "Soner"},
                new Student{StudentId  = 2,Name="Bob"},
                new Student{StudentId  = 1,Name="Soner"},
                new Student{StudentId  = 4,Name="Mark"},


            };

            List<string> str1 = new List<string> { "A", "B", "C", "D" };
            List<string> str2 = new List<string> { "C", "D", "E", "F" };


            Student[] allStudents =
            {
                new Student {Name = "Soner"},
                new Student{Name = "Ahmet"},
                new Student{Name = "Mehmet"},
                new Student {Name = "Derya"},
                new Student{Name = "Lale"},
                new Student{Name = "Fahir"},
                new Student{Name = "Tahir"},
                new Student{Name = "Selen"},

            };

            Student[] mathStudents =
            {
                new Student {Name = "Rumeysa"},
                new Student{Name = "Selma"},
                new Student{Name = "Soner"},
                new Student {Name = "Mehmet"},
                new Student{Name = "Ceren"},
                new Student{Name = "Berna"},

            };

            int[] nums = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 2 };
            string[] names = new string[] { "Soner", "Ahmet", "Mehmet", "Derya", "Rumeysa", "Ada" };


            var workers = new List<Worker>()
            {
                new Worker {Id = 1, FirstName = "Oliver" , AddressId = 1,ManagerId = 1},
                new Worker {Id = 2, FirstName = "Jack" , AddressId =2,ManagerId = 1},
                new Worker {Id = 3, FirstName = "Allison" , AddressId = 7,ManagerId = 1},
                new Worker {Id = 4, FirstName = "Sterling" , AddressId =9,ManagerId = 1 }

            };

            var addresses = new List<Address>()
            {
                new Address{Id = 1, Street = "London"},
                new Address{Id = 2, Street = "Manchester"},
                new Address{Id = 3, Street = "Street 1"},
                new Address{Id = 4, Street = "Street 2"},


            };

            var managers = new List<Manager>()
            {
                new Manager {Id = 1,ManagerName = "Soner"},
            };

            var students1 = new List<Student>()
            {
                new Student {StudentId = 1,StudentName = "Oliver" , CategoryId = 1},
                new Student {StudentId = 2,StudentName = "Jack" , CategoryId = 1},
                new Student {StudentId = 3,StudentName = "Allison" , CategoryId = 2},
                new Student{StudentId = 5,StudentName = "Soner" , },

                new Student{StudentId = 4,StudentName = "Sterling" , CategoryId = 2},
                new Student{StudentId = 5,StudentName = "Soner" , CategoryId = 3},




            };

            var students2 = new List<Student>()
            {
                new Student {StudentId = 1,StudentName = "Oliver" , AddressId = 1},
                new Student {StudentId = 2,StudentName = "Jack" , AddressId = 1},
                new Student {StudentId = 3,StudentName = "Allison" , AddressId = 2},
                new Student{StudentId = 5,StudentName = "Soner"},
                new Student{StudentId = 4,StudentName = "Sterling" , AddressId = 4},
                new Student{StudentId = 5,StudentName = "Soner" , AddressId = 3},
                new Student{StudentId = 5,StudentName = "Merih"},

            };


            var adres = new List<Address>()
            {
                new Address{Id = 1, Street = "St1"},
                new Address{Id = 2, Street = "St2"},
                new Address{Id = 3, Street = "St3"},
                new Address{Id = 4, Street = "St4"},
            };



            var categories = new List<Category>()
            {
                new Category{Id= 1,CategoryName = "A"},
                new Category{Id= 2,CategoryName = "B"},
                new Category{Id= 3,CategoryName = "C"},
                new Category{Id= 4,CategoryName = "D"},
                new Category{Id= 5,CategoryName = "E"},
                new Category{Id= 6,CategoryName = "F"},


            };

            int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
            string[] names2 = new string[] { "Soner", "Ahmet", "Mehmet" };





            #region LINQ Queries

            #region LINQ - SELECT
            //Projection - is used to select data from data source and creating a new form of data.
            // We can select data as original form and also can be selected by applying some operations on it.

            //selectTest(employees);

            //Operations------
            //List of integers Id.
            var basicQuery = employees.Select(emp => emp.Id).ToList();
            //List of strings Id.
            var basicQuery1 = employees.Select(emp => emp.Id.ToString()).ToList();

            //New instance of an employee
            //selectOneClass(employees);

            //Appends data from employee class to student class.
            //selectTestStudent(employees);

            //returns the data with their index vaule.
            //selectIndexQuery(employees);


            #endregion

            #region LINQ - SELECTMANY

            //selectManyCharTest(lists);
            //selectManyMQueryTest(lists);

            //var result = employees.SelectMany(emp => emp.Programming).ToList();

            //selectManyQueryTest1(employees);
            #endregion

            #region LINQ - WHERE | FILTERING OPERATOR

            //With where operator we are filtering data and also can be added multiple conditions.
            //whereTest(values);


            #endregion

            #region LINQ -  OfType | FILTERING OPERATOR

            //OfType(dataSource);

            #endregion

            #region Sorting Operators | asc & dsc | 
            //Sorting is used to manage in a particular order

            #region OrderBy - Sorts data in ascending order

            //orderByTest(values);

            #endregion

            #region OrderByDescending - Sorts data in descending order

            //orderByDescendingTest(values);

            #endregion


            #region ThenBy and ThenByDescending -- 2 lvl condition sorting

            //thenByTest(employees);

            //thenByDescending(employees);


            #endregion


            #region Reverse

            //lists.Reverse();
            //foreach (var item in lists)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion
            #endregion

            #region Quantifier Operators -Boolean

            #region All
            //AllTest(students);
            #endregion

            #region Any - returns Boolean
            //AnyTest(students);

            //var res = (from std in students
            //          select std).Any(s=>s.StudentId > 5);

            #endregion

            #region Contains - returns Boolean

            //ContainTest(lists);

            #endregion

            #endregion

            #region Set -(Kume) | Operations

            #region Distinct - Returns no duplicate element


            //distinctTest(stdList);



            #endregion

            #region Except - Returns values that d1 has that d2 dosen't exist those datas.

            //exceptTest(str1, str2);

            //exceptTest1(allStudents, mathStudents);

            #endregion

            #region Intersect - Returns common datas in both data sources.

            //IntersectTest(allStudents, mathStudents);




            #endregion

            #region Union - Combines multiple data sources and removes duplicates.

            //UnionTest(allStudents, mathStudents);


            #endregion

            #endregion

            #region Partitioning Data Operations - Divide data into two part and return one of them witout changing.

            #region Take - Returns top n number of the elements.

            //TakeTest(values);


            #endregion

            #region TakeWhile - Until condition is true.

            //1.
            // TakeWhileTest(nums);

            //2.
            //TakeWhileTest2(names);
            #endregion

            #region Skip - skips first n num of records and selects the remaining element/s.

            // SkipTest(nums);

            #endregion

            #region Skip While - Is used to skip all records from data source until condition is true.

            //SkipWhileTest(nums);





            #endregion

            #endregion

            #region Pagign - Is process of dividing n num of records into multiple pages. Using skip and take operator.

            //PageTest();



            #endregion

            #region Joins - Is used to get Multiple data sources.

            #region Inner Join - Gets common elements both L + R.
            //JoinTest(workers, addresses);




            #endregion

            #region Inner Join - Multiple table.
            //InnerJoinTest(workers, addresses, managers);

            #endregion

            #region GroupJoin - Is used to group the result based on a common key.
            //GroupJoinTest(students1, categories);



            #endregion

            #region LeftJoin - Is used to return all records from the first data source.

            //LeftJoinTest(students2, adres);


            #endregion


            #endregion

            #region Element Operations - Are used to return one specific record.

            #region ElementAt or ElementAtOrDefault - Used to return an element from a specific index
            //ElementAtandOrDefaultTest(numbers);
            #endregion

            #region First or FirstOrDefault - Used to return First element from a datasource

            //FirstOrDefaultTest(numbers);

            #endregion

            #region Last or LastOrDefault - Used to return Last element from a datasource

            //LastOrDefaultTest(numbers);

            #endregion

            #region Single or SingleOrDefault - Used to return single element from a datasource.

            //SingleOrDefaultTest(numbers);


            #endregion
            #endregion


            #endregion
        }

        private static void SingleOrDefaultTest(int[] numbers)
        {
            var ms = numbers.Single();
            var ms1 = numbers.Single(x => x < 2);
            var ms2 = numbers.SingleOrDefault(x => x < 3);

            var qs = (from num in numbers
                      select num).Single();

            var qs1 = (from num in numbers
                       select num).SingleOrDefault();
        }
        private static void LastOrDefaultTest(int[] numbers)
        {
            var ms = numbers.Last();
            var ms1 = numbers.Last(x => x < 2);
            var ms2 = numbers.LastOrDefault(x => x < 3);

            var qs = (from num in numbers
                      select num).Last();

            var qs1 = (from num in numbers
                       select num).LastOrDefault();
        }
        private static void FirstOrDefaultTest(int[] numbers)
        {
            var ms = numbers.First();
            var ms1 = numbers.First(x => x < 2);
            var ms2 = numbers.FirstOrDefault(x => x < 3);

            var qs = (from num in numbers
                      select num).First();

            var qs1 = (from num in numbers
                       select num).FirstOrDefault();
        }
        private static void ElementAtandOrDefaultTest(int[] numbers)
        {
            var ms = numbers.ElementAt(4);
            var ms1 = numbers.ElementAtOrDefault(2);

            var qs = (from num in numbers
                      select num).ElementAt(4);

            var qs1 = (from num in numbers
                       select num).ElementAtOrDefault(3);
        }
        private static void LeftJoinTest(List<Student> students2, List<Address> adres)
        {
            var qs = (from std in students2
                      join ad in adres
                      on std.AddressId equals ad.Id into stdAddress
                      from studentAddress in stdAddress.DefaultIfEmpty()
                      select new
                      {
                          StudentName = std.StudentName,
                          StudentAddress = studentAddress != null ? studentAddress.Street : "NA"
                      }).ToList();

            //foreach (var item in qs)
            //{
            //    Console.WriteLine($"StudentName: {item.StudentName}   Address: {item.StudentAddress}");
            //}


            var ms = students2.GroupJoin(adres,
                                std => std.AddressId,
                                add => add.Id,
                                (std, add) => new { std, add })
                                .SelectMany(x =>
                                x.add.DefaultIfEmpty(),
                                (studentData, addressData) => new
                                {
                                    studentData.std,
                                    addressData
                                }).ToList();

            foreach (var item in ms)
            {
                Console.WriteLine($"StudentName: {item.std.StudentName}   Address: {item.addressData.Street}");
            }
        }
        private static void GroupJoinTest(List<Student> students1, List<Category> categories)
        {
            var ms = categories.GroupJoin(students1, c => c.Id, s => s.CategoryId, (c, s) => new { c, s });

            foreach (var item in ms)
            {
                Console.WriteLine($"Categories: {item.c.CategoryName}");
                foreach (var s in item.s)
                {
                    Console.WriteLine($"Students: {s.StudentName}");
                }
            }

            var qs = from c in categories
                     join st in students1
                     on c.Id equals st.CategoryId
                     into stdGroups
                     select new { c, stdGroups };

            //foreach (var item in qs)
            //{
            //    Console.WriteLine($"Categories: {item.c.CategoryName}");
            //    foreach (var c in item.stdGroups)
            //    {
            //        Console.WriteLine($"Students: {c.StudentName}");
            //    }
            //}
        }
        private static void InnerJoinTest(List<Worker> workers, List<Address> addresses, List<Manager> managers)
        {
            var ms = workers.Join(addresses,
                                wk => wk.AddressId,
                                ad => ad.Id,
                                (wk, ad) => new { wk, ad })
                                .Join(managers,
                                wk => wk.wk.ManagerId,
                                mn => mn.Id,
                                (wk, mn) => new { wk, mn })
                                .Select(x => new
                                {
                                    Name = x.wk.wk.FirstName,
                                    Street = x.wk.ad.Street,
                                    ManagerName = x.mn.ManagerName,
                                }).ToList();


            var qs = from wk in workers
                     join ad in addresses
                     on wk.AddressId equals ad.Id
                     join mn in managers
                     on wk.ManagerId equals mn.Id
                     select new
                     {
                         WorkerName = wk.FirstName,
                         Street = ad.Street,
                         ManagerName = mn.ManagerName
                     };

            foreach (var item in ms)
            {
                Console.WriteLine($"WorkerName : {item.Name}\t| Street : {item.Street}\t| ManagerName : {item.ManagerName}");
            }
        }
        private static void JoinTest(List<Worker> workers, List<Address> addresses)
        {
            var ms = workers.Join(addresses,
                                    wk => wk.AddressId,
                                    ad => ad.Id,
                                    (wk, ad) => new
                                    {
                                        Name = wk.AddressId,
                                        Street = ad.Id,
                                    }).ToList(); ;
            foreach (var item in ms)
            {
                Console.WriteLine($"Name: {item.Name} Street: {item.Street}");
            }

            var qs = from worker in workers
                     join adress in addresses
                     on worker.AddressId equals adress.Id
                     select new
                     {
                         WorkerName = worker.FirstName,
                         AddressLine = adress.Street
                     };


            foreach (var item in qs)
            {
                Console.WriteLine($"Name: {item.WorkerName} Address: {item.AddressLine}");
            }
        }
        private static void PageTest()
        {
            int totalPagePerView = 4;

            do
            {
                Console.Write("Enter page number: ");
                if (int.TryParse(Console.ReadLine(), out int pageNumber))
                {
                    var result = GetEmployees().Skip((pageNumber - 1) * totalPagePerView).Take(totalPagePerView).ToList();
                    foreach (var item in result)
                    {
                        Console.WriteLine($"Id: {item.Id} Name: {item.Name}");
                    }
                }
                else
                {
                    Console.WriteLine("Enter a valid page number");
                }

            } while (true);
        }
        //Method for PageTest
        public static List<Employee> GetEmployees()
        {
            return new List<Employee>
            {
                new Employee {Id = 1, Name = " Oliver Jake"},
                new Employee {Id = 2, Name = " Jack\tConnor"},
                new Employee {Id = 3, Name = " Harry\tCallum"},
                new Employee {Id = 4, Name = " Jacob\tJacob"},
                new Employee {Id = 5, Name = " Charlie\tKyle"},
                new Employee {Id = 6, Name = " Thomas\tJoe"},
                new Employee {Id = 7, Name = " George\tReece"},
                new Employee {Id = 8, Name = " Oscar\tRhys"},
                new Employee {Id = 9, Name = " James\tCharlie"},
                new Employee {Id = 10, Name = " William\tDamian"},
                new Employee {Id = 11, Name = " Amelia\tMargaret"},
                new Employee {Id = 12, Name = " Olivia\tSamantha"},
                new Employee {Id = 13, Name = " Isla\tBethany"},
                new Employee {Id = 14, Name = " Emily\tElizabeth"},
                new Employee {Id = 15, Name = " Poppy\tJoanne"},
                new Employee {Id = 16, Name = " Ava\tMegan"},
                new Employee {Id = 17, Name = " Isabella\tVictoria"},
                new Employee {Id = 18, Name = " Jessica\tLauren"},
                new Employee {Id = 19, Name = " Lily\tMichelle"},
                new Employee {Id = 20, Name = " Sophie\tTracy"},


            };
        }
        private static void SkipWhileTest(int[] nums)
        {
            var ms = nums.SkipWhile(n => n < 6).ToArray();
            var msq = (from n in nums select n).SkipWhile(n => n < 6).ToArray();
            foreach (var item in msq)
            {
                Console.WriteLine(item);
            }
        }
        private static void SkipTest(int[] nums)
        {
            var ms = nums.Skip(6).ToList();
            var ms1 = nums.Where(n => n > 3).Skip(2).ToList();
            var ms2 = (from n in nums select n).Skip(4).ToList();

            foreach (var item in ms2)
            {
                Console.WriteLine(item);
            }
        }
        private static void TakeWhileTest2(string[] names)
        {
            //While length > index works.
            var ms1 = names.TakeWhile((name, index) => name.Length > index).ToList();
            foreach (var item in ms1)
            {
                Console.WriteLine(item);
            }
        }
        private static void TakeWhileTest(int[] nums)
        {
            //1,2,3 output. Condition works until number 10 checks...
            var ms = nums.TakeWhile(n => n < 10).ToArray();

            foreach (var item in ms)
            {
                Console.WriteLine(item);
            }
        }
        private static void TakeTest(List<int> values)
        {
            var ms = values.Take(4).ToList();
            var mixedS = (from m in values select m).Take(7).ToList();

            foreach (var item in mixedS)
            {
                Console.WriteLine(item);
            }
        }
        private static void UnionTest(Student[] allStudents, Student[] mathStudents)
        {
            var result = allStudents.Union(mathStudents).ToList();

            foreach (var item in result)
            {
                Console.WriteLine(item.Name);
            }
        }
        private static void IntersectTest(Student[] allStudents, Student[] mathStudents)
        {
            var result = allStudents.Select(s => s.Name).Intersect(mathStudents.Select(m => m.Name)).ToList();
            foreach (var item in result)
            {
                Console.WriteLine("Name : {0}", item);
            }

            var result2 = (from all in allStudents
                           select all.Name).Intersect(mathStudents.Select(m => m.Name)).ToList();

            foreach (var item in result2)
            {
                Console.WriteLine("Name : {0}", item);
            }
        }
        private static void exceptTest1(Student[] allStudents, Student[] mathStudents)
        {
            var result = allStudents.Select(s => s.Name).Except(mathStudents.Select(m => m.Name)).ToList();
            foreach (var item in result)
            {
                Console.WriteLine($"Names: {item}");
            }
        }
        private static void exceptTest(List<string> str1, List<string> str2)
        {
            var result = str1.Except(str2).ToList();
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }
        private static void distinctTest(Student[] stdList)
        {
            var result = stdList.Distinct().ToList();
        }
        private static void ContainTest(List<string> lists)
        {
            var iSExist = lists.AsEnumerable().Contains("Soner");
        }
        private static void AnyTest(Student[] students)
        {
            var result = students.Any(s => s.Mark > 96);
        }
        private static void AllTest(Student[] students)
        {
            bool result = (students.All(s => s.Mark >= 75));

            bool result2 = (from student in students
                            select student).All(x => x.Mark > 70);
        }
        private static void thenByDescending(List<Employee> employees)
        {
            var result = employees.OrderByDescending(emp => emp.Id).ThenByDescending(emp => emp.Name).ToList();

            foreach (var item in result)
            {
                Console.WriteLine($"Id {item.Id} Name: {item.Name}");
            }
            var result2 = from emp in employees
                          orderby emp.Id descending,
                          emp.Name descending
                          select emp;
        }
        private static void thenByTest(List<Employee> employees)
        {
            var result = employees.OrderBy(emp => emp.Id).ThenBy(emp => emp.Name).ToList();
            foreach (var item in result)
            {
                Console.WriteLine($"Id {item.Id} Name: {item.Name}");
            }

            var result2 = (from emp in employees
                           orderby emp.Id ascending,
                           emp.Name ascending
                           select emp).ToList();

            foreach (var item in result2)
            {
                Console.WriteLine($"Id {item.Id} Name: {item.Name}");
            }
        }
        private static void orderByDescendingTest(List<int> values)
        {
            var res = values.OrderByDescending(v => v).ToList();
            foreach (var item in res)
            {
                Console.WriteLine(item);
            }

            var res2 = from val in values
                       orderby val descending
                       select val;

            foreach (var item in res2)
            {
                Console.WriteLine(item);
            }
        }
        private static void orderByTest(List<int> values)
        {
            var res = values.OrderBy(values => values).ToList();

            var res2 = (from val in values
                        orderby val
                        select val).ToList();

            foreach (var item in res)
            {
                Console.WriteLine(item);
            }
        }
        private static void OfType(List<object> dataSource)
        {
            var res = dataSource.OfType<string>().ToList();
            foreach (var item in res)
            {
                Console.WriteLine(item);
            }

            var res2 = (from dS in dataSource
                        where dS is string
                        select dS).ToList();

            foreach (var item in res2)
            {
                Console.WriteLine(item);
            }
        }
        private static void whereTest(List<int> values)
        {
            var intResult = values.Where(v => v >= 3).ToList();
            foreach (var item in intResult)
            {
                Console.WriteLine(item);
            }
        }
        private static void selectManyQueryTest1(List<Employee> employees)
        {
            var result2 = (from emp in employees
                           from skill in emp.Programming
                           select skill).ToList();

            foreach (var item in result2)
            {
                Console.WriteLine($"Programming : {item}");
            }
        }
        private static void selectManyMQueryTest(List<string> lists)
        {
            var mQuery = (from rec in lists
                          from ch in rec
                          select ch).ToList();

            foreach (var item in mQuery)
            {
                Console.WriteLine(item);
            }
        }
        private static void selectManyCharTest(List<string> lists)
        {
            var lQuery = lists.SelectMany(l => l).ToList();
            foreach (var item in lQuery)
            {
                Console.WriteLine(item);
            }
        }
        private static void selectIndexQuery(List<Employee> employees)
        {
            var selectQuery = employees.Select((emp, index) => new { Index = index, FullName = emp.Name }).ToList();

            foreach (var emp in selectQuery)
            {
                Console.WriteLine($"Index = {emp.Index} , FullName = {emp.FullName} ");
            }
        }
        private static void selectTestStudent(List<Employee> employees)
        {
            var stResult = (from emp in employees
                            select new Student
                            {
                                StudentId = emp.Id,
                                FullName = emp.Name,
                                StEmail = emp.Email,
                            }).ToList();

            Console.WriteLine("Student Data");
            foreach (var st in stResult)
            {
                Console.WriteLine($"Id = {st.StudentId} , Name = {st.FullName} , Email = {st.StEmail}");
            }
        }
        private static void selectOneClass(List<Employee> employees)
        {
            var resultData = (from emp in employees
                              select new Employee
                              {
                                  Id = emp.Id,
                                  Name = emp.Name,
                                  Email = emp.Email

                              }).ToList();

            foreach (var emp in resultData)
            {
                Console.WriteLine($"Id = {emp.Id} , Name = {emp.Name} , Email = {emp.Email}");
            }
        }
        private static void selectTest(List<Employee> employees)
        {
            var basicQuery = (from emp in employees
                              select emp).ToList();

            foreach (var emp in employees)
            {
                Console.WriteLine($"Id = {emp.Id} Name = {emp.Name} Email = {emp.Email}");
            }
        }

    }

}
