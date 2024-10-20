using System.ComponentModel.DataAnnotations;

namespace QuestionCollections.Models
{
    public class Question
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = string.Empty;

        [Required]
        public string Body { get; set; } = string.Empty;

        [Required]
        public string Explanation { get; set; } = string.Empty;
        public List<Choice> Choices { get; set; } = new List<Choice>();

        public bool HighYield { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "Please Select Category")]
        public int CategoryId { get; set; }
        public Category Category { get; set; } = default!;
    }
}
