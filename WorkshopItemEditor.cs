public class WorkshopItemEditor : SingletonComponent<WorkshopItemEditor> // TypeDefIndex: 7766
{
	[CompilerGeneratedAttribute]
	private GameObject <Prefab>k__BackingField;
	[CompilerGeneratedAttribute]
	private GameObject <ViewModel>k__BackingField;
	[CompilerGeneratedAttribute]
	private Skinnable <Skinnable>k__BackingField;
	[CompilerGeneratedAttribute]
	private Skin <Skin>k__BackingField;
	[CompilerGeneratedAttribute]
	private ulong <ItemId>k__BackingField;
	public static Action<bool, string> OnLoading;
	public Dropdown ItemTypeSelector;
	public InputField ItemTitleLabel;
	public WorkshopViewmodelControls ViewmodelControls;
	public GameObject MaterialTabHolder;
	public GameObject FileDialogObject;
	public GameObject[] EditorElements;
	public GameObject[] ClothOnlyElements;
	public GameObject[] DetailOnlyElements;
	public GameObject[] DirtOnlyElements;
	public Toggle[] MaterialTabs;
	public int EditingMaterial;
	public GameObject item_position_a;
	public GameObject item_position_b;
	private static readonly Regex ModelCleanup;

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


	[CompilerGeneratedAttribute]
	internal GameObject get_Prefab() { }

	[CompilerGeneratedAttribute]
	internal void set_Prefab(GameObject value) { }

	[CompilerGeneratedAttribute]
	internal GameObject get_ViewModel() { }

	[CompilerGeneratedAttribute]
	internal void set_ViewModel(GameObject value) { }

	[CompilerGeneratedAttribute]
	internal Skinnable get_Skinnable() { }

	[CompilerGeneratedAttribute]
	internal void set_Skinnable(Skinnable value) { }

	[CompilerGeneratedAttribute]
	internal Skin get_Skin() { }

	[CompilerGeneratedAttribute]
	internal void set_Skin(Skin value) { }

	[CompilerGeneratedAttribute]
	internal ulong get_ItemId() { }

	[CompilerGeneratedAttribute]
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

	[IteratorStateMachineAttribute]
	public IEnumerator StartViewingItem(IWorkshopContent item) { }

	[IteratorStateMachineAttribute]
	public IEnumerator StartEditingItem(IWorkshopContent item) { }

	private void HideEditor() { }

	private void ShowEditor() { }

	[IteratorStateMachineAttribute]
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

	[IteratorStateMachineAttribute]
	private IEnumerator DoDownloadModel() { }

	private void Update() { }

	private void LateUpdate() { }

	public void SwitchMaterial(int i) { }

	public void .ctor() { }

	private static void .cctor() { }

	[CompilerGeneratedAttribute]
	private bool <LoadItemType>

}

private sealed class WorkshopItemEditor.<>c // TypeDefIndex: 7767
{
	public static readonly WorkshopItemEditor.<>c <>9;
	public static Func<Skinnable, bool> <>9__47_0;
	public static Func<Skinnable, string> <>9__47_1;
	public static Func<string, string> <>9__47_2;


	private static void .cctor() { }

	public void .ctor() { }

	internal bool <OnEnable>

	internal string <OnEnable>

	internal string <OnEnable>

}

private sealed class WorkshopItemEditor.<StartViewingItem>d__50 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 7768
{
	private int <>1__state;
	private object <>2__current;
	public WorkshopItemEditor <>4__this;
	public IWorkshopContent item;

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

private sealed class WorkshopItemEditor.<StartEditingItem>d__51 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 7769
{
	private int <>1__state;
	private object <>2__current;
	public WorkshopItemEditor <>4__this;
	public IWorkshopContent item;

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

private sealed class WorkshopItemEditor.<OpenItem>d__54 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 7770
{
	private int <>1__state;
	private object <>2__current;
	public WorkshopItemEditor <>4__this;
	public IWorkshopContent item;
	private Task<IPlayerInfo> <t>5__2;

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

private sealed class WorkshopItemEditor.<DoDownloadModel>d__74 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 7771
{
	private int <>1__state;
	private object <>2__current;
	public WorkshopItemEditor <>4__this;

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

