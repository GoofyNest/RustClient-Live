public class UdpClient : IDisposable // TypeDefIndex: 3060
{	private Socket m_ClientSocket; // 0x10
	private bool m_Active; // 0x18
	private byte[] m_Buffer; // 0x20
	private AddressFamily m_Family; // 0x28
	private bool m_CleanedUp; // 0x2C
	private bool m_IsBroadcast; // 0x2D

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

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private IAsyncResult <ReceiveAsync>b__64_0(AsyncCallback callback, object state) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private UdpReceiveResult <ReceiveAsync>b__64_1(IAsyncResult ar) { }

}

