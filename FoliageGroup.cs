public class FoliageGroup : Pool.IPooled // TypeDefIndex: 9872
{	// Fields
	public float LOD; // 0x10
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

	// Properties
	public float Size { get; }
	public Vector3 Position { get; }
	public int Count { get; }

	// Methods

	// RVA: 0x6EC020 Offset: 0x6EB420 VA: 0x1806EC020
	public float get_Size() { }

	// RVA: 0x6EBFF0 Offset: 0x6EB3F0 VA: 0x1806EBFF0
	public Vector3 get_Position() { }

	// RVA: 0x6EBFA0 Offset: 0x6EB3A0 VA: 0x1806EBFA0
	public int get_Count() { }

	// RVA: 0x6EB7B0 Offset: 0x6EABB0 VA: 0x1806EB7B0
	public void Initialize(FoliageGrid grid, FoliageCell cell, FoliageKey key) { }

	// RVA: 0x6EB6B0 Offset: 0x6EAAB0 VA: 0x1806EB6B0 Slot: 4
	public void EnterPool() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 5
	public void LeavePool() { }

	// RVA: 0x6EACD0 Offset: 0x6EA0D0 VA: 0x1806EACD0
	public void Add(FoliageRenderer renderer) { }

	// RVA: 0x6EBA30 Offset: 0x6EAE30 VA: 0x1806EBA30
	public void Remove(FoliageRenderer renderer) { }

	// RVA: 0x6EAD30 Offset: 0x6EA130 VA: 0x1806EAD30
	public void Add(FoliagePlacement placement) { }

	// RVA: 0x6EB9D0 Offset: 0x6EADD0 VA: 0x1806EB9D0
	public void Remove(FoliagePlacement placement) { }

	// RVA: 0x6EAD90 Offset: 0x6EA190 VA: 0x1806EAD90
	public void Add(MeshInstance instance) { }

	// RVA: 0x6EBB90 Offset: 0x6EAF90 VA: 0x1806EBB90
	public void UpdateData() { }

	// RVA: 0x6EB350 Offset: 0x6EA750 VA: 0x1806EB350
	public void CreateBatches() { }

	// RVA: 0x6EB930 Offset: 0x6EAD30 VA: 0x1806EB930
	public void RefreshBatches() { }

	// RVA: 0x6EAE00 Offset: 0x6EA200 VA: 0x1806EAE00
	public void ApplyBatches() { }

	// RVA: 0x6EB500 Offset: 0x6EA900 VA: 0x1806EB500
	public void DisplayBatches() { }

	[IteratorStateMachineAttribute] // RVA: 0xA2FA0 Offset: 0xA23A0 VA: 0x1800A2FA0
	// RVA: 0x6EBB20 Offset: 0x6EAF20 VA: 0x1806EBB20
	public IEnumerator UpdateDataAsync() { }

	[IteratorStateMachineAttribute] // RVA: 0xA3110 Offset: 0xA2510 VA: 0x1800A3110
	// RVA: 0x6EB8C0 Offset: 0x6EACC0 VA: 0x1806EB8C0
	public IEnumerator RefreshBatchesAsync() { }

	// RVA: 0x6EBA90 Offset: 0x6EAE90 VA: 0x1806EBA90
	public void Start() { }

	// RVA: 0x6EB5A0 Offset: 0x6EA9A0 VA: 0x1806EB5A0
	public void End() { }

	// RVA: 0x6EB090 Offset: 0x6EA490 VA: 0x1806EB090
	public void Clear() { }

	// RVA: 0x6EAF50 Offset: 0x6EA350 VA: 0x1806EAF50
	public void Cancel() { }

	// RVA: 0x6EB810 Offset: 0x6EAC10 VA: 0x1806EB810
	public int MeshCount() { }

	// RVA: 0x6EAEA0 Offset: 0x6EA2A0 VA: 0x1806EAEA0
	public int BatchedMeshCount() { }

	// RVA: 0x6EBD90 Offset: 0x6EB190 VA: 0x1806EBD90
	public int VertexCount() { }

	// RVA: 0x6EB1D0 Offset: 0x6EA5D0 VA: 0x1806EB1D0
	public FoliageGridBatch CreateBatch() { }

	// RVA: 0x6EBE40 Offset: 0x6EB240 VA: 0x1806EBE40
	public void .ctor() { }

}

private sealed class FoliageGroup.<UpdateDataAsync>d__33 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 9873
{	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public FoliageGroup <>4__this; // 0x20
	private IEnumerator <enumerator>5__2; // 0x28

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497770 Offset: 0x496B70 VA: 0x180497770
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x701960 Offset: 0x700D60 VA: 0x180701960 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x701AB0 Offset: 0x700EB0 VA: 0x180701AB0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

}

private sealed class FoliageGroup.<RefreshBatchesAsync>d__35 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 9874
{	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public FoliageGroup <>4__this; // 0x20
	private IEnumerator <enumerator>5__2; // 0x28

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497770 Offset: 0x496B70 VA: 0x180497770
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x7008F0 Offset: 0x6FFCF0 VA: 0x1807008F0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x700A40 Offset: 0x6FFE40 VA: 0x180700A40 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

}

