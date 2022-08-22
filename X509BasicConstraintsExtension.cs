public sealed class X509BasicConstraintsExtension : X509Extension // TypeDefIndex: 2813
{	internal const string oid = "2.5.29.19";
	internal const string friendlyName = "Basic Constraints";
	private bool _certificateAuthority; // 0x28
	private bool _hasPathLengthConstraint; // 0x29
	private int _pathLengthConstraint; // 0x2C
	private AsnDecodeStatus _status; // 0x30

	public bool CertificateAuthority { get; }
	public bool HasPathLengthConstraint { get; }
	public int PathLengthConstraint { get; }


	public void .ctor() { }

	public void .ctor(AsnEncodedData encodedBasicConstraints, bool critical) { }

	public void .ctor(bool certificateAuthority, bool hasPathLengthConstraint, int pathLengthConstraint, bool critical) { }

	public bool get_CertificateAuthority() { }

	public bool get_HasPathLengthConstraint() { }

	public int get_PathLengthConstraint() { }

	public override void CopyFrom(AsnEncodedData asnEncodedData) { }

	internal AsnDecodeStatus Decode(byte[] extension) { }

	internal byte[] Encode() { }

	internal override string ToString(bool multiLine) { }

}

