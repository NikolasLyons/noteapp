using System;
using System.Collections.Generic;

namespace MrNote.Models;

public class Note
{

    public Guid Id { get; }
    public string Title { get; }
    public string Description { get; }
    // public DateTime CreatedAt { get; }
    // public DateTime LastModifiedAt { get; }
    public string Author { get; }
    public List<string> Todos { get; }
    // public List<string> Tags { get; }
    // public List<string> Attachments { get; }
    // public DateTime Reminder { get; }
    // public string ColorOrTheme { get; }
    // public string Location { get; }

    public Note(
      Guid id,
      string title,
      string description,
      string author,
      List<string> todos

    )
    {
      Id = id;
      Title = title;
      Description = description;
      Author = author;
      Todos = todos;

      
    }
}