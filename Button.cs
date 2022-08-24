public class Button : Selectable, IPointerClickHandler, IEventSystemHandler, ISubmitHandler // TypeDefIndex: 4905
{
	[FormerlySerializedAsAttribute] 
	[SerializeField] 
	private Button.ButtonClickedEvent m_OnClick; 

	public Button.ButtonClickedEvent onClick { get; set; }


	protected void .ctor() { }

	public Button.ButtonClickedEvent get_onClick() { }

	public void set_onClick(Button.ButtonClickedEvent value) { }

	private void Press() { }

	public virtual void OnPointerClick(PointerEventData eventData) { }

	public virtual void OnSubmit(BaseEventData eventData) { }

	[IteratorStateMachineAttribute] 
	private IEnumerator OnFinishSubmit() { }

}

public class Button.ButtonClickedEvent : UnityEvent // TypeDefIndex: 4906
{

	public void .ctor() { }

}

private sealed class Button.<OnFinishSubmit>d__9 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 4907
{
	private int <>1__state; 
	private object <>2__current; 
	public Button <>4__this; 
	private float <fadeTime>5__2; 
	private float <elapsedTime>5__3; 

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

public enum BUTTON // TypeDefIndex: 10100
{
	public int value__; 
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

