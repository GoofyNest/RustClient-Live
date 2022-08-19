public abstract class Focusable : CallbackEventHandler // TypeDefIndex: 4586
{	// Fields
	[DebuggerBrowsableAttribute] // RVA: 0x70650 Offset: 0x6FA50 VA: 0x180070650
	[CompilerGeneratedAttribute] // RVA: 0x70650 Offset: 0x6FA50 VA: 0x180070650
	private bool <focusable>k__BackingField; // 0x18
	internal bool isIMGUIContainer; // 0x19

	// Properties
	public abstract FocusController focusController { get; }
	public bool focusable { get; }
	public virtual bool canGrabFocus { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 12
	public abstract FocusController get_focusController();

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x95B2D0 Offset: 0x95A6D0 VA: 0x18095B2D0
	public bool get_focusable() { }

	// RVA: 0x95B2D0 Offset: 0x95A6D0 VA: 0x18095B2D0 Slot: 13
	public virtual bool get_canGrabFocus() { }

}

