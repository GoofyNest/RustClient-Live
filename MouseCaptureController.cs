public static class MouseCaptureController // TypeDefIndex: 4599
{
	private static bool m_IsMouseCapturedWarningEmitted;
	private static bool m_ReleaseMouseWarningEmitted;


	[ExtensionAttribute]
	public static bool HasMouseCapture(IEventHandler handler) { }

	[ExtensionAttribute]
	public static void CaptureMouse(IEventHandler handler) { }

	[ExtensionAttribute]
	public static void ReleaseMouse(IEventHandler handler) { }

	private static void .cctor() { }

}

