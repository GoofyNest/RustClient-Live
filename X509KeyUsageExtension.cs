public sealed class X509KeyUsageExtension : X509Extension // TypeDefIndex: 2836
{	// Fields
	internal const string oid = "2.5.29.15";
	internal const string friendlyName = "Key Usage";
	internal const X509KeyUsageFlags all = 33023;
	private X509KeyUsageFlags _keyUsages; // 0x28
	private AsnDecodeStatus _status; // 0x2C

	// Properties
	public X509KeyUsageFlags KeyUsages { get; }

	// Methods

	// RVA: 0x14DEAF0 Offset: 0x14DDEF0 VA: 0x1814DEAF0
	public void .ctor() { }

	// RVA: 0x14DE960 Offset: 0x14DDD60 VA: 0x1814DE960
	public void .ctor(AsnEncodedData encodedKeyUsage, bool critical) { }

	// RVA: 0x14DEA30 Offset: 0x14DDE30 VA: 0x1814DEA30
	public void .ctor(X509KeyUsageFlags keyUsages, bool critical) { }

	// RVA: 0x14DEB70 Offset: 0x14DDF70 VA: 0x1814DEB70
	public X509KeyUsageFlags get_KeyUsages() { }

	// RVA: 0x14DE060 Offset: 0x14DD460 VA: 0x1814DE060 Slot: 4
	public override void CopyFrom(AsnEncodedData asnEncodedData) { }

	// RVA: 0x14DE520 Offset: 0x14DD920 VA: 0x1814DE520
	internal X509KeyUsageFlags GetValidFlags(X509KeyUsageFlags flags) { }

	// RVA: 0x14DE1E0 Offset: 0x14DD5E0 VA: 0x1814DE1E0
	internal AsnDecodeStatus Decode(byte[] extension) { }

	// RVA: 0x14DE360 Offset: 0x14DD760 VA: 0x1814DE360
	internal byte[] Encode() { }

	// RVA: 0x14DE530 Offset: 0x14DD930 VA: 0x1814DE530 Slot: 6
	internal override string ToString(bool multiLine) { }

}

