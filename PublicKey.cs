public sealed class PublicKey // TypeDefIndex: 2811
{	// Fields
	private AsymmetricAlgorithm _key; // 0x10
	private AsnEncodedData _keyValue; // 0x18
	private AsnEncodedData _params; // 0x20
	private Oid _oid; // 0x28
	private static byte[] Empty; // 0x0

	// Properties
	public AsnEncodedData EncodedKeyValue { get; }
	public AsnEncodedData EncodedParameters { get; }
	public AsymmetricAlgorithm Key { get; }
	public Oid Oid { get; }

	// Methods

	// RVA: 0x1177BF0 Offset: 0x1176FF0 VA: 0x181177BF0
	internal void .ctor(X509Certificate certificate) { }

	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710
	public AsnEncodedData get_EncodedKeyValue() { }

	// RVA: 0x497E00 Offset: 0x497200 VA: 0x180497E00
	public AsnEncodedData get_EncodedParameters() { }

	// RVA: 0x1178270 Offset: 0x1177670 VA: 0x181178270
	public AsymmetricAlgorithm get_Key() { }

	// RVA: 0x7CE230 Offset: 0x7CD630 VA: 0x1807CE230
	public Oid get_Oid() { }

	// RVA: 0x1177AF0 Offset: 0x1176EF0 VA: 0x181177AF0
	private static byte[] GetUnsignedBigInteger(byte[] integer) { }

	// RVA: 0x1177400 Offset: 0x1176800 VA: 0x181177400
	internal static DSA DecodeDSA(byte[] rawPublicKey, byte[] rawParameters) { }

	// RVA: 0x1177810 Offset: 0x1176C10 VA: 0x181177810
	internal static RSA DecodeRSA(byte[] rawPublicKey) { }

	// RVA: 0x1177BA0 Offset: 0x1176FA0 VA: 0x181177BA0
	private static void .cctor() { }

}

