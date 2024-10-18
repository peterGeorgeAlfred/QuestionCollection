using System.ComponentModel.DataAnnotations;

namespace QuestionCollections.Models
{
    public class Category
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Category Name is required")]
        public string Name { get; set; } = string.Empty;
        public ICollection<Question> Questions { get; set; } = new HashSet<Question>();

    }
}
