public abstract class HttpContent : IDisposable // TypeDefIndex: 5745
{
	private HttpContent.FixedMemoryStream buffer; 
	private Stream stream; 
	private bool disposed; 
	private HttpContentHeaders headers; 

	public HttpContentHeaders Headers { get; }
	internal Nullable<long> LoadedBufferLength { get; }


	public HttpContentHeaders get_Headers() { }

	internal Nullable<long> get_LoadedBufferLength() { }

	internal void CopyTo(Stream stream) { }

	public Task CopyToAsync(Stream stream) { }

	public Task CopyToAsync(Stream stream, TransportContext context) { }

	[AsyncStateMachineAttribute] 
	protected virtual Task<Stream> CreateContentReadStreamAsync() { }

	private static HttpContent.FixedMemoryStream CreateFixedMemoryStream(long maxBufferSize) { }

	public void Dispose() { }

	protected virtual void Dispose(bool disposing) { }

	public Task LoadIntoBufferAsync() { }

	[AsyncStateMachineAttribute] 
	public Task LoadIntoBufferAsync(long maxBufferSize) { }

	[AsyncStateMachineAttribute] 
	public Task<Stream> ReadAsStreamAsync() { }

	[AsyncStateMachineAttribute] 
	public Task<string> ReadAsStringAsync() { }

	private static Encoding GetEncodingFromBuffer(byte[] buffer, int length, ref int preambleLength) { }

	private static int StartsWith(byte[] array, int length, byte[] value) { }

	protected internal abstract Task SerializeToStreamAsync(Stream stream, TransportContext context);

	protected internal abstract bool TryComputeLength(out long length);

	protected void .ctor() { }

}

private sealed class HttpContent.FixedMemoryStream : MemoryStream // TypeDefIndex: 5746
{
	private readonly long maxSize; 


	public void .ctor(long maxSize) { }

	private void CheckOverflow(int count) { }

	public override void WriteByte(byte value) { }

	public override void Write(byte[] buffer, int offset, int count) { }

}

private struct HttpContent.<CreateContentReadStreamAsync>d__12 : IAsyncStateMachine // TypeDefIndex: 5747
{
	public int <>1__state; 
	public AsyncTaskMethodBuilder<Stream> <>t__builder; 
	public HttpContent <>4__this; 
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1; 


	private void MoveNext() { }

	[DebuggerHiddenAttribute] 
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

private struct HttpContent.<LoadIntoBufferAsync>d__17 : IAsyncStateMachine // TypeDefIndex: 5748
{
	public int <>1__state; 
	public AsyncTaskMethodBuilder <>t__builder; 
	public HttpContent <>4__this; 
	public long maxBufferSize; 
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1; 


	private void MoveNext() { }

	[DebuggerHiddenAttribute] 
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

private struct HttpContent.<ReadAsStreamAsync>d__18 : IAsyncStateMachine // TypeDefIndex: 5749
{
	public int <>1__state; 
	public AsyncTaskMethodBuilder<Stream> <>t__builder; 
	public HttpContent <>4__this; 
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<Stream> <>u__1; 


	private void MoveNext() { }

	[DebuggerHiddenAttribute] 
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

private struct HttpContent.<ReadAsStringAsync>d__20 : IAsyncStateMachine // TypeDefIndex: 5750
{
	public int <>1__state; 
	public AsyncTaskMethodBuilder<string> <>t__builder; 
	public HttpContent <>4__this; 
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1; 


	private void MoveNext() { }

	[DebuggerHiddenAttribute] 
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

