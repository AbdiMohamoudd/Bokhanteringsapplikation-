using System;

public class Pass
{
    public string Workout { get; set; }
    public DateTime Time { get; set; }
    public int MaxParticipants { get; set; }
    public int BookedParticipants { get; set; }

    public Pass(string workout, DateTime time, int maxParticipants)
    {
        Workout = workout;
        Time = time;
        MaxParticipants = maxParticipants;
        BookedParticipants = 0;
    }
}
