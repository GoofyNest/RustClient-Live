public static class CoroutineEx // TypeDefIndex: 11695
{	// Fields
	public static WaitForEndOfFrame waitForEndOfFrame; // 0x0
	public static WaitForFixedUpdate waitForFixedUpdate; // 0x8
	private static Dictionary<float, WaitForSeconds> waitForSecondsBuffer; // 0x10

	// Methods

	// RVA: 0x9D6A60 Offset: 0x9D5E60 VA: 0x1809D6A60
	public static WaitForSeconds waitForSeconds(float seconds) { }

	// RVA: 0x9D69F0 Offset: 0x9D5DF0 VA: 0x1809D69F0
	public static WaitForSecondsRealtimeEx waitForSecondsRealtime(float seconds) { }

	[IteratorStateMachineAttribute] // RVA: 0xD1690 Offset: 0xD0A90 VA: 0x1800D1690
	// RVA: 0x9D68B0 Offset: 0x9D5CB0 VA: 0x1809D68B0
	public static IEnumerator Combine(IEnumerator[] coroutines) { }

	// RVA: 0x9D6920 Offset: 0x9D5D20 VA: 0x1809D6920
	private static void .cctor() { }

}

private sealed class CoroutineEx.<Combine>d__5 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 11696
{	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public IEnumerator[] coroutines; // 0x20

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

	// RVA: 0x9DEA50 Offset: 0x9DDE50 VA: 0x1809DEA50 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x9DEB70 Offset: 0x9DDF70 VA: 0x1809DEB70 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

}

