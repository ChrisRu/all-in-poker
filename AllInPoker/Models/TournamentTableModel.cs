namespace AllInPoker.Models
{
    using System.Collections.Generic;

    public class TournamentTableModel
    {
        public int Id { get; set; }

        public int TournamentId { get; set; }

        public int Round { get; set; }

        public List<TournamentTablePlayerModel> Players { get; set; }
    }
}