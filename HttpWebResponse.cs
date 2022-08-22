public class HttpWebResponse : WebResponse, ISerializable, IDisposable // TypeDefIndex: 3010
{	private Uri uri; // 0x18
	private WebHeaderCollection webHeaders; // 0x20
	private CookieCollection cookieCollection; // 0x28
	private string method; // 0x30
	private Version version; // 0x38
	private HttpStatusCode statusCode; // 0x40
	private string statusDescription; // 0x48
	private long contentLength; // 0x50
	private string contentType; // 0x58
	private CookieContainer cookie_container; // 0x60
	private bool disposed; // 0x68
	private Stream stream; // 0x70

	public override long ContentLength { get; }
	public override WebHeaderCollection Headers { get; }
	public override Uri ResponseUri { get; }
	public virtual HttpStatusCode StatusCode { get; }
	public virtual string StatusDescription { get; }


	internal void .ctor(Uri uri, string method, WebConnectionData data, CookieContainer container) { }

	[ObsoleteAttribute] // RVA: 0xB6DD0 Offset: 0xB61D0 VA: 0x1800B6DD0
	protected void .ctor(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	public override long get_ContentLength() { }

	public override WebHeaderCollection get_Headers() { }

	public override Uri get_ResponseUri() { }

	public virtual HttpStatusCode get_StatusCode() { }

	public virtual string get_StatusDescription() { }

	internal void ReadAll() { }

	public override Stream GetResponseStream() { }

	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	protected override void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	public override void Close() { }

	private void System.IDisposable.Dispose() { }

	protected override void Dispose(bool disposing) { }

	private void CheckDisposed() { }

	private void FillCookies() { }

	[ObsoleteAttribute] // RVA: 0xB88A0 Offset: 0xB7CA0 VA: 0x1800B88A0
	[EditorBrowsableAttribute] // RVA: 0xB88A0 Offset: 0xB7CA0 VA: 0x1800B88A0
	public void .ctor() { }

}

