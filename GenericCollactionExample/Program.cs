using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace GenericCollactionExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            string[] isimler = new string[9];
            isimler[0] = "Dilara";
            isimler[1] = "Merve";
            isimler[2] = "Alpaslan";
            //...
            isimler[8] = "Erhan";

            List<string> list = new List<string>();
            list.Add("Dilara");
            list.Add("Merve");
            list.Add("Erhan");
            list.Add("Yasir");
            list.Add("Ayşe");//Default olarak 4 taneyle başlar. Sonrasında listenin boyutunu
            //8,16 şeklinde iki katına çıkara çıkara devam eder.


            foreach(string item in isimler) 
            {
                if (!(String.IsNullOrEmpty(item)))
                {
                    Console.WriteLine(item);
                }
            }
            Console.WriteLine("");
            foreach (string item in list)
            {
               
                    Console.WriteLine(item);
                
            }
            List<string[]> kisiler = new List<string[]>();
            string[] newinformatin1 = { "Erhan", "Kaya", "33", "Erkek" };
            kisiler.Add(newinformatin1);
            string[] newinformatin2 = { "İsmail", "Güleç", "25", "Erkek","Yazar" };
            kisiler.Add(newinformatin2);
            kisiler.Add(new string[] { "Yasir","Akkaya" });

            List<string[]> kisiler2 = new List<string[]>//initialized-Liste oluştururken default veri oluşturma
            {
                new string[]{"İsmail","Güleç"},
                new string[]{"Ali","Durak"},
                new string[]{"Yasir","Akkaya"},
                new string[]{"Salih","Enes"},
            };

            foreach (string[] item in kisiler2)
            {
                int sayi = item.Length;int subindex = 0;
                foreach (string item2 in item)
                {
                    subindex++;
                    if (sayi == subindex) continue;
                    
                    Console.Write(item2 + " - ");
                }

                Console.WriteLine();
            }

            //Arraylerde length Listelerde Count Array.Count

            
            Dictionary<int,string> keyValuePairs = new Dictionary<int,string>();
            keyValuePairs.Add(1,"sadaf");

            Dictionary<string, string> keyValuePairs1 = new Dictionary<string, string>()
            {
                {"c","Erhan"},
                {"a","Memet"},
                {"b","Ayhan"},
            };

            if (keyValuePairs1.ContainsKey("c"))
            {
                Console.WriteLine(keyValuePairs1["c"]);
            }

            Console.WriteLine();

            Dictionary<string, string> Users = new Dictionary<string, string>()
            {
                {"erhan@kaya.com","123123" },
                {"ismail@gulec.com","123" },
                {"merve@kavlak.com","123" },
                {"adem@karagulle.com","123"},
            };

            Console.Write("Enter password: ");
            string password = Console.ReadLine();
            Console.Write("Enter Email: ");
            string email = Console.ReadLine();

            if (Users.ContainsKey(email) && Users[email] ==password)
            {
                Console.WriteLine("Giriş Başarılı");
            }
            else
            {
                Console.WriteLine("Giriş Hatalı");
            }
            Dictionary<string, string[]> UserList = new Dictionary<string, string[]>()
            {
                {"ismail@gulec.com",new string[]{"123","İsmail","Güleç"} },
                {"eslem@tifi.com",new string[]{"1234","Eslem","Tifi"} },
            };

            string getEmail = "ismail@gulec.com";
            string getPassword = "123";

            if (UserList.ContainsKey(getEmail))
            {
                if (UserList[getEmail][0] ==getPassword)
                {
                    Console.WriteLine($"Hoşgeldin {UserList[getEmail][1]} {UserList[getEmail][2]}");
                }
            }
            */

            /*
            List<User> users = new List<User>()
            {
                new User {Id=4,Name="Ali",Surname="Durak",Email="ali@durak.com",Password="123"},
                new User {Id=5,Name="Salih",Surname="Özdel",Email="salih@özdel.com",Password="123"},
                new User {Id=6,Name="Furkan",Surname="Ermiş",Email="furkan@ermiş.com",Password="123"},
            };
            users.Add(new User() { Id=1,Name="İsmail",Surname="Güleç",Email="ismail@gulec.com",Password="123"});
            User user = new User();
            user.Id = 2;
            user.Name = "Fatih";
            user.Surname = "Sezer";
            user.Email = "fatih@sezer.com";
            user.Password = "123";
            users.Add(user);

            User user1 = new User()
            {
                Id = 1,
                Name="Yasir",
                Surname="Akkaya",
                Email="yasir@akkaya.com",
                Password="123"
            };

            users.Add(user1);

            foreach (var item in users)
            {
                Console.WriteLine($"{item.Id}.\t{item.Name}\t{item.Surname}");
            };

            var findUser = users.FirstOrDefault(value => value.Id ==1);//tekil nesne çekme
            Console.WriteLine();
            Console.WriteLine(findUser.Name);

            var findUser2 = users.Where(x => x.Id == 1).ToList();//liste nesnesi çeker eğer bunun yerine firstOrDefault yazarsak tekil çekme olmuş olur.

            foreach (var item in findUser2)
            {
                Console.WriteLine(item.Surname);
            };

            var deleteUser = users.FirstOrDefault(x=> x.Id==4); //Kişiyi bul

            if (deleteUser != null)//Bulunan kişi varmı
            {
                users.Remove(deleteUser);//varsa bu kişiyi nesne olarak listeden çıkar.
            }

            foreach (var item in users)//Kalan kullanıcıları listeleme
            {
                Console.WriteLine($"{item.Name} {item.Surname}");
            }
            */
            /*
            Stack<string> stack = new Stack<string>();//LIFO last in first out
            stack.Push("A");
            stack.Push("B");
            stack.Push("C");
            stack.Push("D");
            stack.Push("E");

            var lastValue = stack.Peek();//En son değeri dönderir

            object value;
            value = stack.Pop();//E en son pushladığın değeri siler.
            foreach (var item in stack)
            {
                Console.WriteLine(item.ToString());//Sırasıyla değerleri döndürür
            }
            Queue<string> queue = new Queue<string>();//FIFO ilk giren ilk çıkar
            queue.Enqueue("Erhan");
            queue.Enqueue("İsmail");
            queue.Enqueue("Enes");
            queue.Enqueue("Fatih");
            foreach (var item in queue)
            {
                Console.WriteLine(item);//Sırasıyla değerleri döndürür
            }

            queue.Dequeue();

            foreach (var item in queue)
            {
                Console.WriteLine(item);//Sırasıyla değerleri döndürür
            }

            Queue values = new Queue();
            values.Enqueue("A");
            values.Enqueue(1);
            values.Enqueue(new User() {Id=1 ,Name="Erhan",Surname="Kaya",Email="asdfas@gmail.com",Password="123"});
            object deleteQueue=values.Dequeue();//ilk gireni siler.

            */

            List<User> userList = new List<User>()
            {
                new User() { Id = 1,Name="İsmail",Surname="Güleç",Email="ismail@güleç.com",Password="123",Age=33},
                new User() { Id = 2,Name="Erhan",Surname="Kaya",Email="erhan@kaya.com",Password="123",Age=25},
                new User() { Id = 3,Name="Yasir",Surname="Akkaya",Email="yasir@akkaya.com",Password="123",Age=24},
                new User() { Id = 4,Name="Ali",Surname="Durak",Email="ali@durak.com",Password="123",Age=25},
                new User() { Id = 5,Name="Fatih",Surname="Sezer",Email="fatih@sezer.com",Password="123",Age=22},
                new User() { Id = 6,Name="Salih",Surname="Özdel",Email="salih@özdel.com",Password="123", Age = 23},
            };

            //Linq sorgularına temel giriş

            //Where select
            //select * from userList where Age<26
            var list = userList.Where(x=>x.Age<26).ToList();

            //select from
            var list2 = from user in userList select user.Name;
            foreach (var item in list2)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("-------------");
            var newList = userList.Select(x => x.Age + 1);
            foreach (var item in newList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("----------");
            var newList2 = userList.Where(x => x.Age<26).Select(x => x.Age);

            foreach (var item in newList2)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("---------");

            var newList3 = from value in userList
                           where value.Age < 30
                           select new
                           {
                               Name = value.Name,
                               Surname= value.Surname,
                               Age= value.Age
                           };
            foreach (var item in newList3)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("----");

            List<NewUser> users = new List<NewUser>();

            foreach (var item in newList3)
            {

                users.Add(new NewUser()
                {
                    Name = item.Name,
                    Surname = item.Surname,
                    Age = item.Age
                });
            }
        }
    }
}