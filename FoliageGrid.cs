public class FoliageGrid : SingletonComponent<FoliageGrid>, IClientComponent // TypeDefIndex: 9870
{	public static bool Paused; // 0x0
	public GameObjectRef BatchPrefab; // 0x18
	public float CellSize; // 0x20
	public LayerSelect FoliageLayer; // 0x24
	public ShadowCastingMode FoliageShadows; // 0x28
	internal ListHashSet<FoliagePlacement> Placements; // 0x30
	private WorldSpaceGrid<FoliageCell> grid; // 0x38
	private Vector2i curCell; // 0x40
	private Vector3 prevPosition; // 0x48
	private Stopwatch watch; // 0x58

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

	[IteratorStateMachineAttribute] // RVA: 0xA2BE0 Offset: 0xA1FE0 VA: 0x1800A2BE0
	private IEnumerator UpdateCoroutine() { }

	private bool NeedsUpdate() { }

	private Vector2i GetCurrentCellCoordinates() { }

	public void .ctor() { }

	private static void .cctor() { }

}

private sealed class FoliageGrid.<UpdateCoroutine>d__31 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 9871
{	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public FoliageGrid <>4__this; // 0x20
	private Vector2i <newCell>5__2; // 0x28
	private List<FoliageCell> <cells>5__3; // 0x30
	private List<IEnumerator> <enumerators>5__4; // 0x38
	private int <i>5__5; // 0x40

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

