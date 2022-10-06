public class ScrollRect : UIBehaviour, IInitializePotentialDragHandler, IEventSystemHandler, IBeginDragHandler, IEndDragHandler, IDragHandler, IScrollHandler, ICanvasElement, ILayoutElement, ILayoutGroup, ILayoutController // TypeDefIndex: 4998
{
	[SerializeField] 
	private RectTransform m_Content; 
	[SerializeField] 
	private bool m_Horizontal; 
	[SerializeField] 
	private bool m_Vertical; 
	[SerializeField] 
	private ScrollRect.MovementType m_MovementType; 
	[SerializeField] 
	private float m_Elasticity; 
	[SerializeField] 
	private bool m_Inertia; 
	[SerializeField] 
	private float m_DecelerationRate; 
	[SerializeField] 
	private float m_ScrollSensitivity; 
	[SerializeField] 
	private RectTransform m_Viewport; 
	[SerializeField] 
	private Scrollbar m_HorizontalScrollbar; 
	[SerializeField] 
	private Scrollbar m_VerticalScrollbar; 
	[SerializeField] 
	private ScrollRect.ScrollbarVisibility m_HorizontalScrollbarVisibility; 
	[SerializeField] 
	private ScrollRect.ScrollbarVisibility m_VerticalScrollbarVisibility; 
	[SerializeField] 
	private float m_HorizontalScrollbarSpacing; 
	[SerializeField] 
	private float m_VerticalScrollbarSpacing; 
	[SerializeField] 
	private ScrollRect.ScrollRectEvent m_OnValueChanged; 
	private Vector2 m_PointerStartLocalCursor; 
	protected Vector2 m_ContentStartPosition; 
	private RectTransform m_ViewRect; 
	protected Bounds m_ContentBounds; 
	private Bounds m_ViewBounds; 
	private Vector2 m_Velocity; 
	private bool m_Dragging; 
	private bool m_Scrolling; 
	private Vector2 m_PrevPosition; 
	private Bounds m_PrevContentBounds; 
	private Bounds m_PrevViewBounds; 
	private bool m_HasRebuiltLayout; 
	private bool m_HSliderExpand; 
	private bool m_VSliderExpand; 
	private float m_HSliderHeight; 
	private float m_VSliderWidth; 
	private RectTransform m_Rect; 
	private RectTransform m_HorizontalScrollbarRect; 
	private RectTransform m_VerticalScrollbarRect; 
	private DrivenRectTransformTracker m_Tracker; 
	private readonly Vector3[] m_Corners; 

	public RectTransform content { get; set; }
	public bool horizontal { get; set; }
	public bool vertical { get; set; }
	public ScrollRect.MovementType movementType { get; set; }
	public float elasticity { get; set; }
	public bool inertia { get; set; }
	public float decelerationRate { get; set; }
	public float scrollSensitivity { get; set; }
	public RectTransform viewport { get; set; }
	public Scrollbar horizontalScrollbar { get; set; }
	public Scrollbar verticalScrollbar { get; set; }
	public ScrollRect.ScrollbarVisibility horizontalScrollbarVisibility { get; set; }
	public ScrollRect.ScrollbarVisibility verticalScrollbarVisibility { get; set; }
	public float horizontalScrollbarSpacing { get; set; }
	public float verticalScrollbarSpacing { get; set; }
	public ScrollRect.ScrollRectEvent onValueChanged { get; set; }
	protected RectTransform viewRect { get; }
	public Vector2 velocity { get; set; }
	private RectTransform rectTransform { get; }
	public Vector2 normalizedPosition { get; set; }
	public float horizontalNormalizedPosition { get; set; }
	public float verticalNormalizedPosition { get; set; }
	private bool hScrollingNeeded { get; }
	private bool vScrollingNeeded { get; }
	public virtual float minWidth { get; }
	public virtual float preferredWidth { get; }
	public virtual float flexibleWidth { get; }
	public virtual float minHeight { get; }
	public virtual float preferredHeight { get; }
	public virtual float flexibleHeight { get; }
	public virtual int layoutPriority { get; }


	public RectTransform get_content() { }

	public void set_content(RectTransform value) { }

	public bool get_horizontal() { }

	public void set_horizontal(bool value) { }

	public bool get_vertical() { }

	public void set_vertical(bool value) { }

	public ScrollRect.MovementType get_movementType() { }

	public void set_movementType(ScrollRect.MovementType value) { }

	public float get_elasticity() { }

	public void set_elasticity(float value) { }

	public bool get_inertia() { }

	public void set_inertia(bool value) { }

	public float get_decelerationRate() { }

	public void set_decelerationRate(float value) { }

	public float get_scrollSensitivity() { }

	public void set_scrollSensitivity(float value) { }

	public RectTransform get_viewport() { }

	public void set_viewport(RectTransform value) { }

	public Scrollbar get_horizontalScrollbar() { }

	public void set_horizontalScrollbar(Scrollbar value) { }

	public Scrollbar get_verticalScrollbar() { }

	public void set_verticalScrollbar(Scrollbar value) { }

	public ScrollRect.ScrollbarVisibility get_horizontalScrollbarVisibility() { }

	public void set_horizontalScrollbarVisibility(ScrollRect.ScrollbarVisibility value) { }

	public ScrollRect.ScrollbarVisibility get_verticalScrollbarVisibility() { }

	public void set_verticalScrollbarVisibility(ScrollRect.ScrollbarVisibility value) { }

	public float get_horizontalScrollbarSpacing() { }

	public void set_horizontalScrollbarSpacing(float value) { }

	public float get_verticalScrollbarSpacing() { }

	public void set_verticalScrollbarSpacing(float value) { }

	public ScrollRect.ScrollRectEvent get_onValueChanged() { }

	public void set_onValueChanged(ScrollRect.ScrollRectEvent value) { }

	protected RectTransform get_viewRect() { }

	public Vector2 get_velocity() { }

	public void set_velocity(Vector2 value) { }

	private RectTransform get_rectTransform() { }

	protected void .ctor() { }

	public virtual void Rebuild(CanvasUpdate executing) { }

	public virtual void LayoutComplete() { }

	public virtual void GraphicUpdateComplete() { }

	private void UpdateCachedData() { }

	protected override void OnEnable() { }

	protected override void OnDisable() { }

	public override bool IsActive() { }

	private void EnsureLayoutHasRebuilt() { }

	public virtual void StopMovement() { }

	public virtual void OnScroll(PointerEventData data) { }

	public virtual void OnInitializePotentialDrag(PointerEventData eventData) { }

	public virtual void OnBeginDrag(PointerEventData eventData) { }

	public virtual void OnEndDrag(PointerEventData eventData) { }

	public virtual void OnDrag(PointerEventData eventData) { }

	protected virtual void SetContentAnchoredPosition(Vector2 position) { }

	protected virtual void LateUpdate() { }

	protected void UpdatePrevData() { }

	private void UpdateScrollbars(Vector2 offset) { }

	public Vector2 get_normalizedPosition() { }

	public void set_normalizedPosition(Vector2 value) { }

	public float get_horizontalNormalizedPosition() { }

	public void set_horizontalNormalizedPosition(float value) { }

	public float get_verticalNormalizedPosition() { }

	public void set_verticalNormalizedPosition(float value) { }

	private void SetHorizontalNormalizedPosition(float value) { }

	private void SetVerticalNormalizedPosition(float value) { }

	protected virtual void SetNormalizedPosition(float value, int axis) { }

	private static float RubberDelta(float overStretching, float viewSize) { }

	protected override void OnRectTransformDimensionsChange() { }

	private bool get_hScrollingNeeded() { }

	private bool get_vScrollingNeeded() { }

	public virtual void CalculateLayoutInputHorizontal() { }

	public virtual void CalculateLayoutInputVertical() { }

	public virtual float get_minWidth() { }

	public virtual float get_preferredWidth() { }

	public virtual float get_flexibleWidth() { }

	public virtual float get_minHeight() { }

	public virtual float get_preferredHeight() { }

	public virtual float get_flexibleHeight() { }

	public virtual int get_layoutPriority() { }

	public virtual void SetLayoutHorizontal() { }

	public virtual void SetLayoutVertical() { }

	private void UpdateScrollbarVisibility() { }

	private static void UpdateOneScrollbarVisibility(bool xScrollingNeeded, bool xAxisEnabled, ScrollRect.ScrollbarVisibility scrollbarVisibility, Scrollbar scrollbar) { }

	private void UpdateScrollbarLayout() { }

	protected void UpdateBounds() { }

	internal static void AdjustBounds(ref Bounds viewBounds, ref Vector2 contentPivot, ref Vector3 contentSize, ref Vector3 contentPos) { }

	private Bounds GetBounds() { }

	internal static Bounds InternalGetBounds(Vector3[] corners, ref Matrix4x4 viewWorldToLocalMatrix) { }

	private Vector2 CalculateOffset(Vector2 delta) { }

	internal static Vector2 InternalCalculateOffset(ref Bounds viewBounds, ref Bounds contentBounds, bool horizontal, bool vertical, ScrollRect.MovementType movementType, ref Vector2 delta) { }

	protected void SetDirty() { }

	protected void SetDirtyCaching() { }

	private Transform UnityEngine.UI.ICanvasElement.get_transform() { }

}

public enum ScrollRect.MovementType // TypeDefIndex: 4999
{
	public int value__; 
	public const ScrollRect.MovementType Unrestricted = 0;
	public const ScrollRect.MovementType Elastic = 1;
	public const ScrollRect.MovementType Clamped = 2;

}

public enum ScrollRect.ScrollbarVisibility // TypeDefIndex: 5000
{
	public int value__; 
	public const ScrollRect.ScrollbarVisibility Permanent = 0;
	public const ScrollRect.ScrollbarVisibility AutoHide = 1;
	public const ScrollRect.ScrollbarVisibility AutoHideAndExpandViewport = 2;

}

public class ScrollRect.ScrollRectEvent : UnityEvent<Vector2> // TypeDefIndex: 5001
{

	public void .ctor() { }

}

