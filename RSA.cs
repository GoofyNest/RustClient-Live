public abstract class RSA : AsymmetricAlgorithm // TypeDefIndex: 982
{

	protected void .ctor() { }

	public static RSA Create() { }

	public virtual byte[] EncryptValue(byte[] rgb) { }

	public override void FromXmlString(string xmlString) { }

	public override string ToXmlString(bool includePrivateParameters) { }

	public abstract RSAParameters ExportParameters(bool includePrivateParameters);

	public abstract void ImportParameters(RSAParameters parameters);

}

