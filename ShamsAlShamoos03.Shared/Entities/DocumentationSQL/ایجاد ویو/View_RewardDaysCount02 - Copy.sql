 
 SELECT 
    a.*,
    b.TotalRewardDays
FROM 
    [NewsDB].[dbo].[View_RewardDaysCount01] a
JOIN 
    (SELECT 
        [MelliCode],
        [PersianYear],
        SUM([RewardDaysCount]) AS TotalRewardDays
     FROM 
        [NewsDB].[dbo].[View_RewardDaysCount01]  
		--where [View_RewardDaysCount01].[MelliCode]='5749561380'

     GROUP BY 
        [MelliCode],
        [PersianYear]) b
ON 
    a.[MelliCode] = b.[MelliCode] AND 
    a.[PersianYear] = b.[PersianYear]
ORDER BY 
    a.[MelliCode],
    a.[PersianYear]

   --where [PersonalCorrespondence01_Tbl].[MelliCode]='5749561380'

 --SELECT TOP (1000) [MelliCode]
 --     ,[PersianYear]
 --     ,[RewardDaysCount]
 -- FROM [NewsDB].[dbo].[View_RewardDaysCount01]


  --where [TypeLetter01]='636' and [RewardDaysCount] is not null
  --where [View_RewardDaysCount01].[MelliCode]='5749561380'

      --,[StatusConfirmation01]
      --,[StatusConfirmation02]
      --,[TypeLetter01]
      --,[EMP_NUM]
      --,[DRJ_NAM]
      --,[FST_NAM]
      --,[LST_NAM]
