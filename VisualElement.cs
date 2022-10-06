public class VisualElement : Focusable, ITransform, IResolvedStyle // TypeDefIndex: 4616
{
	[DebuggerBrowsableAttribute] 
	[CompilerGeneratedAttribute] 
	private bool <isCompositeRoot>k__BackingField; 
	private static List<string> s_EmptyClassList; 
	internal static readonly PropertyName userDataPropertyKey; 
	public static readonly string disabledUssClassName; 
	private Vector3 m_Position; 
	private Quaternion m_Rotation; 
	private Vector3 m_Scale; 
	[CompilerGeneratedAttribute] 
	[DebuggerBrowsableAttribute] 
	private bool <isLayoutManual>k__BackingField; 
	private Rect m_Layout; 
	internal bool isBoundingBoxDirty; 
	private Rect m_BoundingBox; 
	internal bool isWorldBoundingBoxDirty; 
	private Rect m_WorldBoundingBox; 
	[DebuggerBrowsableAttribute] 
	[CompilerGeneratedAttribute] 
	private bool <isWorldTransformDirty>k__BackingField; 
	[DebuggerBrowsableAttribute] 
	[CompilerGeneratedAttribute] 
	private bool <isWorldTransformInverseDirty>k__BackingField; 
	private Matrix4x4 m_WorldTransformCache; 
	private Matrix4x4 m_WorldTransformInverseCache; 
	private static readonly Rect s_InfiniteRect; 
	private PseudoStates m_PseudoStates; 
	[DebuggerBrowsableAttribute] 
	[CompilerGeneratedAttribute] 
	private PickingMode <pickingMode>k__BackingField; 
	[CompilerGeneratedAttribute] 
	[DebuggerBrowsableAttribute] 
	private YogaNode <yogaNode>k__BackingField; 
	internal VisualElementStylesData m_Style; 
	private InheritedStylesData m_InheritedStylesData; 
	[CompilerGeneratedAttribute] 
	[DebuggerBrowsableAttribute] 
	private ComputedStyle <computedStyle>k__BackingField; 
	internal int imguiContainerDescendantCount; 
	[DebuggerBrowsableAttribute] 
	[CompilerGeneratedAttribute] 
	private VisualElement.Hierarchy <hierarchy>k__BackingField; 
	private VisualElement m_PhysicalParent; 
	private static readonly List<VisualElement> s_EmptyList; 
	private List<VisualElement> m_Children; 
	[CompilerGeneratedAttribute] 
	[DebuggerBrowsableAttribute] 
	private BaseVisualElementPanel <elementPanel>k__BackingField; 

	internal bool isCompositeRoot { get; }
	public override FocusController focusController { get; }
	public ITransform transform { get; }
	private Matrix4x4 UnityEngine.UIElements.ITransform.matrix { get; }
	internal bool isLayoutManual { get; }
	public Rect layout { get; }
	internal Rect boundingBox { get; }
	internal Rect worldBoundingBox { get; }
	public Rect worldBound { get; }
	internal Rect rect { get; }
	internal bool isWorldTransformDirty { get; set; }
	internal bool isWorldTransformInverseDirty { get; set; }
	public Matrix4x4 worldTransform { get; }
	internal Matrix4x4 worldTransformInverse { get; }
	internal PseudoStates pseudoStates { get; }
	public PickingMode pickingMode { get; }
	internal YogaNode yogaNode { get; }
	internal VisualElementStylesData specifiedStyle { get; }
	internal InheritedStylesData inheritedStyle { get; }
	internal ComputedStyle computedStyle { get; }
	public bool enabledInHierarchy { get; }
	public bool visible { get; }
	public VisualElement.Hierarchy hierarchy { get; }
	internal BaseVisualElementPanel elementPanel { get; }
	public IPanel panel { get; }
	public IResolvedStyle resolvedStyle { get; }
	private Visibility UnityEngine.UIElements.IResolvedStyle.visibility { get; }
	private DisplayStyle UnityEngine.UIElements.IResolvedStyle.display { get; }


	[CompilerGeneratedAttribute] 
	internal bool get_isCompositeRoot() { }

	public override FocusController get_focusController() { }

	public ITransform get_transform() { }

	private Matrix4x4 UnityEngine.UIElements.ITransform.get_matrix() { }

	[CompilerGeneratedAttribute] 
	internal bool get_isLayoutManual() { }

	public Rect get_layout() { }

	internal static Rect TransformAlignedRect(Matrix4x4 lhc, Rect rect) { }

	internal static Vector2 MultiplyMatrix44Point2(Matrix4x4 lhs, Vector2 point) { }

	internal Rect get_boundingBox() { }

	internal Rect get_worldBoundingBox() { }

	internal void UpdateBoundingBox() { }

	internal void UpdateWorldBoundingBox() { }

	public Rect get_worldBound() { }

	internal Rect get_rect() { }

	[CompilerGeneratedAttribute] 
	internal bool get_isWorldTransformDirty() { }

	[CompilerGeneratedAttribute] 
	internal void set_isWorldTransformDirty(bool value) { }

	[CompilerGeneratedAttribute] 
	internal bool get_isWorldTransformInverseDirty() { }

	[CompilerGeneratedAttribute] 
	internal void set_isWorldTransformInverseDirty(bool value) { }

	public Matrix4x4 get_worldTransform() { }

	internal Matrix4x4 get_worldTransformInverse() { }

	private void UpdateWorldTransform() { }

	internal PseudoStates get_pseudoStates() { }

	[CompilerGeneratedAttribute] 
	public PickingMode get_pickingMode() { }

	[CompilerGeneratedAttribute] 
	internal YogaNode get_yogaNode() { }

	internal VisualElementStylesData get_specifiedStyle() { }

	internal InheritedStylesData get_inheritedStyle() { }

	[CompilerGeneratedAttribute] 
	internal ComputedStyle get_computedStyle() { }

	public sealed override void SendEvent(EventBase e) { }

	internal void IncrementVersion(VersionChangeType changeType) { }

	public bool get_enabledInHierarchy() { }

	public bool get_visible() { }

	public virtual bool ContainsPoint(Vector2 localPoint) { }

	[CompilerGeneratedAttribute] 
	public VisualElement.Hierarchy get_hierarchy() { }

	internal bool ShouldClip() { }

	[CompilerGeneratedAttribute] 
	internal BaseVisualElementPanel get_elementPanel() { }

	public IPanel get_panel() { }

	internal VisualElement RetargetElement(VisualElement retargetAgainst) { }

	public IResolvedStyle get_resolvedStyle() { }

	private Visibility UnityEngine.UIElements.IResolvedStyle.get_visibility() { }

	private DisplayStyle UnityEngine.UIElements.IResolvedStyle.get_display() { }

	private static void .cctor() { }

}

public struct VisualElement.Hierarchy // TypeDefIndex: 4617
{
	private readonly VisualElement m_Owner; 

	public VisualElement parent { get; }
	public int childCount { get; }
	public VisualElement Item { get; }


	public VisualElement get_parent() { }

	public int get_childCount() { }

	public VisualElement get_Item(int key) { }

	public bool Equals(VisualElement.Hierarchy other) { }

	public override bool Equals(object obj) { }

	public override int GetHashCode() { }

	public static bool op_Equality(VisualElement.Hierarchy x, VisualElement.Hierarchy y) { }

}

