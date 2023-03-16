using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystemDomain.Entity
{
    public class Purchase
    {
        
            public Purchase()
            {
              PurchaseDetailses = new HashSet<PurchaseDetails>();
            }

            
        
        [Key]
        public int PurchaseId { get; set;  }   
        public DateTime PurchaseDate { get; set; }

        [Display(Name = "Supplier Name")]
        [Required(ErrorMessage = "Supplier Name is required")]
        [StringLength(100, ErrorMessage = "Supplier Name must be a maximum length of 100")]
        public string SupplierName { get; set; }  

        public string Address { get; set;}

        public string EntryBy { get; set; }  
        
        public string EntryDate { get; set; }   
        
        public string Remark { get; set; }
        public virtual ICollection<PurchaseDetails> PurchaseDetailses { get; set; }
    }
}
