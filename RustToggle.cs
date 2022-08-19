public class RustToggle : RustControl, IPointerDownHandler, IEventSystemHandler // TypeDefIndex: 7034
{	// Fields
	public StyleAsset StyleOff; // 0x30
	public Image Handle; // 0x38
	public RustText TextOn; // 0x40
	public RustText TextOff; // 0x48
	public bool Value; // 0x50
	public float SliderWidth; // 0x54
	public RustToggle.ChangedEvent OnChanged; // 0x58
	private Coroutine anim; // 0x60

	// Properties
	public override StyleAsset Styles { get; }

	// Methods

	// RVA: 0xFCB930 Offset: 0xFCAD30 VA: 0x180FCB930 Slot: 19
	public override StyleAsset get_Styles() { }

	// RVA: 0xFCB8B0 Offset: 0xFCACB0 VA: 0x180FCB8B0
	public void SetValue(bool value) { }

	// RVA: 0xFCB7D0 Offset: 0xFCABD0 VA: 0x180FCB7D0 Slot: 31
	public void OnPointerDown(PointerEventData eventData) { }

	[IteratorStateMachineAttribute] // RVA: 0x72400 Offset: 0x71800 VA: 0x180072400
	// RVA: 0xFCB3B0 Offset: 0xFCA7B0 VA: 0x180FCB3B0
	private IEnumerator AnimateTo() { }

	// RVA: 0xFCB420 Offset: 0xFCA820 VA: 0x180FCB420 Slot: 29
	public override void ApplyStyles() { }

	// RVA: 0xFCB8D0 Offset: 0xFCACD0 VA: 0x180FCB8D0
	public void .ctor() { }

}

public class RustToggle.ChangedEvent : UnityEvent<bool> // TypeDefIndex: 7035
{	// Methods

	// RVA: 0xFB8EB0 Offset: 0xFB82B0 VA: 0x180FB8EB0
	public void .ctor() { }

}

private sealed class RustToggle.<AnimateTo>d__13 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 7036
{	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public RustToggle <>4__this; // 0x20
	private Vector2 <handleMin>5__2; // 0x28
	private Vector2 <handleMax>5__3; // 0x30
	private float <animTime>5__4; // 0x38
	private float <time>5__5; // 0x3C
	private Image <bg>5__6; // 0x40

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

	// RVA: 0xFD1550 Offset: 0xFD0950 VA: 0x180FD1550 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xFD1AE0 Offset: 0xFD0EE0 VA: 0x180FD1AE0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

}

