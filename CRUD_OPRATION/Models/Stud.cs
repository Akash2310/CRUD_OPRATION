using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CRUD_OPRATION.Models
{
    [Table("studdata",Schema="public")]

    public class Stud
    {
        [Key]

        public int id { get; set; }
        public string studname { get; set; }
        public string department { get; set; }
        public string city { get; set; }
    }
}