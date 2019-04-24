namespace MoveIT.Models.Models
{
    public class User
    {
        public int Id { get; set; }
        public Client Customer { get; set; }
        public string Password { get; set; }

    }
}
