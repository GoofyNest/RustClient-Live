public class DynamicMouseCursor : MonoBehaviour // TypeDefIndex: 10920
{	public Texture2D RegularCursor; // 0x18
	public Vector2 RegularCursorPos; // 0x20
	public Texture2D HoverCursor; // 0x28
	public Vector2 HoverCursorPos; // 0x30
	private Texture2D current; // 0x38
	private PointerEventData pointer; // 0x40
	private List<RaycastResult> results; // 0x48


	private void LateUpdate() { }

	private void UpdateCursor(Texture2D cursor, Vector2 offs) { }

	private GameObject CurrentlyHoveredItem() { }

	public void .ctor() { }

}

