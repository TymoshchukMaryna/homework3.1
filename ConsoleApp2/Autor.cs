using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Autor
    {
        string book_autor;

        public string BookAutor
        {
            get
            {
                if (book_autor != null)
                    return book_autor;
                else
                    return "Відсутня автор книги";
            } 
                
            set
            { 
                book_autor = value; 
            }
        }

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"Автор {BookAutor}");
        }
    }
}
