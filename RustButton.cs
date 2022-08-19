public class RustButton : RustControl, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler, ILayoutElement // TypeDefIndex: 7013
{	// Fields
	public Image Background; // 0x30
	public RustText Text; // 0x38
	public RustText SubText; // 0x40
	public RustIcon Icon; // 0x48
	public Image IconImage; // 0x50
	public UnityEvent OnPressed; // 0x58
	public UnityEvent OnReleased; // 0x60
	public bool IsToggle; // 0x68
	public bool UnpressSiblings; // 0x69
	public bool PreventToggleOff; // 0x6A
	public Transform TabPanelTarget; // 0x70
	public Vector4 TextMargin; // 0x78
	public Vector4 TextMarginNoIcon; // 0x88

	// Properties
	public bool Value { get; set; }
	public bool AutoSize { get; set; }
	public float minWidth { get; }
	public float preferredWidth { get; }
	public float flexibleWidth { get; }
	public float minHeight { get; }
	public float preferredHeight { get; }
	public float flexibleHeight { get; }
	public int layoutPriority { get; }

	// Methods

	// RVA: 0xFC61D0 Offset: 0xFC55D0 VA: 0x180FC61D0
	public bool get_Value() { }

	// RVA: 0xFC6660 Offset: 0xFC5A60 VA: 0x180FC6660
	public void set_Value(bool value) { }

	// RVA: 0xFC61B0 Offset: 0xFC55B0 VA: 0x180FC61B0
	public bool get_AutoSize() { }

	// RVA: 0xFC6640 Offset: 0xFC5A40 VA: 0x180FC6640
	public void set_AutoSize(bool value) { }

	// RVA: 0xFC5DC0 Offset: 0xFC51C0 VA: 0x180FC5DC0
	public void Press() { }

	// RVA: 0xFC5D30 Offset: 0xFC5130 VA: 0x180FC5D30
	public void Unpress() { }

	// RVA: 0xFC5D00 Offset: 0xFC5100 VA: 0x180FC5D00 Slot: 42
	public virtual void OnPointerDown(PointerEventData eventData) { }

	// RVA: 0xFC6010 Offset: 0xFC5410 VA: 0x180FC6010
	public void Toggle(bool v, bool forced = False) { }

	// RVA: 0xFC5F00 Offset: 0xFC5300 VA: 0x180FC5F00
	private void ToggleTabPanel(bool onOff) { }

	// RVA: 0xFC59B0 Offset: 0xFC4DB0 VA: 0x180FC59B0
	private void DoUnpressSiblings() { }

	// RVA: 0xFC5D30 Offset: 0xFC5130 VA: 0x180FC5D30 Slot: 43
	public virtual void OnPointerUp(PointerEventData eventData) { }

	// RVA: 0xFC5C10 Offset: 0xFC5010 VA: 0x180FC5C10 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0xFC54C0 Offset: 0xFC48C0 VA: 0x180FC54C0 Slot: 30
	protected override void ApplyStyle(StyleAsset.Group s) { }

	// RVA: 0xFC6450 Offset: 0xFC5850 VA: 0x180FC6450 Slot: 35
	public float get_minWidth() { }

	// RVA: 0xFC6590 Offset: 0xFC5990 VA: 0x180FC6590 Slot: 36
	public float get_preferredWidth() { }

	// RVA: 0xFC6280 Offset: 0xFC5680 VA: 0x180FC6280 Slot: 37
	public float get_flexibleWidth() { }

	// RVA: 0xFC63C0 Offset: 0xFC57C0 VA: 0x180FC63C0 Slot: 38
	public float get_minHeight() { }

	// RVA: 0xFC6500 Offset: 0xFC5900 VA: 0x180FC6500 Slot: 39
	public float get_preferredHeight() { }

	// RVA: 0xFC61F0 Offset: 0xFC55F0 VA: 0x180FC61F0 Slot: 40
	public float get_flexibleHeight() { }

	// RVA: 0xFC6330 Offset: 0xFC5730 VA: 0x180FC6330 Slot: 41
	public int get_layoutPriority() { }

	// RVA: 0xFC5970 Offset: 0xFC4D70 VA: 0x180FC5970 Slot: 33
	public void CalculateLayoutInputHorizontal() { }

	// RVA: 0xFC5990 Offset: 0xFC4D90 VA: 0x180FC5990 Slot: 34
	public void CalculateLayoutInputVertical() { }

	// RVA: 0xFC60D0 Offset: 0xFC54D0 VA: 0x180FC60D0
	public void .ctor() { }

}

