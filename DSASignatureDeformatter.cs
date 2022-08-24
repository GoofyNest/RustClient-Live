public class DSASignatureDeformatter : AsymmetricSignatureDeformatter // TypeDefIndex: 957
{
	private DSA _dsaKey; 
	private string _oid; 


	public void .ctor() { }

	public void .ctor(AsymmetricAlgorithm key) { }

	public override void SetKey(AsymmetricAlgorithm key) { }

	public override void SetHashAlgorithm(string strName) { }

	public override bool VerifySignature(byte[] rgbHash, byte[] rgbSignature) { }

}

