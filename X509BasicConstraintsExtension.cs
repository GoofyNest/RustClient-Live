public sealed class X509BasicConstraintsExtension : X509Extension // TypeDefIndex: 2813
{
	internal const string oid = "2.5.29.19";
	internal const string friendlyName = "Basic Constraints";
	private bool _certificateAuthority; 
	private bool _hasPathLengthConstraint; 
	private int _pathLengthConstraint; 
	private AsnDecodeStatus _status; 

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

