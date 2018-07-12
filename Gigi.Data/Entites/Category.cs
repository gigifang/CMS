using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Gigi.Data.Entites
{
    public class Category
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }
    }
}
