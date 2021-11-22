using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace housecleaning4Api.Models
{
    public partial class housecleaning4Context : DbContext
    {
        public housecleaning4Context()
        {
        }

        public housecleaning4Context(DbContextOptions<housecleaning4Context> options)
            : base(options)
        {
        }

        public virtual DbSet<RoomCost> RoomCosts { get; set; }
        public virtual DbSet<UserTbl> UserTbls { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                //optionsBuilder.UseSqlServer("data source=.;initial catalog=housecleaning4;Integrated Security=true;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<RoomCost>(entity =>
            {
                entity.HasKey(e => e.RoomId);

                entity.ToTable("room_cost");

                entity.Property(e => e.RoomId)
                    .ValueGeneratedNever()
                    .HasColumnName("room_id");

                entity.Property(e => e.CostPerSqft).HasColumnName("cost_per_sqft");

                entity.Property(e => e.RoomName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("room_name");
            });

            modelBuilder.Entity<UserTbl>(entity =>
            {
                entity.HasKey(e => e.UserId);

                entity.ToTable("user_tbl");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.Property(e => e.BathroomSqft).HasColumnName("bathroom_sqft");

                entity.Property(e => e.BedroomSqft).HasColumnName("bedroom_sqft");

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("city");

                entity.Property(e => e.Fullname)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("fullname");

                entity.Property(e => e.KitchenSqft).HasColumnName("kitchen_sqft");

                entity.Property(e => e.LivingRoomSqft).HasColumnName("living_room_sqft");

                entity.Property(e => e.Message)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("message");

                entity.Property(e => e.PhoneNo)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("phone_no");

                entity.Property(e => e.PreferredDays)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("preferred_days");

                entity.Property(e => e.RequestNo)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("request_no")
                    .HasComputedColumnSql("(concat(substring([city],(1),(3)),'-',datepart(year,getdate()),'-',right(concat('00',[user_id]),(3))))", false);

                entity.Property(e => e.StreetAddress)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnName("street_address");

                entity.Property(e => e.TotalAmount).HasColumnName("total_amount");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
