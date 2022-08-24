internal static class TraceInternal // TypeDefIndex: 2641
{
	private static string appName; 
	private static TraceListenerCollection listeners; 
	private static bool autoFlush; 
	[ThreadStaticAttribute] 
	private static int indentLevel; 
	private static int indentSize; 
	internal static readonly object critSec; 

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

