public class DecorSpawn : MonoBehaviour, IClientComponent // TypeDefIndex: 10344
{
	public static List<DecorSpawn> Instances; 
	private static bool Enabled; 
	public SpawnFilter Filter; 
	public string ResourceFolder; 
	public uint Seed; 
	public float ObjectCutoff; 
	public float ObjectTapering; 
	public int ObjectsPerPatch; 
	public float ClusterRadius; 
	public int ClusterSizeMin; 
	public int ClusterSizeMax; 
	public int PatchCount; 
	public int PatchSize; 
	public bool LOD; 
	internal Transform Anchor; 
	internal Prefab[] Prefabs; 
	private DecorPatch[] patches; 


	public static void SetEnabled(bool b) { }

	public static void RefreshAll(bool force = False) { }

	public static void RemoveAll(bool force = False) { }

	public void Remove(bool force = False) { }

	public void Refresh(bool force = False) { }

	[ContextMenu] 
	private void RefreshAll_ContextMenu() { }

	[ContextMenu] 
	private void Refresh_ContextMenu() { }

	protected void OnEnable() { }

	protected void OnDisable() { }

	private void InitPatches() { }

	private void FreePatches() { }

	[IteratorStateMachineAttribute] 
	private IEnumerator UpdateCoroutine() { }

	public void .ctor() { }

	private static void .cctor() { }

}

private sealed class DecorSpawn.<UpdateCoroutine>d__28 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 10345
{
	private int <>1__state; 
	private object <>2__current; 
	public DecorSpawn <>4__this; 
	private int <i>5__2; 

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

