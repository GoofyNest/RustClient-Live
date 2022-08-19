public class RustSlider : RustControl, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler, IDragHandler, IInitializePotentialDragHandler // TypeDefIndex: 7029
{	// Fields
	public RustInput NumberInput; // 0x30
	public Image SliderCanvas; // 0x38
	public string DecimalFormat; // 0x40
	public float MinValue; // 0x48
	public float MaxValue; // 0x4C
	public bool Integer; // 0x50
	public float ValueInternal; // 0x54
	public RustSlider.ChangedEvent OnChanged; // 0x58
	private float lastCallbackValue; // 0x60

	// Properties
	public float Value { get; set; }
	public float ValueNormalized { get; set; }

	// Methods

	// RVA: 0xFC9BB0 Offset: 0xFC8FB0 VA: 0x180FC9BB0 Slot: 4
	protected override void Awake() { }

	// RVA: 0xFCA200 Offset: 0xFC9600 VA: 0x180FCA200
	public float get_Value() { }

	// RVA: 0xFCA230 Offset: 0xFC9630 VA: 0x180FCA230
	public void set_Value(float value) { }

	// RVA: 0xFCA170 Offset: 0xFC9570 VA: 0x180FCA170
	public float get_ValueNormalized() { }

	// RVA: 0xFCA210 Offset: 0xFC9610 VA: 0x180FCA210
	public void set_ValueNormalized(float value) { }

	// RVA: 0xFC9ED0 Offset: 0xFC92D0 VA: 0x180FC9ED0
	public void TextChanged(string text) { }

	// RVA: 0xFC9EC0 Offset: 0xFC92C0 VA: 0x180FC9EC0
	public void SliderChanged(float slider) { }

	// RVA: 0xFC9B10 Offset: 0xFC8F10 VA: 0x180FC9B10 Slot: 30
	protected override void ApplyStyle(StyleAsset.Group s) { }

	// RVA: 0xFC9D60 Offset: 0xFC9160 VA: 0x180FC9D60 Slot: 31
	public void OnPointerDown(PointerEventData eventData) { }

	// RVA: 0xFC9E40 Offset: 0xFC9240 VA: 0x180FC9E40 Slot: 32
	public void OnPointerUp(PointerEventData eventData) { }

	// RVA: 0xFC9D40 Offset: 0xFC9140 VA: 0x180FC9D40 Slot: 34
	public void OnInitializePotentialDrag(PointerEventData eventData) { }

	// RVA: 0xFC9CD0 Offset: 0xFC90D0 VA: 0x180FC9CD0 Slot: 33
	public void OnDrag(PointerEventData eventData) { }

	// RVA: 0xFC9F10 Offset: 0xFC9310 VA: 0x180FC9F10
	private void UpdateDrag(Vector2 pos, Camera cam) { }

	// RVA: 0xFCA100 Offset: 0xFC9500 VA: 0x180FCA100
	public void .ctor() { }

}

public class RustSlider.ChangedEvent : UnityEvent<float> // TypeDefIndex: 7030
{	// Methods

	// RVA: 0xFB8EF0 Offset: 0xFB82F0 VA: 0x180FB8EF0
	public void .ctor() { }

}

