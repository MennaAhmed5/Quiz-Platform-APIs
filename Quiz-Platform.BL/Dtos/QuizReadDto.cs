using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz_Platform.BL.Dtos
{
    public class QuizReadDto
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = string.Empty;

        [Required]
        public string Description { get; set; } = string.Empty;
        [Required]
        public string Image { get; set; } = string.Empty;
        public DateTime Date { get; set; }
    }
}
