public class FocusController // TypeDefIndex: 4589
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x707F0 Offset: 0x6FBF0 VA: 0x1800707F0
	[DebuggerBrowsableAttribute] // RVA: 0x707F0 Offset: 0x6FBF0 VA: 0x1800707F0
	private readonly IFocusRing <focusRing>k__BackingField; // 0x10
	private List<FocusController.FocusedElement> m_FocusedElements; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x707F0 Offset: 0x6FBF0 VA: 0x1800707F0
	[DebuggerBrowsableAttribute] // RVA: 0x707F0 Offset: 0x6FBF0 VA: 0x1800707F0
	private int <imguiKeyboardControl>k__BackingField; // 0x20

	// Properties
	private IFocusRing focusRing { get; }
	internal int imguiKeyboardControl { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4B9460 Offset: 0x4B8860 VA: 0x1804B9460
	private IFocusRing get_focusRing() { }

	// RVA: 0xEC2BF0 Offset: 0xEC1FF0 VA: 0x180EC2BF0
	internal Focusable GetLeafFocusedElement() { }

	// RVA: 0xEC2A80 Offset: 0xEC1E80 VA: 0x180EC2A80
	internal void DoFocusChange(Focusable f) { }

	// RVA: 0xEC2980 Offset: 0xEC1D80 VA: 0x180EC2980
	private void AboutToReleaseFocus(Focusable focusable, Focusable willGiveFocusTo, FocusChangeDirection direction) { }

	// RVA: 0xEC2D50 Offset: 0xEC2150 VA: 0x180EC2D50
	private void ReleaseFocus(Focusable focusable, Focusable willGiveFocusTo, FocusChangeDirection direction) { }

	// RVA: 0xEC2880 Offset: 0xEC1C80 VA: 0x180EC2880
	private void AboutToGrabFocus(Focusable focusable, Focusable willTakeFocusFrom, FocusChangeDirection direction) { }

	// RVA: 0xEC2C50 Offset: 0xEC2050 VA: 0x180EC2C50
	private void GrabFocus(Focusable focusable, Focusable willTakeFocusFrom, FocusChangeDirection direction) { }

	// RVA: 0xEC3120 Offset: 0xEC2520 VA: 0x180EC3120
	private void SwitchFocus(Focusable newFocusedElement, FocusChangeDirection direction) { }

	// RVA: 0xEC2E50 Offset: 0xEC2250 VA: 0x180EC2E50
	internal Focusable SwitchFocusOnEvent(EventBase e) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4D0170 Offset: 0x4CF570 VA: 0x1804D0170
	internal int get_imguiKeyboardControl() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x69CC40 Offset: 0x69C040 VA: 0x18069CC40
	internal void set_imguiKeyboardControl(int value) { }

	// RVA: 0xEC33F0 Offset: 0xEC27F0 VA: 0x180EC33F0
	internal void SyncIMGUIFocus(int imguiKeyboardControlID, Focusable imguiContainerHavingKeyboardControl, bool forceSwitch) { }

}

private struct FocusController.FocusedElement // TypeDefIndex: 4590
{	// Fields
	public VisualElement m_SubTreeRoot; // 0x0
	public Focusable m_FocusedElement; // 0x8

}

