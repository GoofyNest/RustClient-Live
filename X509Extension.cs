internal class X509Extension // TypeDefIndex: 61
{	// Fields
	protected string extnOid; // 0x10
	protected bool extnCritical; // 0x18
	protected ASN1 extnValue; // 0x20

	// Methods

	// RVA: 0x1596200 Offset: 0x1595600 VA: 0x181596200
	public void .ctor(ASN1 asn1) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 4
	protected virtual void Decode() { }

	// RVA: 0x1595D70 Offset: 0x1595170 VA: 0x181595D70 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0xDDCF60 Offset: 0xDDC360 VA: 0x180DDCF60 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1595FE0 Offset: 0x15953E0 VA: 0x181595FE0
	private void WriteLine(StringBuilder sb, int n, int pos) { }

	// RVA: 0x1595EC0 Offset: 0x15952C0 VA: 0x181595EC0 Slot: 3
	public override string ToString() { }

}

public class X509Extension // TypeDefIndex: 1719
{	// Fields
	protected string extnOid; // 0x10
	protected bool extnCritical; // 0x18
	protected ASN1 extnValue; // 0x20

	// Properties
	public string Oid { get; }
	public bool Critical { get; }
	public ASN1 Value { get; }

	// Methods

	// RVA: 0x227C960 Offset: 0x227BD60 VA: 0x18227C960
	public void .ctor(ASN1 asn1) { }

	// RVA: 0x227C800 Offset: 0x227BC00 VA: 0x18227C800
	public void .ctor(X509Extension extension) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 4
	protected virtual void Decode() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 5
	protected virtual void Encode() { }

	// RVA: 0x4B9460 Offset: 0x4B8860 VA: 0x1804B9460
	public string get_Oid() { }

	// RVA: 0x95B2D0 Offset: 0x95A6D0 VA: 0x18095B2D0
	public bool get_Critical() { }

	// RVA: 0x227CC10 Offset: 0x227C010 VA: 0x18227CC10
	public ASN1 get_Value() { }

	// RVA: 0x227C390 Offset: 0x227B790 VA: 0x18227C390 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0xDDCF60 Offset: 0xDDC360 VA: 0x180DDCF60 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x227C600 Offset: 0x227BA00 VA: 0x18227C600
	private void WriteLine(StringBuilder sb, int n, int pos) { }

	// RVA: 0x227C4E0 Offset: 0x227B8E0 VA: 0x18227C4E0 Slot: 3
	public override string ToString() { }

}

public class X509Extension : AsnEncodedData // TypeDefIndex: 2831
{	// Fields
	private bool _critical; // 0x20

	// Properties
	public bool Critical { get; set; }

	// Methods

	// RVA: 0x7992B0 Offset: 0x7986B0 VA: 0x1807992B0
	protected void .ctor() { }

	// RVA: 0x14DDAA0 Offset: 0x14DCEA0 VA: 0x1814DDAA0
	public void .ctor(string oid, byte[] rawData, bool critical) { }

	// RVA: 0xB0BB80 Offset: 0xB0AF80 VA: 0x180B0BB80
	public bool get_Critical() { }

	// RVA: 0x7D99E0 Offset: 0x7D8DE0 VA: 0x1807D99E0
	public void set_Critical(bool value) { }

	// RVA: 0x14DD8A0 Offset: 0x14DCCA0 VA: 0x1814DD8A0 Slot: 4
	public override void CopyFrom(AsnEncodedData asnEncodedData) { }

	// RVA: 0x14DD9B0 Offset: 0x14DCDB0 VA: 0x1814DD9B0
	internal string FormatUnkownData(byte[] data) { }

}

