public class TcpListener // TypeDefIndex: 3059
{	// Fields
	private IPEndPoint m_ServerSocketEP; // 0x10
	private Socket m_ServerSocket; // 0x18
	private bool m_Active; // 0x20
	private bool m_ExclusiveAddressUse; // 0x21

	// Methods

	// RVA: 0x1006A90 Offset: 0x1005E90 VA: 0x181006A90
	public void .ctor(IPAddress localaddr, int port) { }

	// RVA: 0x1006920 Offset: 0x1005D20 VA: 0x181006920
	public void Start() { }

	// RVA: 0x1006730 Offset: 0x1005B30 VA: 0x181006730
	public void Start(int backlog) { }

	// RVA: 0x1006930 Offset: 0x1005D30 VA: 0x181006930
	public void Stop() { }

	// RVA: 0x1006600 Offset: 0x1005A00 VA: 0x181006600
	public bool Pending() { }

	// RVA: 0x1006570 Offset: 0x1005970 VA: 0x181006570
	public Socket AcceptSocket() { }

}

