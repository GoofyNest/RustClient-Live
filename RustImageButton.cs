public class RustImageButton : RustControl, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler, ILayoutElement // TypeDefIndex: 7020
{	public Image Background; // 0x30
	public Image Icon; // 0x38
	public UnityEvent OnPressed; // 0x40
	public UnityEvent OnReleased; // 0x48
	public bool IsToggle; // 0x50
	public bool UnpressSiblings; // 0x51
	public bool PreventToggleOff; // 0x52
	public Transform TabPanelTarget; // 0x58
	public Sprite PressedImage; // 0x60
	public Sprite UnpressedImage; // 0x68

	public bool Value { get; set; }
	public float minWidth { get; }
	public float preferredWidth { get; }
	public float flexibleWidth { get; }
	public float minHeight { get; }
	public float preferredHeight { get; }
	public float flexibleHeight { get; }
	public int layoutPriority { get; }


	public bool get_Value() { }

	public void set_Value(bool value) { }

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

