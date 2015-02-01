using System.Runtime.InteropServices;

namespace HttpUtillity.UtilException
{
    class HttpException : COMException
    {
        public HttpException(HttpUtilExceptionType type, string message = null)
            : base(message, (int)type) { }
    }
}
