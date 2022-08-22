public class FtpWebResponse : WebResponse // TypeDefIndex: 3004
{	private Stream stream; // 0x18
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

	public override long ContentLength { get; }
	public override WebHeaderCollection Headers { get; }
	public override Uri ResponseUri { get; }
	internal DateTime LastModified { set; }
	internal string BannerMessage { set; }
	internal string WelcomeMessage { set; }
	internal FtpStatusCode StatusCode { set; }
	internal Stream Stream { set; }


	internal void .ctor(FtpWebRequest request, Uri uri, string method, bool keepAlive) { }

	internal void .ctor(FtpWebRequest request, Uri uri, string method, FtpStatusCode statusCode, string statusDescription) { }

	internal void .ctor(FtpWebRequest request, Uri uri, string method, FtpStatus status) { }

	public override long get_ContentLength() { }

	public override WebHeaderCollection get_Headers() { }

	public override Uri get_ResponseUri() { }

	internal void set_LastModified(DateTime value) { }

	internal void set_BannerMessage(string value) { }

	internal void set_WelcomeMessage(string value) { }

	internal void set_StatusCode(FtpStatusCode value) { }

	public override void Close() { }

	public override Stream GetResponseStream() { }

	internal void set_Stream(Stream value) { }

	internal void UpdateStatus(FtpStatus status) { }

	private void CheckDisposed() { }

	internal bool IsFinal() { }

}

