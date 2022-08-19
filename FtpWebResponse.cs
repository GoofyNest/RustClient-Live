public class FtpWebResponse : WebResponse // TypeDefIndex: 3004
{	// Fields
	private Stream stream; // 0x18
	private Uri uri; // 0x20
	private FtpStatusCode statusCode; // 0x28
	private DateTime lastModified; // 0x30
	private string bannerMessage; // 0x38
	private string welcomeMessage; // 0x40
	private string exitMessage; // 0x48
	private string statusDescription; // 0x50
	private string method; // 0x58
	private bool disposed; // 0x60
	private FtpWebRequest request; // 0x68
	internal long contentLength; // 0x70

	// Properties
	public override long ContentLength { get; }
	public override WebHeaderCollection Headers { get; }
	public override Uri ResponseUri { get; }
	internal DateTime LastModified { set; }
	internal string BannerMessage { set; }
	internal string WelcomeMessage { set; }
	internal FtpStatusCode StatusCode { set; }
	internal Stream Stream { set; }

	// Methods

	// RVA: 0x1333280 Offset: 0x1332680 VA: 0x181333280
	internal void .ctor(FtpWebRequest request, Uri uri, string method, bool keepAlive) { }

	// RVA: 0x13333A0 Offset: 0x13327A0 VA: 0x1813333A0
	internal void .ctor(FtpWebRequest request, Uri uri, string method, FtpStatusCode statusCode, string statusDescription) { }

	// RVA: 0x1333240 Offset: 0x1332640 VA: 0x181333240
	internal void .ctor(FtpWebRequest request, Uri uri, string method, FtpStatus status) { }

	// RVA: 0x58DC30 Offset: 0x58D030 VA: 0x18058DC30 Slot: 11
	public override long get_ContentLength() { }

	// RVA: 0x13334E0 Offset: 0x13328E0 VA: 0x1813334E0 Slot: 14
	public override WebHeaderCollection get_Headers() { }

	// RVA: 0x497E00 Offset: 0x497200 VA: 0x180497E00 Slot: 13
	public override Uri get_ResponseUri() { }

	// RVA: 0xC107C0 Offset: 0xC0FBC0 VA: 0x180C107C0
	internal void set_LastModified(DateTime value) { }

	// RVA: 0x5089D0 Offset: 0x507DD0 VA: 0x1805089D0
	internal void set_BannerMessage(string value) { }

	// RVA: 0x4B94A0 Offset: 0x4B88A0 VA: 0x1804B94A0
	internal void set_WelcomeMessage(string value) { }

	// RVA: 0x7E8DF0 Offset: 0x7E81F0 VA: 0x1807E8DF0
	internal void set_StatusCode(FtpStatusCode value) { }

	// RVA: 0x1333010 Offset: 0x1332410 VA: 0x181333010 Slot: 9
	public override void Close() { }

	// RVA: 0x13330E0 Offset: 0x13324E0 VA: 0x1813330E0 Slot: 12
	public override Stream GetResponseStream() { }

	// RVA: 0x4D0180 Offset: 0x4CF580 VA: 0x1804D0180
	internal void set_Stream(Stream value) { }

	// RVA: 0x1333210 Offset: 0x1332610 VA: 0x181333210
	internal void UpdateStatus(FtpStatus status) { }

	// RVA: 0x1332F80 Offset: 0x1332380 VA: 0x181332F80
	private void CheckDisposed() { }

	// RVA: 0x1333200 Offset: 0x1332600 VA: 0x181333200
	internal bool IsFinal() { }

}

