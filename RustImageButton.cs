public class RustImageButton : RustControl, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler, ILayoutElement // TypeDefIndex: 7020
{	// Fields
	public Image Background; // 0x30
	public Image Icon; // 0x38
	public UnityEvent OnPressed; // 0x40
	public UnityEvent OnReleased; // 0x48
	public bool IsToggle; // 0x50
	public bool UnpressSiblings; // 0x51
	public bool PreventToggleOff; // 0x52
	public Transform TabPanelTarget; // 0x58
	public Sprite PressedImage; // 0x60
	public Sprite UnpressedImage; // 0x68

	// Properties
	public bool Value { get; set; }
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

	// RVA: 0xFC6FE0 Offset: 0xFC63E0 VA: 0x180FC6FE0
	public void Press() { }

	// RVA: 0xFC6F90 Offset: 0xFC6390 VA: 0x180FC6F90
	public void Unpress() { }

	// RVA: 0xFC6F60 Offset: 0xFC6360 VA: 0x180FC6F60 Slot: 42
	public virtual void OnPointerDown(PointerEventData eventData) { }

	// RVA: 0xFC7230 Offset: 0xFC6630 VA: 0x180FC7230
	public void Toggle(bool v, bool forced = False) { }

	// RVA: 0xFC7120 Offset: 0xFC6520 VA: 0x180FC7120
	private void ToggleTabPanel(bool onOff) { }

	// RVA: 0xFC6CB0 Offset: 0xFC60B0 VA: 0x180FC6CB0
	private void DoUnpressSiblings() { }

	// RVA: 0xFC6F90 Offset: 0xFC6390 VA: 0x180FC6F90 Slot: 43
	public virtual void OnPointerUp(PointerEventData eventData) { }

	// RVA: 0xFC6F10 Offset: 0xFC6310 VA: 0x180FC6F10 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0xFC6B30 Offset: 0xFC5F30 VA: 0x180FC6B30 Slot: 30
	protected override void ApplyStyle(StyleAsset.Group s) { }

	// RVA: 0xFC75B0 Offset: 0xFC69B0 VA: 0x180FC75B0 Slot: 35
	public float get_minWidth() { }

	// RVA: 0xFC76F0 Offset: 0xFC6AF0 VA: 0x180FC76F0 Slot: 36
	public float get_preferredWidth() { }

	// RVA: 0xFC73E0 Offset: 0xFC67E0 VA: 0x180FC73E0 Slot: 37
	public float get_flexibleWidth() { }

	// RVA: 0xFC7520 Offset: 0xFC6920 VA: 0x180FC7520 Slot: 38
	public float get_minHeight() { }

	// RVA: 0xFC7660 Offset: 0xFC6A60 VA: 0x180FC7660 Slot: 39
	public float get_preferredHeight() { }

	// RVA: 0xFC7350 Offset: 0xFC6750 VA: 0x180FC7350 Slot: 40
	public float get_flexibleHeight() { }

	// RVA: 0xFC7490 Offset: 0xFC6890 VA: 0x180FC7490 Slot: 41
	public int get_layoutPriority() { }

	// RVA: 0xFC6C70 Offset: 0xFC6070 VA: 0x180FC6C70 Slot: 33
	public void CalculateLayoutInputHorizontal() { }

	// RVA: 0xFC6C90 Offset: 0xFC6090 VA: 0x180FC6C90 Slot: 34
	public void CalculateLayoutInputVertical() { }

	// RVA: 0xFC72F0 Offset: 0xFC66F0 VA: 0x180FC72F0
	public void .ctor() { }

}

