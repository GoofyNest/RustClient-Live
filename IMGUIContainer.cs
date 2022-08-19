public class IMGUIContainer : VisualElement // TypeDefIndex: 4591
{	// Fields
	private Action m_OnGUIHandler; // 0x160
	private ObjectGUIState m_ObjectGUIState; // 0x168
	internal bool useOwnerObjectGUIState; // 0x170
	[DebuggerBrowsableAttribute] // RVA: 0x70650 Offset: 0x6FA50 VA: 0x180070650
	[CompilerGeneratedAttribute] // RVA: 0x70650 Offset: 0x6FA50 VA: 0x180070650
	private Rect <lastWorldClip>k__BackingField; // 0x174
	private GUILayoutUtility.LayoutCache m_Cache; // 0x188
	private Rect m_CachedClippingRect; // 0x190
	private Matrix4x4 m_CachedTransform; // 0x1A0
	[DebuggerBrowsableAttribute] // RVA: 0x70650 Offset: 0x6FA50 VA: 0x180070650
	[CompilerGeneratedAttribute] // RVA: 0x70650 Offset: 0x6FA50 VA: 0x180070650
	private ContextType <contextType>k__BackingField; // 0x1E0
	private bool lostFocus; // 0x1E4
	private bool receivedFocus; // 0x1E5
	private FocusChangeDirection focusChangeDirection; // 0x1E8
	private bool hasFocusableControls; // 0x1F0
	private int newKeyboardFocusControlID; // 0x1F4
	[CompilerGeneratedAttribute] // RVA: 0x707F0 Offset: 0x6FBF0 VA: 0x1800707F0
	[DebuggerBrowsableAttribute] // RVA: 0x707F0 Offset: 0x6FBF0 VA: 0x1800707F0
	private bool <focusOnlyIfHasFocusableControls>k__BackingField; // 0x1F8
	public static readonly string ussClassName; // 0x0
	private IMGUIContainer.GUIGlobals m_GUIGlobals; // 0x1FC

	// Properties
	public Action onGUIHandler { get; }
	internal ObjectGUIState guiState { get; }
	internal Rect lastWorldClip { get; }
	private GUILayoutUtility.LayoutCache cache { get; }
	private float layoutMeasuredWidth { get; }
	private float layoutMeasuredHeight { get; }
	public ContextType contextType { get; }
	internal bool focusOnlyIfHasFocusableControls { get; }

	// Methods

	// RVA: 0xEC55B0 Offset: 0xEC49B0 VA: 0x180EC55B0
	public Action get_onGUIHandler() { }

	// RVA: 0xEC53D0 Offset: 0xEC47D0 VA: 0x180EC53D0
	internal ObjectGUIState get_guiState() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xEC5480 Offset: 0xEC4880 VA: 0x180EC5480
	internal Rect get_lastWorldClip() { }

	// RVA: 0xEC5340 Offset: 0xEC4740 VA: 0x180EC5340
	private GUILayoutUtility.LayoutCache get_cache() { }

	// RVA: 0xEC5520 Offset: 0xEC4920 VA: 0x180EC5520
	private float get_layoutMeasuredWidth() { }

	// RVA: 0xEC5490 Offset: 0xEC4890 VA: 0x180EC5490
	private float get_layoutMeasuredHeight() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xEC53C0 Offset: 0xEC47C0 VA: 0x180EC53C0
	public ContextType get_contextType() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xDAEF80 Offset: 0xDAE380 VA: 0x180DAEF80
	internal bool get_focusOnlyIfHasFocusableControls() { }

	// RVA: 0xEC50F0 Offset: 0xEC44F0 VA: 0x180EC50F0
	private void SaveGlobals() { }

	// RVA: 0xEC4FA0 Offset: 0xEC43A0 VA: 0x180EC4FA0
	private void RestoreGlobals() { }

	// RVA: 0xEC3730 Offset: 0xEC2B30 VA: 0x180EC3730
	private void DoOnGUI(Event evt, Matrix4x4 parentTransform, Rect clippingRect, bool isComputingLayout, Rect layoutSize, Action onGUIHandler, bool canAffectFocus = True) { }

	// RVA: 0xEC4F70 Offset: 0xEC4370 VA: 0x180EC4F70
	public void MarkDirtyLayout() { }

	// RVA: 0xEC5200 Offset: 0xEC4600 VA: 0x180EC5200
	internal bool SendEventToIMGUI(EventBase evt, bool canAffectFocus = True) { }

	// RVA: 0xEC4E60 Offset: 0xEC4260 VA: 0x180EC4E60
	internal bool HandleIMGUIEvent(Event e, bool canAffectFocus) { }

	// RVA: 0xEC4910 Offset: 0xEC3D10 VA: 0x180EC4910
	internal bool HandleIMGUIEvent(Event e, Action onGUIHandler, bool canAffectFocus) { }

	// RVA: 0xEC4A20 Offset: 0xEC3E20 VA: 0x180EC4A20
	private bool HandleIMGUIEvent(Event e, Matrix4x4 worldTransform, Rect clippingRect, Action onGUIHandler, bool canAffectFocus) { }

	// RVA: 0xEC4570 Offset: 0xEC3970 VA: 0x180EC4570
	private static void GetCurrentTransformAndClip(IMGUIContainer container, Event evt, out Matrix4x4 transform, out Rect clipRect) { }

	// RVA: 0xEC5300 Offset: 0xEC4700 VA: 0x180EC5300
	private static void .cctor() { }

}

private struct IMGUIContainer.GUIGlobals // TypeDefIndex: 4592
{	// Fields
	public Matrix4x4 matrix; // 0x0
	public Color color; // 0x40
	public Color contentColor; // 0x50
	public Color backgroundColor; // 0x60
	public bool enabled; // 0x70
	public bool changed; // 0x71
	public int displayIndex; // 0x74

}

