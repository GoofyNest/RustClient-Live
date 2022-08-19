public class HttpClientHandler : HttpMessageHandler // TypeDefIndex: 5740
{	// Fields
	private static long groupCounter; // 0x0
	private bool allowAutoRedirect; // 0x10
	private DecompressionMethods automaticDecompression; // 0x14
	private CookieContainer cookieContainer; // 0x18
	private ICredentials credentials; // 0x20
	private int maxAutomaticRedirections; // 0x28
	private long maxRequestContentBufferSize; // 0x30
	private bool preAuthenticate; // 0x38
	private IWebProxy proxy; // 0x40
	private bool useCookies; // 0x48
	private bool useDefaultCredentials; // 0x49
	private bool useProxy; // 0x4A
	private bool sentRequest; // 0x4B
	private string connectionGroupName; // 0x50
	private bool disposed; // 0x58

	// Properties
	public CookieContainer CookieContainer { get; }
	public long MaxRequestContentBufferSize { get; }

	// Methods

	// RVA: 0x10845C0 Offset: 0x10839C0 VA: 0x1810845C0
	public void .ctor() { }

	// RVA: 0x1084660 Offset: 0x1083A60 VA: 0x181084660
	public CookieContainer get_CookieContainer() { }

	// RVA: 0x4A2EE0 Offset: 0x4A22E0 VA: 0x1804A2EE0
	public long get_MaxRequestContentBufferSize() { }

	// RVA: 0x1084350 Offset: 0x1083750 VA: 0x181084350 Slot: 5
	protected override void Dispose(bool disposing) { }

	// RVA: 0x10838E0 Offset: 0x1082CE0 VA: 0x1810838E0 Slot: 7
	internal virtual HttpWebRequest CreateWebRequest(HttpRequestMessage request) { }

	// RVA: 0x1083670 Offset: 0x1082A70 VA: 0x181083670
	private HttpResponseMessage CreateResponseMessage(HttpWebResponse wr, HttpRequestMessage requestMessage, CancellationToken cancellationToken) { }

	// RVA: 0x10843D0 Offset: 0x10837D0 VA: 0x1810843D0
	private static bool MethodHasBody(HttpMethod method) { }

	[AsyncStateMachineAttribute] // RVA: 0xD15B0 Offset: 0xD09B0 VA: 0x1800D15B0
	// RVA: 0x1084490 Offset: 0x1083890 VA: 0x181084490 Slot: 6
	protected internal override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken) { }

}

private sealed class HttpClientHandler.<>c // TypeDefIndex: 5741
{	// Fields
	public static readonly HttpClientHandler.<>c <>9; // 0x0
	public static Func<string, bool> <>9__61_0; // 0x8
	public static Action<object> <>9__64_0; // 0x10

	// Methods

	// RVA: 0x1095D90 Offset: 0x1095190 VA: 0x181095D90
	private static void .cctor() { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x1095920 Offset: 0x1094D20 VA: 0x181095920
	internal bool <CreateWebRequest>b__61_0(string l) { }

	// RVA: 0x1095960 Offset: 0x1094D60 VA: 0x181095960
	internal void <SendAsync>b__64_0(object l) { }

}

private struct HttpClientHandler.<SendAsync>d__64 : IAsyncStateMachine // TypeDefIndex: 5742
{	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<HttpResponseMessage> <>t__builder; // 0x8
	public HttpClientHandler <>4__this; // 0x20
	public HttpRequestMessage request; // 0x28
	public CancellationToken cancellationToken; // 0x30
	private HttpWebRequest <wrequest>5__1; // 0x38
	private HttpContent <content>5__2; // 0x40
	private Stream <stream>5__3; // 0x48
	private HttpWebResponse <wresponse>5__4; // 0x50
	private CancellationTokenRegistration <>7__wrap1; // 0x58
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1; // 0x70
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<Stream> <>u__2; // 0x80
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<WebResponse> <>u__3; // 0x90
	private TaskAwaiter<HttpResponseMessage> <>u__4; // 0xA0

	// Methods

	// RVA: 0x19DF90 Offset: 0x19D390 VA: 0x18019DF90 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x19DFA0 Offset: 0x19D3A0 VA: 0x18019DFA0 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

