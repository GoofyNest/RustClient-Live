public class IconSkinPicker : MonoBehaviour // TypeDefIndex: 9192
{	private static IconSkinPicker.SkinHistory loadedHistory; // 0x0
	private const string PrefsKey = "SkinHistory";
	public GameObjectRef pickerIcon; // 0x18
	public GameObject container; // 0x20
	public Action skinChangedEvent; // 0x28
	public ScrollRect scroller; // 0x30
	public SearchFilterInput searchFilter; // 0x38
	private ItemBlueprint lastBlueprintRefresh; // 0x40
	private List<IconSkin> spawnedSkinIcons; // 0x48


	public static bool HasRecentlyUsed(int skinId, out TimeSpan timeSince) { }

	public static void RegisterAsRecentlyUsedSkin(int skinId) { }

	private static void LoadSkinHistory() { }

	private static void SaveSkinHistory() { }

	private void OnEnable() { }

	private void OnSearchFilterChanged(string filter) { }

	private void OnDisable() { }

	internal void ForceNextRefresh() { }

	internal bool Refresh(ItemBlueprint blueprint) { }

	private void ResetScroller() { }

	private int CompareSkinOption(IconSkinPicker.SkinButtonSetup a, IconSkinPicker.SkinButtonSetup b) { }

	private void AddOption(ItemDefinition item, int skinid, string text, bool canUse) { }

	public virtual void OnSkinChanged(int skinId) { }

	public void .ctor() { }

	private static void .cctor() { }

}

private class IconSkinPicker.SkinHistory // TypeDefIndex: 9193
{	public Dictionary<int, long> lastUsedSkins; // 0x10


	public void .ctor() { }

}

private struct IconSkinPicker.SkinButtonSetup // TypeDefIndex: 9194
{	public ItemDefinition item; // 0x0
	public int skinid; // 0x8
	public string text; // 0x10
	public bool canUse; // 0x18

}

