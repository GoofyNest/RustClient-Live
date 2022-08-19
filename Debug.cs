internal static class Debug // TypeDefIndex: 2456
{	// Methods

	// RVA: 0x12116B0 Offset: 0x1210AB0 VA: 0x1812116B0
	public static void CheckAndThrow(UnityTls.unitytls_errorstate errorState, string context, AlertDescription defaultAlert = 80) { }

	// RVA: 0x1211590 Offset: 0x1210990 VA: 0x181211590
	public static void CheckAndThrow(UnityTls.unitytls_errorstate errorState, UnityTls.unitytls_x509verify_result verifyResult, string context, AlertDescription defaultAlert = 80) { }

}

public class Debug // TypeDefIndex: 3371
{	// Fields
	internal static ILogger s_Logger; // 0x2B0AB00

	// Properties
	public static ILogger unityLogger { get; }

	// Methods

	// RVA: 0x1824410 Offset: 0x1823810 VA: 0x181824410
	public static ILogger get_unityLogger() { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1823180 Offset: 0x1822580 VA: 0x181823180
	public static void DrawLine(Vector3 start, Vector3 end, Color color, float duration) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1823350 Offset: 0x1822750 VA: 0x181823350
	public static void DrawLine(Vector3 start, Vector3 end, Color color) { }

	[FreeFunctionAttribute] // RVA: 0x7BD30 Offset: 0x7B130 VA: 0x18007BD30
	// RVA: 0x18232A0 Offset: 0x18226A0 VA: 0x1818232A0
	public static void DrawLine(Vector3 start, Vector3 end, Color color, float duration, bool depthTest) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1823460 Offset: 0x1822860 VA: 0x181823460
	public static void DrawRay(Vector3 start, Vector3 dir, Color color) { }

	// RVA: 0x1823610 Offset: 0x1822A10 VA: 0x181823610
	public static void DrawRay(Vector3 start, Vector3 dir, Color color, float duration, bool depthTest) { }

	// RVA: 0x18241E0 Offset: 0x18235E0 VA: 0x1818241E0
	public static void Log(object message) { }

	// RVA: 0x18242B0 Offset: 0x18236B0 VA: 0x1818242B0
	public static void Log(object message, Object context) { }

	// RVA: 0x1823D80 Offset: 0x1823180 VA: 0x181823D80
	public static void LogFormat(string format, object[] args) { }

	// RVA: 0x1823A30 Offset: 0x1822E30 VA: 0x181823A30
	public static void LogError(object message) { }

	// RVA: 0x1823B00 Offset: 0x1822F00 VA: 0x181823B00
	public static void LogError(object message, Object context) { }

	// RVA: 0x1823950 Offset: 0x1822D50 VA: 0x181823950
	public static void LogErrorFormat(string format, object[] args) { }

	// RVA: 0x1823860 Offset: 0x1822C60 VA: 0x181823860
	public static void LogErrorFormat(Object context, string format, object[] args) { }

	// RVA: 0x1823CB0 Offset: 0x18230B0 VA: 0x181823CB0
	public static void LogException(Exception exception) { }

	// RVA: 0x1823BE0 Offset: 0x1822FE0 VA: 0x181823BE0
	public static void LogException(Exception exception, Object context) { }

	// RVA: 0x1824030 Offset: 0x1823430 VA: 0x181824030
	public static void LogWarning(object message) { }

	// RVA: 0x1824100 Offset: 0x1823500 VA: 0x181824100
	public static void LogWarning(object message, Object context) { }

	// RVA: 0x1823E60 Offset: 0x1823260 VA: 0x181823E60
	public static void LogWarningFormat(string format, object[] args) { }

	// RVA: 0x1823F40 Offset: 0x1823340 VA: 0x181823F40
	public static void LogWarningFormat(Object context, string format, object[] args) { }

	[ConditionalAttribute] // RVA: 0x7CBD0 Offset: 0x7BFD0 VA: 0x18007CBD0
	// RVA: 0x1822CF0 Offset: 0x18220F0 VA: 0x181822CF0
	public static void Assert(bool condition) { }

	[ConditionalAttribute] // RVA: 0x7CBD0 Offset: 0x7BFD0 VA: 0x18007CBD0
	// RVA: 0x1822DD0 Offset: 0x18221D0 VA: 0x181822DD0
	public static void Assert(bool condition, string message) { }

	[ConditionalAttribute] // RVA: 0x7CBD0 Offset: 0x7BFD0 VA: 0x18007CBD0
	// RVA: 0x1822EB0 Offset: 0x18222B0 VA: 0x181822EB0
	public static void Assert(bool condition, string message, Object context) { }

	[ConditionalAttribute] // RVA: 0x7CBD0 Offset: 0x7BFD0 VA: 0x18007CBD0
	// RVA: 0x1823790 Offset: 0x1822B90 VA: 0x181823790
	public static void LogAssertion(object message) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1822FA0 Offset: 0x18223A0 VA: 0x181822FA0
	internal static bool CallOverridenDebugHandler(Exception exception, Object obj) { }

	// RVA: 0x1824390 Offset: 0x1823790 VA: 0x181824390
	private static void .cctor() { }

	// RVA: 0x1823110 Offset: 0x1822510 VA: 0x181823110
	private static void DrawLine_Injected(ref Vector3 start, ref Vector3 end, ref Color color, float duration, bool depthTest) { }

}

public static class Debug // TypeDefIndex: 7146
{	// Fields
	private static TextWriter writer; // 0x11BC0

	// Methods

	// RVA: 0x22DFFF0 Offset: 0x22DF3F0 VA: 0x1822DFFF0
	private static void .cctor() { }

	// RVA: 0x22DFDA0 Offset: 0x22DF1A0 VA: 0x1822DFDA0
	public static void SetOut(TextWriter writer) { }

	// RVA: 0x22DFF40 Offset: 0x22DF340 VA: 0x1822DFF40
	public static void WriteLine(string format, object[] args) { }

}

public sealed class Debug.WriterDelegate : MulticastDelegate // TypeDefIndex: 7147
{	// Methods

	// RVA: 0x4971F0 Offset: 0x4965F0 VA: 0x1804971F0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x12DD910 Offset: 0x12DCD10 VA: 0x1812DD910 Slot: 12
	public virtual void Invoke(string message) { }

	// RVA: 0x497210 Offset: 0x496610 VA: 0x180497210 Slot: 13
	public virtual IAsyncResult BeginInvoke(string message, AsyncCallback callback, object object) { }

	// RVA: 0x497050 Offset: 0x496450 VA: 0x180497050 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

private sealed class Debug.DummyWriter : TextWriter // TypeDefIndex: 7148
{	// Fields
	private Debug.WriterDelegate writer; // 0x28

	// Properties
	public override Encoding Encoding { get; }

	// Methods

	// RVA: 0x1624380 Offset: 0x1623780 VA: 0x181624380 Slot: 11
	public override Encoding get_Encoding() { }

	// RVA: 0x22E01A0 Offset: 0x22DF5A0 VA: 0x1822E01A0
	public void .ctor(Debug.WriterDelegate writer) { }

	// RVA: 0x22E0180 Offset: 0x22DF580 VA: 0x1822E0180 Slot: 19
	public override void WriteLine(string value) { }

}

private sealed class Debug.DummyWriter.<>c // TypeDefIndex: 7149
{	// Fields
	public static readonly Debug.DummyWriter.<>c <>9; // 0x0
	public static Debug.WriterDelegate <>9__3_0; // 0x8

	// Methods

	// RVA: 0x22E33A0 Offset: 0x22E27A0 VA: 0x1822E33A0
	private static void .cctor() { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0
	internal void <.ctor>b__3_0(string msg) { }

}

