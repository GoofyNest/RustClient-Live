public class ZoomImage : MonoBehaviour, IScrollHandler, IEventSystemHandler // TypeDefIndex: 10918
{
	[SerializeField] 
	private float _minimumScale; 
	[SerializeField] 
	private float _initialScale; 
	[SerializeField] 
	private float _maximumScale; 
	[SerializeField] 
	private float _scaleIncrement; 
	[HideInInspector] 
	private Vector3 _scale; 
	private RectTransform _thisTransform; 


private void Awake() { }

public void OnScroll(PointerEventData eventData) { }

public void .ctor() { }

}

