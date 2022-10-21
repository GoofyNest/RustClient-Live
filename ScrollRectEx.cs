public class ScrollRectEx : UIBehaviour, IInitializePotentialDragHandler, IEventSystemHandler, IBeginDragHandler, IEndDragHandler, IDragHandler, IScrollHandler, ICanvasElement, ILayoutGroup, ILayoutController // TypeDefIndex: 13461
{
	public PointerEventData.InputButton scrollButton; 
	public PointerEventData.InputButton altScrollButton; 
	[SerializeField] 
	private RectTransform m_Content; 
	[SerializeField] 
	private bool m_Horizontal; 
	[SerializeField] 
	private bool m_Vertical; 
	[SerializeField] 
	private ScrollRectEx.MovementType m_MovementType; 
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
	private ScrollRectEx.ScrollbarVisibility m_HorizontalScrollbarVisibility; 
	[SerializeField] 
	private ScrollRectEx.ScrollbarVisibility m_VerticalScrollbarVisibility; 
	[SerializeField] 
	private float m_HorizontalScrollbarSpacing; 
	[SerializeField] 
	private float m_VerticalScrollbarSpacing; 
	[SerializeField] 
	private ScrollRectEx.ScrollRectEvent m_OnValueChanged; 
	private Vector2 m_PointerStartLocalCursor; 
	private Vector2 m_ContentStartPosition; 
	private RectTransform m_ViewRect; 
	private Bounds m_ContentBounds; 
	private Bounds m_ViewBounds; 
	private Vector2 m_Velocity; 
	private bool m_Dragging; 
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
	public ScrollRectEx.MovementType movementType { get; set; }
	public float elasticity { get; set; }
	public bool inertia { get; set; }
	public float decelerationRate { get; set; }
	public float scrollSensitivity { get; set; }
	public RectTransform viewport { get; set; }
	public Scrollbar horizontalScrollbar { get; set; }
	public Scrollbar verticalScrollbar { get; set; }
	public ScrollRectEx.ScrollbarVisibility horizontalScrollbarVisibility { get; set; }
	public ScrollRectEx.ScrollbarVisibility verticalScrollbarVisibility { get; set; }
	public float horizontalScrollbarSpacing { get; set; }
	public float verticalScrollbarSpacing { get; set; }
	public ScrollRectEx.ScrollRectEvent onValueChanged { get; set; }
	protected RectTransform viewRect { get; }
	public Vector2 velocity { get; set; }
	private RectTransform rectTransform { get; }
	public Vector2 normalizedPosition { get; set; }
	public float horizontalNormalizedPosition { get; set; }
	public float verticalNormalizedPosition { get; set; }
	private bool hScrollingNeeded { get; }
	private bool vScrollingNeeded { get; }


	public RectTransform get_content() { }

	public void set_content(RectTransform value) { }

	public bool get_horizontal() { }

	public void set_horizontal(bool value) { }

	public bool get_vertical() { }

	public void set_vertical(bool value) { }

	public ScrollRectEx.MovementType get_movementType() { }

	public void set_movementType(ScrollRectEx.MovementType value) { }

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

	public ScrollRectEx.ScrollbarVisibility get_horizontalScrollbarVisibility() { }

	public void set_horizontalScrollbarVisibility(ScrollRectEx.ScrollbarVisibility value) { }

	public ScrollRectEx.ScrollbarVisibility get_verticalScrollbarVisibility() { }

	public void set_verticalScrollbarVisibility(ScrollRectEx.ScrollbarVisibility value) { }

	public float get_horizontalScrollbarSpacing() { }

	public void set_horizontalScrollbarSpacing(float value) { }

	public float get_verticalScrollbarSpacing() { }

	public void set_verticalScrollbarSpacing(float value) { }

	public ScrollRectEx.ScrollRectEvent get_onValueChanged() { }

	public void set_onValueChanged(ScrollRectEx.ScrollRectEvent value) { }

	protected RectTransform get_viewRect() { }

	public Vector2 get_velocity() { }

	public void set_velocity(Vector2 value) { }

	private RectTransform get_rectTransform() { }

	protected void .ctor() { }

	public virtual void Rebuild(CanvasUpdate executing) { }

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

	private void UpdatePrevData() { }

	private void UpdateScrollbars(Vector2 offset) { }

	public Vector2 get_normalizedPosition() { }

	public void set_normalizedPosition(Vector2 value) { }

	public float get_horizontalNormalizedPosition() { }

	public void set_horizontalNormalizedPosition(float value) { }

	public float get_verticalNormalizedPosition() { }

	public void set_verticalNormalizedPosition(float value) { }

	private void SetHorizontalNormalizedPosition(float value) { }

	private void SetVerticalNormalizedPosition(float value) { }

	private void SetNormalizedPosition(float value, int axis) { }

	private static float RubberDelta(float overStretching, float viewSize) { }

	protected override void OnRectTransformDimensionsChange() { }

	private bool get_hScrollingNeeded() { }

	private bool get_vScrollingNeeded() { }

	public virtual void SetLayoutHorizontal() { }

	public virtual void SetLayoutVertical() { }

	private void UpdateScrollbarVisibility() { }

	private void UpdateScrollbarLayout() { }

	private void UpdateBounds() { }

	private Bounds GetBounds() { }

	private Vector2 CalculateOffset(Vector2 delta) { }

	protected void SetDirty() { }

	protected void SetDirtyCaching() { }

	public void CenterOnPosition(Vector2 pos) { }

	public void LayoutComplete() { }

	public void GraphicUpdateComplete() { }

	private Transform UnityEngine.UI.ICanvasElement.get_transform() { }

}

public enum ScrollRectEx.MovementType // TypeDefIndex: 13462
{
	public int value__; 
	public const ScrollRectEx.MovementType Unrestricted = 0;
	public const ScrollRectEx.MovementType Elastic = 1;
	public const ScrollRectEx.MovementType Clamped = 2;

}

public enum ScrollRectEx.ScrollbarVisibility // TypeDefIndex: 13463
{
	public int value__; 
	public const ScrollRectEx.ScrollbarVisibility Permanent = 0;
	public const ScrollRectEx.ScrollbarVisibility AutoHide = 1;
	public const ScrollRectEx.ScrollbarVisibility AutoHideAndExpandViewport = 2;

}

public class ScrollRectEx.ScrollRectEvent : UnityEvent<Vector2> // TypeDefIndex: 13464
{

	public void .ctor() { }

}

