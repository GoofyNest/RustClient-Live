public class Cursor // TypeDefIndex: 3455
{
	public static bool visible { get; set; }
	public static CursorLockMode lockState { get; set; }


	public static void SetCursor(Texture2D texture, Vector2 hotspot, CursorMode cursorMode) { }

	public static bool get_visible() { }

	public static void set_visible(bool value) { }

	public static CursorLockMode get_lockState() { }

	public static void set_lockState(CursorLockMode value) { }

	private static void SetCursor_Injected(Texture2D texture, ref Vector2 hotspot, CursorMode cursorMode) { }

}

