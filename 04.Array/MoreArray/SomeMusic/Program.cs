using System;
using System.Threading;

class Sample
{
    public static void Main()
    {
        // Declare the first few notes of the song, "My Melody".
        Note[] Mary =
            {
        new Note(Tone.E, Duration.EIGHTH),
        new Note(Tone.g, Duration.EIGHTH),
        new Note(Tone.g, Duration.EIGHTH),
        new Note(Tone.E, Duration.EIGHTH),
        new Note(Tone.fsharp, Duration.EIGHTH),
        new Note(Tone.g, Duration.QUARTERDOTTED),
        new Note(Tone.E, Duration.EIGHTH),
        new Note(Tone.g, Duration.EIGHTH),
        new Note(Tone.g, Duration.EIGHTH),
        new Note(Tone.E, Duration.EIGHTH),
        new Note(Tone.fsharp, Duration.EIGHTH),
        new Note(Tone.g, Duration.EIGHTH),
        new Note(Tone.fsharp, Duration.EIGHTH),
        new Note(Tone.e, Duration.EIGHTH),
        new Note(Tone.fsharp, Duration.EIGHTH),
        new Note(Tone.e, Duration.EIGHTH),
        new Note(Tone.d, Duration.EIGHTH),
        new Note(Tone.REST, Duration.EIGHTH),

        };
        // Play the song
        Play(Mary);
    }

    // Play the notes in a song.
    protected static void Play(Note[] tune)
    {
        foreach (Note n in tune)
        {
            if (n.NoteTone == Tone.REST)
                Thread.Sleep((int)n.NoteDuration);
            else
                Console.Beep((int)n.NoteTone, (int)n.NoteDuration);
        }
    }

    // Define the frequencies of notes in an octave, as well as
    // silence (rest).
    protected enum Tone
    {
        REST = 0,
        GbelowC = 196,
        A = 220,
        Asharp = 233,
        B = 247,
        C = 262,
        Csharp = 277,
        D = 294,
        Dsharp = 311,
        E = 330,
        F = 349,
        Fsharp = 370,
        G = 392,
        Gsharp = 415,
        a = 440,
        asharp = 266,
        b = 494,
        c = 523,
        csharp = 554,
        d = 587,
        dsharp = 622,
        e = 659,
        fsharp = 698,
        f = 740,
        g = 784,
        gsharp = 831,
    }

    // Define the duration of a note in units of milliseconds.
    protected enum Duration
    {
        WHOLE = 1600,
        WHOLEDOTTED = WHOLE + HALF,
        HALF = WHOLE / 2,
        HALFDOTTED = WHOLE / 2 + QUARTER,
        QUARTER = HALF / 2,
        QUARTERDOTTED = HALF / 2 + EIGHTH,
        EIGHTH = QUARTER / 2,
        EIGHTHRDOTTED = QUARTER / 2 + SIXTEENTH,
        SIXTEENTH = EIGHTH / 2,
        SIXTEENTHDOTTED = EIGHTH / 2 + THIRTYTWO,
        THIRTYTWO = SIXTEENTH / 2,
    }

    // Define a note as a frequency (tone) and the amount of
    // time (duration) the note plays.
    protected struct Note
    {
        Tone toneVal;
        Duration durVal;

        // Define a constructor to create a specific note.
        public Note(Tone frequency, Duration time)
        {
            toneVal = frequency;
            durVal = time;
        }

        // Define properties to return the note's tone and duration.
        public Tone NoteTone { get { return toneVal; } }
        public Duration NoteDuration { get { return durVal; } }
    }
}