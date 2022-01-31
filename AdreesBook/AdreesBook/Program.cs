using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdreesBook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ///Main  Method / program Entry Point
            
            {
                //Showing Welcome Message On console.
                Console.WriteLine("Welcome to Address Book Progam \n");

                CreateAddressBook addressBook = new CreateAddressBook();
                addressBook.AddContact();
                Console.ReadLine();
            }


        }
    }
}














