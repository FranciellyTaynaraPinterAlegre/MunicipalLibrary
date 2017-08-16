using System;

namespace MunicipalLibrary.Models {
    public class Rent {

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

    }
}