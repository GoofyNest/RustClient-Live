public abstract class LoadAssetsResult : CustomYieldInstruction // TypeDefIndex: 6673
{
	[CompilerGeneratedAttribute]
	private int <CompletedCount>k__BackingField;
	public LoadAssetsResult.AssetLoaded OnAssetLoaded;

	public abstract int TotalCount { get; }
	public virtual int CompletedCount { get; set; }


	public abstract int get_TotalCount();

	[CompilerGeneratedAttribute]
	public virtual int get_CompletedCount() { }

	[CompilerGeneratedAttribute]
	protected virtual void set_CompletedCount(int value) { }

	public abstract Dictionary<string, Object> GetResult();

	protected void .ctor() { }

}

public sealed class LoadAssetsResult.AssetLoaded : MulticastDelegate // TypeDefIndex: 6674
{

	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke(string path, Object obj) { }

	public virtual IAsyncResult BeginInvoke(string path, Object obj, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(IAsyncResult result) { }

}

