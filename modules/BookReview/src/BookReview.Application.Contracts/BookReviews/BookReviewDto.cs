using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Data;

namespace BookReview.BookReviews;

public class BookReviewDto
{
    public Guid Id { get; set; }
    public string ReviewerName { get; set; }
    public string Text { get; set; }
    public int Rating { get; set; }
    public Guid UserId { get; set; }
    public Guid BookId { get; set; }
    public string BookName { get; set; }
    public DateTime LastModificationTime { get; set; }
    public Guid LastModifierId { get; set; }
    public Guid CreatorId { get; set; }
    public DateTime CreationTime { get; set; }
    public string ConcurrencyStamp { get; set; }
    public ExtraPropertyDictionary ExtraProperties { get; set; }
}