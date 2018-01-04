using GTA;
using GTA.Native;
using GTA.Math;
using System;
using System.Windows.Forms;
using System.Collections.Generic;

public class OnlineInteriors : Script
{
	ScriptSettings IniSettings;
	bool EnableBlips;
	bool LongRangeBlips;
	int HeistYachtBlipColor;
	int AircraftCarrierBlipColor;
	int SmallWarehouseBlipColor;
	int MedWarehouseBlipColor;
	int LargeWarehouseBlipColor;
	int MBTOfficeBlipColor;
	int MethWarehouseBlipColor;
	int WeedWarehouseBlipColor;
	int CokeWarehouseBlipColor;
	int DocsForgeriesWarehouseBlipColor;
    int CashWarehouseBlipColor;
	int ClubhouseBlipColor;
	int TwoFloorClubhouseBlipColor;
	int CarWarehouseBlipColor;
	int BunkerBlipColor;
	int GunrunningYachtBlipColor;
	int HangarBlipColor;
	int FacilityBlipColor;
	int ServerFarmBlipColor;
	int SatelliteFacilityBlipColor;
	int SubmarineBlipColor;
	int ChiliadFacilityBlipColor;
	bool LoadBunkerHatches;
	bool LoadFacilityHatches;
	string MBTCarGarageA;
	string MBTCarGarageB;
	string MBTCarGarageC;
	string Bunker;
	string Hangar;
    string MBTOfficeBooze;
	string MBTOfficeCashProps1;
	string MBTOfficeCashProps2;
	string MBTOfficeCashProps3;
	string MBTOfficeCashProps4;
	string MBTOfficeCashProps5;
	string MBTOfficeCashProps6;
	string MBTOfficeCashProps7;
	string MBTOfficeCashProps8;
	string MBTOfficeCashProps9;
	string MBTOfficeCashProps10;
	string MBTOfficeCashProps11;
	string MBTOfficeCashProps12;
	string MBTOfficeCashProps13;
	string MBTOfficeCashProps14;
	string MBTOfficeCashProps15;
	string MBTOfficeCashProps16;
	string MBTOfficeCashProps17;
	string MBTOfficeCashProps18;
	string MBTOfficeCashProps19;
	string MBTOfficeCashProps20;
	string MBTOfficeCashProps21;
	string MBTOfficeCashProps22;
	string MBTOfficeCashProps23;
	string MBTOfficeCashProps24;
    string MBTOfficeSilverProps1;
	string MBTOfficeSilverProps2;
	string MBTOfficeSilverProps3;
	string MBTOfficeDrugBags1;
	string MBTOfficeDrugBags2;
	string MBTOfficeDrugBags3;
	string MBTOfficeCigsProps1;
	string MBTOfficeCigsProps2;
    string MBTOfficeCigsProps3;	
	string MBTOfficeElectronicProps1;
	string MBTOfficeElectronicProps2;
	string MBTOfficeElectronicProps3;
	string MBTOfficeDrugStatue1;
	string MBTOfficeDrugStatue2;
	string MBTOfficeDrugStatue3;
	string MBTOfficeIvoryProps1;
	string MBTOfficeIvoryProps2;
	string MBTOfficeIvoryProps3;
	string MBTOfficePillsProps1;
	string MBTOfficePillsProps2;
	string MBTOfficePillsProps3;
	string MBTOfficeJewelWatchProps1;
	string MBTOfficeJewelWatchProps2;
	string MBTOfficeJewelWatchProps3;
	string MBTOfficeFurCoats1;
	string MBTOfficeFurCoats2;
	string MBTOfficeFurCoats3;
	string MBTOfficeArtProps1;
	string MBTOfficeArtProps2;
	string MBTOfficeArtProps3;
	string MBTOfficeGuns1;
	string MBTOfficeGuns2;
	string MBTOfficeGuns3;
	string MBTOfficeMedProps1;
	string MBTOfficeMedProps2;
	string MBTOfficeMedProps3;
	string MBTOfficeGemProps1;
	string MBTOfficeGemProps2;
	string MBTOfficeGemProps3;
	string MBTOfficeCounterfeitProps1;
	string MBTOfficeCounterfeitProps2;
	string MBTOfficeCounterfeitProps3;
	string MBTCarGarageADecor;
	string MBTCarGarageBDecor;
	string MBTCarGarageCDecor;
	string MBTCarGarageALighting;
	string MBTCarGarageBLighting;
	string MBTCarGarageCLighting;
	string MBTCarGarageANumberingStyle;
	string MBTCarGarageBNumberingStyle;
	string MBTCarGarageCNumberingStyle;
	string MBTModGarageFloorDecal;
    string CarWarehouseStyle;
	string FloorHatch;
	string Pump1;
	string Pump2;
	string Pump3;
	string Pump4;
	string Pump5;
	string Pump6;
	string Pump7;
	string Pump8;
    string BunkerStyle;
	string BunkerSet;
	string BunkerSet2;
	string BunkerSecuritySet;
    string HangarLighting;
    string HangarFloor;
    string HangarFloorDecal;
    string HangarBedroom;
	string HangarOffice;
	string HangarBedroomBlinds;
	string HangarLightingWallTint;
	string HangarNeutralLighting;
	bool EnableHangar;
	int HangarFloorDecalColor;
	int HangarShellColor;
	int HangarBedroomColor;
	int HangarCraneColor;
	int HangarWorkshopColor;
	int HangarLightingTintPropsColor;
	string FacilityGraphic;
	string FacilityOrbitalCannon;
	string FacilitySecurityRoom;
	string FacilityLounge;
	string FacilitySleepingQuarters;
	int FacilityShellColor;
	int FacilityGraphicColor;
	int FacilityOrbitalCannonColor;
	int FacilitySecurityRoomColor;
	int FacilityLoungeColor;
	int FacilitySleepingQuartersColor;
	bool isShipCamNeeded = false;
	
    Vector3 AircraftCarrierPos = new Vector3(3050.70f, -4690.60f, 1f);
	Vector3 HeistYachtPos = new Vector3(-2068.90f, -1023.45f, 2.58f);
	Vector3 GunrunningYachtPos = new Vector3(-1415.90f, 6750.95f, 2.58f);
	Vector3 PlayerYachtPos1 = new Vector3(-1605.074f, -1872.468f, 5.42997f);
	Vector3 PlayerYachtPos2 = new Vector3(-1995.725f, -1523.694f, 5.429955f);
	Vector3 PlayerYachtPos3 = new Vector3(-2697.862f, -540.6123f, 5.42997f);
	Vector3 PlayerYachtPos4 = new Vector3(-3205.344f, -219.0104f, 5.42997f);
	Vector3 PlayerYachtPos5 = new Vector3(-3448.254f, 311.5018f, 5.42997f);
	Vector3 PlayerYachtPos6 = new Vector3(-3542.822f, 1488.25f, 5.42997f);
	Vector3 PlayerYachtPos7 = new Vector3(-3280.501f, 2140.507f, 5.42997f);
	Vector3 PlayerYachtPos8 = new Vector3(-3148.379f, 2807.555f, 5.42997f);
	Vector3 PlayerYachtPos9 = new Vector3(-3254.552f, 3685.677f, 5.42997f);
	Vector3 PlayerYachtPos10 = new Vector3(-2814.49f, 4072.74f, 5.42997f);
	Vector3 PlayerYachtPos11 = new Vector3(-2368.441f, 4697.874f, 5.42997f);
	Vector3 PlayerYachtPos12 = new Vector3(-1170.69f, 5980.682f, 5.42997f);
	Vector3 PlayerYachtPos13 = new Vector3(-777.4865f, 6566.907f, 5.42997f);
	Vector3 PlayerYachtPos14 = new Vector3(-381.7739f, 6946.96f, 5.42997f);
	Vector3 PlayerYachtPos15 = new Vector3(581.5955f, 7124.558f, 5.42997f);
	Vector3 PlayerYachtPos16 = new Vector3(1396.638f, 6860.203f, 5.42997f);
	Vector3 PlayerYachtPos17 = new Vector3(2004.462f, 6907.157f, 5.429955f);
	Vector3 PlayerYachtPos18 = new Vector3(3490.105f, 6305.785f, 5.42997f);
	Vector3 PlayerYachtPos19 = new Vector3(3751.681f, 5753.501f, 5.42997f);
	Vector3 PlayerYachtPos20 = new Vector3(3684.853f, 5212.238f, 5.42997f);
	Vector3 PlayerYachtPos21 = new Vector3(4250.581f, 4576.565f, 5.42997f);
	Vector3 PlayerYachtPos22 = new Vector3(4225.028f, 3988.002f, 5.42997f);
	Vector3 PlayerYachtPos23 = new Vector3(4204.355f, 3373.7f, 5.42997f);
	Vector3 PlayerYachtPos24 = new Vector3(3784.802f, 2548.541f, 5.42997f);
	Vector3 PlayerYachtPos25 = new Vector3(3404.51f, 1977.044f, 5.42997f);
	Vector3 PlayerYachtPos26 = new Vector3(3411.1f, 1193.445f, 5.42997f);
	Vector3 PlayerYachtPos27 = new Vector3(3021.254f, -723.3903f, 5.42997f);
	Vector3 PlayerYachtPos28 = new Vector3(3029.018f, -1495.702f, 5.42997f);
	Vector3 PlayerYachtPos29 = new Vector3(2976.622f, -1994.76f, 5.42997f);
	Vector3 PlayerYachtPos30 = new Vector3(2490.885f, -2428.848f, 5.42997f);
	Vector3 PlayerYachtPos31 = new Vector3(2049.79f, -2821.624f, 5.42997f);
	Vector3 PlayerYachtPos32 = new Vector3(1546.892f, -3045.627f, 5.42997f);
	Vector3 PlayerYachtPos33 = new Vector3(-351.0608f, -3553.323f, 5.42997f);
	Vector3 PlayerYachtPos34 = new Vector3(-753.0817f, -3919.068f, 5.42997f);
	Vector3 PlayerYachtPos35 = new Vector3(-1460.536f, -3761.467f, 5.42997f);
	Vector3 PlayerYachtPos36 = new Vector3(-2117.581f, -2543.346f, 5.42997f);
	//Vector3 AircraftCarrierPos = new Vector3(3090.70f, -4810.60f, 1f);
	//Vector3 HeistYachtPos = new Vector3(-2040.90f, -1032.45f, 2.58f);
	//Vector3 GunrunningYachtPos = new Vector3(-1380.90f, 6739.95f, 2.58f);
	Vector3 MBTGarageShutterPos = new Vector3(-80.75f, -781.30f, 37.89f);
	Vector3 LombankGarageShutterPos = new Vector3(-1552.95f, -555.70f, 26.54f);
	Vector3 MBWestGarageShutterPos = new Vector3(-1419.35f, -479.35f, 33.15f);
	Vector3 MilBaseTowerElevatorEntryPos = new Vector3(-2360.8f, 3249.45f, 32.1f);
    Vector3 MilBaseTowerElevatorExitPos = new Vector3(-2360.8f, 3249.50f, 92.90f);
    Vector3 MilBaseTowerElevatorSpawnPosIn = new Vector3(-2359.10f, 3252f, 92.90f);
    Vector3 MilBaseTowerElevatorSpawnPosOut = new Vector3(-2358.55f, 3252.30f, 32.81f);
    Vector3 ReplayCastingTrailerEntryPos = new Vector3(-1027.6f, -499.2f, 36.76f);
    Vector3 ReplayCastingTrailerExitPos = new Vector3(-25.7f, -4.9f, 500.06f);
    Vector3 ReplayCastingTrailerSpawnPosIn = new Vector3(-27.20f, -5.20f, 500.06f);
    Vector3 ReplayCastingTrailerSpawnPosOut = new Vector3(-1027.65f, -497.10f, 36.82f);
    Vector3 MBTOfficeSpawnPosIn = new Vector3(-73.90f, -819.10f, 243.39f);
	Vector3 MBTOfficeRequestHeliPos = new Vector3(-73.65f, -815.7f, 243.39f);
    Vector3 MBTOfficeHeliSpawnPos = new Vector3(-75.60f, -819.05f, 326.08f);
    Vector3 MBTOfficeSleepPos = new Vector3(-83.25f, -809.9f, 243.39f);
    Vector3 MBTOfficeSleepRespawnPos = new Vector3(-82f, -807.70f, 243.39f);
    Vector3 MBTOfficeStartSitPos = new Vector3(-69.85f, -804.60f, 243.40f);
    Vector3 MBTOfficeSitPos = new Vector3(-68.50f, -804.165f, 241.87f);
	Vector3 MBTOfficeSitRespawnPos = new Vector3(-71.60f, -804.80f, 243.40f);
	Vector3 MBTCarGarageAEntryPos = new Vector3(-75.55f, -827.15f, 243.39f);
    Vector3 MBTCarGarageAExitPos = new Vector3(-91.6f, -821.2f, 222f);
	Vector3 MBTCarGarageASpawnPosIn = new Vector3(-90.05f, -821.80f, 222f);
	Vector3 MBTCarGarageBEntryPos = new Vector3(-76.7f, -830.2f, 243.39f);
    Vector3 MBTCarGarageBExitPos = new Vector3(-71.7f, -832.15f, 222f);
	Vector3 MBTCarGarageBSpawnPosIn = new Vector3(-71.10f, -830.60f, 222f);
	Vector3 MBTCarGarageCEntryPos = new Vector3(-78.75f, -829.50f, 243.39f);
    Vector3 MBTCarGarageCExitPos = new Vector3(-78.6f, -805.9f, 222f);
	Vector3 MBTCarGarageCSpawnPosIn = new Vector3(-79.30f, -807.35f, 222f);
	Vector3 MBTModGarageEntryPos = new Vector3(-77.6f, -826.4f, 243.39f);
    Vector3 MBTModGarageExitPos = new Vector3(-68.75f, -814.2f, 285f);
	Vector3 MBTModGarageSpawnPosIn = new Vector3(-70.40f, -816.15f, 285f);
	Vector3 MBTModGarageEntryPos2 = new Vector3(-84.2f, -821.6f, 36.03f);
    Vector3 MBTModGarageExitPos2 = new Vector3(-72.25f, -812.75f, 285f);
	Vector3 MBTModGarageSpawnPosIn2 = new Vector3(-74.40f, -818.60f, 285f);
	Vector3 MBTModGarageSpawnPosOut2 = new Vector3(-82.75f, -812f, 36.27f);
    Vector3 CarWarehouseEntryPos = new Vector3(-1154f, -2172.5f, 13.20f);
    Vector3 CarWarehouseExitPos = new Vector3(971f, -2990.5f, -39.65f);
	Vector3 CarWarehouseSpawnPosIn = new Vector3(971.75f, -2996.70f, -39.65f);
	Vector3 CarWarehouseSpawnPosOut = new Vector3(-1155f, -2179.25f, 13.20f);
    Vector3 CarWarehouseSleepPos = new Vector3(959.35f, -3066.75f, -39.64f);
    Vector3 CarWarehouseSleepRespawnPos = new Vector3(960f, -3005.20f, -39.64f);
    Vector3 BunkerEntryPos = new Vector3(2108f, 3325f, 45.39f);
    Vector3 BunkerExitPos = new Vector3(894.5f, -3245.75f, -98.27f);
	Vector3 BunkerSpawnPosIn = new Vector3(887.65f, -3245.10f, -98.27f);
	Vector3 BunkerSpawnPosOut = new Vector3(2099.45f, 3320.10f, 45.39f);
    Vector3 BunkerSleepPos = new Vector3(905.90f, -3199.25f, -97.19f);
    Vector3 BunkerSleepRespawnPos = new Vector3(905.60f, -3200.60f, -97.19f);
    Vector3 HangarEntryPos = new Vector3(-1149.5f, -3406f, 13.95f);
	Vector3 HangarExitPos = new Vector3(-1266.5f, -2971f, -48.49f);
	Vector3 HangarSpawnPosIn = new Vector3(-1266.20f, -2985.85f, -48.49f);
	Vector3 HangarSpawnPosOut = new Vector3(-1146, -3399.65f, 13.95f);
    Vector3 HangarSleepPos = new Vector3(-1237.45f, -2984f, -41.27f);
    Vector3 HangarSleepRespawnPos = new Vector3(-1236.30f, -2984.65f, -41.27f);
	Vector3 FacilityEntryPos = new Vector3(1863.17f, 267.53f, 163.83f);
	Vector3 FacilityExitPos = new Vector3(487.01f, 4819.95f, -58.38f);
	Vector3 FacilitySpawnPosIn = new Vector3(482.78f, 4811.84f, -58.38f);
	Vector3 FacilitySpawnPosOut = new Vector3(1863.17f, 267.53f, 163.83f);
	Vector3 FacilitySleepPos = new Vector3(362.97f, 4823.11f, -59f);
    Vector3 FacilitySleepRespawnPos = new Vector3(363.62f, -4825.11f, -59f);
	Vector3 ServerFarmEntryPos = new Vector3(2477.27f, -402.02f, 94.82f);
	Vector3 ServerFarmExitPos = new Vector3(2154.73f, 2921.04f, -81.08f);
	Vector3 ServerFarmSpawnPosIn = new Vector3(2154.73f, 2921.04f, -81.08f);
	Vector3 ServerFarmSpawnPosOut = new Vector3(2477.27f, -402.02f, 94.82f);
	Vector3 SatelliteFacilityEntryPos = new Vector3(2049.96f, 2949.55f, 47.74f);
	Vector3 SatelliteFacilityExitPos = new Vector3(2155.11f, 2920.93f, -61.90f);
	Vector3 SatelliteFacilitySpawnPosIn = new Vector3(2155.11f, 2920.93f, -61.90f);
	Vector3 SatelliteFacilitySpawnPosOut = new Vector3(2049.96f, 2949.55f, 47.74f);
	Vector3 SubEntryPos = new Vector3(-1291.83f, 6859.53f, -105.98f);
	Vector3 SubExitPos = new Vector3(514.33f, 4888.28f, -62.59f);
	Vector3 SubSpawnPosIn = new Vector3(514.33f, 4888.28f, -62.59f);
	Vector3 SubSpawnPosOut = new Vector3(-1291.83f, 6859.03f, -105.98f);
	Vector3 ChiliadFacilityEntryPos = new Vector3(-361.57f, 4827.75f, 143.17f);
	Vector3 ChiliadFacilityExitPos = new Vector3(1256.17f, 4799.07f, -40.17f);
	Vector3 ChiliadFacilitySpawnPosIn = new Vector3(1256.17f, 4799.07f, -40.17f);
	Vector3 ChiliadFacilitySpawnPosOut = new Vector3(-364.94f, 4828.87f, 142.41f);

	public OnlineInteriors()
	{
		IniSettings = ScriptSettings.Load("scripts\\OnlineInteriors.ini");
		EnableBlips = IniSettings.GetValue<bool>("Main Configuration", "Enable blips", false);
		LongRangeBlips = IniSettings.GetValue<bool>("Main Configuration", "Blips on minimap border", false);
		LoadBunkerHatches = IniSettings.GetValue<bool>("Main Configuration", "Load Bunker Hathces", false);
		LoadFacilityHatches = IniSettings.GetValue<bool>("Main Configuration", "Load Facility Hathces", false);
		EnableHangar = IniSettings.GetValue<bool>("Main Configuration", "Enable hangar", false);
		HeistYachtBlipColor = IniSettings.GetValue<int>("Blip Color Configuration", "Heist Yacht blip color", 0);
		AircraftCarrierBlipColor = IniSettings.GetValue<int>("Blip Color Configuration", "Aircraft Carrier blip color", 0);
		SmallWarehouseBlipColor = IniSettings.GetValue<int>("Blip Color Configuration", "Small Warehouse blip color", 0);
		MedWarehouseBlipColor = IniSettings.GetValue<int>("Blip Color Configuration", "Medium Warehouse blip color", 0);
		LargeWarehouseBlipColor = IniSettings.GetValue<int>("Blip Color Configuration", "Large WarehouseBlipColor blip color", 0);
		MBTOfficeBlipColor = IniSettings.GetValue<int>("Blip Color Configuration", "MBT Office blip color", 0);
		MethWarehouseBlipColor = IniSettings.GetValue<int>("Blip Color Configuration", "Meth Warehouse blip color", 0);
		WeedWarehouseBlipColor = IniSettings.GetValue<int>("Blip Color Configuration", "Weed Warehouse blip color", 0);
		CokeWarehouseBlipColor = IniSettings.GetValue<int>("Blip Color Configuration", "Coke Warehouse blip color", 0);
		DocsForgeriesWarehouseBlipColor = IniSettings.GetValue<int>("Blip Color Configuration", "Document Forgeries Warehouse blip color", 0);
		CashWarehouseBlipColor = IniSettings.GetValue<int>("Blip Color Configuration", "Counterfeit Cash Warehouse blip color", 0);
		ClubhouseBlipColor = IniSettings.GetValue<int>("Blip Color Configuration", "Clubhouse blip color", 0);
		TwoFloorClubhouseBlipColor = IniSettings.GetValue<int>("Blip Color Configuration", "Two Floor Clubhouse blip color", 0);
		CarWarehouseBlipColor = IniSettings.GetValue<int>("Blip Color Configuration", "Vehicle Warehouse blip color", 0);
		BunkerBlipColor = IniSettings.GetValue<int>("Blip Color Configuration", "Bunker blip color", 0);
		GunrunningYachtBlipColor = IniSettings.GetValue<int>("Blip Color Configuration", "Gunrunning Yacht blip color", 0);
		HangarBlipColor = IniSettings.GetValue<int>("Blip Color Configuration", "Hangar blip color", 0);
		FacilityBlipColor = IniSettings.GetValue<int>("Blip Color Configuration", "Facility blip color", 0);
		ServerFarmBlipColor = IniSettings.GetValue<int>("Blip Color Configuration", "Server Farm blip color", 0);
		SatelliteFacilityBlipColor = IniSettings.GetValue<int>("Blip Color Configuration", "Satellite Facility blip color", 0);
		SubmarineBlipColor = IniSettings.GetValue<int>("Blip Color Configuration", "Submarine blip color", 0);
		ChiliadFacilityBlipColor = IniSettings.GetValue<int>("Blip Color Configuration", "Missile Launch Facility blip color", 0);
		MBTOfficeBooze = IniSettings.GetValue<string>("MBT Office Props Configuration", "Office Booze", "Disabled");
		MBTOfficeCashProps1 = IniSettings.GetValue<string>("MBT Office Props Configuration", "Cash Props 1", "Disabled");
		MBTOfficeCashProps2 = IniSettings.GetValue<string>("MBT Office Props Configuration", "Cash Props 2", "Disabled");
		MBTOfficeCashProps3 = IniSettings.GetValue<string>("MBT Office Props Configuration", "Cash Props 3", "Disabled");
		MBTOfficeCashProps4 = IniSettings.GetValue<string>("MBT Office Props Configuration", "Cash Props 4", "Disabled");
		MBTOfficeCashProps5 = IniSettings.GetValue<string>("MBT Office Props Configuration", "Cash Props 5", "Disabled");
		MBTOfficeCashProps6 = IniSettings.GetValue<string>("MBT Office Props Configuration", "Cash Props 6", "Disabled");
		MBTOfficeCashProps7 = IniSettings.GetValue<string>("MBT Office Props Configuration", "Cash Props 7", "Disabled");
		MBTOfficeCashProps8 = IniSettings.GetValue<string>("MBT Office Props Configuration", "Cash Props 8", "Disabled");
		MBTOfficeCashProps9 = IniSettings.GetValue<string>("MBT Office Props Configuration", "Cash Props 9", "Disabled");
		MBTOfficeCashProps10 = IniSettings.GetValue<string>("MBT Office Props Configuration", "Cash Props 10", "Disabled");
		MBTOfficeCashProps11 = IniSettings.GetValue<string>("MBT Office Props Configuration", "Cash Props 11", "Disabled");
		MBTOfficeCashProps12 = IniSettings.GetValue<string>("MBT Office Props Configuration", "Cash Props 12", "Disabled");
		MBTOfficeCashProps13 = IniSettings.GetValue<string>("MBT Office Props Configuration", "Cash Props 13", "Disabled");
		MBTOfficeCashProps14 = IniSettings.GetValue<string>("MBT Office Props Configuration", "Cash Props 14", "Disabled");
		MBTOfficeCashProps15 = IniSettings.GetValue<string>("MBT Office Props Configuration", "Cash Props 15", "Disabled");
		MBTOfficeCashProps16 = IniSettings.GetValue<string>("MBT Office Props Configuration", "Cash Props 16", "Disabled");
		MBTOfficeCashProps17 = IniSettings.GetValue<string>("MBT Office Props Configuration", "Cash Props 17", "Disabled");
		MBTOfficeCashProps18 = IniSettings.GetValue<string>("MBT Office Props Configuration", "Cash Props 18", "Disabled");
		MBTOfficeCashProps19 = IniSettings.GetValue<string>("MBT Office Props Configuration", "Cash Props 19", "Disabled");
		MBTOfficeCashProps20 = IniSettings.GetValue<string>("MBT Office Props Configuration", "Cash Props 20", "Disabled");
		MBTOfficeCashProps21 = IniSettings.GetValue<string>("MBT Office Props Configuration", "Cash Props 21", "Disabled");
		MBTOfficeCashProps22 = IniSettings.GetValue<string>("MBT Office Props Configuration", "Cash Props 22", "Disabled");
		MBTOfficeCashProps23 = IniSettings.GetValue<string>("MBT Office Props Configuration", "Cash Props 23", "Disabled");
		MBTOfficeCashProps24 = IniSettings.GetValue<string>("MBT Office Props Configuration", "Cash Props 24", "Disabled");
		MBTOfficeSilverProps1 = IniSettings.GetValue<string>("MBT Office Props Configuration", "Silver Props 1", "Disabled");
		MBTOfficeSilverProps2 = IniSettings.GetValue<string>("MBT Office Props Configuration", "Silver Props 2", "Disabled");
		MBTOfficeSilverProps3 = IniSettings.GetValue<string>("MBT Office Props Configuration", "Silver Props 3", "Disabled");
		MBTOfficeDrugBags1 = IniSettings.GetValue<string>("MBT Office Props Configuration", "Drug Bags 1", "Disabled");
		MBTOfficeDrugBags2 = IniSettings.GetValue<string>("MBT Office Props Configuration", "Drug Bags 2", "Disabled");
		MBTOfficeDrugBags3 = IniSettings.GetValue<string>("MBT Office Props Configuration", "Drug Bags 3", "Disabled");
		MBTOfficeCigsProps1 = IniSettings.GetValue<string>("MBT Office Props Configuration", "Cigarettes Props 1", "Disabled");
		MBTOfficeCigsProps2 = IniSettings.GetValue<string>("MBT Office Props Configuration", "Cigarettes Props 2", "Disabled");
		MBTOfficeCigsProps3 = IniSettings.GetValue<string>("MBT Office Props Configuration", "Cigarettes Props 3", "Disabled");
		MBTOfficeElectronicProps1 = IniSettings.GetValue<string>("MBT Office Props Configuration", "Electronic Props 1", "Disabled");
		MBTOfficeElectronicProps2 = IniSettings.GetValue<string>("MBT Office Props Configuration", "Electronic Props 2", "Disabled");
		MBTOfficeElectronicProps3 = IniSettings.GetValue<string>("MBT Office Props Configuration", "Electronic Props 3", "Disabled");
		MBTOfficeDrugStatue1 = IniSettings.GetValue<string>("MBT Office Props Configuration", "Drug Statue 1", "Disabled");
		MBTOfficeDrugStatue2 = IniSettings.GetValue<string>("MBT Office Props Configuration", "Drug Statue 2", "Disabled");
		MBTOfficeDrugStatue3 = IniSettings.GetValue<string>("MBT Office Props Configuration", "Drug Statue 3", "Disabled");
		MBTOfficeIvoryProps1 = IniSettings.GetValue<string>("MBT Office Props Configuration", "Ivory Props 1", "Disabled");
		MBTOfficeIvoryProps2 = IniSettings.GetValue<string>("MBT Office Props Configuration", "Ivory Props 2", "Disabled");
		MBTOfficeIvoryProps3 = IniSettings.GetValue<string>("MBT Office Props Configuration", "Ivory Props 3", "Disabled");
		MBTOfficePillsProps1 = IniSettings.GetValue<string>("MBT Office Props Configuration", "Pills Props 1", "Disabled");
		MBTOfficePillsProps2 = IniSettings.GetValue<string>("MBT Office Props Configuration", "Pills Props 2", "Disabled");
		MBTOfficePillsProps3 = IniSettings.GetValue<string>("MBT Office Props Configuration", "Pills Props 3", "Disabled");
		MBTOfficeJewelWatchProps1 = IniSettings.GetValue<string>("MBT Office Props Configuration", "Jewel Watch Props 1", "Disabled");
		MBTOfficeJewelWatchProps2= IniSettings.GetValue<string>("MBT Office Props Configuration", "Jewel Watch Props 2", "Disabled");
		MBTOfficeJewelWatchProps3 = IniSettings.GetValue<string>("MBT Office Props Configuration", "Jewel Watch Props 3", "Disabled");
		MBTOfficeFurCoats1 = IniSettings.GetValue<string>("MBT Office Props Configuration", "Fur Coats 1", "Disabled");
		MBTOfficeFurCoats2= IniSettings.GetValue<string>("MBT Office Props Configuration", "Fur Coats 2", "Disabled");
		MBTOfficeFurCoats3 = IniSettings.GetValue<string>("MBT Office Props Configuration", "Fur Coats 3", "Disabled");
		MBTOfficeArtProps1 = IniSettings.GetValue<string>("MBT Office Props Configuration", "Art Props 1", "Disabled");
		MBTOfficeArtProps2 = IniSettings.GetValue<string>("MBT Office Props Configuration", "Art Props 2", "Disabled");
		MBTOfficeArtProps3 = IniSettings.GetValue<string>("MBT Office Props Configuration", "Art Props 3", "Disabled");
		MBTOfficeGuns1 = IniSettings.GetValue<string>("MBT Office Props Configuration", "Guns 1", "Disabled");
		MBTOfficeGuns2 = IniSettings.GetValue<string>("MBT Office Props Configuration", "Guns 2", "Disabled");
		MBTOfficeGuns3 = IniSettings.GetValue<string>("MBT Office Props Configuration", "Guns 3", "Disabled");
		MBTOfficeMedProps1 = IniSettings.GetValue<string>("MBT Office Props Configuration", "Med Props 1", "Disabled");
		MBTOfficeMedProps2 = IniSettings.GetValue<string>("MBT Office Props Configuration", "Med Props 2", "Disabled");
		MBTOfficeMedProps3 = IniSettings.GetValue<string>("MBT Office Props Configuration", "Med Props 3", "Disabled");
		MBTOfficeGemProps1 = IniSettings.GetValue<string>("MBT Office Props Configuration", "Gem Props 1", "Disabled");
		MBTOfficeGemProps2 = IniSettings.GetValue<string>("MBT Office Props Configuration", "Gem Props 2", "Disabled");
		MBTOfficeGemProps3 = IniSettings.GetValue<string>("MBT Office Props Configuration", "Gem Props 3", "Disabled");
		MBTOfficeCounterfeitProps1 = IniSettings.GetValue<string>("MBT Office Props Configuration", "Counterfeit Props 1", "Disabled");
		MBTOfficeCounterfeitProps2 = IniSettings.GetValue<string>("MBT Office Props Configuration", "Counterfeit Props2 ", "Disabled");
		MBTOfficeCounterfeitProps3 = IniSettings.GetValue<string>("MBT Office Props Configuration", "Counterfeit Props 3", "Disabled");
		MBTCarGarageADecor = IniSettings.GetValue<string>("MBT 60 Car Garage Configuration", "Car Garage A Decor", "garage_decor_01");
		MBTCarGarageBDecor = IniSettings.GetValue<string>("MBT 60 Car Garage Configuration", "Car Garage B Decor", "garage_decor_01");
		MBTCarGarageCDecor = IniSettings.GetValue<string>("MBT 60 Car Garage Configuration", "Car Garage C Decor", "garage_decor_01");
		MBTCarGarageALighting = IniSettings.GetValue<string>("MBT 60 Car Garage Configuration", "Car Garage A Lighting", "lighting_option01");
		MBTCarGarageBLighting = IniSettings.GetValue<string>("MBT 60 Car Garage Configuration", "Car Garage B Lighting", "lighting_option01");
		MBTCarGarageCLighting = IniSettings.GetValue<string>("MBT 60 Car Garage Configuration", "Car Garage C Lighting", "lighting_option01");
		MBTCarGarageANumberingStyle = IniSettings.GetValue<string>("MBT 60 Car Garage Configuration", "Car Garage A Numering Style", "numbering_style01_n1");
		MBTCarGarageBNumberingStyle = IniSettings.GetValue<string>("MBT 60 Car Garage Configuration", "Car Garage B Numering Style", "numbering_style01_n1");
		MBTCarGarageCNumberingStyle = IniSettings.GetValue<string>("MBT 60 Car Garage Configuration", "Car Garage C Numering Style", "numbering_style01_n1");
		MBTModGarageFloorDecal = IniSettings.GetValue<string>("MBT Mod Garage Configuration", "Floor Decal", "Disabled");
		CarWarehouseStyle = IniSettings.GetValue<string>("Vehicle Warehouse Configuration", "Style", "basic_style_set");
		FloorHatch = IniSettings.GetValue<string>("Vehicle Warehouse Configuration", "Floor Hatch", "Disabled");
		Pump1 = IniSettings.GetValue<string>("Vehicle Warehouse Configuration", "Pump 1", "Disabled");
		Pump2 = IniSettings.GetValue<string>("Vehicle Warehouse Configuration", "Pump 2", "Disabled");
		Pump3 = IniSettings.GetValue<string>("Vehicle Warehouse Configuration", "Pump 3", "Disabled");
		Pump4 = IniSettings.GetValue<string>("Vehicle Warehouse Configuration", "Pump 4", "Disabled");
		Pump5 = IniSettings.GetValue<string>("Vehicle Warehouse Configuration", "Pump 5", "Disabled");
		Pump6 = IniSettings.GetValue<string>("Vehicle Warehouse Configuration", "Pump 6", "Disabled");
		Pump7 = IniSettings.GetValue<string>("Vehicle Warehouse Configuration", "Pump 7", "Disabled");
		Pump8 = IniSettings.GetValue<string>("Vehicle Warehouse Configuration", "Pump 8", "Disabled");
		BunkerStyle = IniSettings.GetValue<string>("Bunker Configuration", "Style", "bunker_style_a");
		BunkerSet = IniSettings.GetValue<string>("Bunker Configuration", "Props Set", "standard_bunker_set");
		BunkerSet2 = IniSettings.GetValue<string>("Bunker Configuration", "Secondary Props Set", "standard_bunker_set_more");
		BunkerSecuritySet = IniSettings.GetValue<string>("Bunker Configuration", "Security Set", "standard_security_set");
		HangarLighting = IniSettings.GetValue<string>("Hangar Configuration", "Lighting", "set_lighting_hangar_a");
		HangarFloor = IniSettings.GetValue<string>("Hangar Configuration", "Floor", "set_floor_1");
		HangarFloorDecal = IniSettings.GetValue<string>("Hangar Configuration", "Floor Decal", "set_floor_decal_1");
		HangarBedroom = IniSettings.GetValue<string>("Hangar Configuration", "Bedroom", "set_bedroom_clutter");
		HangarOffice= IniSettings.GetValue<string>("Hangar Configuration", "Office", "set_office_basic");
		HangarBedroomBlinds = IniSettings.GetValue<string>("Hangar Configuration", "Bedroom Blinds", "set_bedroom_blinds_open");
		HangarLightingWallTint = IniSettings.GetValue<string>("Hangar Configuration", "Lighting Wall Tint", "set_lighting_wall_tint01");
		HangarNeutralLighting = IniSettings.GetValue<string>("Hangar Configuration", "Lighting", "Disabled");
		HangarFloorDecalColor = IniSettings.GetValue<int>("Hangar Tint Configuration", "Floor Decal color", 1);
		HangarShellColor = IniSettings.GetValue<int>("Hangar Tint Configuration", "Shell color", 1);
		HangarBedroomColor = IniSettings.GetValue<int>("Hangar Tint Configuration", "Bedroom color", 1);
		HangarCraneColor = IniSettings.GetValue<int>("Hangar Tint Configuration", "Crane color", 1);
		HangarWorkshopColor = IniSettings.GetValue<int>("Hangar Tint Configuration", "Workshop color", 1);
		HangarLightingTintPropsColor = IniSettings.GetValue<int>("Hangar Tint Configuration", "Lighting Tint Props color", 1);
		FacilityGraphic = IniSettings.GetValue<string>("Facility Configuration", "Facility Graphic Configuration", "set_int_02_decal_01");
		FacilityOrbitalCannon = IniSettings.GetValue<string>("Facility Configuration", "Orbital Cannon", "set_int_02_no_cannon");
		FacilitySecurityRoom = IniSettings.GetValue<string>("Facility Configuration", "Security Room", "set_int_02_no_security");
		FacilityLounge = IniSettings.GetValue<string>("Facility Configuration", "Lounge", "");
		FacilitySleepingQuarters = IniSettings.GetValue<string>("Facility Configuration",  "Sleeping Quarters", "set_int_02_no_sleep");
		FacilityShellColor =  IniSettings.GetValue<int>("Facility Tint Configuration", "Facility Shell Color", 1);
		FacilityGraphicColor = IniSettings.GetValue<int>("Facility Tint Configuration", "Graphic Color", 1);
		FacilityOrbitalCannonColor = IniSettings.GetValue<int>("Facility Tint Configuration", "Orbital Cannon Color", 1);
		FacilitySecurityRoomColor = IniSettings.GetValue<int>("Facility Tint Configuration", "Security Room Color", 1);
		FacilityLoungeColor = IniSettings.GetValue<int>("Facility Tint Configuration", "Lounge Color", 1);
		FacilitySleepingQuartersColor = IniSettings.GetValue<int>("Facility Tint Configuration", "Sleeping Quarters Color", 1);
		Tick += OnTick;
		MBTOfficeProps();
		BikerInteriorsProps();
		IPL();
		MapFix();

		if (EnableBlips)
		{
			Blip HeistYacht = World.CreateBlip(new Vector3(-2061.94f, -1023.116f, 30f));
			Function.Call(Hash.SET_BLIP_SPRITE, HeistYacht, 455);
			Function.Call(Hash.SET_BLIP_COLOUR, HeistYacht, HeistYachtBlipColor);

			Blip AircraftCarrier = World.CreateBlip(new Vector3(3083.465f, -4659.136f, 30f));
			Function.Call(Hash.SET_BLIP_SPRITE, AircraftCarrier, 16);
			Function.Call(Hash.SET_BLIP_COLOUR, AircraftCarrier, AircraftCarrierBlipColor);
			Function.Call(Hash._0xF9113A30DE5C6670, "STRING");
			Function.Call(Hash._ADD_TEXT_COMPONENT_STRING, "Aircraft Carrier");
			Function.Call(Hash._0xBC38B49BCB83BC9B, AircraftCarrier);

			Blip SmallWarehouse = World.CreateBlip(new Vector3(958.50f, -1586.30f, 30f));
			Function.Call(Hash.SET_BLIP_SPRITE, SmallWarehouse, 473);
			Function.Call(Hash.SET_BLIP_COLOUR, SmallWarehouse, SmallWarehouseBlipColor);

			Blip MedWarehouse = World.CreateBlip(new Vector3(758.90f, -909.15f, 30f));
			Function.Call(Hash.SET_BLIP_SPRITE, MedWarehouse, 473);
			Function.Call(Hash.SET_BLIP_COLOUR, MedWarehouse, MedWarehouseBlipColor);

			Blip LargeWarehouse = World.CreateBlip(new Vector3(714.05f, -716.50f, 30f));
			Function.Call(Hash.SET_BLIP_SPRITE, LargeWarehouse, 473);
			Function.Call(Hash.SET_BLIP_COLOUR, LargeWarehouse, LargeWarehouseBlipColor);

			Blip MBTOffice = World.CreateBlip(new Vector3(-79.25f, -833.75f, 30f));
			Function.Call(Hash.SET_BLIP_SPRITE, MBTOffice, 475);
			Function.Call(Hash.SET_BLIP_COLOUR, MBTOffice, MBTOfficeBlipColor);

			Blip MethWarehouse = World.CreateBlip(new Vector3(1207.30f, -3122.45f, 30f));
			Function.Call(Hash.SET_BLIP_SPRITE, MethWarehouse, 499);
			Function.Call(Hash.SET_BLIP_COLOUR, MethWarehouse, MethWarehouseBlipColor);

			Blip WeedWarehouse = World.CreateBlip(new Vector3(1308.95f, 4362.15f, 30f));
			Function.Call(Hash.SET_BLIP_SPRITE, WeedWarehouse, 496);
			Function.Call(Hash.SET_BLIP_COLOUR, WeedWarehouse, WeedWarehouseBlipColor);

			Blip CocaineWarehouse = World.CreateBlip(new Vector3(387.40f, 3583.45f, 30f));
			Function.Call(Hash.SET_BLIP_SPRITE, CocaineWarehouse, 497);
			Function.Call(Hash.SET_BLIP_COLOUR, CocaineWarehouse, CokeWarehouseBlipColor);

			Blip DocsForgWarehouse = World.CreateBlip(new Vector3(328.85f, -831.30f, 30f));
			Function.Call(Hash.SET_BLIP_SPRITE, DocsForgWarehouse, 498);
			Function.Call(Hash.SET_BLIP_COLOUR, DocsForgWarehouse, DocsForgeriesWarehouseBlipColor);

			Blip CashWarehouse = World.CreateBlip(new Vector3(639.35f, 2769.65f, 30f));
			Function.Call(Hash.SET_BLIP_SPRITE, CashWarehouse, 500);
			Function.Call(Hash.SET_BLIP_COLOUR, CashWarehouse, CashWarehouseBlipColor);

			Blip Clubhouse = World.CreateBlip(new Vector3(-387.20f, 6060.45f, 30f));
			Function.Call(Hash.SET_BLIP_SPRITE, Clubhouse, 492);
			Function.Call(Hash.SET_BLIP_COLOUR, Clubhouse, ClubhouseBlipColor);
			Function.Call(Hash._0xF9113A30DE5C6670, "STRING");
			Function.Call(Hash._ADD_TEXT_COMPONENT_STRING, "Clubhouse");
			Function.Call(Hash._0xBC38B49BCB83BC9B, Clubhouse);

			Blip TwoFloorClubhouse = World.CreateBlip(new Vector3(2473.65f, 4110.10f, 30f));
			Function.Call(Hash.SET_BLIP_SPRITE, TwoFloorClubhouse, 492);
			Function.Call(Hash.SET_BLIP_COLOUR, TwoFloorClubhouse, TwoFloorClubhouseBlipColor);
			Function.Call(Hash._0xF9113A30DE5C6670, "STRING");
			Function.Call(Hash._ADD_TEXT_COMPONENT_STRING, "Clubhouse");
			Function.Call(Hash._0xBC38B49BCB83BC9B, TwoFloorClubhouse);

			Blip CarWarehouse = World.CreateBlip(new Vector3(-1151.70f, -2170.65f, 30f));
			Function.Call(Hash.SET_BLIP_SPRITE, CarWarehouse, 524);
			Function.Call(Hash.SET_BLIP_COLOUR, CarWarehouse, CarWarehouseBlipColor);

			Blip Bunker = World.CreateBlip(new Vector3(2110.75f, 3326.50f, 30f));
			Function.Call(Hash.SET_BLIP_SPRITE, Bunker, 557);
			Function.Call(Hash.SET_BLIP_COLOUR, Bunker, BunkerBlipColor);

			Blip GunrunningYacht = World.CreateBlip(new Vector3(-1407.209f, 6750.852f, 30f));
			Function.Call(Hash.SET_BLIP_SPRITE, GunrunningYacht, 455);
			Function.Call(Hash.SET_BLIP_COLOUR, GunrunningYacht, GunrunningYachtBlipColor);
			
			if (EnableHangar)
			{
				Blip Hangar = World.CreateBlip(new Vector3(-1153.30f, -3412.10f, 30f));
				Function.Call(Hash.SET_BLIP_SPRITE, Hangar, 569);
				Function.Call(Hash.SET_BLIP_COLOUR, Hangar, HangarBlipColor);
			}
			
			Blip Facility = World.CreateBlip(new Vector3(1863.17f, 267.53f, 30f));
			Function.Call(Hash.SET_BLIP_SPRITE, Facility, 590);
			Function.Call(Hash.SET_BLIP_COLOUR, Facility, FacilityBlipColor);
			
			Blip ServerFarm = World.CreateBlip(new Vector3(2477.27f, -402.02f, 30f));
			Function.Call(Hash.SET_BLIP_SPRITE, ServerFarm, 459);
			Function.Call(Hash.SET_BLIP_COLOUR, ServerFarm, ServerFarmBlipColor);
			Function.Call(Hash._0xF9113A30DE5C6670, "STRING");
			Function.Call(Hash._ADD_TEXT_COMPONENT_STRING, "Government Building Server Farm");
			Function.Call(Hash._0xBC38B49BCB83BC9B, ServerFarm);
			
			Blip SatelliteFacility = World.CreateBlip(new Vector3(2049.96f, 2949.55f, 30f));
			Function.Call(Hash.SET_BLIP_SPRITE, SatelliteFacility, 564);
			Function.Call(Hash.SET_BLIP_COLOUR, SatelliteFacility, SatelliteFacilityBlipColor);
			Function.Call(Hash._0xF9113A30DE5C6670, "STRING");
			Function.Call(Hash._ADD_TEXT_COMPONENT_STRING, "IAA Satellite Facility");
			Function.Call(Hash._0xBC38B49BCB83BC9B, SatelliteFacility);
			
			Blip Submarine = World.CreateBlip(new Vector3(-1291.83f, 6859.53f, 30f));
			Function.Call(Hash.SET_BLIP_SPRITE, Submarine, 308);
			Function.Call(Hash.SET_BLIP_COLOUR, Submarine, SubmarineBlipColor);
			Function.Call(Hash._0xF9113A30DE5C6670, "STRING");
			Function.Call(Hash._ADD_TEXT_COMPONENT_STRING, "Naval Submarine");
			Function.Call(Hash._0xBC38B49BCB83BC9B, Submarine);
			
			Blip ChilliadFacility = World.CreateBlip(new Vector3(-361.57f, 4827.75f, 30f));
			Function.Call(Hash.SET_BLIP_SPRITE, ChilliadFacility, 548);
			Function.Call(Hash.SET_BLIP_COLOUR, ChilliadFacility, ChiliadFacilityBlipColor);
			Function.Call(Hash._0xF9113A30DE5C6670, "STRING");
			Function.Call(Hash._ADD_TEXT_COMPONENT_STRING, "Missile Launch Facility");
			Function.Call(Hash._0xBC38B49BCB83BC9B, ChilliadFacility);


			if (!LongRangeBlips)
			{
				Function.Call(Hash.SET_BLIP_AS_SHORT_RANGE, HeistYacht, true);

				Function.Call(Hash.SET_BLIP_AS_SHORT_RANGE, AircraftCarrier, true);

				Function.Call(Hash.SET_BLIP_AS_SHORT_RANGE, SmallWarehouse, true);

				Function.Call(Hash.SET_BLIP_AS_SHORT_RANGE, MedWarehouse, true);

				Function.Call(Hash.SET_BLIP_AS_SHORT_RANGE, LargeWarehouse, true);

				Function.Call(Hash.SET_BLIP_AS_SHORT_RANGE, MBTOffice, true);

				Function.Call(Hash.SET_BLIP_AS_SHORT_RANGE, MethWarehouse, true);

				Function.Call(Hash.SET_BLIP_AS_SHORT_RANGE, WeedWarehouse, true);

				Function.Call(Hash.SET_BLIP_AS_SHORT_RANGE, CocaineWarehouse, true);

				Function.Call(Hash.SET_BLIP_AS_SHORT_RANGE, DocsForgWarehouse, true);

				Function.Call(Hash.SET_BLIP_AS_SHORT_RANGE, CashWarehouse, true);

				Function.Call(Hash.SET_BLIP_AS_SHORT_RANGE, Clubhouse, true);

				Function.Call(Hash.SET_BLIP_AS_SHORT_RANGE, TwoFloorClubhouse, true);

				Function.Call(Hash.SET_BLIP_AS_SHORT_RANGE, CarWarehouse, true);

				Function.Call(Hash.SET_BLIP_AS_SHORT_RANGE, Bunker, true);

				Function.Call(Hash.SET_BLIP_AS_SHORT_RANGE, GunrunningYacht, true);
				
				if(EnableHangar)
					Function.Call(Hash.SET_BLIP_AS_SHORT_RANGE, Hangar, true);
				
				Function.Call(Hash.SET_BLIP_AS_SHORT_RANGE, Facility, true);

				Function.Call(Hash.SET_BLIP_AS_SHORT_RANGE, ServerFarm, true);

				Function.Call(Hash.SET_BLIP_AS_SHORT_RANGE, SatelliteFacility, true);

				Function.Call(Hash.SET_BLIP_AS_SHORT_RANGE, Submarine, true);

				Function.Call(Hash.SET_BLIP_AS_SHORT_RANGE, ChilliadFacility, true);

			}
		}
		if (LoadBunkerHatches)
		{
			Function.Call(Hash.REQUEST_IPL, "gr_case0_bunkerclosed");
			Function.Call(Hash.REQUEST_IPL, "gr_case2_bunkerclosed");
			Function.Call(Hash.REQUEST_IPL, "gr_case3_bunkerclosed");
			Function.Call(Hash.REQUEST_IPL, "gr_case4_bunkerclosed");
			Function.Call(Hash.REQUEST_IPL, "gr_case5_bunkerclosed");
			Function.Call(Hash.REQUEST_IPL, "gr_case6_bunkerclosed");
			Function.Call(Hash.REQUEST_IPL, "gr_case7_bunkerclosed");
			Function.Call(Hash.REQUEST_IPL, "gr_case9_bunkerclosed");
			Function.Call(Hash.REQUEST_IPL, "gr_case10_bunkerclosed");
			Function.Call(Hash.REQUEST_IPL, "gr_case11_bunkerclosed");
		}
		
		if (LoadFacilityHatches)
		{
			Function.Call(Hash.REQUEST_IPL, "xm_bunkerentrance_door");
			Function.Call(Hash.REQUEST_IPL, "xm_hatches_terrain");
			Function.Call(Hash.REQUEST_IPL, "xm_hatches_terrain_lod");
			Function.Call(Hash.REQUEST_IPL, "xm_hatch_closed");
			Function.Call(Hash.REQUEST_IPL, "xm_mpchristmasadditions");
			Function.Call(Hash.REQUEST_IPL, "xm_siloentranceclosed_x17");
		}
	}

	void MBTOfficeProps()
	{
		//mbt office old spice warm
		Function.Call((Hash)0x55E86AF2712B36A1, 238593, "office_chairs");
		Function.Call((Hash)0x55E86AF2712B36A1, 238593, MBTOfficeBooze);
		Function.Call((Hash)0x55E86AF2712B36A1, 238593, MBTOfficeCashProps1);
		Function.Call((Hash)0x55E86AF2712B36A1, 238593, MBTOfficeCashProps2);
		Function.Call((Hash)0x55E86AF2712B36A1, 238593, MBTOfficeCashProps3);
		Function.Call((Hash)0x55E86AF2712B36A1, 238593, MBTOfficeCashProps4);
		Function.Call((Hash)0x55E86AF2712B36A1, 238593, MBTOfficeCashProps5);
		Function.Call((Hash)0x55E86AF2712B36A1, 238593, MBTOfficeCashProps6);
		Function.Call((Hash)0x55E86AF2712B36A1, 238593, MBTOfficeCashProps7);
		Function.Call((Hash)0x55E86AF2712B36A1, 238593, MBTOfficeCashProps8);
		Function.Call((Hash)0x55E86AF2712B36A1, 238593, MBTOfficeCashProps9);
		Function.Call((Hash)0x55E86AF2712B36A1, 238593, MBTOfficeCashProps10);
		Function.Call((Hash)0x55E86AF2712B36A1, 238593, MBTOfficeCashProps11);
		Function.Call((Hash)0x55E86AF2712B36A1, 238593, MBTOfficeCashProps12);
		Function.Call((Hash)0x55E86AF2712B36A1, 238593, MBTOfficeCashProps13);
		Function.Call((Hash)0x55E86AF2712B36A1, 238593, MBTOfficeCashProps14);
		Function.Call((Hash)0x55E86AF2712B36A1, 238593, MBTOfficeCashProps15);
		Function.Call((Hash)0x55E86AF2712B36A1, 238593, MBTOfficeCashProps16);
		Function.Call((Hash)0x55E86AF2712B36A1, 238593, MBTOfficeCashProps17);
		Function.Call((Hash)0x55E86AF2712B36A1, 238593, MBTOfficeCashProps18);
		Function.Call((Hash)0x55E86AF2712B36A1, 238593, MBTOfficeCashProps19);
		Function.Call((Hash)0x55E86AF2712B36A1, 238593, MBTOfficeCashProps20);
		Function.Call((Hash)0x55E86AF2712B36A1, 238593, MBTOfficeCashProps21);
		Function.Call((Hash)0x55E86AF2712B36A1, 238593, MBTOfficeCashProps22);
		Function.Call((Hash)0x55E86AF2712B36A1, 238593, MBTOfficeCashProps23);
		Function.Call((Hash)0x55E86AF2712B36A1, 238593, MBTOfficeCashProps24);
		Function.Call((Hash)0x55E86AF2712B36A1, 238593, MBTOfficeSilverProps1);
		Function.Call((Hash)0x55E86AF2712B36A1, 238593, MBTOfficeSilverProps2);
		Function.Call((Hash)0x55E86AF2712B36A1, 238593, MBTOfficeSilverProps3);
		Function.Call((Hash)0x55E86AF2712B36A1, 238593, MBTOfficeDrugBags1);
		Function.Call((Hash)0x55E86AF2712B36A1, 238593, MBTOfficeDrugBags2);
		Function.Call((Hash)0x55E86AF2712B36A1, 238593, MBTOfficeDrugBags3);
		Function.Call((Hash)0x55E86AF2712B36A1, 238593, MBTOfficeCigsProps1);
		Function.Call((Hash)0x55E86AF2712B36A1, 238593, MBTOfficeCigsProps2);
		Function.Call((Hash)0x55E86AF2712B36A1, 238593, MBTOfficeCigsProps3);
		Function.Call((Hash)0x55E86AF2712B36A1, 238593, MBTOfficeElectronicProps1);
		Function.Call((Hash)0x55E86AF2712B36A1, 238593, MBTOfficeElectronicProps2);
		Function.Call((Hash)0x55E86AF2712B36A1, 238593, MBTOfficeElectronicProps3);
		Function.Call((Hash)0x55E86AF2712B36A1, 238593, MBTOfficeDrugStatue1);
		Function.Call((Hash)0x55E86AF2712B36A1, 238593, MBTOfficeDrugStatue2);
		Function.Call((Hash)0x55E86AF2712B36A1, 238593, MBTOfficeDrugStatue3);
		Function.Call((Hash)0x55E86AF2712B36A1, 238593, MBTOfficeIvoryProps1);
		Function.Call((Hash)0x55E86AF2712B36A1, 238593, MBTOfficeIvoryProps2);
		Function.Call((Hash)0x55E86AF2712B36A1, 238593, MBTOfficeIvoryProps3);
		Function.Call((Hash)0x55E86AF2712B36A1, 238593, MBTOfficePillsProps1);
		Function.Call((Hash)0x55E86AF2712B36A1, 238593, MBTOfficePillsProps2);
		Function.Call((Hash)0x55E86AF2712B36A1, 238593, MBTOfficePillsProps3);
		Function.Call((Hash)0x55E86AF2712B36A1, 238593, MBTOfficeJewelWatchProps1);
		Function.Call((Hash)0x55E86AF2712B36A1, 238593, MBTOfficeJewelWatchProps2);
		Function.Call((Hash)0x55E86AF2712B36A1, 238593, MBTOfficeJewelWatchProps3);
		Function.Call((Hash)0x55E86AF2712B36A1, 238593, MBTOfficeFurCoats1);
		Function.Call((Hash)0x55E86AF2712B36A1, 238593, MBTOfficeFurCoats2);
		Function.Call((Hash)0x55E86AF2712B36A1, 238593, MBTOfficeFurCoats3);
		Function.Call((Hash)0x55E86AF2712B36A1, 238593, MBTOfficeArtProps1);
		Function.Call((Hash)0x55E86AF2712B36A1, 238593, MBTOfficeArtProps2);
		Function.Call((Hash)0x55E86AF2712B36A1, 238593, MBTOfficeArtProps3);
		Function.Call((Hash)0x55E86AF2712B36A1, 238593, MBTOfficeGuns1);
		Function.Call((Hash)0x55E86AF2712B36A1, 238593, MBTOfficeGuns2);
		Function.Call((Hash)0x55E86AF2712B36A1, 238593, MBTOfficeGuns3);
		Function.Call((Hash)0x55E86AF2712B36A1, 238593, MBTOfficeMedProps1);
		Function.Call((Hash)0x55E86AF2712B36A1, 238593, MBTOfficeMedProps2);
		Function.Call((Hash)0x55E86AF2712B36A1, 238593, MBTOfficeGemProps3);
		Function.Call((Hash)0x55E86AF2712B36A1, 238593, MBTOfficeGemProps1);
		Function.Call((Hash)0x55E86AF2712B36A1, 238593, MBTOfficeGemProps2);
		Function.Call((Hash)0x55E86AF2712B36A1, 238593, MBTOfficeMedProps3);
		Function.Call((Hash)0x55E86AF2712B36A1, 238593, MBTOfficeCounterfeitProps1);
		Function.Call((Hash)0x55E86AF2712B36A1, 238593, MBTOfficeCounterfeitProps2);
		Function.Call((Hash)0x55E86AF2712B36A1, 238593, MBTOfficeCounterfeitProps3);
		Function.Call((Hash)0x41F37C3427C75AE0, 238593);
		
		//mbt office old spice classical
		Function.Call((Hash)0x55E86AF2712B36A1, 238849, "office_chairs");
		Function.Call((Hash)0x55E86AF2712B36A1, 238849, MBTOfficeBooze);
		Function.Call((Hash)0x55E86AF2712B36A1, 238849, MBTOfficeCashProps1);
		Function.Call((Hash)0x55E86AF2712B36A1, 238849, MBTOfficeCashProps2);
		Function.Call((Hash)0x55E86AF2712B36A1, 238849, MBTOfficeCashProps3);
		Function.Call((Hash)0x55E86AF2712B36A1, 238849, MBTOfficeCashProps4);
		Function.Call((Hash)0x55E86AF2712B36A1, 238849, MBTOfficeCashProps5);
		Function.Call((Hash)0x55E86AF2712B36A1, 238849, MBTOfficeCashProps6);
		Function.Call((Hash)0x55E86AF2712B36A1, 238849, MBTOfficeCashProps7);
		Function.Call((Hash)0x55E86AF2712B36A1, 238849, MBTOfficeCashProps8);
		Function.Call((Hash)0x55E86AF2712B36A1, 238849, MBTOfficeCashProps9);
		Function.Call((Hash)0x55E86AF2712B36A1, 238849, MBTOfficeCashProps10);
		Function.Call((Hash)0x55E86AF2712B36A1, 238849, MBTOfficeCashProps11);
		Function.Call((Hash)0x55E86AF2712B36A1, 238849, MBTOfficeCashProps12);
		Function.Call((Hash)0x55E86AF2712B36A1, 238849, MBTOfficeCashProps13);
		Function.Call((Hash)0x55E86AF2712B36A1, 238849, MBTOfficeCashProps14);
		Function.Call((Hash)0x55E86AF2712B36A1, 238849, MBTOfficeCashProps15);
		Function.Call((Hash)0x55E86AF2712B36A1, 238849, MBTOfficeCashProps16);
		Function.Call((Hash)0x55E86AF2712B36A1, 238849, MBTOfficeCashProps17);
		Function.Call((Hash)0x55E86AF2712B36A1, 238849, MBTOfficeCashProps18);
		Function.Call((Hash)0x55E86AF2712B36A1, 238849, MBTOfficeCashProps19);
		Function.Call((Hash)0x55E86AF2712B36A1, 238849, MBTOfficeCashProps20);
		Function.Call((Hash)0x55E86AF2712B36A1, 238849, MBTOfficeCashProps21);
		Function.Call((Hash)0x55E86AF2712B36A1, 238849, MBTOfficeCashProps22);
		Function.Call((Hash)0x55E86AF2712B36A1, 238849, MBTOfficeCashProps23);
		Function.Call((Hash)0x55E86AF2712B36A1, 238849, MBTOfficeCashProps24);
		Function.Call((Hash)0x55E86AF2712B36A1, 238849, MBTOfficeSilverProps1);
		Function.Call((Hash)0x55E86AF2712B36A1, 238849, MBTOfficeSilverProps2);
		Function.Call((Hash)0x55E86AF2712B36A1, 238849, MBTOfficeSilverProps3);
		Function.Call((Hash)0x55E86AF2712B36A1, 238849, MBTOfficeDrugBags1);
		Function.Call((Hash)0x55E86AF2712B36A1, 238849, MBTOfficeDrugBags2);
		Function.Call((Hash)0x55E86AF2712B36A1, 238849, MBTOfficeDrugBags3);
		Function.Call((Hash)0x55E86AF2712B36A1, 238849, MBTOfficeCigsProps1);
		Function.Call((Hash)0x55E86AF2712B36A1, 238849, MBTOfficeCigsProps2);
		Function.Call((Hash)0x55E86AF2712B36A1, 238849, MBTOfficeCigsProps3);
		Function.Call((Hash)0x55E86AF2712B36A1, 238849, MBTOfficeElectronicProps1);
		Function.Call((Hash)0x55E86AF2712B36A1, 238849, MBTOfficeElectronicProps2);
		Function.Call((Hash)0x55E86AF2712B36A1, 238849, MBTOfficeElectronicProps3);
		Function.Call((Hash)0x55E86AF2712B36A1, 238849, MBTOfficeDrugStatue1);
		Function.Call((Hash)0x55E86AF2712B36A1, 238849, MBTOfficeDrugStatue2);
		Function.Call((Hash)0x55E86AF2712B36A1, 238849, MBTOfficeDrugStatue3);
		Function.Call((Hash)0x55E86AF2712B36A1, 238849, MBTOfficeIvoryProps1);
		Function.Call((Hash)0x55E86AF2712B36A1, 238849, MBTOfficeIvoryProps2);
		Function.Call((Hash)0x55E86AF2712B36A1, 238849, MBTOfficeIvoryProps3);
		Function.Call((Hash)0x55E86AF2712B36A1, 238849, MBTOfficePillsProps1);
		Function.Call((Hash)0x55E86AF2712B36A1, 238849, MBTOfficePillsProps2);
		Function.Call((Hash)0x55E86AF2712B36A1, 238849, MBTOfficePillsProps3);
		Function.Call((Hash)0x55E86AF2712B36A1, 238849, MBTOfficeJewelWatchProps1);
		Function.Call((Hash)0x55E86AF2712B36A1, 238849, MBTOfficeJewelWatchProps2);
		Function.Call((Hash)0x55E86AF2712B36A1, 238849, MBTOfficeJewelWatchProps3);
		Function.Call((Hash)0x55E86AF2712B36A1, 238849, MBTOfficeFurCoats1);
		Function.Call((Hash)0x55E86AF2712B36A1, 238849, MBTOfficeFurCoats2);
		Function.Call((Hash)0x55E86AF2712B36A1, 238849, MBTOfficeFurCoats3);
		Function.Call((Hash)0x55E86AF2712B36A1, 238849, MBTOfficeArtProps1);
		Function.Call((Hash)0x55E86AF2712B36A1, 238849, MBTOfficeArtProps2);
		Function.Call((Hash)0x55E86AF2712B36A1, 238849, MBTOfficeArtProps3);
		Function.Call((Hash)0x55E86AF2712B36A1, 238849, MBTOfficeGuns1);
		Function.Call((Hash)0x55E86AF2712B36A1, 238849, MBTOfficeGuns2);
		Function.Call((Hash)0x55E86AF2712B36A1, 238849, MBTOfficeGuns3);
		Function.Call((Hash)0x55E86AF2712B36A1, 238849, MBTOfficeMedProps1);
		Function.Call((Hash)0x55E86AF2712B36A1, 238849, MBTOfficeMedProps2);
		Function.Call((Hash)0x55E86AF2712B36A1, 238849, MBTOfficeGemProps3);
		Function.Call((Hash)0x55E86AF2712B36A1, 238849, MBTOfficeGemProps1);
		Function.Call((Hash)0x55E86AF2712B36A1, 238849, MBTOfficeGemProps2);
		Function.Call((Hash)0x55E86AF2712B36A1, 238849, MBTOfficeMedProps3);
		Function.Call((Hash)0x55E86AF2712B36A1, 238849, MBTOfficeCounterfeitProps1);
		Function.Call((Hash)0x55E86AF2712B36A1, 238849, MBTOfficeCounterfeitProps2);
		Function.Call((Hash)0x55E86AF2712B36A1, 238849, MBTOfficeCounterfeitProps3);
		Function.Call((Hash)0x41F37C3427C75AE0, 238849);
		
		//mbt office old spice vintage
		Function.Call((Hash)0x55E86AF2712B36A1, 239105, "office_chairs");
		Function.Call((Hash)0x55E86AF2712B36A1, 239105, MBTOfficeBooze);
		Function.Call((Hash)0x55E86AF2712B36A1, 239105, MBTOfficeCashProps1);
		Function.Call((Hash)0x55E86AF2712B36A1, 239105, MBTOfficeCashProps2);
		Function.Call((Hash)0x55E86AF2712B36A1, 239105, MBTOfficeCashProps3);
		Function.Call((Hash)0x55E86AF2712B36A1, 239105, MBTOfficeCashProps4);
		Function.Call((Hash)0x55E86AF2712B36A1, 239105, MBTOfficeCashProps5);
		Function.Call((Hash)0x55E86AF2712B36A1, 239105, MBTOfficeCashProps6);
		Function.Call((Hash)0x55E86AF2712B36A1, 239105, MBTOfficeCashProps7);
		Function.Call((Hash)0x55E86AF2712B36A1, 239105, MBTOfficeCashProps8);
		Function.Call((Hash)0x55E86AF2712B36A1, 239105, MBTOfficeCashProps9);
		Function.Call((Hash)0x55E86AF2712B36A1, 239105, MBTOfficeCashProps10);
		Function.Call((Hash)0x55E86AF2712B36A1, 239105, MBTOfficeCashProps11);
		Function.Call((Hash)0x55E86AF2712B36A1, 239105, MBTOfficeCashProps12);
		Function.Call((Hash)0x55E86AF2712B36A1, 239105, MBTOfficeCashProps13);
		Function.Call((Hash)0x55E86AF2712B36A1, 239105, MBTOfficeCashProps14);
		Function.Call((Hash)0x55E86AF2712B36A1, 239105, MBTOfficeCashProps15);
		Function.Call((Hash)0x55E86AF2712B36A1, 239105, MBTOfficeCashProps16);
		Function.Call((Hash)0x55E86AF2712B36A1, 239105, MBTOfficeCashProps17);
		Function.Call((Hash)0x55E86AF2712B36A1, 239105, MBTOfficeCashProps18);
		Function.Call((Hash)0x55E86AF2712B36A1, 239105, MBTOfficeCashProps19);
		Function.Call((Hash)0x55E86AF2712B36A1, 239105, MBTOfficeCashProps20);
		Function.Call((Hash)0x55E86AF2712B36A1, 239105, MBTOfficeCashProps21);
		Function.Call((Hash)0x55E86AF2712B36A1, 239105, MBTOfficeCashProps22);
		Function.Call((Hash)0x55E86AF2712B36A1, 239105, MBTOfficeCashProps23);
		Function.Call((Hash)0x55E86AF2712B36A1, 239105, MBTOfficeCashProps24);
		Function.Call((Hash)0x55E86AF2712B36A1, 239105, MBTOfficeSilverProps1);
		Function.Call((Hash)0x55E86AF2712B36A1, 239105, MBTOfficeSilverProps2);
		Function.Call((Hash)0x55E86AF2712B36A1, 239105, MBTOfficeSilverProps3);
		Function.Call((Hash)0x55E86AF2712B36A1, 239105, MBTOfficeDrugBags1);
		Function.Call((Hash)0x55E86AF2712B36A1, 239105, MBTOfficeDrugBags2);
		Function.Call((Hash)0x55E86AF2712B36A1, 239105, MBTOfficeDrugBags3);
		Function.Call((Hash)0x55E86AF2712B36A1, 239105, MBTOfficeCigsProps1);
		Function.Call((Hash)0x55E86AF2712B36A1, 239105, MBTOfficeCigsProps2);
		Function.Call((Hash)0x55E86AF2712B36A1, 239105, MBTOfficeCigsProps3);
		Function.Call((Hash)0x55E86AF2712B36A1, 239105, MBTOfficeElectronicProps1);
		Function.Call((Hash)0x55E86AF2712B36A1, 239105, MBTOfficeElectronicProps2);
		Function.Call((Hash)0x55E86AF2712B36A1, 239105, MBTOfficeElectronicProps3);
		Function.Call((Hash)0x55E86AF2712B36A1, 239105, MBTOfficeDrugStatue1);
		Function.Call((Hash)0x55E86AF2712B36A1, 239105, MBTOfficeDrugStatue2);
		Function.Call((Hash)0x55E86AF2712B36A1, 239105, MBTOfficeDrugStatue3);
		Function.Call((Hash)0x55E86AF2712B36A1, 239105, MBTOfficeIvoryProps1);
		Function.Call((Hash)0x55E86AF2712B36A1, 239105, MBTOfficeIvoryProps2);
		Function.Call((Hash)0x55E86AF2712B36A1, 239105, MBTOfficeIvoryProps3);
		Function.Call((Hash)0x55E86AF2712B36A1, 239105, MBTOfficePillsProps1);
		Function.Call((Hash)0x55E86AF2712B36A1, 239105, MBTOfficePillsProps2);
		Function.Call((Hash)0x55E86AF2712B36A1, 239105, MBTOfficePillsProps3);
		Function.Call((Hash)0x55E86AF2712B36A1, 239105, MBTOfficeJewelWatchProps1);
		Function.Call((Hash)0x55E86AF2712B36A1, 239105, MBTOfficeJewelWatchProps2);
		Function.Call((Hash)0x55E86AF2712B36A1, 239105, MBTOfficeJewelWatchProps3);
		Function.Call((Hash)0x55E86AF2712B36A1, 239105, MBTOfficeFurCoats1);
		Function.Call((Hash)0x55E86AF2712B36A1, 239105, MBTOfficeFurCoats2);
		Function.Call((Hash)0x55E86AF2712B36A1, 239105, MBTOfficeFurCoats3);
		Function.Call((Hash)0x55E86AF2712B36A1, 239105, MBTOfficeArtProps1);
		Function.Call((Hash)0x55E86AF2712B36A1, 239105, MBTOfficeArtProps2);
		Function.Call((Hash)0x55E86AF2712B36A1, 239105, MBTOfficeArtProps3);
		Function.Call((Hash)0x55E86AF2712B36A1, 239105, MBTOfficeGuns1);
		Function.Call((Hash)0x55E86AF2712B36A1, 239105, MBTOfficeGuns2);
		Function.Call((Hash)0x55E86AF2712B36A1, 239105, MBTOfficeGuns3);
		Function.Call((Hash)0x55E86AF2712B36A1, 239105, MBTOfficeMedProps1);
		Function.Call((Hash)0x55E86AF2712B36A1, 239105, MBTOfficeMedProps2);
		Function.Call((Hash)0x55E86AF2712B36A1, 239105, MBTOfficeGemProps3);
		Function.Call((Hash)0x55E86AF2712B36A1, 239105, MBTOfficeGemProps1);
		Function.Call((Hash)0x55E86AF2712B36A1, 239105, MBTOfficeGemProps2);
		Function.Call((Hash)0x55E86AF2712B36A1, 239105, MBTOfficeMedProps3);
		Function.Call((Hash)0x55E86AF2712B36A1, 239105, MBTOfficeCounterfeitProps1);
		Function.Call((Hash)0x55E86AF2712B36A1, 239105, MBTOfficeCounterfeitProps2);
		Function.Call((Hash)0x55E86AF2712B36A1, 239105, MBTOfficeCounterfeitProps3);
		Function.Call((Hash)0x41F37C3427C75AE0, 239105);
		
		//mbt office executive contrast
		Function.Call((Hash)0x55E86AF2712B36A1, 239361, "office_chairs");
		Function.Call((Hash)0x55E86AF2712B36A1, 239361, MBTOfficeBooze);
		Function.Call((Hash)0x55E86AF2712B36A1, 239361, MBTOfficeCashProps1);
		Function.Call((Hash)0x55E86AF2712B36A1, 239361, MBTOfficeCashProps2);
		Function.Call((Hash)0x55E86AF2712B36A1, 239361, MBTOfficeCashProps3);
		Function.Call((Hash)0x55E86AF2712B36A1, 239361, MBTOfficeCashProps4);
		Function.Call((Hash)0x55E86AF2712B36A1, 239361, MBTOfficeCashProps5);
		Function.Call((Hash)0x55E86AF2712B36A1, 239361, MBTOfficeCashProps6);
		Function.Call((Hash)0x55E86AF2712B36A1, 239361, MBTOfficeCashProps7);
		Function.Call((Hash)0x55E86AF2712B36A1, 239361, MBTOfficeCashProps8);
		Function.Call((Hash)0x55E86AF2712B36A1, 239361, MBTOfficeCashProps9);
		Function.Call((Hash)0x55E86AF2712B36A1, 239361, MBTOfficeCashProps10);
		Function.Call((Hash)0x55E86AF2712B36A1, 239361, MBTOfficeCashProps11);
		Function.Call((Hash)0x55E86AF2712B36A1, 239361, MBTOfficeCashProps12);
		Function.Call((Hash)0x55E86AF2712B36A1, 239361, MBTOfficeCashProps13);
		Function.Call((Hash)0x55E86AF2712B36A1, 239361, MBTOfficeCashProps14);
		Function.Call((Hash)0x55E86AF2712B36A1, 239361, MBTOfficeCashProps15);
		Function.Call((Hash)0x55E86AF2712B36A1, 239361, MBTOfficeCashProps16);
		Function.Call((Hash)0x55E86AF2712B36A1, 239361, MBTOfficeCashProps17);
		Function.Call((Hash)0x55E86AF2712B36A1, 239361, MBTOfficeCashProps18);
		Function.Call((Hash)0x55E86AF2712B36A1, 239361, MBTOfficeCashProps19);
		Function.Call((Hash)0x55E86AF2712B36A1, 239361, MBTOfficeCashProps20);
		Function.Call((Hash)0x55E86AF2712B36A1, 239361, MBTOfficeCashProps21);
		Function.Call((Hash)0x55E86AF2712B36A1, 239361, MBTOfficeCashProps22);
		Function.Call((Hash)0x55E86AF2712B36A1, 239361, MBTOfficeCashProps23);
		Function.Call((Hash)0x55E86AF2712B36A1, 239361, MBTOfficeCashProps24);
		Function.Call((Hash)0x55E86AF2712B36A1, 239361, MBTOfficeSilverProps1);
		Function.Call((Hash)0x55E86AF2712B36A1, 239361, MBTOfficeSilverProps2);
		Function.Call((Hash)0x55E86AF2712B36A1, 239361, MBTOfficeSilverProps3);
		Function.Call((Hash)0x55E86AF2712B36A1, 239361, MBTOfficeDrugBags1);
		Function.Call((Hash)0x55E86AF2712B36A1, 239361, MBTOfficeDrugBags2);
		Function.Call((Hash)0x55E86AF2712B36A1, 239361, MBTOfficeDrugBags3);
		Function.Call((Hash)0x55E86AF2712B36A1, 239361, MBTOfficeCigsProps1);
		Function.Call((Hash)0x55E86AF2712B36A1, 239361, MBTOfficeCigsProps2);
		Function.Call((Hash)0x55E86AF2712B36A1, 239361, MBTOfficeCigsProps3);
		Function.Call((Hash)0x55E86AF2712B36A1, 239361, MBTOfficeElectronicProps1);
		Function.Call((Hash)0x55E86AF2712B36A1, 239361, MBTOfficeElectronicProps2);
		Function.Call((Hash)0x55E86AF2712B36A1, 239361, MBTOfficeElectronicProps3);
		Function.Call((Hash)0x55E86AF2712B36A1, 239361, MBTOfficeDrugStatue1);
		Function.Call((Hash)0x55E86AF2712B36A1, 239361, MBTOfficeDrugStatue2);
		Function.Call((Hash)0x55E86AF2712B36A1, 239361, MBTOfficeDrugStatue3);
		Function.Call((Hash)0x55E86AF2712B36A1, 239361, MBTOfficeIvoryProps1);
		Function.Call((Hash)0x55E86AF2712B36A1, 239361, MBTOfficeIvoryProps2);
		Function.Call((Hash)0x55E86AF2712B36A1, 239361, MBTOfficeIvoryProps3);
		Function.Call((Hash)0x55E86AF2712B36A1, 239361, MBTOfficePillsProps1);
		Function.Call((Hash)0x55E86AF2712B36A1, 239361, MBTOfficePillsProps2);
		Function.Call((Hash)0x55E86AF2712B36A1, 239361, MBTOfficePillsProps3);
		Function.Call((Hash)0x55E86AF2712B36A1, 239361, MBTOfficeJewelWatchProps1);
		Function.Call((Hash)0x55E86AF2712B36A1, 239361, MBTOfficeJewelWatchProps2);
		Function.Call((Hash)0x55E86AF2712B36A1, 239361, MBTOfficeJewelWatchProps3);
		Function.Call((Hash)0x55E86AF2712B36A1, 239361, MBTOfficeFurCoats1);
		Function.Call((Hash)0x55E86AF2712B36A1, 239361, MBTOfficeFurCoats2);
		Function.Call((Hash)0x55E86AF2712B36A1, 239361, MBTOfficeFurCoats3);
		Function.Call((Hash)0x55E86AF2712B36A1, 239361, MBTOfficeArtProps1);
		Function.Call((Hash)0x55E86AF2712B36A1, 239361, MBTOfficeArtProps2);
		Function.Call((Hash)0x55E86AF2712B36A1, 239361, MBTOfficeArtProps3);
		Function.Call((Hash)0x55E86AF2712B36A1, 239361, MBTOfficeGuns1);
		Function.Call((Hash)0x55E86AF2712B36A1, 239361, MBTOfficeGuns2);
		Function.Call((Hash)0x55E86AF2712B36A1, 239361, MBTOfficeGuns3);
		Function.Call((Hash)0x55E86AF2712B36A1, 239361, MBTOfficeMedProps1);
		Function.Call((Hash)0x55E86AF2712B36A1, 239361, MBTOfficeMedProps2);
		Function.Call((Hash)0x55E86AF2712B36A1, 239361, MBTOfficeGemProps3);
		Function.Call((Hash)0x55E86AF2712B36A1, 239361, MBTOfficeGemProps1);
		Function.Call((Hash)0x55E86AF2712B36A1, 239361, MBTOfficeGemProps2);
		Function.Call((Hash)0x55E86AF2712B36A1, 239361, MBTOfficeMedProps3);
		Function.Call((Hash)0x55E86AF2712B36A1, 239361, MBTOfficeCounterfeitProps1);
		Function.Call((Hash)0x55E86AF2712B36A1, 239361, MBTOfficeCounterfeitProps2);
		Function.Call((Hash)0x55E86AF2712B36A1, 239361, MBTOfficeCounterfeitProps3);
		Function.Call((Hash)0x41F37C3427C75AE0, 239361);
		
		//mbt office executive rich
		Function.Call((Hash)0x55E86AF2712B36A1, 239617, "office_chairs");
		Function.Call((Hash)0x55E86AF2712B36A1, 239617, MBTOfficeBooze);
		Function.Call((Hash)0x55E86AF2712B36A1, 239617, MBTOfficeCashProps1);
		Function.Call((Hash)0x55E86AF2712B36A1, 239617, MBTOfficeCashProps2);
		Function.Call((Hash)0x55E86AF2712B36A1, 239617, MBTOfficeCashProps3);
		Function.Call((Hash)0x55E86AF2712B36A1, 239617, MBTOfficeCashProps4);
		Function.Call((Hash)0x55E86AF2712B36A1, 239617, MBTOfficeCashProps5);
		Function.Call((Hash)0x55E86AF2712B36A1, 239617, MBTOfficeCashProps6);
		Function.Call((Hash)0x55E86AF2712B36A1, 239617, MBTOfficeCashProps7);
		Function.Call((Hash)0x55E86AF2712B36A1, 239617, MBTOfficeCashProps8);
		Function.Call((Hash)0x55E86AF2712B36A1, 239617, MBTOfficeCashProps9);
		Function.Call((Hash)0x55E86AF2712B36A1, 239617, MBTOfficeCashProps10);
		Function.Call((Hash)0x55E86AF2712B36A1, 239617, MBTOfficeCashProps11);
		Function.Call((Hash)0x55E86AF2712B36A1, 239617, MBTOfficeCashProps12);
		Function.Call((Hash)0x55E86AF2712B36A1, 239617, MBTOfficeCashProps13);
		Function.Call((Hash)0x55E86AF2712B36A1, 239617, MBTOfficeCashProps14);
		Function.Call((Hash)0x55E86AF2712B36A1, 239617, MBTOfficeCashProps15);
		Function.Call((Hash)0x55E86AF2712B36A1, 239617, MBTOfficeCashProps16);
		Function.Call((Hash)0x55E86AF2712B36A1, 239617, MBTOfficeCashProps17);
		Function.Call((Hash)0x55E86AF2712B36A1, 239617, MBTOfficeCashProps18);
		Function.Call((Hash)0x55E86AF2712B36A1, 239617, MBTOfficeCashProps19);
		Function.Call((Hash)0x55E86AF2712B36A1, 239617, MBTOfficeCashProps20);
		Function.Call((Hash)0x55E86AF2712B36A1, 239617, MBTOfficeCashProps21);
		Function.Call((Hash)0x55E86AF2712B36A1, 239617, MBTOfficeCashProps22);
		Function.Call((Hash)0x55E86AF2712B36A1, 239617, MBTOfficeCashProps23);
		Function.Call((Hash)0x55E86AF2712B36A1, 239617, MBTOfficeCashProps24);
		Function.Call((Hash)0x55E86AF2712B36A1, 239617, MBTOfficeSilverProps1);
		Function.Call((Hash)0x55E86AF2712B36A1, 239617, MBTOfficeSilverProps2);
		Function.Call((Hash)0x55E86AF2712B36A1, 239617, MBTOfficeSilverProps3);
		Function.Call((Hash)0x55E86AF2712B36A1, 239617, MBTOfficeDrugBags1);
		Function.Call((Hash)0x55E86AF2712B36A1, 239617, MBTOfficeDrugBags2);
		Function.Call((Hash)0x55E86AF2712B36A1, 239617, MBTOfficeDrugBags3);
		Function.Call((Hash)0x55E86AF2712B36A1, 239617, MBTOfficeCigsProps1);
		Function.Call((Hash)0x55E86AF2712B36A1, 239617, MBTOfficeCigsProps2);
		Function.Call((Hash)0x55E86AF2712B36A1, 239617, MBTOfficeCigsProps3);
		Function.Call((Hash)0x55E86AF2712B36A1, 239617, MBTOfficeElectronicProps1);
		Function.Call((Hash)0x55E86AF2712B36A1, 239617, MBTOfficeElectronicProps2);
		Function.Call((Hash)0x55E86AF2712B36A1, 239617, MBTOfficeElectronicProps3);
		Function.Call((Hash)0x55E86AF2712B36A1, 239617, MBTOfficeDrugStatue1);
		Function.Call((Hash)0x55E86AF2712B36A1, 239617, MBTOfficeDrugStatue2);
		Function.Call((Hash)0x55E86AF2712B36A1, 239617, MBTOfficeDrugStatue3);
		Function.Call((Hash)0x55E86AF2712B36A1, 239617, MBTOfficeIvoryProps1);
		Function.Call((Hash)0x55E86AF2712B36A1, 239617, MBTOfficeIvoryProps2);
		Function.Call((Hash)0x55E86AF2712B36A1, 239617, MBTOfficeIvoryProps3);
		Function.Call((Hash)0x55E86AF2712B36A1, 239617, MBTOfficePillsProps1);
		Function.Call((Hash)0x55E86AF2712B36A1, 239617, MBTOfficePillsProps2);
		Function.Call((Hash)0x55E86AF2712B36A1, 239617, MBTOfficePillsProps3);
		Function.Call((Hash)0x55E86AF2712B36A1, 239617, MBTOfficeJewelWatchProps1);
		Function.Call((Hash)0x55E86AF2712B36A1, 239617, MBTOfficeJewelWatchProps2);
		Function.Call((Hash)0x55E86AF2712B36A1, 239617, MBTOfficeJewelWatchProps3);
		Function.Call((Hash)0x55E86AF2712B36A1, 239617, MBTOfficeFurCoats1);
		Function.Call((Hash)0x55E86AF2712B36A1, 239617, MBTOfficeFurCoats2);
		Function.Call((Hash)0x55E86AF2712B36A1, 239617, MBTOfficeFurCoats3);
		Function.Call((Hash)0x55E86AF2712B36A1, 239617, MBTOfficeArtProps1);
		Function.Call((Hash)0x55E86AF2712B36A1, 239617, MBTOfficeArtProps2);
		Function.Call((Hash)0x55E86AF2712B36A1, 239617, MBTOfficeArtProps3);
		Function.Call((Hash)0x55E86AF2712B36A1, 239617, MBTOfficeGuns1);
		Function.Call((Hash)0x55E86AF2712B36A1, 239617, MBTOfficeGuns2);
		Function.Call((Hash)0x55E86AF2712B36A1, 239617, MBTOfficeGuns3);
		Function.Call((Hash)0x55E86AF2712B36A1, 239617, MBTOfficeMedProps1);
		Function.Call((Hash)0x55E86AF2712B36A1, 239617, MBTOfficeMedProps2);
		Function.Call((Hash)0x55E86AF2712B36A1, 239617, MBTOfficeGemProps3);
		Function.Call((Hash)0x55E86AF2712B36A1, 239617, MBTOfficeGemProps1);
		Function.Call((Hash)0x55E86AF2712B36A1, 239617, MBTOfficeGemProps2);
		Function.Call((Hash)0x55E86AF2712B36A1, 239617, MBTOfficeMedProps3);
		Function.Call((Hash)0x55E86AF2712B36A1, 239617, MBTOfficeCounterfeitProps1);
		Function.Call((Hash)0x55E86AF2712B36A1, 239617, MBTOfficeCounterfeitProps2);
		Function.Call((Hash)0x55E86AF2712B36A1, 239617, MBTOfficeCounterfeitProps3);
		Function.Call((Hash)0x41F37C3427C75AE0, 239617);
		
		//mbt office executive cool
		Function.Call((Hash)0x55E86AF2712B36A1, 239873, "office_chairs");
		Function.Call((Hash)0x55E86AF2712B36A1, 239873, MBTOfficeBooze);
		Function.Call((Hash)0x55E86AF2712B36A1, 239873, MBTOfficeCashProps1);
		Function.Call((Hash)0x55E86AF2712B36A1, 239873, MBTOfficeCashProps2);
		Function.Call((Hash)0x55E86AF2712B36A1, 239873, MBTOfficeCashProps3);
		Function.Call((Hash)0x55E86AF2712B36A1, 239873, MBTOfficeCashProps4);
		Function.Call((Hash)0x55E86AF2712B36A1, 239873, MBTOfficeCashProps5);
		Function.Call((Hash)0x55E86AF2712B36A1, 239873, MBTOfficeCashProps6);
		Function.Call((Hash)0x55E86AF2712B36A1, 239873, MBTOfficeCashProps7);
		Function.Call((Hash)0x55E86AF2712B36A1, 239873, MBTOfficeCashProps8);
		Function.Call((Hash)0x55E86AF2712B36A1, 239873, MBTOfficeCashProps9);
		Function.Call((Hash)0x55E86AF2712B36A1, 239873, MBTOfficeCashProps10);
		Function.Call((Hash)0x55E86AF2712B36A1, 239873, MBTOfficeCashProps11);
		Function.Call((Hash)0x55E86AF2712B36A1, 239873, MBTOfficeCashProps12);
		Function.Call((Hash)0x55E86AF2712B36A1, 239873, MBTOfficeCashProps13);
		Function.Call((Hash)0x55E86AF2712B36A1, 239873, MBTOfficeCashProps14);
		Function.Call((Hash)0x55E86AF2712B36A1, 239873, MBTOfficeCashProps15);
		Function.Call((Hash)0x55E86AF2712B36A1, 239873, MBTOfficeCashProps16);
		Function.Call((Hash)0x55E86AF2712B36A1, 239873, MBTOfficeCashProps17);
		Function.Call((Hash)0x55E86AF2712B36A1, 239873, MBTOfficeCashProps18);
		Function.Call((Hash)0x55E86AF2712B36A1, 239873, MBTOfficeCashProps19);
		Function.Call((Hash)0x55E86AF2712B36A1, 239873, MBTOfficeCashProps20);
		Function.Call((Hash)0x55E86AF2712B36A1, 239873, MBTOfficeCashProps21);
		Function.Call((Hash)0x55E86AF2712B36A1, 239873, MBTOfficeCashProps22);
		Function.Call((Hash)0x55E86AF2712B36A1, 239873, MBTOfficeCashProps23);
		Function.Call((Hash)0x55E86AF2712B36A1, 239873, MBTOfficeCashProps24);
		Function.Call((Hash)0x55E86AF2712B36A1, 239873, MBTOfficeSilverProps1);
		Function.Call((Hash)0x55E86AF2712B36A1, 239873, MBTOfficeSilverProps2);
		Function.Call((Hash)0x55E86AF2712B36A1, 239873, MBTOfficeSilverProps3);
		Function.Call((Hash)0x55E86AF2712B36A1, 239873, MBTOfficeDrugBags1);
		Function.Call((Hash)0x55E86AF2712B36A1, 239873, MBTOfficeDrugBags2);
		Function.Call((Hash)0x55E86AF2712B36A1, 239873, MBTOfficeDrugBags3);
		Function.Call((Hash)0x55E86AF2712B36A1, 239873, MBTOfficeCigsProps1);
		Function.Call((Hash)0x55E86AF2712B36A1, 239873, MBTOfficeCigsProps2);
		Function.Call((Hash)0x55E86AF2712B36A1, 239873, MBTOfficeCigsProps3);
		Function.Call((Hash)0x55E86AF2712B36A1, 239873, MBTOfficeElectronicProps1);
		Function.Call((Hash)0x55E86AF2712B36A1, 239873, MBTOfficeElectronicProps2);
		Function.Call((Hash)0x55E86AF2712B36A1, 239873, MBTOfficeElectronicProps3);
		Function.Call((Hash)0x55E86AF2712B36A1, 239873, MBTOfficeDrugStatue1);
		Function.Call((Hash)0x55E86AF2712B36A1, 239873, MBTOfficeDrugStatue2);
		Function.Call((Hash)0x55E86AF2712B36A1, 239873, MBTOfficeDrugStatue3);
		Function.Call((Hash)0x55E86AF2712B36A1, 239873, MBTOfficeIvoryProps1);
		Function.Call((Hash)0x55E86AF2712B36A1, 239873, MBTOfficeIvoryProps2);
		Function.Call((Hash)0x55E86AF2712B36A1, 239873, MBTOfficeIvoryProps3);
		Function.Call((Hash)0x55E86AF2712B36A1, 239873, MBTOfficePillsProps1);
		Function.Call((Hash)0x55E86AF2712B36A1, 239873, MBTOfficePillsProps2);
		Function.Call((Hash)0x55E86AF2712B36A1, 239873, MBTOfficePillsProps3);
		Function.Call((Hash)0x55E86AF2712B36A1, 239873, MBTOfficeJewelWatchProps1);
		Function.Call((Hash)0x55E86AF2712B36A1, 239873, MBTOfficeJewelWatchProps2);
		Function.Call((Hash)0x55E86AF2712B36A1, 239873, MBTOfficeJewelWatchProps3);
		Function.Call((Hash)0x55E86AF2712B36A1, 239873, MBTOfficeFurCoats1);
		Function.Call((Hash)0x55E86AF2712B36A1, 239873, MBTOfficeFurCoats2);
		Function.Call((Hash)0x55E86AF2712B36A1, 239873, MBTOfficeFurCoats3);
		Function.Call((Hash)0x55E86AF2712B36A1, 239873, MBTOfficeArtProps1);
		Function.Call((Hash)0x55E86AF2712B36A1, 239873, MBTOfficeArtProps2);
		Function.Call((Hash)0x55E86AF2712B36A1, 239873, MBTOfficeArtProps3);
		Function.Call((Hash)0x55E86AF2712B36A1, 239873, MBTOfficeGuns1);
		Function.Call((Hash)0x55E86AF2712B36A1, 239873, MBTOfficeGuns2);
		Function.Call((Hash)0x55E86AF2712B36A1, 239873, MBTOfficeGuns3);
		Function.Call((Hash)0x55E86AF2712B36A1, 239873, MBTOfficeMedProps1);
		Function.Call((Hash)0x55E86AF2712B36A1, 239873, MBTOfficeMedProps2);
		Function.Call((Hash)0x55E86AF2712B36A1, 239873, MBTOfficeGemProps3);
		Function.Call((Hash)0x55E86AF2712B36A1, 239873, MBTOfficeGemProps1);
		Function.Call((Hash)0x55E86AF2712B36A1, 239873, MBTOfficeGemProps2);
		Function.Call((Hash)0x55E86AF2712B36A1, 239873, MBTOfficeMedProps3);
		Function.Call((Hash)0x55E86AF2712B36A1, 239873, MBTOfficeCounterfeitProps1);
		Function.Call((Hash)0x55E86AF2712B36A1, 239873, MBTOfficeCounterfeitProps2);
		Function.Call((Hash)0x55E86AF2712B36A1, 239873, MBTOfficeCounterfeitProps3);
		Function.Call((Hash)0x41F37C3427C75AE0, 239873);
		
		//mbt office power broker ice
		Function.Call((Hash)0x55E86AF2712B36A1, 240129, "office_chairs");
		Function.Call((Hash)0x55E86AF2712B36A1, 240129, MBTOfficeBooze);
		Function.Call((Hash)0x55E86AF2712B36A1, 240129, MBTOfficeCashProps1);
		Function.Call((Hash)0x55E86AF2712B36A1, 240129, MBTOfficeCashProps2);
		Function.Call((Hash)0x55E86AF2712B36A1, 240129, MBTOfficeCashProps3);
		Function.Call((Hash)0x55E86AF2712B36A1, 240129, MBTOfficeCashProps4);
		Function.Call((Hash)0x55E86AF2712B36A1, 240129, MBTOfficeCashProps5);
		Function.Call((Hash)0x55E86AF2712B36A1, 240129, MBTOfficeCashProps6);
		Function.Call((Hash)0x55E86AF2712B36A1, 240129, MBTOfficeCashProps7);
		Function.Call((Hash)0x55E86AF2712B36A1, 240129, MBTOfficeCashProps8);
		Function.Call((Hash)0x55E86AF2712B36A1, 240129, MBTOfficeCashProps9);
		Function.Call((Hash)0x55E86AF2712B36A1, 240129, MBTOfficeCashProps10);
		Function.Call((Hash)0x55E86AF2712B36A1, 240129, MBTOfficeCashProps11);
		Function.Call((Hash)0x55E86AF2712B36A1, 240129, MBTOfficeCashProps12);
		Function.Call((Hash)0x55E86AF2712B36A1, 240129, MBTOfficeCashProps13);
		Function.Call((Hash)0x55E86AF2712B36A1, 240129, MBTOfficeCashProps14);
		Function.Call((Hash)0x55E86AF2712B36A1, 240129, MBTOfficeCashProps15);
		Function.Call((Hash)0x55E86AF2712B36A1, 240129, MBTOfficeCashProps16);
		Function.Call((Hash)0x55E86AF2712B36A1, 240129, MBTOfficeCashProps17);
		Function.Call((Hash)0x55E86AF2712B36A1, 240129, MBTOfficeCashProps18);
		Function.Call((Hash)0x55E86AF2712B36A1, 240129, MBTOfficeCashProps19);
		Function.Call((Hash)0x55E86AF2712B36A1, 240129, MBTOfficeCashProps20);
		Function.Call((Hash)0x55E86AF2712B36A1, 240129, MBTOfficeCashProps21);
		Function.Call((Hash)0x55E86AF2712B36A1, 240129, MBTOfficeCashProps22);
		Function.Call((Hash)0x55E86AF2712B36A1, 240129, MBTOfficeCashProps23);
		Function.Call((Hash)0x55E86AF2712B36A1, 240129, MBTOfficeCashProps24);
		Function.Call((Hash)0x55E86AF2712B36A1, 240129, MBTOfficeSilverProps1);
		Function.Call((Hash)0x55E86AF2712B36A1, 240129, MBTOfficeSilverProps2);
		Function.Call((Hash)0x55E86AF2712B36A1, 240129, MBTOfficeSilverProps3);
		Function.Call((Hash)0x55E86AF2712B36A1, 240129, MBTOfficeDrugBags1);
		Function.Call((Hash)0x55E86AF2712B36A1, 240129, MBTOfficeDrugBags2);
		Function.Call((Hash)0x55E86AF2712B36A1, 240129, MBTOfficeDrugBags3);
		Function.Call((Hash)0x55E86AF2712B36A1, 240129, MBTOfficeCigsProps1);
		Function.Call((Hash)0x55E86AF2712B36A1, 240129, MBTOfficeCigsProps2);
		Function.Call((Hash)0x55E86AF2712B36A1, 240129, MBTOfficeCigsProps3);
		Function.Call((Hash)0x55E86AF2712B36A1, 240129, MBTOfficeElectronicProps1);
		Function.Call((Hash)0x55E86AF2712B36A1, 240129, MBTOfficeElectronicProps2);
		Function.Call((Hash)0x55E86AF2712B36A1, 240129, MBTOfficeElectronicProps3);
		Function.Call((Hash)0x55E86AF2712B36A1, 240129, MBTOfficeDrugStatue1);
		Function.Call((Hash)0x55E86AF2712B36A1, 240129, MBTOfficeDrugStatue2);
		Function.Call((Hash)0x55E86AF2712B36A1, 240129, MBTOfficeDrugStatue3);
		Function.Call((Hash)0x55E86AF2712B36A1, 240129, MBTOfficeIvoryProps1);
		Function.Call((Hash)0x55E86AF2712B36A1, 240129, MBTOfficeIvoryProps2);
		Function.Call((Hash)0x55E86AF2712B36A1, 240129, MBTOfficeIvoryProps3);
		Function.Call((Hash)0x55E86AF2712B36A1, 240129, MBTOfficePillsProps1);
		Function.Call((Hash)0x55E86AF2712B36A1, 240129, MBTOfficePillsProps2);
		Function.Call((Hash)0x55E86AF2712B36A1, 240129, MBTOfficePillsProps3);
		Function.Call((Hash)0x55E86AF2712B36A1, 240129, MBTOfficeJewelWatchProps1);
		Function.Call((Hash)0x55E86AF2712B36A1, 240129, MBTOfficeJewelWatchProps2);
		Function.Call((Hash)0x55E86AF2712B36A1, 240129, MBTOfficeJewelWatchProps3);
		Function.Call((Hash)0x55E86AF2712B36A1, 240129, MBTOfficeFurCoats1);
		Function.Call((Hash)0x55E86AF2712B36A1, 240129, MBTOfficeFurCoats2);
		Function.Call((Hash)0x55E86AF2712B36A1, 240129, MBTOfficeFurCoats3);
		Function.Call((Hash)0x55E86AF2712B36A1, 240129, MBTOfficeArtProps1);
		Function.Call((Hash)0x55E86AF2712B36A1, 240129, MBTOfficeArtProps2);
		Function.Call((Hash)0x55E86AF2712B36A1, 240129, MBTOfficeArtProps3);
		Function.Call((Hash)0x55E86AF2712B36A1, 240129, MBTOfficeGuns1);
		Function.Call((Hash)0x55E86AF2712B36A1, 240129, MBTOfficeGuns2);
		Function.Call((Hash)0x55E86AF2712B36A1, 240129, MBTOfficeGuns3);
		Function.Call((Hash)0x55E86AF2712B36A1, 240129, MBTOfficeMedProps1);
		Function.Call((Hash)0x55E86AF2712B36A1, 240129, MBTOfficeMedProps2);
		Function.Call((Hash)0x55E86AF2712B36A1, 240129, MBTOfficeGemProps3);
		Function.Call((Hash)0x55E86AF2712B36A1, 240129, MBTOfficeGemProps1);
		Function.Call((Hash)0x55E86AF2712B36A1, 240129, MBTOfficeGemProps2);
		Function.Call((Hash)0x55E86AF2712B36A1, 240129, MBTOfficeMedProps3);
		Function.Call((Hash)0x55E86AF2712B36A1, 240129, MBTOfficeCounterfeitProps1);
		Function.Call((Hash)0x55E86AF2712B36A1, 240129, MBTOfficeCounterfeitProps2);
		Function.Call((Hash)0x55E86AF2712B36A1, 240129, MBTOfficeCounterfeitProps3);
		Function.Call((Hash)0x41F37C3427C75AE0, 240129);
		
		//mbt office power broker conservative
		Function.Call((Hash)0x55E86AF2712B36A1, 240385, "office_chairs");
		Function.Call((Hash)0x55E86AF2712B36A1, 240385, MBTOfficeBooze);
		Function.Call((Hash)0x55E86AF2712B36A1, 240385, MBTOfficeCashProps1);
		Function.Call((Hash)0x55E86AF2712B36A1, 240385, MBTOfficeCashProps2);
		Function.Call((Hash)0x55E86AF2712B36A1, 240385, MBTOfficeCashProps3);
		Function.Call((Hash)0x55E86AF2712B36A1, 240385, MBTOfficeCashProps4);
		Function.Call((Hash)0x55E86AF2712B36A1, 240385, MBTOfficeCashProps5);
		Function.Call((Hash)0x55E86AF2712B36A1, 240385, MBTOfficeCashProps6);
		Function.Call((Hash)0x55E86AF2712B36A1, 240385, MBTOfficeCashProps7);
		Function.Call((Hash)0x55E86AF2712B36A1, 240385, MBTOfficeCashProps8);
		Function.Call((Hash)0x55E86AF2712B36A1, 240385, MBTOfficeCashProps9);
		Function.Call((Hash)0x55E86AF2712B36A1, 240385, MBTOfficeCashProps10);
		Function.Call((Hash)0x55E86AF2712B36A1, 240385, MBTOfficeCashProps11);
		Function.Call((Hash)0x55E86AF2712B36A1, 240385, MBTOfficeCashProps12);
		Function.Call((Hash)0x55E86AF2712B36A1, 240385, MBTOfficeCashProps13);
		Function.Call((Hash)0x55E86AF2712B36A1, 240385, MBTOfficeCashProps14);
		Function.Call((Hash)0x55E86AF2712B36A1, 240385, MBTOfficeCashProps15);
		Function.Call((Hash)0x55E86AF2712B36A1, 240385, MBTOfficeCashProps16);
		Function.Call((Hash)0x55E86AF2712B36A1, 240385, MBTOfficeCashProps17);
		Function.Call((Hash)0x55E86AF2712B36A1, 240385, MBTOfficeCashProps18);
		Function.Call((Hash)0x55E86AF2712B36A1, 240385, MBTOfficeCashProps19);
		Function.Call((Hash)0x55E86AF2712B36A1, 240385, MBTOfficeCashProps20);
		Function.Call((Hash)0x55E86AF2712B36A1, 240385, MBTOfficeCashProps21);
		Function.Call((Hash)0x55E86AF2712B36A1, 240385, MBTOfficeCashProps22);
		Function.Call((Hash)0x55E86AF2712B36A1, 240385, MBTOfficeCashProps23);
		Function.Call((Hash)0x55E86AF2712B36A1, 240385, MBTOfficeCashProps24);
		Function.Call((Hash)0x55E86AF2712B36A1, 240385, MBTOfficeSilverProps1);
		Function.Call((Hash)0x55E86AF2712B36A1, 240385, MBTOfficeSilverProps2);
		Function.Call((Hash)0x55E86AF2712B36A1, 240385, MBTOfficeSilverProps3);
		Function.Call((Hash)0x55E86AF2712B36A1, 240385, MBTOfficeDrugBags1);
		Function.Call((Hash)0x55E86AF2712B36A1, 240385, MBTOfficeDrugBags2);
		Function.Call((Hash)0x55E86AF2712B36A1, 240385, MBTOfficeDrugBags3);
		Function.Call((Hash)0x55E86AF2712B36A1, 240385, MBTOfficeCigsProps1);
		Function.Call((Hash)0x55E86AF2712B36A1, 240385, MBTOfficeCigsProps2);
		Function.Call((Hash)0x55E86AF2712B36A1, 240385, MBTOfficeCigsProps3);
		Function.Call((Hash)0x55E86AF2712B36A1, 240385, MBTOfficeElectronicProps1);
		Function.Call((Hash)0x55E86AF2712B36A1, 240385, MBTOfficeElectronicProps2);
		Function.Call((Hash)0x55E86AF2712B36A1, 240385, MBTOfficeElectronicProps3);
		Function.Call((Hash)0x55E86AF2712B36A1, 240385, MBTOfficeDrugStatue1);
		Function.Call((Hash)0x55E86AF2712B36A1, 240385, MBTOfficeDrugStatue2);
		Function.Call((Hash)0x55E86AF2712B36A1, 240385, MBTOfficeDrugStatue3);
		Function.Call((Hash)0x55E86AF2712B36A1, 240385, MBTOfficeIvoryProps1);
		Function.Call((Hash)0x55E86AF2712B36A1, 240385, MBTOfficeIvoryProps2);
		Function.Call((Hash)0x55E86AF2712B36A1, 240385, MBTOfficeIvoryProps3);
		Function.Call((Hash)0x55E86AF2712B36A1, 240385, MBTOfficePillsProps1);
		Function.Call((Hash)0x55E86AF2712B36A1, 240385, MBTOfficePillsProps2);
		Function.Call((Hash)0x55E86AF2712B36A1, 240385, MBTOfficePillsProps3);
		Function.Call((Hash)0x55E86AF2712B36A1, 240385, MBTOfficeJewelWatchProps1);
		Function.Call((Hash)0x55E86AF2712B36A1, 240385, MBTOfficeJewelWatchProps2);
		Function.Call((Hash)0x55E86AF2712B36A1, 240385, MBTOfficeJewelWatchProps3);
		Function.Call((Hash)0x55E86AF2712B36A1, 240385, MBTOfficeFurCoats1);
		Function.Call((Hash)0x55E86AF2712B36A1, 240385, MBTOfficeFurCoats2);
		Function.Call((Hash)0x55E86AF2712B36A1, 240385, MBTOfficeFurCoats3);
		Function.Call((Hash)0x55E86AF2712B36A1, 240385, MBTOfficeArtProps1);
		Function.Call((Hash)0x55E86AF2712B36A1, 240385, MBTOfficeArtProps2);
		Function.Call((Hash)0x55E86AF2712B36A1, 240385, MBTOfficeArtProps3);
		Function.Call((Hash)0x55E86AF2712B36A1, 240385, MBTOfficeGuns1);
		Function.Call((Hash)0x55E86AF2712B36A1, 240385, MBTOfficeGuns2);
		Function.Call((Hash)0x55E86AF2712B36A1, 240385, MBTOfficeGuns3);
		Function.Call((Hash)0x55E86AF2712B36A1, 240385, MBTOfficeMedProps1);
		Function.Call((Hash)0x55E86AF2712B36A1, 240385, MBTOfficeMedProps2);
		Function.Call((Hash)0x55E86AF2712B36A1, 240385, MBTOfficeGemProps3);
		Function.Call((Hash)0x55E86AF2712B36A1, 240385, MBTOfficeGemProps1);
		Function.Call((Hash)0x55E86AF2712B36A1, 240385, MBTOfficeGemProps2);
		Function.Call((Hash)0x55E86AF2712B36A1, 240385, MBTOfficeMedProps3);
		Function.Call((Hash)0x55E86AF2712B36A1, 240385, MBTOfficeCounterfeitProps1);
		Function.Call((Hash)0x55E86AF2712B36A1, 240385, MBTOfficeCounterfeitProps2);
		Function.Call((Hash)0x55E86AF2712B36A1, 240385, MBTOfficeCounterfeitProps3);
		Function.Call((Hash)0x41F37C3427C75AE0, 240385);
		
		//mbt office power broker polished
		Function.Call((Hash)0x55E86AF2712B36A1, 240641, "office_chairs");
		Function.Call((Hash)0x55E86AF2712B36A1, 240641, MBTOfficeBooze);
		Function.Call((Hash)0x55E86AF2712B36A1, 240641, MBTOfficeCashProps1);
		Function.Call((Hash)0x55E86AF2712B36A1, 240641, MBTOfficeCashProps2);
		Function.Call((Hash)0x55E86AF2712B36A1, 240641, MBTOfficeCashProps3);
		Function.Call((Hash)0x55E86AF2712B36A1, 240641, MBTOfficeCashProps4);
		Function.Call((Hash)0x55E86AF2712B36A1, 240641, MBTOfficeCashProps5);
		Function.Call((Hash)0x55E86AF2712B36A1, 240641, MBTOfficeCashProps6);
		Function.Call((Hash)0x55E86AF2712B36A1, 240641, MBTOfficeCashProps7);
		Function.Call((Hash)0x55E86AF2712B36A1, 240641, MBTOfficeCashProps8);
		Function.Call((Hash)0x55E86AF2712B36A1, 240641, MBTOfficeCashProps9);
		Function.Call((Hash)0x55E86AF2712B36A1, 240641, MBTOfficeCashProps10);
		Function.Call((Hash)0x55E86AF2712B36A1, 240641, MBTOfficeCashProps11);
		Function.Call((Hash)0x55E86AF2712B36A1, 240641, MBTOfficeCashProps12);
		Function.Call((Hash)0x55E86AF2712B36A1, 240641, MBTOfficeCashProps13);
		Function.Call((Hash)0x55E86AF2712B36A1, 240641, MBTOfficeCashProps14);
		Function.Call((Hash)0x55E86AF2712B36A1, 240641, MBTOfficeCashProps15);
		Function.Call((Hash)0x55E86AF2712B36A1, 240641, MBTOfficeCashProps16);
		Function.Call((Hash)0x55E86AF2712B36A1, 240641, MBTOfficeCashProps17);
		Function.Call((Hash)0x55E86AF2712B36A1, 240641, MBTOfficeCashProps18);
		Function.Call((Hash)0x55E86AF2712B36A1, 240641, MBTOfficeCashProps19);
		Function.Call((Hash)0x55E86AF2712B36A1, 240641, MBTOfficeCashProps20);
		Function.Call((Hash)0x55E86AF2712B36A1, 240641, MBTOfficeCashProps21);
		Function.Call((Hash)0x55E86AF2712B36A1, 240641, MBTOfficeCashProps22);
		Function.Call((Hash)0x55E86AF2712B36A1, 240641, MBTOfficeCashProps23);
		Function.Call((Hash)0x55E86AF2712B36A1, 240641, MBTOfficeCashProps24);
		Function.Call((Hash)0x55E86AF2712B36A1, 240641, MBTOfficeSilverProps1);
		Function.Call((Hash)0x55E86AF2712B36A1, 240641, MBTOfficeSilverProps2);
		Function.Call((Hash)0x55E86AF2712B36A1, 240641, MBTOfficeSilverProps3);
		Function.Call((Hash)0x55E86AF2712B36A1, 240641, MBTOfficeDrugBags1);
		Function.Call((Hash)0x55E86AF2712B36A1, 240641, MBTOfficeDrugBags2);
		Function.Call((Hash)0x55E86AF2712B36A1, 240641, MBTOfficeDrugBags3);
		Function.Call((Hash)0x55E86AF2712B36A1, 240641, MBTOfficeCigsProps1);
		Function.Call((Hash)0x55E86AF2712B36A1, 240641, MBTOfficeCigsProps2);
		Function.Call((Hash)0x55E86AF2712B36A1, 240641, MBTOfficeCigsProps3);
		Function.Call((Hash)0x55E86AF2712B36A1, 240641, MBTOfficeElectronicProps1);
		Function.Call((Hash)0x55E86AF2712B36A1, 240641, MBTOfficeElectronicProps2);
		Function.Call((Hash)0x55E86AF2712B36A1, 240641, MBTOfficeElectronicProps3);
		Function.Call((Hash)0x55E86AF2712B36A1, 240641, MBTOfficeDrugStatue1);
		Function.Call((Hash)0x55E86AF2712B36A1, 240641, MBTOfficeDrugStatue2);
		Function.Call((Hash)0x55E86AF2712B36A1, 240641, MBTOfficeDrugStatue3);
		Function.Call((Hash)0x55E86AF2712B36A1, 240641, MBTOfficeIvoryProps1);
		Function.Call((Hash)0x55E86AF2712B36A1, 240641, MBTOfficeIvoryProps2);
		Function.Call((Hash)0x55E86AF2712B36A1, 240641, MBTOfficeIvoryProps3);
		Function.Call((Hash)0x55E86AF2712B36A1, 240641, MBTOfficePillsProps1);
		Function.Call((Hash)0x55E86AF2712B36A1, 240641, MBTOfficePillsProps2);
		Function.Call((Hash)0x55E86AF2712B36A1, 240641, MBTOfficePillsProps3);
		Function.Call((Hash)0x55E86AF2712B36A1, 240641, MBTOfficeJewelWatchProps1);
		Function.Call((Hash)0x55E86AF2712B36A1, 240641, MBTOfficeJewelWatchProps2);
		Function.Call((Hash)0x55E86AF2712B36A1, 240641, MBTOfficeJewelWatchProps3);
		Function.Call((Hash)0x55E86AF2712B36A1, 240641, MBTOfficeFurCoats1);
		Function.Call((Hash)0x55E86AF2712B36A1, 240641, MBTOfficeFurCoats2);
		Function.Call((Hash)0x55E86AF2712B36A1, 240641, MBTOfficeFurCoats3);
		Function.Call((Hash)0x55E86AF2712B36A1, 240641, MBTOfficeArtProps1);
		Function.Call((Hash)0x55E86AF2712B36A1, 240641, MBTOfficeArtProps2);
		Function.Call((Hash)0x55E86AF2712B36A1, 240641, MBTOfficeArtProps3);
		Function.Call((Hash)0x55E86AF2712B36A1, 240641, MBTOfficeGuns1);
		Function.Call((Hash)0x55E86AF2712B36A1, 240641, MBTOfficeGuns2);
		Function.Call((Hash)0x55E86AF2712B36A1, 240641, MBTOfficeGuns3);
		Function.Call((Hash)0x55E86AF2712B36A1, 240641, MBTOfficeMedProps1);
		Function.Call((Hash)0x55E86AF2712B36A1, 240641, MBTOfficeMedProps2);
		Function.Call((Hash)0x55E86AF2712B36A1, 240641, MBTOfficeGemProps3);
		Function.Call((Hash)0x55E86AF2712B36A1, 240641, MBTOfficeGemProps1);
		Function.Call((Hash)0x55E86AF2712B36A1, 240641, MBTOfficeGemProps2);
		Function.Call((Hash)0x55E86AF2712B36A1, 240641, MBTOfficeMedProps3);
		Function.Call((Hash)0x55E86AF2712B36A1, 240641, MBTOfficeCounterfeitProps1);
		Function.Call((Hash)0x55E86AF2712B36A1, 240641, MBTOfficeCounterfeitProps2);
		Function.Call((Hash)0x55E86AF2712B36A1, 240641, MBTOfficeCounterfeitProps3);
		Function.Call((Hash)0x41F37C3427C75AE0, 240641);
	}

	void BikerInteriorsProps()
	{
		//clubhouse
		Function.Call((Hash)0x55E86AF2712B36A1, 246273, "mod_booth");
		Function.Call((Hash)0x55E86AF2712B36A1, 246273, "gun_locker");
		Function.Call((Hash)0x55E86AF2712B36A1, 246273, "meth_stash1");
		Function.Call((Hash)0x55E86AF2712B36A1, 246273, "meth_stash2");
		Function.Call((Hash)0x55E86AF2712B36A1, 246273, "meth_stash3");
		Function.Call((Hash)0x55E86AF2712B36A1, 246273, "coke_stash1");
		Function.Call((Hash)0x55E86AF2712B36A1, 246273, "coke_stash2");
		Function.Call((Hash)0x55E86AF2712B36A1, 246273, "coke_stash3");
		Function.Call((Hash)0x55E86AF2712B36A1, 246273, "weed_stash1");
		Function.Call((Hash)0x55E86AF2712B36A1, 246273, "weed_stash2");
		Function.Call((Hash)0x55E86AF2712B36A1, 246273, "weed_stash3");
		Function.Call((Hash)0x55E86AF2712B36A1, 246273, "cash_stash1");
		Function.Call((Hash)0x55E86AF2712B36A1, 246273, "cash_stash2");
		Function.Call((Hash)0x55E86AF2712B36A1, 246273, "cash_stash3");
		Function.Call((Hash)0x55E86AF2712B36A1, 246273, "id_stash1");
		Function.Call((Hash)0x55E86AF2712B36A1, 246273, "id_stash2");
		Function.Call((Hash)0x55E86AF2712B36A1, 246273, "id_stash3");
		Function.Call((Hash)0x55E86AF2712B36A1, 246273, "counterfeit_stash1");
		Function.Call((Hash)0x55E86AF2712B36A1, 246273, "counterfeit_stash2");
		Function.Call((Hash)0x55E86AF2712B36A1, 246273, "counterfeit_stash3");
		Function.Call((Hash)0x41F37C3427C75AE0, 246273);
		
		//two floor clubhouse
		Function.Call((Hash)0x55E86AF2712B36A1, 246529, "mod_booth");
		Function.Call((Hash)0x55E86AF2712B36A1, 246529, "gun_locker");
		Function.Call((Hash)0x55E86AF2712B36A1, 246529, "cash_small");
		Function.Call((Hash)0x55E86AF2712B36A1, 246529, "cash_medium");
		Function.Call((Hash)0x55E86AF2712B36A1, 246529, "cash_large");
		Function.Call((Hash)0x55E86AF2712B36A1, 246529, "counterfeit_small");
		Function.Call((Hash)0x55E86AF2712B36A1, 246529, "counterfeit_medium");
		Function.Call((Hash)0x55E86AF2712B36A1, 246529, "counterfeit_large");
		Function.Call((Hash)0x55E86AF2712B36A1, 246529, "id_small");
		Function.Call((Hash)0x55E86AF2712B36A1, 246529, "id_medium");
		Function.Call((Hash)0x55E86AF2712B36A1, 246529, "id_large");
		Function.Call((Hash)0x55E86AF2712B36A1, 246529, "weed_small");
		Function.Call((Hash)0x55E86AF2712B36A1, 246529, "weed_medium");
		Function.Call((Hash)0x55E86AF2712B36A1, 246529, "weed_large");
		Function.Call((Hash)0x55E86AF2712B36A1, 246529, "coke_small");
		Function.Call((Hash)0x55E86AF2712B36A1, 246529, "coke_medium");
		Function.Call((Hash)0x55E86AF2712B36A1, 246529, "coke_large");
		Function.Call((Hash)0x55E86AF2712B36A1, 246529, "meth_small");
		Function.Call((Hash)0x55E86AF2712B36A1, 246529, "meth_medium");
		Function.Call((Hash)0x55E86AF2712B36A1, 246529, "meth_large");
		Function.Call((Hash)0x55E86AF2712B36A1, 246529, "lower_walls_default");
		Function.Call((Hash)0x41F37C3427C75AE0, 246529);
		
		//meth warehouse
		Function.Call((Hash)0x55E86AF2712B36A1, 247041, "meth_lab_upgrade");
		Function.Call((Hash)0x55E86AF2712B36A1, 247041, "meth_lab_production");
		Function.Call((Hash)0x55E86AF2712B36A1, 247041, "meth_lab_security_high");
		Function.Call((Hash)0x55E86AF2712B36A1, 247041, "meth_lab_setup");
		Function.Call((Hash)0x41F37C3427C75AE0, 247041);
		
		//weed warehouse
		Function.Call((Hash)0x55E86AF2712B36A1, 247297, "weed_upgrade_equip");
		Function.Call((Hash)0x55E86AF2712B36A1, 247297, "weed_drying");
		Function.Call((Hash)0x55E86AF2712B36A1, 247297, "weed_security_upgrade");
		Function.Call((Hash)0x55E86AF2712B36A1, 247297, "weed_production");
		Function.Call((Hash)0x55E86AF2712B36A1, 247297, "weed_set_up");
		Function.Call((Hash)0x55E86AF2712B36A1, 247297, "weed_chairs");
		Function.Call((Hash)0x55E86AF2712B36A1, 247297, "weed_growtha_stage3");
		Function.Call((Hash)0x55E86AF2712B36A1, 247297, "weed_growthb_stage3");
		Function.Call((Hash)0x55E86AF2712B36A1, 247297, "weed_growthc_stage3");
		Function.Call((Hash)0x55E86AF2712B36A1, 247297, "weed_growthd_stage3");
		Function.Call((Hash)0x55E86AF2712B36A1, 247297, "weed_growthe_stage3");
		Function.Call((Hash)0x55E86AF2712B36A1, 247297, "weed_growthf_stage3");
		Function.Call((Hash)0x55E86AF2712B36A1, 247297, "weed_growthg_stage3");
		Function.Call((Hash)0x55E86AF2712B36A1, 247297, "weed_growthh_stage3");
		Function.Call((Hash)0x55E86AF2712B36A1, 247297, "weed_growthi_stage3");
		Function.Call((Hash)0x55E86AF2712B36A1, 247297, "weed_hosea");
		Function.Call((Hash)0x55E86AF2712B36A1, 247297, "weed_hoseb");
		Function.Call((Hash)0x55E86AF2712B36A1, 247297, "weed_hosec");
		Function.Call((Hash)0x55E86AF2712B36A1, 247297, "weed_hosed");
		Function.Call((Hash)0x55E86AF2712B36A1, 247297, "weed_hosee");
		Function.Call((Hash)0x55E86AF2712B36A1, 247297, "weed_hosef");
		Function.Call((Hash)0x55E86AF2712B36A1, 247297, "weed_hoseg");
		Function.Call((Hash)0x55E86AF2712B36A1, 247297, "weed_hoseh");
		Function.Call((Hash)0x55E86AF2712B36A1, 247297, "weed_hosei");
		Function.Call((Hash)0x55E86AF2712B36A1, 247297, "light_growtha_stage23_upgrade");
		Function.Call((Hash)0x55E86AF2712B36A1, 247297, "light_growthb_stage23_upgrade");
		Function.Call((Hash)0x55E86AF2712B36A1, 247297, "light_growthc_stage23_upgrade");
		Function.Call((Hash)0x55E86AF2712B36A1, 247297, "light_growthd_stage23_upgrade");
		Function.Call((Hash)0x55E86AF2712B36A1, 247297, "light_growthe_stage23_upgrade");
		Function.Call((Hash)0x55E86AF2712B36A1, 247297, "light_growthf_stage23_upgrade");
		Function.Call((Hash)0x55E86AF2712B36A1, 247297, "light_growthg_stage23_upgrade");
		Function.Call((Hash)0x55E86AF2712B36A1, 247297, "light_growthh_stage23_upgrade");
		Function.Call((Hash)0x55E86AF2712B36A1, 247297, "light_growthi_stage23_upgrade");
		Function.Call((Hash)0x41F37C3427C75AE0, 247297);
		
		//cocaine warehouse
		Function.Call((Hash)0x55E86AF2712B36A1, 247553, "coke_cut_01");
		Function.Call((Hash)0x55E86AF2712B36A1, 247553, "coke_cut_02");
		Function.Call((Hash)0x55E86AF2712B36A1, 247553, "coke_cut_03");
		Function.Call((Hash)0x55E86AF2712B36A1, 247553, "security_high");
		Function.Call((Hash)0x55E86AF2712B36A1, 247553, "production_upgrade");
		Function.Call((Hash)0x55E86AF2712B36A1, 247553, "equipment_upgrade");
		Function.Call((Hash)0x55E86AF2712B36A1, 247553, "coke_cut_04");
		Function.Call((Hash)0x55E86AF2712B36A1, 247553, "coke_cut_05");
		Function.Call((Hash)0x55E86AF2712B36A1, 247553, "set_up");
		Function.Call((Hash)0x55E86AF2712B36A1, 247553, "table_equipment_upgrade");
		Function.Call((Hash)0x55E86AF2712B36A1, 247553, "coke_press_upgrade");
		Function.Call((Hash)0x41F37C3427C75AE0, 247553);
		
		//document forgeries warehouse
		Function.Call((Hash)0x55E86AF2712B36A1, 246785, "equipment_upgrade");
		Function.Call((Hash)0x55E86AF2712B36A1, 246785, "production");
		Function.Call((Hash)0x55E86AF2712B36A1, 246785, "security_high");
		Function.Call((Hash)0x55E86AF2712B36A1, 246785, "set_up");
		Function.Call((Hash)0x55E86AF2712B36A1, 246785, "clutter");
		Function.Call((Hash)0x55E86AF2712B36A1, 246785, "interior_upgrade");
		Function.Call((Hash)0x55E86AF2712B36A1, 246785, "chair01");
		Function.Call((Hash)0x55E86AF2712B36A1, 246785, "chair02");
		Function.Call((Hash)0x55E86AF2712B36A1, 246785, "chair03");
		Function.Call((Hash)0x55E86AF2712B36A1, 246785, "chair04");
		Function.Call((Hash)0x55E86AF2712B36A1, 246785, "chair05");
		Function.Call((Hash)0x55E86AF2712B36A1, 246785, "chair06");
		Function.Call((Hash)0x55E86AF2712B36A1, 246785, "chair07");
		Function.Call((Hash)0x41F37C3427C75AE0, 246785);
		
		//counterfeit cash warehouse
		Function.Call((Hash)0x55E86AF2712B36A1, 247809, "counterfeit_security");
		Function.Call((Hash)0x55E86AF2712B36A1, 247809, "counterfeit_cashpile100a");
		Function.Call((Hash)0x55E86AF2712B36A1, 247809, "counterfeit_cashpile20a");
		Function.Call((Hash)0x55E86AF2712B36A1, 247809, "counterfeit_cashpile10a");
		Function.Call((Hash)0x55E86AF2712B36A1, 247809, "counterfeit_cashpile100b");
		Function.Call((Hash)0x55E86AF2712B36A1, 247809, "counterfeit_cashpile100c");
		Function.Call((Hash)0x55E86AF2712B36A1, 247809, "counterfeit_cashpile100d");
		Function.Call((Hash)0x55E86AF2712B36A1, 247809, "counterfeit_cashpile20b");
		Function.Call((Hash)0x55E86AF2712B36A1, 247809, "counterfeit_cashpile20c");
		Function.Call((Hash)0x55E86AF2712B36A1, 247809, "counterfeit_cashpile20d");
		Function.Call((Hash)0x55E86AF2712B36A1, 247809, "counterfeit_cashpile10b");
		Function.Call((Hash)0x55E86AF2712B36A1, 247809, "counterfeit_cashpile10c");
		Function.Call((Hash)0x55E86AF2712B36A1, 247809, "counterfeit_cashpile10d");
		Function.Call((Hash)0x55E86AF2712B36A1, 247809, "counterfeit_setup");
		Function.Call((Hash)0x55E86AF2712B36A1, 247809, "counterfeit_upgrade_equip");
		Function.Call((Hash)0x55E86AF2712B36A1, 247809, "dryera_on");
		Function.Call((Hash)0x55E86AF2712B36A1, 247809, "dryerb_on");
		Function.Call((Hash)0x55E86AF2712B36A1, 247809, "dryerc_on");
		Function.Call((Hash)0x55E86AF2712B36A1, 247809, "dryerd_on");
		Function.Call((Hash)0x55E86AF2712B36A1, 247809, "money_cutter");
		Function.Call((Hash)0x55E86AF2712B36A1, 247809, "special_chairs");
		Function.Call((Hash)0x41F37C3427C75AE0, 247809);
	}

	void IPL()
	{
		Function.Call(Hash.REQUEST_IPL, "lr_cs6_08_grave_closed"); //vagos grave (closed)
		
		//mbt mod garage
		Function.Call(Hash.REQUEST_IPL, "imp_dt1_11_modgarage");
		Function.Call((Hash)0x55E86AF2712B36A1, 255233, MBTModGarageFloorDecal);
		Function.Call((Hash)0x41F37C3427C75AE0, 255233);
		Function.Call(Hash.REQUEST_IPL, "bkr_bi_hw1_13_int"); //lost clubhouse (east vinewood)
		Function.Call(Hash.REQUEST_IPL, "bkr_bi_id1_23_door"); //vagos warehouse doors (el burro heights)
		
		//vehicle warehouse
		Function.Call((Hash)0x55E86AF2712B36A1, 252673, CarWarehouseStyle);
		Function.Call((Hash)0x55E86AF2712B36A1, 252673, FloorHatch);
		Function.Call((Hash)0x41F37C3427C75AE0, 252673);
		
		//vehicle warehouse underground
		Function.Call((Hash)0x55E86AF2712B36A1, 253185, Pump1);
		Function.Call((Hash)0x55E86AF2712B36A1, 253185, Pump2);
		Function.Call((Hash)0x55E86AF2712B36A1, 253185, Pump3);
		Function.Call((Hash)0x55E86AF2712B36A1, 253185, Pump4);
		Function.Call((Hash)0x55E86AF2712B36A1, 253185, Pump5);
		Function.Call((Hash)0x55E86AF2712B36A1, 253185, Pump6);
		Function.Call((Hash)0x55E86AF2712B36A1, 253185, Pump7);
		Function.Call((Hash)0x55E86AF2712B36A1, 253185, Pump8);
		Function.Call((Hash)0x41F37C3427C75AE0, 253185);
		
		//bunker
		Function.Call((Hash)0x55E86AF2712B36A1, 258561, BunkerStyle);
		Function.Call((Hash)0x55E86AF2712B36A1, 258561, BunkerSet);
		Function.Call((Hash)0x55E86AF2712B36A1, 258561, BunkerSet2);
		Function.Call((Hash)0x55E86AF2712B36A1, 258561, BunkerSecuritySet);;
		Function.Call((Hash)0x55E86AF2712B36A1, 258561, "Office_Upgrade_set");
		Function.Call((Hash)0x55E86AF2712B36A1, 258561, "gun_range_lights");
		Function.Call((Hash)0x55E86AF2712B36A1, 258561, "gun_schematic_set");
		Function.Call((Hash)0x55E86AF2712B36A1, 258561, "gun_locker_upgrade");
		Function.Call((Hash)0x41F37C3427C75AE0, 258561);
		
		//gunrunning yahct
		Function.Call(Hash.REQUEST_IPL, "gr_Heist_Yacht2");
		Function.Call(Hash.REQUEST_IPL, "gr_Heist_Yacht2_enginrm");
		Function.Call(Hash.REQUEST_IPL, "gr_Heist_Yacht2_Lounge");
		Function.Call(Hash.REQUEST_IPL, "gr_Heist_Yacht2_Bridge");
		Function.Call(Hash.REQUEST_IPL, "gr_Heist_Yacht2_Bar");
		Function.Call(Hash.REQUEST_IPL, "gr_Heist_Yacht2_Bedrm");
		Function.Call(Hash.REQUEST_IPL, "gr_case1_bunkerclosed"); //smoke tree road bunker entrance
		
		//hangar
		if (EnableHangar)
		{
			Function.Call((Hash)0x55E86AF2712B36A1, 260353, HangarLighting);
			Function.Call((Hash)0x55E86AF2712B36A1, 260353, HangarFloor);
			Function.Call((Hash)0x55E86AF2712B36A1, 260353, HangarFloorDecal);
			Function.Call((Hash)0x55E86AF2712B36A1, 260353, HangarBedroom);
			Function.Call((Hash)0x55E86AF2712B36A1, 260353, HangarOffice);
			Function.Call((Hash)0x55E86AF2712B36A1, 260353, HangarBedroomBlinds);
			Function.Call((Hash)0x55E86AF2712B36A1, 260353, HangarLightingWallTint);
			Function.Call((Hash)0x55E86AF2712B36A1, 260353, HangarNeutralLighting);
			Function.Call((Hash)0x55E86AF2712B36A1, 260353, "set_tint_shell");
			Function.Call((Hash)0x55E86AF2712B36A1, 260353, "set_bedroom_tint");
			Function.Call((Hash)0x55E86AF2712B36A1, 260353, "set_crane_tint");
			Function.Call((Hash)0x55E86AF2712B36A1, 260353, "set_modarea");
			Function.Call((Hash)0x31D23FC8CCD18DC3, 260353, HangarFloorDecal, HangarFloorDecalColor);
			Function.Call((Hash)0x31D23FC8CCD18DC3, 260353, "set_tint_shell", HangarShellColor);
			Function.Call((Hash)0x31D23FC8CCD18DC3, 260353, "set_bedroom_tint", HangarBedroomColor);
			Function.Call((Hash)0x31D23FC8CCD18DC3, 260353, "set_crane_tint", HangarCraneColor);
			Function.Call((Hash)0x31D23FC8CCD18DC3, 260353, "set_modarea", HangarWorkshopColor);
			Function.Call((Hash)0x31D23FC8CCD18DC3, 260353, "set_lighting_tint_props", HangarLightingTintPropsColor);
			Function.Call((Hash)0x41F37C3427C75AE0, 260353);
		}
		
		//facility
		Function.Call(Hash.REQUEST_IPL, "xm_x17dlc_int_placement_interior_33_x17dlc_int_02_milo_");
		int facilityID = Function.Call<int>(Hash.GET_INTERIOR_AT_COORDS, 462.09f, 4820.42f, -59.00f);
		Function.Call((Hash)0x55E86AF2712B36A1, facilityID, "set_int_02_shell");
		Function.Call((Hash)0x55E86AF2712B36A1, facilityID, FacilityGraphic);
		Function.Call((Hash)0x55E86AF2712B36A1, facilityID, FacilityOrbitalCannon);
		Function.Call((Hash)0x55E86AF2712B36A1, facilityID, FacilitySecurityRoom);
		Function.Call((Hash)0x55E86AF2712B36A1, facilityID, FacilityLounge);
		Function.Call((Hash)0x55E86AF2712B36A1, facilityID, FacilitySleepingQuarters);
		Function.Call((Hash)0x31D23FC8CCD18DC3, facilityID, "set_int_02_shell", FacilityShellColor);
		Function.Call((Hash)0x31D23FC8CCD18DC3, facilityID, FacilityGraphic, FacilityGraphicColor);
		Function.Call((Hash)0x31D23FC8CCD18DC3, facilityID, FacilityOrbitalCannon, FacilityOrbitalCannonColor);
		Function.Call((Hash)0x31D23FC8CCD18DC3, facilityID, FacilitySecurityRoom, FacilitySecurityRoomColor);
		Function.Call((Hash)0x31D23FC8CCD18DC3, facilityID, FacilityLounge, FacilityLoungeColor);
		Function.Call((Hash)0x31D23FC8CCD18DC3, facilityID, FacilitySleepingQuarters, FacilitySleepingQuartersColor);
		Function.Call((Hash)0x41F37C3427C75AE0, facilityID);
		
		
		//gov building server farm
		Function.Call(Hash.REQUEST_IPL, "xm_x17dlc_int_placement_interior_4_x17dlc_int_facility_milo_");
		
		//satellite facility
		Function.Call(Hash.REQUEST_IPL, "xm_x17dlc_int_placement_interior_5_x17dlc_int_facility2_milo_");
		
		//submarine
		Function.Call(Hash.REQUEST_IPL, "xm_x17dlc_int_placement_interior_8_x17dlc_int_sub_milo_");
		
		//chilliad facility
		Function.Call(Hash.REQUEST_IPL, "xm_x17dlc_int_placement_interior_0_x17dlc_int_base_ent_milo_");
		Function.Call(Hash.REQUEST_IPL, "xm_x17dlc_int_placement_interior_1_x17dlc_int_base_loop_milo_");
		Function.Call(Hash.REQUEST_IPL, "xm_x17dlc_int_placement_interior_2_x17dlc_int_bse_tun_milo_");
		Function.Call(Hash.REQUEST_IPL, "xm_x17dlc_int_placement_interior_3_x17dlc_int_base_milo_");
		Function.Call(Hash.REQUEST_IPL, "xm_x17dlc_int_placement_interior_6_x17dlc_int_silo_01_milo_");
		Function.Call(Hash.REQUEST_IPL, "xm_x17dlc_int_placement_interior_7_x17dlc_int_silo_02_milo_");
		Function.Call(Hash.REQUEST_IPL, "xm_x17dlc_int_placement_interior_10_x17dlc_int_tun_straight_milo_");
		Function.Call(Hash.REQUEST_IPL, "xm_x17dlc_int_placement_interior_11_x17dlc_int_tun_slope_flat_milo_");
		Function.Call(Hash.REQUEST_IPL, "xm_x17dlc_int_placement_interior_12_x17dlc_int_tun_flat_slope_milo_");
		Function.Call(Hash.REQUEST_IPL, "xm_x17dlc_int_placement_interior_13_x17dlc_int_tun_30d_r_milo_");
		Function.Call(Hash.REQUEST_IPL, "xm_x17dlc_int_placement_interior_14_x17dlc_int_tun_30d_l_milo_");
		Function.Call(Hash.REQUEST_IPL, "xm_x17dlc_int_placement_interior_15_x17dlc_int_tun_straight_milo_");
		Function.Call(Hash.REQUEST_IPL, "xm_x17dlc_int_placement_interior_16_x17dlc_int_tun_straight_milo_");
		Function.Call(Hash.REQUEST_IPL, "xm_x17dlc_int_placement_interior_17_x17dlc_int_tun_slope_flat_milo_");
		Function.Call(Hash.REQUEST_IPL, "xm_x17dlc_int_placement_interior_18_x17dlc_int_tun_slope_flat_milo_");
		Function.Call(Hash.REQUEST_IPL, "xm_x17dlc_int_placement_interior_19_x17dlc_int_tun_flat_slope_milo_");
		Function.Call(Hash.REQUEST_IPL, "xm_x17dlc_int_placement_interior_20_x17dlc_int_tun_flat_slope_milo_");
		Function.Call(Hash.REQUEST_IPL, "xm_x17dlc_int_placement_interior_21_x17dlc_int_tun_30d_r_milo_");
		Function.Call(Hash.REQUEST_IPL, "xm_x17dlc_int_placement_interior_22_x17dlc_int_tun_30d_r_milo_");
		Function.Call(Hash.REQUEST_IPL, "xm_x17dlc_int_placement_interior_23_x17dlc_int_tun_30d_r_milo_");
		Function.Call(Hash.REQUEST_IPL, "xm_x17dlc_int_placement_interior_24_x17dlc_int_tun_30d_r_milo_");
		Function.Call(Hash.REQUEST_IPL, "xm_x17dlc_int_placement_interior_25_x17dlc_int_tun_30d_l_milo_");
		Function.Call(Hash.REQUEST_IPL, "xm_x17dlc_int_placement_interior_26_x17dlc_int_tun_30d_l_milo_");
		Function.Call(Hash.REQUEST_IPL, "xm_x17dlc_int_placement_interior_27_x17dlc_int_tun_30d_l_milo_");
		Function.Call(Hash.REQUEST_IPL, "xm_x17dlc_int_placement_interior_28_x17dlc_int_tun_30d_l_milo_");
		Function.Call(Hash.REQUEST_IPL, "xm_x17dlc_int_placement_interior_29_x17dlc_int_tun_30d_l_milo_");
		Function.Call(Hash.REQUEST_IPL, "xm_x17dlc_int_placement_interior_34_x17dlc_int_lab_milo_");
		Function.Call(Hash.REQUEST_IPL, "xm_x17dlc_int_placement_interior_35_x17dlc_int_tun_entry_milo_");
		Function.Call(Hash.REQUEST_IPL, "xm_x17dlc_int_placement_strm_0");
	}

	void MapFix()
	{
		Function.Call(Hash.REQUEST_IPL, "bahama_mamas_west_doors_inside");
		Function.Call(Hash.REQUEST_IPL, "gunrunning_yacht_jacuzzi");
		Function.Call(Hash.REQUEST_IPL, "heist_yacht_jacuzzi");
		Function.Call(Hash.REQUEST_IPL, "michael_house_wc_window");
	}

	void DisplayHelpText(string text)
	{
		InputArgument[] arguments = new InputArgument[] { "STRING" };
		Function.Call(Hash._0x8509B634FBE7DA11, arguments);
		InputArgument[] argumentArray2 = new InputArgument[] { text };
		Function.Call(Hash._0x6C188BE134E074AA, argumentArray2);
		InputArgument[] argumentArray3 = new InputArgument[] {0,0,1,-1};
		Function.Call(Hash._0x238FFE5C7B0498A6, argumentArray3);
	}
	
	void ToggleShipCamShake()
	{
		Ped plrChar = Game.Player.Character;
		
		if (Function.Call<bool>(Hash.IS_PED_ON_FOOT, plrChar))
		{
			if(Function.Call<bool>(Hash.IS_PED_ON_VEHICLE, plrChar) || Function.Call<bool>(Hash.IS_PED_FALLING, plrChar) || Function.Call<bool>(Hash.IS_PED_IN_PARACHUTE_FREE_FALL, plrChar) || Function.Call<bool>(Hash.IS_PED_SWIMMING, plrChar) || Function.Call<bool>(Hash.IS_PED_SWIMMING_UNDER_WATER, plrChar))
			{
				Function.Call(Hash.STOP_GAMEPLAY_CAM_SHAKING);
			}
			else
			{
				if (!Function.Call<bool>(Hash.IS_GAMEPLAY_CAM_SHAKING))
					Function.Call(Hash.SHAKE_GAMEPLAY_CAM, "DRUNK_SHAKE", 0.25f);
			}
		}
	}

	void OnTick(object sender, EventArgs e)
	{
		Ped plrChar = Game.Player.Character;
		{
			int LoadTenCarGarage = Function.Call<int>(Hash.GET_INTERIOR_AT_COORDS, 228.60580000f, -992.05370000f, -100.00000000f);
			Function.Call((Hash)0x2CA429C029CCF247, 146433);
			Function.Call(Hash.SET_INTERIOR_ACTIVE, 146433, true);
			Function.Call(Hash.DISABLE_INTERIOR, 146433, false);
		}
		
		//Map Fix
		/*if (plrChar.Position.DistanceTo(AircraftCarrierPos) < 25f || plrChar.Position.DistanceTo(HeistYachtPos) < 25f || plrChar.Position.DistanceTo(GunrunningYachtPos) < 25f)
		{
			Function.Call((Hash)0xC54A08C85AE4D410, 1.0);
		}
		else
		{
			Function.Call((Hash)0xC54A08C85AE4D410, 0.0);
		}*/
		
		if (plrChar.Position.DistanceTo(AircraftCarrierPos) < 250f || plrChar.Position.DistanceTo(HeistYachtPos) < 100f || plrChar.Position.DistanceTo(GunrunningYachtPos) < 100f)
		{
			isShipCamNeeded = true;
			Function.Call((Hash)0xC443FD757C3BA637, 3090.70f, -4810.60f, 25f, 0.0);
			Function.Call((Hash)0xC443FD757C3BA637, -2040.90f, -1032.45f, 25f, 0.0);
			Function.Call((Hash)0xC443FD757C3BA637, -1380.90f, 6739.95f, 25f, 0.0);
			ToggleShipCamShake();
		}
		else if (plrChar.Position.DistanceTo(PlayerYachtPos1) < 100f || plrChar.Position.DistanceTo(PlayerYachtPos2) < 100f || plrChar.Position.DistanceTo(PlayerYachtPos3) < 100f
				|| plrChar.Position.DistanceTo(PlayerYachtPos4) < 100f || plrChar.Position.DistanceTo(PlayerYachtPos5) < 100f || plrChar.Position.DistanceTo(PlayerYachtPos6) < 100f
				|| plrChar.Position.DistanceTo(PlayerYachtPos7) < 100f || plrChar.Position.DistanceTo(PlayerYachtPos8) < 100f || plrChar.Position.DistanceTo(PlayerYachtPos9) < 100f
				|| plrChar.Position.DistanceTo(PlayerYachtPos10) < 100f || plrChar.Position.DistanceTo(PlayerYachtPos11) < 100f || plrChar.Position.DistanceTo(PlayerYachtPos12) < 100f
				|| plrChar.Position.DistanceTo(PlayerYachtPos13) < 100f || plrChar.Position.DistanceTo(PlayerYachtPos14) < 100f || plrChar.Position.DistanceTo(PlayerYachtPos15) < 100f
				|| plrChar.Position.DistanceTo(PlayerYachtPos16) < 100f || plrChar.Position.DistanceTo(PlayerYachtPos17) < 100f || plrChar.Position.DistanceTo(PlayerYachtPos18) < 100f
				|| plrChar.Position.DistanceTo(PlayerYachtPos19) < 100f || plrChar.Position.DistanceTo(PlayerYachtPos20) < 100f || plrChar.Position.DistanceTo(PlayerYachtPos21) < 100f
				|| plrChar.Position.DistanceTo(PlayerYachtPos22) < 100f || plrChar.Position.DistanceTo(PlayerYachtPos23) < 100f || plrChar.Position.DistanceTo(PlayerYachtPos24) < 100f
				|| plrChar.Position.DistanceTo(PlayerYachtPos25) < 100f || plrChar.Position.DistanceTo(PlayerYachtPos26) < 100f || plrChar.Position.DistanceTo(PlayerYachtPos27) < 100f
				|| plrChar.Position.DistanceTo(PlayerYachtPos28) < 100f || plrChar.Position.DistanceTo(PlayerYachtPos29) < 100f || plrChar.Position.DistanceTo(PlayerYachtPos30) < 100f
				|| plrChar.Position.DistanceTo(PlayerYachtPos31) < 100f || plrChar.Position.DistanceTo(PlayerYachtPos32) < 100f || plrChar.Position.DistanceTo(PlayerYachtPos33) < 100f
				|| plrChar.Position.DistanceTo(PlayerYachtPos34) < 100f || plrChar.Position.DistanceTo(PlayerYachtPos35) < 100f || plrChar.Position.DistanceTo(PlayerYachtPos36) < 100f)
		{
			if (Function.Call<bool>(Hash.IS_IPL_ACTIVE, "apa_yacht_grp01_1_int") || Function.Call<bool>(Hash.IS_IPL_ACTIVE, "apa_yacht_grp01_2_int") || Function.Call<bool>(Hash.IS_IPL_ACTIVE, "apa_yacht_grp01_3_int")
				|| Function.Call<bool>(Hash.IS_IPL_ACTIVE, "apa_yacht_grp02_1_int") || Function.Call<bool>(Hash.IS_IPL_ACTIVE, "apa_yacht_grp02_2_int") || Function.Call<bool>(Hash.IS_IPL_ACTIVE, "apa_yacht_grp02_3_int")
				|| Function.Call<bool>(Hash.IS_IPL_ACTIVE, "apa_yacht_grp03_1_int") || Function.Call<bool>(Hash.IS_IPL_ACTIVE, "apa_yacht_grp03_2_int") || Function.Call<bool>(Hash.IS_IPL_ACTIVE, "apa_yacht_grp03_3_int")
				|| Function.Call<bool>(Hash.IS_IPL_ACTIVE, "apa_yacht_grp04_1_int") || Function.Call<bool>(Hash.IS_IPL_ACTIVE, "apa_yacht_grp04_2_int") || Function.Call<bool>(Hash.IS_IPL_ACTIVE, "apa_yacht_grp04_3_int")
				|| Function.Call<bool>(Hash.IS_IPL_ACTIVE, "apa_yacht_grp05_1_int") || Function.Call<bool>(Hash.IS_IPL_ACTIVE, "apa_yacht_grp05_2_int") || Function.Call<bool>(Hash.IS_IPL_ACTIVE, "apa_yacht_grp05_3_int")
				|| Function.Call<bool>(Hash.IS_IPL_ACTIVE, "apa_yacht_grp06_1_int") || Function.Call<bool>(Hash.IS_IPL_ACTIVE, "apa_yacht_grp06_2_int") || Function.Call<bool>(Hash.IS_IPL_ACTIVE, "apa_yacht_grp06_3_int")
				|| Function.Call<bool>(Hash.IS_IPL_ACTIVE, "apa_yacht_grp07_1_int") || Function.Call<bool>(Hash.IS_IPL_ACTIVE, "apa_yacht_grp07_2_int") || Function.Call<bool>(Hash.IS_IPL_ACTIVE, "apa_yacht_grp07_3_int")
				|| Function.Call<bool>(Hash.IS_IPL_ACTIVE, "apa_yacht_grp08_1_int") || Function.Call<bool>(Hash.IS_IPL_ACTIVE, "apa_yacht_grp08_2_int") || Function.Call<bool>(Hash.IS_IPL_ACTIVE, "apa_yacht_grp08_3_int")
				|| Function.Call<bool>(Hash.IS_IPL_ACTIVE, "apa_yacht_grp09_1_int") || Function.Call<bool>(Hash.IS_IPL_ACTIVE, "apa_yacht_grp09_2_int") || Function.Call<bool>(Hash.IS_IPL_ACTIVE, "apa_yacht_grp09_3_int")
				|| Function.Call<bool>(Hash.IS_IPL_ACTIVE, "apa_yacht_grp10_1_int") || Function.Call<bool>(Hash.IS_IPL_ACTIVE, "apa_yacht_grp10_2_int") || Function.Call<bool>(Hash.IS_IPL_ACTIVE, "apa_yacht_grp10_3_int")
				|| Function.Call<bool>(Hash.IS_IPL_ACTIVE, "apa_yacht_grp11_1_int") || Function.Call<bool>(Hash.IS_IPL_ACTIVE, "apa_yacht_grp11_2_int") || Function.Call<bool>(Hash.IS_IPL_ACTIVE, "apa_yacht_grp11_3_int")
				|| Function.Call<bool>(Hash.IS_IPL_ACTIVE, "apa_yacht_grp12_1_int") || Function.Call<bool>(Hash.IS_IPL_ACTIVE, "apa_yacht_grp12_2_int") || Function.Call<bool>(Hash.IS_IPL_ACTIVE, "apa_yacht_grp12_3_int"))
			{
				isShipCamNeeded = true;
				ToggleShipCamShake();
			}
		}
		else if (isShipCamNeeded)
		{
			isShipCamNeeded = false;
			Function.Call(Hash.STOP_GAMEPLAY_CAM_SHAKING);
		}
		
		
		if (plrChar.Position.DistanceTo(MBTGarageShutterPos) < 15f)
		{
			Function.Call(Hash.REMOVE_IPL, "mbt_garage_shutter");
		}
		else
		{
			Function.Call(Hash.REQUEST_IPL, "mbt_garage_shutter");
		}
		if (plrChar.Position.DistanceTo(LombankGarageShutterPos) < 15f)
		{
			Function.Call(Hash.REMOVE_IPL, "lombank_garage_shutter");
		}
		else
		{
			Function.Call(Hash.REQUEST_IPL, "lombank_garage_shutter");
		}
		if (plrChar.Position.DistanceTo(MBWestGarageShutterPos) < 10f)
		{
			Function.Call(Hash.REMOVE_IPL, "mb_west_garage_shutter");
		}
		else
		{
			Function.Call(Hash.REQUEST_IPL, "mb_west_garage_shutter");
		}
		
		//Military Base Elevator
		if (plrChar != null & plrChar.IsAlive && plrChar.Position.DistanceTo(MilBaseTowerElevatorEntryPos) < 2f)
		{
			Function.Call(Hash.DRAW_MARKER, 1,-2360.8f, 3249.45f, 31.8f, 0f, 0f, 0f, 0f, 0f, 0f, 0.6f, 0.6f, 0.5f, 240, 200, 80, 150, false, false, 2, false, false, false);
			DisplayHelpText("Press ~INPUT_CONTEXT~ to use the elevator.");
		}
		if (Game.IsControlJustPressed(2, GTA.Control.Context) && plrChar.Position.DistanceTo(MilBaseTowerElevatorEntryPos) < 2f)
		{
			Game.Player.Character.FreezePosition = true;
			Game.FadeScreenOut(100);
			Script.Wait(1500);
			Game.Player.Character.Position = MilBaseTowerElevatorSpawnPosIn;
			Game.Player.Character.Heading = 329.20f;
			Function.Call(Hash.SET_GAMEPLAY_CAM_RELATIVE_HEADING, 0f);
			Function.Call(Hash.SET_GAMEPLAY_CAM_RELATIVE_PITCH, 0f);
			Game.Player.Character.FreezePosition = false;
			Script.Wait(1500);
			Game.FadeScreenIn(500);
		}
		if (plrChar != null & plrChar.IsAlive && plrChar.Position.DistanceTo(MilBaseTowerElevatorExitPos) < 2f)
		{
			Function.Call(Hash.DRAW_MARKER, 1,-2360.8f, 3249.50f, 91.90f, 0f, 0f, 0f, 0f, 0f, 0f, 0.6f, 0.6f, 0.5f, 240, 200, 80, 150, false, false, 2, false, false, false);
			DisplayHelpText("Press ~INPUT_CONTEXT~ to use the elevator.");
		}
		if (Game.IsControlJustPressed(2, GTA.Control.Context) && plrChar.Position.DistanceTo(MilBaseTowerElevatorExitPos) < 2f)
		{
			Game.Player.Character.FreezePosition = true;
			Game.FadeScreenOut(100);
			Script.Wait(1500);
			Game.Player.Character.Position = MilBaseTowerElevatorSpawnPosOut;
			Game.Player.Character.Heading = 296.20f;
			Function.Call(Hash.SET_GAMEPLAY_CAM_RELATIVE_HEADING, 0f);
			Function.Call(Hash.SET_GAMEPLAY_CAM_RELATIVE_PITCH, 0f);
			Game.Player.Character.FreezePosition = false;
			Script.Wait(1500);
			Game.FadeScreenIn(500);
		}
		
		//Casting Trailer
		if (plrChar != null & plrChar.IsAlive && plrChar.Position.DistanceTo(ReplayCastingTrailerEntryPos) < 2f)
		{
			Function.Call(Hash.DRAW_MARKER, 1,-1027.6f, -499.2f, 35.73f, 0f, 0f, 0f, 0f, 0f, 0f, 0.6f, 0.6f, 0.5f, 240, 200, 80, 150, false, false, 2, false, false, false);
			DisplayHelpText("Press ~INPUT_CONTEXT~ to reach the Casting Trailer.");
		}
		if (Game.IsControlJustPressed(2, GTA.Control.Context) && plrChar.Position.DistanceTo(ReplayCastingTrailerEntryPos) < 2f)
		{
			Game.Player.Character.FreezePosition = true;
			Game.FadeScreenOut(100);
			Script.Wait(1500);
			Function.Call(Hash.REQUEST_IPL, "replay");
			Function.Call(Hash.REQUEST_IPL, "replay_placement");
			Game.Player.Character.Position = ReplayCastingTrailerSpawnPosIn;
			Game.Player.Character.Heading = 65.65f;
			Function.Call(Hash.SET_GAMEPLAY_CAM_RELATIVE_HEADING, 0f);
			Function.Call(Hash.SET_GAMEPLAY_CAM_RELATIVE_PITCH, 0f);
			Game.Player.Character.FreezePosition = false;
			Script.Wait(1500);
			Game.FadeScreenIn(500);
		}
		if (plrChar != null & plrChar.IsAlive && plrChar.Position.DistanceTo(ReplayCastingTrailerExitPos) < 2f)
		{
			Function.Call(Hash.DRAW_MARKER, 1,-25.7f, -4.9f, 499.05f, 0f, 0f, 0f, 0f, 0f, 0f, 0.6f, 0.6f, 0.5f, 240, 200, 80, 150, false, false, 2, false, false, false);
			DisplayHelpText("Press ~INPUT_CONTEXT~ to go back to the Studios.");
		}
		if (Game.IsControlJustPressed(2, GTA.Control.Context) && plrChar.Position.DistanceTo(ReplayCastingTrailerExitPos) < 2f)
		{
			Game.Player.Character.FreezePosition = true;
			Game.FadeScreenOut(100);
			Script.Wait(1500);
			Function.Call(Hash.REMOVE_IPL, "replay");
			Function.Call(Hash.REMOVE_IPL, "replay_placement");
			Game.Player.Character.Position = ReplayCastingTrailerSpawnPosOut;
			Game.Player.Character.Heading = 77.40f;
			Function.Call(Hash.SET_GAMEPLAY_CAM_RELATIVE_HEADING, 0f);
			Function.Call(Hash.SET_GAMEPLAY_CAM_RELATIVE_PITCH, 0f);
			Game.Player.Character.FreezePosition = false;
			Script.Wait(1500);
			Game.FadeScreenIn(500);
		}
		
		//Maze Bank Office
		if (plrChar != null & plrChar.IsAlive && plrChar.Position.DistanceTo(MBTOfficeRequestHeliPos) < 1f)
		{
			DisplayHelpText("Press ~INPUT_CONTEXT~ to request a Buzzard or ~INPUT_CONTEXT_SECONDARY~ for a Cargobob.");
		}
		if (Game.IsControlJustPressed(2, GTA.Control.Context) && plrChar.Position.DistanceTo(MBTOfficeRequestHeliPos) < 1f)
		{
			Vehicle Heli = World.CreateVehicle(VehicleHash.Buzzard, MBTOfficeHeliSpawnPos);
			Heli.Heading = 260.90f;
			Heli.PlaceOnGround();
			Heli.IsPersistent = false;
			UI.Notify("Buzzard delivered.");
		}
		if (Game.IsControlJustPressed(2, GTA.Control.ContextSecondary) && plrChar.Position.DistanceTo(MBTOfficeRequestHeliPos) < 1f)
		{
			Vehicle Heli = World.CreateVehicle(VehicleHash.Cargobob, MBTOfficeHeliSpawnPos);
			Heli.Heading = 260.90f;
			Heli.PlaceOnGround();
			Heli.IsPersistent = false;
			UI.Notify("Cargobob delivered.");
		}
		if (plrChar != null & plrChar.IsAlive && plrChar.Position.DistanceTo(MBTOfficeSleepPos) < 1f)
		{
			DisplayHelpText("Press ~INPUT_CONTEXT~ to sleep.");
		}
		if (Game.IsControlJustPressed(2, GTA.Control.Context) && plrChar.Position.DistanceTo(MBTOfficeSleepPos) < 1f)
		{
			Game.Player.Character.FreezePosition = true;
			Game.FadeScreenOut(500);
			Script.Wait(500);
			Function.Call(Hash.ADVANCE_CLOCK_TIME_TO, 6, 0, 0);
			Game.Player.WantedLevel = 0;
			Function.Call(Hash.CLEAR_PED_BLOOD_DAMAGE, Game.Player.Character);
			Function.Call(Hash.CLEAR_PED_WETNESS, Game.Player.Character);
			Game.Player.Character.Position = MBTOfficeSleepRespawnPos;
			Game.Player.Character.Heading = 248.15f;
			Function.Call(Hash.SET_GAMEPLAY_CAM_RELATIVE_HEADING, 0f);
			Function.Call(Hash.SET_GAMEPLAY_CAM_RELATIVE_PITCH, 0f);
			Game.Player.Character.FreezePosition = false;
			Script.Wait(1500);
			Game.FadeScreenIn(500);
		}
		if (plrChar != null & plrChar.IsAlive && plrChar.Position.DistanceTo(MBTOfficeStartSitPos) < 1f)
		{
			DisplayHelpText("Press ~INPUT_CONTEXT~ to sit on the couch.");
		}
		if (Game.IsControlJustPressed(2, GTA.Control.Context) && plrChar.Position.DistanceTo(MBTOfficeStartSitPos) < 1f)
		{
			Game.FadeScreenOut(500);
			Script.Wait(500);
			Game.Player.Character.FreezePosition = true;
			Game.Player.Character.Position = MBTOfficeSitPos;
			Game.Player.Character.Heading = 160f;
			Function.Call(Hash.SET_GAMEPLAY_CAM_RELATIVE_HEADING, 0f);
			Function.Call(Hash.SET_GAMEPLAY_CAM_RELATIVE_PITCH, 0f);
			Game.Player.Character.Task.PlayAnimation("anim@amb@office@seating@male@var_e@base@", "base", 8f, -1, true, -1f);
			Script.Wait(500);
			Game.FadeScreenIn(500);
		}
		if (plrChar != null & plrChar.IsAlive && plrChar.Position.DistanceTo(MBTOfficeSitPos) < 2f)
		{
			DisplayHelpText("Press ~INPUT_CONTEXT~ to get up.");
		}
		if (Game.IsControlJustPressed(2, GTA.Control.Context) && plrChar.Position.DistanceTo(MBTOfficeSitPos) < 2f)
		{
			Game.Player.Character.FreezePosition = true;
			Game.FadeScreenOut(500);
			Script.Wait(500);
			Game.Player.Character.Position = MBTOfficeSitRespawnPos;
			Game.Player.Character.Heading = 117.50f;
			Function.Call(Hash.SET_GAMEPLAY_CAM_RELATIVE_HEADING, 0f);
			Function.Call(Hash.SET_GAMEPLAY_CAM_RELATIVE_PITCH, 0f);
			Game.Player.Character.Task.ClearAnimation("anim@amb@office@seating@male@var_e@base@", "base");
			Game.Player.Character.FreezePosition = false;
			Script.Wait(500);
			Game.FadeScreenIn(500);
		}
		
		//Maze Bank Garage A
		if (plrChar != null & plrChar.IsAlive && plrChar.Position.DistanceTo(MBTCarGarageAEntryPos) < 1f)
		{
			Function.Call(Hash.DRAW_MARKER, 1,-75.55f, -827.15f, 242.4f, 0f, 0f, 0f, 0f, 0f, 0f, 0.6f, 0.6f, 0.5f, 240, 200, 80, 150, false, false, 2, false, false, false);
			DisplayHelpText("Press ~INPUT_CONTEXT~ to enter the Car Garage A.");
		}
		if (Game.IsControlJustPressed(2, GTA.Control.Context) && plrChar.Position.DistanceTo(MBTCarGarageAEntryPos) < 1f)
		{
			Game.Player.Character.FreezePosition = true;
			Game.FadeScreenOut(100);
			Script.Wait(1500);
			Function.Call(Hash.REQUEST_IPL, "imp_dt1_11_cargarage_a");
			Function.Call((Hash)0x55E86AF2712B36A1, 254465, MBTCarGarageADecor);
			Function.Call((Hash)0x55E86AF2712B36A1, 254465, MBTCarGarageALighting);
			Function.Call((Hash)0x55E86AF2712B36A1, 254465, MBTCarGarageANumberingStyle);
			Function.Call((Hash)0x41F37C3427C75AE0, 254465);
			Game.Player.Character.Position = MBTCarGarageASpawnPosIn;
			Game.Player.Character.Heading = 247.20f;
			Function.Call(Hash.SET_GAMEPLAY_CAM_RELATIVE_HEADING, 0f);
			Function.Call(Hash.SET_GAMEPLAY_CAM_RELATIVE_PITCH, 0f);
			Game.Player.Character.FreezePosition = false;
			Script.Wait(1500);
			Game.FadeScreenIn(500);
		}
		if (plrChar != null & plrChar.IsAlive && plrChar.Position.DistanceTo(MBTCarGarageAExitPos) < 1f)
		{
			Function.Call(Hash.DRAW_MARKER, 1,-91.6f, -821.2f, 221f, 0f, 0f, 0f, 0f, 0f, 0f, 0.6f, 0.6f, 0.5f, 240, 200, 80, 150, false, false, 2, false, false, false);
			DisplayHelpText("Press ~INPUT_CONTEXT_SECONDARY~ to exit.");
		}
		if (Game.IsControlJustPressed(2, GTA.Control.ContextSecondary) && plrChar.Position.DistanceTo(MBTCarGarageAExitPos) < 1f)
		{
			Game.Player.Character.FreezePosition = true;
			Game.FadeScreenOut(100);
			Script.Wait(1500);
			Function.Call(Hash.REMOVE_IPL, "imp_dt1_11_cargarage_a");
			Function.Call((Hash)0x420BD37289EEE162, 254465, MBTCarGarageADecor);
			Function.Call((Hash)0x420BD37289EEE162, 254465, MBTCarGarageALighting);
			Function.Call((Hash)0x420BD37289EEE162, 254465, MBTCarGarageANumberingStyle);
			Function.Call((Hash)0x41F37C3427C75AE0, 254465);
			Game.Player.Character.Position = MBTOfficeSpawnPosIn;
			Game.Player.Character.Heading = 339.55f;
			Function.Call(Hash.SET_GAMEPLAY_CAM_RELATIVE_HEADING, 0f);
			Function.Call(Hash.SET_GAMEPLAY_CAM_RELATIVE_PITCH, 0f);
			Game.Player.Character.FreezePosition = false;
			Script.Wait(1500);
			Game.FadeScreenIn(500);
		}
		
		//Maze Bank Garage B
		if (plrChar != null & plrChar.IsAlive && plrChar.Position.DistanceTo(MBTCarGarageBEntryPos) < 1f)
		{
			Function.Call(Hash.DRAW_MARKER, 1,-76.7f, -830.2f, 242.4f, 0f, 0f, 0f, 0f, 0f, 0f, 0.6f, 0.6f, 0.5f, 240, 200, 80, 150, false, false, 2, false, false, false);
			DisplayHelpText("Press ~INPUT_CONTEXT~ to enter the Car Garage B.");
		}
		if (Game.IsControlJustPressed(2, GTA.Control.Context) && plrChar.Position.DistanceTo(MBTCarGarageBEntryPos) < 1f)
		{
			Game.Player.Character.FreezePosition = true;
			Game.FadeScreenOut(100);
			Script.Wait(1500);
			Function.Call(Hash.REQUEST_IPL, "imp_dt1_11_cargarage_b");
			Function.Call((Hash)0x55E86AF2712B36A1, 254721, MBTCarGarageBDecor);
			Function.Call((Hash)0x55E86AF2712B36A1, 254721, MBTCarGarageBLighting);
			Function.Call((Hash)0x55E86AF2712B36A1, 254721, MBTCarGarageBNumberingStyle);
			Function.Call((Hash)0x41F37C3427C75AE0, 254721);
			Game.Player.Character.Position = MBTCarGarageBSpawnPosIn;
			Game.Player.Character.Heading = 337.55f;
			Function.Call(Hash.SET_GAMEPLAY_CAM_RELATIVE_HEADING, 0f);
			Function.Call(Hash.SET_GAMEPLAY_CAM_RELATIVE_PITCH, 0f);
			Game.Player.Character.FreezePosition = false;
			Script.Wait(1500);
			Game.FadeScreenIn(500);
		}
		if (plrChar != null & plrChar.IsAlive && plrChar.Position.DistanceTo(MBTCarGarageBExitPos) < 1f)
		{
			Function.Call(Hash.DRAW_MARKER, 1,-71.7f, -832.15f, 221f, 0f, 0f, 0f, 0f, 0f, 0f, 0.6f, 0.6f, 0.5f, 240, 200, 80, 150, false, false, 2, false, false, false);
			DisplayHelpText("Press ~INPUT_CONTEXT_SECONDARY~ to exit.");
		}
		if (Game.IsControlJustPressed(2, GTA.Control.ContextSecondary) && plrChar.Position.DistanceTo(MBTCarGarageBExitPos) < 1f)
		{
			Game.Player.Character.FreezePosition = true;
			Game.FadeScreenOut(100);
			Script.Wait(1500);
			Function.Call(Hash.REMOVE_IPL, "imp_dt1_11_cargarage_b");
			Function.Call((Hash)0x420BD37289EEE162, 254721, MBTCarGarageBDecor);
			Function.Call((Hash)0x420BD37289EEE162, 254721, MBTCarGarageBLighting);
			Function.Call((Hash)0x420BD37289EEE162, 254721, MBTCarGarageBNumberingStyle);
			Function.Call((Hash)0x41F37C3427C75AE0, 254721);
			Game.Player.Character.Position = MBTOfficeSpawnPosIn;
			Game.Player.Character.Heading = 339.55f;
			Function.Call(Hash.SET_GAMEPLAY_CAM_RELATIVE_HEADING, 0f);
			Function.Call(Hash.SET_GAMEPLAY_CAM_RELATIVE_PITCH, 0f);
			Game.Player.Character.FreezePosition = false;
			Script.Wait(1500);
			Game.FadeScreenIn(500);
		}
		
		//Maze Bank Garage C
		if (plrChar != null & plrChar.IsAlive && plrChar.Position.DistanceTo(MBTCarGarageCEntryPos) < 1f)
		{
			Function.Call(Hash.DRAW_MARKER, 1,-78.75f, -829.50f, 242.4f, 0f, 0f, 0f, 0f, 0f, 0f, 0.6f, 0.6f, 0.5f, 240, 200, 80, 150, false, false, 2, false, false, false);
			DisplayHelpText("Press ~INPUT_CONTEXT~ to enter the Car Garage C.");
		}
		if (Game.IsControlJustPressed(2, GTA.Control.Context) && plrChar.Position.DistanceTo(MBTCarGarageCEntryPos) < 1f)
		{
			Game.Player.Character.FreezePosition = true;
			Game.FadeScreenOut(100);
			Script.Wait(1500);
			Function.Call(Hash.REQUEST_IPL, "imp_dt1_11_cargarage_c");
			Function.Call((Hash)0x55E86AF2712B36A1, 254977, MBTCarGarageCDecor);
			Function.Call((Hash)0x55E86AF2712B36A1, 254977, MBTCarGarageCLighting);
			Function.Call((Hash)0x55E86AF2712B36A1, 254977, MBTCarGarageCNumberingStyle);
			Function.Call((Hash)0x41F37C3427C75AE0, 254977);
			Game.Player.Character.Position = MBTCarGarageCSpawnPosIn;
			Game.Player.Character.Heading = 158.35f;
			Function.Call(Hash.SET_GAMEPLAY_CAM_RELATIVE_HEADING, 0f);
			Function.Call(Hash.SET_GAMEPLAY_CAM_RELATIVE_PITCH, 0f);
			Game.Player.Character.FreezePosition = false;
			Script.Wait(1500);
			Game.FadeScreenIn(500);
		}
		if (plrChar != null & plrChar.IsAlive && plrChar.Position.DistanceTo(MBTCarGarageCExitPos) < 1f)
		{
			Function.Call(Hash.DRAW_MARKER, 1,-78.6f, -805.9f, 221f, 0f, 0f, 0f, 0f, 0f, 0f, 0.6f, 0.6f, 0.5f, 240, 200, 80, 150, false, false, 2, false, false, false);
			DisplayHelpText("Press ~INPUT_CONTEXT_SECONDARY~ to exit.");
		}
		if (Game.IsControlJustPressed(2, GTA.Control.ContextSecondary) && plrChar.Position.DistanceTo(MBTCarGarageCExitPos) < 1f)
		{
			Game.Player.Character.FreezePosition = true;
			Game.FadeScreenOut(100);
			Script.Wait(1500);
			Function.Call(Hash.REMOVE_IPL, "imp_dt1_11_cargarage_c");
			Function.Call((Hash)0x420BD37289EEE162, 254977, MBTCarGarageCDecor);
			Function.Call((Hash)0x420BD37289EEE162, 254977, MBTCarGarageCLighting);
			Function.Call((Hash)0x420BD37289EEE162, 254977, MBTCarGarageCNumberingStyle);
			Function.Call((Hash)0x41F37C3427C75AE0, 254977);
			Game.Player.Character.Position = MBTOfficeSpawnPosIn;
			Game.Player.Character.Heading = 339.55f;
			Function.Call(Hash.SET_GAMEPLAY_CAM_RELATIVE_HEADING, 0f);
			Function.Call(Hash.SET_GAMEPLAY_CAM_RELATIVE_PITCH, 0f);
			Game.Player.Character.FreezePosition = false;
			Script.Wait(1500);
			Game.FadeScreenIn(500);
		}
		
		//Maze Bank Mod Garage
		if (plrChar != null & plrChar.IsAlive && plrChar.Position.DistanceTo(MBTModGarageEntryPos) < 1f)
		{
			Function.Call(Hash.DRAW_MARKER, 1,-77.6f, -826.4f, 242.4f, 0f, 0f, 0f, 0f, 0f, 0f, 0.6f, 0.6f, 0.5f, 240, 200, 80, 150, false, false, 2, false, false, false);
			DisplayHelpText("Press ~INPUT_CONTEXT~ to enter the Mod Garage.");
		}
		if (Game.IsControlJustPressed(2, GTA.Control.Context) && plrChar.Position.DistanceTo(MBTModGarageEntryPos) < 1f)
		{
			Game.Player.Character.FreezePosition = true;
			Game.FadeScreenOut(100);
			Script.Wait(1500);
			Game.Player.Character.Position = MBTModGarageSpawnPosIn;
			Game.Player.Character.Heading = 138.80f;
			Function.Call(Hash.SET_GAMEPLAY_CAM_RELATIVE_HEADING, 0f);
			Function.Call(Hash.SET_GAMEPLAY_CAM_RELATIVE_PITCH, 0f);
			Game.Player.Character.FreezePosition = false;
			Script.Wait(1500);
			Game.FadeScreenIn(500);
		}
		if (plrChar != null & plrChar.IsAlive && plrChar.Position.DistanceTo(MBTModGarageExitPos) < 1f)
		{
			Function.Call(Hash.DRAW_MARKER, 1,-68.75f, -814.2f, 284f, 0f, 0f, 0f, 0f, 0f, 0f, 0.6f, 0.6f, 0.5f, 240, 200, 80, 150, false, false, 2, false, false, false);
			DisplayHelpText("Press ~INPUT_CONTEXT~ to exit.");
		}
		if (Game.IsControlJustPressed(2, GTA.Control.Context) && plrChar.Position.DistanceTo(MBTModGarageExitPos) < 1f)
		{
			Game.Player.Character.FreezePosition = true;
			Game.FadeScreenOut(100);
			Script.Wait(1500);
			Game.Player.Character.Position = MBTOfficeSpawnPosIn;
			Game.Player.Character.Heading = 339.55f;
			Function.Call(Hash.SET_GAMEPLAY_CAM_RELATIVE_HEADING, 0f);
			Function.Call(Hash.SET_GAMEPLAY_CAM_RELATIVE_PITCH, 0f);
			Game.Player.Character.FreezePosition = false;
			Script.Wait(1500);
			Game.FadeScreenIn(500);
		}
		if (plrChar != null & plrChar.IsAlive && plrChar.Position.DistanceTo(MBTModGarageEntryPos2) < 3f)
		{
			Function.Call(Hash.DRAW_MARKER, 1,-84.2f, -821.6f, 35.05f, 0f, 0f, 0f, 0f, 0f, 0f, 4f, 4f, 0.25f, 240, 200, 80, 150, false, false, 2, false, false, false);
			DisplayHelpText("Press ~INPUT_CONTEXT_SECONDARY~ to enter the Mod Garage.");
		}
		if (Game.IsControlJustPressed(2, GTA.Control.ContextSecondary) && plrChar.Position.DistanceTo(MBTModGarageEntryPos2) < 3f)
		{
			if (Game.Player.Character.IsInVehicle())
			{
				Game.FadeScreenOut(100);
				Script.Wait(1500);
				Game.Player.Character.CurrentVehicle.Position = MBTModGarageSpawnPosIn2;
				Game.Player.Character.CurrentVehicle.Heading = 158.80f;
				Function.Call(Hash.SET_GAMEPLAY_CAM_RELATIVE_HEADING, 0f);
				Function.Call(Hash.SET_GAMEPLAY_CAM_RELATIVE_PITCH, 0f);
				Script.Wait(1500);
				Game.FadeScreenIn(500);
			}
			else
			{
				Game.Player.Character.FreezePosition = true;
				Game.FadeScreenOut(100);
				Script.Wait(1500);
				Game.Player.Character.Position = MBTModGarageSpawnPosIn2;
				Game.Player.Character.Heading = 158.80f;
				Function.Call(Hash.SET_GAMEPLAY_CAM_RELATIVE_HEADING, 0f);
				Function.Call(Hash.SET_GAMEPLAY_CAM_RELATIVE_PITCH, 0f);
				Game.Player.Character.FreezePosition = false;
				Script.Wait(1500);
				Game.FadeScreenIn(500);
			}
		}
		if (plrChar != null & plrChar.IsAlive && plrChar.Position.DistanceTo(MBTModGarageExitPos2) < 3f)
		{
			Function.Call(Hash.DRAW_MARKER, 1,-72.25f, -812.75f, 284f, 0f, 0f, 0f, 0f, 0f, 0f, 4f, 4f, 0.25f, 240, 200, 80, 150, false, false, 2, false, false, false);
			DisplayHelpText("Press ~INPUT_CONTEXT~ to exit.");
		}
		if (Game.IsControlJustPressed(2, GTA.Control.Context) && plrChar.Position.DistanceTo(MBTModGarageExitPos2) < 3f)
		{
			if (Game.Player.Character.IsInVehicle())
			{
				Game.FadeScreenOut(100);
				Script.Wait(1500);
				Game.Player.Character.CurrentVehicle.Position = MBTModGarageSpawnPosOut2;
				Game.Player.Character.CurrentVehicle.Heading = 350f;
				Function.Call(Hash.SET_GAMEPLAY_CAM_RELATIVE_HEADING, 0f);
				Function.Call(Hash.SET_GAMEPLAY_CAM_RELATIVE_PITCH, 0f);
				Script.Wait(1500);
				Game.FadeScreenIn(500);
			}
		else
			{
				Game.Player.Character.FreezePosition = true;
				Game.FadeScreenOut(100);
				Script.Wait(1500);
				Game.Player.Character.Position = MBTModGarageSpawnPosOut2;
				Game.Player.Character.Heading = 350f;
				Function.Call(Hash.SET_GAMEPLAY_CAM_RELATIVE_HEADING, 0f);
				Function.Call(Hash.SET_GAMEPLAY_CAM_RELATIVE_PITCH, 0f);
				Game.Player.Character.FreezePosition = false;
				Script.Wait(1500);
				Game.FadeScreenIn(500);
			}
		}
		
		//Vehicle Warehouse
		if (plrChar != null & plrChar.IsAlive && plrChar.Position.DistanceTo(CarWarehouseEntryPos) < 3f)
		{
			Function.Call(Hash.DRAW_MARKER, 1,-1154f, -2172.5f, 12.25f, 0f, 0f, 0f, 0f, 0f, 0f, 4.25f, 4.25f, 0.35f, 240, 200, 80, 150, false, false, 2, false, false, false);
			DisplayHelpText("Press ~INPUT_CONTEXT~ to enter the Vehicle Warehouse.");
		}
		if (Game.IsControlJustPressed(2, GTA.Control.Context) && plrChar.Position.DistanceTo(CarWarehouseEntryPos) < 3f)
		{
			if (Game.Player.Character.IsInVehicle())
			{
				Game.FadeScreenOut(100);
				Script.Wait(1500);
				Game.Player.Character.CurrentVehicle.Position = CarWarehouseSpawnPosIn;
				Game.Player.Character.CurrentVehicle.Heading = 177.55f;
				Function.Call(Hash.SET_GAMEPLAY_CAM_RELATIVE_HEADING, 0f);
				Function.Call(Hash.SET_GAMEPLAY_CAM_RELATIVE_PITCH, 0f);
				Script.Wait(1500);
				Game.FadeScreenIn(500);
			}
				else
			{
				Game.Player.Character.FreezePosition = true;
				Game.FadeScreenOut(100);
				Script.Wait(1500);
				Game.Player.Character.Position = CarWarehouseSpawnPosIn;
				Game.Player.Character.Heading = 179.50f;
				Function.Call(Hash.SET_GAMEPLAY_CAM_RELATIVE_HEADING, 0f);
				Function.Call(Hash.SET_GAMEPLAY_CAM_RELATIVE_PITCH, 0f);
				Game.Player.Character.FreezePosition = false;
				Script.Wait(1500);
				Game.FadeScreenIn(500);
			}
		}
		if (plrChar != null & plrChar.IsAlive && plrChar.Position.DistanceTo(CarWarehouseExitPos) < 3f)
		{
			Function.Call(Hash.DRAW_MARKER, 1,971f, -2990.5f, -40.65f, 0f, 0f, 0f, 0f, 0f, 0f, 4.25f, 4.25f, 0.35f, 240, 200, 80, 150, false, false, 2, false, false, false);
			DisplayHelpText("Press ~INPUT_CONTEXT~ to exit.");
		}
		if (Game.IsControlJustPressed(2, GTA.Control.Context) && plrChar.Position.DistanceTo(CarWarehouseExitPos) < 3f)
		{
			if (Game.Player.Character.IsInVehicle())
			{
				Game.FadeScreenOut(100);
				Script.Wait(1500);
				Game.Player.Character.CurrentVehicle.Position = CarWarehouseSpawnPosOut;
				Game.Player.Character.CurrentVehicle.Heading = 190.80f;
				Function.Call(Hash.SET_GAMEPLAY_CAM_RELATIVE_HEADING, 0f);
				Function.Call(Hash.SET_GAMEPLAY_CAM_RELATIVE_PITCH, 0f);
				Script.Wait(1500);
				Game.FadeScreenIn(500);
			}
				else
			{
				Game.Player.Character.FreezePosition = true;
				Game.FadeScreenOut(100);
				Script.Wait(1500);
				Game.Player.Character.Position = CarWarehouseSpawnPosOut;
				Game.Player.Character.Heading = 190.30f;
				Function.Call(Hash.SET_GAMEPLAY_CAM_RELATIVE_HEADING, 0f);
				Function.Call(Hash.SET_GAMEPLAY_CAM_RELATIVE_PITCH, 0f);
				Game.Player.Character.FreezePosition = false;
				Script.Wait(1500);
				Game.FadeScreenIn(500);
			}
		}
		if (plrChar != null & plrChar.IsAlive && plrChar.Position.DistanceTo(CarWarehouseSleepPos) < 1f)
		{
			DisplayHelpText("Press ~INPUT_CONTEXT~ to sleep.");
		}
		if (Game.IsControlJustPressed(2, GTA.Control.Context) && plrChar.Position.DistanceTo(CarWarehouseSleepPos) < 1f)
		{
			Game.Player.Character.FreezePosition = true;
			Game.FadeScreenOut(500);
			Script.Wait(500);
			Function.Call(Hash.ADVANCE_CLOCK_TIME_TO, 6, 0, 0);
			Game.Player.WantedLevel = 0;
			Function.Call(Hash.CLEAR_PED_BLOOD_DAMAGE, Game.Player.Character);
			Function.Call(Hash.CLEAR_PED_WETNESS, Game.Player.Character);
			Game.Player.Character.Position = CarWarehouseSleepRespawnPos;
			Game.Player.Character.Heading = 292f;
			Function.Call(Hash.SET_GAMEPLAY_CAM_RELATIVE_HEADING, 0f);
			Function.Call(Hash.SET_GAMEPLAY_CAM_RELATIVE_PITCH, 0f);
			Game.Player.Character.FreezePosition = false;
			Script.Wait(1500);
			Game.FadeScreenIn(500);
		}
		
		//Bunker
		if (plrChar != null & plrChar.IsAlive && plrChar.Position.DistanceTo(BunkerEntryPos) < 3f)
		{
			Function.Call(Hash.DRAW_MARKER, 1,2108f, 3325f, 44.35f, 0f, 0f, 0f, 0f, 0f, 0f, 4.25f, 4.25f, 0.35f, 240, 200, 80, 150, false, false, 2, false, false, false);
			DisplayHelpText("Press ~INPUT_CONTEXT~ to enter the Bunker.");
		}
		if (Game.IsControlJustPressed(2, GTA.Control.Context) && plrChar.Position.DistanceTo(BunkerEntryPos) < 3f)
		{
			if (Game.Player.Character.IsInVehicle())
			{
				Game.FadeScreenOut(100);
				Script.Wait(1500);
				Game.Player.Character.CurrentVehicle.Position = BunkerSpawnPosIn;
				Game.Player.Character.CurrentVehicle.Heading = 69.85f;
				Function.Call(Hash.SET_GAMEPLAY_CAM_RELATIVE_HEADING, 0f);
				Function.Call(Hash.SET_GAMEPLAY_CAM_RELATIVE_PITCH, 0f);
				Script.Wait(1500);
				Game.FadeScreenIn(500);
			}
				else
			{
				Game.FadeScreenOut(100);
				Script.Wait(1500);
				Game.Player.Character.Position = BunkerSpawnPosIn;
				Game.Player.Character.Heading = 69.85f;
				Function.Call(Hash.SET_GAMEPLAY_CAM_RELATIVE_HEADING, 0f);
				Function.Call(Hash.SET_GAMEPLAY_CAM_RELATIVE_PITCH, 0f);
				Script.Wait(1500);
				Game.FadeScreenIn(500);
			}
		}
		if (plrChar != null & plrChar.IsAlive && plrChar.Position.DistanceTo(BunkerExitPos) < 3f)
		{
			Function.Call(Hash.DRAW_MARKER, 1,893f, -3245.5f, -99.25f, 0f, 0f, 0f, 0f, 0f, 0f, 4f, 4f, 0.25f, 240, 200, 80, 150, false, false, 2, false, false, false);
			DisplayHelpText("Press ~INPUT_CONTEXT~ to exit.");
		}
		if (Game.IsControlJustPressed(2, GTA.Control.Context) && plrChar.Position.DistanceTo(BunkerExitPos) < 3f)
		{
			if (Game.Player.Character.IsInVehicle())
			{
				Game.FadeScreenOut(100);
				Script.Wait(1500);
				Game.Player.Character.CurrentVehicle.Position = BunkerSpawnPosOut;
				Game.Player.Character.CurrentVehicle.Heading = 120f;
				Function.Call(Hash.SET_GAMEPLAY_CAM_RELATIVE_HEADING, 0f);
				Function.Call(Hash.SET_GAMEPLAY_CAM_RELATIVE_PITCH, 0f);
				Game.Player.Character.FreezePosition = false;
				Script.Wait(1500);
				Game.FadeScreenIn(500);
			}
				else
			{
				Game.Player.Character.FreezePosition = true;
				Game.FadeScreenOut(100);
				Script.Wait(1500);
				Game.Player.Character.Position = BunkerSpawnPosOut;
				Game.Player.Character.Heading = 120f;
				Function.Call(Hash.SET_GAMEPLAY_CAM_RELATIVE_HEADING, 0f);
				Function.Call(Hash.SET_GAMEPLAY_CAM_RELATIVE_PITCH, 0f);
				Game.Player.Character.FreezePosition = false;
				Script.Wait(1500);
				Game.FadeScreenIn(500);
			}
		}
		if (plrChar != null & plrChar.IsAlive && plrChar.Position.DistanceTo(BunkerSleepPos) < 1f)
		{
			DisplayHelpText("Press ~INPUT_CONTEXT~ to sleep.");
		}
		if (Game.IsControlJustPressed(2, GTA.Control.Context) && plrChar.Position.DistanceTo(BunkerSleepPos) < 1f)
		{
			Game.Player.Character.FreezePosition = true;
			Game.FadeScreenOut(500);
			Script.Wait(500);
			Function.Call(Hash.ADVANCE_CLOCK_TIME_TO, 6, 0, 0);
			Game.Player.WantedLevel = 0;
			Function.Call(Hash.CLEAR_PED_BLOOD_DAMAGE, Game.Player.Character);
			Function.Call(Hash.CLEAR_PED_WETNESS, Game.Player.Character);
			Game.Player.Character.Position = BunkerSleepRespawnPos;
			Game.Player.Character.Heading = 193.50f;
			Function.Call(Hash.SET_GAMEPLAY_CAM_RELATIVE_HEADING, 0f);
			Function.Call(Hash.SET_GAMEPLAY_CAM_RELATIVE_PITCH, 0f);
			Game.Player.Character.FreezePosition = false;
			Script.Wait(1500);
			Game.FadeScreenIn(500);
		}
		
		//Hangar
		if (EnableHangar)
		{
			if (plrChar != null & plrChar.IsAlive && plrChar.Position.DistanceTo(HangarEntryPos) < 7f)
			{
				Function.Call(Hash.DRAW_MARKER, 1,-1149.5f, -3406f, 12.95f, 0f, 0f, 0f, 0f, 0f, 0f, 10f, 10f, 0.35f, 240, 200, 80, 150, false, false, 2, false, false, false);
				DisplayHelpText("Press ~INPUT_CONTEXT~ to enter the Hangar.");
			}
			if (Game.IsControlJustPressed(2, GTA.Control.Context) && plrChar.Position.DistanceTo(HangarEntryPos) < 7f)
			{
				if (Game.Player.Character.IsInVehicle())
				{
					Game.FadeScreenOut(100);
					Script.Wait(1500);
					Game.Player.Character.CurrentVehicle.Position = HangarSpawnPosIn;
					Game.Player.Character.CurrentVehicle.Heading = 176.70f;
					Function.Call(Hash.SET_GAMEPLAY_CAM_RELATIVE_HEADING, 0f);
					Function.Call(Hash.SET_GAMEPLAY_CAM_RELATIVE_PITCH, 0f);
					Script.Wait(1500);
					Game.FadeScreenIn(500);
				}
					else
				{
					Game.Player.Character.FreezePosition = true;
					Game.FadeScreenOut(100);
					Script.Wait(1500);
					Game.Player.Character.Position = HangarSpawnPosIn;
					Game.Player.Character.Heading = 176.70f;
					Function.Call(Hash.SET_GAMEPLAY_CAM_RELATIVE_HEADING, 0f);
					Function.Call(Hash.SET_GAMEPLAY_CAM_RELATIVE_PITCH, 0f);
					Game.Player.Character.FreezePosition = false;
					Script.Wait(1500);
					Game.FadeScreenIn(500);
				}
			}
			if (plrChar != null & plrChar.IsAlive && plrChar.Position.DistanceTo(HangarExitPos) < 7f)
			{
				Function.Call(Hash.DRAW_MARKER, 1,-1266.5f, -2971f, -49.5f, 0f, 0f, 0f, 0f, 0f, 0f, 10f, 10f, 0.35f, 240, 200, 80, 150, false, false, 2, false, false, false);
				DisplayHelpText("Press ~INPUT_CONTEXT~ to exit.");
			}
			if (Game.IsControlJustPressed(2, GTA.Control.Context) && plrChar.Position.DistanceTo(HangarExitPos) < 7f)
			{
				if (Game.Player.Character.IsInVehicle())
				{
					Game.FadeScreenOut(100);
					Script.Wait(1500);
					Game.Player.Character.CurrentVehicle.Position = HangarSpawnPosOut;
					Game.Player.Character.CurrentVehicle.Heading = 328.70f;
					Function.Call(Hash.SET_GAMEPLAY_CAM_RELATIVE_HEADING, 0f);
					Function.Call(Hash.SET_GAMEPLAY_CAM_RELATIVE_PITCH, 0f);
					Script.Wait(1500);
					Game.FadeScreenIn(500);
				}
				else
				{
					Game.Player.Character.FreezePosition = true;
					Game.FadeScreenOut(100);
					Script.Wait(1500);
					Game.Player.Character.Position = HangarSpawnPosOut;
					Game.Player.Character.Heading = 330.70f;
					Function.Call(Hash.SET_GAMEPLAY_CAM_RELATIVE_HEADING, 0f);
					Function.Call(Hash.SET_GAMEPLAY_CAM_RELATIVE_PITCH, 0f);
					Game.Player.Character.FreezePosition = false;
					Script.Wait(1500);
					Game.FadeScreenIn(500);
				}
			}
			if (plrChar != null & plrChar.IsAlive && plrChar.Position.DistanceTo(HangarSleepPos) < 1f)
			{
				DisplayHelpText("Press ~INPUT_CONTEXT~ to sleep.");
			}
			if (Game.IsControlJustPressed(2, GTA.Control.Context) && plrChar.Position.DistanceTo(HangarSleepPos) < 1f)
			{
				Game.Player.Character.FreezePosition = true;
				Game.FadeScreenOut(500);
				Script.Wait(500);
				Function.Call(Hash.ADVANCE_CLOCK_TIME_TO, 6, 0, 0);
				Game.Player.WantedLevel = 0;
				Function.Call(Hash.CLEAR_PED_BLOOD_DAMAGE, Game.Player.Character);
				Function.Call(Hash.CLEAR_PED_WETNESS, Game.Player.Character);
				Game.Player.Character.Position = HangarSleepRespawnPos;
				Game.Player.Character.Heading = 220.75f;
				Function.Call(Hash.SET_GAMEPLAY_CAM_RELATIVE_HEADING, 0f);
				Function.Call(Hash.SET_GAMEPLAY_CAM_RELATIVE_PITCH, 0f);
				Game.Player.Character.FreezePosition = false;
				Script.Wait(1500);
				Game.FadeScreenIn(500);
			}
		}
		
		//Facility
		if (plrChar != null & plrChar.IsAlive && plrChar.Position.DistanceTo(FacilityEntryPos) < 3f)
		{
			Function.Call(Hash.DRAW_MARKER, 1,1863.17f, 267.53f, 162.83f, 0f, 0f, 0f, 0f, 0f, 0f, 4.25f, 4.25f, 0.35f, 240, 200, 80, 150, false, false, 2, false, false, false);
			DisplayHelpText("Press ~INPUT_CONTEXT~ to enter the Facility.");
		}
		if (Game.IsControlJustPressed(2, GTA.Control.Context) && plrChar.Position.DistanceTo(FacilityEntryPos) < 3f)
		{
			if (Game.Player.Character.IsInVehicle())
			{
				Game.FadeScreenOut(100);
				Script.Wait(1500);
				Game.Player.Character.CurrentVehicle.Position = FacilitySpawnPosIn;
				Game.Player.Character.CurrentVehicle.Heading = 11.55f;
				Function.Call(Hash.SET_GAMEPLAY_CAM_RELATIVE_HEADING, 0f);
				Function.Call(Hash.SET_GAMEPLAY_CAM_RELATIVE_PITCH, 0f);
				Script.Wait(1500);
				Game.FadeScreenIn(500);
			}
				else
			{
				Game.FadeScreenOut(100);
				Script.Wait(1500);
				Game.Player.Character.Position = FacilitySpawnPosIn;
				Game.Player.Character.Heading = 11.55f;
				Function.Call(Hash.SET_GAMEPLAY_CAM_RELATIVE_HEADING, 0f);
				Function.Call(Hash.SET_GAMEPLAY_CAM_RELATIVE_PITCH, 0f);
				Script.Wait(1500);
				Game.FadeScreenIn(500);
			}
		}
		if (plrChar != null & plrChar.IsAlive && plrChar.Position.DistanceTo(FacilityExitPos) < 3f)
		{
			Function.Call(Hash.DRAW_MARKER, 1,487.01f, 4819.95f, -59.38f, 0f, 0f, 0f, 0f, 0f, 0f, 4f, 4f, 0.25f, 240, 200, 80, 150, false, false, 2, false, false, false);
			DisplayHelpText("Press ~INPUT_CONTEXT~ to take the lift to the surface and exit the Facility.");
		}
		if (Game.IsControlJustPressed(2, GTA.Control.Context) && plrChar.Position.DistanceTo(FacilityExitPos) < 3f)
		{
			if (Game.Player.Character.IsInVehicle())
			{
				Game.FadeScreenOut(100);
				Script.Wait(1500);
				Game.Player.Character.CurrentVehicle.Position = FacilitySpawnPosOut;
				Game.Player.Character.CurrentVehicle.Heading = 148.25f;
				Function.Call(Hash.SET_GAMEPLAY_CAM_RELATIVE_HEADING, 0f);
				Function.Call(Hash.SET_GAMEPLAY_CAM_RELATIVE_PITCH, 0f);
				Game.Player.Character.FreezePosition = false;
				Script.Wait(1500);
				Game.FadeScreenIn(500);
			}
				else
			{
				Game.Player.Character.FreezePosition = true;
				Game.FadeScreenOut(100);
				Script.Wait(1500);
				Game.Player.Character.Position = FacilitySpawnPosOut;
				Game.Player.Character.Heading = 148.25f;
				Function.Call(Hash.SET_GAMEPLAY_CAM_RELATIVE_HEADING, 0f);
				Function.Call(Hash.SET_GAMEPLAY_CAM_RELATIVE_PITCH, 0f);
				Game.Player.Character.FreezePosition = false;
				Script.Wait(1500);
				Game.FadeScreenIn(500);
			}
		}
		
		if (plrChar != null & plrChar.IsAlive && plrChar.Position.DistanceTo(FacilitySleepPos) < 2f)
		{
			DisplayHelpText("Press ~INPUT_CONTEXT~ to sleep.");
		}
		if (Game.IsControlJustPressed(2, GTA.Control.Context) && plrChar.Position.DistanceTo(FacilitySleepPos) < 2f)
		{
			Game.Player.Character.FreezePosition = true;
			Game.FadeScreenOut(500);
			Script.Wait(500);
			Function.Call(Hash.ADVANCE_CLOCK_TIME_TO, 6, 0, 0);
			Game.Player.WantedLevel = 0;
			Function.Call(Hash.CLEAR_PED_BLOOD_DAMAGE, Game.Player.Character);
			Function.Call(Hash.CLEAR_PED_WETNESS, Game.Player.Character);
			Game.Player.Character.Position = FacilitySleepRespawnPos;
			Game.Player.Character.Heading = 270f;
			Function.Call(Hash.SET_GAMEPLAY_CAM_RELATIVE_HEADING, 0f);
			Function.Call(Hash.SET_GAMEPLAY_CAM_RELATIVE_PITCH, 0f);
			Game.Player.Character.FreezePosition = false;
			Script.Wait(1500);
			Game.FadeScreenIn(500);
		}
		
		//Server Farm
		if (plrChar != null & plrChar.IsAlive && plrChar.Position.DistanceTo(ServerFarmEntryPos) < 2f)
		{
			Function.Call(Hash.DRAW_MARKER, 1,2477.27f, -402.02f, 93.82f, 0f, 0f, 0f, 0f, 0f, 0f, 0.6f, 0.6f, 0.5f, 240, 200, 80, 150, false, false, 2, false, false, false);
			DisplayHelpText("Press ~INPUT_CONTEXT~ to enter the Government Building Server Farm.");
		}
		if (Game.IsControlJustPressed(2, GTA.Control.Context) && plrChar.Position.DistanceTo(ServerFarmEntryPos) < 2f)
		{
			Game.FadeScreenOut(100);
			Script.Wait(1500);
			Game.Player.Character.Position = ServerFarmSpawnPosIn;
			Game.Player.Character.Heading = 269.39f;
			Function.Call(Hash.SET_GAMEPLAY_CAM_RELATIVE_HEADING, 0f);
			Function.Call(Hash.SET_GAMEPLAY_CAM_RELATIVE_PITCH, 0f);
			Script.Wait(1500);
			Game.FadeScreenIn(500);
		}
		if (plrChar != null & plrChar.IsAlive && plrChar.Position.DistanceTo(ServerFarmExitPos) < 2f)
		{
			Function.Call(Hash.DRAW_MARKER, 1,2154.73f, 2921.04f, -82.08f, 0f, 0f, 0f, 0f, 0f, 0f, 0.6f, 0.6f, 0.5f, 240, 200, 80, 150, false, false, 2, false, false, false);
			DisplayHelpText("Press ~INPUT_CONTEXT~ to use the elevator and exit the Government Building.");
		}
		if (Game.IsControlJustPressed(2, GTA.Control.Context) && plrChar.Position.DistanceTo(ServerFarmExitPos) < 2f)
		{
			Game.Player.Character.FreezePosition = true;
			Game.FadeScreenOut(100);
			Script.Wait(1500);
			Game.Player.Character.Position = ServerFarmSpawnPosOut;
			Game.Player.Character.Heading = 225.53f;
			Function.Call(Hash.SET_GAMEPLAY_CAM_RELATIVE_HEADING, 0f);
			Function.Call(Hash.SET_GAMEPLAY_CAM_RELATIVE_PITCH, 0f);
			Game.Player.Character.FreezePosition = false;
			Script.Wait(1500);
			Game.FadeScreenIn(500);
		}
		
		//Satellite Facility
		if (plrChar != null & plrChar.IsAlive && plrChar.Position.DistanceTo(SatelliteFacilityEntryPos) < 2f)
		{
			Function.Call(Hash.DRAW_MARKER, 1,2049.96f, 2949.55f, 46.74f, 0f, 0f, 0f, 0f, 0f, 0f, 0.6f, 0.6f, 0.5f, 240, 200, 80, 150, false, false, 2, false, false, false);
			DisplayHelpText("Press ~INPUT_CONTEXT~ to enter the IAA Satellite Facility.");
		}
		if (Game.IsControlJustPressed(2, GTA.Control.Context) && plrChar.Position.DistanceTo(SatelliteFacilityEntryPos) < 2f)
		{
			Game.FadeScreenOut(100);
			Script.Wait(1500);
			Game.Player.Character.Position = SatelliteFacilitySpawnPosIn;
			Game.Player.Character.Heading = 87.90f;
			Function.Call(Hash.SET_GAMEPLAY_CAM_RELATIVE_HEADING, 0f);
			Function.Call(Hash.SET_GAMEPLAY_CAM_RELATIVE_PITCH, 0f);
			Script.Wait(1500);
			Game.FadeScreenIn(500);
		}
		if (plrChar != null & plrChar.IsAlive && plrChar.Position.DistanceTo(SatelliteFacilityExitPos) < 2f)
		{
			Function.Call(Hash.DRAW_MARKER, 1,2155.11f, 2920.93f, -62.90f, 0f, 0f, 0f, 0f, 0f, 0f, 0.6f, 0.6f, 0.5f, 240, 200, 80, 150, false, false, 2, false, false, false);
			DisplayHelpText("Press ~INPUT_CONTEXT~ to use the elevator and exit the IAA Satellite Facility.");
		}
		if (Game.IsControlJustPressed(2, GTA.Control.Context) && plrChar.Position.DistanceTo(SatelliteFacilityExitPos) < 2f)
		{
			Game.Player.Character.FreezePosition = true;
			Game.FadeScreenOut(100);
			Script.Wait(1500);
			Game.Player.Character.Position = SatelliteFacilitySpawnPosOut;
			Game.Player.Character.Heading = 247.04f;
			Function.Call(Hash.SET_GAMEPLAY_CAM_RELATIVE_HEADING, 0f);
			Function.Call(Hash.SET_GAMEPLAY_CAM_RELATIVE_PITCH, 0f);
			Game.Player.Character.FreezePosition = false;
			Script.Wait(1500);
			Game.FadeScreenIn(500);
		}
		
		//Submarine
		if (plrChar != null & plrChar.IsAlive && plrChar.Position.DistanceTo(SubEntryPos) < 2f)
		{
			Function.Call(Hash.DRAW_MARKER, 1,-1291.83f, 6859.53f, -106.98f, 0f, 0f, 0f, 0f, 0f, 0f, 0.6f, 0.6f, 0.5f, 240, 200, 80, 150, false, false, 2, false, false, false);
			DisplayHelpText("Press ~INPUT_CONTEXT~ to enter the submarine.");
		}
		if (Game.IsControlJustPressed(2, GTA.Control.Context) && plrChar.Position.DistanceTo(SubEntryPos) < 2f)
		{
			Game.FadeScreenOut(100);
			Script.Wait(1500);
			Game.Player.Character.Position = SubSpawnPosIn;
			Game.Player.Character.Heading = 178.93f;
			Function.Call(Hash.SET_GAMEPLAY_CAM_RELATIVE_HEADING, 0f);
			Function.Call(Hash.SET_GAMEPLAY_CAM_RELATIVE_PITCH, 0f);
			Function.Call(Hash.SHAKE_GAMEPLAY_CAM, "DRUNK_SHAKE", 0.25f);
			Script.Wait(1500);
			Game.FadeScreenIn(500);
		}
		if (plrChar != null & plrChar.IsAlive && plrChar.Position.DistanceTo(SubExitPos) < 2f)
		{
			Function.Call(Hash.DRAW_MARKER, 1,514.33f, 4888.28f, -63.59f, 0f, 0f, 0f, 0f, 0f, 0f, 0.6f, 0.6f, 0.5f, 240, 200, 80, 150, false, false, 2, false, false, false);
			DisplayHelpText("Press ~INPUT_CONTEXT~ to exit the submarine.");
		}
		if (Game.IsControlJustPressed(2, GTA.Control.Context) && plrChar.Position.DistanceTo(SubExitPos) < 2f)
		{
			Game.Player.Character.FreezePosition = true;
			Game.FadeScreenOut(100);
			Script.Wait(1500);
			Function.Call(Hash.STOP_GAMEPLAY_CAM_SHAKING);
			Game.Player.Character.Position = SubSpawnPosOut;
			Game.Player.Character.Heading = 0.00f;
			Function.Call(Hash.SET_GAMEPLAY_CAM_RELATIVE_HEADING, 0f);
			Function.Call(Hash.SET_GAMEPLAY_CAM_RELATIVE_PITCH, 0f);
			Game.Player.Character.FreezePosition = false;
			Script.Wait(1500);
			Game.FadeScreenIn(500);
		}
		
		//Chilliad Facility
		if (plrChar != null & plrChar.IsAlive && plrChar.Position.DistanceTo(ChiliadFacilityEntryPos) < 3f)
		{
			Function.Call(Hash.DRAW_MARKER, 1,-361.57f, 4827.75f, 142.17f, 0f, 0f, 0f, 0f, 0f, 0f, 4.25f, 4.25f, 0.35f, 240, 200, 80, 150, false, false, 2, false, false, false);
			DisplayHelpText("Press ~INPUT_CONTEXT~ to enter the Chilliad Facility.");
		}
		if (Game.IsControlJustPressed(2, GTA.Control.Context) && plrChar.Position.DistanceTo(ChiliadFacilityEntryPos) < 3f)
		{
			if (Game.Player.Character.IsInVehicle())
			{
				Game.FadeScreenOut(100);
				Script.Wait(1500);
				Game.Player.Character.CurrentVehicle.Position = ChiliadFacilitySpawnPosIn;
				Game.Player.Character.CurrentVehicle.Heading = 346.88f;
				Function.Call(Hash.SET_GAMEPLAY_CAM_RELATIVE_HEADING, 0f);
				Function.Call(Hash.SET_GAMEPLAY_CAM_RELATIVE_PITCH, 0f);
				Script.Wait(1500);
				Game.FadeScreenIn(500);
			}
				else
			{
				Game.FadeScreenOut(100);
				Script.Wait(1500);
				Game.Player.Character.Position = ChiliadFacilitySpawnPosIn;
				Game.Player.Character.Heading = 346.88f;
				Function.Call(Hash.SET_GAMEPLAY_CAM_RELATIVE_HEADING, 0f);
				Function.Call(Hash.SET_GAMEPLAY_CAM_RELATIVE_PITCH, 0f);
				Script.Wait(1500);
				Game.FadeScreenIn(500);
			}
		}
		if (plrChar != null & plrChar.IsAlive && plrChar.Position.DistanceTo(ChiliadFacilityExitPos) < 3f)
		{
			Function.Call(Hash.DRAW_MARKER, 1,1256.17f, 4799.07f, -40.27f, 0f, 0f, 0f, 0f, 0f, 0f, 4f, 4f, 0.25f, 240, 200, 80, 150, false, false, 2, false, false, false);
			DisplayHelpText("Press ~INPUT_CONTEXT~ to exit the Chilliad Facility.");
		}
		if (Game.IsControlJustPressed(2, GTA.Control.Context) && plrChar.Position.DistanceTo(ChiliadFacilityExitPos) < 3f)
		{
			if (Game.Player.Character.IsInVehicle())
			{
				Game.FadeScreenOut(100);
				Script.Wait(1500);
				Game.Player.Character.CurrentVehicle.Position = ChiliadFacilitySpawnPosOut;
				Game.Player.Character.CurrentVehicle.Heading = 70.26f;
				Function.Call(Hash.SET_GAMEPLAY_CAM_RELATIVE_HEADING, 0f);
				Function.Call(Hash.SET_GAMEPLAY_CAM_RELATIVE_PITCH, 0f);
				Game.Player.Character.FreezePosition = false;
				Script.Wait(1500);
				Game.FadeScreenIn(500);
			}
				else
			{
				Game.Player.Character.FreezePosition = true;
				Game.FadeScreenOut(100);
				Script.Wait(1500);
				Game.Player.Character.Position = ChiliadFacilitySpawnPosOut;
				Game.Player.Character.Heading = 70.26f;
				Function.Call(Hash.SET_GAMEPLAY_CAM_RELATIVE_HEADING, 0f);
				Function.Call(Hash.SET_GAMEPLAY_CAM_RELATIVE_PITCH, 0f);
				Game.Player.Character.FreezePosition = false;
				Script.Wait(1500);
				Game.FadeScreenIn(500);
			}
		}
	}
}