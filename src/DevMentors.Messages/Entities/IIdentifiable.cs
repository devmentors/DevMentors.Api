using System;

namespace DevMentors.Messages.Entities
{
    public interface IIdentifiable
    {
         Guid Id { get; }
    }
}