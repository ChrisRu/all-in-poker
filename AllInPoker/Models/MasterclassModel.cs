namespace AllInPoker.Models
{
    using System;
    using System.Collections.Generic;

    public class MasterclassModel
    {
        public int Id { get; set; }

        public DateTime Date { get; set; }

        public DateTime Time { get; set; }

        public int MinPlayers { get; set; }

        public int MinRating { get; set; }

        public int LocationId { get; set; }

        public int ProfessionalId { get; set; }

        public List<MasterclassEntryModel> Entries { get; set; }

        public string CityName { get; set; }
    }
}
