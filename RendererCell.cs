public class RendererCell : Pool.IPooled // TypeDefIndex: 9916
{	public Vector3 position; // 0x10
	public RendererGrid grid; // 0x20
	public bool interrupt; // 0x28
	public bool isInPool; // 0x29
	private ListDictionary<RendererKey, RendererGroup> batches; // 0x30

	public int Count { get; }


	public int get_Count() { }

	public void Initialize(RendererGrid grid, Vector3 position) { }

	public bool NeedsRefresh() { }

	public int MeshCount() { }

	public int BatchedMeshCount() { }

	public int VertexCount() { }

	public void Refresh() { }

	[IteratorStateMachineAttribute] // RVA: 0xA7BC0 Offset: 0xA6FC0 VA: 0x1800A7BC0
	public IEnumerator RefreshAsync() { }

	public RendererGroup FindBatchGroup(RendererBatch renderer) { }

	private RendererGroup CreateRendererGroup(RendererGrid grid, RendererCell cell, RendererKey key) { }

	private void DestroyRendererGroup(ref RendererGroup grp) { }

	public void EnterPool() { }

	public void LeavePool() { }

	public void .ctor() { }

}

private sealed class RendererCell.<RefreshAsync>d__13 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 9917
{	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public RendererCell <>4__this; // 0x20
	private BufferList<RendererGroup> <batchGroups>5__2; // 0x28
	private int <i>5__3; // 0x30
	private IEnumerator <enumerator>5__4; // 0x38
	private RendererGroup <batchGroup>5__5; // 0x40
	private int <j>5__6; // 0x48

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

