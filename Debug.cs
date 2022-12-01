internal static class Debug // TypeDefIndex: 2456
{

	public static void CheckAndThrow(UnityTls.unitytls_errorstate errorState, string context, AlertDescription defaultAlert = 80) { }

	public static void CheckAndThrow(UnityTls.unitytls_errorstate errorState, UnityTls.unitytls_x509verify_result verifyResult, string context, AlertDescription defaultAlert = 80) { }

}

public class Debug // TypeDefIndex: 3371
{
	internal static ILogger s_Logger;

	public static ILogger unityLogger { get; }


	public static ILogger get_unityLogger() { }

	[ExcludeFromDocsAttribute]
	public static void DrawLine(Vector3 start, Vector3 end, Color color, float duration) { }

	[ExcludeFromDocsAttribute]
	public static void DrawLine(Vector3 start, Vector3 end, Color color) { }

	[FreeFunctionAttribute]
	public static void DrawLine(Vector3 start, Vector3 end, Color color, float duration, bool depthTest) { }

	[ExcludeFromDocsAttribute]
	public static void DrawRay(Vector3 start, Vector3 dir, Color color, float duration) { }

	[ExcludeFromDocsAttribute]
	public static void DrawRay(Vector3 start, Vector3 dir, Color color) { }

	public static void DrawRay(Vector3 start, Vector3 dir, Color color, float duration, bool depthTest) { }

	public static void Log(object message) { }

	public static void Log(object message, Object context) { }

	public static void LogFormat(string format, object[] args) { }

	public static void LogError(object message) { }

	public static void LogError(object message, Object context) { }

	public static void LogErrorFormat(string format, object[] args) { }

	public static void LogErrorFormat(Object context, string format, object[] args) { }

	public static void LogException(Exception exception) { }

	public static void LogException(Exception exception, Object context) { }

	public static void LogWarning(object message) { }

	public static void LogWarning(object message, Object context) { }

	public static void LogWarningFormat(string format, object[] args) { }

	public static void LogWarningFormat(Object context, string format, object[] args) { }

	[ConditionalAttribute]
	public static void Assert(bool condition) { }

	[ConditionalAttribute]
	public static void Assert(bool condition, string message) { }

	[ConditionalAttribute]
	public static void Assert(bool condition, string message, Object context) { }

	[ConditionalAttribute]
	public static void LogAssertion(object message) { }

	[RequiredByNativeCodeAttribute]
	internal static bool CallOverridenDebugHandler(Exception exception, Object obj) { }

	private static void .cctor() { }

	private static void DrawLine_Injected(ref Vector3 start, ref Vector3 end, ref Color color, float duration, bool depthTest) { }

}

