using Microsoft.EntityFrameworkCore;

public class FeedbackContext : DbContext {
    public DbSet<Feedback> Feedback { get; set; }

    string stringConexao = "Server=localhost;Port=3306;Database=test_feedback;Uid=root;Pwd=Javaartteu12hot6354;";

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
        optionsBuilder.UseMySql(stringConexao, ServerVersion.AutoDetect(stringConexao));
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder) {
        modelBuilder.Entity<Feedback>().ToTable("Feedback");
    }
}