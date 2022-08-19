public class DragMe : MonoBehaviour, IBeginDragHandler, IEventSystemHandler, IDragHandler, IEndDragHandler // TypeDefIndex: 11267
{	// Fields
	public static DragMe dragging; // 0x0
	public static GameObject dragIcon; // 0x8
	public static object data; // 0x10
	public string dragType; // 0x18

	// Properties
	protected virtual Canvas TopCanvas { get; }
	public virtual bool CancelOnDrop { get; }

	// Methods

	// RVA: 0xAAB360 Offset: 0xAAA760 VA: 0x180AAB360 Slot: 7
	public virtual void OnBeginDrag(PointerEventData eventData) { }

	// RVA: 0xAAAE40 Offset: 0xAAA240 VA: 0x180AAAE40 Slot: 8
	protected virtual GameObject CreateDragObject(Canvas topCanvas, IDraggable dragInfo) { }

	// RVA: 0xAABAA0 Offset: 0xAAAEA0 VA: 0x180AABAA0 Slot: 9
	protected virtual Canvas get_TopCanvas() { }

	// RVA: 0xAAB7D0 Offset: 0xAAABD0 VA: 0x180AAB7D0 Slot: 10
	public virtual void OnDrag(PointerEventData eventData) { }

	// RVA: 0xAAB940 Offset: 0xAAAD40 VA: 0x180AAB940 Slot: 11
	public virtual void OnEndDrag(PointerEventData eventData) { }

	// RVA: 0xAAADA0 Offset: 0xAAA1A0 VA: 0x180AAADA0
	public void CancelDrag() { }

	// RVA: 0xAAB050 Offset: 0xAAA450 VA: 0x180AAB050
	internal DropMe FindTarget(GameObject obj) { }

	// RVA: 0x498AD0 Offset: 0x497ED0 VA: 0x180498AD0 Slot: 12
	public virtual bool get_CancelOnDrop() { }

	// RVA: 0xAAAC90 Offset: 0xAAA090 VA: 0x180AAAC90
	public void .ctor() { }

}

