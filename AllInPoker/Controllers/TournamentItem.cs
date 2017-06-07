namespace AllInPoker.Controllers
{
    using System;

    public class TournamentItem
    {
        public int Id { get; set; }

        public DateTime Date { get; set; }

        public decimal Cost { get; set; }

        public short MinPlayers { get; set; }

        public short MinAge { get; set; }

        public short MaxAge { get; set; }

        public int LocationId { get; set; }

        public int EmployeeId { get; set; }

        public int WinnerId { get; set; }

        public short Round { get; set; }
    }
}
