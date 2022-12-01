internal class DynamicPropertyCollection // TypeDefIndex: 1172
{
	private ArrayList _properties;

	public bool HasProperties { get; }


	public bool get_HasProperties() { }

	public bool RegisterDynamicProperty(IDynamicProperty prop) { }

	public bool UnregisterDynamicProperty(string name) { }

	public void NotifyMessage(bool start, IMessage msg, bool client_site, bool async) { }

	private int FindProperty(string name) { }

	public void .ctor() { }

}

private class DynamicPropertyCollection.DynamicPropertyReg // TypeDefIndex: 1173
{
	public IDynamicProperty Property;
	public IDynamicMessageSink Sink;


	public void .ctor() { }

}

