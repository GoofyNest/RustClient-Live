public class RendererGrid : SingletonComponent<RendererGrid>, IClientComponent // TypeDefIndex: 9925
{
	public static bool Paused; 
	public GameObjectRef BatchPrefab; 
	public float CellSize; 
	public float MaxMilliseconds; 
	public const float MinTimeBetweenRefreshes = 1;
	private WorldSpaceGrid<RendererCell> grid; 
	private Stopwatch watch; 

	public bool NeedsTimeout { get; }


	protected void OnEnable() { }

	public static void RefreshAll() { }

	public void Refresh() { }

	public RendererGroup Add(Vector3 position, RendererBatch batch) { }

	public void Remove(RendererCell cell) { }

	private void Init() { }

	public MeshRendererBatch CreateInstance() { }

	public void RecycleInstance(MeshRendererBatch instance) { }

	public int MeshCount() { }

	public int BatchedMeshCount() { }

	public int VertexCount() { }

	public bool get_NeedsTimeout() { }

	public void ResetTimeout() { }

	[IteratorStateMachineAttribute] 
	private IEnumerator UpdateCoroutine() { }

	public void .ctor() { }

	private static void .cctor() { }

}

private sealed class RendererGrid.<UpdateCoroutine>d__21 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 9926
{
	private int <>1__state; 
	private object <>2__current; 
	public RendererGrid <>4__this; 
	private int <x>5__2; 
	private int <z>5__3; 
	private RendererCell <cell>5__4; 
	private IEnumerator <enumerator>5__5; 

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

