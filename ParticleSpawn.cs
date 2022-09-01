public class ParticleSpawn : SingletonComponent<ParticleSpawn>, IClientComponent // TypeDefIndex: 10369
{
	public GameObjectRef[] Prefabs; 
	public int PatchCount; 
	public int PatchSize; 
	[CompilerGeneratedAttribute] 
	private Vector3 <Origin>k__BackingField; 
	private ParticlePatch[] patches; 

	public Vector3 Origin { get; set; }


	public static float Distance(Vector3 pos) { }

	public static void RefreshAll(bool force = False) { }

	public static void RemoveAll(bool force = False) { }

	public void Remove(bool force = False) { }

	public void Refresh(bool force = False) { }

	[ContextMenu] 
	private void RefreshAll_ContextMenu() { }

	[ContextMenu] 
	private void Refresh_ContextMenu() { }

	[CompilerGeneratedAttribute] 
	public Vector3 get_Origin() { }

	[CompilerGeneratedAttribute] 
	private void set_Origin(Vector3 value) { }

	protected override void Awake() { }

	private void InitPatches() { }

	private void FreePatches() { }

	[IteratorStateMachineAttribute] 
	private IEnumerator UpdateCoroutine() { }

	public void .ctor() { }

}

private sealed class ParticleSpawn.<UpdateCoroutine>d__18 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 10370
{
	private int <>1__state; 
	private object <>2__current; 
	public ParticleSpawn <>4__this; 

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

