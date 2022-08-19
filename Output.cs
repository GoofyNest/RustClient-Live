public static class Output // TypeDefIndex: 11984
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private static Action<string, string, LogType> OnMessage; // 0x0
	public static bool installed; // 0x8
	public static List<Output.Entry> HistoryOutput; // 0x10

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x792BD0 Offset: 0x791FD0 VA: 0x180792BD0
	public static void add_OnMessage(Action<string, string, LogType> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x792CC0 Offset: 0x7920C0 VA: 0x180792CC0
	public static void remove_OnMessage(Action<string, string, LogType> value) { }

	// RVA: 0x7924B0 Offset: 0x7918B0 VA: 0x1807924B0
	public static void Install() { }

	// RVA: 0x792580 Offset: 0x791980 VA: 0x180792580
	internal static void LogHandler(string log, string stacktrace, LogType type) { }

	// RVA: 0x792B50 Offset: 0x791F50 VA: 0x180792B50
	private static void .cctor() { }

}

public struct Output.Entry // TypeDefIndex: 11985
{	// Fields
	public string Message; // 0x0
	public string Stacktrace; // 0x8
	public string Type; // 0x10
	public int Time; // 0x18

}

