namespace MauiHumanizer;

public class OtherModel
{
    public long Id { get; set; }

    public required DateTime SentTs { get; set; }

    public required string Title { get; set; }

    public required string Message { get; set; }
}