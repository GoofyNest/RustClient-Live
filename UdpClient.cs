public class UdpClient : IDisposable // TypeDefIndex: 3060
{
	private Socket m_ClientSocket; 
	private bool m_Active; 
	private byte[] m_Buffer; 
	private AddressFamily m_Family; 
	private bool m_CleanedUp; 
	private bool m_IsBroadcast; 

	public Socket Client { get; set; }


	public void .ctor() { }

	public void .ctor(AddressFamily family) { }

	public Socket get_Client() { }

	public void set_Client(Socket value) { }

	private void FreeResources() { }

	public void Dispose() { }

	protected virtual void Dispose(bool disposing) { }

	public void Connect(IPEndPoint endPoint) { }

	private void CheckForBroadcast(IPAddress ipAddress) { }

	public IAsyncResult BeginSend(byte[] datagram, int bytes, IPEndPoint endPoint, AsyncCallback requestCallback, object state) { }

	public IAsyncResult BeginSend(byte[] datagram, int bytes, AsyncCallback requestCallback, object state) { }

	public int EndSend(IAsyncResult asyncResult) { }

	public IAsyncResult BeginReceive(AsyncCallback requestCallback, object state) { }

	public byte[] EndReceive(IAsyncResult asyncResult, ref IPEndPoint remoteEP) { }

	public Task<int> SendAsync(byte[] datagram, int bytes) { }

	public Task<UdpReceiveResult> ReceiveAsync() { }

	private void createClientSocket() { }

	[CompilerGeneratedAttribute] 
	private IAsyncResult <ReceiveAsync>

	[CompilerGeneratedAttribute] 
	private UdpReceiveResult <ReceiveAsync>

}

