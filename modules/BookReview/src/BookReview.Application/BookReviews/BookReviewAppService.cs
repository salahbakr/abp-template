using Acme.BookStore.Books;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.Users;

namespace BookReview.BookReviews;

public class BookReviewAppService : ApplicationService, IBookReviewAppService
{
    private readonly IRepository<BookReview, Guid> _bookReviewRepository;
    private readonly IRepository<Book, Guid> _bookRepository;
    private readonly ICurrentUser _currentUser;

    public BookReviewAppService(
        IRepository<BookReview, Guid> bookReviewRepository,
        IRepository<Book, Guid> bookRepository,
        ICurrentUser currentUser)
    {
        _bookReviewRepository = bookReviewRepository;
        _bookRepository = bookRepository;
        _currentUser = currentUser;
    }

    public async Task<BookReviewDto> CreateAsync(CreateBookReviewDto input)
    {
        var book = await _bookRepository.GetAsync(input.BookId); // Ensure the book exists

        if (book == null)
        {
            throw new ArgumentNullException(nameof(book));
        }

        var review = ObjectMapper.Map<CreateBookReviewDto, BookReview>(input);
        review.UserId = _currentUser.Id.Value;
        review.ReviewerName = _currentUser.Name;

        await _bookReviewRepository.InsertAsync(review);
        return ObjectMapper.Map<BookReview, BookReviewDto>(review);
    }

    public async Task<List<BookReviewDto>> GetListAsync()
    {
        var reviews = await _bookReviewRepository.GetListAsync();
        var bookIds = reviews.Select(r => r.BookId).Distinct().ToList();
        var books = await _bookRepository.GetListAsync(b => bookIds.Contains(b.Id));

        return reviews.Select(review => new BookReviewDto
        {
            Id = review.Id,
            ReviewerName = review.ReviewerName,
            Text = review.Text,
            Rating = review.Rating,
            BookId = review.BookId,
            UserId = review.UserId,
            BookName = books.FirstOrDefault(b => b.Id == review.BookId)?.Name
        }).ToList();
    }
}
