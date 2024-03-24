using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Book
    {
        Autor autor = null;
        Title title = null;
        Content content = null;

        public void InitializeDocument()
        {
            this.autor = new Autor();
            this.title = new Title();
            this.content = new Content();
            Console.WriteLine("Введіть автора книги");
            autor.BookAutor = Console.ReadLine();
            Console.WriteLine("Введіть назву книги");
            title.BookTitle = Console.ReadLine();
            Console.WriteLine("Введіть зміст книги");
            content.BookContent = Console.ReadLine();
        }

        public void Show()
        {
            autor.Show();
            title.Show();
            content.Show();
        }
    }
}
