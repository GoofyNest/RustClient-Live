public abstract class WebRequest : MarshalByRefObject, ISerializable // TypeDefIndex: 2905
{
	private static ArrayList s_PrefixList; 
	private static object s_InternalSyncObject; 
	private static TimerThread.Queue s_DefaultTimerQueue; 
	private AuthenticationLevel m_AuthenticationLevel; 
	private TokenImpersonationLevel m_ImpersonationLevel; 
	private RequestCachePolicy m_CachePolicy; 
	private RequestCacheProtocol m_CacheProtocol; 
	private RequestCacheBinding m_CacheBinding; 
	private static WebRequest.DesignerWebRequestCreate webRequestCreate; 
	private static IWebProxy s_DefaultWebProxy; 
	private static bool s_DefaultWebProxyInitialized; 

private static object InternalSyncObject { get; }
internal static ArrayList PrefixList { get; }
public virtual RequestCachePolicy CachePolicy { set; }
public virtual string Method { get; set; }
public virtual Uri RequestUri { get; }
public virtual string ConnectionGroupName { set; }
public virtual WebHeaderCollection Headers { get; set; }
public virtual long ContentLength { get; set; }
public virtual string ContentType { get; set; }
public virtual ICredentials Credentials { get; set; }
public virtual bool UseDefaultCredentials { get; set; }
public virtual IWebProxy Proxy { get; set; }
public virtual bool PreAuthenticate { set; }
public virtual int Timeout { get; }
internal RequestCacheProtocol CacheProtocol { get; set; }
internal static IWebProxy InternalDefaultWebProxy { get; }
public static IWebProxy DefaultWebProxy { get; }


private static object get_InternalSyncObject() { }

private static WebRequest Create(Uri requestUri, bool useUriBase) { }

public static WebRequest Create(string requestUriString) { }

public static WebRequest Create(Uri requestUri) { }

internal static ArrayList get_PrefixList() { }

private static ArrayList PopulatePrefixList() { }

protected void .ctor() { }

protected void .ctor(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

protected virtual void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

public virtual void set_CachePolicy(RequestCachePolicy value) { }

private void InternalSetCachePolicy(RequestCachePolicy policy) { }

public virtual string get_Method() { }

public virtual void set_Method(string value) { }

public virtual Uri get_RequestUri() { }

public virtual void set_ConnectionGroupName(string value) { }

public virtual WebHeaderCollection get_Headers() { }

public virtual void set_Headers(WebHeaderCollection value) { }

public virtual long get_ContentLength() { }

public virtual void set_ContentLength(long value) { }

public virtual string get_ContentType() { }

public virtual void set_ContentType(string value) { }

public virtual ICredentials get_Credentials() { }

public virtual void set_Credentials(ICredentials value) { }

public virtual bool get_UseDefaultCredentials() { }

public virtual void set_UseDefaultCredentials(bool value) { }

public virtual IWebProxy get_Proxy() { }

public virtual void set_Proxy(IWebProxy value) { }

public virtual void set_PreAuthenticate(bool value) { }

public virtual int get_Timeout() { }

public virtual Stream GetRequestStream() { }

public virtual WebResponse GetResponse() { }

public virtual IAsyncResult BeginGetResponse(AsyncCallback callback, object state) { }

public virtual WebResponse EndGetResponse(IAsyncResult asyncResult) { }

public virtual IAsyncResult BeginGetRequestStream(AsyncCallback callback, object state) { }

public virtual Stream EndGetRequestStream(IAsyncResult asyncResult) { }

public virtual Task<Stream> GetRequestStreamAsync() { }

public virtual Task<WebResponse> GetResponseAsync() { }

private WindowsIdentity SafeCaptureIdenity() { }

public virtual void Abort() { }

internal RequestCacheProtocol get_CacheProtocol() { }

internal void set_CacheProtocol(RequestCacheProtocol value) { }

internal static IWebProxy get_InternalDefaultWebProxy() { }

public static IWebProxy get_DefaultWebProxy() { }

private static void .cctor() { }

	[CompilerGeneratedAttribute] 
private Task<Stream> <GetRequestStreamAsync>b__78_0() { }

	[CompilerGeneratedAttribute] 
private Task<WebResponse> <GetResponseAsync>b__79_0() { }

}

internal class WebRequest.DesignerWebRequestCreate : IWebRequestCreate // TypeDefIndex: 2906
{

public WebRequest Create(Uri uri) { }

public void .ctor() { }

}

internal class WebRequest.WebProxyWrapperOpaque : IWebProxy // TypeDefIndex: 2907
{
	protected readonly WebProxy webProxy; 

public ICredentials Credentials { get; }


public Uri GetProxy(Uri destination) { }

public bool IsBypassed(Uri host) { }

public ICredentials get_Credentials() { }

}

internal class WebRequest.WebProxyWrapper : WebRequest.WebProxyWrapperOpaque // TypeDefIndex: 2908
{
internal WebProxy WebProxy { get; }


internal WebProxy get_WebProxy() { }

}

private sealed class WebRequest.<>c__DisplayClass78_0 // TypeDefIndex: 2909
{
	public WindowsIdentity currentUser; 
	public WebRequest <>4__this; 


public void .ctor() { }

internal Task<Stream> <GetRequestStreamAsync>b__1() { }

}

private sealed class WebRequest.<>c__DisplayClass79_0 // TypeDefIndex: 2910
{
	public WindowsIdentity currentUser; 
	public WebRequest <>4__this; 


public void .ctor() { }

internal Task<WebResponse> <GetResponseAsync>b__1() { }

}

