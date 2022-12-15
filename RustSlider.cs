public class RustSlider : RustControl, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler, IDragHandler, IInitializePotentialDragHandler // TypeDefIndex: 7073
{
	public RustInput NumberInput;
	public Image SliderCanvas;
	public string DecimalFormat;
	public float MinValue;
	public float MaxValue;
	public bool Integer;
	public float ValueInternal;
	public RustSlider.ChangedEvent OnChanged;
	private float lastCallbackValue;

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

public class RustSlider.ChangedEvent : UnityEvent<float> // TypeDefIndex: 7074
{

	public void .ctor() { }

}

