using BusTransportationModel.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Route = BusTransportationModel.Data.Entities.Route;

namespace BusTransportationModel.Data;

public class BusModelDbContext : DbContext
{
    public DbSet<Voyage> Voyages { get; set; }
    public DbSet<Route> Routes { get; set; }
    public DbSet<Ticket> Tickets { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<Role> Roles { get; set; }

    public BusModelDbContext(DbContextOptions options) : base(options)
    {
    }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Role>().HasKey(x => x.Id);
        modelBuilder.Entity<Role>().HasMany(x => x.Users)
            .WithOne(x => x.Role)
            .HasForeignKey(x => x.RoleId)
            .OnDelete(DeleteBehavior.Restrict); // Запретить удаление роли, если есть связанные пользователи

        modelBuilder.Entity<Route>().HasKey(x => x.Id);

        modelBuilder.Entity<Ticket>().HasKey(x => x.Id);
        modelBuilder.Entity<Ticket>().HasOne(x => x.Voyage)
            .WithMany(x => x.Tickets)
            .HasForeignKey(x => x.VoyageId); // Связь билета с рейсом
        modelBuilder.Entity<Ticket>().HasOne(x => x.User)
            .WithMany(x => x.Tickets)
            .HasForeignKey(x => x.UserId); // Связь билета с пользователем

        modelBuilder.Entity<User>().HasKey(x => x.Id);
        modelBuilder.Entity<User>().HasOne(x => x.Role)
            .WithMany(x => x.Users)
            .HasForeignKey(x => x.RoleId);

        modelBuilder.Entity<Voyage>().HasKey(x => x.Id);
        modelBuilder.Entity<Voyage>().HasOne(x => x.Route)
            .WithMany(x => x.Voyages)
            .HasForeignKey(x => x.RouteID); // Связь рейса с маршрутом
        modelBuilder.Entity<Voyage>().HasOne(x => x.Admin)
            .WithMany(x => x.AdminVoyages)
            .HasForeignKey(x => x.AdminId); // Связь рейса с администратором (один ко многим)
        modelBuilder.Entity<Voyage>().HasOne(x => x.User)
            .WithMany(x => x.UserVoyages)
            .HasForeignKey(x => x.UserId); // Связь рейса с пользователем (один ко многим)

        base.OnModelCreating(modelBuilder);
    }
}