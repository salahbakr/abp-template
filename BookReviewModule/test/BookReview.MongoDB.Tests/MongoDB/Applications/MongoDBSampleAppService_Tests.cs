using BookReview.MongoDB;
using BookReview.Samples;
using Xunit;

namespace BookReview.MongoDb.Applications;

[Collection(MongoTestCollection.Name)]
public class MongoDBSampleAppService_Tests : SampleAppService_Tests<BookReviewMongoDbTestModule>
{

}
