public class RendererCell : Pool.IPooled // TypeDefIndex: 9916
{	// Fields
	public Vector3 position; // 0x10
	public RendererGrid grid; // 0x20
	public bool interrupt; // 0x28
	public bool isInPool; // 0x29
	private ListDictionary<RendererKey, RendererGroup> batches; // 0x30

	// Properties
	public int Count { get; }

	// Methods

	// RVA: 0x92DC90 Offset: 0x92D090 VA: 0x18092DC90
	public int get_Count() { }

	// RVA: 0x92D640 Offset: 0x92CA40 VA: 0x18092D640
	public void Initialize(RendererGrid grid, Vector3 position) { }

	// RVA: 0x92D820 Offset: 0x92CC20 VA: 0x18092D820
	public bool NeedsRefresh() { }

	// RVA: 0x92D700 Offset: 0x92CB00 VA: 0x18092D700
	public int MeshCount() { }

	// RVA: 0x92D100 Offset: 0x92C500 VA: 0x18092D100
	public int BatchedMeshCount() { }

	// RVA: 0x92DB00 Offset: 0x92CF00 VA: 0x18092DB00
	public int VertexCount() { }

	// RVA: 0x92D920 Offset: 0x92CD20 VA: 0x18092D920
	public void Refresh() { }

	[IteratorStateMachineAttribute] // RVA: 0xA7BC0 Offset: 0xA6FC0 VA: 0x1800A7BC0
	// RVA: 0x92D8B0 Offset: 0x92CCB0 VA: 0x18092D8B0
	public IEnumerator RefreshAsync() { }

	// RVA: 0x92D480 Offset: 0x92C880 VA: 0x18092D480
	public RendererGroup FindBatchGroup(RendererBatch renderer) { }

	// RVA: 0x92D220 Offset: 0x92C620 VA: 0x18092D220
	private RendererGroup CreateRendererGroup(RendererGrid grid, RendererCell cell, RendererKey key) { }

	// RVA: 0x92D2E0 Offset: 0x92C6E0 VA: 0x18092D2E0
	private void DestroyRendererGroup(ref RendererGroup grp) { }

	// RVA: 0x92D340 Offset: 0x92C740 VA: 0x18092D340 Slot: 4
	public void EnterPool() { }

	// RVA: 0x92D680 Offset: 0x92CA80 VA: 0x18092D680 Slot: 5
	public void LeavePool() { }

	// RVA: 0x92DC20 Offset: 0x92D020 VA: 0x18092DC20
	public void .ctor() { }

}

private sealed class RendererCell.<RefreshAsync>d__13 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 9917
{	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public RendererCell <>4__this; // 0x20
	private BufferList<RendererGroup> <batchGroups>5__2; // 0x28
	private int <i>5__3; // 0x30
	private IEnumerator <enumerator>5__4; // 0x38
	private RendererGroup <batchGroup>5__5; // 0x40
	private int <j>5__6; // 0x48

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

	// RVA: 0x935A10 Offset: 0x934E10 VA: 0x180935A10 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x9363F0 Offset: 0x9357F0 VA: 0x1809363F0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

}

