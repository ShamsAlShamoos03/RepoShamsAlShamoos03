CREATE OR ALTER VIEW dbo.Report2View01
AS
WITH ImagesCTE AS
(
    SELECT 
        ni.NewsId,
        il.IndexImage,
        ROW_NUMBER() OVER (PARTITION BY ni.NewsId ORDER BY ni.Sortable01Id, ni.NewsImagesID) AS RowNum
    FROM NewsImagesList_Tbl ni
    INNER JOIN ImagesList_Tbl il ON il.ImagesListId = ni.ImagesListId
)

SELECT
    n.NewsId,
    nc.CategoryID,
    n.Title,
    n.Content,
    n.Abstract,
    n.NewsDateSham,

    c.CategrySubId AS IDCategories,
    c.Title AS TitleCategories,
    c.Section_01 AS TitleSection,
    c.Description AS TitleDescription,

    cs.CategrySubId AS IDCategoriesSub,
    cs.TitleS AS TitleCategoriesSub,

    nc.Sortable01Id,

    img1.IndexImage AS NewsImages01,
    img2.IndexImage AS NewsImages02,
    img3.IndexImage AS NewsImages03

FROM NewsCategorys nc  
INNER JOIN News_Tbl n ON n.NewsId = nc.NewsId
INNER JOIN Categories_Tbl c ON c.CategryId = nc.CategoryID
LEFT JOIN CategorySub_Tbl cs ON cs.CategrySubId = c.CategrySubId

LEFT JOIN ImagesCTE img1 ON img1.NewsId = n.NewsId AND img1.RowNum = 1
LEFT JOIN ImagesCTE img2 ON img2.NewsId = n.NewsId AND img2.RowNum = 2
LEFT JOIN ImagesCTE img3 ON img3.NewsId = n.NewsId AND img3.RowNum = 3

WHERE img1.IndexImage IS NOT NULL
and NewsDateSham >'1404/02/01'
and cs.CategrySubId=5
;  -- شرط فیلتر در اینجا