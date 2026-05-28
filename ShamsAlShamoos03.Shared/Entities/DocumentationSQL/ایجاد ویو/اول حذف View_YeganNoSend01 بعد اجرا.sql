  
  --delete [dbo].[View_YeganNoSend01]
/****** Object:  View [dbo].[View_YeganNoSend01]    Script Date: 6/19/2025 6:24:41 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

/*and Date01 like '1404/03/17'*/
  create  VIEW [dbo].[View_YeganNoSend01]
AS
 


   SELECT distinct(UitID01 ) UitID01
   --, strUitID01 
   
   
   
	    , strUitID01+': '+STUFF(
        (
            SELECT distinct(', ' + ISNULL(Date01, '')) -- اگر مقدار واقعی‌ای دارید، آن را جایگزین 'strDateCategory01' کنید
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

GO

EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "View_DailyPlanEvidence02"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 136
               Right = 366
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_YeganNoSend01'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_YeganNoSend01'
GO


