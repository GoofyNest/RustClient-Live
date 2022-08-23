public class WorkshopItemEditor : SingletonComponent<WorkshopItemEditor> // TypeDefIndex: 7750
{	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private GameObject <Prefab>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private GameObject <ViewModel>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Skinnable <Skinnable>k__BackingField; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Skin <Skin>k__BackingField; // 0x30
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private ulong <ItemId>k__BackingField; // 0x38
	public static Action<bool, string> OnLoading; // 0x0
	public Dropdown ItemTypeSelector; // 0x40
	public InputField ItemTitleLabel; // 0x48
	public WorkshopViewmodelControls ViewmodelControls; // 0x50
	public GameObject MaterialTabHolder; // 0x58
	public GameObject FileDialogObject; // 0x60
	public GameObject[] EditorElements; // 0x68
	public GameObject[] ClothOnlyElements; // 0x70
	public GameObject[] DetailOnlyElements; // 0x78
	public GameObject[] DirtOnlyElements; // 0x80
	public Toggle[] MaterialTabs; // 0x88
	public int EditingMaterial; // 0x90
	public GameObject item_position_a; // 0x98
	public GameObject item_position_b; // 0xA0
	private static readonly Regex ModelCleanup; // 0x8

	internal GameObject Prefab { get; set; }
	internal GameObject ViewModel { get; set; }
	internal Skinnable Skinnable { get; set; }
	internal Skin Skin { get; set; }
	internal ulong ItemId { get; set; }
	protected WorkshopInterface Interface { get; }
	internal Publisher Publisher { get; }
	public FileDialog FileDialog { get; }
	public string ItemTitle { get; set; }
	public string ChangeLog { get; set; }


	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	internal GameObject get_Prefab() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	internal void set_Prefab(GameObject value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	internal GameObject get_ViewModel() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	internal void set_ViewModel(GameObject value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	internal Skinnable get_Skinnable() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	internal void set_Skinnable(Skinnable value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	internal Skin get_Skin() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	internal void set_Skin(Skin value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	internal ulong get_ItemId() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	internal void set_ItemId(ulong value) { }

	protected WorkshopInterface get_Interface() { }

	internal static void Loading(bool v1, string v2, string v3, float v4) { }

	internal Publisher get_Publisher() { }

	public FileDialog get_FileDialog() { }

	public string get_ItemTitle() { }

	public void set_ItemTitle(string value) { }

	public string get_ChangeLog() { }

	public void set_ChangeLog(string value) { }

	private void OnEnable() { }

	private void ClearEditor() { }

	public void StartNewItem(string type = "TShirt") { }

	[IteratorStateMachineAttribute] // RVA: 0xD2440 Offset: 0xD1840 VA: 0x1800D2440
	public IEnumerator StartViewingItem(IWorkshopContent item) { }

	[IteratorStateMachineAttribute] // RVA: 0xD2500 Offset: 0xD1900 VA: 0x1800D2500
	public IEnumerator StartEditingItem(IWorkshopContent item) { }

	private void HideEditor() { }

	private void ShowEditor() { }

	[IteratorStateMachineAttribute] // RVA: 0xD2760 Offset: 0xD1B60 VA: 0x1800D2760
	internal IEnumerator OpenItem(IWorkshopContent item) { }

	private void OnImportFinished() { }

	internal Texture2D SetTexture(string paramName, string fullName, bool isNormalMap) { }

	internal void SetFloat(string paramName, float value) { }

	internal void SetColor(string paramName, Color val) { }

	internal void SetTexture(string paramName, Texture tex) { }

	private bool LoadItemType(IEnumerable<string> tags) { }

	private bool LoadItemType(string v) { }

	private GameObject LoadForPreview(string entityPrefabName, bool preprocess = True) { }

	public void OnChangedItemType(int type) { }

	private void UpdateMaterialRows() { }

	private void UpdateMaterialTabs() { }

	private void InitScene() { }

	private void InitPlayerPreview(ulong playerid, bool focus) { }

	public void RandomizePlayerPreview() { }

	public void DownloadModel() { }

	public static bool IsLesserLOD(string name) { }

	public static void RemoveLODs(GameObject prefab) { }

	private static void RemoveComponents<T>(GameObject prefab) { }
	/* GenericInstMethod :
	|
	|-WorkshopItemEditor.RemoveComponents<object>
	|-WorkshopItemEditor.RemoveComponents<Rigidbody>
	*/

	[IteratorStateMachineAttribute] // RVA: 0xD3BA0 Offset: 0xD2FA0 VA: 0x1800D3BA0
	private IEnumerator DoDownloadModel() { }

	private void Update() { }

	private void LateUpdate() { }

	public void SwitchMaterial(int i) { }

	public void .ctor() { }

	private static void .cctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private bool <LoadItemType>b__61_0(Dropdown.OptionData x) { }

}

private sealed class WorkshopItemEditor.<>c // TypeDefIndex: 7751
{	public static readonly WorkshopItemEditor.<>c <>9; // 0x0
	public static Func<Skinnable, bool> <>9__47_0; // 0x8
	public static Func<Skinnable, string> <>9__47_1; // 0x10
	public static Func<string, string> <>9__47_2; // 0x18


	private static void .cctor() { }

	public void .ctor() { }

	internal bool <OnEnable>b__47_0(Skinnable x) { }

	internal string <OnEnable>b__47_1(Skinnable x) { }

	internal string <OnEnable>b__47_2(string x) { }

}

private sealed class WorkshopItemEditor.<StartViewingItem>d__50 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 7752
{	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public WorkshopItemEditor <>4__this; // 0x20
	public IWorkshopContent item; // 0x28

	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }


	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void System.IDisposable.Dispose() { }

	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private object System.Collections.IEnumerator.get_Current() { }

}

private sealed class WorkshopItemEditor.<StartEditingItem>d__51 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 7753
{	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public WorkshopItemEditor <>4__this; // 0x20
	public IWorkshopContent item; // 0x28

	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }


	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void System.IDisposable.Dispose() { }

	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private object System.Collections.IEnumerator.get_Current() { }

}

private sealed class WorkshopItemEditor.<OpenItem>d__54 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 7754
{	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public WorkshopItemEditor <>4__this; // 0x20
	public IWorkshopContent item; // 0x28
	private Task<IPlayerInfo> <t>5__2; // 0x30

	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }


	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void System.IDisposable.Dispose() { }

	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private object System.Collections.IEnumerator.get_Current() { }

}

private sealed class WorkshopItemEditor.<DoDownloadModel>d__74 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 7755
{	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public WorkshopItemEditor <>4__this; // 0x20

	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }


	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void System.IDisposable.Dispose() { }

	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private object System.Collections.IEnumerator.get_Current() { }

}

