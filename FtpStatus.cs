internal class FtpStatus // TypeDefIndex: 3001
{	private readonly FtpStatusCode statusCode; // 0x10
	private readonly string statusDescription; // 0x18

	public FtpStatusCode StatusCode { get; }
	public string StatusDescription { get; }


	public void .ctor(FtpStatusCode statusCode, string statusDescription) { }

	public FtpStatusCode get_StatusCode() { }

	public string get_StatusDescription() { }

}

