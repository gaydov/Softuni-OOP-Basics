public class InvalidSongSecondsException : InvalidSongLengthException
{
    private const int MinLength = 0;
    private const int MaxLength = 59;

    public override string Message
    {
        get { return $"Song seconds should be between {MinLength} and {MaxLength}."; }
    }
}
