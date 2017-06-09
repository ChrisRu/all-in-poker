namespace AllInPoker.Models
{
    using System;

    public class MasterclassEntryModel
    {
        public int PlayerId { get; set; }

        public int MasterclassId { get; set; }

        public DateTime Date { get; set; }

        public bool HasPaid { get; set; }
    }
}
