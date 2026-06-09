using Microsoft.AspNetCore.Identity;
using ShamsAlShamoos03.Shared.Entities;

namespace ShamsAlShamoos03.Infrastructure.Persistence.SeedData
{
    public static class ApplicationRolesSeed
    {
        // همه نقش‌ها با هم ترکیب شده
        public static ApplicationRoles[] Roles =>
            UserManagementRoles
            .Concat(PersonnelManagementRoles)
            .Concat(PersonnelViewRoles)
            .ToArray();

        // نقش‌های کاربران پیش‌فرض
        public static readonly IdentityUserRole<string>[] UserRoles =
        {
            new()
            {
                UserId = "3300697e-daa9-42c0-b3fa-99c8dfc080c3",
                RoleId = "efa7d0e0-b4b8-489c-a52a-4182e2f3b3b7"
            },
            new()
            {
                UserId = "3300697e-daa9-42c0-b3fa-99c8dfc080c3",
                RoleId = "1a18cdbc-8197-49c0-92a6-747dbcb34350"
            },
            new()
            {
                UserId = "3300697e-daa9-42c0-b3fa-99c8dfc080c3",
                RoleId = "27162af1-d67a-49af-b8d2-766a2d4467ec"
            },
            new()
            {
                UserId = "3300697e-daa9-42c0-b3fa-99c8dfc080c3",
                RoleId = "f23d8fb0-f077-44c7-a503-635845ab0fb1"
            },
            new()
            {
                UserId = "3300697e-daa9-42c0-b3fa-99c8dfc080c3",
                RoleId = "e414e2cc-2b05-454a-9a07-60da4d929e6c"
            }
        };

        private static readonly ApplicationRoles[] UserManagementRoles =
        {
            new()
            {
                Id = "17addaba-dd6c-4c46-9993-559edf295ac8",
                RoleLevel = "22daafff-159d-482e-92c0-72ba9d455677",
                Description = "کاربر عادی",
                Name = "NORMALUSER",
                NormalizedName = "NORMALUSER",
                ConcurrencyStamp = "20572dd0-966c-42d9-a95c-f64b2abd1016"
            },
            new()
            {
                Id = "189ed4ed-3ac3-4b20-b8c3-3b32769cf976",
                RoleLevel = "22daafff-159d-482e-92c0-72ba9d455677",
                Description = "تفویض اختیار محلی",
                Name = "TafvizEkhtiar01",
                NormalizedName = "TAFVIZEKHTIAR01"
            },
            new()
            {
                Id = "1a18cdbc-8197-49c0-92a6-747dbcb34350",
                RoleLevel = "22daafff-159d-482e-92c0-72ba9d455677",
                Description = "افزودن کاربران",
                Name = "AddUser",
                NormalizedName = "ADDUSER"
            },
            new()
            {
                Id = "22daafff-159d-482e-92c0-72ba9d455677",
                RoleLevel = "abc",
                Description = "مدیریت کاربران",
                Name = "User",
                NormalizedName = "USER"
            },
            new()
            {
                Id = "e414e2cc-2b05-454a-9a07-60da4d929e6c",
                RoleLevel = "22daafff-159d-482e-92c0-72ba9d455677",
                Description = "مدیر کاربر سطح 1",
                Name = "MANAGEUSER01",
                NormalizedName = "MANAGEUSER01"
            }
        };

        private static readonly ApplicationRoles[] PersonnelManagementRoles =
        {
            new()
            {
                Id = "90579366-628e-477f-ac9a-4a7471a9986e",
                RoleLevel = "abc",
                Description = "مدیریت کارکنان",
                Name = "Personnel01",
                NormalizedName = "PERSONNEL01"
            },
            new()
            {
                Id = "351d15d8-a914-41da-b3da-3e72edc82272",
                RoleLevel = "90579366-628e-477f-ac9a-4a7471a9986e",
                Description = "مدیریت کارکنان پایور",
                Name = "MANAGEPERSONNELPAYOR",
                NormalizedName = "MANAGEPERSONNELPAYOR"
            },
            new()
            {
                Id = "27162af1-d67a-49af-b8d2-766a2d4467ec",
                RoleLevel = "351d15d8-a914-41da-b3da-3e72edc82272",
                Description = "افزودن فایل کارکنان پایور",
                Name = "ADDFIEPERSONNELPAYOR",
                NormalizedName = "ADDFIEPERSONNELPAYOR"
            },
            new()
            {
                Id = "998d0d7f-18e5-4cf0-8152-e6ccf1822502",
                RoleLevel = "351d15d8-a914-41da-b3da-3e72edc82272",
                Description = "افزودن فایل دو خطی حقوقی",
                Name = "AddFileAccessHoghoghi01",
                NormalizedName = "ADDFILEACCESSHOGHOGHI01"
            },
            new()
            {
                Id = "c993f1cb-7a97-424c-9e0f-554d402d2b92",
                RoleLevel = "90579366-628e-477f-ac9a-4a7471a9986e",
                Description = "مدیریت کارکنان یگان",
                Name = "MANAGEPERSONNELYEGAN",
                NormalizedName = "MANAGEPERSONNELYEGAN"
            },
            new()
            {
                Id = "d04ecc99-749b-4bbe-baba-d123004d2ca5",
                RoleLevel = "90579366-628e-477f-ac9a-4a7471a9986e",
                Description = "مدیریت کارکنان وظیفه",
                Name = "MANAGEPERSONNELVAZIFEH",
                NormalizedName = "MANAGEPERSONNELVAZIFEH"
            },
            new()
            {
                Id = "e801f9db-7663-42c5-a6ca-0ee7bcb6807b",
                RoleLevel = "90579366-628e-477f-ac9a-4a7471a9986e",
                Description = "مدیریت کارکنان پایور و وظیفه",
                Name = "MANAGEPERSONNELPAYORVAZIFEH",
                NormalizedName = "MANAGEPERSONNELPAYORVAZIFEH"
            },
            new()
            {
                Id = "efa7d0e0-b4b8-489c-a52a-4182e2f3b3b7",
                RoleLevel = "90579366-628e-477f-ac9a-4a7471a9986e",
                Description = "مدیریت کارکنان سطح 1",
                Name = "Personnel02",
                NormalizedName = "PERSONNEL02"
            }
        };

        private static readonly ApplicationRoles[] PersonnelViewRoles =
        {
            new()
            {
                Id = "ed4a4f49-9ba5-4871-a366-ddd049006ab3",
                RoleLevel = "351d15d8-a914-41da-b3da-3e72edc82272",
                Description = "مشاهده کارکنان پایور",
                Name = "VIEWPERSONNELPAYOR",
                NormalizedName = "VIEWPERSONNELPAYOR"
            },
            new()
            {
                Id = "23a68401-f865-4e1e-87a6-9bdfe2f1c773",
                RoleLevel = "ed4a4f49-9ba5-4871-a366-ddd049006ab3",
                Description = "مشاهده کارکنان پایور سطح 2",
                Name = "VIEWPERSONNELPAYOR02",
                NormalizedName = "VIEWPERSONNELPAYOR02"
            },
            new()
            {
                Id = "9dec9ab3-95fa-478b-b0a4-4966b736ce97",
                RoleLevel = "ed4a4f49-9ba5-4871-a366-ddd049006ab3",
                Description = "مشاهده کارکنان پایور سطح 3",
                Name = "VIEWPERSONNELPAYOR03",
                NormalizedName = "VIEWPERSONNELPAYOR03"
            },
            new()
            {
                Id = "f23d8fb0-f077-44c7-a503-635845ab0fb1",
                RoleLevel = "ed4a4f49-9ba5-4871-a366-ddd049006ab3",
                Description = "مشاهده کارکنان پایور سطح 1",
                Name = "VIEWPERSONNELPAYOR01",
                NormalizedName = "VIEWPERSONNELPAYOR01"
            }
        };
    }
}
