
namespace CleanCode.MagicNumbers
{
    public class MagicNumbers
    {
        const string rejected = "1";
        const string expired = "2";

        public void ApproveDocument(Status status)
        {
            if (status ==  Status.Approve)
            {
                // ...
            }
            else if (status ==  Status.Denied)
            {
                // ...
            }
        }

        public void RejectDoument(string status)
        {
            switch (status)
            {
                case rejected:
                    // ...
                    break;
                case expired:
                    // ...
                    break;
            }
        }

        public enum Status {
            Approve = 1,
            Denied = 2
        }

    }
}
