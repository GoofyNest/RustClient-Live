public class WorkshopItemEditor : SingletonComponent<WorkshopItemEditor> // TypeDefIndex: 7750
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
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

	// Properties
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

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710
	internal GameObject get_Prefab() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4D0180 Offset: 0x4CF580 VA: 0x1804D0180
	internal void set_Prefab(GameObject value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497E00 Offset: 0x497200 VA: 0x180497E00
	internal GameObject get_ViewModel() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497E30 Offset: 0x497230 VA: 0x180497E30
	internal void set_ViewModel(GameObject value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x7CE230 Offset: 0x7CD630 VA: 0x1807CE230
	internal Skinnable get_Skinnable() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x7CE240 Offset: 0x7CD640 VA: 0x1807CE240
	internal void set_Skinnable(Skinnable value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4A2EE0 Offset: 0x4A22E0 VA: 0x1804A2EE0
	internal Skin get_Skin() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4A2F10 Offset: 0x4A2310 VA: 0x1804A2F10
	internal void set_Skin(Skin value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x5DCC00 Offset: 0x5DC000 VA: 0x1805DCC00
	internal ulong get_ItemId() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xC107D0 Offset: 0xC0FBD0 VA: 0x180C107D0
	internal void set_ItemId(ulong value) { }

	// RVA: 0xE977B0 Offset: 0xE96BB0 VA: 0x180E977B0
	protected WorkshopInterface get_Interface() { }

	// RVA: 0xE95ED0 Offset: 0xE952D0 VA: 0x180E95ED0
	internal static void Loading(bool v1, string v2, string v3, float v4) { }

	// RVA: 0xE97810 Offset: 0xE96C10 VA: 0x180E97810
	internal Publisher get_Publisher() { }

	// RVA: 0xE97760 Offset: 0xE96B60 VA: 0x180E97760
	public FileDialog get_FileDialog() { }

	// RVA: 0xE977F0 Offset: 0xE96BF0 VA: 0x180E977F0
	public string get_ItemTitle() { }

	// RVA: 0xE978C0 Offset: 0xE96CC0 VA: 0x180E978C0
	public void set_ItemTitle(string value) { }

	// RVA: 0xE97700 Offset: 0xE96B00 VA: 0x180E97700
	public string get_ChangeLog() { }

	// RVA: 0xE97850 Offset: 0xE96C50 VA: 0x180E97850
	public void set_ChangeLog(string value) { }

	// RVA: 0xE96060 Offset: 0xE95460 VA: 0x180E96060
	private void OnEnable() { }

	// RVA: 0xE94EC0 Offset: 0xE942C0 VA: 0x180E94EC0
	private void ClearEditor() { }

	// RVA: 0xE96E80 Offset: 0xE96280 VA: 0x180E96E80
	public void StartNewItem(string type = "TShirt") { }

	[IteratorStateMachineAttribute] // RVA: 0xD2440 Offset: 0xD1840 VA: 0x1800D2440
	// RVA: 0xE96F20 Offset: 0xE96320 VA: 0x180E96F20
	public IEnumerator StartViewingItem(IWorkshopContent item) { }

	[IteratorStateMachineAttribute] // RVA: 0xD2500 Offset: 0xD1900 VA: 0x1800D2500
	// RVA: 0xE96DF0 Offset: 0xE961F0 VA: 0x180E96DF0
	public IEnumerator StartEditingItem(IWorkshopContent item) { }

	// RVA: 0xE951E0 Offset: 0xE945E0 VA: 0x180E951E0
	private void HideEditor() { }

	// RVA: 0xE96D90 Offset: 0xE96190 VA: 0x180E96D90
	private void ShowEditor() { }

	[IteratorStateMachineAttribute] // RVA: 0xD2760 Offset: 0xD1B60 VA: 0x1800D2760
	// RVA: 0xE96480 Offset: 0xE95880 VA: 0x180E96480
	internal IEnumerator OpenItem(IWorkshopContent item) { }

	// RVA: 0xE96360 Offset: 0xE95760 VA: 0x180E96360
	private void OnImportFinished() { }

	// RVA: 0xE96BB0 Offset: 0xE95FB0 VA: 0x180E96BB0
	internal Texture2D SetTexture(string paramName, string fullName, bool isNormalMap) { }

	// RVA: 0xE966E0 Offset: 0xE95AE0 VA: 0x180E966E0
	internal void SetFloat(string paramName, float value) { }

	// RVA: 0xE96680 Offset: 0xE95A80 VA: 0x180E96680
	internal void SetColor(string paramName, Color val) { }

	// RVA: 0xE96A80 Offset: 0xE95E80 VA: 0x180E96A80
	internal void SetTexture(string paramName, Texture tex) { }

	// RVA: 0xE95D60 Offset: 0xE95160 VA: 0x180E95D60
	private bool LoadItemType(IEnumerable<string> tags) { }

	// RVA: 0xE95AB0 Offset: 0xE94EB0 VA: 0x180E95AB0
	private bool LoadItemType(string v) { }

	// RVA: 0xE95890 Offset: 0xE94C90 VA: 0x180E95890
	private GameObject LoadForPreview(string entityPrefabName, bool preprocess = True) { }

	// RVA: 0xE95F50 Offset: 0xE95350 VA: 0x180E95F50
	public void OnChangedItemType(int type) { }

	// RVA: 0xE96FF0 Offset: 0xE963F0 VA: 0x180E96FF0
	private void UpdateMaterialRows() { }

	// RVA: 0xE973A0 Offset: 0xE967A0 VA: 0x180E973A0
	private void UpdateMaterialTabs() { }

	// RVA: 0xE953B0 Offset: 0xE947B0 VA: 0x180E953B0
	private void InitScene() { }

	// RVA: 0xE95240 Offset: 0xE94640 VA: 0x180E95240
	private void InitPlayerPreview(ulong playerid, bool focus) { }

	// RVA: 0xE96510 Offset: 0xE95910 VA: 0x180E96510
	public void RandomizePlayerPreview() { }

	// RVA: 0xE95170 Offset: 0xE94570 VA: 0x180E95170
	public void DownloadModel() { }

	// RVA: 0xE95740 Offset: 0xE94B40 VA: 0x180E95740
	public static bool IsLesserLOD(string name) { }

	// RVA: 0xE96540 Offset: 0xE95940 VA: 0x180E96540
	public static void RemoveLODs(GameObject prefab) { }

	// RVA: -1 Offset: -1
	private static void RemoveComponents<T>(GameObject prefab) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCFA6C0 Offset: 0xCF9AC0 VA: 0x180CFA6C0
	|-WorkshopItemEditor.RemoveComponents<object>
	|-WorkshopItemEditor.RemoveComponents<Rigidbody>
	*/

	[IteratorStateMachineAttribute] // RVA: 0xD3BA0 Offset: 0xD2FA0 VA: 0x1800D3BA0
	// RVA: 0xE95100 Offset: 0xE94500 VA: 0x180E95100
	private IEnumerator DoDownloadModel() { }

	// RVA: 0xE975E0 Offset: 0xE969E0 VA: 0x180E975E0
	private void Update() { }

	// RVA: 0xE95860 Offset: 0xE94C60 VA: 0x180E95860
	private void LateUpdate() { }

	// RVA: 0xE96FB0 Offset: 0xE963B0 VA: 0x180E96FB0
	public void SwitchMaterial(int i) { }

	// RVA: 0xE976A0 Offset: 0xE96AA0 VA: 0x180E976A0
	public void .ctor() { }

	// RVA: 0xE97630 Offset: 0xE96A30 VA: 0x180E97630
	private static void .cctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xE96FC0 Offset: 0xE963C0 VA: 0x180E96FC0
	private bool <LoadItemType>b__61_0(Dropdown.OptionData x) { }

}

private sealed class WorkshopItemEditor.<>c // TypeDefIndex: 7751
{	// Fields
	public static readonly WorkshopItemEditor.<>c <>9; // 0x0
	public static Func<Skinnable, bool> <>9__47_0; // 0x8
	public static Func<Skinnable, string> <>9__47_1; // 0x10
	public static Func<string, string> <>9__47_2; // 0x18

	// Methods

	// RVA: 0xE94240 Offset: 0xE93640 VA: 0x180E94240
	private static void .cctor() { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0xE93FD0 Offset: 0xE933D0 VA: 0x180E93FD0
	internal bool <OnEnable>b__47_0(Skinnable x) { }

	// RVA: 0x936440 Offset: 0x935840 VA: 0x180936440
	internal string <OnEnable>b__47_1(Skinnable x) { }

	// RVA: 0x7B2BE0 Offset: 0x7B1FE0 VA: 0x1807B2BE0
	internal string <OnEnable>b__47_2(string x) { }

}

private sealed class WorkshopItemEditor.<StartViewingItem>d__50 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 7752
{	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public WorkshopItemEditor <>4__this; // 0x20
	public IWorkshopContent item; // 0x28

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

	// RVA: 0xE93E70 Offset: 0xE93270 VA: 0x180E93E70 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xE93F80 Offset: 0xE93380 VA: 0x180E93F80 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

}

private sealed class WorkshopItemEditor.<StartEditingItem>d__51 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 7753
{	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public WorkshopItemEditor <>4__this; // 0x20
	public IWorkshopContent item; // 0x28

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

	// RVA: 0xE93D10 Offset: 0xE93110 VA: 0x180E93D10 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xE93E20 Offset: 0xE93220 VA: 0x180E93E20 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

}

private sealed class WorkshopItemEditor.<OpenItem>d__54 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 7754
{	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public WorkshopItemEditor <>4__this; // 0x20
	public IWorkshopContent item; // 0x28
	private Task<IPlayerInfo> <t>5__2; // 0x30

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

	// RVA: 0xE917F0 Offset: 0xE90BF0 VA: 0x180E917F0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xE91E60 Offset: 0xE91260 VA: 0x180E91E60 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

}

private sealed class WorkshopItemEditor.<DoDownloadModel>d__74 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 7755
{	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public WorkshopItemEditor <>4__this; // 0x20

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

	// RVA: 0xE8A630 Offset: 0xE89A30 VA: 0x180E8A630 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xE8AA00 Offset: 0xE89E00 VA: 0x180E8AA00 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

}

