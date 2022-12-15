public class DragMe : MonoBehaviour, IBeginDragHandler, IEventSystemHandler, IDragHandler, IEndDragHandler // TypeDefIndex: 13075
{
	public static DragMe dragging;
	public static GameObject dragIcon;
	public static object data;
	public string dragType;

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

