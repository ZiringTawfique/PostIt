using System;
namespace Domain.Exceptions
{
    public class PostTypeIsUnknownException:Exception
    {
        private const string message = "THE POST TYPE IS UNKNOWN";

        public PostTypeIsUnknownException():base(ErrorMessage)
        {
        }

        public static string ErrorMessage => message;
    }
}
