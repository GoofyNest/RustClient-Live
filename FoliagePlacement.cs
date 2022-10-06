public class FoliagePlacement : ScriptableObject // TypeDefIndex: 11588
{
	[HeaderAttribute] 
	public float Density; 
	[HeaderAttribute] 
	public SpawnFilter Filter; 
	[FormerlySerializedAsAttribute] 
	public float FilterCutoff; 
	public float FilterFade; 
	[FormerlySerializedAsAttribute] 
	public float FilterScaling; 
	[HeaderAttribute] 
	public float RandomScaling; 
	[HeaderAttribute] 
	[MinMaxAttribute] 
	public MinMax Range; 
	public float RangeFade; 
	[HeaderAttribute] 
	[RangeAttribute] 
	public float DistanceDensity; 
	[RangeAttribute] 
	public float DistanceScaling; 
	[HeaderAttribute] 
	public Material material; 
	[FormerlySerializedAsAttribute] 
	public Mesh mesh0; 
	[FormerlySerializedAsAttribute] 
	public Mesh mesh1; 
	[FormerlySerializedAsAttribute] 
	public Mesh mesh2; 
	public const int lods = 5;
	public const int octaves = 1;
	public const float frequency = 0,05;
	public const float amplitude = 0,5;
	public const float offset = 0,5;


	public void Init() { }

	public bool CheckBatch(Vector3 pivot, float size) { }

	public void AddBatch(FoliageGroup batchGroup, float lod, uint seed) { }

	public void .ctor() { }

}

