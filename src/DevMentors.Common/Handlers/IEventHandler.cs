using DevMentors.Messages.Events;
using System.Threading.Tasks;

namespace DShop.Common.Handlers
{
    public interface IEventHandler<in TEvent> where TEvent : IEvent
    {
        Task HandleAsync(TEvent @event);
    }
}