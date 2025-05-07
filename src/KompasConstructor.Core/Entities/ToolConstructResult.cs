using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KompasConstructor.Core.Entities
{
    public class ToolConstructResult
    {
        private readonly byte[]? _file;
        private readonly Exception? _exception;
        private readonly bool _isSuccess;

        private ToolConstructResult(byte[] file)
        {
            _file = file;
            _exception = null;
            _isSuccess = true;
        }

        private ToolConstructResult(Exception exception)
        {
            _file = default;
            _exception = exception;
            _isSuccess = false;
        }

        public static ToolConstructResult Success(byte[] file) => new(file);
        public static ToolConstructResult Fail(Exception exception) => new(exception);

        public byte[]? File => _file;
        public Exception? Exception => _exception;
        public bool IsSuccess => _isSuccess;
    }
}
