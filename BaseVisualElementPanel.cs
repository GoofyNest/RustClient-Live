internal abstract class BaseVisualElementPanel : IPanel // TypeDefIndex: 4600
{
	private float m_PixelsPerPoint; 
	[DebuggerBrowsableAttribute] 
	[CompilerGeneratedAttribute] 
	private bool <duringLayoutPhase>k__BackingField; 
	[DebuggerBrowsableAttribute] 
	[CompilerGeneratedAttribute] 
	private RepaintData <repaintData>k__BackingField; 
	[CompilerGeneratedAttribute] 
	[DebuggerBrowsableAttribute] 
	private bool <disposed>k__BackingField; 
	internal ElementUnderPointer m_TopElementUnderPointers; 

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


	public abstract EventInterests get_IMGUIEventInterests();

	public abstract ScriptableObject get_ownerObject();

	public abstract int get_IMGUIContainersCount();

	public abstract IMGUIContainer get_rootIMGUIContainer();

	public abstract FocusController get_focusController();

	public void Dispose() { }

	protected virtual void Dispose(bool disposing) { }

	public abstract void Repaint(Event e);

	public abstract void ValidateLayout();

	internal void set_pixelsPerPoint(float value) { }

	[CompilerGeneratedAttribute] 
	internal bool get_duringLayoutPhase() { }

	internal abstract uint get_version();

	internal abstract void OnVersionChanged(VisualElement ele, VersionChangeType changeTypeFlag);

	[CompilerGeneratedAttribute] 
	internal virtual RepaintData get_repaintData() { }

	public abstract VisualElement get_visualTree();

	public abstract EventDispatcher get_dispatcher();

	internal void SendEvent(EventBase e, DispatchMode dispatchMode = 1) { }

	public abstract ContextType get_contextType();

	public abstract VisualElement Pick(Vector2 point);

	[CompilerGeneratedAttribute] 
	internal bool get_disposed() { }

	[CompilerGeneratedAttribute] 
	private void set_disposed(bool value) { }

	internal VisualElement GetTopElementUnderPointer(int pointerId) { }

	internal void SetElementUnderPointer(VisualElement newElementUnderPointer, EventBase triggerEvent) { }

	internal void ClearCachedElementUnderPointer(EventBase triggerEvent) { }

	internal void CommitElementUnderPointers() { }

}

