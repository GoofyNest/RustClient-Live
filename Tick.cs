public static class Tick // TypeDefIndex: 6615
{
	private static Tick.Entry.List Timed;
	private static Tick.Entry.List Update;
	private static Tick.Entry.List Late;
	private static List<Object> RemoveList;


	public static void AddTimed(Object obj, float minDelay, float maxDelay, Action action, string DebugName) { }

	public static void Add(Object obj, Action action, string DebugName) { }

	public static void AddLateUpdate(Object obj, Action action, string DebugName) { }

	public static void RemoveAll(Object obj) { }

	private static void Cleanup() { }

	internal static void OnFrame() { }

	internal static void OnFrameLate() { }

	private static void .cctor() { }

}

public struct Tick.Entry // TypeDefIndex: 6616
{
	public Object TargetObject;
	public float MinDelay;
	public float RandDelay;
	public float NextCall;
	public Action Function;
	private bool Errored;
	public string DebugName;

}

public class Tick.Entry.List : List<Tick.Entry> // TypeDefIndex: 6617
{

	public void Remove(Object obj) { }

	internal void Tick() { }

	internal void TickTimed() { }

	public void .ctor() { }

}

