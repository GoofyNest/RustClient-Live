public class WorldGrid : SingletonComponent<WorldGrid>, IClientComponent // TypeDefIndex: 10082
{	// Fields
	public static bool Paused; // 0x0
	public float CellSize; // 0x18
	public float MaxMilliseconds; // 0x1C
	public const float MaxRefreshDistance = 500;
	private List<GameObject> tempInstances; // 0x20
	private WorldSpaceGrid<WorldCell> grid; // 0x28
	private Vector2i curCell; // 0x30
	private Stopwatch watch; // 0x38

	// Properties
	public bool NeedsTimeout { get; }

	// Methods

	// RVA: 0x8A93F0 Offset: 0x8A87F0 VA: 0x1808A93F0
	protected void OnEnable() { }

	// RVA: 0x8A9460 Offset: 0x8A8860 VA: 0x1808A9460
	public static void RefreshAll() { }

	// RVA: 0x8A9530 Offset: 0x8A8930 VA: 0x1808A9530
	public void Refresh() { }

	// RVA: 0x8A8DD0 Offset: 0x8A81D0 VA: 0x1808A8DD0
	public static void Add(string category, Prefab prefab, Vector3 position, Quaternion rotation, Vector3 scale) { }

	// RVA: 0x8A9300 Offset: 0x8A8700 VA: 0x1808A9300
	private void Init() { }

	// RVA: 0x8A9830 Offset: 0x8A8C30 VA: 0x1808A9830
	public bool get_NeedsTimeout() { }

	// RVA: 0x8A96E0 Offset: 0x8A8AE0 VA: 0x1808A96E0
	public void ResetTimeout() { }

	[IteratorStateMachineAttribute] // RVA: 0xB30E0 Offset: 0xB24E0 VA: 0x1800B30E0
	// RVA: 0x8A9720 Offset: 0x8A8B20 VA: 0x1808A9720
	private IEnumerator UpdateCoroutine() { }

	// RVA: 0x8A9240 Offset: 0x8A8640 VA: 0x1808A9240
	private Vector2i GetCurrentCellCoordinates() { }

	// RVA: 0x8A9790 Offset: 0x8A8B90 VA: 0x1808A9790
	public void .ctor() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0
	private static void .cctor() { }

}

private sealed class WorldGrid.<UpdateCoroutine>d__16 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 10083
{	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public WorldGrid <>4__this; // 0x20
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

	// RVA: 0x897DE0 Offset: 0x8971E0 VA: 0x180897DE0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x8981B0 Offset: 0x8975B0 VA: 0x1808981B0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

}

