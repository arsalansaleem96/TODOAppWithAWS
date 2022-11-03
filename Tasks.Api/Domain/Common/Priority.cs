using ValueOf;
public class Priority : ValueOf<int, Priority>
{
    protected override void Validate()
    {
        if (Value < 0)
        {
            throw new ArgumentException("Priority cannot be negative", nameof(Priority));
        }
    }
}