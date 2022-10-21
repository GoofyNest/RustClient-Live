public class RustButton : RustControl, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler, ILayoutElement // TypeDefIndex: 7048
{
	public Image Background; 
	public RustText Text; 
	public RustText SubText; 
	public RustIcon Icon; 
	public Image IconImage; 
	public UnityEvent OnPressed; 
	public UnityEvent OnReleased; 
	public bool IsToggle; 
	public bool UnpressSiblings; 
	public bool PreventToggleOff; 
	public Transform TabPanelTarget; 
	public Vector4 TextMargin; 
	public Vector4 TextMarginNoIcon; 

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

	public void SetToggleTrue() { }

	public void SetToggleFalse() { }

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

