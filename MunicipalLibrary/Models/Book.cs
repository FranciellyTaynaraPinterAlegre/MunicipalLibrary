using System;
using System.ComponentModel.DataAnnotations;

namespace MunicipalLibrary.Models {
    public class Book {

        [Required]
        public long Id { get; set; }
        
        [StringLength(255, MinimumLength = 3)]
        public string Title {
            get; set;
        }

        public string Subtitle {
            get; set;
        }

        public int Volume {
            get; set;
        }

        public Author Author {
            get; set;
        }

     
        public DateTimeOffset LaunchDate {
            get; set;
        }

       
        public Language Language {
            get; set;
        }

   
        public Category Category {
            get; set;
        }

        public string Location {
            get; set;
        }

    }
}