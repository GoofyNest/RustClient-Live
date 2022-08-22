public class LODGrid : SingletonComponent<LODGrid>, IClientComponent // TypeDefIndex: 9933
{	public static bool Paused; // 0x0
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

	public bool NeedsTimeout { get; }


	protected void OnEnable() { }

	public static void RefreshAll() { }

	public void Refresh() { }

	public static void Refresh(ILOD component, Transform transform, ref LODCell cell) { }

	public static void Add(ILOD component, Transform transform, ref LODCell cell) { }

	public static void Remove(ILOD component, Transform transform, ref LODCell cell) { }

	public static void AddTreeMesh(TreeLOD component) { }

	public static void RemoveTreeMesh(TreeLOD component) { }

	private void Init() { }

	private void UpdateTreeMeshes() { }

	public bool get_NeedsTimeout() { }

	public void ResetTimeout() { }

	[IteratorStateMachineAttribute] // RVA: 0xA9E10 Offset: 0xA9210 VA: 0x1800A9E10
	private IEnumerator UpdateCoroutine() { }

	private Vector2i GetCurrentCellCoordinates() { }

	public void .ctor() { }

	private static void .cctor() { }

}

private sealed class LODGrid.<UpdateCoroutine>d__25 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 9934
{	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public LODGrid <>4__this; // 0x20
	private Vector2i <newCell>5__2; // 0x28
	private int <maxLeaveX>5__3; // 0x30
	private int <minLeaveZ>5__4; // 0x34
	private int <maxLeaveZ>5__5; // 0x38
	private int <x>5__6; // 0x3C
	private int <z>5__7; // 0x40

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

