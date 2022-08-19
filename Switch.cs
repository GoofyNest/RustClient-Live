public abstract class Switch // TypeDefIndex: 2635
{	// Fields
	private readonly string description; // 0x10
	private readonly string displayName; // 0x18
	private string switchValueString; // 0x20
	private string defaultValue; // 0x28
	private static List<WeakReference> switches; // 0x0
	private static int s_LastCollectionCount; // 0x8

	// Methods

	// RVA: 0x172FCE0 Offset: 0x172F0E0 VA: 0x18172FCE0
	protected void .ctor(string displayName, string description) { }

	// RVA: 0x172FAD0 Offset: 0x172EED0 VA: 0x18172FAD0
	protected void .ctor(string displayName, string description, string defaultSwitchValue) { }

	// RVA: 0x172FD50 Offset: 0x172F150 VA: 0x18172FD50
	private static void _pruneCachedSwitches() { }

	// RVA: 0x172FA70 Offset: 0x172EE70 VA: 0x18172FA70
	private static void .cctor() { }

}

