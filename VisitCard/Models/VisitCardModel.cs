namespace VisitCard.Models
{
    public class VisitCardModel
    {
        public string FullName { get; set; } = string.Empty;
        public DateTime BirthDate { get; set; }
        public string Description { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;

        // Вычисляемый возраст
        public int Age
        {
            get
            {
                var today = DateTime.Today;
                var age = today.Year - BirthDate.Year;
                if (BirthDate.Date > today.AddYears(-age)) age--;
                return age;
            }
        }
    }
}