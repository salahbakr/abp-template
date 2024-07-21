using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookReview.BookReviews;

public class CreateBookReviewDto
{
    [Required]
    [StringLength(500)]
    public string Text { get; set; } = "";

    [Range(1, 5)]
    public int Rating { get; set; }

    [Required]
    public Guid BookId { get; set; }
}
