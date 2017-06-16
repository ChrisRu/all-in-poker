namespace AllInPoker.Models
{
    using System;

    public class TournamentEntryModel
    {
        public int ReferenceNumber { get; set; }

        public int PlayerId { get; set; }

        public int TournamentId { get; set; }

        public DateTime Date { get; set; }

        public bool HasPaid { get; set; }

        public PlayerModel Player { get; set; }
    }
}