DROP VIEW IF EXISTS dbo.View_UserFullInfo;

CREATE VIEW View_UserFullInfo AS
SELECT 
    u.UserId as 'UserID',
    u.MelliCodeID,
    u.FirstName,
    u.LastName,
	u.UserName,
    View_TblMaster.FST_NAM,
    View_TblMaster.LST_NAM,
    View_TblMaster.UitID01 as 'YeganUser',
    View_TblMaster.DrjLookupTitle AS Daraje,
    Roles = STUFF((
        SELECT ',' + r.Name
        FROM AspNetUserRoles ur
        INNER JOIN Roles_Tbl r ON ur.RoleId = r.Id
        WHERE ur.UserId = u.UserId
        FOR XML PATH(''), TYPE).value('.', 'NVARCHAR(MAX)'), 1, 1, ''),
    Rolesdes = STUFF((
        SELECT ',' + r.Description
        FROM AspNetUserRoles ur
        INNER JOIN Roles_Tbl r ON ur.RoleId = r.Id
        WHERE ur.UserId = u.UserId
        FOR XML PATH(''), TYPE).value('.', 'NVARCHAR(MAX)'), 1, 1, '')
FROM Users_Tbl u
--LEFT JOIN TblMelicodeID m ON u.tblMelicodeID = m.Id
--LEFT JOIN ooDRJCOD d ON m.ooDRJCODId = d.Id;
    --ON dbo.View_TblMaster.MelliCode = DailyPlanEvidence01_Tbl.MelliCode
     INNER JOIN 
    dbo.View_TblMaster AS View_TblMaster 
    ON u.MelliCodeID = View_TblMaster.MelliCode


	select * from View_UserFullInfo