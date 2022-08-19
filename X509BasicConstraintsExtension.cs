public sealed class X509BasicConstraintsExtension : X509Extension // TypeDefIndex: 2813
{	// Fields
	internal const string oid = "2.5.29.19";
	internal const string friendlyName = "Basic Constraints";
	private bool _certificateAuthority; // 0x28
	private bool _hasPathLengthConstraint; // 0x29
	private int _pathLengthConstraint; // 0x2C
	private AsnDecodeStatus _status; // 0x30

	// Properties
	public bool CertificateAuthority { get; }
	public bool HasPathLengthConstraint { get; }
	public int PathLengthConstraint { get; }

	// Methods

	// RVA: 0x118B790 Offset: 0x118AB90 VA: 0x18118B790
	public void .ctor() { }

	// RVA: 0x118BB20 Offset: 0x118AF20 VA: 0x18118BB20
	public void .ctor(AsnEncodedData encodedBasicConstraints, bool critical) { }

	// RVA: 0x118B840 Offset: 0x118AC40 VA: 0x18118B840
	public void .ctor(bool certificateAuthority, bool hasPathLengthConstraint, int pathLengthConstraint, bool critical) { }

	// RVA: 0x118BC10 Offset: 0x118B010 VA: 0x18118BC10
	public bool get_CertificateAuthority() { }

	// RVA: 0x118BC80 Offset: 0x118B080 VA: 0x18118BC80
	public bool get_HasPathLengthConstraint() { }

	// RVA: 0x118BCF0 Offset: 0x118B0F0 VA: 0x18118BCF0
	public int get_PathLengthConstraint() { }

	// RVA: 0x118B0C0 Offset: 0x118A4C0 VA: 0x18118B0C0 Slot: 4
	public override void CopyFrom(AsnEncodedData asnEncodedData) { }

	// RVA: 0x118B2B0 Offset: 0x118A6B0 VA: 0x18118B2B0
	internal AsnDecodeStatus Decode(byte[] extension) { }

	// RVA: 0x118B440 Offset: 0x118A840 VA: 0x18118B440
	internal byte[] Encode() { }

	// RVA: 0x118B5A0 Offset: 0x118A9A0 VA: 0x18118B5A0 Slot: 6
	internal override string ToString(bool multiLine) { }

}

