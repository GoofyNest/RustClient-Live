public class WorldSetup : SingletonComponent<WorldSetup> // TypeDefIndex: 10570
{	public bool AutomaticallySetup; // 0x18
	public GameObject terrain; // 0x20
	public GameObject decorPrefab; // 0x28
	public GameObject grassPrefab; // 0x30
	public GameObject spawnPrefab; // 0x38
	private TerrainMeta terrainMeta; // 0x40
	public uint EditorSeed; // 0x48
	public uint EditorSalt; // 0x4C
	public uint EditorSize; // 0x50
	public string EditorUrl; // 0x58
	internal List<ProceduralObject> ProceduralObjects; // 0x60
	internal List<MonumentNode> MonumentNodes; // 0x68


	private void OnValidate() { }

	protected override void Awake() { }

	protected void CreateObject(GameObject prefab) { }

	[IteratorStateMachineAttribute] // RVA: 0xDB850 Offset: 0xDAC50 VA: 0x1800DB850
	public IEnumerator InitCoroutine() { }

	private void CancelSetup(string msg) { }

	public void .ctor() { }

}

private sealed class WorldSetup.<>c // TypeDefIndex: 10571
{	public static readonly WorldSetup.<>c <>9; // 0x0
	public static Action<string> <>9__15_0; // 0x8
	public static Action<string> <>9__15_1; // 0x10


	private static void .cctor() { }

	public void .ctor() { }

	internal void <InitCoroutine>b__15_0(string str) { }

	internal void <InitCoroutine>b__15_1(string str) { }

}

private sealed class WorldSetup.<InitCoroutine>d__15 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 10572
{	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public WorldSetup <>4__this; // 0x20
	private ProceduralComponent[] <components>5__2; // 0x28
	private Timing <downloadTimer>5__3; // 0x30
	private Timing <loadTimer>5__4; // 0x40
	private Timing <receiveTimer>5__5; // 0x50
	private Timing <spawnTimer>5__6; // 0x60
	private Timing <procgenTimer>5__7; // 0x70
	private Timing <saveTimer>5__8; // 0x80
	private Timing <checksumTimer>5__9; // 0x90
	private Timing <finalizeTimer>5__10; // 0xA0
	private Timing <cleaningTimer>5__11; // 0xB0
	private UnityWebRequest <request>5__12; // 0xC0
	private IEnumerator <worldSpawn>5__13; // 0xC8
	private int <i>5__14; // 0xD0
	private ProceduralComponent <component>5__15; // 0xD8
	private uint <seed>5__16; // 0xE0

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

