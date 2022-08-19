public class SslStream : AuthenticatedStream // TypeDefIndex: 3072
{	// Fields
	private MonoTlsProvider provider; // 0x38
	private IMonoSslStream impl; // 0x40

	// Properties
	internal IMonoSslStream Impl { get; }
	public override bool IsAuthenticated { get; }
	public override bool CanSeek { get; }
	public override bool CanRead { get; }
	public override bool CanWrite { get; }
	public override int ReadTimeout { get; }
	public override int WriteTimeout { get; }
	public override long Length { get; }
	public override long Position { get; set; }

	// Methods

	// RVA: 0x10060C0 Offset: 0x10054C0 VA: 0x1810060C0
	internal IMonoSslStream get_Impl() { }

	// RVA: 0x1005B00 Offset: 0x1004F00 VA: 0x181005B00
	private static MonoTlsProvider GetProvider() { }

	// RVA: 0x1005EE0 Offset: 0x10052E0 VA: 0x181005EE0
	public void .ctor(Stream innerStream, bool leaveInnerStreamOpen) { }

	// RVA: 0x1005F80 Offset: 0x1005380 VA: 0x181005F80
	internal void .ctor(Stream innerStream, bool leaveInnerStreamOpen, MonoTlsProvider provider, MonoTlsSettings settings) { }

	// RVA: 0x1005690 Offset: 0x1004A90 VA: 0x181005690
	internal static IMonoSslStream CreateMonoSslStream(Stream innerStream, bool leaveInnerStreamOpen, MonoTlsProvider provider, MonoTlsSettings settings) { }

	// RVA: 0x1005320 Offset: 0x1004720 VA: 0x181005320 Slot: 32
	public virtual IAsyncResult BeginAuthenticateAsServer(X509Certificate serverCertificate, bool clientCertificateRequired, SslProtocols enabledSslProtocols, bool checkCertificateRevocation, AsyncCallback asyncCallback, object asyncState) { }

	// RVA: 0x10058C0 Offset: 0x1004CC0 VA: 0x1810058C0 Slot: 33
	public virtual void EndAuthenticateAsServer(IAsyncResult asyncResult) { }

	// RVA: 0x1006130 Offset: 0x1005530 VA: 0x181006130 Slot: 31
	public override bool get_IsAuthenticated() { }

	// RVA: 0x498AD0 Offset: 0x497ED0 VA: 0x180498AD0 Slot: 8
	public override bool get_CanSeek() { }

	// RVA: 0x1006020 Offset: 0x1005420 VA: 0x181006020 Slot: 7
	public override bool get_CanRead() { }

	// RVA: 0x1006070 Offset: 0x1005470 VA: 0x181006070 Slot: 9
	public override bool get_CanWrite() { }

	// RVA: 0x10062E0 Offset: 0x10056E0 VA: 0x1810062E0 Slot: 13
	public override int get_ReadTimeout() { }

	// RVA: 0x1006370 Offset: 0x1005770 VA: 0x181006370 Slot: 14
	public override int get_WriteTimeout() { }

	// RVA: 0x10061C0 Offset: 0x10055C0 VA: 0x1810061C0 Slot: 10
	public override long get_Length() { }

	// RVA: 0x1006250 Offset: 0x1005650 VA: 0x181006250 Slot: 11
	public override long get_Position() { }

	// RVA: 0x1006400 Offset: 0x1005800 VA: 0x181006400 Slot: 12
	public override void set_Position(long value) { }

	// RVA: 0x1005CB0 Offset: 0x10050B0 VA: 0x181005CB0 Slot: 26
	public override void SetLength(long value) { }

	// RVA: 0x1005C40 Offset: 0x1005040 VA: 0x181005C40 Slot: 25
	public override long Seek(long offset, SeekOrigin origin) { }

	// RVA: 0xB9FE70 Offset: 0xB9F270 VA: 0x180B9FE70 Slot: 18
	public override void Flush() { }

	// RVA: 0x1005620 Offset: 0x1004A20 VA: 0x181005620
	private void CheckDisposed() { }

	// RVA: 0x10057C0 Offset: 0x1004BC0 VA: 0x1810057C0 Slot: 17
	protected override void Dispose(bool disposing) { }

	// RVA: 0x1005B10 Offset: 0x1004F10 VA: 0x181005B10 Slot: 27
	public override int Read(byte[] buffer, int offset, int count) { }

	// RVA: 0x1005DB0 Offset: 0x10051B0 VA: 0x181005DB0 Slot: 29
	public override void Write(byte[] buffer, int offset, int count) { }

	// RVA: 0x1005460 Offset: 0x1004860 VA: 0x181005460 Slot: 19
	public override IAsyncResult BeginRead(byte[] buffer, int offset, int count, AsyncCallback asyncCallback, object asyncState) { }

	// RVA: 0x1005960 Offset: 0x1004D60 VA: 0x181005960 Slot: 20
	public override int EndRead(IAsyncResult asyncResult) { }

	// RVA: 0x1005540 Offset: 0x1004940 VA: 0x181005540 Slot: 22
	public override IAsyncResult BeginWrite(byte[] buffer, int offset, int count, AsyncCallback asyncCallback, object asyncState) { }

	// RVA: 0x1005A60 Offset: 0x1004E60 VA: 0x181005A60 Slot: 23
	public override void EndWrite(IAsyncResult asyncResult) { }

}

