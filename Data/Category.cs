using System.ComponentModel.DataAnnotations;

namespace YumBlazor.Data
{
    public class Category
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Lütfen kategori adını giriniz")]
        public string Name { get; set; }
    }
}
