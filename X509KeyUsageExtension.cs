public sealed class X509KeyUsageExtension : X509Extension // TypeDefIndex: 2836
{
internal const string oid = "2.5.29.15";
internal const string friendlyName = "Key Usage";
internal const X509KeyUsageFlags all = 33023;
	private X509KeyUsageFlags _keyUsages; 
	private AsnDecodeStatus _status; 

public X509KeyUsageFlags KeyUsages { get; }


public void .ctor() { }

public void .ctor(AsnEncodedData encodedKeyUsage, bool critical) { }

public void .ctor(X509KeyUsageFlags keyUsages, bool critical) { }

public X509KeyUsageFlags get_KeyUsages() { }

public override void CopyFrom(AsnEncodedData asnEncodedData) { }

internal X509KeyUsageFlags GetValidFlags(X509KeyUsageFlags flags) { }

internal AsnDecodeStatus Decode(byte[] extension) { }

internal byte[] Encode() { }

internal override string ToString(bool multiLine) { }

}

