// See https://aka.ms/new-console-template for more information
using System;
using System.Linq;

namespace IDToDOBns
{
    public class IdDob
    {
        public String getID()
        {
            Console.WriteLine("Enter ID Number: ");
            return Console.ReadLine();
        }

        public bool isInputValid(string input)
        {
            if(input=="")
            {
                return false;
            }
            if (input.Length!= 13)
            {
                return false;
            }

            if(!input.Any(c => c >= '0' || c <= '9'))
            {
                Console.WriteLine("ID Number must be numerical");
                return false;
            }
            return true;
        }

        public String dateOfBirth(String id)
        {
            string dob;
            string year = "";
            string month = "";
            string day = "";
            string mil = "";
            year = id.Substring(0, 2);
            month = id.Substring(2, 2);
            day = id.Substring(4, 2);

            if (int.Parse(year) >=0 && int.Parse(year) <=15)
            {
                mil = "20";
            }
            if (int.Parse(year) >= 16 && int.Parse(year)<=99)
            {
                mil = "19";
            }
            dob = day + "/" + month + "/" + mil+year;
            return dob;
        }

        public static void Main(String[] args)
        {
            IdDob t = new IdDob();
            string id;
            do
            {
                id = t.getID();
            } while (!t.isInputValid(id));

            Console.WriteLine("Date of Birth: " + t.dateOfBirth(id));
        }
    }
}
