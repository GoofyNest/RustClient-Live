internal class ImportVersion2 : SingletonComponent<ImportVersion2> // TypeDefIndex: 7788
{
	private AssetBundle Bundle;


	public void OnDisable() { }

	[IteratorStateMachineAttribute]
	internal IEnumerator DoImport(IWorkshopContent item, Skin skin) { }

	[IteratorStateMachineAttribute]
	public IEnumerator LoadItem(string Folder, string BundleName, Skin skin) { }

	[IteratorStateMachineAttribute]
	private IEnumerator ProcessMaterial(int v, Material inputMaterial, Skin skin) { }

	private Texture2D ImportTexture(string name, Material inputMaterial, Material outputMaterial, bool normal, Skin skin, int group, string targetName) { }

	private Texture2D ConvertMetalToSpec(Texture2D tex, Material outputMaterial) { }

	public void .ctor() { }

}

private sealed class ImportVersion2.<DoImport>d__2 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 7789
{
	private int <>1__state;
	private object <>2__current;
	public ImportVersion2 <>4__this;
	public IWorkshopContent item;
	public Skin skin;

	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }


	[DebuggerHiddenAttribute]
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute]
	private void System.IDisposable.Dispose() { }

	private bool MoveNext() { }

	[DebuggerHiddenAttribute]
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute]
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute]
	private object System.Collections.IEnumerator.get_Current() { }

}

private sealed class ImportVersion2.<>c__DisplayClass3_0 // TypeDefIndex: 7790
{
	public AssetBundleCreateRequest request;


	public void .ctor() { }

	internal bool <LoadItem>

}

private sealed class ImportVersion2.<LoadItem>d__3 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 7791
{
	private int <>1__state;
	private object <>2__current;
	public string BundleName;
	private ImportVersion2.<>c
	public ImportVersion2 <>4__this;
	public string Folder;
	public Skin skin;
	private WorkshopSkinBase <asset>5__2;

	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }


	[DebuggerHiddenAttribute]
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute]
	private void System.IDisposable.Dispose() { }

	private bool MoveNext() { }

	[DebuggerHiddenAttribute]
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute]
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute]
	private object System.Collections.IEnumerator.get_Current() { }

}

private sealed class ImportVersion2.<ProcessMaterial>d__4 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 7792
{
	private int <>1__state;
	private object <>2__current;
	public Material inputMaterial;
	public Skin skin;
	public int v;
	public ImportVersion2 <>4__this;

	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }


	[DebuggerHiddenAttribute]
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute]
	private void System.IDisposable.Dispose() { }

	private bool MoveNext() { }

	[DebuggerHiddenAttribute]
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute]
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute]
	private object System.Collections.IEnumerator.get_Current() { }

}

