using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace passwordchecker
{
    class Program
    {
        static void Main(string[] args)
        {
            int minLength = 8;
            string uppercase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string lowercase = "abcdefghijklmnopqrstuvwxyz";
            string digits = "0123456789";
            string specialChars = "~!@#$%^&*()_+/*-+:";

            Console.Write("Enter you password: ");
            string password = Console.ReadLine();

            int score = 0;

            if (password.Length >= minLength)
            {
                score++;
            }
            if (Tools.Contains(password, uppercase))
            {
                score++;
            }
            if (Tools.Contains(password, lowercase))
            {
                score++;
            }
            if (Tools.Contains(password, digits))
            {
                score++;
            }
            if (Tools.Contains(password, specialChars))
            {
                score++;
            }

            switch (score)
            {
                case 5:
                case 4:
                    Console.WriteLine("Holy cow! Your password sure is strong!");
                    break;
                case 3:
                    Console.WriteLine("Nice, your password is about average");
                    break;
                case 2:
                    Console.WriteLine("your password is acceptable I guess");
                    break;
                case 1:
                    Console.WriteLine("Oof, password doesn't pass the requirement!");
                    break;
            }
    }
}
