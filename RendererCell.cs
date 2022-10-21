public class RendererCell : Pool.IPooled // TypeDefIndex: 11640
{
	public Vector3 position; 
	public RendererGrid grid; 
	public bool interrupt; 
	public bool isInPool; 
	public float Timestamp; 
	private ListDictionary<RendererKey, RendererGroup> batches; 

	public int Count { get; }


	public int get_Count() { }

	public void Initialize(RendererGrid grid, Vector3 position) { }

	public bool NeedsRefresh() { }

	public int MeshCount() { }

	public int BatchedMeshCount() { }

	public int VertexCount() { }

	public void Refresh() { }

	[IteratorStateMachineAttribute] 
	public IEnumerator RefreshAsync() { }

	public RendererGroup FindBatchGroup(RendererBatch renderer) { }

	private RendererGroup CreateRendererGroup(RendererGrid grid, RendererCell cell, RendererKey key) { }

	private void DestroyRendererGroup(ref RendererGroup grp) { }

	public void EnterPool() { }

	public void LeavePool() { }

	public void .ctor() { }

}

private sealed class RendererCell.<RefreshAsync>d__14 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 11641
{
	private int <>1__state; 
	private object <>2__current; 
	public RendererCell <>4__this; 
	private BufferList<RendererGroup> <batchGroups>5__2; 
	private int <i>5__3; 
	private IEnumerator <enumerator>5__4; 
	private RendererGroup <batchGroup>5__5; 
	private int <j>5__6; 

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

