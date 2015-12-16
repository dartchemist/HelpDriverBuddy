namespace HelpDriverBuddy.Data.Models
{
    public class FullProblemInformation : BaseProblemInformation
    {
        public string Problem { get; set; }
        public string OwnerName { get; set; }
        public string OwnerPhone { get; set; }

        public ProblemLocation Location { get; set; }
    }
}
