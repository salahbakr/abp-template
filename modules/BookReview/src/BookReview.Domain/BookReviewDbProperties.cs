namespace BookReview;

public static class BookReviewDbProperties
{
    public static string DbTablePrefix { get; set; } = "BookReview";

    public static string? DbSchema { get; set; } = null;

    public const string ConnectionStringName = "BookReview";
}
