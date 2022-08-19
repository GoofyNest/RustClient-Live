internal abstract class MobileAuthenticatedStream : AuthenticatedStream, IMonoSslStream, IDisposable // TypeDefIndex: 2544
{	// Fields
	private MobileTlsContext xobileTlsContext; // 0x38
	private ExceptionDispatchInfo lastException; // 0x40
	private AsyncProtocolRequest asyncHandshakeRequest; // 0x48
	private AsyncProtocolRequest asyncReadRequest; // 0x50
	private AsyncProtocolRequest asyncWriteRequest; // 0x58
	private BufferOffsetSize2 readBuffer; // 0x60
	private BufferOffsetSize2 writeBuffer; // 0x68
	private object ioLock; // 0x70
	private int closeRequested; // 0x78
	private bool shutdown; // 0x7C
	private static int uniqueNameInteger; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private readonly SslStream <SslStream>k__BackingField; // 0x80
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private readonly MonoTlsSettings <Settings>k__BackingField; // 0x88
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private readonly MonoTlsProvider <Provider>k__BackingField; // 0x90
	private static int nextId; // 0x4
	internal readonly int ID; // 0x98

	// Properties
	public MonoTlsSettings Settings { get; }
	public MonoTlsProvider Provider { get; }
	public AuthenticatedStream AuthenticatedStream { get; }
	public override bool IsAuthenticated { get; }
	public X509Certificate InternalLocalCertificate { get; }
	public override bool CanRead { get; }
	public override bool CanWrite { get; }
	public override bool CanSeek { get; }
	public override long Length { get; }
	public override long Position { get; set; }
	public override int ReadTimeout { get; }
	public override int WriteTimeout { get; }

	// Methods

	// RVA: 0x1213430 Offset: 0x1212830 VA: 0x181213430
	public void .ctor(Stream innerStream, bool leaveInnerStreamOpen, SslStream owner, MonoTlsSettings settings, MonoTlsProvider provider) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x58DBD0 Offset: 0x58CFD0 VA: 0x18058DBD0
	public MonoTlsSettings get_Settings() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4E09F0 Offset: 0x4DFDF0 VA: 0x1804E09F0 Slot: 51
	public MonoTlsProvider get_Provider() { }

	// RVA: 0x1211AE0 Offset: 0x1210EE0 VA: 0x181211AE0
	internal void CheckThrow(bool authSuccessCheck, bool shutdownCheck = False) { }

	// RVA: 0x1211F50 Offset: 0x1211350 VA: 0x181211F50
	internal static Exception GetSSPIException(Exception e) { }

	// RVA: 0x1211DE0 Offset: 0x12111E0 VA: 0x181211DE0
	internal static Exception GetIOException(Exception e, string message) { }

	// RVA: 0x1213060 Offset: 0x1212460 VA: 0x181213060
	internal ExceptionDispatchInfo SetException(Exception e) { }

	// RVA: 0x1211810 Offset: 0x1210C10 VA: 0x181211810 Slot: 32
	public void AuthenticateAsClient(string targetHost, X509CertificateCollection clientCertificates, SslProtocols enabledSslProtocols, bool checkCertificateRevocation) { }

	// RVA: 0x1211860 Offset: 0x1210C60 VA: 0x181211860 Slot: 33
	public IAsyncResult BeginAuthenticateAsServer(X509Certificate serverCertificate, bool clientCertificateRequired, SslProtocols enabledSslProtocols, bool checkCertificateRevocation, AsyncCallback asyncCallback, object asyncState) { }

	// RVA: 0x1211D90 Offset: 0x1211190 VA: 0x181211D90 Slot: 34
	public void EndAuthenticateAsServer(IAsyncResult asyncResult) { }

	// RVA: 0x4B0E80 Offset: 0x4B0280 VA: 0x1804B0E80 Slot: 47
	public AuthenticatedStream get_AuthenticatedStream() { }

	[AsyncStateMachineAttribute] // RVA: 0xA34C0 Offset: 0xA28C0 VA: 0x1800A34C0
	// RVA: 0x12128F0 Offset: 0x1211CF0 VA: 0x1812128F0
	private Task ProcessAuthentication(bool runSynchronously, bool serverMode, string targetHost, SslProtocols enabledProtocols, X509Certificate serverCertificate, X509CertificateCollection clientCertificates, bool clientCertRequired) { }

	// RVA: -1 Offset: -1 Slot: 52
	protected abstract MobileTlsContext CreateContext(bool serverMode, string targetHost, SslProtocols enabledProtocols, X509Certificate serverCertificate, X509CertificateCollection clientCertificates, bool askForClientCert);

	// RVA: 0x1211910 Offset: 0x1210D10 VA: 0x181211910 Slot: 19
	public override IAsyncResult BeginRead(byte[] buffer, int offset, int count, AsyncCallback asyncCallback, object asyncState) { }

	// RVA: 0x1211DA0 Offset: 0x12111A0 VA: 0x181211DA0 Slot: 20
	public override int EndRead(IAsyncResult asyncResult) { }

	// RVA: 0x12119F0 Offset: 0x1210DF0 VA: 0x1812119F0 Slot: 22
	public override IAsyncResult BeginWrite(byte[] buffer, int offset, int count, AsyncCallback asyncCallback, object asyncState) { }

	// RVA: 0x1211D90 Offset: 0x1211190 VA: 0x181211D90 Slot: 23
	public override void EndWrite(IAsyncResult asyncResult) { }

	// RVA: 0x1212F20 Offset: 0x1212320 VA: 0x181212F20 Slot: 27
	public override int Read(byte[] buffer, int offset, int count) { }

	// RVA: 0x1213300 Offset: 0x1212700 VA: 0x181213300 Slot: 29
	public override void Write(byte[] buffer, int offset, int count) { }

	// RVA: 0x1212E70 Offset: 0x1212270 VA: 0x181212E70 Slot: 21
	public override Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	// RVA: 0x1213250 Offset: 0x1212650 VA: 0x181213250 Slot: 24
	public override Task WriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	[AsyncStateMachineAttribute] // RVA: 0xA3570 Offset: 0xA2970 VA: 0x1800A3570
	// RVA: 0x12130B0 Offset: 0x12124B0 VA: 0x1812130B0
	private Task<int> StartOperation(MobileAuthenticatedStream.OperationType type, AsyncProtocolRequest asyncRequest, CancellationToken cancellationToken) { }

	// RVA: 0x1212320 Offset: 0x1211720 VA: 0x181212320
	internal int InternalRead(byte[] buffer, int offset, int size, out bool outWantMore) { }

	// RVA: 0x1212510 Offset: 0x1211910 VA: 0x181212510
	private ValueTuple<int, bool> InternalRead(AsyncProtocolRequest asyncRequest, BufferOffsetSize internalBuffer, byte[] buffer, int offset, int size) { }

	// RVA: 0x1212820 Offset: 0x1211C20 VA: 0x181212820
	internal bool InternalWrite(byte[] buffer, int offset, int size) { }

	// RVA: 0x1212660 Offset: 0x1211A60 VA: 0x181212660
	private bool InternalWrite(AsyncProtocolRequest asyncRequest, BufferOffsetSize2 internalBuffer, byte[] buffer, int offset, int size) { }

	[AsyncStateMachineAttribute] // RVA: 0xA3620 Offset: 0xA2A20 VA: 0x1800A3620
	// RVA: 0x12120B0 Offset: 0x12114B0 VA: 0x1812120B0
	internal Task<int> InnerRead(bool sync, int requestedSize, CancellationToken cancellationToken) { }

	[AsyncStateMachineAttribute] // RVA: 0xA3790 Offset: 0xA2B90 VA: 0x1800A3790
	// RVA: 0x12121F0 Offset: 0x12115F0 VA: 0x1812121F0
	internal Task InnerWrite(bool sync, CancellationToken cancellationToken) { }

	// RVA: 0x1212A50 Offset: 0x1211E50 VA: 0x181212A50
	internal AsyncOperationStatus ProcessHandshake(AsyncOperationStatus status) { }

	// RVA: 0x1212C30 Offset: 0x1212030 VA: 0x181212C30
	internal ValueTuple<int, bool> ProcessRead(BufferOffsetSize userBuffer) { }

	// RVA: 0x1212D50 Offset: 0x1212150 VA: 0x181212D50
	internal ValueTuple<int, bool> ProcessWrite(BufferOffsetSize userBuffer) { }

	// RVA: 0x1213790 Offset: 0x1212B90 VA: 0x181213790 Slot: 31
	public override bool get_IsAuthenticated() { }

	// RVA: 0x1211BC0 Offset: 0x1210FC0 VA: 0x181211BC0 Slot: 17
	protected override void Dispose(bool disposing) { }

	// RVA: 0xB9FE70 Offset: 0xB9F270 VA: 0x180B9FE70 Slot: 18
	public override void Flush() { }

	// RVA: 0x1213660 Offset: 0x1212A60 VA: 0x181213660 Slot: 50
	public X509Certificate get_InternalLocalCertificate() { }

	// RVA: 0x1213010 Offset: 0x1212410 VA: 0x181213010 Slot: 25
	public override long Seek(long offset, SeekOrigin origin) { }

	// RVA: 0xB9FF30 Offset: 0xB9F330 VA: 0x180B9FF30 Slot: 26
	public override void SetLength(long value) { }

	// RVA: 0x12135A0 Offset: 0x12129A0 VA: 0x1812135A0 Slot: 7
	public override bool get_CanRead() { }

	// RVA: 0x12135F0 Offset: 0x12129F0 VA: 0x1812135F0 Slot: 9
	public override bool get_CanWrite() { }

	// RVA: 0x498AD0 Offset: 0x497ED0 VA: 0x180498AD0 Slot: 8
	public override bool get_CanSeek() { }

	// RVA: 0xBA0100 Offset: 0xB9F500 VA: 0x180BA0100 Slot: 10
	public override long get_Length() { }

	// RVA: 0xBA0130 Offset: 0xB9F530 VA: 0x180BA0130 Slot: 11
	public override long get_Position() { }

	// RVA: 0x12138B0 Offset: 0x1212CB0 VA: 0x1812138B0 Slot: 12
	public override void set_Position(long value) { }

	// RVA: 0xE52880 Offset: 0xE51C80 VA: 0x180E52880 Slot: 13
	public override int get_ReadTimeout() { }

	// RVA: 0x1213880 Offset: 0x1212C80 VA: 0x181213880 Slot: 14
	public override int get_WriteTimeout() { }

	// RVA: 0x12133F0 Offset: 0x12127F0 VA: 0x1812133F0
	private static void .cctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1213200 Offset: 0x1212600 VA: 0x181213200
	private void <InnerWrite>b__67_0() { }

}

private enum MobileAuthenticatedStream.OperationType // TypeDefIndex: 2545
{	// Fields
	public int value__; // 0x0
	public const MobileAuthenticatedStream.OperationType Read = 0;
	public const MobileAuthenticatedStream.OperationType Write = 1;
	public const MobileAuthenticatedStream.OperationType Shutdown = 2;

}

private struct MobileAuthenticatedStream.<ProcessAuthentication>d__47 : IAsyncStateMachine // TypeDefIndex: 2546
{	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x8
	public bool serverMode; // 0x20
	public X509Certificate serverCertificate; // 0x28
	public string targetHost; // 0x30
	public MobileAuthenticatedStream <>4__this; // 0x38
	public bool runSynchronously; // 0x40
	public SslProtocols enabledProtocols; // 0x44
	public X509CertificateCollection clientCertificates; // 0x48
	public bool clientCertRequired; // 0x50
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<AsyncProtocolResult> <>u__1; // 0x58

	// Methods

	// RVA: 0x1D1D10 Offset: 0x1D1110 VA: 0x1801D1D10 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xF2060 Offset: 0xF1460 VA: 0x1800F2060 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

private struct MobileAuthenticatedStream.<StartOperation>d__58 : IAsyncStateMachine // TypeDefIndex: 2547
{	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<int> <>t__builder; // 0x8
	public MobileAuthenticatedStream <>4__this; // 0x20
	public MobileAuthenticatedStream.OperationType type; // 0x28
	public AsyncProtocolRequest asyncRequest; // 0x30
	public CancellationToken cancellationToken; // 0x38
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<AsyncProtocolResult> <>u__1; // 0x40

	// Methods

	// RVA: 0x1D1D90 Offset: 0x1D1190 VA: 0x1801D1D90 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1D1DA0 Offset: 0x1D11A0 VA: 0x1801D1DA0 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

private sealed class MobileAuthenticatedStream.<>c__DisplayClass66_0 // TypeDefIndex: 2548
{	// Fields
	public MobileAuthenticatedStream <>4__this; // 0x10
	public int len; // 0x18

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x1218B00 Offset: 0x1217F00 VA: 0x181218B00
	internal int <InnerRead>b__0() { }

}

private struct MobileAuthenticatedStream.<InnerRead>d__66 : IAsyncStateMachine // TypeDefIndex: 2549
{	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<int> <>t__builder; // 0x8
	public MobileAuthenticatedStream <>4__this; // 0x20
	public CancellationToken cancellationToken; // 0x28
	public int requestedSize; // 0x30
	public bool sync; // 0x34
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int> <>u__1; // 0x38

	// Methods

	// RVA: 0x1D1CA0 Offset: 0x1D10A0 VA: 0x1801D1CA0 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1D1CB0 Offset: 0x1D10B0 VA: 0x1801D1CB0 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

private struct MobileAuthenticatedStream.<InnerWrite>d__67 : IAsyncStateMachine // TypeDefIndex: 2550
{	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x8
	public CancellationToken cancellationToken; // 0x20
	public MobileAuthenticatedStream <>4__this; // 0x28
	public bool sync; // 0x30
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1; // 0x38

	// Methods

	// RVA: 0x1D1D00 Offset: 0x1D1100 VA: 0x1801D1D00 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xF2060 Offset: 0xF1460 VA: 0x1800F2060 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

