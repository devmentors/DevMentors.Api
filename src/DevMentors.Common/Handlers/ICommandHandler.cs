using DevMentors.Messages.Commands;
using System.Threading.Tasks;

namespace DevMentors.Common.Handlers
{
    public interface ICommandHandler<in TCommand> where TCommand : ICommand
    {
        Task HandleAsync(TCommand command);
    }
}