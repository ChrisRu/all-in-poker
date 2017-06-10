namespace AllInPoker.Models
{
    using System;
    using System.Collections.Generic;

    public class PersonModel
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string MiddleName { get; set; }

        public string LastName { get; set; }

        public char Gender { get; set; }

        public DateTime BirthDate { get; set; }

        public List<string> PhoneNumbers { get; set; }

        public List<string> Emails { get; set; }

        public string GetFullGender()
        {
            switch (this.Gender)
            {
                case 'm':
                    return "Man";

                case 'v':
                    return "Vrouw";

                default:
                    return "Niet bekend";
            }
        }
    }
}