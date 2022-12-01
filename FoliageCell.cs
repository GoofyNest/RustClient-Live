public class FoliageCell // TypeDefIndex: 11612
{
	private static readonly ListHashSet<FoliagePlacement> EmptyPlacements;
	public Vector3 position;
	public FoliageGrid grid;
	public bool interrupt;
	public float lod;
	public uint seed;
	private ListHashSet<FoliagePlacement> placements;
	private ListDictionary<FoliageKey, FoliageGroup> batches;
	private Action initAsyncAction;


	public void .ctor(FoliageGrid grid, Vector3 position) { }

	private void Init() { }

	[IteratorStateMachineAttribute]
	private IEnumerator InitAsync() { }

	public bool NeedsRefresh() { }

	public int MeshCount() { }

	public int BatchedMeshCount() { }

	public int VertexCount() { }

	public void Refresh(bool force = False) { }

	[IteratorStateMachineAttribute]
	public IEnumerator RefreshAsync() { }

	private float CalculateLOD() { }

	public FoliageGroup FindBatchGroup(Material material) { }

	private FoliageGroup CreateFoliageGroup(FoliageGrid grid, FoliageCell cell, FoliageKey key) { }

	private void DestroyFoliageGroup(ref FoliageGroup grp) { }

	private static void .cctor() { }

}

private sealed class FoliageCell.<InitAsync>d__11 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 11613
{
	private int <>1__state;
	private object <>2__current;
	public FoliageCell <>4__this;
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

private sealed class FoliageCell.<RefreshAsync>d__17 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 11614
{
	private int <>1__state;
	private object <>2__current;
	public FoliageCell <>4__this;
	private BufferList<FoliageGroup> <batchGroups>5__2;
	private IEnumerator <enumerator>5__3;
	private int <i>5__4;
	private FoliageGroup <batchGroup>5__5;
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

