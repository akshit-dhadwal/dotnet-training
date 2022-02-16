using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DBMigration_test.Context
{
    public class Studentcs
    {
        [Key]
        public int StudentId { get; set; }

        public string StudentName { get; set; }

        public int StudentAge { get; set; }

        public string CoverImageUrl { get; set; }

        [NotMapped]
        public IFormFile CoverPhoto { get; set; }

        //public string StandardId { get; set; }
    }
}
