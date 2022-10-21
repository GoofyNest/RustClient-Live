public static class WebUtil // TypeDefIndex: 6235
{

	internal static void Get(string url, Action<string> result) { }

	[IteratorStateMachineAttribute] 
	private static IEnumerator DownloadStringCoroutine(UnityWebRequest www, Action<string> result) { }

	[AsyncStateMachineAttribute] 
	public static Task<string> DownloadFileTemp(string url, bool keepextension) { }

	private static void DownloadString(UnityWebRequest www, Action<string> result) { }

	internal static void Post(string url, Dictionary<string, string> data, bool wait, Action<string> result) { }

	[AsyncStateMachineAttribute] 
	internal static Task<string> PostAsync(string url, Dictionary<string, string> data) { }

	internal static void PostData(string url, object dataObject, Action<string> result, bool wait = False) { }

	[AsyncStateMachineAttribute] 
	internal static Task<string> PostDataAsync(string url, object dataObject) { }

	[IteratorStateMachineAttribute] 
	private static IEnumerator PostValuesCoroutine(WWW www, Action<string> result) { }

	internal static string Escape(string type) { }

}

private class WebUtil.AcceptAllCertificates : CertificateHandler // TypeDefIndex: 6236
{

	protected override bool ValidateCertificate(byte[] certificateData) { }

	public void .ctor() { }

}

private sealed class WebUtil.<DownloadStringCoroutine>d__2 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 6237
{
	private int <>1__state; 
	private object <>2__current; 
	public UnityWebRequest www; 
	public Action<string> result; 

	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }


	[DebuggerHiddenAttribute] 
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] 
	private void System.IDisposable.Dispose() { }

	private bool MoveNext() { }

	[DebuggerHiddenAttribute] 
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] 
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] 
	private object System.Collections.IEnumerator.get_Current() { }

}

private struct WebUtil.<DownloadFileTemp>d__3 : IAsyncStateMachine // TypeDefIndex: 6238
{
	public int <>1__state; 
	public AsyncTaskMethodBuilder<string> <>t__builder; 
	public bool keepextension; 
	public string url; 
	private string <targetName>5__2; 
	private FileInfo <fileInfo>5__3; 
	private UnityWebRequest <request>5__4; 
	private TaskAwaiter <>u__1; 


	private void MoveNext() { }

	[DebuggerHiddenAttribute] 
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

private struct WebUtil.<PostAsync>d__6 : IAsyncStateMachine // TypeDefIndex: 6239
{
	public int <>1__state; 
	public AsyncTaskMethodBuilder<string> <>t__builder; 
	public string url; 
	public Dictionary<string, string> data; 
	private Stopwatch <waitTime>5__2; 
	private UnityWebRequest <request>5__3; 
	private TaskAwaiter <>u__1; 


	private void MoveNext() { }

	[DebuggerHiddenAttribute] 
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

private struct WebUtil.<PostDataAsync>d__8 : IAsyncStateMachine // TypeDefIndex: 6240
{
	public int <>1__state; 
	public AsyncTaskMethodBuilder<string> <>t__builder; 
	public object dataObject; 
	public string url; 
	private UnityWebRequest <www>5__2; 
	private UnityWebRequestAsyncOperation <request>5__3; 
	private Stopwatch <waitTime>5__4; 
	private TaskAwaiter <>u__1; 


	private void MoveNext() { }

	[DebuggerHiddenAttribute] 
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

private sealed class WebUtil.<PostValuesCoroutine>d__9 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 6241
{
	private int <>1__state; 
	private object <>2__current; 
	public WWW www; 
	public Action<string> result; 

	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }


	[DebuggerHiddenAttribute] 
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] 
	private void System.IDisposable.Dispose() { }

	private bool MoveNext() { }

	[DebuggerHiddenAttribute] 
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] 
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] 
	private object System.Collections.IEnumerator.get_Current() { }

}

