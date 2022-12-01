public class RectMask2D : UIBehaviour, IClipper, ICanvasRaycastFilter // TypeDefIndex: 4999
{
	private readonly RectangularVertexClipper m_VertexClipper;
	private RectTransform m_RectTransform;
	private HashSet<MaskableGraphic> m_MaskableTargets;
	private HashSet<IClippable> m_ClipTargets;
	private bool m_ShouldRecalculateClipRects;
	private List<RectMask2D> m_Clippers;
	private Rect m_LastClipRectCanvasSpace;
	private bool m_ForceClip;
	private Canvas m_Canvas;
	private Vector3[] m_Corners;

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

