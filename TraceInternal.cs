internal static class TraceInternal // TypeDefIndex: 2641
{	// Fields
	private static string appName; // 0x0
	private static TraceListenerCollection listeners; // 0x8
	private static bool autoFlush; // 0x10
	[ThreadStaticAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private static int indentLevel; // 0x80000000
	private static int indentSize; // 0x14
	internal static readonly object critSec; // 0x18

	// Properties
	public static TraceListenerCollection Listeners { get; }
	public static bool AutoFlush { get; }
	public static int IndentLevel { get; }
	public static int IndentSize { get; }

	// Methods

	// RVA: 0x17314C0 Offset: 0x17308C0 VA: 0x1817314C0
	public static TraceListenerCollection get_Listeners() { }

	// RVA: 0x17313A0 Offset: 0x17307A0 VA: 0x1817313A0
	public static bool get_AutoFlush() { }

	// RVA: 0x1731410 Offset: 0x1730810 VA: 0x181731410
	public static int get_IndentLevel() { }

	// RVA: 0x1731460 Offset: 0x1730860 VA: 0x181731460
	public static int get_IndentSize() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0
	private static void InitializeSettings() { }

	// RVA: 0x1731320 Offset: 0x1730720 VA: 0x181731320
	private static void .cctor() { }

}

