namespace AllInPoker.Models
{
    public class EventLocationModel
    {
        public int Id { get; set; }

        public int MaxPlayers { get; set; }

        public string PostalCode { get; set; }

        public string City { get; set; }

        public string Street { get; set; }

        public int HouseNumber { get; set; }
    }
}