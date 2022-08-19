public class AspectRatioFitter : UIBehaviour, ILayoutSelfController, ILayoutController // TypeDefIndex: 4957
{	// Fields
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private AspectRatioFitter.AspectMode m_AspectMode; // 0x18
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private float m_AspectRatio; // 0x1C
	private RectTransform m_Rect; // 0x20
	private bool m_DelayedSetDirty; // 0x28
	private DrivenRectTransformTracker m_Tracker; // 0x29

	// Properties
	public AspectRatioFitter.AspectMode aspectMode { get; set; }
	public float aspectRatio { get; set; }
	private RectTransform rectTransform { get; }

	// Methods

	// RVA: 0x4BE200 Offset: 0x4BD600 VA: 0x1804BE200
	public AspectRatioFitter.AspectMode get_aspectMode() { }

	// RVA: 0x10B0570 Offset: 0x10AF970 VA: 0x1810B0570
	public void set_aspectMode(AspectRatioFitter.AspectMode value) { }

	// RVA: 0x7723E0 Offset: 0x7717E0 VA: 0x1807723E0
	public float get_aspectRatio() { }

	// RVA: 0x10B05D0 Offset: 0x10AF9D0 VA: 0x1810B05D0
	public void set_aspectRatio(float value) { }

	// RVA: 0x10B04D0 Offset: 0x10AF8D0 VA: 0x1810B04D0
	private RectTransform get_rectTransform() { }

	// RVA: 0x70F570 Offset: 0x70E970 VA: 0x18070F570
	protected void .ctor() { }

	// RVA: 0x10B0150 Offset: 0x10AF550 VA: 0x1810B0150 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x10B00E0 Offset: 0x10AF4E0 VA: 0x1810B00E0 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x10B04B0 Offset: 0x10AF8B0 VA: 0x1810B04B0 Slot: 19
	protected virtual void Update() { }

	// RVA: 0x10B0150 Offset: 0x10AF550 VA: 0x1810B0150 Slot: 10
	protected override void OnRectTransformDimensionsChange() { }

	// RVA: 0x10B0160 Offset: 0x10AF560 VA: 0x1810B0160
	private void UpdateRect() { }

	// RVA: 0x10B0010 Offset: 0x10AF410 VA: 0x1810B0010
	private float GetSizeDeltaToProduceSize(float size, int axis) { }

	// RVA: 0x10AFF20 Offset: 0x10AF320 VA: 0x1810AFF20
	private Vector2 GetParentSize() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 20
	public virtual void SetLayoutHorizontal() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 21
	public virtual void SetLayoutVertical() { }

	// RVA: 0x10B0150 Offset: 0x10AF550 VA: 0x1810B0150
	protected void SetDirty() { }

}

public enum AspectRatioFitter.AspectMode // TypeDefIndex: 4958
{	// Fields
	public int value__; // 0x0
	public const AspectRatioFitter.AspectMode None = 0;
	public const AspectRatioFitter.AspectMode WidthControlsHeight = 1;
	public const AspectRatioFitter.AspectMode HeightControlsWidth = 2;
	public const AspectRatioFitter.AspectMode FitInParent = 3;
	public const AspectRatioFitter.AspectMode EnvelopeParent = 4;

}

