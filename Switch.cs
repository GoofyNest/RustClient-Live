public abstract class Switch // TypeDefIndex: 2635
{
	private readonly string description; 
	private readonly string displayName; 
	private string switchValueString; 
	private string defaultValue; 
	private static List<WeakReference> switches; 
	private static int s_LastCollectionCount; 


	protected void .ctor(string displayName, string description) { }

	protected void .ctor(string displayName, string description, string defaultSwitchValue) { }

	private static void _pruneCachedSwitches() { }

	private static void .cctor() { }

}

