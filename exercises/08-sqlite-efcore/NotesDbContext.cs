using Microsoft.EntityFrameworkCore;

namespace Exercises._08_SqliteEfCore;

public sealed class NotesDbContext : DbContext
{
    public DbSet<StudyNote> StudyNotes => Set<StudyNote>();

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=study-notes.db");
    }
}
