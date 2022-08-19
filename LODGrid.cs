public class LODGrid : SingletonComponent<LODGrid>, IClientComponent // TypeDefIndex: 9933
{	// Fields
	public static bool Paused; // 0x0
	public float CellSize; // 0x18
	public float MaxMilliseconds; // 0x1C
	public const float MaxRefreshDistance = 500;
	public static float TreeMeshDistance; // 0x4
	private bool treeRefreshRequest; // 0x20
	private Vector3 treeRefreshPosition; // 0x24
	private List<TreeLOD> treeQueue; // 0x30
	private ListHashSet<TreeLOD> treeMeshes; // 0x38
	private WorldSpaceGrid<LODCell> grid; // 0x40
	private Vector2i curCell; // 0x48
	private Stopwatch watch; // 0x50

	// Properties
	public bool NeedsTimeout { get; }

	// Methods

	// RVA: 0x6BA880 Offset: 0x6B9C80 VA: 0x1806BA880
	protected void OnEnable() { }

	// RVA: 0x6BA8F0 Offset: 0x6B9CF0 VA: 0x1806BA8F0
	public static void RefreshAll() { }

	// RVA: 0x6BAB70 Offset: 0x6B9F70 VA: 0x1806BAB70
	public void Refresh() { }

	// RVA: 0x6BAA70 Offset: 0x6B9E70 VA: 0x1806BAA70
	public static void Refresh(ILOD component, Transform transform, ref LODCell cell) { }

	// RVA: 0x6BA390 Offset: 0x6B9790 VA: 0x1806BA390
	public static void Add(ILOD component, Transform transform, ref LODCell cell) { }

	// RVA: 0x6BAD40 Offset: 0x6BA140 VA: 0x1806BAD40
	public static void Remove(ILOD component, Transform transform, ref LODCell cell) { }

	// RVA: 0x6BA230 Offset: 0x6B9630 VA: 0x1806BA230
	public static void AddTreeMesh(TreeLOD component) { }

	// RVA: 0x6BAC40 Offset: 0x6BA040 VA: 0x1806BAC40
	public static void RemoveTreeMesh(TreeLOD component) { }

	// RVA: 0x6BA7C0 Offset: 0x6B9BC0 VA: 0x1806BA7C0
	private void Init() { }

	// RVA: 0x6BB050 Offset: 0x6BA450 VA: 0x1806BB050
	private void UpdateTreeMeshes() { }

	// RVA: 0x6BB750 Offset: 0x6BAB50 VA: 0x1806BB750
	public bool get_NeedsTimeout() { }

	// RVA: 0x6BAFA0 Offset: 0x6BA3A0 VA: 0x1806BAFA0
	public void ResetTimeout() { }

	[IteratorStateMachineAttribute] // RVA: 0xA9E10 Offset: 0xA9210 VA: 0x1800A9E10
	// RVA: 0x6BAFE0 Offset: 0x6BA3E0 VA: 0x1806BAFE0
	private IEnumerator UpdateCoroutine() { }

	// RVA: 0x6BA700 Offset: 0x6B9B00 VA: 0x1806BA700
	private Vector2i GetCurrentCellCoordinates() { }

	// RVA: 0x6BB650 Offset: 0x6BAA50 VA: 0x1806BB650
	public void .ctor() { }

	// RVA: 0x6BB600 Offset: 0x6BAA00 VA: 0x1806BB600
	private static void .cctor() { }

}

private sealed class LODGrid.<UpdateCoroutine>d__25 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 9934
{	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public LODGrid <>4__this; // 0x20
	private Vector2i <newCell>5__2; // 0x28
	private int <maxLeaveX>5__3; // 0x30
	private int <minLeaveZ>5__4; // 0x34
	private int <maxLeaveZ>5__5; // 0x38
	private int <x>5__6; // 0x3C
	private int <z>5__7; // 0x40

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

	// RVA: 0x6C66A0 Offset: 0x6C5AA0 VA: 0x1806C66A0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x6C6A90 Offset: 0x6C5E90 VA: 0x1806C6A90 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

}

