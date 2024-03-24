using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Title
    {
        string book_title;

        public string BookTitle 
        {  
            get
            { 
                if (book_title != null)
                return book_title; 
                else
                    return "Відсутня назва книги";
            } 
            set
            {  
                book_title = value;
            }
        }

        public void Show()
        {

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Назва {BookTitle}");
        }
    }
}
