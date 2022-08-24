public class RendererGroup : Pool.IPooled // TypeDefIndex: 9920
{
	public bool Invalidated; 
	public bool NeedsRefresh; 
	public bool Processing; 
	public bool Preserving; 
	public ListHashSet<RendererBatch> Renderers; 
	public List<RendererBatch> TempRenderers; 
	public List<MeshRendererBatch> Batches; 
	public List<MeshRendererBatch> TempBatches; 
	public List<MeshRendererInstance> TempInstances; 
	private RendererGrid grid; 
	private RendererCell cell; 
	private RendererKey key; 
	private Action updateData; 
	private Action refreshBatches; 

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

