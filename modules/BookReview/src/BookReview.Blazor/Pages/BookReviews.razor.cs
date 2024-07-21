using Acme.BookStore.Books;
using Blazorise;
using BookReview.BookReviews;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

    private Modal CreateBookReviewModal { get; set; }

    private Validations CreateValidationsRef;

    public BookReviews()
    {
        NewBookReview = new CreateBookReviewDto();
    }

    protected override async Task OnInitializedAsync()
    {
        await GetBookReviewsAsync();
        await GetBooksAsync();
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
}
