public class ObjRef : IObjectReference, ISerializable // TypeDefIndex: 1136
{
	private IChannelInfo channel_info;
	private string uri;
	private IRemotingTypeInfo typeInfo;
	private IEnvoyInfo envoyInfo;
	private int flags;
	private Type _serverType;
	private static int MarshalledObjectRef;
	private static int WellKnowObjectRef;

	internal bool IsReferenceToWellKnow { get; }
	public virtual IChannelInfo ChannelInfo { get; }
	public virtual IEnvoyInfo EnvoyInfo { get; set; }
	public virtual IRemotingTypeInfo TypeInfo { get; set; }
	public virtual string URI { get; set; }
	internal Type ServerType { get; }


	public void .ctor() { }

	internal void .ctor(string uri, IChannelInfo cinfo) { }

	internal ObjRef DeserializeInTheCurrentDomain(int domainId, byte[] tInfo) { }

	internal byte[] SerializeType() { }

	internal void .ctor(Type type, string url, object remoteChannelData) { }

	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	internal bool get_IsReferenceToWellKnow() { }

	[ReliabilityContractAttribute]
	public virtual IChannelInfo get_ChannelInfo() { }

	public virtual IEnvoyInfo get_EnvoyInfo() { }

	public virtual void set_EnvoyInfo(IEnvoyInfo value) { }

	public virtual IRemotingTypeInfo get_TypeInfo() { }

	public virtual void set_TypeInfo(IRemotingTypeInfo value) { }

	public virtual string get_URI() { }

	public virtual void set_URI(string value) { }

	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	public virtual object GetRealObject(StreamingContext context) { }

	internal void UpdateChannelInfo() { }

	internal Type get_ServerType() { }

	private static void .cctor() { }

}

