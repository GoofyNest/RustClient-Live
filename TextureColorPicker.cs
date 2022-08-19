public class TextureColorPicker : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IDragHandler // TypeDefIndex: 9241
{	// Fields
	public Texture2D texture; // 0x18
	public TextureColorPicker.onColorSelectedEvent onColorSelected; // 0x20

	// Methods

	// RVA: 0x84C920 Offset: 0x84BD20 VA: 0x18084C920 Slot: 6
	public virtual void OnPointerDown(PointerEventData eventData) { }

	// RVA: 0x84C6B0 Offset: 0x84BAB0 VA: 0x18084C6B0 Slot: 7
	public virtual void OnDrag(PointerEventData eventData) { }

	// RVA: 0x84C940 Offset: 0x84BD40 VA: 0x18084C940
	public void .ctor() { }

}

public class TextureColorPicker.onColorSelectedEvent : UnityEvent<Color> // TypeDefIndex: 9242
{	// Methods

	// RVA: 0x855ED0 Offset: 0x8552D0 VA: 0x180855ED0
	public void .ctor() { }

}

