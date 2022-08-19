public class TimelineMarker : RustControl, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler, IDragHandler // TypeDefIndex: 7042
{	// Fields
	public int CurrentPosition; // 0x30
	public Image Background; // 0x38
	private Timeline Parent; // 0x40
	private bool hasDragged; // 0x48

	// Properties
	public override bool IsPressed { get; }

	// Methods

	// RVA: 0xFD0260 Offset: 0xFCF660 VA: 0x180FD0260 Slot: 31
	public void OnPointerDown(PointerEventData eventData) { }

	// RVA: 0xFD0270 Offset: 0xFCF670 VA: 0x180FD0270 Slot: 32
	public void OnPointerUp(PointerEventData eventData) { }

	// RVA: 0xFD03A0 Offset: 0xFCF7A0 VA: 0x180FD03A0 Slot: 34
	public virtual void SelectMarker() { }

	// RVA: 0xFD0240 Offset: 0xFCF640 VA: 0x180FD0240 Slot: 33
	public void OnDrag(PointerEventData eventData) { }

	// RVA: 0xFD0420 Offset: 0xFCF820 VA: 0x180FD0420 Slot: 26
	public override bool get_IsPressed() { }

	// RVA: 0xFD0290 Offset: 0xFCF690 VA: 0x180FD0290
	internal void Position(Timeline timeline) { }

	// RVA: 0xFD0170 Offset: 0xFCF570 VA: 0x180FD0170 Slot: 30
	protected override void ApplyStyle(StyleAsset.Group s) { }

	// RVA: 0xA17E80 Offset: 0xA17280 VA: 0x180A17E80 Slot: 35
	public virtual void SetTime(int time) { }

	// RVA: 0xFD01B0 Offset: 0xFCF5B0 VA: 0x180FD01B0
	public void Delete() { }

	// RVA: 0xFD03C0 Offset: 0xFCF7C0 VA: 0x180FD03C0
	public void .ctor() { }

}

