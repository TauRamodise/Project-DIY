using System.ComponentModel.DataAnnotations;

namespace Project_DIY.Models
{
    public enum Status
    {
        PENDING, ACCEPTED, DECLINED, COUNTERED, DONE
    }
    public class Contract
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        [Required]
        public int ProviderId { get; set; }
        [Required]
        public string? Service { get; set; }
        [Required]
        public string? Description { get; set; }
        [Required]
        public DateTime StartDate { get; set; }
        [Required]
        public DateTime EndDate { get; set; }
        [Required]
        public int Amount { get; set; }
        [Required]
        public bool IsCountered { get; set; }
        public Status Status { get; set; }
        public DateTime Created { get; set; }
    }
}
