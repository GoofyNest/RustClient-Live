internal static class PointerDeviceState // TypeDefIndex: 4690
{
	private static Vector2[] m_Positions; 
	private static IPanel[] m_Panels; 
	private static int[] m_PressedButtons; 


	public static void SavePointerPosition(int pointerId, Vector2 position, IPanel panel) { }

	public static void PressButton(int pointerId, int buttonId) { }

	public static void ReleaseButton(int pointerId, int buttonId) { }

	public static void ReleaseAllButtons(int pointerId) { }

	public static Vector2 GetPointerPosition(int pointerId) { }

	public static int GetPressedButtons(int pointerId) { }

	internal static bool HasAdditionalPressedButtons(int pointerId, int exceptButtonId) { }

	private static void .cctor() { }

}

