using System.Collections.Generic;

namespace MunicipalLibrary.Models {
    public class Author : Person {

        public IEnumerable<Book> Books { get; set; }

    }
}