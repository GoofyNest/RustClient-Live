public class IconSkinPicker : MonoBehaviour // TypeDefIndex: 9192
{	// Fields
	private static IconSkinPicker.SkinHistory loadedHistory; // 0x0
	private const string PrefsKey = "SkinHistory";
	public GameObjectRef pickerIcon; // 0x18
	public GameObject container; // 0x20
	public Action skinChangedEvent; // 0x28
	public ScrollRect scroller; // 0x30
	public SearchFilterInput searchFilter; // 0x38
	private ItemBlueprint lastBlueprintRefresh; // 0x40
	private List<IconSkin> spawnedSkinIcons; // 0x48

	// Methods

	// RVA: 0x807150 Offset: 0x806550 VA: 0x180807150
	public static bool HasRecentlyUsed(int skinId, out TimeSpan timeSince) { }

	// RVA: 0x808720 Offset: 0x807B20 VA: 0x180808720
	public static void RegisterAsRecentlyUsedSkin(int skinId) { }

	// RVA: 0x8072A0 Offset: 0x8066A0 VA: 0x1808072A0
	private static void LoadSkinHistory() { }

	// RVA: 0x808AB0 Offset: 0x807EB0 VA: 0x180808AB0
	private static void SaveSkinHistory() { }

	// RVA: 0x807600 Offset: 0x806A00 VA: 0x180807600
	private void OnEnable() { }

	// RVA: 0x807720 Offset: 0x806B20 VA: 0x180807720
	private void OnSearchFilterChanged(string filter) { }

	// RVA: 0x8074F0 Offset: 0x8068F0 VA: 0x1808074F0
	private void OnDisable() { }

	// RVA: 0x807130 Offset: 0x806530 VA: 0x180807130
	internal void ForceNextRefresh() { }

	// RVA: 0x807AC0 Offset: 0x806EC0 VA: 0x180807AC0
	internal bool Refresh(ItemBlueprint blueprint) { }

	// RVA: 0x808980 Offset: 0x807D80 VA: 0x180808980
	private void ResetScroller() { }

	// RVA: 0x806FF0 Offset: 0x8063F0 VA: 0x180806FF0
	private int CompareSkinOption(IconSkinPicker.SkinButtonSetup a, IconSkinPicker.SkinButtonSetup b) { }

	// RVA: 0x806CC0 Offset: 0x8060C0 VA: 0x180806CC0
	private void AddOption(ItemDefinition item, int skinid, string text, bool canUse) { }

	// RVA: 0x8079A0 Offset: 0x806DA0 VA: 0x1808079A0 Slot: 4
	public virtual void OnSkinChanged(int skinId) { }

	// RVA: 0x808B80 Offset: 0x807F80 VA: 0x180808B80
	public void .ctor() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0
	private static void .cctor() { }

}

private class IconSkinPicker.SkinHistory // TypeDefIndex: 9193
{	// Fields
	public Dictionary<int, long> lastUsedSkins; // 0x10

	// Methods

	// RVA: 0x81DF50 Offset: 0x81D350 VA: 0x18081DF50
	public void .ctor() { }

}

private struct IconSkinPicker.SkinButtonSetup // TypeDefIndex: 9194
{	// Fields
	public ItemDefinition item; // 0x0
	public int skinid; // 0x8
	public string text; // 0x10
	public bool canUse; // 0x18

}

