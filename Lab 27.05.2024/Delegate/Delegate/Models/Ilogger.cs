namespace Delegate.Models
{
    public interface Ilogger
    {
        void SendLog(string message);
    }

    public class IloggerFactory
    {

        public class SmsLog : IloggerFactory { }
        public class EmailLog : IloggerFactory { }
        public class XmlLog : IloggerFactory { }
        public class SqlLog : IloggerFactory { }
        public class PushLog : IloggerFactory { }
    }
}
