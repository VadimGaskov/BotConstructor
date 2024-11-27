namespace BotConstructor.Domain.Entities;

public class Section
{
    public Guid Id { get; set; }
    public string Title { get; set; }
    public string? Message { get; set; }
    public Section? ParentSection { get; set; }
}