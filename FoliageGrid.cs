public class FoliageGrid : SingletonComponent<FoliageGrid>, IClientComponent // TypeDefIndex: 9870
{	// Fields
	public static bool Paused; // 0x0
	public GameObjectRef BatchPrefab; // 0x18
	public float CellSize; // 0x20
	public LayerSelect FoliageLayer; // 0x24
	public ShadowCastingMode FoliageShadows; // 0x28
	internal ListHashSet<FoliagePlacement> Placements; // 0x30
	private WorldSpaceGrid<FoliageCell> grid; // 0x38
	private Vector2i curCell; // 0x40
	private Vector3 prevPosition; // 0x48
	private Stopwatch watch; // 0x58

	// Properties
	public static float MaxRefreshDistance { get; }
	public bool Initialized { get; }
	public float MaxMilliseconds { get; }
	public FoliageCell Item { get; }
	public bool NeedsTimeout { get; }

	// Methods

	// RVA: 0x6EAB50 Offset: 0x6E9F50 VA: 0x1806EAB50
	public static float get_MaxRefreshDistance() { }

	// RVA: 0x6EAA20 Offset: 0x6E9E20 VA: 0x1806EAA20
	public bool get_Initialized() { }

	// RVA: 0x6EAAB0 Offset: 0x6E9EB0 VA: 0x1806EAAB0
	public float get_MaxMilliseconds() { }

	// RVA: 0x6EA350 Offset: 0x6E9750 VA: 0x1806EA350
	protected void OnEnable() { }

	// RVA: 0x6EA450 Offset: 0x6E9850 VA: 0x1806EA450
	public static void RefreshAll(bool force = False) { }

	// RVA: 0x6EA670 Offset: 0x6E9A70 VA: 0x1806EA670
	public void Refresh(bool force = False) { }

	// RVA: 0x6EAA30 Offset: 0x6E9E30 VA: 0x1806EAA30
	public FoliageCell get_Item(Vector3 worldPos) { }

	// RVA: 0x6EA030 Offset: 0x6E9430 VA: 0x1806EA030
	private void Init() { }

	// RVA: 0x6E9EB0 Offset: 0x6E92B0 VA: 0x1806E9EB0
	public FoliageGridBatch CreateInstance() { }

	// RVA: 0x6EA3C0 Offset: 0x6E97C0 VA: 0x1806EA3C0
	public void RecycleInstance(FoliageGridBatch instance) { }

	// RVA: 0x6E9D20 Offset: 0x6E9120 VA: 0x1806E9D20
	public void AddPlacement(FoliagePlacement placement) { }

	// RVA: 0x6EA200 Offset: 0x6E9600 VA: 0x1806EA200
	public int MeshCount() { }

	// RVA: 0x6E9E00 Offset: 0x6E9200 VA: 0x1806E9E00
	public int BatchedMeshCount() { }

	// RVA: 0x6EA890 Offset: 0x6E9C90 VA: 0x1806EA890
	public int VertexCount() { }

	// RVA: 0x6EABF0 Offset: 0x6E9FF0 VA: 0x1806EABF0
	public bool get_NeedsTimeout() { }

	// RVA: 0x6EA7E0 Offset: 0x6E9BE0 VA: 0x1806EA7E0
	public void ResetTimeout() { }

	[IteratorStateMachineAttribute] // RVA: 0xA2BE0 Offset: 0xA1FE0 VA: 0x1800A2BE0
	// RVA: 0x6EA820 Offset: 0x6E9C20 VA: 0x1806EA820
	private IEnumerator UpdateCoroutine() { }

	// RVA: 0x6EA2B0 Offset: 0x6E96B0 VA: 0x1806EA2B0
	private bool NeedsUpdate() { }

	// RVA: 0x6E9F70 Offset: 0x6E9370 VA: 0x1806E9F70
	private Vector2i GetCurrentCellCoordinates() { }

	// RVA: 0x6EA940 Offset: 0x6E9D40 VA: 0x1806EA940
	public void .ctor() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0
	private static void .cctor() { }

}

private sealed class FoliageGrid.<UpdateCoroutine>d__31 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 9871
{	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public FoliageGrid <>4__this; // 0x20
	private Vector2i <newCell>5__2; // 0x28
	private List<FoliageCell> <cells>5__3; // 0x30
	private List<IEnumerator> <enumerators>5__4; // 0x38
	private int <i>5__5; // 0x40

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

	// RVA: 0x701080 Offset: 0x700480 VA: 0x180701080 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x701910 Offset: 0x700D10 VA: 0x180701910 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

}

