using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ITRI.Models.Entities
{
    public partial class ITRIContext : DbContext
    {
        public ITRIContext()
        {
        }

        public ITRIContext(DbContextOptions<ITRIContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Account> Account { get; set; }
        public virtual DbSet<AssemblyList> AssemblyList { get; set; }
        public virtual DbSet<Company> Company { get; set; }
        public virtual DbSet<Gon> Gon { get; set; }
        public virtual DbSet<Machine> Machine { get; set; }
        public virtual DbSet<Material> Material { get; set; }
        public virtual DbSet<Member> Member { get; set; }
        public virtual DbSet<Orderoutsource> Orderoutsource { get; set; }
        public virtual DbSet<Orderselfmade> Orderselfmade { get; set; }
        public virtual DbSet<Package> Package { get; set; }
        public virtual DbSet<Plan> Plan { get; set; }
        public virtual DbSet<Porder> Porder { get; set; }
        public virtual DbSet<PurchaseOrder> PurchaseOrder { get; set; }
        public virtual DbSet<Student> Student { get; set; }
        public virtual DbSet<Toolcutter> Toolcutter { get; set; }
        public virtual DbSet<Tooljig> Tooljig { get; set; }
        public virtual DbSet<WorkOrder> WorkOrder { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseMySQL("server=itri.caxkojlfld6f.us-east-1.rds.amazonaws.com;port=3306;user=admin;password=Tku8833122;database=ITRI");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.1-servicing-10028");

            modelBuilder.Entity<Account>(entity =>
            {
                entity.ToTable("account", "ITRI");

                entity.HasIndex(e => e.UserName)
                    .HasName("UserName_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.Active).HasColumnType("tinyint(4)");

                entity.Property(e => e.CompanyId)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.CreateDate).HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.NickName)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.Test)
                    .HasColumnName("test")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.Token)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Type)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.UserName)
                    .HasMaxLength(45)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AssemblyList>(entity =>
            {
                entity.ToTable("assembly list", "ITRI");

                entity.HasIndex(e => e.AGonNo)
                    .HasName("A_gonNo_idx");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.AGonNo)
                    .HasColumnName("A_gonNo")
                    .HasColumnType("int(11)");

                entity.Property(e => e.AListCompleteDate).HasColumnName("A_list_complete_date");

                entity.Property(e => e.AListImage)
                    .HasColumnName("A_list_image")
                    .HasColumnType("int(11)");

                entity.Property(e => e.AListMemberName)
                    .HasColumnName("A_list_member_name")
                    .HasColumnType("int(11)");

                entity.Property(e => e.AListPredictDate).HasColumnName("A_list_predict_date");

                entity.Property(e => e.AListTool)
                    .HasColumnName("A_list_tool")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CreateDate).HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.HasOne(d => d.AGonNoNavigation)
                    .WithMany(p => p.AssemblyList)
                    .HasForeignKey(d => d.AGonNo)
                    .HasConstraintName("A_gonNo");
            });

            modelBuilder.Entity<Company>(entity =>
            {
                entity.ToTable("company", "ITRI");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.Active)
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.CompanyName)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.CreateDate).HasDefaultValueSql("CURRENT_TIMESTAMP");
            });

            modelBuilder.Entity<Gon>(entity =>
            {
                entity.ToTable("gon", "ITRI");

                entity.HasIndex(e => e.PorderNo)
                    .HasName("porderId_idx");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CreateDate).HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.ModifyDate).HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.PorderNo)
                    .HasColumnName("porderNo")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.PorderNoNavigation)
                    .WithMany(p => p.Gon)
                    .HasForeignKey(d => d.PorderNo)
                    .HasConstraintName("porderId");
            });

            modelBuilder.Entity<Machine>(entity =>
            {
                entity.ToTable("machine", "ITRI");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.MachineBrand)
                    .HasColumnName("machine_Brand")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.MachineClass)
                    .IsRequired()
                    .HasColumnName("machine_Class")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.MachineEndingTime).HasColumnName("machine_EndingTime");

                entity.Property(e => e.MachineName)
                    .IsRequired()
                    .HasColumnName("machine_Name")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.MachineNo)
                    .HasColumnName("machine_No")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.MachineSize)
                    .HasColumnName("machine_Size")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.MachineStatus)
                    .HasColumnName("machine_Status")
                    .HasColumnType("tinyint(4)");

                entity.Property(e => e.MachineTableCreateDate)
                    .HasColumnName("machineTableCreateDate")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.MachineTableModifyDate)
                    .HasColumnName("machineTableModifyDate")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.MachineUsingTime).HasColumnName("machine_UsingTime");
            });

            modelBuilder.Entity<Material>(entity =>
            {
                entity.ToTable("material", "ITRI");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.MaterialBrand)
                    .HasColumnName("Material_Brand")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.MaterialClass)
                    .HasColumnName("Material_Class")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.MaterialCount)
                    .HasColumnName("Material_Count")
                    .HasColumnType("int(11)");

                entity.Property(e => e.MaterialName)
                    .HasColumnName("Material_Name")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.MaterialNo)
                    .HasColumnName("Material_No")
                    .HasColumnType("int(11)");

                entity.Property(e => e.MaterialSize)
                    .HasColumnName("Material_Size")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.MaterialStatus)
                    .HasColumnName("Material_Status")
                    .HasColumnType("tinyint(4)");

                entity.Property(e => e.MaterialTableCreateDate).HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.MaterialTableModifyDate).HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.MemberId).HasColumnType("tinyint(4)");

                entity.Property(e => e.OrderId).HasColumnType("tinyint(4)");
            });

            modelBuilder.Entity<Member>(entity =>
            {
                entity.ToTable("member", "ITRI");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.CreateDate).HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.MemberDuties)
                    .HasColumnName("member_Duties")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.MemberFiringDay)
                    .HasColumnName("member_FiringDay")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.MemberHiringDay)
                    .HasColumnName("member_HiringDay")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.MemberName)
                    .HasColumnName("member_Name")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.MemberNo)
                    .HasColumnName("member_No")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.MemberSubDuties)
                    .HasColumnName("member_Sub_Duties")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.MemberTransferMemberId)
                    .HasColumnName("member_TransferMember_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ModifyDate).HasDefaultValueSql("CURRENT_TIMESTAMP");
            });

            modelBuilder.Entity<Orderoutsource>(entity =>
            {
                entity.ToTable("orderoutsource", "ITRI");

                entity.HasIndex(e => e.OGonNo)
                    .HasName("O_gonNo_idx");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.CreateDate).HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.OGonNo)
                    .HasColumnName("O_gonNo")
                    .HasColumnType("int(11)");

                entity.Property(e => e.OOrderCompleteDate).HasColumnName("O_order_complete_date");

                entity.Property(e => e.OOrderContractor)
                    .HasColumnName("O_order_contractor")
                    .IsUnicode(false);

                entity.Property(e => e.OOrderImage)
                    .HasColumnName("O_order_image")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.OOrderMethod)
                    .HasColumnName("O_order_method")
                    .IsUnicode(false);

                entity.Property(e => e.OOrderPredictDate).HasColumnName("O_order_predict_date");

                entity.Property(e => e.OOrderSchedule)
                    .HasColumnName("O_order_schedule")
                    .IsUnicode(false);

                entity.HasOne(d => d.OGonNoNavigation)
                    .WithMany(p => p.Orderoutsource)
                    .HasForeignKey(d => d.OGonNo)
                    .HasConstraintName("O_gonNo");
            });

            modelBuilder.Entity<Orderselfmade>(entity =>
            {
                entity.ToTable("orderselfmade", "ITRI");

                entity.HasIndex(e => e.SGonNo)
                    .HasName("S_gonNo_idx");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.CreateDate).HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.SGonNo)
                    .HasColumnName("S_gonNo")
                    .HasColumnType("int(11)");

                entity.Property(e => e.SOrderCompleteDate).HasColumnName("S_order_complete_date");

                entity.Property(e => e.SOrderCount)
                    .HasColumnName("S_order_count")
                    .HasColumnType("int(11)");

                entity.Property(e => e.SOrderImage)
                    .HasColumnName("S_order_image")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.SOrderMachine)
                    .HasColumnName("S_order_machine")
                    .HasColumnType("int(11)");

                entity.Property(e => e.SOrderMaterial)
                    .HasColumnName("S_order_material")
                    .HasColumnType("int(11)");

                entity.Property(e => e.SOrderMemberName)
                    .HasColumnName("S_order_member_name")
                    .HasColumnType("int(11)");

                entity.Property(e => e.SOrderMethod)
                    .HasColumnName("S_order_method")
                    .IsUnicode(false);

                entity.Property(e => e.SOrderPredictDate).HasColumnName("S_order_predict_date");

                entity.Property(e => e.SOrderProgram)
                    .HasColumnName("S_order_program")
                    .IsUnicode(false);

                entity.Property(e => e.SOrderSchedule)
                    .HasColumnName("S_order_schedule")
                    .IsUnicode(false);

                entity.Property(e => e.SOrderSetting)
                    .HasColumnName("S_order_setting")
                    .IsUnicode(false);

                entity.Property(e => e.SOrderTool)
                    .HasColumnName("S_order_tool")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.SGonNoNavigation)
                    .WithMany(p => p.Orderselfmade)
                    .HasForeignKey(d => d.SGonNo)
                    .HasConstraintName("S_gonNo");
            });

            modelBuilder.Entity<Package>(entity =>
            {
                entity.ToTable("package", "ITRI");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.CreateDate).HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.MemberId).HasColumnType("tinyint(4)");

                entity.Property(e => e.OrderId).HasColumnType("tinyint(4)");

                entity.Property(e => e.Time).HasColumnType("tinyint(4)");
            });

            modelBuilder.Entity<Plan>(entity =>
            {
                entity.ToTable("plan", "ITRI");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.CreateDate).HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.MemberId).HasColumnType("tinyint(4)");

                entity.Property(e => e.OrderId).HasColumnType("tinyint(4)");

                entity.Property(e => e.Time).HasColumnType("tinyint(4)");
            });

            modelBuilder.Entity<Porder>(entity =>
            {
                entity.ToTable("porder", "ITRI");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.CreateDate).HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.PInOrderId)
                    .HasColumnName("P_In_order_Id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.POrderClientNo)
                    .HasColumnName("P_Order_Client_No")
                    .HasColumnType("int(11)");

                entity.Property(e => e.POrderCompleteDate).HasColumnName("P_order_complete_date");

                entity.Property(e => e.POrderPredictDate).HasColumnName("P_order_predict_date");

                entity.Property(e => e.POutOrderId)
                    .HasColumnName("P_Out_order_Id")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<PurchaseOrder>(entity =>
            {
                entity.ToTable("purchase order", "ITRI");

                entity.HasIndex(e => e.PGonNo)
                    .HasName("P_gonNo_idx");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.CreateDate).HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.PGonNo)
                    .HasColumnName("P_gonNo")
                    .HasColumnType("int(11)");

                entity.Property(e => e.PurchaseOrderCompleteDate).HasColumnName("Purchase_order_complete_date");

                entity.Property(e => e.PurchaseOrderList)
                    .HasColumnName("Purchase_order_list")
                    .IsUnicode(false);

                entity.Property(e => e.PurchaseOrderMemberName)
                    .HasColumnName("Purchase_order_member_name")
                    .HasColumnType("int(11)");

                entity.Property(e => e.PurchaseOrderPredictDate).HasColumnName("Purchase_order_predict_date");

                entity.HasOne(d => d.PGonNoNavigation)
                    .WithMany(p => p.PurchaseOrder)
                    .HasForeignKey(d => d.PGonNo)
                    .HasConstraintName("P_gonNo");
            });

            modelBuilder.Entity<Student>(entity =>
            {
                entity.ToTable("student", "ITRI");

                entity.HasIndex(e => e.AccountId)
                    .HasName("Account_Id_idx");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.AccountId)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.CardNumber).HasColumnType("int(11)");

                entity.Property(e => e.ChineseName)
                    .IsRequired()
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.Class)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.ClassNumber).HasColumnType("int(11)");

                entity.Property(e => e.CreateDate).HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.EnglishName)
                    .IsRequired()
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasDefaultValueSql("\"\"");

                entity.Property(e => e.Gender).HasColumnType("tinyint(4)");

                entity.Property(e => e.GoOutWeekdays).HasColumnType("int(11)");

                entity.Property(e => e.GoOutWeekends).HasColumnType("int(11)");

                entity.Property(e => e.ModifyDate).HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Number)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.OvernightWeekends).HasColumnType("int(11)");

                entity.Property(e => e.Qrcode)
                    .HasColumnName("QRCode")
                    .HasColumnType("mediumblob");

                entity.Property(e => e.Status)
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Year).HasColumnType("int(11)");
            });

            modelBuilder.Entity<Toolcutter>(entity =>
            {
                entity.ToTable("toolcutter", "ITRI");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.CutterBrand)
                    .HasColumnName("cutter_Brand")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.CutterClass)
                    .HasColumnName("cutter_Class")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.CutterEndingTime).HasColumnName("cutter_EndingTime");

                entity.Property(e => e.CutterName)
                    .HasColumnName("cutter_Name")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.CutterNo)
                    .HasColumnName("cutter_No")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CutterSize)
                    .HasColumnName("cutter_Size")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.CutterStatus)
                    .HasColumnName("cutter_Status")
                    .HasColumnType("tinyint(4)");

                entity.Property(e => e.CutterTableCreateDate)
                    .HasColumnName("cutterTableCreateDate")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.CutterTableModifyDate)
                    .HasColumnName("cutterTableModifyDate")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.CutterUsingTime).HasColumnName("cutter_UsingTime");

                entity.Property(e => e.MemberId).HasColumnType("tinyint(4)");

                entity.Property(e => e.OrderId).HasColumnType("tinyint(4)");
            });

            modelBuilder.Entity<Tooljig>(entity =>
            {
                entity.ToTable("tooljig", "ITRI");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.JigBrand)
                    .HasColumnName("Jig_Brand")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.JigClass)
                    .HasColumnName("Jig_Class")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.JigEndingTime).HasColumnName("Jig_EndingTime");

                entity.Property(e => e.JigName)
                    .HasColumnName("Jig_Name")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.JigNo)
                    .HasColumnName("Jig_No")
                    .HasColumnType("int(11)");

                entity.Property(e => e.JigSize)
                    .HasColumnName("Jig_Size")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.JigStatus)
                    .HasColumnName("Jig_Status")
                    .HasColumnType("tinyint(4)");

                entity.Property(e => e.JigTableCreateDate).HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.JigTableModifyDate).HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.JigUse)
                    .HasColumnName("Jig_use")
                    .HasColumnType("tinytext");

                entity.Property(e => e.JigUsingTime).HasColumnName("Jig_UsingTime");

                entity.Property(e => e.MemberId).HasColumnType("tinyint(4)");

                entity.Property(e => e.OrderId).HasColumnType("tinyint(4)");
            });

            modelBuilder.Entity<WorkOrder>(entity =>
            {
                entity.ToTable("work order", "ITRI");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.OrderImage)
                    .IsRequired()
                    .HasColumnName("Order_image")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.OrderMade)
                    .HasColumnName("Order_made")
                    .HasColumnType("tinyint(4)");

                entity.Property(e => e.OrderMethod)
                    .HasColumnName("Order_method")
                    .IsUnicode(false);

                entity.Property(e => e.OrderSchedule)
                    .IsRequired()
                    .HasColumnName("Order_schedule")
                    .IsUnicode(false);
            });
        }
    }
}
