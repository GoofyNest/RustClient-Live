public class LODGrid : SingletonComponent<LODGrid>, IClientComponent // TypeDefIndex: 11655
{
	public static bool Paused; 
	public float CellSize; 
	public float MaxMilliseconds; 
	public const float MaxRefreshDistance = 500;
	public static float TreeMeshDistance; 
	public const float MinTimeBetweenRefreshes = 1;
	private bool treeRefreshRequest; 
	private Vector3 treeRefreshPosition; 
	private List<TreeLOD> treeQueue; 
	private ListHashSet<TreeLOD> treeMeshes; 
	private WorldSpaceGrid<LODCell> grid; 
	private Vector2i curCell; 
	private Stopwatch watch; 

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

	[IteratorStateMachineAttribute] 
	private IEnumerator UpdateCoroutine() { }

	private Vector2i GetCurrentCellCoordinates() { }

	public void .ctor() { }

	private static void .cctor() { }

}

private sealed class LODGrid.<UpdateCoroutine>d__26 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 11656
{
	private int <>1__state; 
	private object <>2__current; 
	public LODGrid <>4__this; 
	private Vector2i <newCell>5__2; 
	private int <maxLeaveX>5__3; 
	private int <minLeaveZ>5__4; 
	private int <maxLeaveZ>5__5; 
	private int <x>5__6; 
	private int <z>5__7; 

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

