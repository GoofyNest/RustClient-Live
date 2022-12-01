public struct ReceivePacketOptions // TypeDefIndex: 8998
{
	[CompilerGeneratedAttribute]
	private ProductUserId <LocalUserId>k__BackingField;
	[CompilerGeneratedAttribute]
	private uint <MaxDataSizeBytes>k__BackingField;
	[CompilerGeneratedAttribute]
	private Nullable<byte> <RequestedChannel>k__BackingField;

	public ProductUserId LocalUserId { get; set; }
	public uint MaxDataSizeBytes { get; set; }
	public Nullable<byte> RequestedChannel { get; set; }


	[CompilerGeneratedAttribute]
	public ProductUserId get_LocalUserId() { }

	[CompilerGeneratedAttribute]
	public void set_LocalUserId(ProductUserId value) { }

	[CompilerGeneratedAttribute]
	public uint get_MaxDataSizeBytes() { }

	[CompilerGeneratedAttribute]
	public void set_MaxDataSizeBytes(uint value) { }

	[CompilerGeneratedAttribute]
	public Nullable<byte> get_RequestedChannel() { }

	[CompilerGeneratedAttribute]
	public void set_RequestedChannel(Nullable<byte> value) { }

}

