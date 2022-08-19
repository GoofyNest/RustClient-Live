public class RendererGrid : SingletonComponent<RendererGrid>, IClientComponent // TypeDefIndex: 9918
{	// Fields
	public static bool Paused; // 0x0
	public GameObjectRef BatchPrefab; // 0x18
	public float CellSize; // 0x20
	public float MaxMilliseconds; // 0x24
	private WorldSpaceGrid<RendererCell> grid; // 0x28
	private Stopwatch watch; // 0x30

	// Properties
	public bool NeedsTimeout { get; }

	// Methods

	// RVA: 0x92E400 Offset: 0x92D800 VA: 0x18092E400
	protected void OnEnable() { }

	// RVA: 0x92E500 Offset: 0x92D900 VA: 0x18092E500
	public static void RefreshAll() { }

	// RVA: 0x92E660 Offset: 0x92DA60 VA: 0x18092E660
	public void Refresh() { }

	// RVA: 0x92DF50 Offset: 0x92D350 VA: 0x18092DF50
	public RendererGroup Add(Vector3 position, RendererBatch batch) { }

	// RVA: 0x92E710 Offset: 0x92DB10 VA: 0x18092E710
	public void Remove(RendererCell cell) { }

	// RVA: 0x92E280 Offset: 0x92D680 VA: 0x18092E280
	private void Init() { }

	// RVA: 0x92E1C0 Offset: 0x92D5C0 VA: 0x18092E1C0
	public MeshRendererBatch CreateInstance() { }

	// RVA: 0x92E470 Offset: 0x92D870 VA: 0x18092E470
	public void RecycleInstance(MeshRendererBatch instance) { }

	// RVA: 0x92E340 Offset: 0x92D740 VA: 0x18092E340
	public int MeshCount() { }

	// RVA: 0x92E100 Offset: 0x92D500 VA: 0x18092E100
	public int BatchedMeshCount() { }

	// RVA: 0x92E930 Offset: 0x92DD30 VA: 0x18092E930
	public int VertexCount() { }

	// RVA: 0x92EA90 Offset: 0x92DE90 VA: 0x18092EA90
	public bool get_NeedsTimeout() { }

	// RVA: 0x92E880 Offset: 0x92DC80 VA: 0x18092E880
	public void ResetTimeout() { }

	[IteratorStateMachineAttribute] // RVA: 0xA7F90 Offset: 0xA7390 VA: 0x1800A7F90
	// RVA: 0x92E8C0 Offset: 0x92DCC0 VA: 0x18092E8C0
	private IEnumerator UpdateCoroutine() { }

	// RVA: 0x92E9F0 Offset: 0x92DDF0 VA: 0x18092E9F0
	public void .ctor() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0
	private static void .cctor() { }

}

private sealed class RendererGrid.<UpdateCoroutine>d__20 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 9919
{	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public RendererGrid <>4__this; // 0x20
	private int <x>5__2; // 0x28
	private int <z>5__3; // 0x2C
	private RendererCell <cell>5__4; // 0x30
	private IEnumerator <enumerator>5__5; // 0x38

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

	// RVA: 0x936560 Offset: 0x935960 VA: 0x180936560 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x936900 Offset: 0x935D00 VA: 0x180936900 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

}

