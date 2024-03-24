using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Content
    {
        string book_content;

        public string BookContent
        {
            get
            {
                if (book_content != null)
                    return book_content;
                else
                    return "У книги відсутній зміст";
            }
            set
            { 
                book_content = value; 
            }
        }

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Контент {BookContent}");
        }
    }
}
