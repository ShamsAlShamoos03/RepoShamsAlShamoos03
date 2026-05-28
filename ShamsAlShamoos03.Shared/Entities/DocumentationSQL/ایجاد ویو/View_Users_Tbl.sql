 
 SELECT
       [Users_Tbl].[UserID]
      ,[FirstName]
      ,[LastName]
	  ,View_UjobPesronel01_Tbl.Darajee 
	  	  ,View_UjobPesronel01_Tbl.FST_NAM
	  ,View_UjobPesronel01_Tbl.LST_NAM
	  ,View_UjobPesronel01_Tbl.EMP_NUM


      ,[gender]
      ,[PhoneNumber]
      ,[ImagePath]
      ,[BirthDayDate]
      ,[IsActive]
      ,[UserName]
      ,[NormalizedUserName]
      ,[Email]
      ,[NormalizedEmail]
      ,[EmailConfirmed]
      ,[PasswordHash]
      ,[SecurityStamp]
      ,[ConcurrencyStamp]
      ,[PhoneNumberConfirmed]
      ,[TwoFactorEnabled]
      ,[LockoutEnd]
      ,[LockoutEnabled]
      ,[AccessFailedCount]
      ,[Melicode]
      ,[PersonalCode]
      ,[TextRequest]
      ,[FName]
      ,[LName]
      ,[Personelcodes]
      ,[Rate]
      ,[YeganID]
      ,[SematID]
      ,[ShobehID]
      ,[RateID]
      ,[MelliCodeID]
      ,[JobsLevel]
      ,[Sortable013d]


  FROM  [dbo].[Users_Tbl]

 LEFT OUTER JOIN 
    dbo.View_UjobPesronel01_Tbl AS View_UjobPesronel01_Tbl 
    ON View_UjobPesronel01_Tbl.[UserID] = [Users_Tbl].[UserID]

	