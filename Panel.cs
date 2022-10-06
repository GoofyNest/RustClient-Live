internal class Panel : BaseVisualElementPanel // TypeDefIndex: 4604
{
	private VisualElement m_RootContainer; 
	private VisualTreeUpdater m_VisualTreeUpdater; 
	private uint m_Version; 
	private uint m_RepaintVersion; 
	private ProfilerMarker m_MarkerUpdate; 
	private static ProfilerMarker s_MarkerPickAll; 
	[CompilerGeneratedAttribute] 
	[DebuggerBrowsableAttribute] 
	private EventDispatcher <dispatcher>k__BackingField; 
	[CompilerGeneratedAttribute] 
	[DebuggerBrowsableAttribute] 
	private ScriptableObject <ownerObject>k__BackingField; 
	[DebuggerBrowsableAttribute] 
	[CompilerGeneratedAttribute] 
	private ContextType <contextType>k__BackingField; 
	[DebuggerBrowsableAttribute] 
	[CompilerGeneratedAttribute] 
	private FocusController <focusController>k__BackingField; 
	[DebuggerBrowsableAttribute] 
	[CompilerGeneratedAttribute] 
	private EventInterests <IMGUIEventInterests>k__BackingField; 
	[CompilerGeneratedAttribute] 
	[DebuggerBrowsableAttribute] 
	private int <IMGUIContainersCount>k__BackingField; 
	[CompilerGeneratedAttribute] 
	[DebuggerBrowsableAttribute] 
	private IMGUIContainer <rootIMGUIContainer>k__BackingField; 
	private bool m_ValidatingLayout; 

	public override VisualElement visualTree { get; }
	public override EventDispatcher dispatcher { get; }
	public override ScriptableObject ownerObject { get; }
	public override ContextType contextType { get; }
	public override FocusController focusController { get; }
	public override EventInterests IMGUIEventInterests { get; }
	public override int IMGUIContainersCount { get; }
	public override IMGUIContainer rootIMGUIContainer { get; }
	internal override uint version { get; }


	public override VisualElement get_visualTree() { }

	[CompilerGeneratedAttribute] 
	public override EventDispatcher get_dispatcher() { }

	[CompilerGeneratedAttribute] 
	public override ScriptableObject get_ownerObject() { }

	[CompilerGeneratedAttribute] 
	public override ContextType get_contextType() { }

	[CompilerGeneratedAttribute] 
	public override FocusController get_focusController() { }

	[CompilerGeneratedAttribute] 
	public override EventInterests get_IMGUIEventInterests() { }

	[CompilerGeneratedAttribute] 
	public override int get_IMGUIContainersCount() { }

	[CompilerGeneratedAttribute] 
	public override IMGUIContainer get_rootIMGUIContainer() { }

	internal override uint get_version() { }

	private static VisualElement PickAll(VisualElement root, Vector2 point, List<VisualElement> picked) { }

	private static VisualElement PerformPick(VisualElement root, Vector2 point, List<VisualElement> picked) { }

	public override VisualElement Pick(Vector2 point) { }

	public override void ValidateLayout() { }

	private void UpdateForRepaint() { }

	public override void Repaint(Event e) { }

	internal override void OnVersionChanged(VisualElement ve, VersionChangeType versionChangeType) { }

	private static void .cctor() { }

}

