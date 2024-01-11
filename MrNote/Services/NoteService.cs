using System;
using System.Collections.Generic;
using MrNote.Models;

namespace MrNote.Services;

public class NoteService : INotesService
{
  private static readonly Dictionary<Guid, Note> _note = new();
    public void CreateNote(Note note)
    {
      _note.Add(note.Id, note);
    }

    public Note GetNoteById(Guid id)
    {
        return _note[id];
    }
}