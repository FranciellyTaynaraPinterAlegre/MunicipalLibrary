using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MunicipalLibrary.Models {
    public class Rent {

        public int Id { get; set; }

        public Book Book {
            get; set;
        }

        public Client Client {
            get; set;
        }

        public DateTimeOffset RentDate {
            get; set;
        }

        public DateTimeOffset ReturnDate {
            get {
                return RentDate.AddDays(7);
            }
        }
        public Rent()
        {
            Client = new Client();
            Book = new Book();
        }
    }
}