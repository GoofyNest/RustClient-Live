public class RustButton : RustControl, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler, ILayoutElement // TypeDefIndex: 7013
{	public Image Background; // 0x30
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

	public bool Value { get; set; }
	public bool AutoSize { get; set; }
	public float minWidth { get; }
	public float preferredWidth { get; }
	public float flexibleWidth { get; }
	public float minHeight { get; }
	public float preferredHeight { get; }
	public float flexibleHeight { get; }
	public int layoutPriority { get; }


	public bool get_Value() { }

	public void set_Value(bool value) { }

	public bool get_AutoSize() { }

	public void set_AutoSize(bool value) { }

	public void Press() { }

	public void Unpress() { }

	public virtual void OnPointerDown(PointerEventData eventData) { }

	public void Toggle(bool v, bool forced = False) { }

	private void ToggleTabPanel(bool onOff) { }

	private void DoUnpressSiblings() { }

	public virtual void OnPointerUp(PointerEventData eventData) { }

	protected override void OnDisable() { }

	protected override void ApplyStyle(StyleAsset.Group s) { }

	public float get_minWidth() { }

	public float get_preferredWidth() { }

	public float get_flexibleWidth() { }

	public float get_minHeight() { }

	public float get_preferredHeight() { }

	public float get_flexibleHeight() { }

	public int get_layoutPriority() { }

	public void CalculateLayoutInputHorizontal() { }

	public void CalculateLayoutInputVertical() { }

	public void .ctor() { }

}

