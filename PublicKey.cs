public sealed class PublicKey // TypeDefIndex: 2811
{
	private AsymmetricAlgorithm _key;
	private AsnEncodedData _keyValue;
	private AsnEncodedData _params;
	private Oid _oid;
	private static byte[] Empty;

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

