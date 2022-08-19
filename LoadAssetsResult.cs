public abstract class LoadAssetsResult : CustomYieldInstruction // TypeDefIndex: 6661
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private int <CompletedCount>k__BackingField; // 0x10
	public LoadAssetsResult.AssetLoaded OnAssetLoaded; // 0x18

	// Properties
	public abstract int TotalCount { get; }
	public virtual int CompletedCount { get; set; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 8
	public abstract int get_TotalCount();

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x36A480 Offset: 0x369880 VA: 0x18036A480 Slot: 9
	public virtual int get_CompletedCount() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x596240 Offset: 0x595640 VA: 0x180596240 Slot: 10
	protected virtual void set_CompletedCount(int value) { }

	// RVA: -1 Offset: -1 Slot: 11
	public abstract Dictionary<string, Object> GetResult();

	// RVA: 0x7992B0 Offset: 0x7986B0 VA: 0x1807992B0
	protected void .ctor() { }

}

public sealed class LoadAssetsResult.AssetLoaded : MulticastDelegate // TypeDefIndex: 6662
{	// Methods

	// RVA: 0x4971F0 Offset: 0x4965F0 VA: 0x1804971F0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xADFD50 Offset: 0xADF150 VA: 0x180ADFD50 Slot: 12
	public virtual void Invoke(string path, Object obj) { }

	// RVA: 0xADFD10 Offset: 0xADF110 VA: 0x180ADFD10 Slot: 13
	public virtual IAsyncResult BeginInvoke(string path, Object obj, AsyncCallback callback, object object) { }

	// RVA: 0x497050 Offset: 0x496450 VA: 0x180497050 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

