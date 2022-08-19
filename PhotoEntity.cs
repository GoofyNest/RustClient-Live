public class PhotoEntity : ImageStorageEntity, IUGCBrowserEntity // TypeDefIndex: 8815
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private ulong <PhotographerSteamId>k__BackingField; // 0x170
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private uint <ImageCrc>k__BackingField; // 0x178

	// Properties
	public ulong PhotographerSteamId { get; set; }
	public uint ImageCrc { get; set; }
	protected override uint CrcToLoad { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x8A99E0 Offset: 0x8A8DE0 VA: 0x1808A99E0
	public ulong get_PhotographerSteamId() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x8CB3A0 Offset: 0x8CA7A0 VA: 0x1808CB3A0
	private void set_PhotographerSteamId(ulong value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x8CB380 Offset: 0x8CA780 VA: 0x1808CB380
	public uint get_ImageCrc() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x8CB390 Offset: 0x8CA790 VA: 0x1808CB390
	private void set_ImageCrc(uint value) { }

	// RVA: 0x8CB380 Offset: 0x8CA780 VA: 0x1808CB380 Slot: 132
	protected override uint get_CrcToLoad() { }

	// RVA: 0x8CB300 Offset: 0x8CA700 VA: 0x1808CB300 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x8CB370 Offset: 0x8CA770 VA: 0x1808CB370
	public void .ctor() { }

}

