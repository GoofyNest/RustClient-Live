public class FocusController // TypeDefIndex: 4589
{
	[CompilerGeneratedAttribute] 
	[DebuggerBrowsableAttribute] 
	private readonly IFocusRing <focusRing>k__BackingField; 
	private List<FocusController.FocusedElement> m_FocusedElements; 
	[CompilerGeneratedAttribute] 
	[DebuggerBrowsableAttribute] 
	private int <imguiKeyboardControl>k__BackingField; 

private IFocusRing focusRing { get; }
internal int imguiKeyboardControl { get; set; }


	[CompilerGeneratedAttribute] 
private IFocusRing get_focusRing() { }

internal Focusable GetLeafFocusedElement() { }

internal void DoFocusChange(Focusable f) { }

private void AboutToReleaseFocus(Focusable focusable, Focusable willGiveFocusTo, FocusChangeDirection direction) { }

private void ReleaseFocus(Focusable focusable, Focusable willGiveFocusTo, FocusChangeDirection direction) { }

private void AboutToGrabFocus(Focusable focusable, Focusable willTakeFocusFrom, FocusChangeDirection direction) { }

private void GrabFocus(Focusable focusable, Focusable willTakeFocusFrom, FocusChangeDirection direction) { }

private void SwitchFocus(Focusable newFocusedElement, FocusChangeDirection direction) { }

internal Focusable SwitchFocusOnEvent(EventBase e) { }

	[CompilerGeneratedAttribute] 
internal int get_imguiKeyboardControl() { }

	[CompilerGeneratedAttribute] 
internal void set_imguiKeyboardControl(int value) { }

internal void SyncIMGUIFocus(int imguiKeyboardControlID, Focusable imguiContainerHavingKeyboardControl, bool forceSwitch) { }

}

private struct FocusController.FocusedElement // TypeDefIndex: 4590
{
	public VisualElement m_SubTreeRoot; 
	public Focusable m_FocusedElement; 

}

