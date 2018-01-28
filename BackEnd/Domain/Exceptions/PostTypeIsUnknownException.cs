using System;
namespace Domain.Exceptions
{
    public class PostTypeIsUnknownException:Exception
    {
        private const string message = "The post type is uknown";

        public PostTypeIsUnknownException():base(ErrorMessage)
        {
        }

        public static string ErrorMessage => message;
    }
}
