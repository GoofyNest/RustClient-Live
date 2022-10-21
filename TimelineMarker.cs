public class TimelineMarker : RustControl, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler, IDragHandler // TypeDefIndex: 7078
{
	public int CurrentPosition; 
	public Image Background; 
	private Timeline Parent; 
	private bool hasDragged; 

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

