public abstract class WebRequest : MarshalByRefObject, ISerializable // TypeDefIndex: 2905
{	// Fields
	private static ArrayList s_PrefixList; // 0x0
	private static object s_InternalSyncObject; // 0x8
	private static TimerThread.Queue s_DefaultTimerQueue; // 0x10
	private AuthenticationLevel m_AuthenticationLevel; // 0x18
	private TokenImpersonationLevel m_ImpersonationLevel; // 0x1C
	private RequestCachePolicy m_CachePolicy; // 0x20
	private RequestCacheProtocol m_CacheProtocol; // 0x28
	private RequestCacheBinding m_CacheBinding; // 0x30
	private static WebRequest.DesignerWebRequestCreate webRequestCreate; // 0x18
	private static IWebProxy s_DefaultWebProxy; // 0x20
	private static bool s_DefaultWebProxyInitialized; // 0x28

	// Properties
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

	// Methods

	// RVA: 0x1189610 Offset: 0x1188A10 VA: 0x181189610
	private static object get_InternalSyncObject() { }

	// RVA: 0x1188470 Offset: 0x1187870 VA: 0x181188470
	private static WebRequest Create(Uri requestUri, bool useUriBase) { }

	// RVA: 0x11882F0 Offset: 0x11876F0 VA: 0x1811882F0
	public static WebRequest Create(string requestUriString) { }

	// RVA: 0x11883B0 Offset: 0x11877B0 VA: 0x1811883B0
	public static WebRequest Create(Uri requestUri) { }

	// RVA: 0x1189750 Offset: 0x1188B50 VA: 0x181189750
	internal static ArrayList get_PrefixList() { }

	// RVA: 0x1188D30 Offset: 0x1188130 VA: 0x181188D30
	private static ArrayList PopulatePrefixList() { }

	// RVA: 0x1189270 Offset: 0x1188670 VA: 0x181189270
	protected void .ctor() { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	protected void .ctor(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x1188F90 Offset: 0x1188390 VA: 0x181188F90 Slot: 6
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 7
	protected virtual void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x1188C60 Offset: 0x1188060 VA: 0x181188C60 Slot: 8
	public virtual void set_CachePolicy(RequestCachePolicy value) { }

	// RVA: 0x1188C60 Offset: 0x1188060 VA: 0x181188C60
	private void InternalSetCachePolicy(RequestCachePolicy policy) { }

	// RVA: 0x1189710 Offset: 0x1188B10 VA: 0x181189710 Slot: 9
	public virtual string get_Method() { }

	// RVA: 0x1189B70 Offset: 0x1188F70 VA: 0x181189B70 Slot: 10
	public virtual void set_Method(string value) { }

	// RVA: 0x1189970 Offset: 0x1188D70 VA: 0x181189970 Slot: 11
	public virtual Uri get_RequestUri() { }

	// RVA: 0x1189A30 Offset: 0x1188E30 VA: 0x181189A30 Slot: 12
	public virtual void set_ConnectionGroupName(string value) { }

	// RVA: 0x11893B0 Offset: 0x11887B0 VA: 0x1811893B0 Slot: 13
	public virtual WebHeaderCollection get_Headers() { }

	// RVA: 0x1189B30 Offset: 0x1188F30 VA: 0x181189B30 Slot: 14
	public virtual void set_Headers(WebHeaderCollection value) { }

	// RVA: 0x11892A0 Offset: 0x11886A0 VA: 0x1811892A0 Slot: 15
	public virtual long get_ContentLength() { }

	// RVA: 0x1189A70 Offset: 0x1188E70 VA: 0x181189A70 Slot: 16
	public virtual void set_ContentLength(long value) { }

	// RVA: 0x11892E0 Offset: 0x11886E0 VA: 0x1811892E0 Slot: 17
	public virtual string get_ContentType() { }

	// RVA: 0x1189AB0 Offset: 0x1188EB0 VA: 0x181189AB0 Slot: 18
	public virtual void set_ContentType(string value) { }

	// RVA: 0x1189320 Offset: 0x1188720 VA: 0x181189320 Slot: 19
	public virtual ICredentials get_Credentials() { }

	// RVA: 0x1189AF0 Offset: 0x1188EF0 VA: 0x181189AF0 Slot: 20
	public virtual void set_Credentials(ICredentials value) { }

	// RVA: 0x11899F0 Offset: 0x1188DF0 VA: 0x1811899F0 Slot: 21
	public virtual bool get_UseDefaultCredentials() { }

	// RVA: 0x1189C30 Offset: 0x1189030 VA: 0x181189C30 Slot: 22
	public virtual void set_UseDefaultCredentials(bool value) { }

	// RVA: 0x1189930 Offset: 0x1188D30 VA: 0x181189930 Slot: 23
	public virtual IWebProxy get_Proxy() { }

	// RVA: 0x1189BF0 Offset: 0x1188FF0 VA: 0x181189BF0 Slot: 24
	public virtual void set_Proxy(IWebProxy value) { }

	// RVA: 0x1189BB0 Offset: 0x1188FB0 VA: 0x181189BB0 Slot: 25
	public virtual void set_PreAuthenticate(bool value) { }

	// RVA: 0x11899B0 Offset: 0x1188DB0 VA: 0x1811899B0 Slot: 26
	public virtual int get_Timeout() { }

	// RVA: 0x11889A0 Offset: 0x1187DA0 VA: 0x1811889A0 Slot: 27
	public virtual Stream GetRequestStream() { }

	// RVA: 0x1188C20 Offset: 0x1188020 VA: 0x181188C20 Slot: 28
	public virtual WebResponse GetResponse() { }

	// RVA: 0x11882B0 Offset: 0x11876B0 VA: 0x1811882B0 Slot: 29
	public virtual IAsyncResult BeginGetResponse(AsyncCallback callback, object state) { }

	// RVA: 0x1188720 Offset: 0x1187B20 VA: 0x181188720 Slot: 30
	public virtual WebResponse EndGetResponse(IAsyncResult asyncResult) { }

	// RVA: 0x1188270 Offset: 0x1187670 VA: 0x181188270 Slot: 31
	public virtual IAsyncResult BeginGetRequestStream(AsyncCallback callback, object state) { }

	// RVA: 0x11886E0 Offset: 0x1187AE0 VA: 0x1811886E0 Slot: 32
	public virtual Stream EndGetRequestStream(IAsyncResult asyncResult) { }

	// RVA: 0x1188760 Offset: 0x1187B60 VA: 0x181188760 Slot: 33
	public virtual Task<Stream> GetRequestStreamAsync() { }

	// RVA: 0x11889E0 Offset: 0x1187DE0 VA: 0x1811889E0 Slot: 34
	public virtual Task<WebResponse> GetResponseAsync() { }

	// RVA: 0x1188F40 Offset: 0x1188340 VA: 0x181188F40
	private WindowsIdentity SafeCaptureIdenity() { }

	// RVA: 0x1188230 Offset: 0x1187630 VA: 0x181188230 Slot: 35
	public virtual void Abort() { }

	// RVA: 0x7CE230 Offset: 0x7CD630 VA: 0x1807CE230
	internal RequestCacheProtocol get_CacheProtocol() { }

	// RVA: 0x7CE240 Offset: 0x7CD640 VA: 0x1807CE240
	internal void set_CacheProtocol(RequestCacheProtocol value) { }

	// RVA: 0x11893F0 Offset: 0x11887F0 VA: 0x1811893F0
	internal static IWebProxy get_InternalDefaultWebProxy() { }

	// RVA: 0x1189360 Offset: 0x1188760 VA: 0x181189360
	public static IWebProxy get_DefaultWebProxy() { }

	// RVA: 0x11891C0 Offset: 0x11885C0 VA: 0x1811891C0
	private static void .cctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1188FC0 Offset: 0x11883C0 VA: 0x181188FC0
	private Task<Stream> <GetRequestStreamAsync>b__78_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x11890C0 Offset: 0x11884C0 VA: 0x1811890C0
	private Task<WebResponse> <GetResponseAsync>b__79_0() { }

}

internal class WebRequest.DesignerWebRequestCreate : IWebRequestCreate // TypeDefIndex: 2906
{	// Methods

	// RVA: 0x1176260 Offset: 0x1175660 VA: 0x181176260 Slot: 4
	public WebRequest Create(Uri uri) { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

}

internal class WebRequest.WebProxyWrapperOpaque : IWebProxy // TypeDefIndex: 2907
{	// Fields
	protected readonly WebProxy webProxy; // 0x10

	// Properties
	public ICredentials Credentials { get; }

	// Methods

	// RVA: 0x11866E0 Offset: 0x1185AE0 VA: 0x1811866E0 Slot: 4
	public Uri GetProxy(Uri destination) { }

	// RVA: 0x1186700 Offset: 0x1185B00 VA: 0x181186700 Slot: 5
	public bool IsBypassed(Uri host) { }

	// RVA: 0x524970 Offset: 0x523D70 VA: 0x180524970 Slot: 6
	public ICredentials get_Credentials() { }

}

internal class WebRequest.WebProxyWrapper : WebRequest.WebProxyWrapperOpaque // TypeDefIndex: 2908
{	// Properties
	internal WebProxy WebProxy { get; }

	// Methods

	// RVA: 0x4B9460 Offset: 0x4B8860 VA: 0x1804B9460
	internal WebProxy get_WebProxy() { }

}

private sealed class WebRequest.<>c__DisplayClass78_0 // TypeDefIndex: 2909
{	// Fields
	public WindowsIdentity currentUser; // 0x10
	public WebRequest <>4__this; // 0x18

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x1178800 Offset: 0x1177C00 VA: 0x181178800
	internal Task<Stream> <GetRequestStreamAsync>b__1() { }

}

private sealed class WebRequest.<>c__DisplayClass79_0 // TypeDefIndex: 2910
{	// Fields
	public WindowsIdentity currentUser; // 0x10
	public WebRequest <>4__this; // 0x18

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x1178A30 Offset: 0x1177E30 VA: 0x181178A30
	internal Task<WebResponse> <GetResponseAsync>b__1() { }

}

