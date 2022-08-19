public class Button : Selectable, IPointerClickHandler, IEventSystemHandler, ISubmitHandler // TypeDefIndex: 4905
{	// Fields
	[FormerlySerializedAsAttribute] // RVA: 0xE4880 Offset: 0xE3C80 VA: 0x1800E4880
	[SerializeField] // RVA: 0xE4880 Offset: 0xE3C80 VA: 0x1800E4880
	private Button.ButtonClickedEvent m_OnClick; // 0xE8

	// Properties
	public Button.ButtonClickedEvent onClick { get; set; }

	// Methods

	// RVA: 0x10B2450 Offset: 0x10B1850 VA: 0x1810B2450
	protected void .ctor() { }

	// RVA: 0x94E830 Offset: 0x94DC30 VA: 0x18094E830
	public Button.ButtonClickedEvent get_onClick() { }

	// RVA: 0x94E8B0 Offset: 0x94DCB0 VA: 0x18094E8B0
	public void set_onClick(Button.ButtonClickedEvent value) { }

	// RVA: 0x10B23C0 Offset: 0x10B17C0 VA: 0x1810B23C0
	private void Press() { }

	// RVA: 0x10B22C0 Offset: 0x10B16C0 VA: 0x1810B22C0 Slot: 41
	public virtual void OnPointerClick(PointerEventData eventData) { }

	// RVA: 0x10B22F0 Offset: 0x10B16F0 VA: 0x1810B22F0 Slot: 42
	public virtual void OnSubmit(BaseEventData eventData) { }

	[IteratorStateMachineAttribute] // RVA: 0xE5C40 Offset: 0xE5040 VA: 0x1800E5C40
	// RVA: 0x10B2250 Offset: 0x10B1650 VA: 0x1810B2250
	private IEnumerator OnFinishSubmit() { }

}

public class Button.ButtonClickedEvent : UnityEvent // TypeDefIndex: 4906
{	// Methods

	// RVA: 0x10B2240 Offset: 0x10B1640 VA: 0x1810B2240
	public void .ctor() { }

}

private sealed class Button.<OnFinishSubmit>d__9 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 4907
{	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public Button <>4__this; // 0x20
	private float <fadeTime>5__2; // 0x28
	private float <elapsedTime>5__3; // 0x2C

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

	// RVA: 0x10C9AE0 Offset: 0x10C8EE0 VA: 0x1810C9AE0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x10C9BC0 Offset: 0x10C8FC0 VA: 0x1810C9BC0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

}

public enum BUTTON // TypeDefIndex: 10100
{	// Fields
	public int value__; // 0x0
	public const BUTTON FORWARD = 2;
	public const BUTTON BACKWARD = 4;
	public const BUTTON LEFT = 8;
	public const BUTTON RIGHT = 16;
	public const BUTTON JUMP = 32;
	public const BUTTON DUCK = 64;
	public const BUTTON SPRINT = 128;
	public const BUTTON USE = 256;
	public const BUTTON FIRE_PRIMARY = 1024;
	public const BUTTON FIRE_SECONDARY = 2048;
	public const BUTTON RELOAD = 8192;
	public const BUTTON FIRE_THIRD = 134217728;

}

