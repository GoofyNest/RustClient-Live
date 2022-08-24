public class PhotoEntity : ImageStorageEntity, IUGCBrowserEntity // TypeDefIndex: 8815
{
	[CompilerGeneratedAttribute] 
	private ulong <PhotographerSteamId>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private uint <ImageCrc>k__BackingField; 

public ulong PhotographerSteamId { get; set; }
public uint ImageCrc { get; set; }
protected override uint CrcToLoad { get; }


	[CompilerGeneratedAttribute] 
public ulong get_PhotographerSteamId() { }

	[CompilerGeneratedAttribute] 
private void set_PhotographerSteamId(ulong value) { }

	[CompilerGeneratedAttribute] 
public uint get_ImageCrc() { }

	[CompilerGeneratedAttribute] 
private void set_ImageCrc(uint value) { }

protected override uint get_CrcToLoad() { }

public override void Load(BaseNetworkable.LoadInfo info) { }

public void .ctor() { }

}

