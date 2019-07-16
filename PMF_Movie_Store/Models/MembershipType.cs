using System.ComponentModel.DataAnnotations;

namespace PMF_Movie_Store.Models
{
    public class MembershipType
    {
        public byte Id { get; set; }
        [Required]
        public string Name { get; set; }
        public short SignUpFee { get; set; }
        public byte DurationInMonths { get; set; }
        public byte DiscountRate { get; set; }

        public static readonly byte Unknown = 0; // koristimo za model Min18YearsIfMember, kako bi lakše vidjeli o cemu se radi
        public static readonly byte PayAsYouGo = 1;
    }
}