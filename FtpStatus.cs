internal class FtpStatus // TypeDefIndex: 3001
{	// Fields
	private readonly FtpStatusCode statusCode; // 0x10
	private readonly string statusDescription; // 0x18

	// Properties
	public FtpStatusCode StatusCode { get; }
	public string StatusDescription { get; }

	// Methods

	// RVA: 0xC44770 Offset: 0xC43B70 VA: 0x180C44770
	public void .ctor(FtpStatusCode statusCode, string statusDescription) { }

	// RVA: 0x36A480 Offset: 0x369880 VA: 0x18036A480
	public FtpStatusCode get_StatusCode() { }

	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710
	public string get_StatusDescription() { }

}

