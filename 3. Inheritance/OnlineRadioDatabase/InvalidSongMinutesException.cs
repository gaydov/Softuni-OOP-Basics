public class InvalidSongMinutesException : InvalidSongLengthException
{
    private const int MinLength = 0;
    private const int MaxLength = 14;

    public override string Message
    {
        get { return $"Song minutes should be between {MinLength} and {MaxLength}."; }
    }
}

