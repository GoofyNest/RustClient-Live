internal class X509Extension // TypeDefIndex: 61
{	protected string extnOid; // 0x10
	protected bool extnCritical; // 0x18
	protected ASN1 extnValue; // 0x20


	public void .ctor(ASN1 asn1) { }

	protected virtual void Decode() { }

	public override bool Equals(object obj) { }

	public override int GetHashCode() { }

	private void WriteLine(StringBuilder sb, int n, int pos) { }

	public override string ToString() { }

}

public class X509Extension // TypeDefIndex: 1719
{	protected string extnOid; // 0x10
	protected bool extnCritical; // 0x18
	protected ASN1 extnValue; // 0x20

	public string Oid { get; }
	public bool Critical { get; }
	public ASN1 Value { get; }


	public void .ctor(ASN1 asn1) { }

	public void .ctor(X509Extension extension) { }

	protected virtual void Decode() { }

	protected virtual void Encode() { }

	public string get_Oid() { }

	public bool get_Critical() { }

	public ASN1 get_Value() { }

	public override bool Equals(object obj) { }

	public override int GetHashCode() { }

	private void WriteLine(StringBuilder sb, int n, int pos) { }

	public override string ToString() { }

}

public class X509Extension : AsnEncodedData // TypeDefIndex: 2831
{	private bool _critical; // 0x20

	public bool Critical { get; set; }


	protected void .ctor() { }

	public void .ctor(string oid, byte[] rawData, bool critical) { }

	public bool get_Critical() { }

	public void set_Critical(bool value) { }

	public override void CopyFrom(AsnEncodedData asnEncodedData) { }

	internal string FormatUnkownData(byte[] data) { }

}

