public class HttpWebResponse : WebResponse, ISerializable, IDisposable // TypeDefIndex: 3010
{	// Fields
	private Uri uri; // 0x18
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

	// Properties
	public override long ContentLength { get; }
	public override WebHeaderCollection Headers { get; }
	public override Uri ResponseUri { get; }
	public virtual HttpStatusCode StatusCode { get; }
	public virtual string StatusDescription { get; }

	// Methods

	// RVA: 0x133D4F0 Offset: 0x133C8F0 VA: 0x18133D4F0
	internal void .ctor(Uri uri, string method, WebConnectionData data, CookieContainer container) { }

	[ObsoleteAttribute] // RVA: 0xB6DD0 Offset: 0xB61D0 VA: 0x1800B6DD0
	// RVA: 0x133D240 Offset: 0x133C640 VA: 0x18133D240
	protected void .ctor(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x4CC350 Offset: 0x4CB750 VA: 0x1804CC350 Slot: 11
	public override long get_ContentLength() { }

	// RVA: 0x497E00 Offset: 0x497200 VA: 0x180497E00 Slot: 14
	public override WebHeaderCollection get_Headers() { }

	// RVA: 0x133D740 Offset: 0x133CB40 VA: 0x18133D740 Slot: 13
	public override Uri get_ResponseUri() { }

	// RVA: 0x5F7C80 Offset: 0x5F7080 VA: 0x1805F7C80 Slot: 15
	public virtual HttpStatusCode get_StatusCode() { }

	// RVA: 0x133D760 Offset: 0x133CB60 VA: 0x18133D760 Slot: 16
	public virtual string get_StatusDescription() { }

	// RVA: 0x133D160 Offset: 0x133C560 VA: 0x18133D160
	internal void ReadAll() { }

	// RVA: 0x133D0C0 Offset: 0x133C4C0 VA: 0x18133D0C0 Slot: 12
	public override Stream GetResponseStream() { }

	// RVA: 0x11879A0 Offset: 0x1186DA0 VA: 0x1811879A0 Slot: 6
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x133CFB0 Offset: 0x133C3B0 VA: 0x18133CFB0 Slot: 8
	protected override void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x133CDE0 Offset: 0x133C1E0 VA: 0x18133CDE0 Slot: 9
	public override void Close() { }

	// RVA: 0x133D1F0 Offset: 0x133C5F0 VA: 0x18133D1F0 Slot: 7
	private void System.IDisposable.Dispose() { }

	// RVA: 0x133CE20 Offset: 0x133C220 VA: 0x18133CE20 Slot: 10
	protected override void Dispose(bool disposing) { }

	// RVA: 0x133CD50 Offset: 0x133C150 VA: 0x18133CD50
	private void CheckDisposed() { }

	// RVA: 0x133CE30 Offset: 0x133C230 VA: 0x18133CE30
	private void FillCookies() { }

	[ObsoleteAttribute] // RVA: 0xB88A0 Offset: 0xB7CA0 VA: 0x1800B88A0
	[EditorBrowsableAttribute] // RVA: 0xB88A0 Offset: 0xB7CA0 VA: 0x1800B88A0
	// RVA: 0x133D210 Offset: 0x133C610 VA: 0x18133D210
	public void .ctor() { }

}

