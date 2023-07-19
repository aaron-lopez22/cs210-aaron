public class Videos
{
    public string _title;

    public string _author;

    public string _length;

    public List<Comments> _comments = new List<Comments>();

    public void Display()
    {
        Console.WriteLine();
        Console.WriteLine($"Title of the video: {_title}, Author: {_author}, Length: {_length} ");
     

        foreach (Comments comment in _comments)
        {
            Console.WriteLine();
            comment.Display();
            
        }
    }
}