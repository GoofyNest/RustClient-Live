public class TypeThroughButton : Button, IUpdateSelectedHandler, IEventSystemHandler // TypeDefIndex: 11239
{	// Fields
	public InputField typingTarget; // 0xF0
	private Event _processingEvent; // 0xF8

	// Methods

	// RVA: 0x4D1C90 Offset: 0x4D1090 VA: 0x1804D1C90 Slot: 43
	public void OnUpdateSelected(BaseEventData eventData) { }

	[IteratorStateMachineAttribute] // RVA: 0xA2680 Offset: 0xA1A80 VA: 0x1800A2680
	// RVA: 0x4D1C00 Offset: 0x4D1000 VA: 0x1804D1C00
	private IEnumerator DelayedActivateTextField(Event e) { }

	// RVA: 0x4D1DE0 Offset: 0x4D11E0 VA: 0x1804D1DE0
	public void .ctor() { }

}

private sealed class TypeThroughButton.<DelayedActivateTextField>d__3 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 11240
{	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public TypeThroughButton <>4__this; // 0x20
	public Event e; // 0x28

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

	// RVA: 0x4D1E50 Offset: 0x4D1250 VA: 0x1804D1E50 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4D1FF0 Offset: 0x4D13F0 VA: 0x1804D1FF0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

}

