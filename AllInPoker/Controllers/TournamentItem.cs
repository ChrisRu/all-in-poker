namespace AllInPoker.Controllers
{
    using System;

    public class TournamentItem
    {
        public int Id { get; set; }

        public DateTime Date { get; set; }

        public DateTime Time { get; set; }

        public decimal Cost { get; set; }

        public int MinPlayers { get; set; }

        public int MinAge { get; set; }

        public int MaxAge { get; set; }

        public int LocationId { get; set; }

        public int EmployeeId { get; set; }

        public int WinnerId { get; set; }

        public string CityName { get; set; }
    }
}
