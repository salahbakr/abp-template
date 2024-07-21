using BookReview.BookReviews;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace BookReview;

public interface IBookReviewApplicationService : IApplicationService
{
    Task<List<BookReviewDto>> GetListAsync();
    Task<BookReviewDto> CreateAsync(CreateBookReviewDto input);
    Task<BookReviewDto> UpdateAsync(Guid id, CreateBookReviewDto input);
    Task<BookReviewDto> DeleteAsync(Guid id);
}
