public class FoliageCell // TypeDefIndex: 9867
{	private static readonly ListHashSet<FoliagePlacement> EmptyPlacements; // 0x0
	public Vector3 position; // 0x10
	public FoliageGrid grid; // 0x20
	public bool interrupt; // 0x28
	public float lod; // 0x2C
	public uint seed; // 0x30
	private ListHashSet<FoliagePlacement> placements; // 0x38
	private ListDictionary<FoliageKey, FoliageGroup> batches; // 0x40
	private Action initAsyncAction; // 0x48


	public void .ctor(FoliageGrid grid, Vector3 position) { }

	private void Init() { }

	[IteratorStateMachineAttribute] // RVA: 0xA2410 Offset: 0xA1810 VA: 0x1800A2410
	private IEnumerator InitAsync() { }

	public bool NeedsRefresh() { }

	public int MeshCount() { }

	public int BatchedMeshCount() { }

	public int VertexCount() { }

	public void Refresh(bool force = False) { }

	[IteratorStateMachineAttribute] // RVA: 0xA24E0 Offset: 0xA18E0 VA: 0x1800A24E0
	public IEnumerator RefreshAsync() { }

	private float CalculateLOD() { }

	public FoliageGroup FindBatchGroup(Material material) { }

	private FoliageGroup CreateFoliageGroup(FoliageGrid grid, FoliageCell cell, FoliageKey key) { }

	private void DestroyFoliageGroup(ref FoliageGroup grp) { }

	private static void .cctor() { }

}

private sealed class FoliageCell.<InitAsync>d__11 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 9868
{	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public FoliageCell <>4__this; // 0x20
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

private sealed class FoliageCell.<RefreshAsync>d__17 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 9869
{	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public FoliageCell <>4__this; // 0x20
	private BufferList<FoliageGroup> <batchGroups>5__2; // 0x28
	private IEnumerator <enumerator>5__3; // 0x30
	private int <i>5__4; // 0x38
	private FoliageGroup <batchGroup>5__5; // 0x40
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

