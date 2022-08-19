public class GameSetup : MonoBehaviour // TypeDefIndex: 9887
{	// Fields
	public static bool RunOnce; // 0x0
	public bool startServer; // 0x18
	public string clientConnectCommand; // 0x20
	public bool loadMenu; // 0x28
	public bool loadLevel; // 0x29
	public string loadLevelScene; // 0x30
	public bool loadSave; // 0x38
	public string loadSaveFile; // 0x40

	// Methods

	// RVA: 0x6F90C0 Offset: 0x6F84C0 VA: 0x1806F90C0
	protected void Awake() { }

	[IteratorStateMachineAttribute] // RVA: 0xA49A0 Offset: 0xA3DA0 VA: 0x1800A49A0
	// RVA: 0x6F9550 Offset: 0x6F8950 VA: 0x1806F9550
	private IEnumerator DoGameSetup() { }

	// RVA: 0x6F9360 Offset: 0x6F8760 VA: 0x1806F9360
	private void ClientJoin() { }

	// RVA: 0x6F95C0 Offset: 0x6F89C0 VA: 0x1806F95C0
	public void .ctor() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0
	private static void .cctor() { }

}

private sealed class GameSetup.<DoGameSetup>d__9 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 9888
{	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public GameSetup <>4__this; // 0x20

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

	// RVA: 0x6FF950 Offset: 0x6FED50 VA: 0x1806FF950 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x6FFE10 Offset: 0x6FF210 VA: 0x1806FFE10 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

}

