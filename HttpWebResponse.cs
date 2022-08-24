public class HttpWebResponse : WebResponse, ISerializable, IDisposable // TypeDefIndex: 3010
{
	private Uri uri; 
	private WebHeaderCollection webHeaders; 
	private CookieCollection cookieCollection; 
	private string method; 
	private Version version; 
	private HttpStatusCode statusCode; 
	private string statusDescription; 
	private long contentLength; 
	private string contentType; 
	private CookieContainer cookie_container; 
	private bool disposed; 
	private Stream stream; 

public override long ContentLength { get; }
public override WebHeaderCollection Headers { get; }
public override Uri ResponseUri { get; }
public virtual HttpStatusCode StatusCode { get; }
public virtual string StatusDescription { get; }


internal void .ctor(Uri uri, string method, WebConnectionData data, CookieContainer container) { }

	[ObsoleteAttribute] 
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

	[ObsoleteAttribute] 
	[EditorBrowsableAttribute] 
public void .ctor() { }

}

