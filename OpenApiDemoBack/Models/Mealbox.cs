namespace OpenApiDemo.Models;

public class Mealbox
{
    public Mealbox(string name, DateTime publicDate, List<Recipe> recipes)
    {
        Name = name;
        PublicDate = publicDate;
        Recipes = recipes;
    }

    public Guid Id { get; set; } = Guid.NewGuid();
    public string Name { get; set; }
    public string Author { get; set; }
    public DateTime PublicDate { get; set; }
    public List<Recipe> Recipes { get; set; }

}