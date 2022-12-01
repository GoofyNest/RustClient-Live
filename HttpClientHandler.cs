public class HttpClientHandler : HttpMessageHandler // TypeDefIndex: 5749
{
	private static long groupCounter;
	private bool allowAutoRedirect;
	private DecompressionMethods automaticDecompression;
	private CookieContainer cookieContainer;
	private ICredentials credentials;
	private int maxAutomaticRedirections;
	private long maxRequestContentBufferSize;
	private bool preAuthenticate;
	private IWebProxy proxy;
	private bool useCookies;
	private bool useDefaultCredentials;
	private bool useProxy;
	private bool sentRequest;
	private string connectionGroupName;
	private bool disposed;

	public CookieContainer CookieContainer { get; }
	public long MaxRequestContentBufferSize { get; }


	public void .ctor() { }

	public CookieContainer get_CookieContainer() { }

	public long get_MaxRequestContentBufferSize() { }

	protected override void Dispose(bool disposing) { }

	internal virtual HttpWebRequest CreateWebRequest(HttpRequestMessage request) { }

	private HttpResponseMessage CreateResponseMessage(HttpWebResponse wr, HttpRequestMessage requestMessage, CancellationToken cancellationToken) { }

	private static bool MethodHasBody(HttpMethod method) { }

	[AsyncStateMachineAttribute]
	protected internal override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken) { }

}

private sealed class HttpClientHandler.<>c // TypeDefIndex: 5750
{
	public static readonly HttpClientHandler.<>c <>9;
	public static Func<string, bool> <>9__61_0;
	public static Action<object> <>9__64_0;


	private static void .cctor() { }

	public void .ctor() { }

	internal bool <CreateWebRequest>

	internal void <SendAsync>

}

private struct HttpClientHandler.<SendAsync>d__64 : IAsyncStateMachine // TypeDefIndex: 5751
{
	public int <>1__state;
	public AsyncTaskMethodBuilder<HttpResponseMessage> <>t__builder;
	public HttpClientHandler <>4__this;
	public HttpRequestMessage request;
	public CancellationToken cancellationToken;
	private HttpWebRequest <wrequest>5__1;
	private HttpContent <content>5__2;
	private Stream <stream>5__3;
	private HttpWebResponse <wresponse>5__4;
	private CancellationTokenRegistration <>7__wrap1;
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1;
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<Stream> <>u__2;
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<WebResponse> <>u__3;
	private TaskAwaiter<HttpResponseMessage> <>u__4;


	private void MoveNext() { }

	[DebuggerHiddenAttribute]
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

