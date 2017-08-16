using System.Collections.Generic;

namespace MunicipalLibrary.Models {
    public class Author : Person {

        private IList<Book> books = new List<Book>();

        public IList<Book> Books {
            get {
                return books;
            }
        }

    }
}