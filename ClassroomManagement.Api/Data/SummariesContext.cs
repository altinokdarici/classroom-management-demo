namespace ClassroomManagement.Api.Data
{
    public class SummariesContext:ISummariesContext
    {
        private static readonly string[] SummariesArray = new[]
        {
                "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        public string[] GetSummaries()
        {
            return SummariesArray;
        }
    }
}

