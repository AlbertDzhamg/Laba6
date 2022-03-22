using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductApp
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            using (ApplicationContext db = new ApplicationContext())
            {
                db.Users.Add(new User
                {
                    NomerVTablice = "1",
                    LubimoeChislo = "228",
                    Name = "Valera"
                });
                db.Users.Add(new User
                {
                    NomerVTablice = "2",
                    LubimoeChislo = "322",
                    Name = "Vasya"
                });
                db.Users.Add(new User
                {
                    NomerVTablice = "3",
                    LubimoeChislo = "1488",
                    Name = "Stasyan"
                });
                db.Users.Add(new User
                {
                    NomerVTablice = "4",
                    LubimoeChislo = "777",
                    Name = "Nick"
                });
                db.Users.Add(new User
                {
                    NomerVTablice = "5",
                    LubimoeChislo = "4548465",
                    Name = "Amber"
                });
                db.Users.Add(new User
                {
                    NomerVTablice = "6",
                    LubimoeChislo = "6454",
                    Name = "Johny"
                });
                db.Users.Add(new User
                {
                    NomerVTablice = "7",
                    LubimoeChislo = "24223",
                    Name = "Stepan"
                });
                db.Users.Add(new User
                {
                    NomerVTablice = "8",
                    LubimoeChislo = "12345",
                    Name = "Triss"
                });
                db.Users.Add(new User
                {
                    NomerVTablice = "9",
                    LubimoeChislo = "42141",
                    Name = "Nanny"
                });
                db.Users.Add(new User
                {
                    NomerVTablice = "10",
                    LubimoeChislo = "1233",
                    Name = "Taty"
                });
                db.SaveChanges();
                var users = db.Users.ToList();
                foreach (var u in users)
                    Console.WriteLine($"{u.Name} : {u.NomerVTablice} {u.LubimoeChislo}");
            }
        }
    }
}

