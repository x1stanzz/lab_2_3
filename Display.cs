using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2_3
{
    internal class Display
    {
        public void DisplayDataMenu()
        {
            Console.WriteLine("Display data menu:");
            Console.WriteLine("1. Display Authors");
            Console.WriteLine("2. Display Books");
            Console.WriteLine("3. Display Customers");
            Console.WriteLine("4. Display Genres");
            Console.WriteLine("5. Display Publishers");
            Console.WriteLine("6. Display Reviews");
            Console.WriteLine("7. Display All Tables");

            Console.Write("Choose option: ");
            string option = Console.ReadLine();
            switch (option)
            {
                case "1":
                    DisplayAuthors();
                    break;
                case "2":
                    DisplayBooks();
                    break;
                case "3":
                    DisplayCustomers();
                    break;
                case "4":
                    DisplayGenres();
                    break;
                case "5":
                    DisplayPublishers();
                    break;
                case "6":
                    DisplayReviews();
                    break;
                case "7":
                    DisplayAllTables();
                    break;
                default:
                    Console.WriteLine("Invalid option.");
                    break;
            }
        }
        public void DisplayAuthors()
        {
            using (var context = new BookStoreContext())
            {
                var authors = context.Authors.ToList();
                Console.WriteLine("Authors:");
                foreach (var author in authors)
                {
                    Console.WriteLine($"ID: {author.Id}, Name: {author.Name}");
                }
            }
        }

        public void DisplayBooks()
        {
            using (var context = new BookStoreContext())
            {
                var books = context.Books.Include("Author").Include("Publisher").Include("Genre").ToList();
                Console.WriteLine("Books:");
                foreach (var book in books)
                {
                    Console.WriteLine($"ID: {book.Id}, Name: {book.Name}, Author: {book.Author.Name}, Publisher: {book.Publisher.Name}, Genre: {book.Genre.Name}");
                }
            }
        }
        static void DisplayCustomers()
        {
            using (var context = new BookStoreContext())
            {
                var customers = context.Customers.ToList();
                Console.WriteLine("Customers:");
                foreach (var customer in customers)
                {
                    Console.WriteLine($"ID: {customer.Id}, Name: {customer.Name}, Email: {customer.Email}, Country: {customer.Country}, City: {customer.City}, Address: {customer.Address}");
                }
            }
        }

        public void DisplayGenres()
        {
            using (var context = new BookStoreContext())
            {
                var genres = context.Genres.ToList();
                Console.WriteLine("Genres:");
                foreach (var genre in genres)
                {
                    Console.WriteLine($"ID: {genre.Id}, Name: {genre.Name}, Description: {genre.Description}");
                }
            }
        }

        public void DisplayPublishers()
        {
            using (var context = new BookStoreContext())
            {
                var publishers = context.Publishers.ToList();
                Console.WriteLine("Publishers:");
                foreach (var publisher in publishers)
                {
                    Console.WriteLine($"ID: {publisher.Id}, Name: {publisher.Name}, Country: {publisher.Country}");
                }
            }
        }

        public void DisplayReviews()
        {
            using (var context = new BookStoreContext())
            {
                var reviews = context.Reviews.Include("Book").Include("Customer").ToList();
                Console.WriteLine("Reviews:");
                foreach (var review in reviews)
                {
                    Console.WriteLine($"ID: {review.Id}, Book: {review.Book.Name}, Customer: {review.Customer.Name}, Review: {review.ReviewText}, Date: {review.Date}");
                }
            }
        }

        public void DisplayAllTables()
        {
            DisplayAuthors();
            DisplayBooks();
            DisplayCustomers();
            DisplayGenres();
            DisplayPublishers();
            DisplayReviews();
        }
    }
}
