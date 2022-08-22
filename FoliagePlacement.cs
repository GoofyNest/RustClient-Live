public class FoliagePlacement : ScriptableObject // TypeDefIndex: 9876
{	[HeaderAttribute] // RVA: 0xA39F0 Offset: 0xA2DF0 VA: 0x1800A39F0
	public float Density; // 0x18
	[HeaderAttribute] // RVA: 0xA3A80 Offset: 0xA2E80 VA: 0x1800A3A80
	public SpawnFilter Filter; // 0x20
	[FormerlySerializedAsAttribute] // RVA: 0xA3B90 Offset: 0xA2F90 VA: 0x1800A3B90
	public float FilterCutoff; // 0x28
	public float FilterFade; // 0x2C
	[FormerlySerializedAsAttribute] // RVA: 0xA3CA0 Offset: 0xA30A0 VA: 0x1800A3CA0
	public float FilterScaling; // 0x30
	[HeaderAttribute] // RVA: 0xA3E10 Offset: 0xA3210 VA: 0x1800A3E10
	public float RandomScaling; // 0x34
	[HeaderAttribute] // RVA: 0xA3F30 Offset: 0xA3330 VA: 0x1800A3F30
	[MinMaxAttribute] // RVA: 0xA3F30 Offset: 0xA3330 VA: 0x1800A3F30
	public MinMax Range; // 0x38
	public float RangeFade; // 0x40
	[HeaderAttribute] // RVA: 0xA40B0 Offset: 0xA34B0 VA: 0x1800A40B0
	[RangeAttribute] // RVA: 0xA40B0 Offset: 0xA34B0 VA: 0x1800A40B0
	public float DistanceDensity; // 0x44
	[RangeAttribute] // RVA: 0xA42D0 Offset: 0xA36D0 VA: 0x1800A42D0
	public float DistanceScaling; // 0x48
	[HeaderAttribute] // RVA: 0xA4440 Offset: 0xA3840 VA: 0x1800A4440
	public Material material; // 0x50
	[FormerlySerializedAsAttribute] // RVA: 0xA4510 Offset: 0xA3910 VA: 0x1800A4510
	public Mesh mesh0; // 0x58
	[FormerlySerializedAsAttribute] // RVA: 0xA4510 Offset: 0xA3910 VA: 0x1800A4510
	public Mesh mesh1; // 0x60
	[FormerlySerializedAsAttribute] // RVA: 0xA4510 Offset: 0xA3910 VA: 0x1800A4510
	public Mesh mesh2; // 0x68
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

