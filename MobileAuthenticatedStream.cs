internal abstract class MobileAuthenticatedStream : AuthenticatedStream, IMonoSslStream, IDisposable // TypeDefIndex: 2544
{
	private MobileTlsContext xobileTlsContext;
	private ExceptionDispatchInfo lastException;
	private AsyncProtocolRequest asyncHandshakeRequest;
	private AsyncProtocolRequest asyncReadRequest;
	private AsyncProtocolRequest asyncWriteRequest;
	private BufferOffsetSize2 readBuffer;
	private BufferOffsetSize2 writeBuffer;
	private object ioLock;
	private int closeRequested;
	private bool shutdown;
	private static int uniqueNameInteger;
	[CompilerGeneratedAttribute]
	private readonly SslStream <SslStream>k__BackingField;
	[CompilerGeneratedAttribute]
	private readonly MonoTlsSettings <Settings>k__BackingField;
	[CompilerGeneratedAttribute]
	private readonly MonoTlsProvider <Provider>k__BackingField;
	private static int nextId;
	internal readonly int ID;

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


	public void .ctor(Stream innerStream, bool leaveInnerStreamOpen, SslStream owner, MonoTlsSettings settings, MonoTlsProvider provider) { }

	[CompilerGeneratedAttribute]
	public MonoTlsSettings get_Settings() { }

	[CompilerGeneratedAttribute]
	public MonoTlsProvider get_Provider() { }

	internal void CheckThrow(bool authSuccessCheck, bool shutdownCheck = False) { }

	internal static Exception GetSSPIException(Exception e) { }

	internal static Exception GetIOException(Exception e, string message) { }

	internal ExceptionDispatchInfo SetException(Exception e) { }

	public void AuthenticateAsClient(string targetHost, X509CertificateCollection clientCertificates, SslProtocols enabledSslProtocols, bool checkCertificateRevocation) { }

	public IAsyncResult BeginAuthenticateAsServer(X509Certificate serverCertificate, bool clientCertificateRequired, SslProtocols enabledSslProtocols, bool checkCertificateRevocation, AsyncCallback asyncCallback, object asyncState) { }

	public void EndAuthenticateAsServer(IAsyncResult asyncResult) { }

	public AuthenticatedStream get_AuthenticatedStream() { }

	[AsyncStateMachineAttribute]
	private Task ProcessAuthentication(bool runSynchronously, bool serverMode, string targetHost, SslProtocols enabledProtocols, X509Certificate serverCertificate, X509CertificateCollection clientCertificates, bool clientCertRequired) { }

	protected abstract MobileTlsContext CreateContext(bool serverMode, string targetHost, SslProtocols enabledProtocols, X509Certificate serverCertificate, X509CertificateCollection clientCertificates, bool askForClientCert);

	public override IAsyncResult BeginRead(byte[] buffer, int offset, int count, AsyncCallback asyncCallback, object asyncState) { }

	public override int EndRead(IAsyncResult asyncResult) { }

	public override IAsyncResult BeginWrite(byte[] buffer, int offset, int count, AsyncCallback asyncCallback, object asyncState) { }

	public override void EndWrite(IAsyncResult asyncResult) { }

	public override int Read(byte[] buffer, int offset, int count) { }

	public override void Write(byte[] buffer, int offset, int count) { }

	public override Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	public override Task WriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	[AsyncStateMachineAttribute]
	private Task<int> StartOperation(MobileAuthenticatedStream.OperationType type, AsyncProtocolRequest asyncRequest, CancellationToken cancellationToken) { }

	internal int InternalRead(byte[] buffer, int offset, int size, out bool outWantMore) { }

	private ValueTuple<int, bool> InternalRead(AsyncProtocolRequest asyncRequest, BufferOffsetSize internalBuffer, byte[] buffer, int offset, int size) { }

	internal bool InternalWrite(byte[] buffer, int offset, int size) { }

	private bool InternalWrite(AsyncProtocolRequest asyncRequest, BufferOffsetSize2 internalBuffer, byte[] buffer, int offset, int size) { }

	[AsyncStateMachineAttribute]
	internal Task<int> InnerRead(bool sync, int requestedSize, CancellationToken cancellationToken) { }

	[AsyncStateMachineAttribute]
	internal Task InnerWrite(bool sync, CancellationToken cancellationToken) { }

	internal AsyncOperationStatus ProcessHandshake(AsyncOperationStatus status) { }

	internal ValueTuple<int, bool> ProcessRead(BufferOffsetSize userBuffer) { }

	internal ValueTuple<int, bool> ProcessWrite(BufferOffsetSize userBuffer) { }

	public override bool get_IsAuthenticated() { }

	protected override void Dispose(bool disposing) { }

	public override void Flush() { }

	public X509Certificate get_InternalLocalCertificate() { }

	public override long Seek(long offset, SeekOrigin origin) { }

	public override void SetLength(long value) { }

	public override bool get_CanRead() { }

	public override bool get_CanWrite() { }

	public override bool get_CanSeek() { }

	public override long get_Length() { }

	public override long get_Position() { }

	public override void set_Position(long value) { }

	public override int get_ReadTimeout() { }

	public override int get_WriteTimeout() { }

	private static void .cctor() { }

	[CompilerGeneratedAttribute]
	private void <InnerWrite>

}

private enum MobileAuthenticatedStream.OperationType // TypeDefIndex: 2545
{
	public int value__;
	public const MobileAuthenticatedStream.OperationType Read = 0;
	public const MobileAuthenticatedStream.OperationType Write = 1;
	public const MobileAuthenticatedStream.OperationType Shutdown = 2;

}

private struct MobileAuthenticatedStream.<ProcessAuthentication>d__47 : IAsyncStateMachine // TypeDefIndex: 2546
{
	public int <>1__state;
	public AsyncTaskMethodBuilder <>t__builder;
	public bool serverMode;
	public X509Certificate serverCertificate;
	public string targetHost;
	public MobileAuthenticatedStream <>4__this;
	public bool runSynchronously;
	public SslProtocols enabledProtocols;
	public X509CertificateCollection clientCertificates;
	public bool clientCertRequired;
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<AsyncProtocolResult> <>u__1;


	private void MoveNext() { }

	[DebuggerHiddenAttribute]
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

private struct MobileAuthenticatedStream.<StartOperation>d__58 : IAsyncStateMachine // TypeDefIndex: 2547
{
	public int <>1__state;
	public AsyncTaskMethodBuilder<int> <>t__builder;
	public MobileAuthenticatedStream <>4__this;
	public MobileAuthenticatedStream.OperationType type;
	public AsyncProtocolRequest asyncRequest;
	public CancellationToken cancellationToken;
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<AsyncProtocolResult> <>u__1;


	private void MoveNext() { }

	[DebuggerHiddenAttribute]
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

private sealed class MobileAuthenticatedStream.<>c__DisplayClass66_0 // TypeDefIndex: 2548
{
	public MobileAuthenticatedStream <>4__this;
	public int len;


	public void .ctor() { }

	internal int <InnerRead>

}

private struct MobileAuthenticatedStream.<InnerRead>d__66 : IAsyncStateMachine // TypeDefIndex: 2549
{
	public int <>1__state;
	public AsyncTaskMethodBuilder<int> <>t__builder;
	public MobileAuthenticatedStream <>4__this;
	public CancellationToken cancellationToken;
	public int requestedSize;
	public bool sync;
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int> <>u__1;


	private void MoveNext() { }

	[DebuggerHiddenAttribute]
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

private struct MobileAuthenticatedStream.<InnerWrite>d__67 : IAsyncStateMachine // TypeDefIndex: 2550
{
	public int <>1__state;
	public AsyncTaskMethodBuilder <>t__builder;
	public CancellationToken cancellationToken;
	public MobileAuthenticatedStream <>4__this;
	public bool sync;
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1;


	private void MoveNext() { }

	[DebuggerHiddenAttribute]
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

