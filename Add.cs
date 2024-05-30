using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2_3
{
    internal class Add
    {
        public void AddRecordMenu()
        {
            Console.WriteLine("Add record menu:");
            Console.WriteLine("1. Add Author");
            Console.WriteLine("2. Add Book");
            Console.WriteLine("3. Add Customer");
            Console.WriteLine("4. Add Genre");
            Console.WriteLine("5. Add Publisher");
            Console.WriteLine("6. Add Review");

            Console.Write("Choose option: ");
            string option = Console.ReadLine();
            switch (option)
            {
                case "1":
                    AddAuthor();
                    break;
                case "2":
                    AddBook();
                    break;
                case "3":
                    AddCustomer();
                    break;
                case "4":
                    AddGenre(); 
                    break;
                case "5":
                    AddPublisher();
                    break;
                case "6":
                    AddReview();
                    break;
                default:
                    Console.WriteLine("Invalid option.");
                    break;
            }
        }
        public void AddAuthor()
        {
            Console.WriteLine("Enter author name:");
            string name = Console.ReadLine();

            using (var context = new BookStoreContext())
            {
                var author = new Author { Name = name };
                context.Authors.Add(author);
                context.SaveChanges();
                Console.WriteLine("Author added successfully.");
            }
        }

        public void AddBook()
        {
            Console.WriteLine("Enter book name:");
            string name = Console.ReadLine();

            Console.WriteLine("Enter author ID:");
            int authorId = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter publisher ID:");
            int publisherId = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter genre ID:");
            int genreId = int.Parse(Console.ReadLine());

            using (var context = new BookStoreContext())
            {
                var book = new Book
                {
                    Name = name,
                    AuthorId = authorId,
                    PublisherId = publisherId,
                    GenreId = genreId
                };
                context.Books.Add(book);
                context.SaveChanges();
                Console.WriteLine("Book added successfully.");
            }
        }

        static void AddCustomer()
        {
            Console.WriteLine("Enter customer name:");
            string name = Console.ReadLine();

            Console.WriteLine("Enter customer email:");
            string email = Console.ReadLine();

            Console.WriteLine("Enter customer country:");
            string country = Console.ReadLine();

            Console.WriteLine("Enter customer city:");
            string city = Console.ReadLine();

            Console.WriteLine("Enter customer address:");
            string address = Console.ReadLine();

            using (var context = new BookStoreContext())
            {
                var customer = new Customer
                {
                    Name = name,
                    Email = email,
                    Country = country,
                    City = city,
                    Address = address
                };
                context.Customers.Add(customer);
                context.SaveChanges();
                Console.WriteLine("Customer added successfully.");
            }
        }

        static void AddGenre()
        {
            Console.WriteLine("Enter genre name:");
            string name = Console.ReadLine();

            Console.WriteLine("Enter genre description:");
            string description = Console.ReadLine();

            using (var context = new BookStoreContext())
            {
                var genre = new Genre
                {
                    Name = name,
                    Description = description
                };
                context.Genres.Add(genre);
                context.SaveChanges();
                Console.WriteLine("Genre added successfully.");
            }
        }

        static void AddPublisher()
        {
            Console.WriteLine("Enter publisher name:");
            string name = Console.ReadLine();

            Console.WriteLine("Enter publisher country:");
            string country = Console.ReadLine();

            using (var context = new BookStoreContext())
            {
                var publisher = new Publisher
                {
                    Name = name,
                    Country = country
                };
                context.Publishers.Add(publisher);
                context.SaveChanges();
                Console.WriteLine("Publisher added successfully.");
            }
        }

        static void AddReview()
        {
            Console.WriteLine("Enter book ID:");
            int bookId = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter customer ID:");
            int customerId = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter review:");
            string review = Console.ReadLine();

            DateTime date = DateTime.Now;

            using (var context = new BookStoreContext())
            {
                var reviewEntity = new Review
                {
                    BookId = bookId,
                    CustomerId = customerId,
                    ReviewText = review,
                    Date = date
                };
                context.Reviews.Add(reviewEntity);
                context.SaveChanges();
                Console.WriteLine("Review added successfully.");
            }
        }
    }
}
