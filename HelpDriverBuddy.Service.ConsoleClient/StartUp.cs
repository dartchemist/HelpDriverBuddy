namespace HelpDriverBuddy.Service.ConsoleClient
{
    using System.ServiceModel;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            ServiceReference.HelpDriverBuddyServiceClient client = new ServiceReference.HelpDriverBuddyServiceClient();
            var c = client.GetVehicleProblems();
        }
    }
}
