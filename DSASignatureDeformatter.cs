public class DSASignatureDeformatter : AsymmetricSignatureDeformatter // TypeDefIndex: 957
{	private DSA _dsaKey; // 0x10
	private string _oid; // 0x18


	public void .ctor() { }

	public void .ctor(AsymmetricAlgorithm key) { }

	public override void SetKey(AsymmetricAlgorithm key) { }

	public override void SetHashAlgorithm(string strName) { }

	public override bool VerifySignature(byte[] rgbHash, byte[] rgbSignature) { }

}

