public class FtpWebResponse : WebResponse // TypeDefIndex: 3004
{
	private Stream stream; 
	private Uri uri; 
	private FtpStatusCode statusCode; 
	private DateTime lastModified; 
	private string bannerMessage; 
	private string welcomeMessage; 
	private string exitMessage; 
	private string statusDescription; 
	private string method; 
	private bool disposed; 
	private FtpWebRequest request; 
	internal long contentLength; 

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

