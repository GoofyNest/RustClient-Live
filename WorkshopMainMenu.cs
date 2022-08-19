public class WorkshopMainMenu : SingletonComponent<WorkshopMainMenu> // TypeDefIndex: 11174
{	// Fields
	public static Translate.Phrase loading_workshop; // 0x0
	public static Translate.Phrase loading_workshop_setup; // 0x8
	public static Translate.Phrase loading_workshop_skinnables; // 0x10
	public static Translate.Phrase loading_workshop_item; // 0x18

	// Methods

	// RVA: 0x8A8060 Offset: 0x8A7460 VA: 0x1808A8060
	public void CreateNewItem() { }

	// RVA: 0x8A8140 Offset: 0x8A7540 VA: 0x1808A8140
	private void OnEnable() { }

	[IteratorStateMachineAttribute] // RVA: 0x9CBD0 Offset: 0x9BFD0 VA: 0x18009CBD0
	// RVA: 0x8A7FF0 Offset: 0x8A73F0 VA: 0x1808A7FF0
	private IEnumerator CreateNewItemAsync() { }

	// RVA: 0x8A8220 Offset: 0x8A7620 VA: 0x1808A8220
	public void StartEditingItem(IWorkshopContent id) { }

	// RVA: 0x8A8340 Offset: 0x8A7740 VA: 0x1808A8340
	public void StartViewingItem(IWorkshopContent id) { }

	[IteratorStateMachineAttribute] // RVA: 0x9CCE0 Offset: 0x9C0E0 VA: 0x18009CCE0
	// RVA: 0x8A80D0 Offset: 0x8A74D0 VA: 0x1808A80D0
	private IEnumerator LoadEditor() { }

	[IteratorStateMachineAttribute] // RVA: 0x9CEC0 Offset: 0x9C2C0 VA: 0x18009CEC0
	// RVA: 0x8A8190 Offset: 0x8A7590 VA: 0x1808A8190
	private IEnumerator StartEditingItemAsync(IWorkshopContent id) { }

	[IteratorStateMachineAttribute] // RVA: 0x9D050 Offset: 0x9C450 VA: 0x18009D050
	// RVA: 0x8A82B0 Offset: 0x8A76B0 VA: 0x1808A82B0
	private IEnumerator StartViewingItemAsync(IWorkshopContent id) { }

	// RVA: 0x8A8510 Offset: 0x8A7910 VA: 0x1808A8510
	public void .ctor() { }

	// RVA: 0x8A83D0 Offset: 0x8A77D0 VA: 0x1808A83D0
	private static void .cctor() { }

}

private sealed class WorkshopMainMenu.<CreateNewItemAsync>d__6 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 11175
{	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public WorkshopMainMenu <>4__this; // 0x20

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

	// RVA: 0x892F40 Offset: 0x892340 VA: 0x180892F40 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x893090 Offset: 0x892490 VA: 0x180893090 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

}

private sealed class WorkshopMainMenu.<>c // TypeDefIndex: 11176
{	// Fields
	public static readonly WorkshopMainMenu.<>c <>9; // 0x0
	public static Action<bool, string> <>9__9_0; // 0x8

	// Methods

	// RVA: 0x897CC0 Offset: 0x8970C0 VA: 0x180897CC0
	private static void .cctor() { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x8979E0 Offset: 0x896DE0 VA: 0x1808979E0
	internal void <LoadEditor>b__9_0(bool o, string str) { }

}

private sealed class WorkshopMainMenu.<LoadEditor>d__9 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 11177
{	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public WorkshopMainMenu <>4__this; // 0x20

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

	// RVA: 0x896190 Offset: 0x895590 VA: 0x180896190 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x896620 Offset: 0x895A20 VA: 0x180896620 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

}

private sealed class WorkshopMainMenu.<StartEditingItemAsync>d__10 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 11178
{	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public WorkshopMainMenu <>4__this; // 0x20
	public IWorkshopContent id; // 0x28

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

	// RVA: 0x897170 Offset: 0x896570 VA: 0x180897170 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x897350 Offset: 0x896750 VA: 0x180897350 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

}

private sealed class WorkshopMainMenu.<StartViewingItemAsync>d__11 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 11179
{	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public WorkshopMainMenu <>4__this; // 0x20
	public IWorkshopContent id; // 0x28

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

	// RVA: 0x8973A0 Offset: 0x8967A0 VA: 0x1808973A0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x897580 Offset: 0x896980 VA: 0x180897580 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

}

