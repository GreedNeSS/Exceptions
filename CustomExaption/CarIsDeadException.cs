using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomExaption
{
    #region Take One!
    //class CarIsDeadException : ApplicationException
    //{
    //    private string messageDetails = String.Empty;
    //    public DateTime ErrorTimeStamp { get; set; }
    //    public string CauseOfError { get; set; }

    //    public CarIsDeadException()
    //    {

    //    }

    //    public CarIsDeadException(string message, DateTime time, string cause)
    //    {
    //        messageDetails = message;
    //        ErrorTimeStamp = time;
    //        CauseOfError = cause;
    //    }

    //    public override string Message => $"Car error message: {messageDetails}";
    //}
    #endregion

    #region Take Two!
    //class CarIsDeadException : ApplicationException
    //{
    //    public DateTime ErrorTimeStamp { get; set; }
    //    public string CauseOfError { get; set; }

    //    public CarIsDeadException()
    //    {

    //    }

    //    public CarIsDeadException(string message, DateTime time, string cause) :
    //            base(message)
    //    {
    //        ErrorTimeStamp = time;
    //        CauseOfError = cause;
    //    }
    //}
    #endregion

    #region Take Three!
    [global::System.Serializable]
    class CarIsDeadException : ApplicationException
    {
        public CarIsDeadException() { }

        public CarIsDeadException(string message) : base(message) { }
        public CarIsDeadException(string message, Exception inner) : base(message, inner) { }
        protected CarIsDeadException(
            System.Runtime.Serialization.SerializationInfo info,
            System.Runtime.Serialization.StreamingContext context
            ) : base(info, context) { }

        public DateTime ErrorTimeStamp { get; set; }
        public string CauseOfError { get; set; }

        public CarIsDeadException(string message, DateTime time, string cause) :
                base(message)
        {
            ErrorTimeStamp = time;
            CauseOfError = cause;
        }
    }
    #endregion
}
