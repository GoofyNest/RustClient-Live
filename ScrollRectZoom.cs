public class ScrollRectZoom : MonoBehaviour, IScrollHandler, IEventSystemHandler // TypeDefIndex: 11215
{	public ScrollRectEx scrollRect; // 0x18
	public float zoom; // 0x20
	public float max; // 0x24
	public float min; // 0x28
	public bool mouseWheelZoom; // 0x2C
	public float scrollAmount; // 0x30

	public RectTransform rectTransform { get; }


	public RectTransform get_rectTransform() { }

	private void OnEnable() { }

	public void OnScroll(PointerEventData data) { }

	public void SetZoom(float z, bool expZoom = True) { }

	public void .ctor() { }

}

