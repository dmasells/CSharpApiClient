namespace IntakeQ.ApiClient.Models
{
    public class IntakeSubmission
    {
        public string IntakeId { get; set; }
        public string Type { get; set; }
        public int ClientId { get; set; }
        public string ExternalPracticeId { get; set; } = "";
        public string ExternalClientId { get; set; } = "";

    }
}
