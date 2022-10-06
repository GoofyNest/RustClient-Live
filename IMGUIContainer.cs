public class IMGUIContainer : VisualElement // TypeDefIndex: 4594
{
	private Action m_OnGUIHandler; 
	private ObjectGUIState m_ObjectGUIState; 
	internal bool useOwnerObjectGUIState; 
	[DebuggerBrowsableAttribute] 
	[CompilerGeneratedAttribute] 
	private Rect <lastWorldClip>k__BackingField; 
	private GUILayoutUtility.LayoutCache m_Cache; 
	private Rect m_CachedClippingRect; 
	private Matrix4x4 m_CachedTransform; 
	[DebuggerBrowsableAttribute] 
	[CompilerGeneratedAttribute] 
	private ContextType <contextType>k__BackingField; 
	private bool lostFocus; 
	private bool receivedFocus; 
	private FocusChangeDirection focusChangeDirection; 
	private bool hasFocusableControls; 
	private int newKeyboardFocusControlID; 
	[CompilerGeneratedAttribute] 
	[DebuggerBrowsableAttribute] 
	private bool <focusOnlyIfHasFocusableControls>k__BackingField; 
	public static readonly string ussClassName; 
	private IMGUIContainer.GUIGlobals m_GUIGlobals; 

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

	[CompilerGeneratedAttribute] 
	internal Rect get_lastWorldClip() { }

	private GUILayoutUtility.LayoutCache get_cache() { }

	private float get_layoutMeasuredWidth() { }

	private float get_layoutMeasuredHeight() { }

	[CompilerGeneratedAttribute] 
	public ContextType get_contextType() { }

	[CompilerGeneratedAttribute] 
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

private struct IMGUIContainer.GUIGlobals // TypeDefIndex: 4595
{
	public Matrix4x4 matrix; 
	public Color color; 
	public Color contentColor; 
	public Color backgroundColor; 
	public bool enabled; 
	public bool changed; 
	public int displayIndex; 

}

