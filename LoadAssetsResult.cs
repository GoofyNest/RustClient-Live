public abstract class LoadAssetsResult : CustomYieldInstruction // TypeDefIndex: 6661
{	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private int <CompletedCount>k__BackingField; // 0x10
	public LoadAssetsResult.AssetLoaded OnAssetLoaded; // 0x18

	public abstract int TotalCount { get; }
	public virtual int CompletedCount { get; set; }


	public abstract int get_TotalCount();

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public virtual int get_CompletedCount() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	protected virtual void set_CompletedCount(int value) { }

	public abstract Dictionary<string, Object> GetResult();

	protected void .ctor() { }

}

public sealed class LoadAssetsResult.AssetLoaded : MulticastDelegate // TypeDefIndex: 6662
{
	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke(string path, Object obj) { }

	public virtual IAsyncResult BeginInvoke(string path, Object obj, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(IAsyncResult result) { }

}

