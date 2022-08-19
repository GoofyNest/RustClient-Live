public static class WebUtil // TypeDefIndex: 6230
{	// Methods

	// RVA: 0x14F5240 Offset: 0x14F4640 VA: 0x1814F5240
	internal static void Get(string url, Action<string> result) { }

	[IteratorStateMachineAttribute] // RVA: 0xAAFC0 Offset: 0xAA3C0 VA: 0x1800AAFC0
	// RVA: 0x14F5010 Offset: 0x14F4410 VA: 0x1814F5010
	private static IEnumerator DownloadStringCoroutine(UnityWebRequest www, Action<string> result) { }

	[AsyncStateMachineAttribute] // RVA: 0xAB120 Offset: 0xAA520 VA: 0x1800AB120
	// RVA: 0x14F4EE0 Offset: 0x14F42E0 VA: 0x1814F4EE0
	public static Task<string> DownloadFileTemp(string url, bool keepextension) { }

	// RVA: 0x14F50A0 Offset: 0x14F44A0 VA: 0x1814F50A0
	private static void DownloadString(UnityWebRequest www, Action<string> result) { }

	// RVA: 0x14F5920 Offset: 0x14F4D20 VA: 0x1814F5920
	internal static void Post(string url, Dictionary<string, string> data, bool wait, Action<string> result) { }

	[AsyncStateMachineAttribute] // RVA: 0xAB280 Offset: 0xAA680 VA: 0x1800AB280
	// RVA: 0x14F53C0 Offset: 0x14F47C0 VA: 0x1814F53C0
	internal static Task<string> PostAsync(string url, Dictionary<string, string> data) { }

	// RVA: 0x14F5600 Offset: 0x14F4A00 VA: 0x1814F5600
	internal static void PostData(string url, object dataObject, Action<string> result, bool wait = False) { }

	[AsyncStateMachineAttribute] // RVA: 0xAB3F0 Offset: 0xAA7F0 VA: 0x1800AB3F0
	// RVA: 0x14F54E0 Offset: 0x14F48E0 VA: 0x1814F54E0
	internal static Task<string> PostDataAsync(string url, object dataObject) { }

	[IteratorStateMachineAttribute] // RVA: 0xAB580 Offset: 0xAA980 VA: 0x1800AB580
	// RVA: 0x14F5890 Offset: 0x14F4C90 VA: 0x1814F5890
	private static IEnumerator PostValuesCoroutine(WWW www, Action<string> result) { }

	// RVA: 0x14F5230 Offset: 0x14F4630 VA: 0x1814F5230
	internal static string Escape(string type) { }

}

private class WebUtil.AcceptAllCertificates : CertificateHandler // TypeDefIndex: 6231
{	// Methods

	// RVA: 0x4D1BF0 Offset: 0x4D0FF0 VA: 0x1804D1BF0 Slot: 5
	protected override bool ValidateCertificate(byte[] certificateData) { }

	// RVA: 0x14E03C0 Offset: 0x14DF7C0 VA: 0x1814E03C0
	public void .ctor() { }

}

private sealed class WebUtil.<DownloadStringCoroutine>d__2 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 6232
{	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public UnityWebRequest www; // 0x20
	public Action<string> result; // 0x28

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497770 Offset: 0x496B70 VA: 0x180497770
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x14F15A0 Offset: 0x14F09A0 VA: 0x1814F15A0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x14F1900 Offset: 0x14F0D00 VA: 0x1814F1900 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

}

private struct WebUtil.<DownloadFileTemp>d__3 : IAsyncStateMachine // TypeDefIndex: 6233
{	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<string> <>t__builder; // 0x8
	public bool keepextension; // 0x20
	public string url; // 0x28
	private string <targetName>5__2; // 0x30
	private FileInfo <fileInfo>5__3; // 0x38
	private UnityWebRequest <request>5__4; // 0x40
	private TaskAwaiter <>u__1; // 0x48

	// Methods

	// RVA: 0x1F1820 Offset: 0x1F0C20 VA: 0x1801F1820 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1F1830 Offset: 0x1F0C30 VA: 0x1801F1830 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

private struct WebUtil.<PostAsync>d__6 : IAsyncStateMachine // TypeDefIndex: 6234
{	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<string> <>t__builder; // 0x8
	public string url; // 0x20
	public Dictionary<string, string> data; // 0x28
	private Stopwatch <waitTime>5__2; // 0x30
	private UnityWebRequest <request>5__3; // 0x38
	private TaskAwaiter <>u__1; // 0x40

	// Methods

	// RVA: 0x1F1880 Offset: 0x1F0C80 VA: 0x1801F1880 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1F1890 Offset: 0x1F0C90 VA: 0x1801F1890 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

private struct WebUtil.<PostDataAsync>d__8 : IAsyncStateMachine // TypeDefIndex: 6235
{	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<string> <>t__builder; // 0x8
	public object dataObject; // 0x20
	public string url; // 0x28
	private UnityWebRequest <www>5__2; // 0x30
	private UnityWebRequestAsyncOperation <request>5__3; // 0x38
	private Stopwatch <waitTime>5__4; // 0x40
	private TaskAwaiter <>u__1; // 0x48

	// Methods

	// RVA: 0x1F18E0 Offset: 0x1F0CE0 VA: 0x1801F18E0 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1F18F0 Offset: 0x1F0CF0 VA: 0x1801F18F0 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

private sealed class WebUtil.<PostValuesCoroutine>d__9 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 6236
{	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public WWW www; // 0x20
	public Action<string> result; // 0x28

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497770 Offset: 0x496B70 VA: 0x180497770
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x14F2540 Offset: 0x14F1940 VA: 0x1814F2540 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x14F2950 Offset: 0x14F1D50 VA: 0x1814F2950 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

}

