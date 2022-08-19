public class ObjRef : IObjectReference, ISerializable // TypeDefIndex: 1136
{	// Fields
	private IChannelInfo channel_info; // 0x10
	private string uri; // 0x18
	private IRemotingTypeInfo typeInfo; // 0x20
	private IEnvoyInfo envoyInfo; // 0x28
	private int flags; // 0x30
	private Type _serverType; // 0x38
	private static int MarshalledObjectRef; // 0x0
	private static int WellKnowObjectRef; // 0x4

	// Properties
	internal bool IsReferenceToWellKnow { get; }
	public virtual IChannelInfo ChannelInfo { get; }
	public virtual IEnvoyInfo EnvoyInfo { get; set; }
	public virtual IRemotingTypeInfo TypeInfo { get; set; }
	public virtual string URI { get; set; }
	internal Type ServerType { get; }

	// Methods

	// RVA: 0x147C7D0 Offset: 0x147BBD0 VA: 0x18147C7D0
	public void .ctor() { }

	// RVA: 0x147CC50 Offset: 0x147C050 VA: 0x18147CC50
	internal void .ctor(string uri, IChannelInfo cinfo) { }

	// RVA: 0x147C230 Offset: 0x147B630 VA: 0x18147C230
	internal ObjRef DeserializeInTheCurrentDomain(int domainId, byte[] tInfo) { }

	// RVA: 0x147C590 Offset: 0x147B990 VA: 0x18147C590
	internal byte[] SerializeType() { }

	// RVA: 0x147C6D0 Offset: 0x147BAD0 VA: 0x18147C6D0
	internal void .ctor(Type type, string url, object remoteChannelData) { }

	// RVA: 0x147C840 Offset: 0x147BC40 VA: 0x18147C840
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x147CCA0 Offset: 0x147C0A0 VA: 0x18147CCA0
	internal bool get_IsReferenceToWellKnow() { }

	[ReliabilityContractAttribute] // RVA: 0x76C70 Offset: 0x76070 VA: 0x180076C70
	// RVA: 0x4B9460 Offset: 0x4B8860 VA: 0x1804B9460 Slot: 6
	public virtual IChannelInfo get_ChannelInfo() { }

	// RVA: 0x7CE230 Offset: 0x7CD630 VA: 0x1807CE230 Slot: 7
	public virtual IEnvoyInfo get_EnvoyInfo() { }

	// RVA: 0x7CE240 Offset: 0x7CD640 VA: 0x1807CE240 Slot: 8
	public virtual void set_EnvoyInfo(IEnvoyInfo value) { }

	// RVA: 0x497E00 Offset: 0x497200 VA: 0x180497E00 Slot: 9
	public virtual IRemotingTypeInfo get_TypeInfo() { }

	// RVA: 0x497E30 Offset: 0x497230 VA: 0x180497E30 Slot: 10
	public virtual void set_TypeInfo(IRemotingTypeInfo value) { }

	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710 Slot: 11
	public virtual string get_URI() { }

	// RVA: 0x4D0180 Offset: 0x4CF580 VA: 0x1804D0180 Slot: 12
	public virtual void set_URI(string value) { }

	// RVA: 0x147C350 Offset: 0x147B750 VA: 0x18147C350 Slot: 13
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x147C4A0 Offset: 0x147B8A0 VA: 0x18147C4A0 Slot: 14
	public virtual object GetRealObject(StreamingContext context) { }

	// RVA: 0x147C620 Offset: 0x147BA20 VA: 0x18147C620
	internal void UpdateChannelInfo() { }

	// RVA: 0x147CD10 Offset: 0x147C110 VA: 0x18147CD10
	internal Type get_ServerType() { }

	// RVA: 0x147C680 Offset: 0x147BA80 VA: 0x18147C680
	private static void .cctor() { }

}

