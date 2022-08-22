public abstract class Switch // TypeDefIndex: 2635
{	private readonly string description; // 0x10
	private readonly string displayName; // 0x18
	private string switchValueString; // 0x20
	private string defaultValue; // 0x28
	private static List<WeakReference> switches; // 0x0
	private static int s_LastCollectionCount; // 0x8


	protected void .ctor(string displayName, string description) { }

	protected void .ctor(string displayName, string description, string defaultSwitchValue) { }

	private static void _pruneCachedSwitches() { }

	private static void .cctor() { }

}

