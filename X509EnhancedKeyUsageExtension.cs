public sealed class X509EnhancedKeyUsageExtension : X509Extension // TypeDefIndex: 2830
{	// Fields
	private OidCollection _enhKeyUsage; // 0x28
	private AsnDecodeStatus _status; // 0x30

	// Methods

	// RVA: 0x14DCC90 Offset: 0x14DC090 VA: 0x1814DCC90
	public void .ctor(AsnEncodedData encodedEnhancedKeyUsages, bool critical) { }

	// RVA: 0x14DC6F0 Offset: 0x14DBAF0 VA: 0x1814DC6F0 Slot: 4
	public override void CopyFrom(AsnEncodedData asnEncodedData) { }

	// RVA: 0x14DC870 Offset: 0x14DBC70 VA: 0x1814DC870
	internal AsnDecodeStatus Decode(byte[] extension) { }

	// RVA: 0x14DCA40 Offset: 0x14DBE40 VA: 0x1814DCA40 Slot: 6
	internal override string ToString(bool multiLine) { }

}

