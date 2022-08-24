internal sealed class DebugLogHandler : ILogHandler // TypeDefIndex: 3370
{

	[ThreadAndSerializationSafeAttribute] 
internal static void Internal_Log(LogType level, LogOption options, string msg, Object obj) { }

	[ThreadAndSerializationSafeAttribute] 
internal static void Internal_LogException(Exception exception, Object obj) { }

public void LogFormat(LogType logType, Object context, string format, object[] args) { }

public void LogException(Exception exception, Object context) { }

public void .ctor() { }

}

