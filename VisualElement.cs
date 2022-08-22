public class VisualElement : Focusable, ITransform, IResolvedStyle // TypeDefIndex: 4613
{	[DebuggerBrowsableAttribute] // RVA: 0x70650 Offset: 0x6FA50 VA: 0x180070650
	[CompilerGeneratedAttribute] // RVA: 0x70650 Offset: 0x6FA50 VA: 0x180070650
	private bool <isCompositeRoot>k__BackingField; // 0x20
	private static List<string> s_EmptyClassList; // 0x0
	internal static readonly PropertyName userDataPropertyKey; // 0x8
	public static readonly string disabledUssClassName; // 0x10
	private Vector3 m_Position; // 0x24
	private Quaternion m_Rotation; // 0x30
	private Vector3 m_Scale; // 0x40
	[CompilerGeneratedAttribute] // RVA: 0x707F0 Offset: 0x6FBF0 VA: 0x1800707F0
	[DebuggerBrowsableAttribute] // RVA: 0x707F0 Offset: 0x6FBF0 VA: 0x1800707F0
	private bool <isLayoutManual>k__BackingField; // 0x4C
	private Rect m_Layout; // 0x50
	internal bool isBoundingBoxDirty; // 0x60
	private Rect m_BoundingBox; // 0x64
	internal bool isWorldBoundingBoxDirty; // 0x74
	private Rect m_WorldBoundingBox; // 0x78
	[DebuggerBrowsableAttribute] // RVA: 0x70650 Offset: 0x6FA50 VA: 0x180070650
	[CompilerGeneratedAttribute] // RVA: 0x70650 Offset: 0x6FA50 VA: 0x180070650
	private bool <isWorldTransformDirty>k__BackingField; // 0x88
	[DebuggerBrowsableAttribute] // RVA: 0x70650 Offset: 0x6FA50 VA: 0x180070650
	[CompilerGeneratedAttribute] // RVA: 0x70650 Offset: 0x6FA50 VA: 0x180070650
	private bool <isWorldTransformInverseDirty>k__BackingField; // 0x89
	private Matrix4x4 m_WorldTransformCache; // 0x8C
	private Matrix4x4 m_WorldTransformInverseCache; // 0xCC
	private static readonly Rect s_InfiniteRect; // 0x18
	private PseudoStates m_PseudoStates; // 0x10C
	[DebuggerBrowsableAttribute] // RVA: 0x70650 Offset: 0x6FA50 VA: 0x180070650
	[CompilerGeneratedAttribute] // RVA: 0x70650 Offset: 0x6FA50 VA: 0x180070650
	private PickingMode <pickingMode>k__BackingField; // 0x110
	[CompilerGeneratedAttribute] // RVA: 0x707F0 Offset: 0x6FBF0 VA: 0x1800707F0
	[DebuggerBrowsableAttribute] // RVA: 0x707F0 Offset: 0x6FBF0 VA: 0x1800707F0
	private YogaNode <yogaNode>k__BackingField; // 0x118
	internal VisualElementStylesData m_Style; // 0x120
	private InheritedStylesData m_InheritedStylesData; // 0x128
	[CompilerGeneratedAttribute] // RVA: 0x707F0 Offset: 0x6FBF0 VA: 0x1800707F0
	[DebuggerBrowsableAttribute] // RVA: 0x707F0 Offset: 0x6FBF0 VA: 0x1800707F0
	private ComputedStyle <computedStyle>k__BackingField; // 0x130
	internal int imguiContainerDescendantCount; // 0x138
	[DebuggerBrowsableAttribute] // RVA: 0x70650 Offset: 0x6FA50 VA: 0x180070650
	[CompilerGeneratedAttribute] // RVA: 0x70650 Offset: 0x6FA50 VA: 0x180070650
	private VisualElement.Hierarchy <hierarchy>k__BackingField; // 0x140
	private VisualElement m_PhysicalParent; // 0x148
	private static readonly List<VisualElement> s_EmptyList; // 0x28
	private List<VisualElement> m_Children; // 0x150
	[CompilerGeneratedAttribute] // RVA: 0x707F0 Offset: 0x6FBF0 VA: 0x1800707F0
	[DebuggerBrowsableAttribute] // RVA: 0x707F0 Offset: 0x6FBF0 VA: 0x1800707F0
	private BaseVisualElementPanel <elementPanel>k__BackingField; // 0x158

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


	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	internal bool get_isCompositeRoot() { }

	public override FocusController get_focusController() { }

	public ITransform get_transform() { }

	private Matrix4x4 UnityEngine.UIElements.ITransform.get_matrix() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
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

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	internal bool get_isWorldTransformDirty() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	internal void set_isWorldTransformDirty(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	internal bool get_isWorldTransformInverseDirty() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	internal void set_isWorldTransformInverseDirty(bool value) { }

	public Matrix4x4 get_worldTransform() { }

	internal Matrix4x4 get_worldTransformInverse() { }

	private void UpdateWorldTransform() { }

	internal PseudoStates get_pseudoStates() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public PickingMode get_pickingMode() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	internal YogaNode get_yogaNode() { }

	internal VisualElementStylesData get_specifiedStyle() { }

	internal InheritedStylesData get_inheritedStyle() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	internal ComputedStyle get_computedStyle() { }

	public sealed override void SendEvent(EventBase e) { }

	internal void IncrementVersion(VersionChangeType changeType) { }

	public bool get_enabledInHierarchy() { }

	public bool get_visible() { }

	public virtual bool ContainsPoint(Vector2 localPoint) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public VisualElement.Hierarchy get_hierarchy() { }

	internal bool ShouldClip() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	internal BaseVisualElementPanel get_elementPanel() { }

	public IPanel get_panel() { }

	internal VisualElement RetargetElement(VisualElement retargetAgainst) { }

	public IResolvedStyle get_resolvedStyle() { }

	private Visibility UnityEngine.UIElements.IResolvedStyle.get_visibility() { }

	private DisplayStyle UnityEngine.UIElements.IResolvedStyle.get_display() { }

	private static void .cctor() { }

}

public struct VisualElement.Hierarchy // TypeDefIndex: 4614
{	private readonly VisualElement m_Owner; // 0x0

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

