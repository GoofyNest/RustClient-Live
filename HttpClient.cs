public class HttpClient : HttpMessageInvoker // TypeDefIndex: 5737
{
	private static readonly TimeSpan TimeoutDefault; 
	private Uri base_address; 
	private CancellationTokenSource cts; 
	private bool disposed; 
	private HttpRequestHeaders headers; 
	private long buffer_size; 
	private TimeSpan timeout; 

	public long MaxResponseContentBufferSize { get; }
	public TimeSpan Timeout { set; }


	public void .ctor() { }

	public void .ctor(HttpMessageHandler handler, bool disposeHandler) { }

	public long get_MaxResponseContentBufferSize() { }

	public void set_Timeout(TimeSpan value) { }

	protected override void Dispose(bool disposing) { }

	public Task<HttpResponseMessage> GetAsync(string requestUri, HttpCompletionOption completionOption) { }

	public Task<HttpResponseMessage> PostAsync(string requestUri, HttpContent content) { }

	public Task<HttpResponseMessage> SendAsync(HttpRequestMessage request) { }

	public Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, HttpCompletionOption completionOption) { }

	public override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken) { }

	public Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, HttpCompletionOption completionOption, CancellationToken cancellationToken) { }

	[AsyncStateMachineAttribute] 
	private Task<HttpResponseMessage> SendAsyncWorker(HttpRequestMessage request, HttpCompletionOption completionOption, CancellationToken cancellationToken) { }

	[AsyncStateMachineAttribute] 
	public Task<string> GetStringAsync(string requestUri) { }

	private static void .cctor() { }

	[DebuggerHiddenAttribute] 
	[CompilerGeneratedAttribute] 
	private Task<HttpResponseMessage> <>n__0(HttpRequestMessage request, CancellationToken cancellationToken) { }

}

private struct HttpClient.<SendAsyncWorker>d__47 : IAsyncStateMachine // TypeDefIndex: 5738
{
	public int <>1__state; 
	public AsyncTaskMethodBuilder<HttpResponseMessage> <>t__builder; 
	public HttpClient <>4__this; 
	public CancellationToken cancellationToken; 
	public HttpRequestMessage request; 
	public HttpCompletionOption completionOption; 
	private HttpResponseMessage <response>5__1; 
	private CancellationTokenSource <lcts>5__2; 
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<HttpResponseMessage> <>u__1; 
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__2; 


	private void MoveNext() { }

	[DebuggerHiddenAttribute] 
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

private struct HttpClient.<GetStringAsync>d__52 : IAsyncStateMachine // TypeDefIndex: 5739
{
	public int <>1__state; 
	public AsyncTaskMethodBuilder<string> <>t__builder; 
	public HttpClient <>4__this; 
	public string requestUri; 
	private HttpResponseMessage <resp>5__1; 
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<HttpResponseMessage> <>u__1; 
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<string> <>u__2; 


	private void MoveNext() { }

	[DebuggerHiddenAttribute] 
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

