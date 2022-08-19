public class HttpClient : HttpMessageInvoker // TypeDefIndex: 5737
{	// Fields
	private static readonly TimeSpan TimeoutDefault; // 0x0
	private Uri base_address; // 0x20
	private CancellationTokenSource cts; // 0x28
	private bool disposed; // 0x30
	private HttpRequestHeaders headers; // 0x38
	private long buffer_size; // 0x40
	private TimeSpan timeout; // 0x48

	// Properties
	public long MaxResponseContentBufferSize { get; }
	public TimeSpan Timeout { set; }

	// Methods

	// RVA: 0x1085230 Offset: 0x1084630 VA: 0x181085230
	public void .ctor() { }

	// RVA: 0x10853C0 Offset: 0x10847C0 VA: 0x1810853C0
	public void .ctor(HttpMessageHandler handler, bool disposeHandler) { }

	// RVA: 0x4B9440 Offset: 0x4B8840 VA: 0x1804B9440
	public long get_MaxResponseContentBufferSize() { }

	// RVA: 0x10854E0 Offset: 0x10848E0 VA: 0x1810854E0
	public void set_Timeout(TimeSpan value) { }

	// RVA: 0x10846D0 Offset: 0x1083AD0 VA: 0x1810846D0 Slot: 5
	protected override void Dispose(bool disposing) { }

	// RVA: 0x1084740 Offset: 0x1083B40 VA: 0x181084740
	public Task<HttpResponseMessage> GetAsync(string requestUri, HttpCompletionOption completionOption) { }

	// RVA: 0x10849B0 Offset: 0x1083DB0 VA: 0x1810849B0
	public Task<HttpResponseMessage> PostAsync(string requestUri, HttpContent content) { }

	// RVA: 0x1085110 Offset: 0x1084510 VA: 0x181085110
	public Task<HttpResponseMessage> SendAsync(HttpRequestMessage request) { }

	// RVA: 0x1084C60 Offset: 0x1084060 VA: 0x181084C60
	public Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, HttpCompletionOption completionOption) { }

	// RVA: 0x10850F0 Offset: 0x10844F0 VA: 0x1810850F0 Slot: 6
	public override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken) { }

	// RVA: 0x1084CF0 Offset: 0x10840F0 VA: 0x181084CF0
	public Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, HttpCompletionOption completionOption, CancellationToken cancellationToken) { }

	[AsyncStateMachineAttribute] // RVA: 0xD1070 Offset: 0xD0470 VA: 0x1800D1070
	// RVA: 0x1084B20 Offset: 0x1083F20 VA: 0x181084B20
	private Task<HttpResponseMessage> SendAsyncWorker(HttpRequestMessage request, HttpCompletionOption completionOption, CancellationToken cancellationToken) { }

	[AsyncStateMachineAttribute] // RVA: 0xD11B0 Offset: 0xD05B0 VA: 0x1800D11B0
	// RVA: 0x1084890 Offset: 0x1083C90 VA: 0x181084890
	public Task<string> GetStringAsync(string requestUri) { }

	// RVA: 0x10851C0 Offset: 0x10845C0 VA: 0x1810851C0
	private static void .cctor() { }

	[DebuggerHiddenAttribute] // RVA: 0x71590 Offset: 0x70990 VA: 0x180071590
	[CompilerGeneratedAttribute] // RVA: 0x71590 Offset: 0x70990 VA: 0x180071590
	// RVA: 0x1085190 Offset: 0x1084590 VA: 0x181085190
	private Task<HttpResponseMessage> <>n__0(HttpRequestMessage request, CancellationToken cancellationToken) { }

}

private struct HttpClient.<SendAsyncWorker>d__47 : IAsyncStateMachine // TypeDefIndex: 5738
{	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<HttpResponseMessage> <>t__builder; // 0x8
	public HttpClient <>4__this; // 0x20
	public CancellationToken cancellationToken; // 0x28
	public HttpRequestMessage request; // 0x30
	public HttpCompletionOption completionOption; // 0x38
	private HttpResponseMessage <response>5__1; // 0x40
	private CancellationTokenSource <lcts>5__2; // 0x48
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<HttpResponseMessage> <>u__1; // 0x50
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__2; // 0x60

	// Methods

	// RVA: 0x19DFF0 Offset: 0x19D3F0 VA: 0x18019DFF0 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x19E000 Offset: 0x19D400 VA: 0x18019E000 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

private struct HttpClient.<GetStringAsync>d__52 : IAsyncStateMachine // TypeDefIndex: 5739
{	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<string> <>t__builder; // 0x8
	public HttpClient <>4__this; // 0x20
	public string requestUri; // 0x28
	private HttpResponseMessage <resp>5__1; // 0x30
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<HttpResponseMessage> <>u__1; // 0x38
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<string> <>u__2; // 0x48

	// Methods

	// RVA: 0x19DE60 Offset: 0x19D260 VA: 0x18019DE60 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x19DE70 Offset: 0x19D270 VA: 0x18019DE70 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

