using System.ComponentModel.DataAnnotations;

namespace InAndOut.Models
{
    public class Expense
    {
        [Key]
        public int Id { get; set; }
    
        [Display(Name ="Expense Name")]
        public string ExpenseName { get; set; }

        public int Amount { get; set; }


    }
}
