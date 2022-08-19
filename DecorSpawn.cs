public class DecorSpawn : MonoBehaviour, IClientComponent // TypeDefIndex: 10333
{	// Fields
	public static List<DecorSpawn> Instances; // 0x0
	private static bool Enabled; // 0x8
	public SpawnFilter Filter; // 0x18
	public string ResourceFolder; // 0x20
	public uint Seed; // 0x28
	public float ObjectCutoff; // 0x2C
	public float ObjectTapering; // 0x30
	public int ObjectsPerPatch; // 0x34
	public float ClusterRadius; // 0x38
	public int ClusterSizeMin; // 0x3C
	public int ClusterSizeMax; // 0x40
	public int PatchCount; // 0x44
	public int PatchSize; // 0x48
	public bool LOD; // 0x4C
	internal Transform Anchor; // 0x50
	internal Prefab[] Prefabs; // 0x58
	private DecorPatch[] patches; // 0x60

	// Methods

	// RVA: 0x8EA290 Offset: 0x8E9690 VA: 0x1808EA290
	public static void SetEnabled(bool b) { }

	// RVA: 0x8E9E20 Offset: 0x8E9220 VA: 0x1808E9E20
	public static void RefreshAll(bool force = False) { }

	// RVA: 0x8EA0F0 Offset: 0x8E94F0 VA: 0x1808EA0F0
	public static void RemoveAll(bool force = False) { }

	// RVA: 0x8E99D0 Offset: 0x8E8DD0 VA: 0x1808E99D0
	public void Remove(bool force = False) { }

	// RVA: 0x8E9F90 Offset: 0x8E9390 VA: 0x1808E9F90
	public void Refresh(bool force = False) { }

	[ContextMenu] // RVA: 0xCB300 Offset: 0xCA700 VA: 0x1800CB300
	// RVA: 0x8E9DC0 Offset: 0x8E91C0 VA: 0x1808E9DC0
	private void RefreshAll_ContextMenu() { }

	[ContextMenu] // RVA: 0xCB4B0 Offset: 0xCA8B0 VA: 0x1800CB4B0
	// RVA: 0x8E9F60 Offset: 0x8E9360 VA: 0x1808E9F60
	private void Refresh_ContextMenu() { }

	// RVA: 0x8E9CE0 Offset: 0x8E90E0 VA: 0x1808E9CE0
	protected void OnEnable() { }

	// RVA: 0x8E9C30 Offset: 0x8E9030 VA: 0x1808E9C30
	protected void OnDisable() { }

	// RVA: 0x8E9A50 Offset: 0x8E8E50 VA: 0x1808E9A50
	private void InitPatches() { }

	// RVA: 0x8E99D0 Offset: 0x8E8DD0 VA: 0x1808E99D0
	private void FreePatches() { }

	[IteratorStateMachineAttribute] // RVA: 0xCB5C0 Offset: 0xCA9C0 VA: 0x1800CB5C0
	// RVA: 0x8EA300 Offset: 0x8E9700 VA: 0x1808EA300
	private IEnumerator UpdateCoroutine() { }

	// RVA: 0x8EA3E0 Offset: 0x8E97E0 VA: 0x1808EA3E0
	public void .ctor() { }

	// RVA: 0x8EA370 Offset: 0x8E9770 VA: 0x1808EA370
	private static void .cctor() { }

}

private sealed class DecorSpawn.<UpdateCoroutine>d__28 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 10334
{	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public DecorSpawn <>4__this; // 0x20
	private int <i>5__2; // 0x28

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

	// RVA: 0x8FFF70 Offset: 0x8FF370 VA: 0x1808FFF70 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x900140 Offset: 0x8FF540 VA: 0x180900140 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

}

