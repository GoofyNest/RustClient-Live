public class RendererGroup : Pool.IPooled // TypeDefIndex: 9920
{	// Fields
	public bool Invalidated; // 0x10
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

	// Properties
	public float Size { get; }
	public Vector3 Position { get; }
	public int Count { get; }

	// Methods

	// RVA: 0x930110 Offset: 0x92F510 VA: 0x180930110
	public float get_Size() { }

	// RVA: 0x9300E0 Offset: 0x92F4E0 VA: 0x1809300E0
	public Vector3 get_Position() { }

	// RVA: 0x930090 Offset: 0x92F490 VA: 0x180930090
	public int get_Count() { }

	// RVA: 0x92F790 Offset: 0x92EB90 VA: 0x18092F790
	public void Initialize(RendererGrid grid, RendererCell cell, RendererKey key) { }

	// RVA: 0x92F6C0 Offset: 0x92EAC0 VA: 0x18092F6C0 Slot: 4
	public void EnterPool() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 5
	public void LeavePool() { }

	// RVA: 0x92EAE0 Offset: 0x92DEE0 VA: 0x18092EAE0
	public void Add(RendererBatch renderer) { }

	// RVA: 0x92FAC0 Offset: 0x92EEC0 VA: 0x18092FAC0
	public void Remove(RendererBatch renderer) { }

	// RVA: 0x92F7F0 Offset: 0x92EBF0 VA: 0x18092F7F0
	public void Invalidate() { }

	// RVA: 0x92EB40 Offset: 0x92DF40 VA: 0x18092EB40
	public void Add(MeshRendererInstance instance) { }

	// RVA: 0x92FC50 Offset: 0x92F050 VA: 0x18092FC50
	public void UpdateData() { }

	// RVA: 0x92F160 Offset: 0x92E560 VA: 0x18092F160
	public void CreateBatches() { }

	// RVA: 0x92FA10 Offset: 0x92EE10 VA: 0x18092FA10
	public void RefreshBatches() { }

	// RVA: 0x92EC10 Offset: 0x92E010 VA: 0x18092EC10
	public void ApplyBatches() { }

	// RVA: 0x92F3C0 Offset: 0x92E7C0 VA: 0x18092F3C0
	public void DisplayBatches() { }

	// RVA: 0x92FBA0 Offset: 0x92EFA0 VA: 0x18092FBA0
	public IEnumerator UpdateDataAsync() { }

	// RVA: 0x92F960 Offset: 0x92ED60 VA: 0x18092F960
	public IEnumerator RefreshBatchesAsync() { }

	// RVA: 0x92FB20 Offset: 0x92EF20 VA: 0x18092FB20
	public void Start() { }

	// RVA: 0x92F470 Offset: 0x92E870 VA: 0x18092F470
	public void End() { }

	// RVA: 0x92EEB0 Offset: 0x92E2B0 VA: 0x18092EEB0
	public void Clear() { }

	// RVA: 0x92ED70 Offset: 0x92E170 VA: 0x18092ED70
	public void Cancel() { }

	// RVA: 0x92F8B0 Offset: 0x92ECB0 VA: 0x18092F8B0
	public int MeshCount() { }

	// RVA: 0x92ECC0 Offset: 0x92E0C0 VA: 0x18092ECC0
	public int BatchedMeshCount() { }

	// RVA: 0x92FEB0 Offset: 0x92F2B0 VA: 0x18092FEB0
	public int VertexCount() { }

	// RVA: 0x92EFF0 Offset: 0x92E3F0 VA: 0x18092EFF0
	public MeshRendererBatch CreateBatch() { }

	// RVA: 0x92FF60 Offset: 0x92F360 VA: 0x18092FF60
	public void .ctor() { }

}

