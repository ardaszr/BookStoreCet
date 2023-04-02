using System.ComponentModel.DataAnnotations;

namespace BookStoreCet.Data
{
    public class Book
    {
        public int BookId { get; set; }

        [Required]
        [MaxLength(200)]

        public string Name { get; set; }
        public Decimal Price { get; set; }
        public int PageCount { get; set; }
        public DateTime PublishedDate { get; set; }
        public int? PublisherId { get; set; }
        public virtual Publisher Publisher { get; set; }

        public int CategoryId { get; set; }

        public virtual List<Book> Books { get; set; }

    }

    public class Publisher
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual List<Book> Books { get; set;}
    }

    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual List<Book> Books { get; set; }

    }


}



