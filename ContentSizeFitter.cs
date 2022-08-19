public class ContentSizeFitter : UIBehaviour, ILayoutSelfController, ILayoutController // TypeDefIndex: 4963
{	// Fields
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	protected ContentSizeFitter.FitMode m_HorizontalFit; // 0x18
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	protected ContentSizeFitter.FitMode m_VerticalFit; // 0x1C
	private RectTransform m_Rect; // 0x20
	private DrivenRectTransformTracker m_Tracker; // 0x28

	// Properties
	public ContentSizeFitter.FitMode horizontalFit { get; set; }
	public ContentSizeFitter.FitMode verticalFit { get; set; }
	private RectTransform rectTransform { get; }

	// Methods

	// RVA: 0x4BE200 Offset: 0x4BD600 VA: 0x1804BE200
	public ContentSizeFitter.FitMode get_horizontalFit() { }

	// RVA: 0x10B54D0 Offset: 0x10B48D0 VA: 0x1810B54D0
	public void set_horizontalFit(ContentSizeFitter.FitMode value) { }

	// RVA: 0x4BE1F0 Offset: 0x4BD5F0 VA: 0x1804BE1F0
	public ContentSizeFitter.FitMode get_verticalFit() { }

	// RVA: 0x10B5530 Offset: 0x10B4930 VA: 0x1810B5530
	public void set_verticalFit(ContentSizeFitter.FitMode value) { }

	// RVA: 0x10B5430 Offset: 0x10B4830 VA: 0x1810B5430
	private RectTransform get_rectTransform() { }

	// RVA: 0x2F91F0 Offset: 0x2F85F0 VA: 0x1802F91F0
	protected void .ctor() { }

	// RVA: 0x10B51F0 Offset: 0x10B45F0 VA: 0x1810B51F0 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x10B5180 Offset: 0x10B4580 VA: 0x1810B5180 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x10B51F0 Offset: 0x10B45F0 VA: 0x1810B51F0 Slot: 10
	protected override void OnRectTransformDimensionsChange() { }

	// RVA: 0x10B50A0 Offset: 0x10B44A0 VA: 0x1810B50A0
	private void HandleSelfFittingAlongAxis(int axis) { }

	// RVA: 0x10B5280 Offset: 0x10B4680 VA: 0x1810B5280 Slot: 19
	public virtual void SetLayoutHorizontal() { }

	// RVA: 0x10B5360 Offset: 0x10B4760 VA: 0x1810B5360 Slot: 20
	public virtual void SetLayoutVertical() { }

	// RVA: 0x10B5200 Offset: 0x10B4600 VA: 0x1810B5200
	protected void SetDirty() { }

}

public enum ContentSizeFitter.FitMode // TypeDefIndex: 4964
{	// Fields
	public int value__; // 0x0
	public const ContentSizeFitter.FitMode Unconstrained = 0;
	public const ContentSizeFitter.FitMode MinSize = 1;
	public const ContentSizeFitter.FitMode PreferredSize = 2;

}

