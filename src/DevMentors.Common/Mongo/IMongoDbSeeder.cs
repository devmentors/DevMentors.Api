using System.Threading.Tasks;

namespace DevMentors.Common.Mongo
{
    public interface IMongoDbSeeder
    {
        Task SeedAsync();
    }
}