public class TcpListener // TypeDefIndex: 3059
{
	private IPEndPoint m_ServerSocketEP; 
	private Socket m_ServerSocket; 
	private bool m_Active; 
	private bool m_ExclusiveAddressUse; 


	public void .ctor(IPAddress localaddr, int port) { }

	public void Start() { }

	public void Start(int backlog) { }

	public void Stop() { }

	public bool Pending() { }

	public Socket AcceptSocket() { }

}

