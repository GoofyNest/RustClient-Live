public class RectMask2D : UIBehaviour, IClipper, ICanvasRaycastFilter // TypeDefIndex: 4993
{	// Fields
	private readonly RectangularVertexClipper m_VertexClipper; // 0x18
	private RectTransform m_RectTransform; // 0x20
	private HashSet<MaskableGraphic> m_MaskableTargets; // 0x28
	private HashSet<IClippable> m_ClipTargets; // 0x30
	private bool m_ShouldRecalculateClipRects; // 0x38
	private List<RectMask2D> m_Clippers; // 0x40
	private Rect m_LastClipRectCanvasSpace; // 0x48
	private bool m_ForceClip; // 0x58
	private Canvas m_Canvas; // 0x60
	private Vector3[] m_Corners; // 0x68

	// Properties
	private Canvas Canvas { get; }
	public Rect canvasRect { get; }
	public RectTransform rectTransform { get; }
	private Rect rootCanvasRect { get; }

	// Methods

	// RVA: 0x17145E0 Offset: 0x17139E0 VA: 0x1817145E0
	private Canvas get_Canvas() { }

	// RVA: 0x1714720 Offset: 0x1713B20 VA: 0x181714720
	public Rect get_canvasRect() { }

	// RVA: 0x17147E0 Offset: 0x1713BE0 VA: 0x1817147E0
	public RectTransform get_rectTransform() { }

	// RVA: 0x1714470 Offset: 0x1713870 VA: 0x181714470
	protected void .ctor() { }

	// RVA: 0x1713A60 Offset: 0x1712E60 VA: 0x181713A60 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x17139D0 Offset: 0x1712DD0 VA: 0x1817139D0 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x17138A0 Offset: 0x1712CA0 VA: 0x1817138A0 Slot: 19
	public virtual bool IsRaycastLocationValid(Vector2 sp, Camera eventCamera) { }

	// RVA: 0x1714850 Offset: 0x1713C50 VA: 0x181714850
	private Rect get_rootCanvasRect() { }

	// RVA: 0x1713AB0 Offset: 0x1712EB0 VA: 0x181713AB0 Slot: 20
	public virtual void PerformClipping() { }

	// RVA: 0x17137B0 Offset: 0x1712BB0 VA: 0x1817137B0
	public void AddClippable(IClippable clippable) { }

	// RVA: 0x17142F0 Offset: 0x17136F0 VA: 0x1817142F0
	public void RemoveClippable(IClippable clippable) { }

	// RVA: 0x1713A90 Offset: 0x1712E90 VA: 0x181713A90 Slot: 12
	protected override void OnTransformParentChanged() { }

	// RVA: 0x17139A0 Offset: 0x1712DA0 VA: 0x1817139A0 Slot: 15
	protected override void OnCanvasHierarchyChanged() { }

}

