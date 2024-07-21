using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace BookReview;

public class BookReview : AuditedAggregateRoot<Guid>
{
    public string ReviewerName { get; set; } = "";
    public string Text { get; set; } = "";
    public int Rating { get; set; }

    public Guid UserId { get; set; }
    public Guid BookId { get; set; }
}