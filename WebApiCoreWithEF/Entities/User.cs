namespace LibraryManagementSystemEF.Entities
{
    public abstract class User
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}, Email: {Email}, Password: {Password}";
        }
    }
}
