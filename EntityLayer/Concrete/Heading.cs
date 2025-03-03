using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Heading
    {
        [Key]
        public int HeadingId { get; set; }

        [StringLength(50)]
        public string HeadingName { get; set; }
        public DateTime HeadingDate { get; set; }
        public int CategoryId { get; set; } //category de oluşturulan bire çok ilişki için
        public virtual Category Category { get; set; } //virtual anahtar kelimesi ilişkinin kurulduğu sınıftan değer alındığını belirtir
        public ICollection<Content> Contents { get; set; } //content sınıfıyla ilişki
        public int WriterId { get; set; } //heading sınıfyla ilişkili
        public virtual Writer Writer { get; set; }
        public bool HeadingStatus { get; set; }

    }
}
