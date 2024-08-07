namespace MovieLab.Models
{
    public class OMDBResponse
    {
        public List<Movie> Search { get; set; }
        public string totalresults { get; set; }
        public string Response { get; set; }    
    }
}
