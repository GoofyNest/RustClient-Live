public class RendererGroup : Pool.IPooled // TypeDefIndex: 9920
{	public bool Invalidated; // 0x10
	public bool NeedsRefresh; // 0x11
	public bool Processing; // 0x12
	public bool Preserving; // 0x13
	public ListHashSet<RendererBatch> Renderers; // 0x18
	public List<RendererBatch> TempRenderers; // 0x20
	public List<MeshRendererBatch> Batches; // 0x28
	public List<MeshRendererBatch> TempBatches; // 0x30
	public List<MeshRendererInstance> TempInstances; // 0x38
	private RendererGrid grid; // 0x40
	private RendererCell cell; // 0x48
	private RendererKey key; // 0x50
	private Action updateData; // 0x60
	private Action refreshBatches; // 0x68

	public float Size { get; }
	public Vector3 Position { get; }
	public int Count { get; }


	public float get_Size() { }

	public Vector3 get_Position() { }

	public int get_Count() { }

	public void Initialize(RendererGrid grid, RendererCell cell, RendererKey key) { }

	public void EnterPool() { }

	public void LeavePool() { }

	public void Add(RendererBatch renderer) { }

	public void Remove(RendererBatch renderer) { }

	public void Invalidate() { }

	public void Add(MeshRendererInstance instance) { }

	public void UpdateData() { }

	public void CreateBatches() { }

	public void RefreshBatches() { }

	public void ApplyBatches() { }

	public void DisplayBatches() { }

	public IEnumerator UpdateDataAsync() { }

	public IEnumerator RefreshBatchesAsync() { }

	public void Start() { }

	public void End() { }

	public void Clear() { }

	public void Cancel() { }

	public int MeshCount() { }

	public int BatchedMeshCount() { }

	public int VertexCount() { }

	public MeshRendererBatch CreateBatch() { }

	public void .ctor() { }

}

