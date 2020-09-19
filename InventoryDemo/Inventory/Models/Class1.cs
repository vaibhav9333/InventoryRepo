using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Inventory.Models
{
    [MetadataType(typeof(Class1))]
    public partial class Item
    {


    }
    public class Class1
    {
        public int Ino { get; set; }
        [Required(ErrorMessage ="Field is manatory")]
        public string Name { get; set; }
        [Display(Name ="Description")]
        [Required(ErrorMessage = "Field is manatory")]
        public string IDescription { get; set; }

        [Required(ErrorMessage = "Field is manatory")]
        public Nullable<int> Price { get; set; }

    }
    
}