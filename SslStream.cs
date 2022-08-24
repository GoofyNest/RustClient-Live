public class SslStream : AuthenticatedStream // TypeDefIndex: 3072
{
	private MonoTlsProvider provider; 
	private IMonoSslStream impl; 

internal IMonoSslStream Impl { get; }
public override bool IsAuthenticated { get; }
public override bool CanSeek { get; }
public override bool CanRead { get; }
public override bool CanWrite { get; }
public override int ReadTimeout { get; }
public override int WriteTimeout { get; }
public override long Length { get; }
public override long Position { get; set; }


internal IMonoSslStream get_Impl() { }

private static MonoTlsProvider GetProvider() { }

public void .ctor(Stream innerStream, bool leaveInnerStreamOpen) { }

internal void .ctor(Stream innerStream, bool leaveInnerStreamOpen, MonoTlsProvider provider, MonoTlsSettings settings) { }

internal static IMonoSslStream CreateMonoSslStream(Stream innerStream, bool leaveInnerStreamOpen, MonoTlsProvider provider, MonoTlsSettings settings) { }

public virtual IAsyncResult BeginAuthenticateAsServer(X509Certificate serverCertificate, bool clientCertificateRequired, SslProtocols enabledSslProtocols, bool checkCertificateRevocation, AsyncCallback asyncCallback, object asyncState) { }

public virtual void EndAuthenticateAsServer(IAsyncResult asyncResult) { }

public override bool get_IsAuthenticated() { }

public override bool get_CanSeek() { }

public override bool get_CanRead() { }

public override bool get_CanWrite() { }

public override int get_ReadTimeout() { }

public override int get_WriteTimeout() { }

public override long get_Length() { }

public override long get_Position() { }

public override void set_Position(long value) { }

public override void SetLength(long value) { }

public override long Seek(long offset, SeekOrigin origin) { }

public override void Flush() { }

private void CheckDisposed() { }

protected override void Dispose(bool disposing) { }

public override int Read(byte[] buffer, int offset, int count) { }

public override void Write(byte[] buffer, int offset, int count) { }

public override IAsyncResult BeginRead(byte[] buffer, int offset, int count, AsyncCallback asyncCallback, object asyncState) { }

public override int EndRead(IAsyncResult asyncResult) { }

public override IAsyncResult BeginWrite(byte[] buffer, int offset, int count, AsyncCallback asyncCallback, object asyncState) { }

public override void EndWrite(IAsyncResult asyncResult) { }

}

