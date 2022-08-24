public class RSAPKCS1SignatureDeformatter : AsymmetricSignatureDeformatter // TypeDefIndex: 1009
{
	private RSA rsa; 
	private string hashName; 


public void .ctor() { }

public void .ctor(AsymmetricAlgorithm key) { }

public override void SetHashAlgorithm(string strName) { }

public override void SetKey(AsymmetricAlgorithm key) { }

public override bool VerifySignature(byte[] rgbHash, byte[] rgbSignature) { }

}

