public class DropMe : MonoBehaviour, IDropHandler, IEventSystemHandler // TypeDefIndex: 13022
{
	public string[] droppableTypes; 


	public bool Accepts(DragMe drag) { }

	public void StopHighlight() { }

	public void StartHighlight() { }

	public virtual void OnDrop(PointerEventData eventData) { }

	public void .ctor() { }

}

