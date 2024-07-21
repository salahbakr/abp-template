using Acme.BookStore.Books;
using Blazorise;
using BookReview.BookReviews;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;

namespace BookReview.Blazor.Pages;

public partial class BookReviews
{
    private IReadOnlyList<BookReviewDto> BookReviewList { get; set; }
    private IReadOnlyList<BookDto> Books { get; set; }

    private int PageSize { get; } = LimitedResultRequestDto.DefaultMaxResultCount;
    private int CurrentPage { get; set; }
    private string CurrentSorting { get; set; }
    private int TotalCount { get; set; }

    private CreateBookReviewDto NewBookReview { get; set; }
    private CreateBookReviewDto EditingBookReview { get; set; } = new CreateBookReviewDto();
    private Guid EditingBookReviewId { get; set; }

    private Modal CreateBookReviewModal { get; set; }
    private Modal EditBookReviewModal { get; set; }

    private Validations CreateValidationsRef;
    private Validations EditValidationsRef;

    public BookReviews()
    {
        NewBookReview = new CreateBookReviewDto();
    }

    private async Task GetBookReviewsAsync()
    {
        var result = await BookReviewAppService.GetListAsync();
        BookReviewList = result;
        TotalCount = BookReviewList.Count;
    }

    private async Task GetBooksAsync()
    {
        var pagedResult = new PagedAndSortedResultRequestDto
        {
            SkipCount = 0,
        };
        var result = await BookAppService.GetListAsync(pagedResult);
        Books = result.Items;
    }

    private void OpenCreateBookReviewModal()
    {
        CreateValidationsRef.ClearAll();
        NewBookReview = new CreateBookReviewDto();
        CreateBookReviewModal.Show();
    }

    private void CloseCreateBookReviewModal()
    {
        CreateBookReviewModal.Hide();
    }

    private async Task CreateBookReviewAsync()
    {
        if (await CreateValidationsRef.ValidateAll())
        {
            await BookReviewAppService.CreateAsync(NewBookReview);
            await GetBookReviewsAsync();
            CloseCreateBookReviewModal();
        }
    }
    private void OpenEditBookReviewModal(BookReviewDto bookReview)
    {
        EditingBookReviewId = bookReview.Id;
        EditingBookReview.Rating = bookReview.Rating;
        EditingBookReview.Text = bookReview.Text;
        EditValidationsRef.ClearAll();
        EditBookReviewModal.Show();
    }

    private void CloseEditBookReviewModal()
    {
        EditBookReviewModal.Hide();
    }

    private async Task UpdateBookReviewAsync()
    {
        if (await EditValidationsRef.ValidateAll())
        {
            await BookReviewAppService.UpdateAsync(EditingBookReviewId, EditingBookReview);
            await GetBookReviewsAsync();
            CloseEditBookReviewModal();
        }
    }

    private async Task DeleteBookReviewAsync(BookReviewDto bookReview)
    {
        await BookReviewAppService.DeleteAsync(bookReview.Id);
        await GetBookReviewsAsync();
    }
}