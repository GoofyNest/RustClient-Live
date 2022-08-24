public class PKCS8.PrivateKeyInfo // TypeDefIndex: 72
{

public class PKCS8.PrivateKeyInfo 
	private int _version; 
	private string _algorithm; 
	private byte[] _key; 
	private ArrayList _list; 

public byte[] PrivateKey { get; }


public void .ctor() { }

public void .ctor(byte[] data) { }

public byte[] get_PrivateKey() { }

private void Decode(byte[] data) { }

private static byte[] RemoveLeadingZero(byte[] bigInt) { }

private static byte[] Normalize(byte[] bigInt, int length) { }

public static RSA DecodeRSA(byte[] keypair) { }

public static DSA DecodeDSA(byte[] privateKey, DSAParameters dsaParameters) { }

}

public class PKCS8.EncryptedPrivateKeyInfo // TypeDefIndex: 73
{
	private string _algorithm; 
	private byte[] _salt; 
	private int _iterations; 
	private byte[] _data; 

public string Algorithm { get; }
public byte[] EncryptedData { get; }
public byte[] Salt { get; }
public int IterationCount { get; }


public void .ctor() { }

public void .ctor(byte[] data) { }

public string get_Algorithm() { }

public byte[] get_EncryptedData() { }

public byte[] get_Salt() { }

public int get_IterationCount() { }

private void Decode(byte[] data) { }

}

public class PKCS8.PrivateKeyInfo // TypeDefIndex: 1759
{

public class PKCS8.PrivateKeyInfo 
	private int _version; 
	private string _algorithm; 
	private byte[] _key; 
	private ArrayList _list; 

public byte[] PrivateKey { get; }


public void .ctor() { }

public void .ctor(byte[] data) { }

public byte[] get_PrivateKey() { }

private void Decode(byte[] data) { }

private static byte[] RemoveLeadingZero(byte[] bigInt) { }

private static byte[] Normalize(byte[] bigInt, int length) { }

public static RSA DecodeRSA(byte[] keypair) { }

public static byte[] Encode(RSA rsa) { }

public static DSA DecodeDSA(byte[] privateKey, DSAParameters dsaParameters) { }

public static byte[] Encode(DSA dsa) { }

public static byte[] Encode(AsymmetricAlgorithm aa) { }

}

public class PKCS8.EncryptedPrivateKeyInfo // TypeDefIndex: 1760
{
	private string _algorithm; 
	private byte[] _salt; 
	private int _iterations; 
	private byte[] _data; 

public string Algorithm { get; }
public byte[] EncryptedData { get; }
public byte[] Salt { get; }
public int IterationCount { get; }


public void .ctor() { }

public void .ctor(byte[] data) { }

public string get_Algorithm() { }

public byte[] get_EncryptedData() { }

public byte[] get_Salt() { }

public int get_IterationCount() { }

private void Decode(byte[] data) { }

}

