using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2_3
{
    internal class Update
    {
        public void UpdateRecordMenu()
        {
            Console.WriteLine("Update record menu:");
            Console.WriteLine("1. Update Author");
            Console.WriteLine("2. Update Book");
            Console.WriteLine("3. Update Customer");
            Console.WriteLine("4. Update Genre");
            Console.WriteLine("5. Update Publisher");
            Console.WriteLine("6. Update Review");

            Console.Write("Choose option: ");
            string option = Console.ReadLine();
            switch (option)
            {
                case "1":
                    UpdateAuthor();
                    break;
                case "2":
                    UpdateBook();
                    break;
                case "3":
                    UpdateCustomer();
                    break;
                case "4":
                    UpdateGenre();
                    break;
                case "5":
                    UpdatePublisher();
                    break;
                case "6":
                    UpdateReview();
                    break;
                default:
                    Console.WriteLine("Invalid option.");
                    break;
            }
        }
        public void UpdateAuthor()
        {
            Console.WriteLine("Enter author ID:");
            int authorId = int.Parse(Console.ReadLine());

            using (var context = new BookStoreContext())
            {
                var author = context.Authors.Find(authorId);
                if (author != null)
                {
                    Console.WriteLine("Enter new author name:");
                    string newName = Console.ReadLine();
                    author.Name = newName;

                    context.SaveChanges();
                    Console.WriteLine("Author updated successfully.");
                }
                else
                {
                    Console.WriteLine("Author not found.");
                }
            }
        }

        public void UpdateBook()
        {
            Console.WriteLine("Enter book ID:");
            int bookId = int.Parse(Console.ReadLine());

            using (var context = new BookStoreContext())
            {
                var book = context.Books.Find(bookId);
                if (book != null)
                {
                    Console.WriteLine("Enter new book name:");
                    string newName = Console.ReadLine();
                    book.Name = newName;

                    Console.WriteLine("Enter new author ID:");
                    int newAuthorId = int.Parse(Console.ReadLine());
                    book.AuthorId = newAuthorId;

                    Console.WriteLine("Enter new publisher ID:");
                    int newPublisherId = int.Parse(Console.ReadLine());
                    book.PublisherId = newPublisherId;

                    Console.WriteLine("Enter new genre ID:");
                    int newGenreId = int.Parse(Console.ReadLine());
                    book.GenreId = newGenreId;

                    context.SaveChanges();
                    Console.WriteLine("Book updated successfully.");
                }
                else
                {
                    Console.WriteLine("Book not found.");
                }
            }
        }

        public void UpdateCustomer()
        {
            Console.WriteLine("Enter customer ID:");
            int customerId = int.Parse(Console.ReadLine());

            using (var context = new BookStoreContext())
            {
                var customer = context.Customers.Find(customerId);
                if (customer != null)
                {
                    Console.WriteLine("Enter new customer name:");
                    string newName = Console.ReadLine();
                    customer.Name = newName;

                    Console.WriteLine("Enter new customer email:");
                    string newEmail = Console.ReadLine();
                    customer.Email = newEmail;

                    Console.WriteLine("Enter new customer country:");
                    string newCountry = Console.ReadLine();
                    customer.Country = newCountry;

                    Console.WriteLine("Enter new customer city:");
                    string newCity = Console.ReadLine();
                    customer.City = newCity;

                    Console.WriteLine("Enter new customer address:");
                    string newAddress = Console.ReadLine();
                    customer.Address = newAddress;

                    context.SaveChanges();
                    Console.WriteLine("Customer updated successfully.");
                }
                else
                {
                    Console.WriteLine("Customer not found.");
                }
            }
        }

        public void UpdateGenre()
        {
            Console.WriteLine("Enter genre ID:");
            int genreId = int.Parse(Console.ReadLine());

            using (var context = new BookStoreContext())
            {
                var genre = context.Genres.Find(genreId);
                if (genre != null)
                {
                    Console.WriteLine("Enter new genre name:");
                    string newName = Console.ReadLine();
                    genre.Name = newName;

                    Console.WriteLine("Enter new genre description:");
                    string newDescription = Console.ReadLine();
                    genre.Description = newDescription;

                    context.SaveChanges();
                    Console.WriteLine("Genre updated successfully.");
                }
                else
                {
                    Console.WriteLine("Genre not found.");
                }
            }
        }

        public void UpdatePublisher()
        {
            Console.WriteLine("Enter publisher ID:");
            int publisherId = int.Parse(Console.ReadLine());

            using (var context = new BookStoreContext())
            {
                var publisher = context.Publishers.Find(publisherId);
                if (publisher != null)
                {
                    Console.WriteLine("Enter new publisher name:");
                    string newName = Console.ReadLine();
                    publisher.Name = newName;

                    Console.WriteLine("Enter new publisher country:");
                    string newCountry = Console.ReadLine();
                    publisher.Country = newCountry;

                    context.SaveChanges();
                    Console.WriteLine("Publisher updated successfully.");
                }
                else
                {
                    Console.WriteLine("Publisher not found.");
                }
            }
        }

        public void UpdateReview()
        {
            Console.WriteLine("Enter review ID:");
            int reviewId = int.Parse(Console.ReadLine());

            using (var context = new BookStoreContext())
            {
                var review = context.Reviews.Find(reviewId);
                if (review != null)
                {
                    Console.WriteLine("Enter new review:");
                    string newReview = Console.ReadLine();
                    review.ReviewText = newReview;

                    context.SaveChanges();
                    Console.WriteLine("Review updated successfully.");
                }
                else
                {
                    Console.WriteLine("Review not found.");
                }
            }
        }

    }
}
