using System;

namespace DevMentors.Common.Types
{
    public class DevMentorsException : Exception
    {
        public string Code { get; }

        public DevMentorsException()
        {
        }

        public DevMentorsException(string code)
        {
            Code = code;
        }

        public DevMentorsException(string message, params object[] args) 
            : this(string.Empty, message, args)
        {
        }

        public DevMentorsException(string code, string message, params object[] args) 
            : this(null, code, message, args)
        {
        }

        public DevMentorsException(Exception innerException, string message, params object[] args)
            : this(innerException, string.Empty, message, args)
        {
        }

        public DevMentorsException(Exception innerException, string code, string message, params object[] args)
            : base(string.Format(message, args), innerException)
        {
            Code = code;
        }        
    }
}