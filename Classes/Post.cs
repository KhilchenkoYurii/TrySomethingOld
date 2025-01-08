using System.Text;

namespace Classes;

public class Post
{
    private string _title;
    private string _description;
    private DateTime _created;
    private float _votes = 0;

    public Post()
    {
        _title = "Title";
        _description = "Description";
        _created = DateTime.Now;
    }

    public Post(string title, string description)
    {
        _title = title;
        _description = description;
        _created = DateTime.Now;
    }

    public void UpVote()
    {
        _votes += 1;
    }

    public void DownVote()
    {
        _votes -= 1;
    }

    public void Represent()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("Title: " + _title)
            .AppendLine()
            .Append("Description: " + _description)
            .AppendLine()
            .Append("Created: " + _created.ToString())
            .AppendLine()
            .Append("Votes: " + _votes);
        Console.WriteLine(sb);
    }
}