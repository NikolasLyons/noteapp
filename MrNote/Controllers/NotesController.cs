using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MrNote.Contracts;
using MrNote.Models;
using MrNote.Services;

namespace Notes.Controllers;

[ApiController]
[Route("api/[controller]")]
public class NotesController : ControllerBase
{
  private readonly INotesService _noteService;

    public NotesController(INotesService noteService)
    {
        _noteService = noteService;
    }

    [HttpPost]
  public IActionResult CreateNote(CreateNoteRequest noteData)
  {
    var note = new Note(
      Guid.NewGuid(),
      noteData.Title,
      noteData.Description,
      noteData.Author,
      noteData.Todos
    );
    // TODO: save to database

    _noteService.CreateNote(note);
    var response = new NoteResponse(

      note.Id,
      note.Title,
      note.Description,
      note.Author,
      note.Todos
    );
    
   return CreatedAtAction(
    actionName: nameof(GetNoteById),
    routeValues: new {id = note.Id},
    value: response);
  }
  [HttpGet("{id:guid}")]
  public IActionResult GetNoteById(Guid id)
  {
    Note note = _noteService.GetNoteById(id);
    var response  = new NoteResponse(
      note.Id,
      note.Title,
      note.Description,
      note.Author,
      note.Todos
    );
    return Ok(response);
  }
}