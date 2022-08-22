public class ScrollRect : UIBehaviour, IInitializePotentialDragHandler, IEventSystemHandler, IBeginDragHandler, IEndDragHandler, IDragHandler, IScrollHandler, ICanvasElement, ILayoutElement, ILayoutGroup, ILayoutController // TypeDefIndex: 4994
{	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private RectTransform m_Content; // 0x18
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private bool m_Horizontal; // 0x20
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private bool m_Vertical; // 0x21
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private ScrollRect.MovementType m_MovementType; // 0x24
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private float m_Elasticity; // 0x28
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private bool m_Inertia; // 0x2C
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private float m_DecelerationRate; // 0x30
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private float m_ScrollSensitivity; // 0x34
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private RectTransform m_Viewport; // 0x38
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Scrollbar m_HorizontalScrollbar; // 0x40
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Scrollbar m_VerticalScrollbar; // 0x48
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private ScrollRect.ScrollbarVisibility m_HorizontalScrollbarVisibility; // 0x50
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private ScrollRect.ScrollbarVisibility m_VerticalScrollbarVisibility; // 0x54
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private float m_HorizontalScrollbarSpacing; // 0x58
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private float m_VerticalScrollbarSpacing; // 0x5C
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private ScrollRect.ScrollRectEvent m_OnValueChanged; // 0x60
	private Vector2 m_PointerStartLocalCursor; // 0x68
	protected Vector2 m_ContentStartPosition; // 0x70
	private RectTransform m_ViewRect; // 0x78
	protected Bounds m_ContentBounds; // 0x80
	private Bounds m_ViewBounds; // 0x98
	private Vector2 m_Velocity; // 0xB0
	private bool m_Dragging; // 0xB8
	private bool m_Scrolling; // 0xB9
	private Vector2 m_PrevPosition; // 0xBC
	private Bounds m_PrevContentBounds; // 0xC4
	private Bounds m_PrevViewBounds; // 0xDC
	private bool m_HasRebuiltLayout; // 0xF4
	private bool m_HSliderExpand; // 0xF5
	private bool m_VSliderExpand; // 0xF6
	private float m_HSliderHeight; // 0xF8
	private float m_VSliderWidth; // 0xFC
	private RectTransform m_Rect; // 0x100
	private RectTransform m_HorizontalScrollbarRect; // 0x108
	private RectTransform m_VerticalScrollbarRect; // 0x110
	private DrivenRectTransformTracker m_Tracker; // 0x118
	private readonly Vector3[] m_Corners; // 0x120

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

public enum ScrollRect.MovementType // TypeDefIndex: 4995
{	public int value__; // 0x0
	public const ScrollRect.MovementType Unrestricted = 0;
	public const ScrollRect.MovementType Elastic = 1;
	public const ScrollRect.MovementType Clamped = 2;

}

public enum ScrollRect.ScrollbarVisibility // TypeDefIndex: 4996
{	public int value__; // 0x0
	public const ScrollRect.ScrollbarVisibility Permanent = 0;
	public const ScrollRect.ScrollbarVisibility AutoHide = 1;
	public const ScrollRect.ScrollbarVisibility AutoHideAndExpandViewport = 2;

}

public class ScrollRect.ScrollRectEvent : UnityEvent<Vector2> // TypeDefIndex: 4997
{
	public void .ctor() { }

}

