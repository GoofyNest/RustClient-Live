public static class PointerCaptureHelper // TypeDefIndex: 4603
{

	private static PointerDispatchState GetStateFor(IEventHandler handler) { }

	[ExtensionAttribute] 
	public static bool HasPointerCapture(IEventHandler handler, int pointerId) { }

	[ExtensionAttribute] 
	public static void CapturePointer(IEventHandler handler, int pointerId) { }

	[ExtensionAttribute] 
	public static void ReleasePointer(IEventHandler handler, int pointerId) { }

	[ExtensionAttribute] 
	public static IEventHandler GetCapturingElement(IPanel panel, int pointerId) { }

	[ExtensionAttribute] 
	public static void ReleasePointer(IPanel panel, int pointerId) { }

	[ExtensionAttribute] 
	internal static void ActivateCompatibilityMouseEvents(IPanel panel, int pointerId) { }

	[ExtensionAttribute] 
	internal static void PreventCompatibilityMouseEvents(IPanel panel, int pointerId) { }

	[ExtensionAttribute] 
	internal static bool ShouldSendCompatibilityMouseEvents(IPanel panel, IPointerEvent evt) { }

	[ExtensionAttribute] 
	internal static void ProcessPointerCapture(IPanel panel, int pointerId) { }

}

