public class DropMe : MonoBehaviour, IDropHandler, IEventSystemHandler // TypeDefIndex: 11270
{	// Fields
	public string[] droppableTypes; // 0x18

	// Methods

	// RVA: 0xAACDF0 Offset: 0xAAC1F0 VA: 0x180AACDF0
	public bool Accepts(DragMe drag) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0
	public void StopHighlight() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0
	public void StartHighlight() { }

	// RVA: 0xAAD070 Offset: 0xAAC470 VA: 0x180AAD070 Slot: 5
	public virtual void OnDrop(PointerEventData eventData) { }

	// RVA: 0x2F91F0 Offset: 0x2F85F0 VA: 0x1802F91F0
	public void .ctor() { }

}

