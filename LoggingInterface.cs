public sealed class LoggingInterface // TypeDefIndex: 9060
{

	public static Result SetCallback(LogMessageFunc callback) { }

	public static Result SetLogLevel(LogCategory logCategory, LogLevel logLevel) { }

	[MonoPInvokeCallbackAttribute]
	internal static void LogMessageFuncInternalImplementation(ref LogMessageInternal message) { }

	public void .ctor() { }

}

