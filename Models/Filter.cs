

namespace SchoolManagementSystem.Models
{
    public class Filter
    {
        public string? firstName { get; set; }
        public string? lastName { get; set; }
        public string? classCode { get; set; }
        public int? above { get; set; }
        public int? below { get; set; }

        public Filter()
        {
            above = -1;
            below = 101;
        }
        public bool SetName(string fullName)
        {
            var Name = fullName.Split(' ');
            if(Name.Length == 1 )
                firstName = Name[0];
            
            else if(Name.Length == 2 ) { 
                firstName= Name[0];
                lastName = Name[1];
            }
            else return false;
            return true;
        }
        public void gradeRange(int above, int below)
        {
            this.above = above;
            this.below = below;
        }
    }
}
