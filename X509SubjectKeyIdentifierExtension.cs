public sealed class X509SubjectKeyIdentifierExtension : X509Extension // TypeDefIndex: 2838
{	// Fields
	internal const string oid = "2.5.29.14";
	internal const string friendlyName = "Subject Key Identifier";
	private byte[] _subjectKeyIdentifier; // 0x28
	private string _ski; // 0x30
	private AsnDecodeStatus _status; // 0x38

	// Properties
	public string SubjectKeyIdentifier { get; }

	// Methods

	// RVA: 0x14DFDC0 Offset: 0x14DF1C0 VA: 0x1814DFDC0
	public void .ctor() { }

	// RVA: 0x14DFA60 Offset: 0x14DEE60 VA: 0x1814DFA60
	public void .ctor(AsnEncodedData encodedSubjectKeyIdentifier, bool critical) { }

	// RVA: 0x14DF8F0 Offset: 0x14DECF0 VA: 0x1814DF8F0
	public void .ctor(byte[] subjectKeyIdentifier, bool critical) { }

	// RVA: 0x14DFB30 Offset: 0x14DEF30 VA: 0x1814DFB30
	public void .ctor(string subjectKeyIdentifier, bool critical) { }

	// RVA: 0x14DFDA0 Offset: 0x14DF1A0 VA: 0x1814DFDA0
	public void .ctor(PublicKey key, bool critical) { }

	// RVA: 0x14DFE40 Offset: 0x14DF240 VA: 0x1814DFE40
	public void .ctor(PublicKey key, X509SubjectKeyIdentifierHashAlgorithm algorithm, bool critical) { }

	// RVA: 0x14E01E0 Offset: 0x14DF5E0 VA: 0x1814E01E0
	public string get_SubjectKeyIdentifier() { }

	// RVA: 0x14DF140 Offset: 0x14DE540 VA: 0x1814DF140 Slot: 4
	public override void CopyFrom(AsnEncodedData asnEncodedData) { }

	// RVA: 0x14DF4A0 Offset: 0x14DE8A0 VA: 0x1814DF4A0
	internal static byte FromHexChar(char c) { }

	// RVA: 0x14DF4D0 Offset: 0x14DE8D0 VA: 0x1814DF4D0
	internal static byte FromHexChars(char c1, char c2) { }

	// RVA: 0x14DF550 Offset: 0x14DE950 VA: 0x1814DF550
	internal static byte[] FromHex(string hex) { }

	// RVA: 0x14DF2C0 Offset: 0x14DE6C0 VA: 0x1814DF2C0
	internal AsnDecodeStatus Decode(byte[] extension) { }

	// RVA: 0x14DF420 Offset: 0x14DE820 VA: 0x1814DF420
	internal byte[] Encode() { }

	// RVA: 0x14DF6D0 Offset: 0x14DEAD0 VA: 0x1814DF6D0 Slot: 6
	internal override string ToString(bool multiLine) { }

}

