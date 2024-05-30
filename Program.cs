using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool exitRequested = false;
            while (!exitRequested)
            {
                Console.WriteLine("Menu:");
                Console.WriteLine("1. Display data");
                Console.WriteLine("2. Add record");
                Console.WriteLine("3. Update record");
                Console.WriteLine("4. Delete record");
                Console.WriteLine("5. Exit");

                Console.Write("Choose option: ");
                string option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        var display = new Display();
                        display.DisplayDataMenu();
                        break;
                    case "2":
                        var add = new Add();
                        add.AddRecordMenu();
                        break;
                    case "3":
                        var update = new Update();
                        update.UpdateRecordMenu();
                        break;
                    case "4":
                        var delete = new Delete();
                        delete.DeleteRecordMenu();
                        break;
                    case "5":
                        exitRequested = true;
                        Console.WriteLine("Exiting program...");
                        break;
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
            }
        }
    }
}

public class Author
{
    public int Id { get; set; }
    public string Name { get; set; }

    public virtual ICollection<Book> Books { get; set; }
}

public class Book
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Isbn { get; set; }
    public string Description { get; set; }

    public int AuthorId { get; set; }
    public virtual Author Author { get; set; }

    public int PublisherId { get; set; }
    public virtual Publisher Publisher { get; set; }

    public int GenreId { get; set; }
    public virtual Genre Genre { get; set; }

    public virtual ICollection<Review> Reviews { get; set; }
}

public class Customer
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public string Country { get; set; }
    public string City { get; set; }
    public string Address { get; set; }

    public virtual ICollection<Review> Reviews { get; set; }
}

public class Genre
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }

    public virtual ICollection<Book> Books { get; set; }
}

public class Publisher
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Country { get; set; }

    public virtual ICollection<Book> Books { get; set; }
}

public class Review
{
    public int Id { get; set; }
    public int BookId { get; set; }
    public virtual Book Book { get; set; }

    public int CustomerId { get; set; }
    public virtual Customer Customer { get; set; }

    public string ReviewText { get; set; }
    public DateTime Date { get; set; }
}