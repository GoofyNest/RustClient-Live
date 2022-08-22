internal static class TraceInternal // TypeDefIndex: 2641
{	private static string appName; // 0x0
	private static TraceListenerCollection listeners; // 0x8
	private static bool autoFlush; // 0x10
	[ThreadStaticAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private static int indentLevel; // 0x80000000
	private static int indentSize; // 0x14
	internal static readonly object critSec; // 0x18

	public static TraceListenerCollection Listeners { get; }
	public static bool AutoFlush { get; }
	public static int IndentLevel { get; }
	public static int IndentSize { get; }


	public static TraceListenerCollection get_Listeners() { }

	public static bool get_AutoFlush() { }

	public static int get_IndentLevel() { }

	public static int get_IndentSize() { }

	private static void InitializeSettings() { }

	private static void .cctor() { }

}

