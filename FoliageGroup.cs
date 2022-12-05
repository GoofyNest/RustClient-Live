public class FoliageGroup : Pool.IPooled // TypeDefIndex: 11618
{
	public float LOD;
	public bool NeedsRefresh;
	public bool Processing;
	public bool Preserving;
	public ListHashSet<FoliagePlacement> Placements;
	public ListHashSet<FoliageRenderer> Renderers;
	public List<FoliageRenderer> TempRenderers;
	public List<FoliageGridBatch> Batches;
	public List<FoliageGridBatch> TempBatches;
	public List<MeshInstance> TempInstances;
	private FoliageGrid grid;
	private FoliageCell cell;
	private FoliageKey key;
	private Action updateData;
	private Action refreshBatches;

	public float Size { get; }
	public Vector3 Position { get; }
	public int Count { get; }


	public float get_Size() { }

	public Vector3 get_Position() { }

	public int get_Count() { }

	public void Initialize(FoliageGrid grid, FoliageCell cell, FoliageKey key) { }

	public void EnterPool() { }

	public void LeavePool() { }

	public void Add(FoliageRenderer renderer) { }

	public void Remove(FoliageRenderer renderer) { }

	public void Add(FoliagePlacement placement) { }

	public void Remove(FoliagePlacement placement) { }

	public void Add(MeshInstance instance) { }

	public void UpdateData() { }

	public void CreateBatches() { }

	public void RefreshBatches() { }

	public void ApplyBatches() { }

	public void DisplayBatches() { }

	[IteratorStateMachineAttribute]
	public IEnumerator UpdateDataAsync() { }

	[IteratorStateMachineAttribute]
	public IEnumerator RefreshBatchesAsync() { }

	public void Start() { }

	public void End() { }

	public void Clear() { }

	public void Cancel() { }

	public int MeshCount() { }

	public int BatchedMeshCount() { }

	public int VertexCount() { }

	public FoliageGridBatch CreateBatch() { }

	public void .ctor() { }

}

private sealed class FoliageGroup.<UpdateDataAsync>d__33 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 11619
{
	private int <>1__state;
	private object <>2__current;
	public FoliageGroup <>4__this;
	private IEnumerator <enumerator>5__2;

	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }


	[DebuggerHiddenAttribute]
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute]
	private void System.IDisposable.Dispose() { }

	private bool MoveNext() { }

	[DebuggerHiddenAttribute]
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute]
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute]
	private object System.Collections.IEnumerator.get_Current() { }

}

private sealed class FoliageGroup.<RefreshBatchesAsync>d__35 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 11620
{
	private int <>1__state;
	private object <>2__current;
	public FoliageGroup <>4__this;
	private IEnumerator <enumerator>5__2;

	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }


	[DebuggerHiddenAttribute]
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute]
	private void System.IDisposable.Dispose() { }

	private bool MoveNext() { }

	[DebuggerHiddenAttribute]
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute]
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute]
	private object System.Collections.IEnumerator.get_Current() { }

}

