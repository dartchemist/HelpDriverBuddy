namespace HelpDriverBuddy.Service.ConsoleClient
{
    using ServiceReferenceTest;
    using System.ServiceModel;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            HelpDriverBuddyServiceClient client = new HelpDriverBuddyServiceClient();
            var c = client.GetVehicleProblems();
        }
    }
}
