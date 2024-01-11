namespace MrNote.Contracts;
public record CreateNoteRequest(
  string Title,
  string Description,
  string Author,
  List<string> Todos
);

