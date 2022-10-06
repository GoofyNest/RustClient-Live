public class FoliageGrid : SingletonComponent<FoliageGrid>, IClientComponent // TypeDefIndex: 11582
{
	public static bool Paused; 
	public GameObjectRef BatchPrefab; 
	public float CellSize; 
	public LayerSelect FoliageLayer; 
	public ShadowCastingMode FoliageShadows; 
	internal ListHashSet<FoliagePlacement> Placements; 
	private WorldSpaceGrid<FoliageCell> grid; 
	private Vector2i curCell; 
	private Vector3 prevPosition; 
	private Stopwatch watch; 

	public static float MaxRefreshDistance { get; }
	public bool Initialized { get; }
	public float MaxMilliseconds { get; }
	public FoliageCell Item { get; }
	public bool NeedsTimeout { get; }


	public static float get_MaxRefreshDistance() { }

	public bool get_Initialized() { }

	public float get_MaxMilliseconds() { }

	protected void OnEnable() { }

	public static void RefreshAll(bool force = False) { }

	public void Refresh(bool force = False) { }

	public FoliageCell get_Item(Vector3 worldPos) { }

	private void Init() { }

	public FoliageGridBatch CreateInstance() { }

	public void RecycleInstance(FoliageGridBatch instance) { }

	public void AddPlacement(FoliagePlacement placement) { }

	public int MeshCount() { }

	public int BatchedMeshCount() { }

	public int VertexCount() { }

	public bool get_NeedsTimeout() { }

	public void ResetTimeout() { }

	[IteratorStateMachineAttribute] 
	private IEnumerator UpdateCoroutine() { }

	private bool NeedsUpdate() { }

	private Vector2i GetCurrentCellCoordinates() { }

	public void .ctor() { }

	private static void .cctor() { }

}

private sealed class FoliageGrid.<UpdateCoroutine>d__31 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 11583
{
	private int <>1__state; 
	private object <>2__current; 
	public FoliageGrid <>4__this; 
	private Vector2i <newCell>5__2; 
	private List<FoliageCell> <cells>5__3; 
	private List<IEnumerator> <enumerators>5__4; 
	private int <i>5__5; 

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

