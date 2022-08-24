public abstract class Focusable : CallbackEventHandler // TypeDefIndex: 4586
{
	[DebuggerBrowsableAttribute] 
	[CompilerGeneratedAttribute] 
	private bool <focusable>k__BackingField; 
	internal bool isIMGUIContainer; 

	public abstract FocusController focusController { get; }
	public bool focusable { get; }
	public virtual bool canGrabFocus { get; }


	public abstract FocusController get_focusController();

	[CompilerGeneratedAttribute] 
	public bool get_focusable() { }

	public virtual bool get_canGrabFocus() { }

}

