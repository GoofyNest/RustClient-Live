public class RectMask2D : UIBehaviour, IClipper, ICanvasRaycastFilter // TypeDefIndex: 4993
{	private readonly RectangularVertexClipper m_VertexClipper; // 0x18
	private RectTransform m_RectTransform; // 0x20
	private HashSet<MaskableGraphic> m_MaskableTargets; // 0x28
	private HashSet<IClippable> m_ClipTargets; // 0x30
	private bool m_ShouldRecalculateClipRects; // 0x38
	private List<RectMask2D> m_Clippers; // 0x40
	private Rect m_LastClipRectCanvasSpace; // 0x48
	private bool m_ForceClip; // 0x58
	private Canvas m_Canvas; // 0x60
	private Vector3[] m_Corners; // 0x68

	private Canvas Canvas { get; }
	public Rect canvasRect { get; }
	public RectTransform rectTransform { get; }
	private Rect rootCanvasRect { get; }


	private Canvas get_Canvas() { }

	public Rect get_canvasRect() { }

	public RectTransform get_rectTransform() { }

	protected void .ctor() { }

	protected override void OnEnable() { }

	protected override void OnDisable() { }

	public virtual bool IsRaycastLocationValid(Vector2 sp, Camera eventCamera) { }

	private Rect get_rootCanvasRect() { }

	public virtual void PerformClipping() { }

	public void AddClippable(IClippable clippable) { }

	public void RemoveClippable(IClippable clippable) { }

	protected override void OnTransformParentChanged() { }

	protected override void OnCanvasHierarchyChanged() { }

}

