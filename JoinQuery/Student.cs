namespace JoinQuery
{
    public class Student
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Major {  get; set; }
        public int UniversityId {  get; set; }
        public University University { get; set; }
    }
}
