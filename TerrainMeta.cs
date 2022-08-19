public class TerrainMeta : MonoBehaviour // TypeDefIndex: 10424
{	// Fields
	public Terrain terrain; // 0x18
	public TerrainConfig config; // 0x20
	public TerrainMeta.PaintMode paint; // 0x28
	[HideInInspector] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public TerrainMeta.PaintMode currentPaintMode; // 0x2C
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private static TerrainConfig <Config>k__BackingField; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private static Terrain <Terrain>k__BackingField; // 0x8
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private static Transform <Transform>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private static Vector3 <Position>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private static Vector3 <Size>k__BackingField; // 0x24
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private static Vector3 <OneOverSize>k__BackingField; // 0x30
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private static Vector3 <HighestPoint>k__BackingField; // 0x3C
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private static Vector3 <LowestPoint>k__BackingField; // 0x48
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private static float <LootAxisAngle>k__BackingField; // 0x54
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private static float <BiomeAxisAngle>k__BackingField; // 0x58
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private static TerrainData <Data>k__BackingField; // 0x60
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private static TerrainCollider <Collider>k__BackingField; // 0x68
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private static TerrainCollision <Collision>k__BackingField; // 0x70
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private static TerrainPhysics <Physics>k__BackingField; // 0x78
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private static TerrainColors <Colors>k__BackingField; // 0x80
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private static TerrainQuality <Quality>k__BackingField; // 0x88
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private static TerrainPath <Path>k__BackingField; // 0x90
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private static TerrainBiomeMap <BiomeMap>k__BackingField; // 0x98
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private static TerrainAlphaMap <AlphaMap>k__BackingField; // 0xA0
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private static TerrainBlendMap <BlendMap>k__BackingField; // 0xA8
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private static TerrainHeightMap <HeightMap>k__BackingField; // 0xB0
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private static TerrainSplatMap <SplatMap>k__BackingField; // 0xB8
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private static TerrainTopologyMap <TopologyMap>k__BackingField; // 0xC0
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private static TerrainWaterMap <WaterMap>k__BackingField; // 0xC8
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private static TerrainDistanceMap <DistanceMap>k__BackingField; // 0xD0
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private static TerrainPlacementMap <PlacementMap>k__BackingField; // 0xD8
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private static TerrainTexturing <Texturing>k__BackingField; // 0xE0

	// Properties
	public static TerrainConfig Config { get; set; }
	public static Terrain Terrain { get; set; }
	public static Transform Transform { get; set; }
	public static Vector3 Position { get; set; }
	public static Vector3 Size { get; set; }
	public static Vector3 Center { get; }
	public static Vector3 OneOverSize { get; set; }
	public static Vector3 HighestPoint { get; set; }
	public static Vector3 LowestPoint { get; set; }
	public static float LootAxisAngle { get; set; }
	public static float BiomeAxisAngle { get; set; }
	public static TerrainData Data { get; set; }
	public static TerrainCollider Collider { get; set; }
	public static TerrainCollision Collision { get; set; }
	public static TerrainPhysics Physics { get; set; }
	public static TerrainColors Colors { get; set; }
	public static TerrainQuality Quality { get; set; }
	public static TerrainPath Path { get; set; }
	public static TerrainBiomeMap BiomeMap { get; set; }
	public static TerrainAlphaMap AlphaMap { get; set; }
	public static TerrainBlendMap BlendMap { get; set; }
	public static TerrainHeightMap HeightMap { get; set; }
	public static TerrainSplatMap SplatMap { get; set; }
	public static TerrainTopologyMap TopologyMap { get; set; }
	public static TerrainWaterMap WaterMap { get; set; }
	public static TerrainDistanceMap DistanceMap { get; set; }
	public static TerrainPlacementMap PlacementMap { get; set; }
	public static TerrainTexturing Texturing { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1146AD0 Offset: 0x1145ED0 VA: 0x181146AD0
	public static TerrainConfig get_Config() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1147250 Offset: 0x1146650 VA: 0x181147250
	private static void set_Config(TerrainConfig value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1146EE0 Offset: 0x11462E0 VA: 0x181146EE0
	public static Terrain get_Terrain() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1147700 Offset: 0x1146B00 VA: 0x181147700
	private static void set_Terrain(Terrain value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1146FA0 Offset: 0x11463A0 VA: 0x181146FA0
	public static Transform get_Transform() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x11477F0 Offset: 0x1146BF0 VA: 0x1811477F0
	private static void set_Transform(Transform value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1146DC0 Offset: 0x11461C0 VA: 0x181146DC0
	public static Vector3 get_Position() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x11475C0 Offset: 0x11469C0 VA: 0x1811475C0
	private static void set_Position(Vector3 value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1146E50 Offset: 0x1146250 VA: 0x181146E50
	public static Vector3 get_Size() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1147660 Offset: 0x1146A60 VA: 0x181147660
	private static void set_Size(Vector3 value) { }

	// RVA: 0x11468D0 Offset: 0x1145CD0 VA: 0x1811468D0
	public static Vector3 get_Center() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1146CB0 Offset: 0x11460B0 VA: 0x181146CB0
	public static Vector3 get_OneOverSize() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1147480 Offset: 0x1146880 VA: 0x181147480
	private static void set_OneOverSize(Vector3 value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1146BD0 Offset: 0x1145FD0 VA: 0x181146BD0
	public static Vector3 get_HighestPoint() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1147390 Offset: 0x1146790 VA: 0x181147390
	public static void set_HighestPoint(Vector3 value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1146C60 Offset: 0x1146060 VA: 0x181146C60
	public static Vector3 get_LowestPoint() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1147430 Offset: 0x1146830 VA: 0x181147430
	public static void set_LowestPoint(Vector3 value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1146C20 Offset: 0x1146020 VA: 0x181146C20
	public static float get_LootAxisAngle() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x11473E0 Offset: 0x11467E0 VA: 0x1811473E0
	private static void set_LootAxisAngle(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1146810 Offset: 0x1145C10 VA: 0x181146810
	public static float get_BiomeAxisAngle() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1147070 Offset: 0x1146470 VA: 0x181147070
	private static void set_BiomeAxisAngle(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1146B10 Offset: 0x1145F10 VA: 0x181146B10
	public static TerrainData get_Data() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x11472A0 Offset: 0x11466A0 VA: 0x1811472A0
	private static void set_Data(TerrainData value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1146A10 Offset: 0x1145E10 VA: 0x181146A10
	public static TerrainCollider get_Collider() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1147160 Offset: 0x1146560 VA: 0x181147160
	private static void set_Collider(TerrainCollider value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1146A50 Offset: 0x1145E50 VA: 0x181146A50
	public static TerrainCollision get_Collision() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x11471B0 Offset: 0x11465B0 VA: 0x1811471B0
	private static void set_Collision(TerrainCollision value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1146D40 Offset: 0x1146140 VA: 0x181146D40
	public static TerrainPhysics get_Physics() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1147520 Offset: 0x1146920 VA: 0x181147520
	private static void set_Physics(TerrainPhysics value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1146A90 Offset: 0x1145E90 VA: 0x181146A90
	public static TerrainColors get_Colors() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1147200 Offset: 0x1146600 VA: 0x181147200
	private static void set_Colors(TerrainColors value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1146E10 Offset: 0x1146210 VA: 0x181146E10
	public static TerrainQuality get_Quality() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1147610 Offset: 0x1146A10 VA: 0x181147610
	private static void set_Quality(TerrainQuality value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1146D00 Offset: 0x1146100 VA: 0x181146D00
	public static TerrainPath get_Path() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x11474D0 Offset: 0x11468D0 VA: 0x1811474D0
	private static void set_Path(TerrainPath value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1146850 Offset: 0x1145C50 VA: 0x181146850
	public static TerrainBiomeMap get_BiomeMap() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x11470C0 Offset: 0x11464C0 VA: 0x1811470C0
	private static void set_BiomeMap(TerrainBiomeMap value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x11467D0 Offset: 0x1145BD0 VA: 0x1811467D0
	public static TerrainAlphaMap get_AlphaMap() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1147020 Offset: 0x1146420 VA: 0x181147020
	private static void set_AlphaMap(TerrainAlphaMap value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1146890 Offset: 0x1145C90 VA: 0x181146890
	public static TerrainBlendMap get_BlendMap() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1147110 Offset: 0x1146510 VA: 0x181147110
	private static void set_BlendMap(TerrainBlendMap value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1146B90 Offset: 0x1145F90 VA: 0x181146B90
	public static TerrainHeightMap get_HeightMap() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1147340 Offset: 0x1146740 VA: 0x181147340
	private static void set_HeightMap(TerrainHeightMap value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1146EA0 Offset: 0x11462A0 VA: 0x181146EA0
	public static TerrainSplatMap get_SplatMap() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x11476B0 Offset: 0x1146AB0 VA: 0x1811476B0
	private static void set_SplatMap(TerrainSplatMap value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1146F60 Offset: 0x1146360 VA: 0x181146F60
	public static TerrainTopologyMap get_TopologyMap() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x11477A0 Offset: 0x1146BA0 VA: 0x1811477A0
	private static void set_TopologyMap(TerrainTopologyMap value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1146FE0 Offset: 0x11463E0 VA: 0x181146FE0
	public static TerrainWaterMap get_WaterMap() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1147840 Offset: 0x1146C40 VA: 0x181147840
	private static void set_WaterMap(TerrainWaterMap value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1146B50 Offset: 0x1145F50 VA: 0x181146B50
	public static TerrainDistanceMap get_DistanceMap() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x11472F0 Offset: 0x11466F0 VA: 0x1811472F0
	private static void set_DistanceMap(TerrainDistanceMap value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1146D80 Offset: 0x1146180 VA: 0x181146D80
	public static TerrainPlacementMap get_PlacementMap() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1147570 Offset: 0x1146970 VA: 0x181147570
	private static void set_PlacementMap(TerrainPlacementMap value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1146F20 Offset: 0x1146320 VA: 0x181146F20
	public static TerrainTexturing get_Texturing() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1147750 Offset: 0x1146B50 VA: 0x181147750
	private static void set_Texturing(TerrainTexturing value) { }

	// RVA: 0x1145EE0 Offset: 0x11452E0 VA: 0x181145EE0
	public static bool OutOfBounds(Vector3 worldPos) { }

	// RVA: 0x11460A0 Offset: 0x11454A0 VA: 0x1811460A0
	public static bool OutOfMargin(Vector3 worldPos) { }

	// RVA: 0x1146400 Offset: 0x1145800 VA: 0x181146400
	public static Vector3 RandomPointOffshore() { }

	// RVA: 0x1145CE0 Offset: 0x11450E0 VA: 0x181145CE0
	public static Vector3 Normalize(Vector3 worldPos) { }

	// RVA: 0x1145B30 Offset: 0x1144F30 VA: 0x181145B30
	public static float NormalizeX(float x) { }

	// RVA: 0x1145BC0 Offset: 0x1144FC0 VA: 0x181145BC0
	public static float NormalizeY(float y) { }

	// RVA: 0x1145C50 Offset: 0x1145050 VA: 0x181145C50
	public static float NormalizeZ(float z) { }

	// RVA: 0x1144B30 Offset: 0x1143F30 VA: 0x181144B30
	public static Vector3 Denormalize(Vector3 normPos) { }

	// RVA: 0x1144980 Offset: 0x1143D80 VA: 0x181144980
	public static float DenormalizeX(float normX) { }

	// RVA: 0x1144A10 Offset: 0x1143E10 VA: 0x181144A10
	public static float DenormalizeY(float normY) { }

	// RVA: 0x1144AA0 Offset: 0x1143EA0 VA: 0x181144AA0
	public static float DenormalizeZ(float normZ) { }

	// RVA: 0x11437A0 Offset: 0x1142BA0 VA: 0x1811437A0
	protected void Awake() { }

	// RVA: 0x1144EF0 Offset: 0x11442F0 VA: 0x181144EF0
	public void Init(Terrain terrainOverride, TerrainConfig configOverride) { }

	// RVA: 0x1144D20 Offset: 0x1144120 VA: 0x181144D20
	public static void InitNoTerrain(bool createPath = False) { }

	// RVA: 0x1146720 Offset: 0x1145B20 VA: 0x181146720
	public void SetupComponents() { }

	// RVA: 0x1146360 Offset: 0x1145760 VA: 0x181146360
	public void PostSetupComponents() { }

	// RVA: 0x11437F0 Offset: 0x1142BF0 VA: 0x1811437F0
	public void BindShaderProperties() { }

	// RVA: 0x2F91F0 Offset: 0x2F85F0 VA: 0x1802F91F0
	public void .ctor() { }

}

public enum TerrainMeta.PaintMode // TypeDefIndex: 10425
{	// Fields
	public int value__; // 0x0
	public const TerrainMeta.PaintMode None = 0;
	public const TerrainMeta.PaintMode Splats = 1;
	public const TerrainMeta.PaintMode Biomes = 2;
	public const TerrainMeta.PaintMode Alpha = 3;
	public const TerrainMeta.PaintMode Blend = 4;
	public const TerrainMeta.PaintMode Field = 5;
	public const TerrainMeta.PaintMode Cliff = 6;
	public const TerrainMeta.PaintMode Summit = 7;
	public const TerrainMeta.PaintMode Beachside = 8;
	public const TerrainMeta.PaintMode Beach = 9;
	public const TerrainMeta.PaintMode Forest = 10;
	public const TerrainMeta.PaintMode Forestside = 11;
	public const TerrainMeta.PaintMode Ocean = 12;
	public const TerrainMeta.PaintMode Oceanside = 13;
	public const TerrainMeta.PaintMode Decor = 14;
	public const TerrainMeta.PaintMode Monument = 15;
	public const TerrainMeta.PaintMode Road = 16;
	public const TerrainMeta.PaintMode Roadside = 17;
	public const TerrainMeta.PaintMode Bridge = 18;
	public const TerrainMeta.PaintMode River = 19;
	public const TerrainMeta.PaintMode Riverside = 20;
	public const TerrainMeta.PaintMode Lake = 21;
	public const TerrainMeta.PaintMode Lakeside = 22;
	public const TerrainMeta.PaintMode Offshore = 23;
	public const TerrainMeta.PaintMode Rail = 24;
	public const TerrainMeta.PaintMode Railside = 25;
	public const TerrainMeta.PaintMode Building = 26;
	public const TerrainMeta.PaintMode Cliffside = 27;
	public const TerrainMeta.PaintMode Mountain = 28;
	public const TerrainMeta.PaintMode Clutter = 29;
	public const TerrainMeta.PaintMode Alt = 30;
	public const TerrainMeta.PaintMode Tier0 = 31;
	public const TerrainMeta.PaintMode Tier1 = 32;
	public const TerrainMeta.PaintMode Tier2 = 33;
	public const TerrainMeta.PaintMode Mainland = 34;
	public const TerrainMeta.PaintMode Hilltop = 35;

}

