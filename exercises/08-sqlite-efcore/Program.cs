using Exercises._08_SqliteEfCore;
using Microsoft.EntityFrameworkCore;

await using var db = new NotesDbContext();
await db.Database.EnsureCreatedAsync();

if (!await db.StudyNotes.AnyAsync())
{
    db.StudyNotes.Add(new StudyNote
    {
        Title = "First database note",
        Body = "This record is stored in SQLite and remains after the program exits."
    });

    await db.SaveChangesAsync();
}

var notes = await db.StudyNotes
    .OrderBy(note => note.CreatedUtc)
    .ToListAsync();

Console.WriteLine($"Stored notes: {notes.Count}");
foreach (var note in notes)
{
    Console.WriteLine($"[{note.Id}] {note.Title}: {note.Body}");
}
