namespace IteratorDesignPattern.Model;
public record User
{
    public string Name { get; set; }
    public int Id { get; set; }
    public User(string name,int id)
    {
        Name = name;
        Id = id;
    }
}
