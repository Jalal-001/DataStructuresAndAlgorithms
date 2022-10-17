public class ToDo
{
    public int Time { get; set; }
    public string Describe { get; set; }
    public override string ToString()
    {
        return $"{Describe,-50} {Time,-3}";
    }
}