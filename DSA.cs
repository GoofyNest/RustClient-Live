public abstract class DSA : AsymmetricAlgorithm // TypeDefIndex: 956
{
	protected void .ctor() { }

	public static DSA Create() { }

	public abstract bool VerifySignature(byte[] rgbHash, byte[] rgbSignature);

	public override void FromXmlString(string xmlString) { }

	public override string ToXmlString(bool includePrivateParameters) { }

	public abstract DSAParameters ExportParameters(bool includePrivateParameters);

	public abstract void ImportParameters(DSAParameters parameters);

}

