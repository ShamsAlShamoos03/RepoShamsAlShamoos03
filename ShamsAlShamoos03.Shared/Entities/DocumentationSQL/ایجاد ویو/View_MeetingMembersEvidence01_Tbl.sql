 SELECT   [MeetingMembersEvidence01ID]
      ,[MeetingMembersEvidence01_Tbl].[MeetingDetailsEvidence01ID]
      ,[MeetingMembersEvidence01_Tbl].[MelliCode]
	  ,MeetingEvidence01_Tbl.MeetingEvidence01ID
       ,[IsPIC]
      [Duty],
          View_TblMaster1.EMP_NUM,
    View_TblMaster1.FST_NAM as 'Fname',
    View_TblMaster1.LST_NAM as 'Rname',
	     View_TblMaster1.UnitTitle as 'strUitID01',
		      View_TblMaster1.DrjLookupTitle as 'Darajee',

     View_TblMaster1.UitID01 ,
     View_TblMaster1.DrjLookupId,
     View_TblMaster1.DrjSubLookupId
	 
      ,[MeetingMembersEvidence01_Tbl].[Sortable01Id]
       ,[MeetingMembersEvidence01_Tbl].[IsHaveJob]
       , View_TblMaster1.DrjLookupTitle+' ' +View_TblMaster1.FST_NAM+' ' +View_TblMaster1.LST_NAM+' ' +View_TblMaster1.EMP_NUM+' ' +View_TblMaster1.MelliCode  as 'Title'
 	      ,[MeetingMembersEvidence01_Tbl].[MelliCode] as 'PersonImage'

		,MeetingDetailsEvidence01_Tbl.FromDateMeetingDetailsEvidence01Title  as 'FromDateMeetingEvidence01TitleMeet'
		,MeetingEvidence01_Tbl.TypeMeeting  as 'TypeMeetingMeet'
		,CatTypeMeetingMeet.Title  as 'TypeMeetingMeetstr'
		
		,MeetingDetailsEvidence01_Tbl.TypeMeeting  as 'TitleMeetingMeet'
		,MeetingDetailsEvidence01_Tbl.PlaceMeeting  as 'PlaceMeetingMeet'
		,CatPlaceMeeting.Title  as 'PlaceMeetingMeetstr'
		--,CatTitleMeeting.Title  as 'PlaceMeetingMeetstr'

		    --FromDateMeetingEvidence01TitleMeet = item.oo_MeetingDetailsEvidence01ID.FromDateMeetingDetailsEvidence01Title,

	--Title = item.oo_CrewFlightPesronel.ooDRJCOD.Title + " " + item.oo_CrewFlightPesronel.FST_NAM + " " + item.oo_CrewFlightPesronel.LST_NAM + " " + item.oo_CrewFlightPesronel.EMP_NUM + " " + item.MelliCode,
	 --  TypeMeetingMeet = item.oo_MeetingDetailsEvidence01ID.oo_MeetingEvidence01ID.TypeMeeting,
 --TypeMeetingMeetstr = item.oo_MeetingDetailsEvidence01ID.oo_MeetingEvidence01ID.oo_TypeMeeting.Title,
 --TitleMeetingMeet = item.oo_MeetingDetailsEvidence01ID.oo_MeetingEvidence01ID.TitleMeeting,
 --TitleMeetingMeetstr = item.oo_MeetingDetailsEvidence01ID.oo_MeetingEvidence01ID.oo_TitleMeeting.Title,
 --PlaceMeetingMeet = item.oo_MeetingDetailsEvidence01ID.PlaceMeeting,
 --PlaceMeetingMeetstr = item.oo_MeetingDetailsEvidence01ID.oo_PlaceMeeting.Title,
 --StatusMeetingEvidence01Meet = item.oo_MeetingDetailsEvidence01ID.StatusMeetingDetailsEvidence01,
 --StatusMeetingEvidence01Meetstr = item.oo_MeetingDetailsEvidence01ID.oo_StatusMeetingDetailsEvidence01.Title,
 --ToDateMeetingEvidence01MeetTitle = item.oo_MeetingDetailsEvidence01ID.ToDateMeetingDetailsEvidence01Title,


  FROM [dbo].[MeetingMembersEvidence01_Tbl]

   INNER JOIN 
  dbo.View_TblMaster AS View_TblMaster1 
  ON  View_TblMaster1.MelliCode = [MeetingMembersEvidence01_Tbl].MelliCode

     INNER JOIN 
  dbo.MeetingDetailsEvidence01_Tbl AS MeetingDetailsEvidence01_Tbl 
  ON  MeetingDetailsEvidence01_Tbl.MeetingDetailsEvidence01ID = [MeetingMembersEvidence01_Tbl].MeetingDetailsEvidence01ID

     INNER JOIN 
  dbo.CategoriesGeneral_Tbl AS CatPlaceMeeting 
  ON CatPlaceMeeting.CategoryGeneralId= MeetingDetailsEvidence01_Tbl.PlaceMeeting

       INNER JOIN 
  dbo.MeetingEvidence01_Tbl AS MeetingEvidence01_Tbl 
  ON MeetingEvidence01_Tbl.MeetingEvidence01ID= MeetingDetailsEvidence01_Tbl.MeetingEvidence01ID

       INNER JOIN 
  dbo.CategoriesGeneral_Tbl AS CatTypeMeetingMeet
  ON CatTypeMeetingMeet.CategoryGeneralId= MeetingEvidence01_Tbl.TypeMeeting

  --where [MeetingMembersEvidence01_Tbl].[MeetingDetailsEvidence01ID] like 'fe2e6c44-1f7ca-1404d-1bb15-12269b1a28b00'
  --order by View_TblMaster1.UitID01 ,DrjLookupId desc,DrjSubLookupId
  --order by View_TblMaster1.UitID01 ,DrjSubLookupId,DrjLookupId desc,View_TblMaster1.EMP_NUM
  --order by  DrjSubLookupId,DrjLookupId desc, EMP_NUM

  --View_TblMaster1.EMP_NUM
  --   INNER JOIN 
  --dbo.CategoriesGeneral_Tbl AS CatTitleMeeting
  --ON CatTitleMeeting.CategoryGeneralId= MeetingDetailsEvidence01_Tbl.TitleMeeting



 --  TypeMeetingMeet = item.oo_MeetingDetailsEvidence01ID.oo_MeetingEvidence01ID.TypeMeeting,
 --TypeMeetingMeetstr = item.oo_MeetingDetailsEvidence01ID.oo_MeetingEvidence01ID.oo_TypeMeeting.Title,
 --TitleMeetingMeet = item.oo_MeetingDetailsEvidence01ID.oo_MeetingEvidence01ID.TitleMeeting,
 --TitleMeetingMeetstr = item.oo_MeetingDetailsEvidence01ID.oo_MeetingEvidence01ID.oo_TitleMeeting.Title,
 --PlaceMeetingMeet = item.oo_MeetingDetailsEvidence01ID.PlaceMeeting,
 --PlaceMeetingMeetstr = item.oo_MeetingDetailsEvidence01ID.oo_PlaceMeeting.Title,
 --StatusMeetingEvidence01Meet = item.oo_MeetingDetailsEvidence01ID.StatusMeetingDetailsEvidence01,
 --StatusMeetingEvidence01Meetstr = item.oo_MeetingDetailsEvidence01ID.oo_StatusMeetingDetailsEvidence01.Title,
 --ToDateMeetingEvidence01MeetTitle = item.oo_MeetingDetailsEvidence01ID.ToDateMeetingDetailsEvidence01Title,

