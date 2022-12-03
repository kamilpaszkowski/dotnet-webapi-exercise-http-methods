namespace Euvic.WebAPI.HttpMethods.Controllers.Requests
{
    public class UpdateTrainingRequest
    {
        public int StartDate { get; set; }
        public int DurationInMinutes { get; set; }
        public string Description { get; set; }
    }
}
