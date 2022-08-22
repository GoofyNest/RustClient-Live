public class DragMe : MonoBehaviour, IBeginDragHandler, IEventSystemHandler, IDragHandler, IEndDragHandler // TypeDefIndex: 11267
{	public static DragMe dragging; // 0x0
	public static GameObject dragIcon; // 0x8
	public static object data; // 0x10
	public string dragType; // 0x18

	protected virtual Canvas TopCanvas { get; }
	public virtual bool CancelOnDrop { get; }


	public virtual void OnBeginDrag(PointerEventData eventData) { }

	protected virtual GameObject CreateDragObject(Canvas topCanvas, IDraggable dragInfo) { }

	protected virtual Canvas get_TopCanvas() { }

	public virtual void OnDrag(PointerEventData eventData) { }

	public virtual void OnEndDrag(PointerEventData eventData) { }

	public void CancelDrag() { }

	internal DropMe FindTarget(GameObject obj) { }

	public virtual bool get_CancelOnDrop() { }

	public void .ctor() { }

}

