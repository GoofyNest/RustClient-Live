public static class Output // TypeDefIndex: 13793
{
	[CompilerGeneratedAttribute]
	private static Action<string, string, LogType> OnMessage;
	public static bool installed;
	public static List<Output.Entry> HistoryOutput;


	[CompilerGeneratedAttribute]
	public static void add_OnMessage(Action<string, string, LogType> value) { }

	[CompilerGeneratedAttribute]
	public static void remove_OnMessage(Action<string, string, LogType> value) { }

	public static void Install() { }

	internal static void LogHandler(string log, string stacktrace, LogType type) { }

	private static void .cctor() { }

}

public struct Output.Entry // TypeDefIndex: 13794
{
	public string Message;
	public string Stacktrace;
	public string Type;
	public int Time;

}

