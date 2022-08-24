public sealed class OperatingSystem : ICloneable, ISerializable // TypeDefIndex: 384
{
	private PlatformID _platform; 
	private Version _version; 
	private string _servicePack; 

public PlatformID Platform { get; }
public Version Version { get; }
public string ServicePack { get; }


public void .ctor(PlatformID platform, Version version) { }

private void .ctor(SerializationInfo information, StreamingContext context) { }

public PlatformID get_Platform() { }

public Version get_Version() { }

public string get_ServicePack() { }

public object Clone() { }

public void GetObjectData(SerializationInfo info, StreamingContext context) { }

public override string ToString() { }

}

