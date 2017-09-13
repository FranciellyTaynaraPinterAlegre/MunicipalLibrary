using System;
using System.ComponentModel.DataAnnotations;

namespace MunicipalLibrary.Models {
    public class Book {

        [Required]
        public long Id { get; set; }
        [Required]
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

        [Required]
        public Author Author {
            get; set;
        }

        [Required]
        public DateTimeOffset LaunchDate {
            get; set;
        }

        [Required]
        public Language Language {
            get; set;
        }

        [Required]
        public Category Category {
            get; set;
        }

        public string Location {
            get; set;
        }

    }
}