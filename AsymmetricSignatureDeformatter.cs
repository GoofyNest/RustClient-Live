public abstract class AsymmetricSignatureDeformatter // TypeDefIndex: 939
{
	protected void .ctor() { }

	public abstract void SetKey(AsymmetricAlgorithm key);

	public abstract void SetHashAlgorithm(string strName);

	public abstract bool VerifySignature(byte[] rgbHash, byte[] rgbSignature);

}

