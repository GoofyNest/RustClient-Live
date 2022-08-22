public abstract class MeshBatch : MonoBehaviour // TypeDefIndex: 11384
{	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private bool <NeedsRefresh>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private int <Count>k__BackingField; // 0x1C
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private int <BatchedCount>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private int <VertexCount>k__BackingField; // 0x24

	public bool NeedsRefresh { get; set; }
	public int Count { get; set; }
	public int BatchedCount { get; set; }
	public int VertexCount { get; set; }
	public abstract int VertexCapacity { get; }
	public abstract int VertexCutoff { get; }
	public int AvailableVertices { get; }


	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public bool get_NeedsRefresh() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void set_NeedsRefresh(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public int get_Count() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void set_Count(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public int get_BatchedCount() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void set_BatchedCount(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public int get_VertexCount() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void set_VertexCount(int value) { }

	protected abstract void AllocMemory();

	protected abstract void FreeMemory();

	protected abstract void RefreshMesh();

	protected abstract void ApplyMesh();

	protected abstract void ToggleMesh(bool state);

	protected abstract void OnPooled();

	public abstract int get_VertexCapacity();

	public abstract int get_VertexCutoff();

	public int get_AvailableVertices() { }

	public void Alloc() { }

	public void Free() { }

	public void Refresh() { }

	public void Apply() { }

	public void Display() { }

	public void Invalidate() { }

	protected void AddVertices(int vertices) { }

	protected void OnEnable() { }

	protected void OnDisable() { }

	protected void .ctor() { }

}

