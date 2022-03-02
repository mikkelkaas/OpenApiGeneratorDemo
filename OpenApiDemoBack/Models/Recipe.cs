namespace OpenApiDemo.Models;

public class Recipe
{
    public Recipe(string name, int persons, List<string> ingrediens)
    {
        Name = name;
        Persons = persons;
        Ingrediens = ingrediens;
    }

    public Guid Id { get; set; } = Guid.NewGuid();
    public string Name { get; set; }
    public int Persons { get; set; }
    public List<string> Ingrediens { get; set; }
}