public class QuickCraft : SingletonComponent<QuickCraft>, IInventoryChanged // TypeDefIndex: 11044
{	// Fields
	public GameObjectRef craftButton; // 0x18
	public GameObject empty; // 0x20
	public Sprite FavouriteOnSprite; // 0x28
	public Sprite FavouriteOffSprite; // 0x30
	public Color FavouriteOnColor; // 0x38
	public Color FavouriteOffColor; // 0x48
	public static HashSet<ItemBlueprint> FavouriteBlueprints; // 0x0
	private float lastRebuildTime; // 0x58
	private bool forceRebuild; // 0x5C
	private bool isDirty; // 0x5D
	private int lastHash; // 0x60
	private const int buttonCount = 18;

	// Methods

	// RVA: 0x69B7B0 Offset: 0x69ABB0 VA: 0x18069B7B0 Slot: 6
	protected override void Awake() { }

	// RVA: 0x69B8F0 Offset: 0x69ACF0 VA: 0x18069B8F0
	private void LoadFavourites() { }

	// RVA: 0x69BBB0 Offset: 0x69AFB0 VA: 0x18069BBB0
	private void OnEnable() { }

	// RVA: 0x69BB00 Offset: 0x69AF00 VA: 0x18069BB00
	private void OnDisable() { }

	// RVA: 0x69B7F0 Offset: 0x69ABF0 VA: 0x18069B7F0 Slot: 8
	public void OnInventoryChanged() { }

	// RVA: 0x69B7F0 Offset: 0x69ABF0 VA: 0x18069B7F0
	private void Dirty() { }

	[IteratorStateMachineAttribute] // RVA: 0x90AC0 Offset: 0x8FEC0 VA: 0x180090AC0
	// RVA: 0x69C8F0 Offset: 0x69BCF0 VA: 0x18069C8F0
	private IEnumerator WatchForChanges() { }

	// RVA: 0x69BC90 Offset: 0x69B090 VA: 0x18069BC90
	private void Rebuild() { }

	// RVA: 0x69C2D0 Offset: 0x69B6D0 VA: 0x18069C2D0
	public bool RecentlyRebuilt() { }

	// RVA: 0x69B800 Offset: 0x69AC00 VA: 0x18069B800
	public void ForceRebuild() { }

	// RVA: 0x69C6E0 Offset: 0x69BAE0 VA: 0x18069C6E0
	public void ToggleFavourite(ItemBlueprint bp) { }

	// RVA: 0x69B870 Offset: 0x69AC70 VA: 0x18069B870
	public static bool IsBluePrintFavourited(ItemBlueprint bp) { }

	// RVA: 0x69B6B0 Offset: 0x69AAB0 VA: 0x18069B6B0
	public static void AddFavouriteBlueprint(ItemBlueprint bp) { }

	// RVA: 0x69C3A0 Offset: 0x69B7A0 VA: 0x18069C3A0
	public static void RemoveFavouriteBlueprint(ItemBlueprint bp) { }

	// RVA: 0x69B810 Offset: 0x69AC10 VA: 0x18069B810
	private static string GetSaveString(ItemBlueprint bp) { }

	// RVA: 0x69C5A0 Offset: 0x69B9A0 VA: 0x18069C5A0
	public void SetFavouriteIconState(bool favourited, Image image) { }

	// RVA: 0x69C470 Offset: 0x69B870 VA: 0x18069C470
	public void SetFavouriteIconHoveredState(bool favourited, Image image) { }

	// RVA: 0x69C5E0 Offset: 0x69B9E0 VA: 0x18069C5E0
	public void SetFavouriteIconUnhoveredState(bool favourited, Image image) { }

	// RVA: 0x69C9C0 Offset: 0x69BDC0 VA: 0x18069C9C0
	public void .ctor() { }

	// RVA: 0x69C960 Offset: 0x69BD60 VA: 0x18069C960
	private static void .cctor() { }

}

private sealed class QuickCraft.<WatchForChanges>d__16 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 11045
{	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public QuickCraft <>4__this; // 0x20

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

	// RVA: 0x6AC970 Offset: 0x6ABD70 VA: 0x1806AC970 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x6ACB30 Offset: 0x6ABF30 VA: 0x1806ACB30 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

}

