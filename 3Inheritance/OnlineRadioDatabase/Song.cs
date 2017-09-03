public class Song
{
    private const int SecsMin = 0;
    private const int SecsMax = 59;
    private const int MinsMin = 0;
    private const int MinsMax = 14;
    private const int NameLenMin = 3;
    private const int NameLenMax = 30;
    private const int ArtistNameMin = 3;
    private const int ArtistNameMax = 20;

    private string artistName;
    private string name;
    private int minutes;
    private int seconds;

    public Song(string artistName, string name, int minutes, int seconds)
    {
        this.ArtistName = artistName;
        this.Name = name;
        this.Minutes = minutes;
        this.Seconds = seconds;
    }

    public int Seconds
    {
        get
        {
            return this.seconds;
        }

        private set
        {
            if (value < SecsMin || value > SecsMax)
            {
                throw new InvalidSongSecondsException();
            }

            this.seconds = value;
        }
    }

    public int Minutes
    {
        get
        {
            return this.minutes;
        }

        private set
        {
            if (value < MinsMin || value > MinsMax)
            {
                throw new InvalidSongMinutesException();
            }

            this.minutes = value;
        }
    }

    public string Name
    {
        get
        {
            return this.name;
        }

        private set
        {
            if (value.Length < NameLenMin || value.Length > NameLenMax)
            {
                throw new InvalidSongNameException();
            }

            this.name = value;
        }
    }

    public string ArtistName
    {
        get
        {
            return this.artistName;
        }

        private set
        {
            if (value.Length < ArtistNameMin || value.Length > ArtistNameMax)
            {
                throw new InvalidArtistNameException();
            }

            this.artistName = value;
        }
    }
}