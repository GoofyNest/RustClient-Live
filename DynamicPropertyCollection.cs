internal class DynamicPropertyCollection // TypeDefIndex: 1172
{	// Fields
	private ArrayList _properties; // 0x10

	// Properties
	public bool HasProperties { get; }

	// Methods

	// RVA: 0x14721D0 Offset: 0x14715D0 VA: 0x1814721D0
	public bool get_HasProperties() { }

	// RVA: 0x1471DF0 Offset: 0x14711F0 VA: 0x181471DF0
	public bool RegisterDynamicProperty(IDynamicProperty prop) { }

	// RVA: 0x1472000 Offset: 0x1471400 VA: 0x181472000
	public bool UnregisterDynamicProperty(string name) { }

	// RVA: 0x1471940 Offset: 0x1470D40 VA: 0x181471940
	public void NotifyMessage(bool start, IMessage msg, bool client_site, bool async) { }

	// RVA: 0x14717C0 Offset: 0x1470BC0 VA: 0x1814717C0
	private int FindProperty(string name) { }

	// RVA: 0x1472160 Offset: 0x1471560 VA: 0x181472160
	public void .ctor() { }

}

private class DynamicPropertyCollection.DynamicPropertyReg // TypeDefIndex: 1173
{	// Fields
	public IDynamicProperty Property; // 0x10
	public IDynamicMessageSink Sink; // 0x18

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

}

