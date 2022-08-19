public class ParticleSpawn : SingletonComponent<ParticleSpawn>, IClientComponent // TypeDefIndex: 10358
{	// Fields
	public GameObjectRef[] Prefabs; // 0x18
	public int PatchCount; // 0x20
	public int PatchSize; // 0x24
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Vector3 <Origin>k__BackingField; // 0x28
	private ParticlePatch[] patches; // 0x38

	// Properties
	public Vector3 Origin { get; set; }

	// Methods

	// RVA: 0x939E90 Offset: 0x939290 VA: 0x180939E90
	public static float Distance(Vector3 pos) { }

	// RVA: 0x93A370 Offset: 0x939770 VA: 0x18093A370
	public static void RefreshAll(bool force = False) { }

	// RVA: 0x93A5C0 Offset: 0x9399C0 VA: 0x18093A5C0
	public static void RemoveAll(bool force = False) { }

	// RVA: 0x939FD0 Offset: 0x9393D0 VA: 0x180939FD0
	public void Remove(bool force = False) { }

	// RVA: 0x93A420 Offset: 0x939820 VA: 0x18093A420
	public void Refresh(bool force = False) { }

	[ContextMenu] // RVA: 0xCB300 Offset: 0xCA700 VA: 0x1800CB300
	// RVA: 0x93A2A0 Offset: 0x9396A0 VA: 0x18093A2A0
	private void RefreshAll_ContextMenu() { }

	[ContextMenu] // RVA: 0xCB4B0 Offset: 0xCA8B0 VA: 0x1800CB4B0
	// RVA: 0x93A3F0 Offset: 0x9397F0 VA: 0x18093A3F0
	private void Refresh_ContextMenu() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x7E85E0 Offset: 0x7E79E0 VA: 0x1807E85E0
	public Vector3 get_Origin() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4B9490 Offset: 0x4B8890 VA: 0x1804B9490
	private void set_Origin(Vector3 value) { }

	// RVA: 0x939E10 Offset: 0x939210 VA: 0x180939E10 Slot: 6
	protected override void Awake() { }

	// RVA: 0x93A160 Offset: 0x939560 VA: 0x18093A160
	private void InitPatches() { }

	// RVA: 0x939FD0 Offset: 0x9393D0 VA: 0x180939FD0
	private void FreePatches() { }

	[IteratorStateMachineAttribute] // RVA: 0xCCB10 Offset: 0xCBF10 VA: 0x1800CCB10
	// RVA: 0x93A640 Offset: 0x939A40 VA: 0x18093A640
	private IEnumerator UpdateCoroutine() { }

	// RVA: 0x93A6B0 Offset: 0x939AB0 VA: 0x18093A6B0
	public void .ctor() { }

}

private sealed class ParticleSpawn.<UpdateCoroutine>d__18 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 10359
{	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public ParticleSpawn <>4__this; // 0x20

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

	// RVA: 0x952680 Offset: 0x951A80 VA: 0x180952680 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x952AA0 Offset: 0x951EA0 VA: 0x180952AA0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

}

