public class FoliageRenderer : MonoBehaviour, IClientComponent // TypeDefIndex: 9877
{	// Fields
	public Material material; // 0x18
	public Mesh LOD0; // 0x20
	public Mesh LOD1; // 0x28
	private FoliageGroup batchGroup; // 0x30
	private MeshInstance batchInstance; // 0x38

	// Methods

	// RVA: 0x6ECF30 Offset: 0x6EC330 VA: 0x1806ECF30
	protected void OnEnable() { }

	// RVA: 0x6ECEC0 Offset: 0x6EC2C0 VA: 0x1806ECEC0
	protected void OnDisable() { }

	// RVA: 0x6ECBB0 Offset: 0x6EBFB0 VA: 0x1806ECBB0
	public void Add() { }

	// RVA: 0x6ECF60 Offset: 0x6EC360 VA: 0x1806ECF60
	public void Remove() { }

	// RVA: 0x6ECF40 Offset: 0x6EC340 VA: 0x1806ECF40
	public void Refresh() { }

	// RVA: 0x6ECB00 Offset: 0x6EBF00 VA: 0x1806ECB00
	public void AddBatch(FoliageGroup batchGroup, float lod, uint seed) { }

	// RVA: 0x2F91F0 Offset: 0x2F85F0 VA: 0x1802F91F0
	public void .ctor() { }

}

