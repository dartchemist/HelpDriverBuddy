namespace HelpDriverBuddy.Service.ConsoleClient
{
    using HelpDriverBuddy.Service.ConsoleClient.HelpDriverBuddyService;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            HelpDriverBuddyServiceClient client = new HelpDriverBuddyServiceClient();
            var c = client.GetVehicleProblems();
        }
    }
}
