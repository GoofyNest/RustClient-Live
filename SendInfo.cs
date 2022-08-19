public struct SendInfo // TypeDefIndex: 6701
{	// Fields
	public SendMethod method; // 0x0
	public sbyte channel; // 0x4
	public Priority priority; // 0x8
	public List<Connection> connections; // 0x10
	public Connection connection; // 0x18

	// Methods

	// RVA: 0x2372C0 Offset: 0x2366C0 VA: 0x1802372C0
	public void .ctor(List<Connection> connections) { }

	// RVA: 0x237290 Offset: 0x236690 VA: 0x180237290
	public void .ctor(Connection connection) { }

}

