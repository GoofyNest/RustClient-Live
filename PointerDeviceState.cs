internal static class PointerDeviceState // TypeDefIndex: 4685
{	// Fields
	private static Vector2[] m_Positions; // 0x0
	private static IPanel[] m_Panels; // 0x8
	private static int[] m_PressedButtons; // 0x10

	// Methods

	// RVA: 0xECA8D0 Offset: 0xEC9CD0 VA: 0x180ECA8D0
	public static void SavePointerPosition(int pointerId, Vector2 position, IPanel panel) { }

	// RVA: 0xECA680 Offset: 0xEC9A80 VA: 0x180ECA680
	public static void PressButton(int pointerId, int buttonId) { }

	// RVA: 0xECA7F0 Offset: 0xEC9BF0 VA: 0x180ECA7F0
	public static void ReleaseButton(int pointerId, int buttonId) { }

	// RVA: 0xECA760 Offset: 0xEC9B60 VA: 0x180ECA760
	public static void ReleaseAllButtons(int pointerId) { }

	// RVA: 0xECA4C0 Offset: 0xEC98C0 VA: 0x180ECA4C0
	public static Vector2 GetPointerPosition(int pointerId) { }

	// RVA: 0xECA550 Offset: 0xEC9950 VA: 0x180ECA550
	public static int GetPressedButtons(int pointerId) { }

	// RVA: 0xECA5E0 Offset: 0xEC99E0 VA: 0x180ECA5E0
	internal static bool HasAdditionalPressedButtons(int pointerId, int exceptButtonId) { }

	// RVA: 0xECAA00 Offset: 0xEC9E00 VA: 0x180ECAA00
	private static void .cctor() { }

}

