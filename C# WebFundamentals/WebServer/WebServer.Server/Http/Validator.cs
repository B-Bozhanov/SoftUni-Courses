namespace WebServer.Server.Http
{
    using static Common.GlobalConstants.ExceptionsMesseges;

    public class Validator
    {
        public static void IsNull(object obj)
        {
            if (obj == null)
            {
                throw new InvalidOperationException(String.Format(IsNullObject, nameof(obj)));
            }
        }
    }
}
