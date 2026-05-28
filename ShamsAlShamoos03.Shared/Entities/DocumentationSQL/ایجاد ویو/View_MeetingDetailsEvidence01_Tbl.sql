SELECT   [MeetingDetailsEvidence01ID]
          ,[FromDateMeetingDetailsEvidence01Title]
	 -- 		,MeetingDetailsEvidence01_Tbl.TypeMeeting  as 'TitleMeetingMeet'
		--,MeetingDetailsEvidence01_Tbl.PlaceMeeting  as 'PlaceMeetingMeet'
		--,CatPlaceMeeting.Title  as 'PlaceMeetingMeetstr'
			--,MeetingDetailsEvidence01_Tbl.FromDateMeetingDetailsEvidence01Title  as 'FromDateMeetingEvidence01TitleMeet'
		--,MeetingDetailsEvidence01_Tbl.FromDateMeetingDetailsEvidence01Title  as 'FromDateMeetingEvidence01TitleMeet'
		--,MeetingEvidence01_Tbl.TypeMeeting  as 'TypeMeetingMeet'    
		,[MeetingDetailsEvidence01_Tbl].[Sortable01Id]

		,CatTypeMeetingMeet.Title  as 'TypeMeetingMeetstr'
      --,[MeetingDetailsEvidence01_Tbl].[UjobPesronel01],[MeetingDetailsEvidence01_Tbl].[RegisterPesronel01]  
      --,[MeetingDetailsEvidence01_Tbl].[StatusConfirmation01]
      --,[MeetingDetailsEvidence01_Tbl].[UjobPesronel02]
      --,[MeetingDetailsEvidence01_Tbl].[StatusConfirmation02]
      --,[MeetingDetailsEvidence01_Tbl].[UjobPesronel03]
      --,[MeetingDetailsEvidence01_Tbl].[StatusConfirmation03]
      --,[MeetingDetailsEvidence01_Tbl].[UjobPesronel04]
      --,[MeetingDetailsEvidence01_Tbl].[StatusConfirmation04]
      --,[MeetingDetailsEvidence01_Tbl].[UjobPesronel05]
      --,[MeetingDetailsEvidence01_Tbl].[StatusConfirmation05]
      --,[MeetingDetailsEvidence01_Tbl].[UjobPesronel06]
      --,[MeetingDetailsEvidence01_Tbl].[StatusConfirmation06]
      --,[MeetingDetailsEvidence01_Tbl].[UjobPesronel07]
      --,[MeetingDetailsEvidence01_Tbl].[StatusConfirmation07]
      --,[MeetingDetailsEvidence01_Tbl].[UjobPesronel08]
      --,[MeetingDetailsEvidence01_Tbl].[StatusConfirmation08]
      --,[MeetingDetailsEvidence01_Tbl].[UjobPesronel09]
      --,[MeetingDetailsEvidence01_Tbl].[StatusConfirmation09]
      --,[MeetingDetailsEvidence01_Tbl].[UjobPesronel10]
      --,[MeetingDetailsEvidence01_Tbl].[StatusConfirmation10]
      --,[MeetingDetailsEvidence01_Tbl].[UjobPesronel11]
      --,[MeetingDetailsEvidence01_Tbl].[StatusConfirmation11]
      --,[MeetingDetailsEvidence01_Tbl].[UjobPesronel12]
      --,[MeetingDetailsEvidence01_Tbl].[StatusConfirmation12]
      --,[MeetingDetailsEvidence01_Tbl].[TypeMeeting]
      --,[MeetingDetailsEvidence01_Tbl].[TitleMeeting]
      --,[MeetingDetailsEvidence01_Tbl].[PlaceMeeting]
      --,[MeetingDetailsEvidence01_Tbl].[FLTAREANOTAMCHECK]
      --,[StatusMeetingDetailsEvidence01]
      --,[ToDateMeetingDetailsEvidence01Title]
      --,[MeetingDetailsEvidence01_Tbl].[NOTAMCHECKETitle01]
      --,[MeetingDetailsEvidence01_Tbl].[NOTAMCHECKETitle02]
      --,[MeetingDetailsEvidence01_Tbl].[NOTAMCHECKETitle03]
      --,[MeetingDetailsEvidence01_Tbl].[IsHaveJob]
      ,[MeetingDetailsEvidence01_Tbl].[MeetingEvidence01ID]
  FROM [NewsDB].[dbo].[MeetingDetailsEvidence01_Tbl]

  --     INNER JOIN 
  --dbo.CategoriesGeneral_Tbl AS CatPlaceMeeting 
  --ON CatPlaceMeeting.CategoryGeneralId= MeetingDetailsEvidence01_Tbl.PlaceMeeting
       --INNER JOIN 
  --dbo.MeetingDetailsEvidence01_Tbl AS MeetingDetailsEvidence01_Tbl 
  --ON  MeetingDetailsEvidence01_Tbl.MeetingDetailsEvidence01ID = [MeetingMembersEvidence01_Tbl].MeetingDetailsEvidence01ID
         INNER JOIN 
  dbo.MeetingEvidence01_Tbl AS MeetingEvidence01_Tbl 
  ON MeetingEvidence01_Tbl.MeetingEvidence01ID= MeetingDetailsEvidence01_Tbl.MeetingEvidence01ID

         INNER JOIN 
  dbo.CategoriesGeneral_Tbl AS CatTypeMeetingMeet
  ON CatTypeMeetingMeet.CategoryGeneralId= MeetingEvidence01_Tbl.TypeMeeting


  --where CatTypeMeetingMeet.Title like N'کلاس'
  where CatTypeMeetingMeet.Title like N'کمیسیون'
    order by  TypeMeetingMeetstr,[FromDateMeetingDetailsEvidence01Title]  
	,[MeetingDetailsEvidence01_Tbl].[Sortable01Id]


	--update [NewsDB].[dbo].[MeetingDetailsEvidence01_Tbl] set FromDateMeetingDetailsEvidence01Title ='' where MeetingDetailsEvidence01ID=''
	--update [NewsDB].[dbo].[MeetingDetailsEvidence01_Tbl] set FromDateMeetingDetailsEvidence01Title ='1403/12/20'where MeetingDetailsEvidence01ID='15d4bbb8-1147c-14b8b-1a1eb-11d37eddcd388'
