using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PartialViewDemo.Models
{
    [Table("Book")]
    public class Book
    {
        [Key]//pk in col in DB
        public int Id { get; set; }
       
        public string? Name { get; set; }
        
        public string? Author { get; set; }
        
        public int Price { get; set; }
    }
}
