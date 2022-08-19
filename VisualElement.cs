public class VisualElement : Focusable, ITransform, IResolvedStyle // TypeDefIndex: 4613
{	// Fields
	[DebuggerBrowsableAttribute] // RVA: 0x70650 Offset: 0x6FA50 VA: 0x180070650
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

	// Properties
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

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xB0BB80 Offset: 0xB0AF80 VA: 0x180B0BB80
	internal bool get_isCompositeRoot() { }

	// RVA: 0xED4B00 Offset: 0xED3F00 VA: 0x180ED4B00 Slot: 12
	public override FocusController get_focusController() { }

	// RVA: 0xED4D30 Offset: 0xED4130 VA: 0x180ED4D30
	public ITransform get_transform() { }

	// RVA: 0xED4010 Offset: 0xED3410 VA: 0x180ED4010 Slot: 14
	private Matrix4x4 UnityEngine.UIElements.ITransform.get_matrix() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xC1C200 Offset: 0xC1B600 VA: 0x180C1C200
	internal bool get_isLayoutManual() { }

	// RVA: 0xED4B70 Offset: 0xED3F70 VA: 0x180ED4B70
	public Rect get_layout() { }

	// RVA: 0xED3C40 Offset: 0xED3040 VA: 0x180ED3C40
	internal static Rect TransformAlignedRect(Matrix4x4 lhc, Rect rect) { }

	// RVA: 0xED3A40 Offset: 0xED2E40 VA: 0x180ED3A40
	internal static Vector2 MultiplyMatrix44Point2(Matrix4x4 lhs, Vector2 point) { }

	// RVA: 0xED4AB0 Offset: 0xED3EB0 VA: 0x180ED4AB0
	internal Rect get_boundingBox() { }

	// RVA: 0xED4F30 Offset: 0xED4330 VA: 0x180ED4F30
	internal Rect get_worldBoundingBox() { }

	// RVA: 0xED4120 Offset: 0xED3520 VA: 0x180ED4120
	internal void UpdateBoundingBox() { }

	// RVA: 0xED4500 Offset: 0xED3900 VA: 0x180ED4500
	internal void UpdateWorldBoundingBox() { }

	// RVA: 0xED4DA0 Offset: 0xED41A0 VA: 0x180ED4DA0
	public Rect get_worldBound() { }

	// RVA: 0xED4C80 Offset: 0xED4080 VA: 0x180ED4C80
	internal Rect get_rect() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x69CC20 Offset: 0x69C020 VA: 0x18069CC20
	internal bool get_isWorldTransformDirty() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x69CC30 Offset: 0x69C030 VA: 0x18069CC30
	internal void set_isWorldTransformDirty(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xED4B60 Offset: 0xED3F60 VA: 0x180ED4B60
	internal bool get_isWorldTransformInverseDirty() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xED5200 Offset: 0xED4600 VA: 0x180ED5200
	internal void set_isWorldTransformInverseDirty(bool value) { }

	// RVA: 0xED5190 Offset: 0xED4590 VA: 0x180ED5190
	public Matrix4x4 get_worldTransform() { }

	// RVA: 0xED5090 Offset: 0xED4490 VA: 0x180ED5090
	internal Matrix4x4 get_worldTransformInverse() { }

	// RVA: 0xED4610 Offset: 0xED3A10 VA: 0x180ED4610
	private void UpdateWorldTransform() { }

	// RVA: 0xED4C70 Offset: 0xED4070 VA: 0x180ED4C70
	internal PseudoStates get_pseudoStates() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xED4C60 Offset: 0xED4060 VA: 0x180ED4C60
	public PickingMode get_pickingMode() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xE610C0 Offset: 0xE604C0 VA: 0x180E610C0
	internal YogaNode get_yogaNode() { }

	// RVA: 0xED4D40 Offset: 0xED4140 VA: 0x180ED4D40
	internal VisualElementStylesData get_specifiedStyle() { }

	// RVA: 0xED4B50 Offset: 0xED3F50 VA: 0x180ED4B50
	internal InheritedStylesData get_inheritedStyle() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x71AF80 Offset: 0x71A380 VA: 0x18071AF80
	internal ComputedStyle get_computedStyle() { }

	// RVA: 0xED3B50 Offset: 0xED2F50 VA: 0x180ED3B50 Slot: 6
	public sealed override void SendEvent(EventBase e) { }

	// RVA: 0xED3A10 Offset: 0xED2E10 VA: 0x180ED3A10
	internal void IncrementVersion(VersionChangeType changeType) { }

	// RVA: 0xED4AF0 Offset: 0xED3EF0 VA: 0x180ED4AF0
	public bool get_enabledInHierarchy() { }

	// RVA: 0xED4D50 Offset: 0xED4150 VA: 0x180ED4D50
	public bool get_visible() { }

	// RVA: 0xED3940 Offset: 0xED2D40 VA: 0x180ED3940 Slot: 17
	public virtual bool ContainsPoint(Vector2 localPoint) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xD5C900 Offset: 0xD5BD00 VA: 0x180D5C900
	public VisualElement.Hierarchy get_hierarchy() { }

	// RVA: 0xED3B70 Offset: 0xED2F70 VA: 0x180ED3B70
	internal bool ShouldClip() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xC62810 Offset: 0xC61C10 VA: 0x180C62810
	internal BaseVisualElementPanel get_elementPanel() { }

	// RVA: 0xED4C50 Offset: 0xED4050 VA: 0x180ED4C50
	public IPanel get_panel() { }

	// RVA: 0xED3AB0 Offset: 0xED2EB0 VA: 0x180ED3AB0
	internal VisualElement RetargetElement(VisualElement retargetAgainst) { }

	// RVA: 0xED4D30 Offset: 0xED4130 VA: 0x180ED4D30
	public IResolvedStyle get_resolvedStyle() { }

	// RVA: 0xED3F10 Offset: 0xED3310 VA: 0x180ED3F10 Slot: 15
	private Visibility UnityEngine.UIElements.IResolvedStyle.get_visibility() { }

	// RVA: 0xED3E40 Offset: 0xED3240 VA: 0x180ED3E40 Slot: 16
	private DisplayStyle UnityEngine.UIElements.IResolvedStyle.get_display() { }

	// RVA: 0xED4970 Offset: 0xED3D70 VA: 0x180ED4970
	private static void .cctor() { }

}

public struct VisualElement.Hierarchy // TypeDefIndex: 4614
{	// Fields
	private readonly VisualElement m_Owner; // 0x0

	// Properties
	public VisualElement parent { get; }
	public int childCount { get; }
	public VisualElement Item { get; }

	// Methods

	// RVA: 0x23DFC0 Offset: 0x23D3C0 VA: 0x18023DFC0
	public VisualElement get_parent() { }

	// RVA: 0x23DF70 Offset: 0x23D370 VA: 0x18023DF70
	public int get_childCount() { }

	// RVA: 0x23DF00 Offset: 0x23D300 VA: 0x18023DF00
	public VisualElement get_Item(int key) { }

	// RVA: 0x23DE50 Offset: 0x23D250 VA: 0x18023DE50
	public bool Equals(VisualElement.Hierarchy other) { }

	// RVA: 0x23DE60 Offset: 0x23D260 VA: 0x18023DE60 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x139E30 Offset: 0x139230 VA: 0x180139E30 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x22F0BB0 Offset: 0x22EFFB0 VA: 0x1822F0BB0
	public static bool op_Equality(VisualElement.Hierarchy x, VisualElement.Hierarchy y) { }

}

