public class ScrollRectZoom : MonoBehaviour, IScrollHandler, IEventSystemHandler // TypeDefIndex: 12997
{
	public ScrollRectEx scrollRect; 
	public float zoom; 
	public float max; 
	public float min; 
	public bool mouseWheelZoom; 
	public float scrollAmount; 

	public RectTransform rectTransform { get; }


	public RectTransform get_rectTransform() { }

	private void OnEnable() { }

	public void OnScroll(PointerEventData data) { }

	public void SetZoom(float z, bool expZoom = True) { }

	public void .ctor() { }

}

