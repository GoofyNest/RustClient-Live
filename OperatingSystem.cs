public sealed class OperatingSystem : ICloneable, ISerializable // TypeDefIndex: 384
{	// Fields
	private PlatformID _platform; // 0x10
	private Version _version; // 0x18
	private string _servicePack; // 0x20

	// Properties
	public PlatformID Platform { get; }
	public Version Version { get; }
	public string ServicePack { get; }

	// Methods

	// RVA: 0x167E950 Offset: 0x167DD50 VA: 0x18167E950
	public void .ctor(PlatformID platform, Version version) { }

	// RVA: 0x167EA90 Offset: 0x167DE90 VA: 0x18167EA90
	private void .ctor(SerializationInfo information, StreamingContext context) { }

	// RVA: 0x36A480 Offset: 0x369880 VA: 0x18036A480
	public PlatformID get_Platform() { }

	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710
	public Version get_Version() { }

	// RVA: 0x497E00 Offset: 0x497200 VA: 0x180497E00
	public string get_ServicePack() { }

	// RVA: 0x167E5F0 Offset: 0x167D9F0 VA: 0x18167E5F0 Slot: 4
	public object Clone() { }

	// RVA: 0x167E760 Offset: 0x167DB60 VA: 0x18167E760 Slot: 5
	public void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x167E800 Offset: 0x167DC00 VA: 0x18167E800 Slot: 3
	public override string ToString() { }

}

