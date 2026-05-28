 


   SELECT distinct(UitID01 ) UitID01
   --, strUitID01 
   
   
   
	    , strUitID01+': '+STUFF(
        (
            SELECT distinct(', ' + ISNULL(RIGHT(Date01,5), '')) -- اگر مقدار واقعی‌ای دارید، آن را جایگزین 'strDateCategory01' کنید
            FROM [View_DailyPlanEvidence02] mt1
          
            WHERE mt1.StatusConfirmation02 IN ('319') and mt1.[TimwStartEnd01] not in ('625') and  mt.UitID01=mt1.UitID01 
            FOR XML PATH(''), TYPE
        ).value('.', 'NVARCHAR(MAX)'), 1, 2, ''
    ) AS strUitID01
   
   
   FROM [dbo].[View_DailyPlanEvidence02] mt where StatusConfirmation02 IN ('319') and [TimwStartEnd01] not in ('625')   
   --order by UitID01   
   

   --order by mt1.UitID01,mt1.Date01 desc

	   --  STUFF(
    --    (
    --        SELECT ', ' + ISNULL(strDateCategory01, '') -- اگر مقدار واقعی‌ای دارید، آن را جایگزین 'strDateCategory01' کنید
    --        FROM [View_DatePropertyPlanEvidence01_Tbl] mt1
    --        INNER JOIN dbo.View_CategoriesGeneral_Tbl AS luDateCategory01
    --            ON mt1.DateCategory01 = luDateCategory01.CategoryGeneralId
    --        WHERE mt1.DateProperty01ID = DateProperty01_Tbl.DateProperty01ID -- استفاده از نام اصلی ستون
    --        ORDER BY luDateCategory01.MainSortableId ASC
    --        FOR XML PATH(''), TYPE
    --    ).value('.', 'NVARCHAR(MAX)'), 1, 2, ''
    --) AS strDateCategory01



   --and Date01 like '1404/03/17'


   --SELECT * FROM [dbo].[View_DailyPlanEvidence02]  where StatusConfirmation02 IN ('319')

   --   ,[TimwStartEnd01]
   --   ,[strTimwStart01]
   --   ,[strTimwEnd01]
