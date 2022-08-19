public abstract class MeshBatch : MonoBehaviour // TypeDefIndex: 11384
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private bool <NeedsRefresh>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private int <Count>k__BackingField; // 0x1C
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private int <BatchedCount>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private int <VertexCount>k__BackingField; // 0x24

	// Properties
	public bool NeedsRefresh { get; set; }
	public int Count { get; set; }
	public int BatchedCount { get; set; }
	public int VertexCount { get; set; }
	public abstract int VertexCapacity { get; }
	public abstract int VertexCutoff { get; }
	public int AvailableVertices { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x95B2D0 Offset: 0x95A6D0 VA: 0x18095B2D0
	public bool get_NeedsRefresh() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x95B2F0 Offset: 0x95A6F0 VA: 0x18095B2F0
	private void set_NeedsRefresh(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4BE1F0 Offset: 0x4BD5F0 VA: 0x1804BE1F0
	public int get_Count() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x95B2E0 Offset: 0x95A6E0 VA: 0x18095B2E0
	private void set_Count(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4D0170 Offset: 0x4CF570 VA: 0x1804D0170
	public int get_BatchedCount() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x69CC40 Offset: 0x69C040 VA: 0x18069CC40
	private void set_BatchedCount(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x7E8DA0 Offset: 0x7E81A0 VA: 0x1807E8DA0
	public int get_VertexCount() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x7E8E00 Offset: 0x7E8200 VA: 0x1807E8E00
	private void set_VertexCount(int value) { }

	// RVA: -1 Offset: -1 Slot: 4
	protected abstract void AllocMemory();

	// RVA: -1 Offset: -1 Slot: 5
	protected abstract void FreeMemory();

	// RVA: -1 Offset: -1 Slot: 6
	protected abstract void RefreshMesh();

	// RVA: -1 Offset: -1 Slot: 7
	protected abstract void ApplyMesh();

	// RVA: -1 Offset: -1 Slot: 8
	protected abstract void ToggleMesh(bool state);

	// RVA: -1 Offset: -1 Slot: 9
	protected abstract void OnPooled();

	// RVA: -1 Offset: -1 Slot: 10
	public abstract int get_VertexCapacity();

	// RVA: -1 Offset: -1 Slot: 11
	public abstract int get_VertexCutoff();

	// RVA: 0x95B230 Offset: 0x95A630 VA: 0x18095B230
	public int get_AvailableVertices() { }

	// RVA: 0x4D0950 Offset: 0x4CFD50 VA: 0x1804D0950
	public void Alloc() { }

	// RVA: 0x95B120 Offset: 0x95A520 VA: 0x18095B120
	public void Free() { }

	// RVA: 0x95B210 Offset: 0x95A610 VA: 0x18095B210
	public void Refresh() { }

	// RVA: 0x95B0D0 Offset: 0x95A4D0 VA: 0x18095B0D0
	public void Apply() { }

	// RVA: 0x95B0F0 Offset: 0x95A4F0 VA: 0x18095B0F0
	public void Display() { }

	// RVA: 0x95B140 Offset: 0x95A540 VA: 0x18095B140
	public void Invalidate() { }

	// RVA: 0x95B0C0 Offset: 0x95A4C0 VA: 0x18095B0C0
	protected void AddVertices(int vertices) { }

	// RVA: 0x95B200 Offset: 0x95A600 VA: 0x18095B200
	protected void OnEnable() { }

	// RVA: 0x95B170 Offset: 0x95A570 VA: 0x18095B170
	protected void OnDisable() { }

	// RVA: 0x2F91F0 Offset: 0x2F85F0 VA: 0x1802F91F0
	protected void .ctor() { }

}

