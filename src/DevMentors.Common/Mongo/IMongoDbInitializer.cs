using System.Threading.Tasks;

namespace DevMentors.Common.Mongo
{
    public interface IMongoDbInitializer
    {
        Task InitializeAsync();
    }
}