using System.Collections.Generic;

namespace MunicipalLibrary.Models {
    public class Client : Person {

        public int Id {
            get; set;
        }

        public IList<Book> RentedBooks {
            get; set;
        }

    }
}