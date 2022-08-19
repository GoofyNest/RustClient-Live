public class AsnEncodedData // TypeDefIndex: 2797
{	// Fields
	internal Oid _oid; // 0x10
	internal byte[] _raw; // 0x18

	// Properties
	public Oid Oid { get; set; }
	public byte[] RawData { get; set; }

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	protected void .ctor() { }

	// RVA: 0x1174D30 Offset: 0x1174130 VA: 0x181174D30
	public void .ctor(string oid, byte[] rawData) { }

	// RVA: 0x1174E80 Offset: 0x1174280 VA: 0x181174E80
	public void .ctor(Oid oid, byte[] rawData) { }

	// RVA: 0x4B9460 Offset: 0x4B8860 VA: 0x1804B9460
	public Oid get_Oid() { }

	// RVA: 0x1174F60 Offset: 0x1174360 VA: 0x181174F60
	public void set_Oid(Oid value) { }

	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710
	public byte[] get_RawData() { }

	// RVA: 0x1175020 Offset: 0x1174420 VA: 0x181175020
	public void set_RawData(byte[] value) { }

	// RVA: 0x1174080 Offset: 0x1173480 VA: 0x181174080 Slot: 4
	public virtual void CopyFrom(AsnEncodedData asnEncodedData) { }

	// RVA: 0x1174420 Offset: 0x1173820 VA: 0x181174420 Slot: 5
	public virtual string Format(bool multiLine) { }

	// RVA: 0x1174BA0 Offset: 0x1173FA0 VA: 0x181174BA0 Slot: 6
	internal virtual string ToString(bool multiLine) { }

	// RVA: 0x1174250 Offset: 0x1173650 VA: 0x181174250
	internal string Default(bool multiLine) { }

	// RVA: 0x1173F30 Offset: 0x1173330 VA: 0x181173F30
	internal string BasicConstraintsExtension(bool multiLine) { }

	// RVA: 0x1174370 Offset: 0x1173770 VA: 0x181174370
	internal string EnhancedKeyUsageExtension(bool multiLine) { }

	// RVA: 0x11744B0 Offset: 0x11738B0 VA: 0x1811744B0
	internal string KeyUsageExtension(bool multiLine) { }

	// RVA: 0x1174AF0 Offset: 0x1173EF0 VA: 0x181174AF0
	internal string SubjectKeyIdentifierExtension(bool multiLine) { }

	// RVA: 0x1174880 Offset: 0x1173C80 VA: 0x181174880
	internal string SubjectAltName(bool multiLine) { }

	// RVA: 0x1174560 Offset: 0x1173960 VA: 0x181174560
	internal string NetscapeCertType(bool multiLine) { }

}

