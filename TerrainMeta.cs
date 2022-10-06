public class TerrainMeta : MonoBehaviour // TypeDefIndex: 12141
{
	public Terrain terrain; 
	public TerrainConfig config; 
	public TerrainMeta.PaintMode paint; 
	[HideInInspector] 
	public TerrainMeta.PaintMode currentPaintMode; 
	[CompilerGeneratedAttribute] 
	private static TerrainConfig <Config>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private static Terrain <Terrain>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private static Transform <Transform>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private static Vector3 <Position>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private static Vector3 <Size>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private static Vector3 <OneOverSize>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private static Vector3 <HighestPoint>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private static Vector3 <LowestPoint>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private static float <LootAxisAngle>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private static float <BiomeAxisAngle>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private static TerrainData <Data>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private static TerrainCollider <Collider>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private static TerrainCollision <Collision>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private static TerrainPhysics <Physics>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private static TerrainColors <Colors>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private static TerrainQuality <Quality>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private static TerrainPath <Path>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private static TerrainBiomeMap <BiomeMap>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private static TerrainAlphaMap <AlphaMap>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private static TerrainBlendMap <BlendMap>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private static TerrainHeightMap <HeightMap>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private static TerrainSplatMap <SplatMap>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private static TerrainTopologyMap <TopologyMap>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private static TerrainWaterMap <WaterMap>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private static TerrainDistanceMap <DistanceMap>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private static TerrainPlacementMap <PlacementMap>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private static TerrainTexturing <Texturing>k__BackingField; 

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


	[CompilerGeneratedAttribute] 
	public static TerrainConfig get_Config() { }

	[CompilerGeneratedAttribute] 
	private static void set_Config(TerrainConfig value) { }

	[CompilerGeneratedAttribute] 
	public static Terrain get_Terrain() { }

	[CompilerGeneratedAttribute] 
	private static void set_Terrain(Terrain value) { }

	[CompilerGeneratedAttribute] 
	public static Transform get_Transform() { }

	[CompilerGeneratedAttribute] 
	private static void set_Transform(Transform value) { }

	[CompilerGeneratedAttribute] 
	public static Vector3 get_Position() { }

	[CompilerGeneratedAttribute] 
	private static void set_Position(Vector3 value) { }

	[CompilerGeneratedAttribute] 
	public static Vector3 get_Size() { }

	[CompilerGeneratedAttribute] 
	private static void set_Size(Vector3 value) { }

	public static Vector3 get_Center() { }

	[CompilerGeneratedAttribute] 
	public static Vector3 get_OneOverSize() { }

	[CompilerGeneratedAttribute] 
	private static void set_OneOverSize(Vector3 value) { }

	[CompilerGeneratedAttribute] 
	public static Vector3 get_HighestPoint() { }

	[CompilerGeneratedAttribute] 
	public static void set_HighestPoint(Vector3 value) { }

	[CompilerGeneratedAttribute] 
	public static Vector3 get_LowestPoint() { }

	[CompilerGeneratedAttribute] 
	public static void set_LowestPoint(Vector3 value) { }

	[CompilerGeneratedAttribute] 
	public static float get_LootAxisAngle() { }

	[CompilerGeneratedAttribute] 
	private static void set_LootAxisAngle(float value) { }

	[CompilerGeneratedAttribute] 
	public static float get_BiomeAxisAngle() { }

	[CompilerGeneratedAttribute] 
	private static void set_BiomeAxisAngle(float value) { }

	[CompilerGeneratedAttribute] 
	public static TerrainData get_Data() { }

	[CompilerGeneratedAttribute] 
	private static void set_Data(TerrainData value) { }

	[CompilerGeneratedAttribute] 
	public static TerrainCollider get_Collider() { }

	[CompilerGeneratedAttribute] 
	private static void set_Collider(TerrainCollider value) { }

	[CompilerGeneratedAttribute] 
	public static TerrainCollision get_Collision() { }

	[CompilerGeneratedAttribute] 
	private static void set_Collision(TerrainCollision value) { }

	[CompilerGeneratedAttribute] 
	public static TerrainPhysics get_Physics() { }

	[CompilerGeneratedAttribute] 
	private static void set_Physics(TerrainPhysics value) { }

	[CompilerGeneratedAttribute] 
	public static TerrainColors get_Colors() { }

	[CompilerGeneratedAttribute] 
	private static void set_Colors(TerrainColors value) { }

	[CompilerGeneratedAttribute] 
	public static TerrainQuality get_Quality() { }

	[CompilerGeneratedAttribute] 
	private static void set_Quality(TerrainQuality value) { }

	[CompilerGeneratedAttribute] 
	public static TerrainPath get_Path() { }

	[CompilerGeneratedAttribute] 
	private static void set_Path(TerrainPath value) { }

	[CompilerGeneratedAttribute] 
	public static TerrainBiomeMap get_BiomeMap() { }

	[CompilerGeneratedAttribute] 
	private static void set_BiomeMap(TerrainBiomeMap value) { }

	[CompilerGeneratedAttribute] 
	public static TerrainAlphaMap get_AlphaMap() { }

	[CompilerGeneratedAttribute] 
	private static void set_AlphaMap(TerrainAlphaMap value) { }

	[CompilerGeneratedAttribute] 
	public static TerrainBlendMap get_BlendMap() { }

	[CompilerGeneratedAttribute] 
	private static void set_BlendMap(TerrainBlendMap value) { }

	[CompilerGeneratedAttribute] 
	public static TerrainHeightMap get_HeightMap() { }

	[CompilerGeneratedAttribute] 
	private static void set_HeightMap(TerrainHeightMap value) { }

	[CompilerGeneratedAttribute] 
	public static TerrainSplatMap get_SplatMap() { }

	[CompilerGeneratedAttribute] 
	private static void set_SplatMap(TerrainSplatMap value) { }

	[CompilerGeneratedAttribute] 
	public static TerrainTopologyMap get_TopologyMap() { }

	[CompilerGeneratedAttribute] 
	private static void set_TopologyMap(TerrainTopologyMap value) { }

	[CompilerGeneratedAttribute] 
	public static TerrainWaterMap get_WaterMap() { }

	[CompilerGeneratedAttribute] 
	private static void set_WaterMap(TerrainWaterMap value) { }

	[CompilerGeneratedAttribute] 
	public static TerrainDistanceMap get_DistanceMap() { }

	[CompilerGeneratedAttribute] 
	private static void set_DistanceMap(TerrainDistanceMap value) { }

	[CompilerGeneratedAttribute] 
	public static TerrainPlacementMap get_PlacementMap() { }

	[CompilerGeneratedAttribute] 
	private static void set_PlacementMap(TerrainPlacementMap value) { }

	[CompilerGeneratedAttribute] 
	public static TerrainTexturing get_Texturing() { }

	[CompilerGeneratedAttribute] 
	private static void set_Texturing(TerrainTexturing value) { }

	public static bool OutOfBounds(Vector3 worldPos) { }

	public static bool OutOfMargin(Vector3 worldPos) { }

	public static Vector3 RandomPointOffshore() { }

	public static Vector3 Normalize(Vector3 worldPos) { }

	public static float NormalizeX(float x) { }

	public static float NormalizeY(float y) { }

	public static float NormalizeZ(float z) { }

	public static Vector3 Denormalize(Vector3 normPos) { }

	public static float DenormalizeX(float normX) { }

	public static float DenormalizeY(float normY) { }

	public static float DenormalizeZ(float normZ) { }

	protected void Awake() { }

	public void Init(Terrain terrainOverride, TerrainConfig configOverride) { }

	public static void InitNoTerrain(bool createPath = False) { }

	public void SetupComponents() { }

	public void PostSetupComponents() { }

	public void BindShaderProperties() { }

	public void .ctor() { }

}

public enum TerrainMeta.PaintMode // TypeDefIndex: 12142
{
	public int value__; 
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

