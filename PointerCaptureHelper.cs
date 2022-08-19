public static class PointerCaptureHelper // TypeDefIndex: 4603
{	// Methods

	// RVA: 0xEC9F30 Offset: 0xEC9330 VA: 0x180EC9F30
	private static PointerDispatchState GetStateFor(IEventHandler handler) { }

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xEC9FD0 Offset: 0xEC93D0 VA: 0x180EC9FD0
	public static bool HasPointerCapture(IEventHandler handler, int pointerId) { }

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xEC9CA0 Offset: 0xEC90A0 VA: 0x180EC9CA0
	public static void CapturePointer(IEventHandler handler, int pointerId) { }

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xECA250 Offset: 0xEC9650 VA: 0x180ECA250
	public static void ReleasePointer(IEventHandler handler, int pointerId) { }

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xEC9E90 Offset: 0xEC9290 VA: 0x180EC9E90
	public static IEventHandler GetCapturingElement(IPanel panel, int pointerId) { }

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xECA1B0 Offset: 0xEC95B0 VA: 0x180ECA1B0
	public static void ReleasePointer(IPanel panel, int pointerId) { }

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xEC9C10 Offset: 0xEC9010 VA: 0x180EC9C10
	internal static void ActivateCompatibilityMouseEvents(IPanel panel, int pointerId) { }

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xECA0B0 Offset: 0xEC94B0 VA: 0x180ECA0B0
	internal static void PreventCompatibilityMouseEvents(IPanel panel, int pointerId) { }

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xECA340 Offset: 0xEC9740 VA: 0x180ECA340
	internal static bool ShouldSendCompatibilityMouseEvents(IPanel panel, IPointerEvent evt) { }

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xECA140 Offset: 0xEC9540 VA: 0x180ECA140
	internal static void ProcessPointerCapture(IPanel panel, int pointerId) { }

}

