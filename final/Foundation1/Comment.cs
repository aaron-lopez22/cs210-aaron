public class Comments
{
    public string _nameCommenter = "";
    public string _comment = "";

    

    public void Display()
    {
        Console.WriteLine($"Name: @{_nameCommenter}");
        Console.WriteLine($"{_comment}");
       
    }
}