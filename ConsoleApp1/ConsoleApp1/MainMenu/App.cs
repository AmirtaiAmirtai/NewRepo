using ConsoleApp1.ooj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Threading.Tasks;

namespace ConsoleApp1.lol
{
    public class App
    {
        private string systemPassword;

        public App(string password)
        {
            systemPassword = password;
        }
        public User? CreateUser(string password, string username)
        {
            if (username != null && password == systemPassword)
            {
                return new User(username, password);
            }
            return null;
        }
        public void HelloUser(User? user)
        {
            if (user != null) { Console.WriteLine($"Привет, {user.Value.Username}!"); }
            else { Console.WriteLine("Вам не удалось войти в систему."); };
        }
        public User? LoginUser(string username, string password)
        {
            if (password == systemPassword)
            {
                return new User(username, password);
            }
            else
            {
                return null;
            }
        }
        public void Startup()
        {
            
            Console.WriteLine("Введите ваше имя:");
            string username = Console.ReadLine();
            Console.WriteLine("Введите ваш пароль:");
            string passsword = Console.ReadLine();

            User? newUser = CreateUser(passsword, username);
            HelloUser(newUser);
        }


        
    }
}
