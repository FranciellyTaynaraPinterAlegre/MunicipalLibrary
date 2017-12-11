using System.Collections.Generic;

namespace MunicipalLibrary.Models {
    public class Client : Person {

      public IList<Book> RentedBooks {
            get; set;
       }

    }
}