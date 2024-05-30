using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2_3
{
    internal class Delete
    {
        public void DeleteRecordMenu()
        {
            Console.WriteLine("Delete record menu:");
            Console.WriteLine("1. Delete Author");
            Console.WriteLine("2. Delete Book");
            Console.WriteLine("3. Delete Customer");
            Console.WriteLine("4. Delete Genre");
            Console.WriteLine("5. Delete Publisher");
            Console.WriteLine("6. Delete Review");

            Console.Write("Choose option: ");
            string option = Console.ReadLine();
            switch (option)
            {
                case "1":
                    DeleteAuthor();
                    break;
                case "2":
                    DeleteBook();
                    break;
                case "3":
                    DeleteCustomer();
                    break;
                case "4":
                    DeleteGenre();
                    break;
                case "5":
                    DeletePublisher();
                    break;
                case "6":
                    DeleteReview();
                    break;
                default:
                    Console.WriteLine("Invalid option.");
                    break;
            }
        }
        public void DeleteAuthor()
        {
            Console.WriteLine("Enter author ID:");
            int authorId = int.Parse(Console.ReadLine());

            using (var context = new BookStoreContext())
            {
                var author = context.Authors.Find(authorId);
                if (author != null)
                {
                    context.Authors.Remove(author);
                    context.SaveChanges();
                    Console.WriteLine("Author deleted successfully.");
                }
                else
                {
                    Console.WriteLine("Author not found.");
                }
            }
        }

        static void DeleteBook()
        {
            Console.WriteLine("Enter book ID:");
            int bookId = int.Parse(Console.ReadLine());

            using (var context = new BookStoreContext())
            {
                var book = context.Books.Find(bookId);
                if (book != null)
                {
                    context.Books.Remove(book);
                    context.SaveChanges();
                    Console.WriteLine("Book deleted successfully.");
                }
                else
                {
                    Console.WriteLine("Book not found.");
                }
            }
        }

        public void DeleteCustomer()
        {
            Console.WriteLine("Enter customer ID:");
            int customerId = int.Parse(Console.ReadLine());

            using (var context = new BookStoreContext())
            {
                var customer = context.Customers.Find(customerId);
                if (customer != null)
                {
                    context.Customers.Remove(customer);
                    context.SaveChanges();
                    Console.WriteLine("Customer deleted successfully.");
                }
                else
                {
                    Console.WriteLine("Customer not found.");
                }
            }
        }

        public void DeleteGenre()
        {
            Console.WriteLine("Enter genre ID:");
            int genreId = int.Parse(Console.ReadLine());

            using (var context = new BookStoreContext())
            {
                var genre = context.Genres.Find(genreId);
                if (genre != null)
                {
                    context.Genres.Remove(genre);
                    context.SaveChanges();
                    Console.WriteLine("Genre deleted successfully.");
                }
                else
                {
                    Console.WriteLine("Genre not found.");
                }
            }
        }

        public void DeletePublisher()
        {
            Console.WriteLine("Enter publisher ID:");
            int publisherId = int.Parse(Console.ReadLine());

            using (var context = new BookStoreContext())
            {
                var publisher = context.Publishers.Find(publisherId);
                if (publisher != null)
                {
                    context.Publishers.Remove(publisher);
                    context.SaveChanges();
                    Console.WriteLine("Publisher deleted successfully.");
                }
                else
                {
                    Console.WriteLine("Publisher not found.");
                }
            }
        }

        public void DeleteReview()
        {
            Console.WriteLine("Enter review ID:");
            int reviewId = int.Parse(Console.ReadLine());

            using (var context = new BookStoreContext())
            {
                var review = context.Reviews.Find(reviewId);
                if (review != null)
                {
                    context.Reviews.Remove(review);
                    context.SaveChanges();
                    Console.WriteLine("Review deleted successfully.");
                }
                else
                {
                    Console.WriteLine("Review not found.");
                }
            }
        }

    }
}
