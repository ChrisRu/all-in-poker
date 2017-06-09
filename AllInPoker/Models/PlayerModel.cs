namespace AllInPoker.Models
{
    public class PlayerModel : PersonModel
    {
        public string PostalCode { get; set; }

        public string City { get; set; }

        public string Street { get; set; }

        public string HouseNumber { get; set; }

        public decimal MoneyWon { get; set; }

        public int Rating { get; set; }

        public string IbanNumber { get; set; }
    }
}
