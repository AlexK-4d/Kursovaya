namespace Kursovaya.Models
{
    public class User
    {
        public int UserId { get; set; }

        public string? Email { get; set; }

        public int Phone { get; set; }

        public string? Surname { get; set; }

        public string? Name { get; set; }

        public string? SecName { get; set; }

        public int PassportSeries { get; set; }

        public int PassportNumber { get; set; }

        public string? Address { get; set; }

        public DateTime? DateOfBirth { get; set; }

        public string? Password { get; set; }


        public string FullName {
            get
            { 
            return Surname + " " + Name + " " + SecName; 
            }  
            }

        public int Passport
        { 
            get { 
                return int.Parse(PassportSeries.ToString() + " " + 
                    PassportNumber.ToString()); 
            }
        }
    }
}
