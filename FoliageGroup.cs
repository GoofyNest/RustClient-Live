public class FoliageGroup : Pool.IPooled // TypeDefIndex: 9872
{	public float LOD; // 0x10
	public bool NeedsRefresh; // 0x14
	public bool Processing; // 0x15
	public bool Preserving; // 0x16
	public ListHashSet<FoliagePlacement> Placements; // 0x18
	public ListHashSet<FoliageRenderer> Renderers; // 0x20
	public List<FoliageRenderer> TempRenderers; // 0x28
	public List<FoliageGridBatch> Batches; // 0x30
	public List<FoliageGridBatch> TempBatches; // 0x38
	public List<MeshInstance> TempInstances; // 0x40
	private FoliageGrid grid; // 0x48
	private FoliageCell cell; // 0x50
	private FoliageKey key; // 0x58
	private Action updateData; // 0x60
	private Action refreshBatches; // 0x68

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

	[IteratorStateMachineAttribute] // RVA: 0xA2FA0 Offset: 0xA23A0 VA: 0x1800A2FA0
	public IEnumerator UpdateDataAsync() { }

	[IteratorStateMachineAttribute] // RVA: 0xA3110 Offset: 0xA2510 VA: 0x1800A3110
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

private sealed class FoliageGroup.<UpdateDataAsync>d__33 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 9873
{	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public FoliageGroup <>4__this; // 0x20
	private IEnumerator <enumerator>5__2; // 0x28

	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }


	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void System.IDisposable.Dispose() { }

	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private object System.Collections.IEnumerator.get_Current() { }

}

private sealed class FoliageGroup.<RefreshBatchesAsync>d__35 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 9874
{	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public FoliageGroup <>4__this; // 0x20
	private IEnumerator <enumerator>5__2; // 0x28

	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }


	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void System.IDisposable.Dispose() { }

	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private object System.Collections.IEnumerator.get_Current() { }

}

