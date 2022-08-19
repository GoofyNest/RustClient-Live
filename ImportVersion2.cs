internal class ImportVersion2 : SingletonComponent<ImportVersion2> // TypeDefIndex: 7772
{	// Fields
	private AssetBundle Bundle; // 0x18

	// Methods

	// RVA: 0xE875C0 Offset: 0xE869C0 VA: 0x180E875C0
	public void OnDisable() { }

	[IteratorStateMachineAttribute] // RVA: 0xD9390 Offset: 0xD8790 VA: 0x1800D9390
	// RVA: 0xE87280 Offset: 0xE86680 VA: 0x180E87280
	internal IEnumerator DoImport(IWorkshopContent item, Skin skin) { }

	[IteratorStateMachineAttribute] // RVA: 0xD9560 Offset: 0xD8960 VA: 0x1800D9560
	// RVA: 0xE87500 Offset: 0xE86900 VA: 0x180E87500
	public IEnumerator LoadItem(string Folder, string BundleName, Skin skin) { }

	[IteratorStateMachineAttribute] // RVA: 0xD9680 Offset: 0xD8A80 VA: 0x1800D9680
	// RVA: 0xE876C0 Offset: 0xE86AC0 VA: 0x180E876C0
	private IEnumerator ProcessMaterial(int v, Material inputMaterial, Skin skin) { }

	// RVA: 0xE87320 Offset: 0xE86720 VA: 0x180E87320
	private Texture2D ImportTexture(string name, Material inputMaterial, Material outputMaterial, bool normal, Skin skin, int group, string targetName) { }

	// RVA: 0xE870A0 Offset: 0xE864A0 VA: 0x180E870A0
	private Texture2D ConvertMetalToSpec(Texture2D tex, Material outputMaterial) { }

	// RVA: 0xE87770 Offset: 0xE86B70 VA: 0x180E87770
	public void .ctor() { }

}

private sealed class ImportVersion2.<DoImport>d__2 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 7773
{	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public ImportVersion2 <>4__this; // 0x20
	public IWorkshopContent item; // 0x28
	public Skin skin; // 0x30

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497770 Offset: 0x496B70 VA: 0x180497770
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0xE8BC10 Offset: 0xE8B010 VA: 0x180E8BC10 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xE8BFC0 Offset: 0xE8B3C0 VA: 0x180E8BFC0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

}

private sealed class ImportVersion2.<>c__DisplayClass3_0 // TypeDefIndex: 7774
{	// Fields
	public AssetBundleCreateRequest request; // 0x10

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0xE94190 Offset: 0xE93590 VA: 0x180E94190
	internal bool <LoadItem>b__0() { }

}

private sealed class ImportVersion2.<LoadItem>d__3 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 7775
{	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public string BundleName; // 0x20
	private ImportVersion2.<>c__DisplayClass3_0 <>8__1; // 0x28
	public ImportVersion2 <>4__this; // 0x30
	public string Folder; // 0x38
	public Skin skin; // 0x40
	private WorkshopSkinBase <asset>5__2; // 0x48

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497770 Offset: 0x496B70 VA: 0x180497770
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0xE90CC0 Offset: 0xE900C0 VA: 0x180E90CC0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xE91260 Offset: 0xE90660 VA: 0x180E91260 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

}

private sealed class ImportVersion2.<ProcessMaterial>d__4 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 7776
{	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public Material inputMaterial; // 0x20
	public Skin skin; // 0x28
	public int v; // 0x30
	public ImportVersion2 <>4__this; // 0x38

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497770 Offset: 0x496B70 VA: 0x180497770
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0xE91EB0 Offset: 0xE912B0 VA: 0x180E91EB0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xE92430 Offset: 0xE91830 VA: 0x180E92430 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

}

