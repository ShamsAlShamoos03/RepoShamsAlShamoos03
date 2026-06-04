
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ShamsAlShamoos03.Shared.Entities;

namespace ShamsAlShamoos03.Infrastructure.Persistence.Contexts
{

    public class ApplicationDbContext : IdentityDbContext<ApplicationUsers, ApplicationRoles, string>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

            Database.SetCommandTimeout(15001100);
        }

        public virtual DbSet<Answer> Answers { get; set; }
        public virtual DbSet<Choice> Choices { get; set; }
        public virtual DbSet<Question02> Questions02 { get; set; }
        public virtual DbSet<Quiz> Quizs { get; set; }
        public virtual DbSet<User02> Users02 { get; set; }


        public DbSet<Question> Questions { get; set; }
        public DbSet<Option> Options { get; set; }

        public DbSet<TblLookupsData> TblLookupsData { get; set; }
        public DbSet<TblLuLookup> TblLuLookup { get; set; }
        public DbSet<TblUnitsInfo> TblUnitsInfo { get; set; }
        public DbSet<CityType> CityType { get; set; }
        public DbSet<TblMaster> TblMaster { get; set; }
        public DbSet<TblHoghog01> TblHoghog01 { get; set; }

        public DbSet<JsTree01> JsTree01 { get; set; }


        public DbSet<Category> Categories_Tbl { get; set; }


        public DbSet<GaurdPost> GaurdPost_Tbl { get; set; }
        public DbSet<PropertyDay> PropertyDay_Tbl { get; set; }

        public DbSet<EvidencelImage> EvidencelImage_Tbl { get; set; }
        public DbSet<EvidencelImageV> EvidencelImageV_Tbl { get; set; }


        public DbSet<CategoryGeneral> CategoriesGeneral_Tbl { get; set; }

        public DbSet<CategoryGeneralSub> CategoryGeneralSub { get; set; }

        public DbSet<CategoryReport> CategoriesReport_Tbl { get; set; }

        public DbSet<News> News_Tbl { get; set; }

        public DbSet<PersonnelVazife01> PersonnelVazife01_Tbl { get; set; }


        public DbSet<Comment> Comments_Tbl { get; set; }
        public DbSet<Advertise> Advertis_Tbl { get; set; }
        public DbSet<Poll> Poll_Tbl { get; set; }
        public DbSet<PollOption> Polloption_Tbl { get; set; }
        public DbSet<VisitorHits> Visit_Tbl { get; set; }
        public DbSet<NewsCategory> NewsCategorys { get; set; }

        public DbSet<BorhanEntesabat02> BorhanEntesabat02 { get; set; }
        public DbSet<BorhanTabaghePezashki02> BorhanTabaghePezashki02 { get; set; }

        public DbSet<ImagesListCategoryImagesList> ImagesListCategoryImagesLists { get; set; }


        public DbSet<GuardboardVPG> Tbl_GuardboardVPGs { get; set; }
        //.OnDelete(DeleteBehavior.Restrict);
        //.OnDelete(DeleteBehavior.Cascade);


        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<StudentCourse> StudentCourses { get; set; }

        public DbSet<CategorySub> CategorySub_Tbl { get; set; }

        public DbSet<UsersCategorySub> UsersCategorySub_Tbl { get; set; }
        public DbSet<UsersCategory> UsersCategory_Tbl { get; set; }
        public DbSet<Sortable01> Sortable01_Tbl { get; set; }
        public DbSet<Sortable03> Sortable03_Tbl { get; set; }

        public DbSet<ImagesList> ImagesList_Tbl { get; set; }
        public DbSet<CategoryImagesList> CategoryImagesList_Tbl { get; set; }
        public DbSet<CategorySubImagesList> CategorySubImagesList_Tbl { get; set; }

        //public DbSet<ImagesListCategoryImagesList> ImagesListCategoryImagesList_Tbl { get; set; }
        public DbSet<CategoryReportSub> CategoryReportSub_Tbl { get; set; }

        public DbSet<NewsImagesList> NewsImagesList_Tbl { get; set; }
        public DbSet<UjobPesronel01> UjobPesronel01_Tbl { get; set; }

        //public DbSet<FlightEvidence01> FlightEvidence01_Tbl { get; set; }
        public DbSet<FlightEvidence01> FlightEvidence01_Tbl { get; set; }

        public DbSet<TblLuLookupSub> TblLuLookupSub_Tbl { get; set; }

        //public DbSet<StandCheck01> StandCheck01_Tbl { get; set; }

        public DbSet<StandCheckWritten01> StandCheckWritten01_Tbl { get; set; }
        public DbSet<HealthEvidence01> HealthEvidence01_Tbl { get; set; }
        public DbSet<NoNoticeEvidence01> NoNoticeEvidence01_Tbl { get; set; }
        public DbSet<EnglishExamEvidence01> EnglishExamEvidence01_Tbl { get; set; }
        public DbSet<AdressEvidence01> AdressEvidence01_Tbl { get; set; }
        public DbSet<HelicopterTailEvidence01> HelicopterTailEvidence01_Tbl { get; set; }
        public DbSet<Daily1352ActivityEvidence01> Daily1352ActivityEvidence01_Tbl { get; set; }
        public DbSet<Daily1352PlanEvidence01> Daily1352PlanEvidence01_Tbl { get; set; }

        public DbSet<Daily1352INSPPlanEvidence01> Daily1352INSPPlanEvidence01_Tbl { get; set; }
        public DbSet<Daily1352INSPNextDuePlanEvidence01> Daily1352INSPNextDuePlanEvidence01_Tbl { get; set; }
        public DbSet<Daily1352INSPListPlanEvidence01> Daily1352INSPListPlanEvidence01_Tbl { get; set; }
        public DbSet<Daily1352PARTPlanEvidence01> Daily1352PARTPlanEvidence01_Tbl { get; set; }
        public DbSet<Daily1352NORSPlanEvidence01> Daily1352NORSPlanEvidence01_Tbl { get; set; }

        public DbSet<WeatherEvidence01> WeatherEvidence01_Tbl { get; set; }
        public DbSet<NOTAMCHECKEvidence01> NOTAMCHECKEvidence01_Tbl { get; set; }
        public DbSet<FlightActivityEvidence01> FlightActivityEvidence01_Tbl { get; set; }
        public DbSet<MeetingDetailsTemplateEvidence01> MeetingDetailsTemplateEvidence01_Tbl { get; set; }
        public DbSet<MeetingConetntEvidence01> MeetingConetntEvidence01_Tbl { get; set; }
        public DbSet<MeetingEvidence01> MeetingEvidence01_Tbl { get; set; }
        public DbSet<MeetingDetailsEvidence01> MeetingDetailsEvidence01_Tbl { get; set; }
        public DbSet<FlightPlanEvidence01> FlightPlanEvidence01_Tbl { get; set; }
        public DbSet<MANEUVERSEvidence01> MANEUVERSEvidence01_Tbl { get; set; }
        public DbSet<CrewFlightPlanEvidence01> CrewFlightPlanEvidence01_Tbl { get; set; }
        public DbSet<MeetingMembersEvidence01> MeetingMembersEvidence01_Tbl { get; set; }
        public DbSet<PhoneEvidence01> PhoneEvidence01_Tbl { get; set; }



        public DbSet<GaurdActivityEvidence01> GaurdActivityEvidence01_Tbl { get; set; }
        public DbSet<GaurdPlanEvidence01> GaurdPlanEvidence01_Tbl { get; set; }
        public DbSet<DailyPlanEvidenceStatAmar01Summary01> DailyPlanEvidenceStatAmar01Summary01_Tbl { get; set; }

        public DbSet<DailyActivityEvidence01> DailyActivityEvidence01_Tbl { get; set; }
        public DbSet<DailyPlanEvidence01> DailyPlanEvidence01_Tbl { get; set; }


        public DbSet<DatePropertyPlanEvidence01> DatePropertyPlanEvidence01_Tbl { get; set; }
        public DbSet<CrewGaurdPlanEvidence01> CrewGaurdPlanEvidence01_Tbl { get; set; }

        public DbSet<DateProperty01> DateProperty01_Tbl { get; set; }
        public DbSet<PersonalCorrespondence01> PersonalCorrespondence01_Tbl { get; set; }
        public DbSet<HistoryEvaluation01> HistoryEvaluation01_Tbl { get; set; }
        public DbSet<HistoryTraficPersonal01> HistoryTraficPersonal01_Tbl { get; set; }
        public DbSet<HistoryRegisterKala01> HistoryRegisterKala01_Tbl { get; set; }
        public DbSet<HistoryReduceWorkPersonal01> HistoryReduceWorkPersonal01_Tbl { get; set; }
        public DbSet<HistoryVazifehDastoorPersonal01> HistoryVazifehDastoorPersonal01_Tbl { get; set; }
        public DbSet<HistoryRokn04jamDastoor01> HistoryRokn04jamDastoor01_Tbl { get; set; }
        public DbSet<HistoryRokn04jamDetailDastoor01> HistoryRokn04jamDetailDastoor01_Tbl { get; set; }

        public DbSet<HistoryRokn04FLYDastoor01> HistoryRokn04FLYDastoor01_Tbl { get; set; }
        public DbSet<HistoryRokn04FLYDetailDastoor01> HistoryRokn04FLYDetailDastoor01_Tbl { get; set; }

        public DbSet<HistoryRokn04FAVADastoor01> HistoryRokn04FAVADastoor01_Tbl { get; set; }
        public DbSet<HistoryRokn04FAVADetailDastoor01> HistoryRokn04FAVADetailDastoor01_Tbl { get; set; }

        public DbSet<HistoryRokn04GRDDastoor01> HistoryRokn04GRDDastoor01_Tbl { get; set; }
        public DbSet<HistoryRokn04GRDDetailDastoor01> HistoryRokn04GRDDetailDastoor01_Tbl { get; set; }

        public DbSet<HistoryRokn04ArrestDastoor01> HistoryRokn04ArrestDastoor01_Tbl { get; set; }
        public DbSet<HistoryRokn04ArrestDetailDastoor01> HistoryRokn04ArrestDetailDastoor01_Tbl { get; set; }

        public DbSet<HistoryRokn04TRNDastoor01> HistoryRokn04TRNDastoor01_Tbl { get; set; }
        public DbSet<HistoryRokn04TRNDetailDastoor01> HistoryRokn04TRNDetailDastoor01_Tbl { get; set; }

        public DbSet<CrewPersonalCorrespondence01> CrewPersonalCorrespondence01_Tbl { get; set; }

        public DbSet<UnitOrganization01> UnitOrganization01_Tbl { get; set; }
        public DbSet<UnitCountAmar01> UnitCountAmar01_Tbl { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            //builder.UseLazyLoadingProxies();
            //    builder.Entity<TblMaster>().HasOne<CategoryGeneral>(p => p.UitID01).WithMany(b => b.CategoryGeneralId)
            //.OnDelete(DeleteBehavior.Restrict);

            builder.Entity<UnitCountAmar01>(entity =>
            {
                // سایر کانفیگ‌ها...

                entity.Property(e => e.averold)
                    .HasComputedColumnSql(
                        "CASE " +
                        "WHEN [CountEdeKol] IS NULL OR [CountEdeKol] = '0' THEN '0' " +
                        "ELSE CAST(CAST(ISNULL([sumold],'0') AS DECIMAL(18,2)) / CAST([CountEdeKol] AS DECIMAL(18,2)) AS NVARCHAR(50)) " +
                        "END",
                        stored: true);
            });



            builder.Entity<DailyActivityEvidence01>()
    .HasIndex(e => e.DailyActivityEvidence01IDStateName01)
    .IsUnique();

            builder.Entity<PersonalCorrespondence01>()
    .HasIndex(e => e.DocumentNO01)
    .IsUnique();


            builder.Entity<CrewPersonalCorrespondence01>()
    .HasIndex(e => e.DocumentNO01)
    .IsUnique();

            builder.Entity<Quiz>()
    .HasMany(q => q.Questions02)
    .WithOne(q => q.Quiz)
    .HasForeignKey(q => q.QuizId);

            builder.Entity<Question02>()
                .HasMany(q => q.Choices)
                .WithOne(q => q.Question02)
                .HasForeignKey(q => q.QuestionId);

            builder.Entity<Answer>()
                .HasOne(a => a.Question02)
                .WithMany(q => q.Answers)
                .HasForeignKey(a => a.QuestionId);
            //    builder.Entity<PersonnelVazife01>().HasOne<CategoryGeneral>(p => p.RankID).WithMany(b => b.CategoryGeneralSubId)
            //.OnDelete(DeleteBehavior.Restrict);

            //One to One
            //modelBuilder.Entity<Biography>().HasOne(a => a.Author).WithOne().HasForeignKey<Biography>(v => v.FK_AuthorId)
            //    .HasConstraintName("B_A_Key").IsRequired(false);

            //One to One
            //builder.Entity<TblMaster>().HasOne(a => a.BRT_COD).WithOne().HasForeignKey<TblMaster>(v => v._BRT_COD);
            //builder.Entity<TblMaster>().HasOne(a => a._BRT_COD).WithOne().HasForeignKey<TblMaster>(v => v.BRT_COD);

            //     builder.HasSequence<int>("MySimpleSequence")
            //.StartsAt(1)
            //.IncrementsBy(1);
            //     builder.HasSequence<int>("MySimpleSequence")
            //.StartsAt(1)
            //.IncrementsBy(1);
            //     builder.Entity<MyEntity>()
            //         .Property(e => e.SequenceNumber)
            //         .HasDefaultValueSql("NEXTVAL('MySimpleSequence')");
            //builder.HasSequence<int>("FactorNumber", schema: "Fdbo").StartsAt(1).IncrementsBy(1).HasMax(5);
            //builder.Entity<FlightPlanEvidence01>().Property(a => a.FactorNumber).HasDefaultValueSql("Next Value For Fdbo.FactorNumber");


            //.Property(l => l.FactorNumber).ForSqlServerUseSequenceHiLo("Fdbo.FactorNumber").IsRequired()
            //.Property(a => a.FactorNumber).HasDefaultValueSql("Next Value For Fdbo.FactorNumber");
            //builder.HasSequence<int>("MySimpleSequence" )

            //  .StartsAt(1)
            // .IncrementsBy(1)
            // .HasMin(1)
            // .HasMax(1000)
            // .IsCyclic()

            //  ;

            //builder.HasSequence<int>("Number").StartsAt(1).IncrementsBy(1).IsCyclic(false); ;

            //builder.Entity<MyEntity>().Property(x => x.Code).HasDefaultValueSql("NEXT VALUE FOR Number");


            //builder.Entity<FlightPlanEvidence01>(entity =>
            //{
            //    entity.Property(e => e.SerialNOPlan)
            //              //.HasDefaultValueSql("CONCAT('FromDateFlightPlanEvidence01Title', MySimpleSequence))");
            //              .HasDefaultValueSql("CONCAT('FromDateFlightPlanEvidence01Title-', FORMAT((NEXT VALUE FOR MySimpleSequence), '0000'))");
            //});


            // builder.Entity<FlightPlanEvidence01>(entity =>
            //{
            //    entity.Property(x => x.SerialNOPlan)
            //    entity.u


            //    //      entity.UseIdentityColumn(seed: 1, increment: 1)
            //    // entity.HasColumnName("Id")
            //    //entity.HasColumnType("int")
            //    // entity.IsRequired()
            //    ;
            //});

            //builder.Entity<FlightPlanEvidence01>(entity =>
            //{
            //    entity.Property(e => e.SerialNOPlan)
            //              .HasDefaultValueSql("CONCAT('FromDateFlightPlanEvidence01Title-',IDENTITY ))");
            //});
            var hasher = new PasswordHasher<ApplicationUsers>();

            builder.Entity<ApplicationUsers>()
                .Property(p => p.BirthDayDate)
                .HasDefaultValueSql("GETDATE()");

            builder.Entity<ApplicationUsers>()
                .Property(p => p.LastPasswordChangeDate)
                .HasDefaultValueSql("GETDATE()");


            builder.Entity<ApplicationUsers>(entity =>
            {
                entity.ToTable(name: "Users_Tbl");
                entity.Property(e => e.Id).HasColumnName("UserID");
                entity.Property(e => e.Id).ValueGeneratedOnAdd();
                entity.HasData(new ApplicationUsers
                {
                    UserName = "lb123456",
                    Id = "3300697e-daa9-42c0-b3fa-99c8dfc080c3",
                    //PasswordHash = hasher.HashPassword(null, "lb123456"), // هش کردن رمز عبور
                    PasswordHash = "AQAAAAIAAYagAAAAEDr2e8Jbo6sutkQJI6SCwuQ2nGko2CD4AchCPyr6lNf6bdIY/LlC9TevOqbd16O2xg==",
                    FirstName = "مدیر",
                    LastName = "سامانه شریف",
                    Melicode = "",
                    gender = 1,
                    PhoneNumber = "",
                    ImagePath = "",
                    IsActive = 1,
                    NormalizedUserName = "LB123456",
                    Email = "lb123456@lb123456.com",
                    NormalizedEmail = "LB123456@LB123456.COM",
                    EmailConfirmed = false,
                    SecurityStamp = "BFABUDNKBSPZR6OQOY5GSUGP4BI6YSX5",
                    ConcurrencyStamp = "8a56bb0c-5f2e-4953-b6bb-5cb812d0dba0",
                    PhoneNumberConfirmed = false,
                    TwoFactorEnabled = false,
                    LockoutEnd = null,
                    LockoutEnabled = true,
                    AccessFailedCount = 0,
                    PersonalCode = "",
                    TextRequest = "",
                    FName = "",
                    LName = "",
                    Personelcodes = "",
                    Rate = "",
                    JobsLevel = "",

                });
            });


            //        modelBuilder.Entity<Article>().HasData(
            //new Article { Id = 1, Name = "Article1", JournalName = "JournalName1" },

            builder.Entity<ApplicationRoles>(entity =>
            {
                entity.ToTable(name: "Roles_Tbl");
                entity.HasKey(e => e.Id);

                // تنظیم Seed Data
                entity.HasData(
                    new ApplicationRoles
                    {
                        Id = "17addaba-dd6c-4c46-9993-559edf295ac8",
                        RoleLevel = "22daafff-159d-482e-92c0-72ba9d455677",
                        Description = "کاربر عادی",
                        Name = "NORMALUSER",
                        NormalizedName = "NORMALUSER",
                        ConcurrencyStamp = "20572dd0-966c-42d9-a95c-f64b2abd1016"
                    },
                    new ApplicationRoles
                    {
                        Id = "189ed4ed-3ac3-4b20-b8c3-3b32769cf976",
                        RoleLevel = "22daafff-159d-482e-92c0-72ba9d455677",
                        Description = "تفویض اختیار محلی",
                        Name = "TafvizEkhtiar01",
                        NormalizedName = "TAFVIZEKHTIAR01",
                        ConcurrencyStamp = null
                    },
                    new ApplicationRoles
                    {
                        Id = "1a18cdbc-8197-49c0-92a6-747dbcb34350",
                        RoleLevel = "22daafff-159d-482e-92c0-72ba9d455677",
                        Description = "افزودن کاربران",
                        Name = "AddUser",
                        NormalizedName = "ADDUSER",
                        ConcurrencyStamp = "5e66b7a3-65ae-41ae-80a7-0051c9f87945"
                    },
                    new ApplicationRoles
                    {
                        Id = "22daafff-159d-482e-92c0-72ba9d455677",
                        RoleLevel = "abc",
                        Description = "مدیریت کاربران",
                        Name = "User",
                        NormalizedName = "USER",
                        ConcurrencyStamp = "ce40097b-8e87-4c62-8081-8f23d7b0d334"
                    },
                    new ApplicationRoles
                    {
                        Id = "e414e2cc-2b05-454a-9a07-60da4d929e6c",
                        RoleLevel = "22daafff-159d-482e-92c0-72ba9d455677",
                        Description = "مدیر کاربر سطح 1",
                        Name = "MANAGEUSER01",
                        NormalizedName = "MANAGEUSER01",
                        ConcurrencyStamp = "355f684a-3146-444c-b5cb-ff0f019bd61e"
                    },


                #region "مدیریت کارکنان"




                    new ApplicationRoles
                    {
                        Id = "90579366-628e-477f-ac9a-4a7471a9986e",
                        RoleLevel = "abc",
                        Description = "مدیریت کارکنان",
                        Name = "Personnel01",
                        NormalizedName = "PERSONNEL01",
                        ConcurrencyStamp = "e13fd7a2-e0ad-4597-9273-3327ef8c1776"
                    },
                    new ApplicationRoles
                    {
                        Id = "351d15d8-a914-41da-b3da-3e72edc82272",
                        RoleLevel = "90579366-628e-477f-ac9a-4a7471a9986e",
                        Description = "مدیریت کارکنان پایور",
                        Name = "MANAGEPERSONNELPAYOR",
                        NormalizedName = "MANAGEPERSONNELPAYOR",
                        ConcurrencyStamp = null
                    },


                    new ApplicationRoles
                    {
                        Id = "27162af1-d67a-49af-b8d2-766a2d4467ec",
                        RoleLevel = "351d15d8-a914-41da-b3da-3e72edc82272",
                        Description = "افزودن فایل کارکنان پایور",
                        Name = "ADDFIEPERSONNELPAYOR",
                        NormalizedName = "ADDFIEPERSONNELPAYOR",
                        ConcurrencyStamp = null
                    },

                    new ApplicationRoles
                    {
                        Id = "998d0d7f-18e5-4cf0-8152-e6ccf1822502",
                        RoleLevel = "351d15d8-a914-41da-b3da-3e72edc82272",
                        Description = "افزودن فایل دو خطی حقوقی",
                        Name = "AddFileAccessHoghoghi01",
                        NormalizedName = "ADDFILEACCESSHOGHOGHI01",
                        ConcurrencyStamp = null
                    },

                    new ApplicationRoles
                    {
                        Id = "ed4a4f49-9ba5-4871-a366-ddd049006ab3",
                        RoleLevel = "351d15d8-a914-41da-b3da-3e72edc82272",
                        Description = "مشاهده کارکنان پایور",
                        Name = "VIEWPERSONNELPAYOR",
                        NormalizedName = "VIEWPERSONNELPAYOR",
                        ConcurrencyStamp = null
                    },


                    new ApplicationRoles
                    {
                        Id = "23a68401-f865-4e1e-87a6-9bdfe2f1c773",
                        RoleLevel = "ed4a4f49-9ba5-4871-a366-ddd049006ab3",
                        Description = "مشاهده کارکنان پایور سطح 2",
                        Name = "VIEWPERSONNELPAYOR02",
                        NormalizedName = "VIEWPERSONNELPAYOR02",
                        ConcurrencyStamp = null
                    },

                    new ApplicationRoles
                    {
                        Id = "9dec9ab3-95fa-478b-b0a4-4966b736ce97",
                        RoleLevel = "ed4a4f49-9ba5-4871-a366-ddd049006ab3",
                        Description = "مشاهده کارکنان پایور سطح 3",
                        Name = "VIEWPERSONNELPAYOR03",
                        NormalizedName = "VIEWPERSONNELPAYOR03",
                        ConcurrencyStamp = null
                    },

                    new ApplicationRoles
                    {
                        Id = "f23d8fb0-f077-44c7-a503-635845ab0fb1",
                        RoleLevel = "ed4a4f49-9ba5-4871-a366-ddd049006ab3",
                        Description = "مشاهده کارکنان پایور سطح 1",
                        Name = "VIEWPERSONNELPAYOR01",
                        NormalizedName = "VIEWPERSONNELPAYOR01",
                        ConcurrencyStamp = null
                    },






                    new ApplicationRoles
                    {
                        Id = "c993f1cb-7a97-424c-9e0f-554d402d2b92",
                        RoleLevel = "90579366-628e-477f-ac9a-4a7471a9986e",
                        Description = "مدیریت کارکنان یگان",
                        Name = "MANAGEPERSONNELYEGAN",
                        NormalizedName = "MANAGEPERSONNELYEGAN",
                        ConcurrencyStamp = null
                    },
                    new ApplicationRoles
                    {
                        Id = "d04ecc99-749b-4bbe-baba-d123004d2ca5",
                        RoleLevel = "90579366-628e-477f-ac9a-4a7471a9986e",
                        Description = "مدیریت کارکنان وظیفه",
                        Name = "MANAGEPERSONNELVAZIFEH",
                        NormalizedName = "MANAGEPERSONNELVAZIFEH",
                        ConcurrencyStamp = null
                    },
                    new ApplicationRoles
                    {
                        Id = "e801f9db-7663-42c5-a6ca-0ee7bcb6807b",
                        RoleLevel = "90579366-628e-477f-ac9a-4a7471a9986e",
                        Description = "مدیریت کارکنان پایور و وظیفه",
                        Name = "MANAGEPERSONNELPAYORVAZIFEH",
                        NormalizedName = "MANAGEPERSONNELPAYORVAZIFEH",
                        ConcurrencyStamp = null
                    },
                    new ApplicationRoles
                    {
                        Id = "efa7d0e0-b4b8-489c-a52a-4182e2f3b3b7",
                        RoleLevel = "90579366-628e-477f-ac9a-4a7471a9986e",
                        Description = "مدیریت کارکنان سطح 1",
                        Name = "Personnel02",
                        NormalizedName = "PERSONNEL02",
                        ConcurrencyStamp = null
                    }
                    #endregion

                );
            });



            // Seed Data برای AspNetUserRoles
            builder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>
                {
                    UserId = "3300697e-daa9-42c0-b3fa-99c8dfc080c3", // مقدار UserId
                    RoleId = "efa7d0e0-b4b8-489c-a52a-4182e2f3b3b7"                  // مقدار RoleId
                },
                new IdentityUserRole<string>
                {
                    UserId = "3300697e-daa9-42c0-b3fa-99c8dfc080c3", // مقدار UserId
                    RoleId = "1a18cdbc-8197-49c0-92a6-747dbcb34350"                  // مقدار RoleId
                },
                new IdentityUserRole<string>
                {
                    UserId = "3300697e-daa9-42c0-b3fa-99c8dfc080c3", // مقدار UserId
                    RoleId = "27162af1-d67a-49af-b8d2-766a2d4467ec"                  // مقدار RoleId
                },
                new IdentityUserRole<string>
                {
                    UserId = "3300697e-daa9-42c0-b3fa-99c8dfc080c3", // مقدار UserId
                    RoleId = "f23d8fb0-f077-44c7-a503-635845ab0fb1"                  // مقدار RoleId
                },

                new IdentityUserRole<string>
                {
                    UserId = "3300697e-daa9-42c0-b3fa-99c8dfc080c3", // مقدار UserId
                    RoleId = "e414e2cc-2b05-454a-9a07-60da4d929e6c"                  // مقدار RoleId
                }
            );

            //            builder.Entity<TblLuLookup>()
            //       .HasKey(e => new { e.Id, e.Type });

            //            builder.Entity<TblLookupsData>()
            //.HasKey(e => new { e.Id, e.Type });


            //    builder.Entity<TblLuLookup>()
            //.HasKey(nameof(TblLuLookup.Id), nameof(Actor.LastName), nameof(Actor.BirthDate));



            builder.Entity<NewsCategory>().HasKey(sc => new { sc.NewsId, sc.CategoryID });
            builder.Entity<NewsCategory>()
                .HasOne<News>(sc => sc.News)
                .WithMany(s => s.NewsCategorys)
                .HasForeignKey(sc => sc.NewsId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<NewsCategory>()
                .HasOne<Category>(sc => sc.Category)
                .WithMany(s => s.NewsCategorys)
                .HasForeignKey(sc => sc.CategoryID)
                .OnDelete(DeleteBehavior.Restrict);


            builder.Entity<StandCheckWritten01>()
                .HasOne(s => s.ooMelliCodeList_3)
        .WithMany()
        .HasForeignKey(s => s.MelliCode)
        .IsRequired(false); // Make the relationship optional

            builder.Entity<StandCheckWritten01>()
    .HasOne(s => s.ooMelliCodeList_4)
.WithMany()
.HasForeignKey(s => s.MelliCodeExamer)
.IsRequired(false); // Make the relationship optional

            builder.Entity<StandCheckWritten01>()
         .HasOne(s => s.ooMelliCodeInstructor)
 .WithMany()
 .HasForeignKey(s => s.MelliCodeInstructor)
 .IsRequired(false); // Make the relationship optional


            //.OnDelete(DeleteBehavior.Cascade);

            //            مشکل شما Multiple cascade paths هست. به این معنی که یک اگر یک ردیف از جدول Provience حذف بشه همه ی ردیف های مرتبط با اون در جدول Candidator حذف میشه.

            //شما می تونید با استفاده از کد زیر این مشکل رو حل کنید:
            //            builder.Entity<Candidator>().HasOne(p => p.provienceID).WithMany(b => b.ProvienceID)
            //        .OnDelete(DeleteBehavior.Restrict);


            //      builder.Entity<NewsCategory>().HasOne(p => p.provienceID).WithMany(b => b.ProvienceID)
            //.OnDelete(DeleteBehavior.Restrict);
            //.OnDelete(DeleteBehavior.Cascade);

            //base.OnModelCreating(modelBuilder);

            //برای مقدار پیش فرض تنیظمات باید انجام شود
            builder.Entity<FlightPlanEvidence01>()
                .Property(b => b.PlusDateTime)
                .HasDefaultValue(new DateTime(2024, 6, 1, 0, 0, 0));
            builder.Entity<FlightPlanEvidence01>()
                .Property(b => b.PlusTimeSpan)
                .HasDefaultValue(new string("00:00"));

            builder.Entity<FlightPlanEvidence01>()
                .Property(b => b.Sorties01)
                .HasDefaultValue(new string("0"));

            builder.Entity<FlightPlanEvidence01>()
                .Property(b => b.NOPassengers01)
                .HasDefaultValue(new string("0"));

            builder.Entity<FlightPlanEvidence01>()
                .Property(b => b.NOInjured01)
                .HasDefaultValue(new string("0"));

            builder.Entity<FlightPlanEvidence01>()
                .Property(b => b.QTCargo01)
                .HasDefaultValue(new string("0"));

            builder.Entity<FlightPlanEvidence01>()
                .Property(b => b.QT20MM01)
                .HasDefaultValue(new string("0"));


            builder.Entity<FlightPlanEvidence01>()
    .Property(b => b.QTRocket01)
    .HasDefaultValue(new string("0"));


            builder.Entity<FlightPlanEvidence01>()
    .Property(b => b.QTFuel01)
    .HasDefaultValue(new string("0"));




            //برای مقدار پیش فرض تنیظمات باید انجام شود

            //برای مقدار پیش فرض تنیظمات باید انجام شود
            builder.Entity<TblMaster>()
                .Property(b => b.DRJ_COD)
                .HasDefaultValue(new string("100"));

            builder.Entity<TblMaster>()
                .Property(b => b.UitID01)
                .HasDefaultValue(123);




            //برای مقدار پیش فرض تنیظمات باید انجام شود


            //برای مقدار پیش فرض تنیظمات باید انجام شود
            builder.Entity<TblMaster>()
                .Property(b => b.DRJ_COD)
                .HasDefaultValue(new string("100"));
            //برای مقدار پیش فرض تنیظمات باید انجام شود



            builder.Entity<StudentCourse>().HasKey(sc => new { sc.StudentId, sc.CourseId });

            builder.Entity<StudentCourse>()
           .HasOne<Student>(sc => sc.Student)
                   .WithMany(s => s.StudentCourses)
                .HasForeignKey(sc => sc.StudentId);


            builder.Entity<StudentCourse>()
                .HasOne<Course>(sc => sc.Course)
                .WithMany(s => s.StudentCourses)
                .HasForeignKey(sc => sc.CourseId);




            builder.Entity<UsersCategorySub>().HasKey(sc => new { sc.CategrySubId, sc.UserID });

            builder.Entity<UsersCategorySub>()
           .HasOne<CategorySub>(sc => sc.CategorySub)
                   .WithMany(s => s.UsersCategorySubs)
                .HasForeignKey(sc => sc.CategrySubId);


            builder.Entity<UsersCategorySub>()
                .HasOne<ApplicationUsers>(sc => sc.ApplicationUsers)
                .WithMany(s => s.UsersCategorySubs)
                .HasForeignKey(sc => sc.UserID);




            //UsersCategory
            builder.Entity<UsersCategory>().HasKey(sc => new { sc.CategryId, sc.UserID });

            builder.Entity<UsersCategory>()
           .HasOne<Category>(sc => sc.Category)
                   .WithMany(s => s.UsersCategorys)
                .HasForeignKey(sc => sc.CategryId);


            builder.Entity<UsersCategory>()
                .HasOne<ApplicationUsers>(sc => sc.ApplicationUsers)
                .WithMany(s => s.UsersCategorys)
                .HasForeignKey(sc => sc.UserID);
            //UsersCategory


            //NewsImagesList
            builder.Entity<NewsImagesList>().HasKey(sc => new { sc.NewsImagesID });

            builder.Entity<NewsImagesList>()
           .HasOne<News>(sc => sc.News)
                   .WithMany(s => s.NewsImagesLists)
                .HasForeignKey(sc => sc.NewsId);


            builder.Entity<NewsImagesList>()
                .HasOne<ImagesList>(sc => sc.ImagesList)
                .WithMany(s => s.NewsImagesLists)
                .HasForeignKey(sc => sc.ImagesListId);
            //NewsImagesList


            //UjobPesronel01
            builder.Entity<UjobPesronel01>().HasKey(sc => new
            {
                sc.UjobPesronel01ID
            });

            builder.Entity<UjobPesronel01>()
           .HasOne<ApplicationUsers>(sc => sc.Users)
                   .WithMany(s => s.UjobPesronel01s)
                .HasForeignKey(sc => sc.UserID);


            builder.Entity<UjobPesronel01>()
                        .HasOne<TblMaster>(sc => sc.MelliCodeList)
                        .WithMany(s => s.UjobPesronel01s)
                        .HasForeignKey(sc => sc.MelliCode);
            //UjobPesronel01




            // //ImagesListCategoryImagesList
            builder.Entity<ImagesListCategoryImagesList>().HasKey(sc => new { sc.ImagesListId, sc.CategoryImagesId });

            builder.Entity<ImagesListCategoryImagesList>()
           .HasOne<ImagesList>(sc => sc.ImagesList)
                   .WithMany(s => s.ImagesListCategoryImagesLists)
                .HasForeignKey(sc => sc.ImagesListId)
                .OnDelete(DeleteBehavior.Restrict);


            builder.Entity<ImagesListCategoryImagesList>()
                .HasOne<CategoryImagesList>(sc => sc.CategoryImagesList)
                .WithMany(s => s.ImagesListCategoryImagesLists)
                .HasForeignKey(sc => sc.CategoryImagesId)
                .OnDelete(DeleteBehavior.Restrict);





            //.OnDelete(DeleteBehavior.Restrict);
            //.OnDelete(DeleteBehavior.Cascade);

            //builder.Entity<GuardboardVPG>().HasKey(sc => new { sc.GuardboardVPGID, sc.PropertyDayID, sc.GaurdPostID, sc.VazifeID });

            builder.Entity<GuardboardVPG>().HasKey(sc => new { sc.GuardboardVPGID });


            builder.Entity<GuardboardVPG>()
           .HasOne<PropertyDay>(sc => sc.TBL_date)
                   .WithMany(s => s.TBL_GuardboardVPG)
                .HasForeignKey(sc => sc.PropertyDayID);

            builder.Entity<GuardboardVPG>()
                 .HasOne<GaurdPost>(sc => sc.TBL_GaurdPost)
                         .WithMany(s => s.TBL_GuardboardVPG)
                      .HasForeignKey(sc => sc.GaurdPostID);

            builder.Entity<GuardboardVPG>()
             .HasOne<PersonnelVazife01>(sc => sc.TBL_Vazife)
                     .WithMany(s => s.TBL_GuardboardVPG)
                  .HasForeignKey(sc => sc.VazifeID);

















            // //ImagesListCategoryImagesList

            //builder.Entity<NewsCategory>().HasKey(sc => new { sc.NewsId, sc.CategoryID });
            //builder.Entity<NewsCategory>()
            //    .HasOne<News>(sc => sc.News)
            //    .WithMany(s => s.NewsCategorys)
            //    .HasForeignKey(sc => sc.NewsId)
            //    .OnDelete(DeleteBehavior.Restrict);

            //builder.Entity<NewsCategory>()
            //    .HasOne<Category>(sc => sc.Category)
            //    .WithMany(s => s.NewsCategorys)
            //    .HasForeignKey(sc => sc.CategoryID)
            //    .OnDelete(DeleteBehavior.Restrict);


        }
    }
}
