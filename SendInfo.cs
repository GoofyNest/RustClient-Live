public struct SendInfo // TypeDefIndex: 6701
{	public SendMethod method; // 0x0
	public sbyte channel; // 0x4
	public Priority priority; // 0x8
	public List<Connection> connections; // 0x10
	public Connection connection; // 0x18


	public void .ctor(List<Connection> connections) { }

	public void .ctor(Connection connection) { }

}

