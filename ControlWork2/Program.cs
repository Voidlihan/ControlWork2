using ControlWork2.Models;
using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;
using System.Data;

namespace ControlWork2
{
    class Program
    {
        private static List<Sms> res;
        static void Main(string[] args)
        {
            Console.WriteLine("Чтобы войти в чат, введите логин");
            string inp = Console.ReadLine();
            User user = new User
            {
                Log = inp,                
            };
            string sampleText;

            using (var context = new ChatContext())
            {
                while(true)
                {
                    DataSet ds = new DataSet();
                    ChatContext db = new ChatContext();
                    foreach (var _set in inp)
                    {
                        
                    }
                    context.Add(user);
                    context.SaveChanges();
                }
            }
        }
    }
}
