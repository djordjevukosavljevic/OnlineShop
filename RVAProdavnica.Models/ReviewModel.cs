namespace RVAProdavnica.Models
{
    public class ReviewModel 
    {
        public int Id {get; set;}

        public DateTime DateCreatedAt {get; set;}

        public DateTime DateUpdatetAt {get; set;}

        public bool Active {get;  set;}

        public int Grade {get; set;}

        
    }
}