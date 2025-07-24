using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookShop.Models.Entities
{

    //[Table("Categories", Schema = "MasterSchema")]
    public class Category
    {

        //[Key]
        public int Id { get; set; }

        //[Required]
        //[MaxLength(50)]
        public string CatName { get; set; }

        //[Required]
        public int CatOrder { get; set; }

        //[NotMapped]
        public DateTime CreatedDate { get; set; }

        //[Column("isDeleted")]
        public bool IsDeleted { get; set; }
    }
}
