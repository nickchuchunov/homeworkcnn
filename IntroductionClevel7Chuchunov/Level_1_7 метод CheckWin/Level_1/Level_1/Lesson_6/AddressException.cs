using System;
using System.Collections.Generic;
using System.Text;

namespace Level_1.Lesson_6
{
    public enum ErrorCodes
    {
        NoAddress,
        NoBuilding
    }

    //[Serializable]
    //public class AddressException : Exception { }

    [Serializable]
    public class AddressException : Exception
    {
        public AddressException(ErrorCodes code)
        {
            Code = code;
        }

        public ErrorCodes Code { get; }
    }
}
