public class RustToggle : RustControl, IPointerDownHandler, IEventSystemHandler // TypeDefIndex: 7034
{	public StyleAsset StyleOff; // 0x30
	public Image Handle; // 0x38
	public RustText TextOn; // 0x40
	public RustText TextOff; // 0x48
	public bool Value; // 0x50
	public float SliderWidth; // 0x54
	public RustToggle.ChangedEvent OnChanged; // 0x58
	private Coroutine anim; // 0x60

	public override StyleAsset Styles { get; }


	public override StyleAsset get_Styles() { }

	public void SetValue(bool value) { }

	public void OnPointerDown(PointerEventData eventData) { }

	[IteratorStateMachineAttribute] // RVA: 0x72400 Offset: 0x71800 VA: 0x180072400
	private IEnumerator AnimateTo() { }

	public override void ApplyStyles() { }

	public void .ctor() { }

}

public class RustToggle.ChangedEvent : UnityEvent<bool> // TypeDefIndex: 7035
{
	public void .ctor() { }

}

private sealed class RustToggle.<AnimateTo>d__13 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 7036
{	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public RustToggle <>4__this; // 0x20
	private Vector2 <handleMin>5__2; // 0x28
	private Vector2 <handleMax>5__3; // 0x30
	private float <animTime>5__4; // 0x38
	private float <time>5__5; // 0x3C
	private Image <bg>5__6; // 0x40

	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }


	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void System.IDisposable.Dispose() { }

	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private object System.Collections.IEnumerator.get_Current() { }

}

