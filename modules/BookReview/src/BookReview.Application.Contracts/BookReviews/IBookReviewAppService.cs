using BookReview.BookReviews;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace BookReview;

public interface IBookReviewAppService : IApplicationService
{
    Task<List<BookReviewDto>> GetListAsync();
    Task<BookReviewDto> CreateAsync(CreateBookReviewDto input);
}
