namespace MrNote.Contracts;
public record NoteResponse(
  Guid Id,
  string Title,
  string Description,
  string Author,
  List<string> Todos
);
