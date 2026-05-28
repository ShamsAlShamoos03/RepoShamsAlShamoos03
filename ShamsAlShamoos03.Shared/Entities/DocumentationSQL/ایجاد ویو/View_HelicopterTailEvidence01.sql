 SELECT   [HelicopterTailEvidence01ID]
      ,[Sortable01Id]
      
	   --[StatusHelicopterTailEvidence01]
	  ,CATStatus.[CategoryGeneralId] as [StatusHelicopterTailEvidence01]
      ,CATStatus.[Title] as TitleStatus
      ,CATStatus.[CategoryDescription] as [CategoryDescriptionStatus]
      ,CATStatus.[CategoryGeneralSubId] as [CategoryGeneralSubIdStatus]
      ,CATStatus.[CategoryIsActive] as [CategoryIsActiveStatus]
      ,CATStatus.[CategorySortableId] as [CategorySortableIdStatus]
      ,CATStatus.[ooCategoryGeneralSubId] as [ooCategoryGeneralSubIdStatus]
      ,CATStatus.[SubCategoryId] as [SubCategoryIdStatus]
      ,CATStatus.[SubCategoryTitle] as [SubCategoryTitleStatus]
      ,CATStatus.[SubCategoryDescription] as [SubCategoryDescriptionStatus]
      ,CATStatus.[SubCategoryIsActive] as [SubCategoryIsActiveStatus]
      ,CATStatus.[SubCategorySortableId] as [SubCategorySortableIdStatus]
      ,CATStatus.[OOSubCategoryId] as [OOSubCategoryIdStatus]
      ,CATStatus.[OOSubCategoryTitle] as [OOSubCategoryTitleStatus]
      ,CATStatus.[OOSubCategoryDescription] as [OOSubCategoryDescriptionStatus]
      ,CATStatus.[OOSubCategoryIsActive] as [OOSubCategoryIsActiveStatus]
      ,CATStatus.[OOSubCategorySortableId] as [OOSubCategorySortableIdStatus]
      ,CATStatus.[MainSortableId] as [MainSortableIdStatus]
      ,CATStatus.[MainSortableDescription] as [MainSortableDescriptionStatus]
      ,CATStatus.[SubSortableId] as [SubSortableIdStatus]
      ,CATStatus.[SubSortableDescription] as [SubSortableDescriptionStatus]
	  	   --[StatusHelicopterTailEvidence01]













      ,[IsHaveJob]
      ,[SeriakHelicopter]
      ,[TailHelicopter]

 	  	   --[TypeHelicopter]
	  ,CATTypeHelicopter.[CategoryGeneralId] as [TypeHelicopter]
      ,CATTypeHelicopter.[Title] as TitleTypeHelicopter
      ,CATTypeHelicopter.[CategoryDescription] as [CategoryDescriptionTypeHelicopter]
      ,CATTypeHelicopter.[CategoryGeneralSubId] as [CategoryGeneralSubIdTypeHelicopter]
      ,CATTypeHelicopter.[CategoryIsActive] as [CategoryIsActiveTypeHelicopter]
      ,CATTypeHelicopter.[CategorySortableId] as [CategorySortableIdTypeHelicopter]
      ,CATTypeHelicopter.[ooCategoryGeneralSubId] as [ooCategoryGeneralSubIdTypeHelicopter]
      ,CATTypeHelicopter.[SubCategoryId] as [SubCategoryIdTypeHelicopter]
      ,CATTypeHelicopter.[SubCategoryTitle] as [SubCategoryTitleTypeHelicopter]
      ,CATTypeHelicopter.[SubCategoryDescription] as [SubCategoryDescriptionTypeHelicopter]
      ,CATTypeHelicopter.[SubCategoryIsActive] as [SubCategoryIsActiveTypeHelicopter]
      ,CATTypeHelicopter.[SubCategorySortableId] as [SubCategorySortableIdTypeHelicopter]
      ,CATTypeHelicopter.[OOSubCategoryId] as [OOSubCategoryIdTypeHelicopter]
      ,CATTypeHelicopter.[OOSubCategoryTitle] as [OOSubCategoryTitleTypeHelicopter]
      ,CATTypeHelicopter.[OOSubCategoryDescription] as [OOSubCategoryDescriptionTypeHelicopter]
      ,CATTypeHelicopter.[OOSubCategoryIsActive] as [OOSubCategoryIsActiveTypeHelicopter]
      ,CATTypeHelicopter.[OOSubCategorySortableId] as [OOSubCategorySortableIdTypeHelicopter]
      ,CATTypeHelicopter.[MainSortableId] as [MainSortableIdTypeHelicopter]
      ,CATTypeHelicopter.[MainSortableDescription] as [MainSortableDescriptionTypeHelicopter]
      ,CATTypeHelicopter.[SubSortableId] as [SubSortableIdTypeHelicopter]
      ,CATTypeHelicopter.[SubSortableDescription] as [SubSortableDescriptionTypeHelicopter]
 	  	   --[TypeHelicopter]







       --[AIRCRAFTCOLOURANDMARKINGS]
 	  ,CATAIRCRAFTCOLOURANDMARKINGS.[CategoryGeneralId] as [AIRCRAFTCOLOURANDMARKINGS]
      ,CATAIRCRAFTCOLOURANDMARKINGS.[Title] as TitleAIRCRAFTCOLOURANDMARKINGS
      ,CATAIRCRAFTCOLOURANDMARKINGS.[CategoryDescription] as [CategoryDescriptionAIRCRAFTCOLOURANDMARKINGS]
      ,CATAIRCRAFTCOLOURANDMARKINGS.[CategoryGeneralSubId] as [CategoryGeneralSubIdAIRCRAFTCOLOURANDMARKINGS]
      ,CATAIRCRAFTCOLOURANDMARKINGS.[CategoryIsActive] as [CategoryIsActiveAIRCRAFTCOLOURANDMARKINGS]
      ,CATAIRCRAFTCOLOURANDMARKINGS.[CategorySortableId] as [CategorySortableIdAIRCRAFTCOLOURANDMARKINGS]
      ,CATAIRCRAFTCOLOURANDMARKINGS.[ooCategoryGeneralSubId] as [ooCategoryGeneralSubIdAIRCRAFTCOLOURANDMARKINGS]
      ,CATAIRCRAFTCOLOURANDMARKINGS.[SubCategoryId] as [SubCategoryIdAIRCRAFTCOLOURANDMARKINGS]
      ,CATAIRCRAFTCOLOURANDMARKINGS.[SubCategoryTitle] as [SubCategoryTitleAIRCRAFTCOLOURANDMARKINGS]
      ,CATAIRCRAFTCOLOURANDMARKINGS.[SubCategoryDescription] as [SubCategoryDescriptionAIRCRAFTCOLOURANDMARKINGS]
      ,CATAIRCRAFTCOLOURANDMARKINGS.[SubCategoryIsActive] as [SubCategoryIsActiveAIRCRAFTCOLOURANDMARKINGS]
      ,CATAIRCRAFTCOLOURANDMARKINGS.[SubCategorySortableId] as [SubCategorySortableIdAIRCRAFTCOLOURANDMARKINGS]
      ,CATAIRCRAFTCOLOURANDMARKINGS.[OOSubCategoryId] as [OOSubCategoryIdAIRCRAFTCOLOURANDMARKINGS]
      ,CATAIRCRAFTCOLOURANDMARKINGS.[OOSubCategoryTitle] as [OOSubCategoryTitleAIRCRAFTCOLOURANDMARKINGS]
      ,CATAIRCRAFTCOLOURANDMARKINGS.[OOSubCategoryDescription] as [OOSubCategoryDescriptionAIRCRAFTCOLOURANDMARKINGS]
      ,CATAIRCRAFTCOLOURANDMARKINGS.[OOSubCategoryIsActive] as [OOSubCategoryIsActiveAIRCRAFTCOLOURANDMARKINGS]
      ,CATAIRCRAFTCOLOURANDMARKINGS.[OOSubCategorySortableId] as [OOSubCategorySortableIdAIRCRAFTCOLOURANDMARKINGS]
      ,CATAIRCRAFTCOLOURANDMARKINGS.[MainSortableId] as [MainSortableIdAIRCRAFTCOLOURANDMARKINGS]
      ,CATAIRCRAFTCOLOURANDMARKINGS.[MainSortableDescription] as [MainSortableDescriptionAIRCRAFTCOLOURANDMARKINGS]
      ,CATAIRCRAFTCOLOURANDMARKINGS.[SubSortableId] as [SubSortableIdAIRCRAFTCOLOURANDMARKINGS]
      ,CATAIRCRAFTCOLOURANDMARKINGS.[SubSortableDescription] as [SubSortableDescriptionAIRCRAFTCOLOURANDMARKINGS]
       --[AIRCRAFTCOLOURANDMARKINGS]


      
	  --[CRUISINGSPEED]
       ,CATCRUISINGSPEED.[CategoryGeneralId] as CRUISINGSPEED
      ,CATCRUISINGSPEED.[Title] as TitleCRUISINGSPEED
      ,CATCRUISINGSPEED.[CategoryDescription] as [CategoryDescriptionCRUISINGSPEED]
      ,CATCRUISINGSPEED.[CategoryGeneralSubId] as [CategoryGeneralSubIdCRUISINGSPEED]
      ,CATCRUISINGSPEED.[CategoryIsActive] as [CategoryIsActiveCRUISINGSPEED]
      ,CATCRUISINGSPEED.[CategorySortableId] as [CategorySortableIdCRUISINGSPEED]
      ,CATCRUISINGSPEED.[ooCategoryGeneralSubId] as [ooCategoryGeneralSubIdCRUISINGSPEED]
      ,CATCRUISINGSPEED.[SubCategoryId] as [SubCategoryIdCRUISINGSPEED]
      ,CATCRUISINGSPEED.[SubCategoryTitle] as [SubCategoryTitleCRUISINGSPEED]
      ,CATCRUISINGSPEED.[SubCategoryDescription] as [SubCategoryDescriptionCRUISINGSPEED]
      ,CATCRUISINGSPEED.[SubCategoryIsActive] as [SubCategoryIsActiveCRUISINGSPEED]
      ,CATCRUISINGSPEED.[SubCategorySortableId] as [SubCategorySortableIdCRUISINGSPEED]
      ,CATCRUISINGSPEED.[OOSubCategoryId] as [OOSubCategoryIdCRUISINGSPEED]
      ,CATCRUISINGSPEED.[OOSubCategoryTitle] as [OOSubCategoryTitleCRUISINGSPEED]
      ,CATCRUISINGSPEED.[OOSubCategoryDescription] as [OOSubCategoryDescriptionCRUISINGSPEED]
      ,CATCRUISINGSPEED.[OOSubCategoryIsActive] as [OOSubCategoryIsActiveCRUISINGSPEED]
      ,CATCRUISINGSPEED.[OOSubCategorySortableId] as [OOSubCategorySortableIdCRUISINGSPEED]
      ,CATCRUISINGSPEED.[MainSortableId] as [MainSortableIdCRUISINGSPEED]
      ,CATCRUISINGSPEED.[MainSortableDescription] as [MainSortableDescriptionCRUISINGSPEED]
      ,CATCRUISINGSPEED.[SubSortableId] as [SubSortableIdCRUISINGSPEED]
      ,CATCRUISINGSPEED.[SubSortableDescription] as [SubSortableDescriptionCRUISINGSPEED]
	  --[CRUISINGSPEED]




       --[EMERGENCYRADIO]
	   	  ,CATEMERGENCYRADIO.[CategoryGeneralId] as [EMERGENCYRADIO]
      ,CATEMERGENCYRADIO.[Title] as TitleEMERGENCYRADIO
      ,CATEMERGENCYRADIO.[CategoryDescription] as [CategoryDescriptionEMERGENCYRADIO]
      ,CATEMERGENCYRADIO.[CategoryGeneralSubId] as [CategoryGeneralSubIdEMERGENCYRADIO]
      ,CATEMERGENCYRADIO.[CategoryIsActive] as [CategoryIsActiveEMERGENCYRADIO]
      ,CATEMERGENCYRADIO.[CategorySortableId] as [CategorySortableIdEMERGENCYRADIO]
      ,CATEMERGENCYRADIO.[ooCategoryGeneralSubId] as [ooCategoryGeneralSubIdEMERGENCYRADIO]
      ,CATEMERGENCYRADIO.[SubCategoryId] as [SubCategoryIdEMERGENCYRADIO]
      ,CATEMERGENCYRADIO.[SubCategoryTitle] as [SubCategoryTitleEMERGENCYRADIO]
      ,CATEMERGENCYRADIO.[SubCategoryDescription] as [SubCategoryDescriptionEMERGENCYRADIO]
      ,CATEMERGENCYRADIO.[SubCategoryIsActive] as [SubCategoryIsActiveEMERGENCYRADIO]
      ,CATEMERGENCYRADIO.[SubCategorySortableId] as [SubCategorySortableIdEMERGENCYRADIO]
      ,CATEMERGENCYRADIO.[OOSubCategoryId] as [OOSubCategoryIdEMERGENCYRADIO]
      ,CATEMERGENCYRADIO.[OOSubCategoryTitle] as [OOSubCategoryTitleEMERGENCYRADIO]
      ,CATEMERGENCYRADIO.[OOSubCategoryDescription] as [OOSubCategoryDescriptionEMERGENCYRADIO]
      ,CATEMERGENCYRADIO.[OOSubCategoryIsActive] as [OOSubCategoryIsActiveEMERGENCYRADIO]
      ,CATEMERGENCYRADIO.[OOSubCategorySortableId] as [OOSubCategorySortableIdEMERGENCYRADIO]
      ,CATEMERGENCYRADIO.[MainSortableId] as [MainSortableIdEMERGENCYRADIO]
      ,CATEMERGENCYRADIO.[MainSortableDescription] as [MainSortableDescriptionEMERGENCYRADIO]
      ,CATEMERGENCYRADIO.[SubSortableId] as [SubSortableIdEMERGENCYRADIO]
      ,CATEMERGENCYRADIO.[SubSortableDescription] as [SubSortableDescriptionEMERGENCYRADIO]


       --[EMERGENCYRADIO]




       --[ENDURANCEHRMIN]

		  ,CATENDURANCEHRMIN.[CategoryGeneralId] as [ENDURANCEHRMIN]
      ,CATENDURANCEHRMIN.[Title] as TitleENDURANCEHRMIN
      ,CATENDURANCEHRMIN.[CategoryDescription] as [CategoryDescriptionENDURANCEHRMIN]
      ,CATENDURANCEHRMIN.[CategoryGeneralSubId] as [CategoryGeneralSubIdENDURANCEHRMIN]
      ,CATENDURANCEHRMIN.[CategoryIsActive] as [CategoryIsActiveENDURANCEHRMIN]
      ,CATENDURANCEHRMIN.[CategorySortableId] as [CategorySortableIdENDURANCEHRMIN]
      ,CATENDURANCEHRMIN.[ooCategoryGeneralSubId] as [ooCategoryGeneralSubIdENDURANCEHRMIN]
      ,CATENDURANCEHRMIN.[SubCategoryId] as [SubCategoryIdENDURANCEHRMIN]
      ,CATENDURANCEHRMIN.[SubCategoryTitle] as [SubCategoryTitleENDURANCEHRMIN]
      ,CATENDURANCEHRMIN.[SubCategoryDescription] as [SubCategoryDescriptionENDURANCEHRMIN]
      ,CATENDURANCEHRMIN.[SubCategoryIsActive] as [SubCategoryIsActiveENDURANCEHRMIN]
      ,CATENDURANCEHRMIN.[SubCategorySortableId] as [SubCategorySortableIdENDURANCEHRMIN]
      ,CATENDURANCEHRMIN.[OOSubCategoryId] as [OOSubCategoryIdENDURANCEHRMIN]
      ,CATENDURANCEHRMIN.[OOSubCategoryTitle] as [OOSubCategoryTitleENDURANCEHRMIN]
      ,CATENDURANCEHRMIN.[OOSubCategoryDescription] as [OOSubCategoryDescriptionENDURANCEHRMIN]
      ,CATENDURANCEHRMIN.[OOSubCategoryIsActive] as [OOSubCategoryIsActiveENDURANCEHRMIN]
      ,CATENDURANCEHRMIN.[OOSubCategorySortableId] as [OOSubCategorySortableIdENDURANCEHRMIN]
      ,CATENDURANCEHRMIN.[MainSortableId] as [MainSortableIdENDURANCEHRMIN]
      ,CATENDURANCEHRMIN.[MainSortableDescription] as [MainSortableDescriptionENDURANCEHRMIN]
      ,CATENDURANCEHRMIN.[SubSortableId] as [SubSortableIdENDURANCEHRMIN]
      ,CATENDURANCEHRMIN.[SubSortableDescription] as [SubSortableDescriptionENDURANCEHRMIN]

	   --[ENDURANCEHRMIN]



       --[EQUIPMENTANDCAPABILITIES]
	   	  ,CATEQUIPMENTANDCAPABILITIES.[CategoryGeneralId] as [EQUIPMENTANDCAPABILITIES]
      ,CATEQUIPMENTANDCAPABILITIES.[Title] as TitleEQUIPMENTANDCAPABILITIES
      ,CATEQUIPMENTANDCAPABILITIES.[CategoryDescription] as [CategoryDescriptionEQUIPMENTANDCAPABILITIES]
      ,CATEQUIPMENTANDCAPABILITIES.[CategoryGeneralSubId] as [CategoryGeneralSubIdEQUIPMENTANDCAPABILITIES]
      ,CATEQUIPMENTANDCAPABILITIES.[CategoryIsActive] as [CategoryIsActiveEQUIPMENTANDCAPABILITIES]
      ,CATEQUIPMENTANDCAPABILITIES.[CategorySortableId] as [CategorySortableIdEQUIPMENTANDCAPABILITIES]
      ,CATEQUIPMENTANDCAPABILITIES.[ooCategoryGeneralSubId] as [ooCategoryGeneralSubIdEQUIPMENTANDCAPABILITIES]
      ,CATEQUIPMENTANDCAPABILITIES.[SubCategoryId] as [SubCategoryIdEQUIPMENTANDCAPABILITIES]
      ,CATEQUIPMENTANDCAPABILITIES.[SubCategoryTitle] as [SubCategoryTitleEQUIPMENTANDCAPABILITIES]
      ,CATEQUIPMENTANDCAPABILITIES.[SubCategoryDescription] as [SubCategoryDescriptionEQUIPMENTANDCAPABILITIES]
      ,CATEQUIPMENTANDCAPABILITIES.[SubCategoryIsActive] as [SubCategoryIsActiveEQUIPMENTANDCAPABILITIES]
      ,CATEQUIPMENTANDCAPABILITIES.[SubCategorySortableId] as [SubCategorySortableIdEQUIPMENTANDCAPABILITIES]
      ,CATEQUIPMENTANDCAPABILITIES.[OOSubCategoryId] as [OOSubCategoryIdEQUIPMENTANDCAPABILITIES]
      ,CATEQUIPMENTANDCAPABILITIES.[OOSubCategoryTitle] as [OOSubCategoryTitleEQUIPMENTANDCAPABILITIES]
      ,CATEQUIPMENTANDCAPABILITIES.[OOSubCategoryDescription] as [OOSubCategoryDescriptionEQUIPMENTANDCAPABILITIES]
      ,CATEQUIPMENTANDCAPABILITIES.[OOSubCategoryIsActive] as [OOSubCategoryIsActiveEQUIPMENTANDCAPABILITIES]
      ,CATEQUIPMENTANDCAPABILITIES.[OOSubCategorySortableId] as [OOSubCategorySortableIdEQUIPMENTANDCAPABILITIES]
      ,CATEQUIPMENTANDCAPABILITIES.[MainSortableId] as [MainSortableIdEQUIPMENTANDCAPABILITIES]
      ,CATEQUIPMENTANDCAPABILITIES.[MainSortableDescription] as [MainSortableDescriptionEQUIPMENTANDCAPABILITIES]
      ,CATEQUIPMENTANDCAPABILITIES.[SubSortableId] as [SubSortableIdEQUIPMENTANDCAPABILITIES]
      ,CATEQUIPMENTANDCAPABILITIES.[SubSortableDescription] as [SubSortableDescriptionEQUIPMENTANDCAPABILITIES]

       --[EQUIPMENTANDCAPABILITIES]




       --[FLIGHTROLES]
	   	  ,CATFLIGHTROLES.[CategoryGeneralId] as [FLIGHTROLES]
      ,CATFLIGHTROLES.[Title] as TitleFLIGHTROLES
      ,CATFLIGHTROLES.[CategoryDescription] as [CategoryDescriptionFLIGHTROLES]
      ,CATFLIGHTROLES.[CategoryGeneralSubId] as [CategoryGeneralSubIdFLIGHTROLES]
      ,CATFLIGHTROLES.[CategoryIsActive] as [CategoryIsActiveFLIGHTROLES]
      ,CATFLIGHTROLES.[CategorySortableId] as [CategorySortableIdFLIGHTROLES]
      ,CATFLIGHTROLES.[ooCategoryGeneralSubId] as [ooCategoryGeneralSubIdFLIGHTROLES]
      ,CATFLIGHTROLES.[SubCategoryId] as [SubCategoryIdFLIGHTROLES]
      ,CATFLIGHTROLES.[SubCategoryTitle] as [SubCategoryTitleFLIGHTROLES]
      ,CATFLIGHTROLES.[SubCategoryDescription] as [SubCategoryDescriptionFLIGHTROLES]
      ,CATFLIGHTROLES.[SubCategoryIsActive] as [SubCategoryIsActiveFLIGHTROLES]
      ,CATFLIGHTROLES.[SubCategorySortableId] as [SubCategorySortableIdFLIGHTROLES]
      ,CATFLIGHTROLES.[OOSubCategoryId] as [OOSubCategoryIdFLIGHTROLES]
      ,CATFLIGHTROLES.[OOSubCategoryTitle] as [OOSubCategoryTitleFLIGHTROLES]
      ,CATFLIGHTROLES.[OOSubCategoryDescription] as [OOSubCategoryDescriptionFLIGHTROLES]
      ,CATFLIGHTROLES.[OOSubCategoryIsActive] as [OOSubCategoryIsActiveFLIGHTROLES]
      ,CATFLIGHTROLES.[OOSubCategorySortableId] as [OOSubCategorySortableIdFLIGHTROLES]
      ,CATFLIGHTROLES.[MainSortableId] as [MainSortableIdFLIGHTROLES]
      ,CATFLIGHTROLES.[MainSortableDescription] as [MainSortableDescriptionFLIGHTROLES]
      ,CATFLIGHTROLES.[SubSortableId] as [SubSortableIdFLIGHTROLES]
      ,CATFLIGHTROLES.[SubSortableDescription] as [SubSortableDescriptionFLIGHTROLES]

       --[FLIGHTROLES]





       --[TYPEOFFLIGHT]
	   	  ,CATTYPEOFFLIGHT.[CategoryGeneralId] as [TYPEOFFLIGHT]
      ,CATTYPEOFFLIGHT.[Title] as TitleTYPEOFFLIGHT
      ,CATTYPEOFFLIGHT.[CategoryDescription] as [CategoryDescriptionTYPEOFFLIGHT]
      ,CATTYPEOFFLIGHT.[CategoryGeneralSubId] as [CategoryGeneralSubIdTYPEOFFLIGHT]
      ,CATTYPEOFFLIGHT.[CategoryIsActive] as [CategoryIsActiveTYPEOFFLIGHT]
      ,CATTYPEOFFLIGHT.[CategorySortableId] as [CategorySortableIdTYPEOFFLIGHT]
      ,CATTYPEOFFLIGHT.[ooCategoryGeneralSubId] as [ooCategoryGeneralSubIdTYPEOFFLIGHT]
      ,CATTYPEOFFLIGHT.[SubCategoryId] as [SubCategoryIdTYPEOFFLIGHT]
      ,CATTYPEOFFLIGHT.[SubCategoryTitle] as [SubCategoryTitleTYPEOFFLIGHT]
      ,CATTYPEOFFLIGHT.[SubCategoryDescription] as [SubCategoryDescriptionTYPEOFFLIGHT]
      ,CATTYPEOFFLIGHT.[SubCategoryIsActive] as [SubCategoryIsActiveTYPEOFFLIGHT]
      ,CATTYPEOFFLIGHT.[SubCategorySortableId] as [SubCategorySortableIdTYPEOFFLIGHT]
      ,CATTYPEOFFLIGHT.[OOSubCategoryId] as [OOSubCategoryIdTYPEOFFLIGHT]
      ,CATTYPEOFFLIGHT.[OOSubCategoryTitle] as [OOSubCategoryTitleTYPEOFFLIGHT]
      ,CATTYPEOFFLIGHT.[OOSubCategoryDescription] as [OOSubCategoryDescriptionTYPEOFFLIGHT]
      ,CATTYPEOFFLIGHT.[OOSubCategoryIsActive] as [OOSubCategoryIsActiveTYPEOFFLIGHT]
      ,CATTYPEOFFLIGHT.[OOSubCategorySortableId] as [OOSubCategorySortableIdTYPEOFFLIGHT]
      ,CATTYPEOFFLIGHT.[MainSortableId] as [MainSortableIdTYPEOFFLIGHT]
      ,CATTYPEOFFLIGHT.[MainSortableDescription] as [MainSortableDescriptionTYPEOFFLIGHT]
      ,CATTYPEOFFLIGHT.[SubSortableId] as [SubSortableIdTYPEOFFLIGHT]
      ,CATTYPEOFFLIGHT.[SubSortableDescription] as [SubSortableDescriptionTYPEOFFLIGHT]

       --[TYPEOFFLIGHT]




       --[WAKETURBULENCECAL]
	   	  ,CATWAKETURBULENCECAL.[CategoryGeneralId] as [WAKETURBULENCECAL]
      ,CATWAKETURBULENCECAL.[Title] as TitleWAKETURBULENCECAL
      ,CATWAKETURBULENCECAL.[CategoryDescription] as [CategoryDescriptionWAKETURBULENCECAL]
      ,CATWAKETURBULENCECAL.[CategoryGeneralSubId] as [CategoryGeneralSubIdWAKETURBULENCECAL]
      ,CATWAKETURBULENCECAL.[CategoryIsActive] as [CategoryIsActiveWAKETURBULENCECAL]
      ,CATWAKETURBULENCECAL.[CategorySortableId] as [CategorySortableIdWAKETURBULENCECAL]
      ,CATWAKETURBULENCECAL.[ooCategoryGeneralSubId] as [ooCategoryGeneralSubIdWAKETURBULENCECAL]
      ,CATWAKETURBULENCECAL.[SubCategoryId] as [SubCategoryIdWAKETURBULENCECAL]
      ,CATWAKETURBULENCECAL.[SubCategoryTitle] as [SubCategoryTitleWAKETURBULENCECAL]
      ,CATWAKETURBULENCECAL.[SubCategoryDescription] as [SubCategoryDescriptionWAKETURBULENCECAL]
      ,CATWAKETURBULENCECAL.[SubCategoryIsActive] as [SubCategoryIsActiveWAKETURBULENCECAL]
      ,CATWAKETURBULENCECAL.[SubCategorySortableId] as [SubCategorySortableIdWAKETURBULENCECAL]
      ,CATWAKETURBULENCECAL.[OOSubCategoryId] as [OOSubCategoryIdWAKETURBULENCECAL]
      ,CATWAKETURBULENCECAL.[OOSubCategoryTitle] as [OOSubCategoryTitleWAKETURBULENCECAL]
      ,CATWAKETURBULENCECAL.[OOSubCategoryDescription] as [OOSubCategoryDescriptionWAKETURBULENCECAL]
      ,CATWAKETURBULENCECAL.[OOSubCategoryIsActive] as [OOSubCategoryIsActiveWAKETURBULENCECAL]
      ,CATWAKETURBULENCECAL.[OOSubCategorySortableId] as [OOSubCategorySortableIdWAKETURBULENCECAL]
      ,CATWAKETURBULENCECAL.[MainSortableId] as [MainSortableIdWAKETURBULENCECAL]
      ,CATWAKETURBULENCECAL.[MainSortableDescription] as [MainSortableDescriptionWAKETURBULENCECAL]
      ,CATWAKETURBULENCECAL.[SubSortableId] as [SubSortableIdWAKETURBULENCECAL]
      ,CATWAKETURBULENCECAL.[SubSortableDescription] as [SubSortableDescriptionWAKETURBULENCECAL]

       --[WAKETURBULENCECAL]




       --[UnitID01]
	   	  ,CATUnitID01.[CategoryGeneralId] as [UnitID01]
      ,CATUnitID01.[Title] as TitleUnitID01
      ,CATUnitID01.[CategoryDescription] as [CategoryDescriptionUnitID01]
      ,CATUnitID01.[CategoryGeneralSubId] as [CategoryGeneralSubIdUnitID01]
      ,CATUnitID01.[CategoryIsActive] as [CategoryIsActiveUnitID01]
      ,CATUnitID01.[CategorySortableId] as [CategorySortableIdUnitID01]
      ,CATUnitID01.[ooCategoryGeneralSubId] as [ooCategoryGeneralSubIdUnitID01]
      ,CATUnitID01.[SubCategoryId] as [SubCategoryIdUnitID01]
      ,CATUnitID01.[SubCategoryTitle] as [SubCategoryTitleUnitID01]
      ,CATUnitID01.[SubCategoryDescription] as [SubCategoryDescriptionUnitID01]
      ,CATUnitID01.[SubCategoryIsActive] as [SubCategoryIsActiveUnitID01]
      ,CATUnitID01.[SubCategorySortableId] as [SubCategorySortableIdUnitID01]
      ,CATUnitID01.[OOSubCategoryId] as [OOSubCategoryIdUnitID01]
      ,CATUnitID01.[OOSubCategoryTitle] as [OOSubCategoryTitleUnitID01]
      ,CATUnitID01.[OOSubCategoryDescription] as [OOSubCategoryDescriptionUnitID01]
      ,CATUnitID01.[OOSubCategoryIsActive] as [OOSubCategoryIsActiveUnitID01]
      ,CATUnitID01.[OOSubCategorySortableId] as [OOSubCategorySortableIdUnitID01]
      ,CATUnitID01.[MainSortableId] as [MainSortableIdUnitID01]
      ,CATUnitID01.[MainSortableDescription] as [MainSortableDescriptionUnitID01]
      ,CATUnitID01.[SubSortableId] as [SubSortableIdUnitID01]
      ,CATUnitID01.[SubSortableDescription] as [SubSortableDescriptionUnitID01]

       --[UnitID01]





  FROM  [dbo].[HelicopterTailEvidence01_Tbl]


  LEFT JOIN 
    dbo.View_CategoriesGeneral_Tbl CATStatus 
    ON CATStatus.CategoryGeneralId = [HelicopterTailEvidence01_Tbl].StatusHelicopterTailEvidence01
  
  LEFT JOIN 
    dbo.View_CategoriesGeneral_Tbl CATTypeHelicopter 
    ON CATTypeHelicopter.CategoryGeneralId = [HelicopterTailEvidence01_Tbl].[TypeHelicopter]



	  LEFT JOIN 
    dbo.View_CategoriesGeneral_Tbl CATAIRCRAFTCOLOURANDMARKINGS 
    ON CATAIRCRAFTCOLOURANDMARKINGS.CategoryGeneralId = [HelicopterTailEvidence01_Tbl].AIRCRAFTCOLOURANDMARKINGS

	  LEFT JOIN 
      dbo.View_CategoriesGeneral_Tbl CATCRUISINGSPEED 
    ON CATCRUISINGSPEED.CategoryGeneralId = [HelicopterTailEvidence01_Tbl].CRUISINGSPEED
  
    LEFT JOIN 
    dbo.View_CategoriesGeneral_Tbl CATEMERGENCYRADIO 
    ON CATEMERGENCYRADIO.CategoryGeneralId = [HelicopterTailEvidence01_Tbl].EMERGENCYRADIO



	  LEFT JOIN 
    dbo.View_CategoriesGeneral_Tbl CATENDURANCEHRMIN 
    ON CATENDURANCEHRMIN.CategoryGeneralId = [HelicopterTailEvidence01_Tbl].ENDURANCEHRMIN







	
  LEFT JOIN 
    dbo.View_CategoriesGeneral_Tbl CATEQUIPMENTANDCAPABILITIES 
    ON CATEQUIPMENTANDCAPABILITIES.CategoryGeneralId = [HelicopterTailEvidence01_Tbl].EQUIPMENTANDCAPABILITIES
	
  LEFT JOIN 
    dbo.View_CategoriesGeneral_Tbl CATFLIGHTROLES 
    ON CATFLIGHTROLES.CategoryGeneralId = [HelicopterTailEvidence01_Tbl].FLIGHTROLES
	
  LEFT JOIN 
    dbo.View_CategoriesGeneral_Tbl CATTYPEOFFLIGHT 
    ON CATTYPEOFFLIGHT.CategoryGeneralId = [HelicopterTailEvidence01_Tbl].TYPEOFFLIGHT
	
  LEFT JOIN 
    dbo.View_CategoriesGeneral_Tbl CATWAKETURBULENCECAL 
    ON CATWAKETURBULENCECAL.CategoryGeneralId = [HelicopterTailEvidence01_Tbl].WAKETURBULENCECAL
	
  LEFT JOIN 
    dbo.View_CategoriesGeneral_Tbl CATUnitID01 
    ON CATUnitID01.CategoryGeneralId = [HelicopterTailEvidence01_Tbl].UnitID01
	
 