namespace AllInPoker.Models
{
    using System;
    using System.Collections.Generic;

    public class TournamentModel
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

        public List<TournamentEntryModel> Entries { get; set; }

        public List<TournamentTableModel> Tables { get; set; }
    }
}