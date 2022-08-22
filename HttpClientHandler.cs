public class HttpClientHandler : HttpMessageHandler // TypeDefIndex: 5740
{	private static long groupCounter; // 0x0
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

	public CookieContainer CookieContainer { get; }
	public long MaxRequestContentBufferSize { get; }


	public void .ctor() { }

	public CookieContainer get_CookieContainer() { }

	public long get_MaxRequestContentBufferSize() { }

	protected override void Dispose(bool disposing) { }

	internal virtual HttpWebRequest CreateWebRequest(HttpRequestMessage request) { }

	private HttpResponseMessage CreateResponseMessage(HttpWebResponse wr, HttpRequestMessage requestMessage, CancellationToken cancellationToken) { }

	private static bool MethodHasBody(HttpMethod method) { }

	[AsyncStateMachineAttribute] // RVA: 0xD15B0 Offset: 0xD09B0 VA: 0x1800D15B0
	protected internal override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken) { }

}

private sealed class HttpClientHandler.<>c // TypeDefIndex: 5741
{	public static readonly HttpClientHandler.<>c <>9; // 0x0
	public static Func<string, bool> <>9__61_0; // 0x8
	public static Action<object> <>9__64_0; // 0x10


	private static void .cctor() { }

	public void .ctor() { }

	internal bool <CreateWebRequest>b__61_0(string l) { }

	internal void <SendAsync>b__64_0(object l) { }

}

private struct HttpClientHandler.<SendAsync>d__64 : IAsyncStateMachine // TypeDefIndex: 5742
{	public int <>1__state; // 0x0
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


	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

