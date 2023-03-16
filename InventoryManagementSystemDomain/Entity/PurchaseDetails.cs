using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystemDomain.Entity
{
    public class PurchaseDetails
    {
        public int Id { get; set; }
        public int PurchaseId { get; set; }

        public string ItemCode { get; set; }  

        public float ItemQty{ get; set; }
        
        public float ItemUnitId { get; set; } 
        
        public float ItemRate { get; set; }    

        public virtual Purchase Purchase { get; set; }
    }
}
