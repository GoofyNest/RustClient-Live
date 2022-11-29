public abstract class MeshBatch : MonoBehaviour // TypeDefIndex: 13177
{
	[CompilerGeneratedAttribute] 
	private bool <NeedsRefresh>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private int <Count>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private int <BatchedCount>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private int <VertexCount>k__BackingField; 

	public bool NeedsRefresh { get; set; }
	public int Count { get; set; }
	public int BatchedCount { get; set; }
	public int VertexCount { get; set; }
	public abstract int VertexCapacity { get; }
	public abstract int VertexCutoff { get; }
	public int AvailableVertices { get; }


	[CompilerGeneratedAttribute] 
	public bool get_NeedsRefresh() { }

	[CompilerGeneratedAttribute] 
	private void set_NeedsRefresh(bool value) { }

	[CompilerGeneratedAttribute] 
	public int get_Count() { }

	[CompilerGeneratedAttribute] 
	private void set_Count(int value) { }

	[CompilerGeneratedAttribute] 
	public int get_BatchedCount() { }

	[CompilerGeneratedAttribute] 
	private void set_BatchedCount(int value) { }

	[CompilerGeneratedAttribute] 
	public int get_VertexCount() { }

	[CompilerGeneratedAttribute] 
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

