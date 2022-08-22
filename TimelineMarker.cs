public class TimelineMarker : RustControl, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler, IDragHandler // TypeDefIndex: 7042
{	public int CurrentPosition; // 0x30
	public Image Background; // 0x38
	private Timeline Parent; // 0x40
	private bool hasDragged; // 0x48

	public override bool IsPressed { get; }


	public void OnPointerDown(PointerEventData eventData) { }

	public void OnPointerUp(PointerEventData eventData) { }

	public virtual void SelectMarker() { }

	public void OnDrag(PointerEventData eventData) { }

	public override bool get_IsPressed() { }

	internal void Position(Timeline timeline) { }

	protected override void ApplyStyle(StyleAsset.Group s) { }

	public virtual void SetTime(int time) { }

	public void Delete() { }

	public void .ctor() { }

}

