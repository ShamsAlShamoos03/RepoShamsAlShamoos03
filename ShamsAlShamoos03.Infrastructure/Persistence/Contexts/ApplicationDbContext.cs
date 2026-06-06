using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ShamsAlShamoos03.Shared.Entities;

namespace ShamsAlShamoos03.Infrastructure.Persistence.Contexts
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUsers, ApplicationRoles, string>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
        }
     
        #region "DbSets"
        public DbSet<Answer> Answers { get; set; } = null!;
        public DbSet<Choice> Choices { get; set; } = null!;
        public DbSet<Question02> Questions02 { get; set; } = null!;
        public DbSet<Quiz> Quizs { get; set; } = null!;
        public DbSet<User02> Users02 { get; set; } = null!;
        public DbSet<Question> Questions { get; set; } = null!;
        public DbSet<Option> Options { get; set; } = null!;
        public DbSet<TblLookupsData> TblLookupsData { get; set; } = null!;
        public DbSet<TblLuLookup> TblLuLookup { get; set; } = null!;
        public DbSet<TblUnitsInfo> TblUnitsInfo { get; set; } = null!;
        public DbSet<CityType> CityType { get; set; } = null!;
        public DbSet<TblMaster> TblMaster { get; set; } = null!;
        public DbSet<TblHoghog01> TblHoghog01 { get; set; } = null!;
        public DbSet<JsTree01> JsTree01 { get; set; } = null!;
        public DbSet<Category> Categories_Tbl { get; set; } = null!;
        public DbSet<GaurdPost> GaurdPost_Tbl { get; set; } = null!;
        public DbSet<PropertyDay> PropertyDay_Tbl { get; set; } = null!;
        public DbSet<EvidencelImage> EvidencelImage_Tbl { get; set; } = null!;
        public DbSet<EvidencelImageV> EvidencelImageV_Tbl { get; set; } = null!;
        public DbSet<CategoryGeneral> CategoriesGeneral_Tbl { get; set; } = null!;
        public DbSet<CategoryGeneralSub> CategoryGeneralSub { get; set; } = null!;
        public DbSet<CategoryReport> CategoriesReport_Tbl { get; set; } = null!;
        public DbSet<News> News_Tbl { get; set; } = null!;
        public DbSet<PersonnelVazife01> PersonnelVazife01_Tbl { get; set; } = null!;
        public DbSet<Comment> Comments_Tbl { get; set; } = null!;
        public DbSet<Advertise> Advertis_Tbl { get; set; } = null!;
        public DbSet<Poll> Poll_Tbl { get; set; } = null!;
        public DbSet<PollOption> Polloption_Tbl { get; set; } = null!;
        public DbSet<VisitorHits> Visit_Tbl { get; set; } = null!;
        public DbSet<NewsCategory> NewsCategorys { get; set; } = null!;
        public DbSet<BorhanEntesabat02> BorhanEntesabat02 { get; set; } = null!;
        public DbSet<BorhanTabaghePezashki02> BorhanTabaghePezashki02 { get; set; } = null!;
        public DbSet<ImagesListCategoryImagesList> ImagesListCategoryImagesLists { get; set; } = null!;
        public DbSet<GuardboardVPG> Tbl_GuardboardVPGs { get; set; } = null!;
        public DbSet<Student> Students { get; set; } = null!;
        public DbSet<Course> Courses { get; set; } = null!;
        public DbSet<StudentCourse> StudentCourses { get; set; } = null!;
        public DbSet<CategorySub> CategorySub_Tbl { get; set; } = null!;
        public DbSet<UsersCategorySub> UsersCategorySub_Tbl { get; set; } = null!;
        public DbSet<UsersCategory> UsersCategory_Tbl { get; set; } = null!;
        public DbSet<Sortable01> Sortable01_Tbl { get; set; } = null!;
        public DbSet<Sortable03> Sortable03_Tbl { get; set; } = null!;
        public DbSet<ImagesList> ImagesList_Tbl { get; set; } = null!;
        public DbSet<CategoryImagesList> CategoryImagesList_Tbl { get; set; } = null!;
        public DbSet<CategorySubImagesList> CategorySubImagesList_Tbl { get; set; } = null!;
        public DbSet<CategoryReportSub> CategoryReportSub_Tbl { get; set; } = null!;
        public DbSet<NewsImagesList> NewsImagesList_Tbl { get; set; } = null!;
        public DbSet<UjobPesronel01> UjobPesronel01_Tbl { get; set; } = null!;
        public DbSet<FlightEvidence01> FlightEvidence01_Tbl { get; set; } = null!;
        public DbSet<TblLuLookupSub> TblLuLookupSub_Tbl { get; set; } = null!;
        public DbSet<StandCheckWritten01> StandCheckWritten01_Tbl { get; set; } = null!;
        public DbSet<HealthEvidence01> HealthEvidence01_Tbl { get; set; } = null!;
        public DbSet<NoNoticeEvidence01> NoNoticeEvidence01_Tbl { get; set; } = null!;
        public DbSet<EnglishExamEvidence01> EnglishExamEvidence01_Tbl { get; set; } = null!;
        public DbSet<AdressEvidence01> AdressEvidence01_Tbl { get; set; } = null!;
        public DbSet<HelicopterTailEvidence01> HelicopterTailEvidence01_Tbl { get; set; } = null!;
        public DbSet<Daily1352ActivityEvidence01> Daily1352ActivityEvidence01_Tbl { get; set; } = null!;
        public DbSet<Daily1352PlanEvidence01> Daily1352PlanEvidence01_Tbl { get; set; } = null!;
        public DbSet<Daily1352INSPPlanEvidence01> Daily1352INSPPlanEvidence01_Tbl { get; set; } = null!;
        public DbSet<Daily1352INSPNextDuePlanEvidence01> Daily1352INSPNextDuePlanEvidence01_Tbl { get; set; } = null!;
        public DbSet<Daily1352INSPListPlanEvidence01> Daily1352INSPListPlanEvidence01_Tbl { get; set; } = null!;
        public DbSet<Daily1352PARTPlanEvidence01> Daily1352PARTPlanEvidence01_Tbl { get; set; } = null!;
        public DbSet<Daily1352NORSPlanEvidence01> Daily1352NORSPlanEvidence01_Tbl { get; set; } = null!;
        public DbSet<WeatherEvidence01> WeatherEvidence01_Tbl { get; set; } = null!;
        public DbSet<NOTAMCHECKEvidence01> NOTAMCHECKEvidence01_Tbl { get; set; } = null!;
        public DbSet<FlightActivityEvidence01> FlightActivityEvidence01_Tbl { get; set; } = null!;
        public DbSet<MeetingDetailsTemplateEvidence01> MeetingDetailsTemplateEvidence01_Tbl { get; set; } = null!;
        public DbSet<MeetingConetntEvidence01> MeetingConetntEvidence01_Tbl { get; set; } = null!;
        public DbSet<MeetingEvidence01> MeetingEvidence01_Tbl { get; set; } = null!;
        public DbSet<MeetingDetailsEvidence01> MeetingDetailsEvidence01_Tbl { get; set; } = null!;
        public DbSet<FlightPlanEvidence01> FlightPlanEvidence01_Tbl { get; set; } = null!;
        public DbSet<MANEUVERSEvidence01> MANEUVERSEvidence01_Tbl { get; set; } = null!;
        public DbSet<CrewFlightPlanEvidence01> CrewFlightPlanEvidence01_Tbl { get; set; } = null!;
        public DbSet<MeetingMembersEvidence01> MeetingMembersEvidence01_Tbl { get; set; } = null!;
        public DbSet<PhoneEvidence01> PhoneEvidence01_Tbl { get; set; } = null!;
        public DbSet<GaurdActivityEvidence01> GaurdActivityEvidence01_Tbl { get; set; } = null!;
        public DbSet<GaurdPlanEvidence01> GaurdPlanEvidence01_Tbl { get; set; } = null!;
        public DbSet<DailyPlanEvidenceStatAmar01Summary01> DailyPlanEvidenceStatAmar01Summary01_Tbl { get; set; } = null!;
        public DbSet<DailyActivityEvidence01> DailyActivityEvidence01_Tbl { get; set; } = null!;
        public DbSet<DailyPlanEvidence01> DailyPlanEvidence01_Tbl { get; set; } = null!;
        public DbSet<DatePropertyPlanEvidence01> DatePropertyPlanEvidence01_Tbl { get; set; } = null!;
        public DbSet<CrewGaurdPlanEvidence01> CrewGaurdPlanEvidence01_Tbl { get; set; } = null!;
        public DbSet<DateProperty01> DateProperty01_Tbl { get; set; } = null!;
        public DbSet<PersonalCorrespondence01> PersonalCorrespondence01_Tbl { get; set; } = null!;
        public DbSet<HistoryEvaluation01> HistoryEvaluation01_Tbl { get; set; } = null!;
        public DbSet<HistoryTraficPersonal01> HistoryTraficPersonal01_Tbl { get; set; } = null!;
        public DbSet<HistoryRegisterKala01> HistoryRegisterKala01_Tbl { get; set; } = null!;
        public DbSet<HistoryReduceWorkPersonal01> HistoryReduceWorkPersonal01_Tbl { get; set; } = null!;
        public DbSet<HistoryVazifehDastoorPersonal01> HistoryVazifehDastoorPersonal01_Tbl { get; set; } = null!;
        public DbSet<HistoryRokn04jamDastoor01> HistoryRokn04jamDastoor01_Tbl { get; set; } = null!;
        public DbSet<HistoryRokn04jamDetailDastoor01> HistoryRokn04jamDetailDastoor01_Tbl { get; set; } = null!;
        public DbSet<HistoryRokn04FLYDastoor01> HistoryRokn04FLYDastoor01_Tbl { get; set; } = null!;
        public DbSet<HistoryRokn04FLYDetailDastoor01> HistoryRokn04FLYDetailDastoor01_Tbl { get; set; } = null!;
        public DbSet<HistoryRokn04FAVADastoor01> HistoryRokn04FAVADastoor01_Tbl { get; set; } = null!;
        public DbSet<HistoryRokn04FAVADetailDastoor01> HistoryRokn04FAVADetailDastoor01_Tbl { get; set; } = null!;
        public DbSet<HistoryRokn04GRDDastoor01> HistoryRokn04GRDDastoor01_Tbl { get; set; } = null!;
        public DbSet<HistoryRokn04GRDDetailDastoor01> HistoryRokn04GRDDetailDastoor01_Tbl { get; set; } = null!;
        public DbSet<HistoryRokn04ArrestDastoor01> HistoryRokn04ArrestDastoor01_Tbl { get; set; } = null!;
        public DbSet<HistoryRokn04ArrestDetailDastoor01> HistoryRokn04ArrestDetailDastoor01_Tbl { get; set; } = null!;
        public DbSet<HistoryRokn04TRNDastoor01> HistoryRokn04TRNDastoor01_Tbl { get; set; } = null!;
        public DbSet<HistoryRokn04TRNDetailDastoor01> HistoryRokn04TRNDetailDastoor01_Tbl { get; set; } = null!;
        public DbSet<CrewPersonalCorrespondence01> CrewPersonalCorrespondence01_Tbl { get; set; } = null!;
        public DbSet<UnitOrganization01> UnitOrganization01_Tbl { get; set; } = null!;
        public DbSet<UnitCountAmar01> UnitCountAmar01_Tbl { get; set; } = null!;
        #endregion
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            ConfigureUnitCountAmar(builder);
            ConfigureUniqueConstraints(builder);
            ConfigureQuizRelationships(builder);
            ConfigureApplicationUsers(builder);
            ConfigureApplicationRoles(builder);
            ConfigureNewsCategory(builder);
            ConfigureStandCheckWritten(builder);
            ConfigureFlightPlanEvidence(builder);
            ConfigureTblMaster(builder);
            ConfigureStudentCourse(builder);
            ConfigureUsersCategorySub(builder);
            ConfigureUsersCategory(builder);
            ConfigureNewsImagesList(builder);
            ConfigureUjobPesronel(builder);
            ConfigureImagesListCategoryImagesList(builder);
            ConfigureGuardboardVPG(builder);
        }

        private static void ConfigureUnitCountAmar(ModelBuilder builder)
        {
            builder.Entity<UnitCountAmar01>(entity =>
            {
                entity.Property(e => e.averold)
                    .HasComputedColumnSql(
                        "CASE WHEN [CountEdeKol] IS NULL OR [CountEdeKol] = '0' THEN '0' " +
                        "ELSE CAST(CAST(ISNULL([sumold],'0') AS DECIMAL(18,2)) / CAST([CountEdeKol] AS DECIMAL(18,2)) AS NVARCHAR(50)) END",
                        stored: true);
            });
        }

        private static void ConfigureUniqueConstraints(ModelBuilder builder)
        {
            builder.Entity<DailyActivityEvidence01>()
                .HasIndex(e => e.DailyActivityEvidence01IDStateName01)
                .IsUnique();

            builder.Entity<PersonalCorrespondence01>()
                .HasIndex(e => e.DocumentNO01)
                .IsUnique();

            builder.Entity<CrewPersonalCorrespondence01>()
                .HasIndex(e => e.DocumentNO01)
                .IsUnique();
        }

        private static void ConfigureQuizRelationships(ModelBuilder builder)
        {
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
        }

        private static void ConfigureApplicationUsers(ModelBuilder builder)
        {
            builder.Entity<ApplicationUsers>(entity =>
            {
                entity.ToTable("Users_Tbl");
                entity.Property(e => e.Id).HasColumnName("UserID").ValueGeneratedOnAdd();
                entity.Property(p => p.BirthDayDate).HasDefaultValueSql("GETDATE()");
                entity.Property(p => p.LastPasswordChangeDate).HasDefaultValueSql("GETDATE()");

                entity.HasData(new ApplicationUsers
                {
                    UserName = "lb123456",
                    Id = "3300697e-daa9-42c0-b3fa-99c8dfc080c3",
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
        }

        private static void ConfigureApplicationRoles(ModelBuilder builder)
        {
            builder.Entity<ApplicationRoles>(entity =>
            {
                entity.ToTable("Roles_Tbl");
                entity.HasKey(e => e.Id);

                var roles = GetApplicationRoles();
                entity.HasData(roles);
            });

            var userRoles = GetUserRoles();
            builder.Entity<IdentityUserRole<string>>().HasData(userRoles);
        }

        private static ApplicationRoles[] GetApplicationRoles()
        {
            return new[]
            {
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
                    NormalizedName = "TAFVIZEKHTIAR01"
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
                    NormalizedName = "MANAGEPERSONNELPAYOR"
                },
                new ApplicationRoles
                {
                    Id = "27162af1-d67a-49af-b8d2-766a2d4467ec",
                    RoleLevel = "351d15d8-a914-41da-b3da-3e72edc82272",
                    Description = "افزودن فایل کارکنان پایور",
                    Name = "ADDFIEPERSONNELPAYOR",
                    NormalizedName = "ADDFIEPERSONNELPAYOR"
                },
                new ApplicationRoles
                {
                    Id = "998d0d7f-18e5-4cf0-8152-e6ccf1822502",
                    RoleLevel = "351d15d8-a914-41da-b3da-3e72edc82272",
                    Description = "افزودن فایل دو خطی حقوقی",
                    Name = "AddFileAccessHoghoghi01",
                    NormalizedName = "ADDFILEACCESSHOGHOGHI01"
                },
                new ApplicationRoles
                {
                    Id = "ed4a4f49-9ba5-4871-a366-ddd049006ab3",
                    RoleLevel = "351d15d8-a914-41da-b3da-3e72edc82272",
                    Description = "مشاهده کارکنان پایور",
                    Name = "VIEWPERSONNELPAYOR",
                    NormalizedName = "VIEWPERSONNELPAYOR"
                },
                new ApplicationRoles
                {
                    Id = "23a68401-f865-4e1e-87a6-9bdfe2f1c773",
                    RoleLevel = "ed4a4f49-9ba5-4871-a366-ddd049006ab3",
                    Description = "مشاهده کارکنان پایور سطح 2",
                    Name = "VIEWPERSONNELPAYOR02",
                    NormalizedName = "VIEWPERSONNELPAYOR02"
                },
                new ApplicationRoles
                {
                    Id = "9dec9ab3-95fa-478b-b0a4-4966b736ce97",
                    RoleLevel = "ed4a4f49-9ba5-4871-a366-ddd049006ab3",
                    Description = "مشاهده کارکنان پایور سطح 3",
                    Name = "VIEWPERSONNELPAYOR03",
                    NormalizedName = "VIEWPERSONNELPAYOR03"
                },
                new ApplicationRoles
                {
                    Id = "f23d8fb0-f077-44c7-a503-635845ab0fb1",
                    RoleLevel = "ed4a4f49-9ba5-4871-a366-ddd049006ab3",
                    Description = "مشاهده کارکنان پایور سطح 1",
                    Name = "VIEWPERSONNELPAYOR01",
                    NormalizedName = "VIEWPERSONNELPAYOR01"
                },
                new ApplicationRoles
                {
                    Id = "c993f1cb-7a97-424c-9e0f-554d402d2b92",
                    RoleLevel = "90579366-628e-477f-ac9a-4a7471a9986e",
                    Description = "مدیریت کارکنان یگان",
                    Name = "MANAGEPERSONNELYEGAN",
                    NormalizedName = "MANAGEPERSONNELYEGAN"
                },
                new ApplicationRoles
                {
                    Id = "d04ecc99-749b-4bbe-baba-d123004d2ca5",
                    RoleLevel = "90579366-628e-477f-ac9a-4a7471a9986e",
                    Description = "مدیریت کارکنان وظیفه",
                    Name = "MANAGEPERSONNELVAZIFEH",
                    NormalizedName = "MANAGEPERSONNELVAZIFEH"
                },
                new ApplicationRoles
                {
                    Id = "e801f9db-7663-42c5-a6ca-0ee7bcb6807b",
                    RoleLevel = "90579366-628e-477f-ac9a-4a7471a9986e",
                    Description = "مدیریت کارکنان پایور و وظیفه",
                    Name = "MANAGEPERSONNELPAYORVAZIFEH",
                    NormalizedName = "MANAGEPERSONNELPAYORVAZIFEH"
                },
                new ApplicationRoles
                {
                    Id = "efa7d0e0-b4b8-489c-a52a-4182e2f3b3b7",
                    RoleLevel = "90579366-628e-477f-ac9a-4a7471a9986e",
                    Description = "مدیریت کارکنان سطح 1",
                    Name = "Personnel02",
                    NormalizedName = "PERSONNEL02"
                }
            };
        }

        private static IdentityUserRole<string>[] GetUserRoles()
        {
            var userId = "3300697e-daa9-42c0-b3fa-99c8dfc080c3";
            var roleIds = new[]
            {
                "efa7d0e0-b4b8-489c-a52a-4182e2f3b3b7",
                "1a18cdbc-8197-49c0-92a6-747dbcb34350",
                "27162af1-d67a-49af-b8d2-766a2d4467ec",
                "f23d8fb0-f077-44c7-a503-635845ab0fb1",
                "e414e2cc-2b05-454a-9a07-60da4d929e6c"
            };

            return roleIds.Select(roleId => new IdentityUserRole<string>
            {
                UserId = userId,
                RoleId = roleId
            }).ToArray();
        }

        private static void ConfigureNewsCategory(ModelBuilder builder)
        {
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
        }

        private static void ConfigureStandCheckWritten(ModelBuilder builder)
        {
            builder.Entity<StandCheckWritten01>()
                .HasOne(s => s.ooMelliCodeList_3)
                .WithMany()
                .HasForeignKey(s => s.MelliCode)
                .IsRequired(false);

            builder.Entity<StandCheckWritten01>()
                .HasOne(s => s.ooMelliCodeList_4)
                .WithMany()
                .HasForeignKey(s => s.MelliCodeExamer)
                .IsRequired(false);

            builder.Entity<StandCheckWritten01>()
                .HasOne(s => s.ooMelliCodeInstructor)
                .WithMany()
                .HasForeignKey(s => s.MelliCodeInstructor)
                .IsRequired(false);
        }

        private static void ConfigureFlightPlanEvidence(ModelBuilder builder)
        {
            var defaultDate = new DateTime(2024, 6, 1, 0, 0, 0);

            builder.Entity<FlightPlanEvidence01>(entity =>
            {
                entity.Property(b => b.PlusDateTime).HasDefaultValue(defaultDate);
                entity.Property(b => b.PlusTimeSpan).HasDefaultValue("00:00");
                entity.Property(b => b.Sorties01).HasDefaultValue("0");
                entity.Property(b => b.NOPassengers01).HasDefaultValue("0");
                entity.Property(b => b.NOInjured01).HasDefaultValue("0");
                entity.Property(b => b.QTCargo01).HasDefaultValue("0");
                entity.Property(b => b.QT20MM01).HasDefaultValue("0");
                entity.Property(b => b.QTRocket01).HasDefaultValue("0");
                entity.Property(b => b.QTFuel01).HasDefaultValue("0");
            });
        }

        private static void ConfigureTblMaster(ModelBuilder builder)
        {
            builder.Entity<TblMaster>(entity =>
            {
                entity.Property(b => b.DRJ_COD).HasDefaultValue("100");
                entity.Property(b => b.UitID01).HasDefaultValue(123);
            });
        }

        private static void ConfigureStudentCourse(ModelBuilder builder)
        {
            builder.Entity<StudentCourse>().HasKey(sc => new { sc.StudentId, sc.CourseId });

            builder.Entity<StudentCourse>()
                .HasOne<Student>(sc => sc.Student)
                .WithMany(s => s.StudentCourses)
                .HasForeignKey(sc => sc.StudentId);

            builder.Entity<StudentCourse>()
                .HasOne<Course>(sc => sc.Course)
                .WithMany(s => s.StudentCourses)
                .HasForeignKey(sc => sc.CourseId);
        }

        private static void ConfigureUsersCategorySub(ModelBuilder builder)
        {
            builder.Entity<UsersCategorySub>().HasKey(sc => new { sc.CategrySubId, sc.UserID });

            builder.Entity<UsersCategorySub>()
                .HasOne<CategorySub>(sc => sc.CategorySub)
                .WithMany(s => s.UsersCategorySubs)
                .HasForeignKey(sc => sc.CategrySubId);

            builder.Entity<UsersCategorySub>()
                .HasOne<ApplicationUsers>(sc => sc.ApplicationUsers)
                .WithMany(s => s.UsersCategorySubs)
                .HasForeignKey(sc => sc.UserID);
        }

        private static void ConfigureUsersCategory(ModelBuilder builder)
        {
            builder.Entity<UsersCategory>().HasKey(sc => new { sc.CategryId, sc.UserID });

            builder.Entity<UsersCategory>()
                .HasOne<Category>(sc => sc.Category)
                .WithMany(s => s.UsersCategorys)
                .HasForeignKey(sc => sc.CategryId);

            builder.Entity<UsersCategory>()
                .HasOne<ApplicationUsers>(sc => sc.ApplicationUsers)
                .WithMany(s => s.UsersCategorys)
                .HasForeignKey(sc => sc.UserID);
        }

        private static void ConfigureNewsImagesList(ModelBuilder builder)
        {
            builder.Entity<NewsImagesList>().HasKey(sc => sc.NewsImagesID);

            builder.Entity<NewsImagesList>()
                .HasOne<News>(sc => sc.News)
                .WithMany(s => s.NewsImagesLists)
                .HasForeignKey(sc => sc.NewsId);

            builder.Entity<NewsImagesList>()
                .HasOne<ImagesList>(sc => sc.ImagesList)
                .WithMany(s => s.NewsImagesLists)
                .HasForeignKey(sc => sc.ImagesListId);
        }

        private static void ConfigureUjobPesronel(ModelBuilder builder)
        {
            builder.Entity<UjobPesronel01>().HasKey(sc => sc.UjobPesronel01ID);

            builder.Entity<UjobPesronel01>()
                .HasOne<ApplicationUsers>(sc => sc.Users)
                .WithMany(s => s.UjobPesronel01s)
                .HasForeignKey(sc => sc.UserID);

            builder.Entity<UjobPesronel01>()
                .HasOne<TblMaster>(sc => sc.MelliCodeList)
                .WithMany(s => s.UjobPesronel01s)
                .HasForeignKey(sc => sc.MelliCode);
        }

        private static void ConfigureImagesListCategoryImagesList(ModelBuilder builder)
        {
            builder.Entity<ImagesListCategoryImagesList>()
                .HasKey(sc => new { sc.ImagesListId, sc.CategoryImagesId });

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
        }

        private static void ConfigureGuardboardVPG(ModelBuilder builder)
        {
            builder.Entity<GuardboardVPG>().HasKey(sc => sc.GuardboardVPGID);

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
        }
    }
}
