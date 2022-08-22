public class RustSlider : RustControl, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler, IDragHandler, IInitializePotentialDragHandler // TypeDefIndex: 7029
{	public RustInput NumberInput; // 0x30
	public Image SliderCanvas; // 0x38
	public string DecimalFormat; // 0x40
	public float MinValue; // 0x48
	public float MaxValue; // 0x4C
	public bool Integer; // 0x50
	public float ValueInternal; // 0x54
	public RustSlider.ChangedEvent OnChanged; // 0x58
	private float lastCallbackValue; // 0x60

	public float Value { get; set; }
	public float ValueNormalized { get; set; }


	protected override void Awake() { }

	public float get_Value() { }

	public void set_Value(float value) { }

	public float get_ValueNormalized() { }

	public void set_ValueNormalized(float value) { }

	public void TextChanged(string text) { }

	public void SliderChanged(float slider) { }

	protected override void ApplyStyle(StyleAsset.Group s) { }

	public void OnPointerDown(PointerEventData eventData) { }

	public void OnPointerUp(PointerEventData eventData) { }

	public void OnInitializePotentialDrag(PointerEventData eventData) { }

	public void OnDrag(PointerEventData eventData) { }

	private void UpdateDrag(Vector2 pos, Camera cam) { }

	public void .ctor() { }

}

public class RustSlider.ChangedEvent : UnityEvent<float> // TypeDefIndex: 7030
{
	public void .ctor() { }

}

