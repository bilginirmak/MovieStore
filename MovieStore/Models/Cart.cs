namespace MovieStore.Models
{
    public class Cart
    {
        public int Id { get; set; }
        public int ItemId { get; set; }
        public List<Movie> Items { get; set; } = new List<Movie>();
    }
}
