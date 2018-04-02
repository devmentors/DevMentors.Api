using System.Collections.Generic;
using System.Security.Claims;

namespace DevMentors.Common.Authentication
{
    public class JsonWebTokenPayload
    {
        public string Subject { get; set; }
        public string Role { get; set; }
        public long Expires { get; set; }
    }
}