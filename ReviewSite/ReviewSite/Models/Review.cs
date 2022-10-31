using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ReviewSite.Models
{
    public class Review
    {
        public int Id { get; set; }
        public int ProductId { get; set; }

        [Display(Name = "Reviewer Name")]
        public string Reviewer_Name { get; set; }

        [Display(Name = "Product Review")]
        public string Product_Review { get; set; }
        
        [DataType(DataType.Date)]
        public DateTime? Date { get; set; }
        public virtual Product Product { get; set; }
    }
}
