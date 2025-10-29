using System;

namespace CustomExcExample

{
    [Serializable]
    public class CustomException:ApplicationException
    {
        private string messageDetails = string.Empty;

        public DateTime ErrorTimeStamp { get; set; }
        public string CauseOfError { get; set; }

        public CustomException() { }

        public CustomException(string message, string cause, DateTime time,Exception inner):
            base(message,inner)
        {
            messageDetails = message;
            CauseOfError = cause;
            ErrorTimeStamp = time;
        }

        // Override the Exception.Message property
        public override string Message
        {
            get
            {
                return string.Format("An unrecoverable error was encountered: {0}", messageDetails);
            }
        }
    }
}
