internal class Panel : BaseVisualElementPanel // TypeDefIndex: 4601
{	// Fields
	private VisualElement m_RootContainer; // 0x30
	private VisualTreeUpdater m_VisualTreeUpdater; // 0x38
	private uint m_Version; // 0x40
	private uint m_RepaintVersion; // 0x44
	private ProfilerMarker m_MarkerUpdate; // 0x48
	private static ProfilerMarker s_MarkerPickAll; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x707F0 Offset: 0x6FBF0 VA: 0x1800707F0
	[DebuggerBrowsableAttribute] // RVA: 0x707F0 Offset: 0x6FBF0 VA: 0x1800707F0
	private EventDispatcher <dispatcher>k__BackingField; // 0x50
	[CompilerGeneratedAttribute] // RVA: 0x707F0 Offset: 0x6FBF0 VA: 0x1800707F0
	[DebuggerBrowsableAttribute] // RVA: 0x707F0 Offset: 0x6FBF0 VA: 0x1800707F0
	private ScriptableObject <ownerObject>k__BackingField; // 0x58
	[DebuggerBrowsableAttribute] // RVA: 0x70650 Offset: 0x6FA50 VA: 0x180070650
	[CompilerGeneratedAttribute] // RVA: 0x70650 Offset: 0x6FA50 VA: 0x180070650
	private ContextType <contextType>k__BackingField; // 0x60
	[DebuggerBrowsableAttribute] // RVA: 0x70650 Offset: 0x6FA50 VA: 0x180070650
	[CompilerGeneratedAttribute] // RVA: 0x70650 Offset: 0x6FA50 VA: 0x180070650
	private FocusController <focusController>k__BackingField; // 0x68
	[DebuggerBrowsableAttribute] // RVA: 0x70650 Offset: 0x6FA50 VA: 0x180070650
	[CompilerGeneratedAttribute] // RVA: 0x70650 Offset: 0x6FA50 VA: 0x180070650
	private EventInterests <IMGUIEventInterests>k__BackingField; // 0x70
	[CompilerGeneratedAttribute] // RVA: 0x707F0 Offset: 0x6FBF0 VA: 0x1800707F0
	[DebuggerBrowsableAttribute] // RVA: 0x707F0 Offset: 0x6FBF0 VA: 0x1800707F0
	private int <IMGUIContainersCount>k__BackingField; // 0x74
	[CompilerGeneratedAttribute] // RVA: 0x707F0 Offset: 0x6FBF0 VA: 0x1800707F0
	[DebuggerBrowsableAttribute] // RVA: 0x707F0 Offset: 0x6FBF0 VA: 0x1800707F0
	private IMGUIContainer <rootIMGUIContainer>k__BackingField; // 0x78
	private bool m_ValidatingLayout; // 0x80

	// Properties
	public override VisualElement visualTree { get; }
	public override EventDispatcher dispatcher { get; }
	public override ScriptableObject ownerObject { get; }
	public override ContextType contextType { get; }
	public override FocusController focusController { get; }
	public override EventInterests IMGUIEventInterests { get; }
	public override int IMGUIContainersCount { get; }
	public override IMGUIContainer rootIMGUIContainer { get; }
	internal override uint version { get; }

	// Methods

	// RVA: 0xEC9460 Offset: 0xEC8860 VA: 0x180EC9460 Slot: 20
	public override VisualElement get_visualTree() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4CC350 Offset: 0x4CB750 VA: 0x1804CC350 Slot: 21
	public override EventDispatcher get_dispatcher() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4CC340 Offset: 0x4CB740 VA: 0x1804CC340 Slot: 10
	public override ScriptableObject get_ownerObject() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x58DC10 Offset: 0x58D010 VA: 0x18058DC10 Slot: 22
	public override ContextType get_contextType() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x5334F0 Offset: 0x5328F0 VA: 0x1805334F0 Slot: 13
	public override FocusController get_focusController() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xEC9440 Offset: 0xEC8840 VA: 0x180EC9440 Slot: 9
	public override EventInterests get_IMGUIEventInterests() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xB24340 Offset: 0xB23740 VA: 0x180B24340 Slot: 11
	public override int get_IMGUIContainersCount() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4E4EC0 Offset: 0x4E42C0 VA: 0x1804E4EC0 Slot: 12
	public override IMGUIContainer get_rootIMGUIContainer() { }

	// RVA: 0xEC9450 Offset: 0xEC8850 VA: 0x180EC9450 Slot: 17
	internal override uint get_version() { }

	// RVA: 0xEC8D90 Offset: 0xEC8190 VA: 0x180EC8D90
	private static VisualElement PickAll(VisualElement root, Vector2 point, List<VisualElement> picked) { }

	// RVA: 0xEC88C0 Offset: 0xEC7CC0 VA: 0x180EC88C0
	private static VisualElement PerformPick(VisualElement root, Vector2 point, List<VisualElement> picked) { }

	// RVA: 0xEC8E10 Offset: 0xEC8210 VA: 0x180EC8E10 Slot: 23
	public override VisualElement Pick(Vector2 point) { }

	// RVA: 0xEC9380 Offset: 0xEC8780 VA: 0x180EC9380 Slot: 16
	public override void ValidateLayout() { }

	// RVA: 0xEC9300 Offset: 0xEC8700 VA: 0x180EC9300
	private void UpdateForRepaint() { }

	// RVA: 0xEC9040 Offset: 0xEC8440 VA: 0x180EC9040 Slot: 15
	public override void Repaint(Event e) { }

	// RVA: 0xEC8890 Offset: 0xEC7C90 VA: 0x180EC8890 Slot: 18
	internal override void OnVersionChanged(VisualElement ve, VersionChangeType versionChangeType) { }

	// RVA: 0xEC93F0 Offset: 0xEC87F0 VA: 0x180EC93F0
	private static void .cctor() { }

}

