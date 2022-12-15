public struct SendInfo // TypeDefIndex: 6879
{
	public SendMethod method;
	public sbyte channel;
	public Priority priority;
	public List<Connection> connections;
	public Connection connection;


	public void .ctor(List<Connection> connections) { }

	public void .ctor(Connection connection) { }

}

