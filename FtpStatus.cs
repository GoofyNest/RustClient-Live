internal class FtpStatus // TypeDefIndex: 3001
{
	private readonly FtpStatusCode statusCode;
	private readonly string statusDescription;

	public FtpStatusCode StatusCode { get; }
	public string StatusDescription { get; }


	public void .ctor(FtpStatusCode statusCode, string statusDescription) { }

	public FtpStatusCode get_StatusCode() { }

	public string get_StatusDescription() { }

}

