public class AsnEncodedData // TypeDefIndex: 2797
{
	internal Oid _oid;
	internal byte[] _raw;

	public Oid Oid { get; set; }
	public byte[] RawData { get; set; }


	protected void .ctor() { }

	public void .ctor(string oid, byte[] rawData) { }

	public void .ctor(Oid oid, byte[] rawData) { }

	public Oid get_Oid() { }

	public void set_Oid(Oid value) { }

	public byte[] get_RawData() { }

	public void set_RawData(byte[] value) { }

	public virtual void CopyFrom(AsnEncodedData asnEncodedData) { }

	public virtual string Format(bool multiLine) { }

	internal virtual string ToString(bool multiLine) { }

	internal string Default(bool multiLine) { }

	internal string BasicConstraintsExtension(bool multiLine) { }

	internal string EnhancedKeyUsageExtension(bool multiLine) { }

	internal string KeyUsageExtension(bool multiLine) { }

	internal string SubjectKeyIdentifierExtension(bool multiLine) { }

	internal string SubjectAltName(bool multiLine) { }

	internal string NetscapeCertType(bool multiLine) { }

}

