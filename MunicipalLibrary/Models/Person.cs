using System;

namespace MunicipalLibrary.Models {
    public class Person {

        public string Name {
            get; set;
        }

        public DateTimeOffset BirthDate {
            get; set;
        }

        public string Document {
            get; set;
        }

        public string Etny {
            get; set;
        }

        public CivilState CivilState {
            get; set;
        }

        public Sex Sex {
            get; set;
        }

    }
}