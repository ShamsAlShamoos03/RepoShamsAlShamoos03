

--SELECT 
--    dbo.TblLuLookup.*, 
--    dbo.TblLuLookupSub_Tbl.*, 
--    dbo.Sortable01_Tbl.*
--FROM dbo.TblLuLookup 
--LEFT OUTER JOIN dbo.Sortable01_Tbl 
--    ON dbo.TblLuLookup.Sortable01Id = dbo.Sortable01_Tbl.Sortable01Id 
--LEFT OUTER JOIN dbo.TblLuLookupSub_Tbl 
--    ON dbo.TblLuLookupSub_Tbl.TblLuLookupSubbId = dbo.TblLuLookup.TblLuLookupSubbId;


--SELECT 
--    tll.ID AS LookupId,
--    tll.Type AS LookupType,
--    tll.Title AS LookupTitle,
--    tll.AlphabeticSort,
--    tll.Cod_h,
--    tll.TitleEn1,
--    tll.TblLuLookupSubbId,
--    tll.Sortable01Id AS LookupSortableId,
    
--    s.Idsort AS MainSortableId,
--    s.Description AS MainSortableDescription,

--    tlls.TblLuLookupSubbId AS SubLookupId,
--    tlls.TitleS AS SubLookupTitle,
--    tlls.DescriptionS AS SubLookupDescription,
--    tlls.Section_S01,
--    tlls.Section_S02,
--    tlls.Seed_S01,
--    tlls.Seed_S02,
--    tlls.Sortable01Id AS SubLookupSortableId,
    
--    sSub.Idsort AS SubSortableId,
--    sSub.Description AS SubSortableDescription
--FROM 
--    dbo.TblLuLookup tll
--LEFT OUTER JOIN 
--    dbo.Sortable01_Tbl s 
--    ON tll.Sortable01Id = s.Sortable01Id
--LEFT OUTER JOIN 
--    dbo.TblLuLookupSub_Tbl tlls 
--    ON tll.TblLuLookupSubbId = tlls.TblLuLookupSubbId
--LEFT OUTER JOIN 
--    dbo.Sortable01_Tbl sSub 
--    ON tlls.Sortable01Id = sSub.Sortable01Id 
	  
 



 --FROM            dbo.TblLuLookup LEFT OUTER JOIN
 --                        dbo.Sortable01_Tbl ON dbo.TblLuLookup.Sortable01Id = dbo.Sortable01_Tbl.Sortable01Id LEFT OUTER JOIN
 --                        dbo.TblLuLookupSub_Tbl ON dbo.TblLuLookupSub_Tbl.TblLuLookupSubbId = dbo.TblLuLookup.TblLuLookupSubbId LEFT OUTER JOIN
 --                        dbo.Sortable01_Tbl AS SortableSub ON dbo.TblLuLookupSub_Tbl.Sortable01Id = SortableSub.Sortable01Id



 --SELECT   [DateProperty01ID]
 --  ,dbo.GetPersianWeekday([DateProperty01ID]) as persianWeekDate01

 --     ,[TimwStartEnd01]
 -- ,  CatDateProperty01.Title AS [strTimwStart01]
 --   , CatDateProperty01.CategoryDescription AS [strTimwEnd01]

	----strDateCategory01
	--	  ,           STUFF((
 --               SELECT '', '' + ISNULL([View_DatePropertyPlanEvidence01_Tbl].strDateCategory01, '''')
 --               FROM [View_DatePropertyPlanEvidence01_Tbl] mt1
 --               LEFT OUTER JOIN (SELECT [CategoryGeneralId], [Title], [Description], [CategoryGeneralSubId], [IsActive], [Sortable01Id], [ooCategoryGeneralSubId] FROM CategoriesGeneral_Tbl) AS luDateCategory01 ON mt1.DateCategory01 = luDateCategory01.CategoryGeneralId
 --               WHERE mt1.DateProperty01ID = DailyActivityEvidence01_Tbl.FromDateDailyActivityEvidence01Title
 --               ORDER BY luDateCategory01.Sortable01Id asc
 --               FOR XML PATH(''''), TYPE).value(''.'', ''NVARCHAR(MAX)''), 1, 2, '''') AS arrastrDateCategory01,



 -- FROM [NewsDB].[dbo].[DateProperty01_Tbl]

 -- 	INNER JOIN 
 --   dbo.View_CategoriesGeneral_Tbl AS CatDateProperty01
 --   ON CatDateProperty01.CategoryGeneralId=DateProperty01_Tbl.TimwStartEnd01  ;


-- SELECT 
--    [DateProperty01ID],
--    [DateProperty01ID] as [ddddddddd],
--    dbo.GetPersianWeekday([DateProperty01ID]) AS persianWeekDate01,
--    [TimwStartEnd01],
--    CatDateProperty01.Title AS [strTimwStart01],
--    CatDateProperty01.CategoryDescription AS [strTimwEnd01],




--    STUFF(
--        (
--            SELECT ', ' + ISNULL( 'strDateCategory01', '')
--            FROM [View_DatePropertyPlanEvidence01_Tbl] mt1
           
		   
--		   INNER JOIN 
--    dbo.View_CategoriesGeneral_Tbl AS luDateCategory01


--            ON mt1.DateCategory01 = luDateCategory01.CategoryGeneralId
--            WHERE mt1.DateProperty01ID =[ddddddddd]
--            ORDER BY luDateCategory01.MainSortableId ASC
--            FOR XML PATH(''), TYPE
--        ).value('.', 'NVARCHAR(MAX)'), 1, 2, ''
--    ) AS arrastrDateCategory01



--FROM 
--    [NewsDB].[dbo].[DateProperty01_Tbl]
--INNER JOIN 
--    dbo.View_CategoriesGeneral_Tbl AS CatDateProperty01
--    ON CatDateProperty01.CategoryGeneralId = DateProperty01_Tbl.TimwStartEnd01;


SELECT 
    dp.[DateProperty01ID],
    dbo.GetPersianWeekday(dp.[DateProperty01ID]) AS persianWeekDate01,
    dp.[TimwStartEnd01],
	--prev.TimwStartEnd01 as pre,prev.DateProperty01ID as predat,next.TimwStartEnd01 as nex,next.DateProperty01ID as nextdat,
    CatDateProperty01.Title AS [strTimwStart01],
    CatDateProperty01.CategoryDescription AS [strTimwEnd01],
    STUFF(
        (
            SELECT ', ' + ISNULL(strDateCategory01, '')
            FROM [View_DatePropertyPlanEvidence01_Tbl] mt1
            INNER JOIN dbo.View_CategoriesGeneral_Tbl AS luDateCategory01
                ON mt1.DateCategory01 = luDateCategory01.CategoryGeneralId
            WHERE mt1.DateProperty01ID = dp.DateProperty01ID
            ORDER BY luDateCategory01.MainSortableId ASC
            FOR XML PATH(''), TYPE
        ).value('.', 'NVARCHAR(MAX)'), 1, 2, ''
    ) AS strDateCategory01,
    dbo.MiladiToShamsi(dbo.AddDaysToDate(dbo.[ShamsiToGregorian](dp.DateProperty01ID), 1)) as Date02,
    dbo.[ShamsiToGregorian](dp.DateProperty01ID) as Miladidate,
    
    -- ستون جدید تعطیلی
  
CASE
    -- اگر روز جاری عادی است ولی روز بعد 625 است → تمام تعطیل
    WHEN dp.[TimwStartEnd01] != 625 AND next.[TimwStartEnd01] = 625 THEN N'تمام تعطیل'  

    -- اگر روز جاری خودش عادی و روز بعد هم عادی → عادی
    WHEN dp.[TimwStartEnd01] != 625 THEN N'عادی'                

    -- اگر روز جاری 625 و روز قبل و بعد 625 → تمام تعطیل
    WHEN prev.[TimwStartEnd01] = 625 AND next.[TimwStartEnd01] = 625 THEN N'تمام تعطیل'  

    -- اگر روز بعد 625 → تمام تعطیل
    WHEN next.[TimwStartEnd01] = 625 THEN N'تمام تعطیل'        

    -- اگر روز قبل 625 → نیمه تعطیل
    WHEN prev.[TimwStartEnd01] = 625 THEN N'نیمه تعطیل'        

    ELSE N'عادی'  -- حالت پیش‌فرض
END AS HolidayStatusGRD,

    -- ستون جدید تعطیلی
  
CASE
    -- اگر روز جاری عادی است ولی روز بعد 625 است → تمام تعطیل
    WHEN dp.[TimwStartEnd01] != 625 AND next.[TimwStartEnd01] = 625 THEN N'FH'  

    -- اگر روز جاری خودش عادی و روز بعد هم عادی → عادی
    WHEN dp.[TimwStartEnd01] != 625 THEN N'N'                

    -- اگر روز جاری 625 و روز قبل و بعد 625 → تمام تعطیل
    WHEN prev.[TimwStartEnd01] = 625 AND next.[TimwStartEnd01] = 625 THEN N'FH'  

    -- اگر روز بعد 625 → تمام تعطیل
    WHEN next.[TimwStartEnd01] = 625 THEN N'FH'        

    -- اگر روز قبل 625 → نیمه تعطیل
    WHEN prev.[TimwStartEnd01] = 625 THEN N'HH'        

    ELSE N'عادی'  -- حالت پیش‌فرض
END AS HolidayStatusGRDID



FROM 
    [NewsDB].[dbo].[DateProperty01_Tbl] dp
INNER JOIN 
    dbo.View_CategoriesGeneral_Tbl AS CatDateProperty01
    ON CatDateProperty01.CategoryGeneralId = dp.TimwStartEnd01

-- روز قبل
LEFT JOIN [NewsDB].[dbo].[DateProperty01_Tbl] prev
    ON prev.DateProperty01ID = dbo.MiladiToShamsi(dbo.AddDaysToDate(dbo.[ShamsiToGregorian](dp.DateProperty01ID), -1))

-- روز بعد
LEFT JOIN [NewsDB].[dbo].[DateProperty01_Tbl] next
    ON next.DateProperty01ID = dbo.MiladiToShamsi(dbo.AddDaysToDate(dbo.[ShamsiToGregorian](dp.DateProperty01ID), 1));




--SELECT 
--    [DateProperty01ID],
--     dbo.GetPersianWeekday([DateProperty01ID]) AS persianWeekDate01,
--    [TimwStartEnd01],
--    CatDateProperty01.Title AS [strTimwStart01],
--    CatDateProperty01.CategoryDescription AS [strTimwEnd01],
--    STUFF(
--        (
--            SELECT ', ' + ISNULL(strDateCategory01, '') -- اگر مقدار واقعی‌ای دارید، آن را جایگزین 'strDateCategory01' کنید
--            FROM [View_DatePropertyPlanEvidence01_Tbl] mt1
--            INNER JOIN dbo.View_CategoriesGeneral_Tbl AS luDateCategory01
--                ON mt1.DateCategory01 = luDateCategory01.CategoryGeneralId
--            WHERE mt1.DateProperty01ID = DateProperty01_Tbl.DateProperty01ID -- استفاده از نام اصلی ستون
--            ORDER BY luDateCategory01.MainSortableId ASC
--            FOR XML PATH(''), TYPE
--        ).value('.', 'NVARCHAR(MAX)'), 1, 2, ''
--    ) AS strDateCategory01
--	         ,   dbo.MiladiToShamsi(dbo.AddDaysToDate(dbo.[ShamsiToGregorian](DateProperty01ID), 1)) as Date02
--			 ,dbo.[ShamsiToGregorian](DateProperty01ID) as Miladidate
--FROM 
--    [NewsDB].[dbo].[DateProperty01_Tbl]
--INNER JOIN 
--    dbo.View_CategoriesGeneral_Tbl AS CatDateProperty01
--    ON CatDateProperty01.CategoryGeneralId = DateProperty01_Tbl.TimwStartEnd01;