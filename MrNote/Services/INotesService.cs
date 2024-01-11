using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MrNote.Models;

namespace MrNote.Services
{
    public interface INotesService
    {
        void CreateNote(Note note);
        
       Note GetNoteById(Guid id);
    }
}