public class TcpListener // TypeDefIndex: 3059
{	private IPEndPoint m_ServerSocketEP; // 0x10
	private Socket m_ServerSocket; // 0x18
	private bool m_Active; // 0x20
	private bool m_ExclusiveAddressUse; // 0x21


	public void .ctor(IPAddress localaddr, int port) { }

	public void Start() { }

	public void Start(int backlog) { }

	public void Stop() { }

	public bool Pending() { }

	public Socket AcceptSocket() { }

}

