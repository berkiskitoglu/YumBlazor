using System.ComponentModel.DataAnnotations;

namespace YumBlazor.Data
{
    public class OrderHeader
    {
        public int Id { get; set; }
        [Required]
        public string UserId { get; set; }
        [Required]
        [Display(Name = "Toplam Fiyat")]
        public double OrderTotal { get; set; }
        [Required]
        public DateTime OrderDate { get; set; }
        [Required]
        public string Status { get; set; }
        [Required(ErrorMessage ="Ad Alanını Girmek Zorunludur")]
        [Display(Name ="Ad")]
        public string Name { get; set; }
        [Required(ErrorMessage="Telefon Numarasını Girmek Zorunludur")]
        [Display(Name ="Telefon Numarası")]
        public string PhoneNumber { get; set; }
        [Required(ErrorMessage ="Mail Adresi Girmek Zorunludur")]
        //Email
        [Display(Name = "Email")]
        public string Email { get; set; }
        public string? SessionId { get; set; }
        public string? PaymentIntentId { get; set; }
        
        public ICollection<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();


    }
}
