using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entitylayer.Concrete
{
    public class Writer
    {
        [Key]
        public int WriterID { get; set; }
        [StringLength(50)]
        public string Writername { get; set; }
        [StringLength(50)]
        public string Writersurname { get; set; }
        [StringLength(100)]
        public string Writerimage { get; set; }
        [StringLength(50)]
        public string Writermail { get; set; }
        [StringLength(20)]
        public string Writerpassword { get; set; }
        public ICollection<Heading> Headings { get; set; }
        public ICollection<Content> Contents { get; set; }
    }
}
