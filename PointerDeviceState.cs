internal static class PointerDeviceState // TypeDefIndex: 4685
{	private static Vector2[] m_Positions; // 0x0
	private static IPanel[] m_Panels; // 0x8
	private static int[] m_PressedButtons; // 0x10


	public static void SavePointerPosition(int pointerId, Vector2 position, IPanel panel) { }

	public static void PressButton(int pointerId, int buttonId) { }

	public static void ReleaseButton(int pointerId, int buttonId) { }

	public static void ReleaseAllButtons(int pointerId) { }

	public static Vector2 GetPointerPosition(int pointerId) { }

	public static int GetPressedButtons(int pointerId) { }

	internal static bool HasAdditionalPressedButtons(int pointerId, int exceptButtonId) { }

	private static void .cctor() { }

}

