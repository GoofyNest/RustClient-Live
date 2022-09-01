public class FleckLog // TypeDefIndex: 6905
{
	public static LogLevel Level; 
	public static Action<LogLevel, string, Exception> LogAction; 


	public static void Warn(string message, Exception ex) { }

	public static void Error(string message, Exception ex) { }

	private static void .cctor() { }

}

private sealed class FleckLog.<>c // TypeDefIndex: 6906
{
	public static readonly FleckLog.<>c <>9; 


	private static void .cctor() { }

	public void .ctor() { }

	internal void <.cctor>b__7_0(LogLevel level, string message, Exception ex) { }

}

