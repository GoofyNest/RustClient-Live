public class FoliageCell // TypeDefIndex: 9867
{	// Fields
	private static readonly ListHashSet<FoliagePlacement> EmptyPlacements; // 0x0
	public Vector3 position; // 0x10
	public FoliageGrid grid; // 0x20
	public bool interrupt; // 0x28
	public float lod; // 0x2C
	public uint seed; // 0x30
	private ListHashSet<FoliagePlacement> placements; // 0x38
	private ListDictionary<FoliageKey, FoliageGroup> batches; // 0x40
	private Action initAsyncAction; // 0x48

	// Methods

	// RVA: 0x6E7540 Offset: 0x6E6940 VA: 0x1806E7540
	public void .ctor(FoliageGrid grid, Vector3 position) { }

	// RVA: 0x6E6AA0 Offset: 0x6E5EA0 VA: 0x1806E6AA0
	private void Init() { }

	[IteratorStateMachineAttribute] // RVA: 0xA2410 Offset: 0xA1810 VA: 0x1800A2410
	// RVA: 0x6E6A30 Offset: 0x6E5E30 VA: 0x1806E6A30
	private IEnumerator InitAsync() { }

	// RVA: 0x6E6F20 Offset: 0x6E6320 VA: 0x1806E6F20
	public bool NeedsRefresh() { }

	// RVA: 0x6E6DF0 Offset: 0x6E61F0 VA: 0x1806E6DF0
	public int MeshCount() { }

	// RVA: 0x6E61E0 Offset: 0x6E55E0 VA: 0x1806E61E0
	public int BatchedMeshCount() { }

	// RVA: 0x6E73B0 Offset: 0x6E67B0 VA: 0x1806E73B0
	public int VertexCount() { }

	// RVA: 0x6E7050 Offset: 0x6E6450 VA: 0x1806E7050
	public void Refresh(bool force = False) { }

	[IteratorStateMachineAttribute] // RVA: 0xA24E0 Offset: 0xA18E0 VA: 0x1800A24E0
	// RVA: 0x6E6FE0 Offset: 0x6E63E0 VA: 0x1806E6FE0
	public IEnumerator RefreshAsync() { }

	// RVA: 0x6E6310 Offset: 0x6E5710 VA: 0x1806E6310
	private float CalculateLOD() { }

	// RVA: 0x6E67C0 Offset: 0x6E5BC0 VA: 0x1806E67C0
	public FoliageGroup FindBatchGroup(Material material) { }

	// RVA: 0x6E65E0 Offset: 0x6E59E0 VA: 0x1806E65E0
	private FoliageGroup CreateFoliageGroup(FoliageGrid grid, FoliageCell cell, FoliageKey key) { }

	// RVA: 0x6E6760 Offset: 0x6E5B60 VA: 0x1806E6760
	private void DestroyFoliageGroup(ref FoliageGroup grp) { }

	// RVA: 0x6E74E0 Offset: 0x6E68E0 VA: 0x1806E74E0
	private static void .cctor() { }

}

private sealed class FoliageCell.<InitAsync>d__11 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 9868
{	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public FoliageCell <>4__this; // 0x20
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

	// RVA: 0x6FFE60 Offset: 0x6FF260 VA: 0x1806FFE60 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x6FFFB0 Offset: 0x6FF3B0 VA: 0x1806FFFB0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

}

private sealed class FoliageCell.<RefreshAsync>d__17 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 9869
{	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public FoliageCell <>4__this; // 0x20
	private BufferList<FoliageGroup> <batchGroups>5__2; // 0x28
	private IEnumerator <enumerator>5__3; // 0x30
	private int <i>5__4; // 0x38
	private FoliageGroup <batchGroup>5__5; // 0x40
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

	// RVA: 0x700000 Offset: 0x6FF400 VA: 0x180700000 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x7008A0 Offset: 0x6FFCA0 VA: 0x1807008A0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

}

