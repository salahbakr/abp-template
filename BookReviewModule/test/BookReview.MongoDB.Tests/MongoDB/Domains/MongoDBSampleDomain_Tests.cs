using BookReview.Samples;
using Xunit;

namespace BookReview.MongoDB.Domains;

[Collection(MongoTestCollection.Name)]
public class MongoDBSampleDomain_Tests : SampleManager_Tests<BookReviewMongoDbTestModule>
{

}
