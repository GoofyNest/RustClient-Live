public class DynamicMouseCursor : MonoBehaviour // TypeDefIndex: 10920
{	// Fields
	public Texture2D RegularCursor; // 0x18
	public Vector2 RegularCursorPos; // 0x20
	public Texture2D HoverCursor; // 0x28
	public Vector2 HoverCursorPos; // 0x30
	private Texture2D current; // 0x38
	private PointerEventData pointer; // 0x40
	private List<RaycastResult> results; // 0x48

	// Methods

	// RVA: 0xAB0F70 Offset: 0xAB0370 VA: 0x180AB0F70
	private void LateUpdate() { }

	// RVA: 0xAB10D0 Offset: 0xAB04D0 VA: 0x180AB10D0
	private void UpdateCursor(Texture2D cursor, Vector2 offs) { }

	// RVA: 0xAB0CD0 Offset: 0xAB00D0 VA: 0x180AB0CD0
	private GameObject CurrentlyHoveredItem() { }

	// RVA: 0xAB1180 Offset: 0xAB0580 VA: 0x180AB1180
	public void .ctor() { }

}

