using System.ComponentModel.DataAnnotations;

namespace CA3
{
    public class SearchForm
    {
        [Required]
        [StringLength(18, ErrorMessage = "Name is too long.")]
        public string Name { get; set; }
        
        public bool critic { get; set; }

    }
}
