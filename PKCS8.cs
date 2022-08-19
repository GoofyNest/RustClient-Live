public class PKCS8.PrivateKeyInfo // TypeDefIndex: 72
{
// Namespace: 
public class PKCS8.PrivateKeyInfo // TypeDefIndex: 72
	// Fields
	private int _version; // 0x10
	private string _algorithm; // 0x18
	private byte[] _key; // 0x20
	private ArrayList _list; // 0x28

	// Properties
	public byte[] PrivateKey { get; }

	// Methods

	// RVA: 0x174F420 Offset: 0x174E820 VA: 0x18174F420
	public void .ctor() { }

	// RVA: 0x174F390 Offset: 0x174E790 VA: 0x18174F390
	public void .ctor(byte[] data) { }

	// RVA: 0x174F490 Offset: 0x174E890 VA: 0x18174F490
	public byte[] get_PrivateKey() { }

	// RVA: 0x174EF90 Offset: 0x174E390 VA: 0x18174EF90
	private void Decode(byte[] data) { }

	// RVA: 0x174F2E0 Offset: 0x174E6E0 VA: 0x18174F2E0
	private static byte[] RemoveLeadingZero(byte[] bigInt) { }

	// RVA: 0x174F230 Offset: 0x174E630 VA: 0x18174F230
	private static byte[] Normalize(byte[] bigInt, int length) { }

	// RVA: 0x174EB10 Offset: 0x174DF10 VA: 0x18174EB10
	public static RSA DecodeRSA(byte[] keypair) { }

	// RVA: 0x174E970 Offset: 0x174DD70 VA: 0x18174E970
	public static DSA DecodeDSA(byte[] privateKey, DSAParameters dsaParameters) { }

}

public class PKCS8.EncryptedPrivateKeyInfo // TypeDefIndex: 73
{	// Fields
	private string _algorithm; // 0x10
	private byte[] _salt; // 0x18
	private int _iterations; // 0x20
	private byte[] _data; // 0x28

	// Properties
	public string Algorithm { get; }
	public byte[] EncryptedData { get; }
	public byte[] Salt { get; }
	public int IterationCount { get; }

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x17436E0 Offset: 0x1742AE0 VA: 0x1817436E0
	public void .ctor(byte[] data) { }

	// RVA: 0x4B9460 Offset: 0x4B8860 VA: 0x1804B9460
	public string get_Algorithm() { }

	// RVA: 0x1743710 Offset: 0x1742B10 VA: 0x181743710
	public byte[] get_EncryptedData() { }

	// RVA: 0x1743790 Offset: 0x1742B90 VA: 0x181743790
	public byte[] get_Salt() { }

	// RVA: 0x4D0170 Offset: 0x4CF570 VA: 0x1804D0170
	public int get_IterationCount() { }

	// RVA: 0x17433E0 Offset: 0x17427E0 VA: 0x1817433E0
	private void Decode(byte[] data) { }

}

public class PKCS8.PrivateKeyInfo // TypeDefIndex: 1759
{
// Namespace: 
public class PKCS8.PrivateKeyInfo // TypeDefIndex: 1759
	// Fields
	private int _version; // 0x10
	private string _algorithm; // 0x18
	private byte[] _key; // 0x20
	private ArrayList _list; // 0x28

	// Properties
	public byte[] PrivateKey { get; }

	// Methods

	// RVA: 0x1ABDC50 Offset: 0x1ABD050 VA: 0x181ABDC50
	public void .ctor() { }

	// RVA: 0x1ABDBC0 Offset: 0x1ABCFC0 VA: 0x181ABDBC0
	public void .ctor(byte[] data) { }

	// RVA: 0x1ABDCC0 Offset: 0x1ABD0C0 VA: 0x181ABDCC0
	public byte[] get_PrivateKey() { }

	// RVA: 0x1ABCFA0 Offset: 0x1ABC3A0 VA: 0x181ABCFA0
	private void Decode(byte[] data) { }

	// RVA: 0x1ABDB10 Offset: 0x1ABCF10 VA: 0x181ABDB10
	private static byte[] RemoveLeadingZero(byte[] bigInt) { }

	// RVA: 0x1ABDA60 Offset: 0x1ABCE60 VA: 0x181ABDA60
	private static byte[] Normalize(byte[] bigInt, int length) { }

	// RVA: 0x1ABCB10 Offset: 0x1ABBF10 VA: 0x181ABCB10
	public static RSA DecodeRSA(byte[] keypair) { }

	// RVA: 0x1ABD4C0 Offset: 0x1ABC8C0 VA: 0x181ABD4C0
	public static byte[] Encode(RSA rsa) { }

	// RVA: 0x1ABC970 Offset: 0x1ABBD70 VA: 0x181ABC970
	public static DSA DecodeDSA(byte[] privateKey, DSAParameters dsaParameters) { }

	// RVA: 0x1ABD260 Offset: 0x1ABC660 VA: 0x181ABD260
	public static byte[] Encode(DSA dsa) { }

	// RVA: 0x1ABD2D0 Offset: 0x1ABC6D0 VA: 0x181ABD2D0
	public static byte[] Encode(AsymmetricAlgorithm aa) { }

}

public class PKCS8.EncryptedPrivateKeyInfo // TypeDefIndex: 1760
{	// Fields
	private string _algorithm; // 0x10
	private byte[] _salt; // 0x18
	private int _iterations; // 0x20
	private byte[] _data; // 0x28

	// Properties
	public string Algorithm { get; }
	public byte[] EncryptedData { get; }
	public byte[] Salt { get; }
	public int IterationCount { get; }

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x1AAFEE0 Offset: 0x1AAF2E0 VA: 0x181AAFEE0
	public void .ctor(byte[] data) { }

	// RVA: 0x4B9460 Offset: 0x4B8860 VA: 0x1804B9460
	public string get_Algorithm() { }

	// RVA: 0x1AAFF10 Offset: 0x1AAF310 VA: 0x181AAFF10
	public byte[] get_EncryptedData() { }

	// RVA: 0x1AAFF90 Offset: 0x1AAF390 VA: 0x181AAFF90
	public byte[] get_Salt() { }

	// RVA: 0x4D0170 Offset: 0x4CF570 VA: 0x1804D0170
	public int get_IterationCount() { }

	// RVA: 0x1AAFBD0 Offset: 0x1AAEFD0 VA: 0x181AAFBD0
	private void Decode(byte[] data) { }

}

