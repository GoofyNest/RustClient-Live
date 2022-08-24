public class RustToggle : RustControl, IPointerDownHandler, IEventSystemHandler // TypeDefIndex: 7034
{
	public StyleAsset StyleOff; 
	public Image Handle; 
	public RustText TextOn; 
	public RustText TextOff; 
	public bool Value; 
	public float SliderWidth; 
	public RustToggle.ChangedEvent OnChanged; 
	private Coroutine anim; 

	public override StyleAsset Styles { get; }


	public override StyleAsset get_Styles() { }

	public void SetValue(bool value) { }

	public void OnPointerDown(PointerEventData eventData) { }

	[IteratorStateMachineAttribute] 
	private IEnumerator AnimateTo() { }

	public override void ApplyStyles() { }

	public void .ctor() { }

}

public class RustToggle.ChangedEvent : UnityEvent<bool> // TypeDefIndex: 7035
{

	public void .ctor() { }

}

private sealed class RustToggle.<AnimateTo>d__13 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 7036
{
	private int <>1__state; 
	private object <>2__current; 
	public RustToggle <>4__this; 
	private Vector2 <handleMin>5__2; 
	private Vector2 <handleMax>5__3; 
	private float <animTime>5__4; 
	private float <time>5__5; 
	private Image <bg>5__6; 

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

