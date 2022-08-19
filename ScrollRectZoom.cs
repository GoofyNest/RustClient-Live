public class ScrollRectZoom : MonoBehaviour, IScrollHandler, IEventSystemHandler // TypeDefIndex: 11215
{	// Fields
	public ScrollRectEx scrollRect; // 0x18
	public float zoom; // 0x20
	public float max; // 0x24
	public float min; // 0x28
	public bool mouseWheelZoom; // 0x2C
	public float scrollAmount; // 0x30

	// Properties
	public RectTransform rectTransform { get; }

	// Methods

	// RVA: 0x4A2B70 Offset: 0x4A1F70 VA: 0x1804A2B70
	public RectTransform get_rectTransform() { }

	// RVA: 0x4A28E0 Offset: 0x4A1CE0 VA: 0x1804A28E0
	private void OnEnable() { }

	// RVA: 0x4A28F0 Offset: 0x4A1CF0 VA: 0x1804A28F0 Slot: 4
	public void OnScroll(PointerEventData data) { }

	// RVA: 0x4A2930 Offset: 0x4A1D30 VA: 0x1804A2930
	public void SetZoom(float z, bool expZoom = True) { }

	// RVA: 0x4A2B40 Offset: 0x4A1F40 VA: 0x1804A2B40
	public void .ctor() { }

}

