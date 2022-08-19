public class UdpClient : IDisposable // TypeDefIndex: 3060
{	// Fields
	private Socket m_ClientSocket; // 0x10
	private bool m_Active; // 0x18
	private byte[] m_Buffer; // 0x20
	private AddressFamily m_Family; // 0x28
	private bool m_CleanedUp; // 0x2C
	private bool m_IsBroadcast; // 0x2D

	// Properties
	public Socket Client { get; set; }

	// Methods

	// RVA: 0x100A920 Offset: 0x1009D20 VA: 0x18100A920
	public void .ctor() { }

	// RVA: 0x100A7C0 Offset: 0x1009BC0 VA: 0x18100A7C0
	public void .ctor(AddressFamily family) { }

	// RVA: 0x4B9460 Offset: 0x4B8860 VA: 0x1804B9460
	public Socket get_Client() { }

	// RVA: 0x4B94C0 Offset: 0x4B88C0 VA: 0x1804B94C0
	public void set_Client(Socket value) { }

	// RVA: 0x100A290 Offset: 0x1009690 VA: 0x18100A290
	private void FreeResources() { }

	// RVA: 0x1009F60 Offset: 0x1009360 VA: 0x181009F60 Slot: 4
	public void Dispose() { }

	// RVA: 0x1009EB0 Offset: 0x10092B0 VA: 0x181009EB0 Slot: 5
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x1009D70 Offset: 0x1009170 VA: 0x181009D70
	public void Connect(IPEndPoint endPoint) { }

	// RVA: 0x1009D00 Offset: 0x1009100 VA: 0x181009D00
	private void CheckForBroadcast(IPAddress ipAddress) { }

	// RVA: 0x1009A90 Offset: 0x1008E90 VA: 0x181009A90
	public IAsyncResult BeginSend(byte[] datagram, int bytes, IPEndPoint endPoint, AsyncCallback requestCallback, object state) { }

	// RVA: 0x1009A60 Offset: 0x1008E60 VA: 0x181009A60
	public IAsyncResult BeginSend(byte[] datagram, int bytes, AsyncCallback requestCallback, object state) { }

	// RVA: 0x100A1C0 Offset: 0x10095C0 VA: 0x18100A1C0
	public int EndSend(IAsyncResult asyncResult) { }

	// RVA: 0x1009910 Offset: 0x1008D10 VA: 0x181009910
	public IAsyncResult BeginReceive(AsyncCallback requestCallback, object state) { }

	// RVA: 0x1009F80 Offset: 0x1009380 VA: 0x181009F80
	public byte[] EndReceive(IAsyncResult asyncResult, ref IPEndPoint remoteEP) { }

	// RVA: 0x100A4D0 Offset: 0x10098D0 VA: 0x18100A4D0
	public Task<int> SendAsync(byte[] datagram, int bytes) { }

	// RVA: 0x100A300 Offset: 0x1009700 VA: 0x18100A300
	public Task<UdpReceiveResult> ReceiveAsync() { }

	// RVA: 0x100AA00 Offset: 0x1009E00 VA: 0x18100AA00
	private void createClientSocket() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1009910 Offset: 0x1008D10 VA: 0x181009910
	private IAsyncResult <ReceiveAsync>b__64_0(AsyncCallback callback, object state) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x100A6C0 Offset: 0x1009AC0 VA: 0x18100A6C0
	private UdpReceiveResult <ReceiveAsync>b__64_1(IAsyncResult ar) { }

}

