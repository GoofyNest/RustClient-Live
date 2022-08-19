internal abstract class BaseVisualElementPanel : IPanel // TypeDefIndex: 4600
{	// Fields
	private float m_PixelsPerPoint; // 0x10
	[DebuggerBrowsableAttribute] // RVA: 0x70650 Offset: 0x6FA50 VA: 0x180070650
	[CompilerGeneratedAttribute] // RVA: 0x70650 Offset: 0x6FA50 VA: 0x180070650
	private bool <duringLayoutPhase>k__BackingField; // 0x14
	[DebuggerBrowsableAttribute] // RVA: 0x70650 Offset: 0x6FA50 VA: 0x180070650
	[CompilerGeneratedAttribute] // RVA: 0x70650 Offset: 0x6FA50 VA: 0x180070650
	private RepaintData <repaintData>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x707F0 Offset: 0x6FBF0 VA: 0x1800707F0
	[DebuggerBrowsableAttribute] // RVA: 0x707F0 Offset: 0x6FBF0 VA: 0x1800707F0
	private bool <disposed>k__BackingField; // 0x20
	internal ElementUnderPointer m_TopElementUnderPointers; // 0x28

	// Properties
	public abstract EventInterests IMGUIEventInterests { get; }
	public abstract ScriptableObject ownerObject { get; }
	public abstract int IMGUIContainersCount { get; }
	public abstract IMGUIContainer rootIMGUIContainer { get; }
	public abstract FocusController focusController { get; }
	internal float pixelsPerPoint { set; }
	internal bool duringLayoutPhase { get; }
	internal abstract uint version { get; }
	internal virtual RepaintData repaintData { get; }
	public abstract VisualElement visualTree { get; }
	public abstract EventDispatcher dispatcher { get; }
	public abstract ContextType contextType { get; }
	internal bool disposed { get; set; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 9
	public abstract EventInterests get_IMGUIEventInterests();

	// RVA: -1 Offset: -1 Slot: 10
	public abstract ScriptableObject get_ownerObject();

	// RVA: -1 Offset: -1 Slot: 11
	public abstract int get_IMGUIContainersCount();

	// RVA: -1 Offset: -1 Slot: 12
	public abstract IMGUIContainer get_rootIMGUIContainer();

	// RVA: -1 Offset: -1 Slot: 13
	public abstract FocusController get_focusController();

	// RVA: 0xEBC940 Offset: 0xEBBD40 VA: 0x180EBC940 Slot: 8
	public void Dispose() { }

	// RVA: 0xEBC7F0 Offset: 0xEBBBF0 VA: 0x180EBC7F0 Slot: 14
	protected virtual void Dispose(bool disposing) { }

	// RVA: -1 Offset: -1 Slot: 15
	public abstract void Repaint(Event e);

	// RVA: -1 Offset: -1 Slot: 16
	public abstract void ValidateLayout();

	// RVA: 0xEBCAE0 Offset: 0xEBBEE0 VA: 0x180EBCAE0
	internal void set_pixelsPerPoint(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x9EF9E0 Offset: 0x9EEDE0 VA: 0x1809EF9E0
	internal bool get_duringLayoutPhase() { }

	// RVA: -1 Offset: -1 Slot: 17
	internal abstract uint get_version();

	// RVA: -1 Offset: -1 Slot: 18
	internal abstract void OnVersionChanged(VisualElement ele, VersionChangeType changeTypeFlag);

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710 Slot: 19
	internal virtual RepaintData get_repaintData() { }

	// RVA: -1 Offset: -1 Slot: 20
	public abstract VisualElement get_visualTree();

	// RVA: -1 Offset: -1 Slot: 21
	public abstract EventDispatcher get_dispatcher();

	// RVA: 0xEBC9F0 Offset: 0xEBBDF0 VA: 0x180EBC9F0
	internal void SendEvent(EventBase e, DispatchMode dispatchMode = 1) { }

	// RVA: -1 Offset: -1 Slot: 22
	public abstract ContextType get_contextType();

	// RVA: -1 Offset: -1 Slot: 23
	public abstract VisualElement Pick(Vector2 point);

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xB0BB80 Offset: 0xB0AF80 VA: 0x180B0BB80
	internal bool get_disposed() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x7D99E0 Offset: 0x7D8DE0 VA: 0x1807D99E0
	private void set_disposed(bool value) { }

	// RVA: 0xEBC9B0 Offset: 0xEBBDB0 VA: 0x180EBC9B0
	internal VisualElement GetTopElementUnderPointer(int pointerId) { }

	// RVA: 0xEBCAB0 Offset: 0xEBBEB0 VA: 0x180EBCAB0
	internal void SetElementUnderPointer(VisualElement newElementUnderPointer, EventBase triggerEvent) { }

	// RVA: 0xEBC780 Offset: 0xEBBB80 VA: 0x180EBC780
	internal void ClearCachedElementUnderPointer(EventBase triggerEvent) { }

	// RVA: 0xEBC7B0 Offset: 0xEBBBB0 VA: 0x180EBC7B0
	internal void CommitElementUnderPointers() { }

}

