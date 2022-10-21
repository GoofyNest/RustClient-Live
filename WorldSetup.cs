public class WorldSetup : SingletonComponent<WorldSetup> // TypeDefIndex: 12301
{
	public bool AutomaticallySetup; 
	public GameObject terrain; 
	public GameObject decorPrefab; 
	public GameObject grassPrefab; 
	public GameObject spawnPrefab; 
	private TerrainMeta terrainMeta; 
	public uint EditorSeed; 
	public uint EditorSalt; 
	public uint EditorSize; 
	public string EditorUrl; 
	internal List<ProceduralObject> ProceduralObjects; 
	internal List<MonumentNode> MonumentNodes; 


	private void OnValidate() { }

	protected override void Awake() { }

	protected void CreateObject(GameObject prefab) { }

	[IteratorStateMachineAttribute] 
	public IEnumerator InitCoroutine() { }

	private void CancelSetup(string msg) { }

	public void .ctor() { }

}

private sealed class WorldSetup.<>c // TypeDefIndex: 12302
{
	public static readonly WorldSetup.<>c <>9; 
	public static Action<string> <>9__15_0; 
	public static Action<string> <>9__15_1; 


	private static void .cctor() { }

	public void .ctor() { }

	internal void <InitCoroutine>b__15_0(string str) { }

	internal void <InitCoroutine>b__15_1(string str) { }

}

private sealed class WorldSetup.<InitCoroutine>d__15 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 12303
{
	private int <>1__state; 
	private object <>2__current; 
	public WorldSetup <>4__this; 
	private ProceduralComponent[] <components>5__2; 
	private Timing <downloadTimer>5__3; 
	private Timing <loadTimer>5__4; 
	private Timing <receiveTimer>5__5; 
	private Timing <spawnTimer>5__6; 
	private Timing <procgenTimer>5__7; 
	private Timing <saveTimer>5__8; 
	private Timing <checksumTimer>5__9; 
	private Timing <finalizeTimer>5__10; 
	private Timing <cleaningTimer>5__11; 
	private UnityWebRequest <request>5__12; 
	private IEnumerator <worldSpawn>5__13; 
	private int <i>5__14; 
	private ProceduralComponent <component>5__15; 
	private uint <seed>5__16; 

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

