public class ZoomImage : MonoBehaviour, IScrollHandler, IEventSystemHandler // TypeDefIndex: 10918
{	// Fields
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private float _minimumScale; // 0x18
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private float _initialScale; // 0x1C
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private float _maximumScale; // 0x20
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private float _scaleIncrement; // 0x24
	[HideInInspector] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Vector3 _scale; // 0x28
	private RectTransform _thisTransform; // 0x38

	// Methods

	// RVA: 0x1A97980 Offset: 0x1A96D80 VA: 0x181A97980
	private void Awake() { }

	// RVA: 0x1A97A40 Offset: 0x1A96E40 VA: 0x181A97A40 Slot: 4
	public void OnScroll(PointerEventData eventData) { }

	// RVA: 0x1A97D10 Offset: 0x1A97110 VA: 0x181A97D10
	public void .ctor() { }

}

