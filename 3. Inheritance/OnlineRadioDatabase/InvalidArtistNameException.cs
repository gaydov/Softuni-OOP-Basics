public class InvalidArtistNameException : InvalidSongException
{
    private const int MinLength = 3;
    private const int MaxLength = 20;

    public override string Message
    {
        get { return $"Artist name should be between {MinLength} and {MaxLength} symbols."; }
    }
}

