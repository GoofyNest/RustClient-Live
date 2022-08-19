public class Cursor // TypeDefIndex: 3454
{	// Properties
	public static bool visible { get; set; }
	public static CursorLockMode lockState { get; set; }

	// Methods

	// RVA: 0x1822A00 Offset: 0x1821E00 VA: 0x181822A00
	public static void SetCursor(Texture2D texture, Vector2 hotspot, CursorMode cursorMode) { }

	// RVA: 0x1822A80 Offset: 0x1821E80 VA: 0x181822A80
	public static bool get_visible() { }

	// RVA: 0x1822AF0 Offset: 0x1821EF0 VA: 0x181822AF0
	public static void set_visible(bool value) { }

	// RVA: 0x1822A50 Offset: 0x1821E50 VA: 0x181822A50
	public static CursorLockMode get_lockState() { }

	// RVA: 0x1822AB0 Offset: 0x1821EB0 VA: 0x181822AB0
	public static void set_lockState(CursorLockMode value) { }

	// RVA: 0x18229A0 Offset: 0x1821DA0 VA: 0x1818229A0
	private static void SetCursor_Injected(Texture2D texture, ref Vector2 hotspot, CursorMode cursorMode) { }

}

