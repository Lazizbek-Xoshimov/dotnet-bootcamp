namespace JoinQuery
{
    public class University
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address {  get; set; }
        public List<Student> Students { get; set; }
    }
}
