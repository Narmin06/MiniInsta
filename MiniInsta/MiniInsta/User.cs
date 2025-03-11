namespace MiniInsta;

internal class User
{
    public int Id { get; set; } 
    public string Login {  get; set; }
    public string Password { get; set; }
    public bool IsOpen { get; set; } = true;
    public bool Gender { get; set; } = true;
    public DateTime? Birthday { get; set; }
    public List<Post> Posts { get; set; }
    public override string ToString()
    {
        return $@"Login: {Login}
Password: {Password}";
    }
}
