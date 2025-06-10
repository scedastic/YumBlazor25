using System.ComponentModel.DataAnnotations;

namespace YumBlazor25.Data
{
    public class Category
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter name.")]
        public string Name { get; set; }
    }
}
