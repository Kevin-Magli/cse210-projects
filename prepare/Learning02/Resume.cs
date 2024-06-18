public class Resume
{
    public string _name;
    public List<Job> _jobs = new List<Job>();
    // (Hint: the data type for this should be List<Job> , and it is probably easiest to initialize this to a new list right when you declare it..)

    public void Display()
    {
        Console.WriteLine($"Name: {_name}");
        foreach (Job job in _jobs)
        {
            job.Display();
            Console.WriteLine("Jobs:");
        }
    }
}