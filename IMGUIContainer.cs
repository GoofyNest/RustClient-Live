public class IMGUIContainer : VisualElement // TypeDefIndex: 4591
{	private Action m_OnGUIHandler; // 0x160
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

	public Action onGUIHandler { get; }
	internal ObjectGUIState guiState { get; }
	internal Rect lastWorldClip { get; }
	private GUILayoutUtility.LayoutCache cache { get; }
	private float layoutMeasuredWidth { get; }
	private float layoutMeasuredHeight { get; }
	public ContextType contextType { get; }
	internal bool focusOnlyIfHasFocusableControls { get; }


	public Action get_onGUIHandler() { }

	internal ObjectGUIState get_guiState() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	internal Rect get_lastWorldClip() { }

	private GUILayoutUtility.LayoutCache get_cache() { }

	private float get_layoutMeasuredWidth() { }

	private float get_layoutMeasuredHeight() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public ContextType get_contextType() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	internal bool get_focusOnlyIfHasFocusableControls() { }

	private void SaveGlobals() { }

	private void RestoreGlobals() { }

	private void DoOnGUI(Event evt, Matrix4x4 parentTransform, Rect clippingRect, bool isComputingLayout, Rect layoutSize, Action onGUIHandler, bool canAffectFocus = True) { }

	public void MarkDirtyLayout() { }

	internal bool SendEventToIMGUI(EventBase evt, bool canAffectFocus = True) { }

	internal bool HandleIMGUIEvent(Event e, bool canAffectFocus) { }

	internal bool HandleIMGUIEvent(Event e, Action onGUIHandler, bool canAffectFocus) { }

	private bool HandleIMGUIEvent(Event e, Matrix4x4 worldTransform, Rect clippingRect, Action onGUIHandler, bool canAffectFocus) { }

	private static void GetCurrentTransformAndClip(IMGUIContainer container, Event evt, out Matrix4x4 transform, out Rect clipRect) { }

	private static void .cctor() { }

}

private struct IMGUIContainer.GUIGlobals // TypeDefIndex: 4592
{	public Matrix4x4 matrix; // 0x0
	public Color color; // 0x40
	public Color contentColor; // 0x50
	public Color backgroundColor; // 0x60
	public bool enabled; // 0x70
	public bool changed; // 0x71
	public int displayIndex; // 0x74

}

