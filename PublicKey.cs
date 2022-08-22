public sealed class PublicKey // TypeDefIndex: 2811
{	private AsymmetricAlgorithm _key; // 0x10
	private AsnEncodedData _keyValue; // 0x18
	private AsnEncodedData _params; // 0x20
	private Oid _oid; // 0x28
	private static byte[] Empty; // 0x0

	public AsnEncodedData EncodedKeyValue { get; }
	public AsnEncodedData EncodedParameters { get; }
	public AsymmetricAlgorithm Key { get; }
	public Oid Oid { get; }


	internal void .ctor(X509Certificate certificate) { }

	public AsnEncodedData get_EncodedKeyValue() { }

	public AsnEncodedData get_EncodedParameters() { }

	public AsymmetricAlgorithm get_Key() { }

	public Oid get_Oid() { }

	private static byte[] GetUnsignedBigInteger(byte[] integer) { }

	internal static DSA DecodeDSA(byte[] rawPublicKey, byte[] rawParameters) { }

	internal static RSA DecodeRSA(byte[] rawPublicKey) { }

	private static void .cctor() { }

}

