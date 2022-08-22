public static class Tick // TypeDefIndex: 6603
{	private static Tick.Entry.List Timed; // 0x0
	private static Tick.Entry.List Update; // 0x8
	private static Tick.Entry.List Late; // 0x10
	private static List<Object> RemoveList; // 0x18


	public static void AddTimed(Object obj, float minDelay, float maxDelay, Action action, string DebugName) { }

	public static void Add(Object obj, Action action, string DebugName) { }

	public static void AddLateUpdate(Object obj, Action action, string DebugName) { }

	public static void RemoveAll(Object obj) { }

	private static void Cleanup() { }

	internal static void OnFrame() { }

	internal static void OnFrameLate() { }

	private static void .cctor() { }

}

public struct Tick.Entry // TypeDefIndex: 6604
{	public Object TargetObject; // 0x0
	public float MinDelay; // 0x8
	public float RandDelay; // 0xC
	public float NextCall; // 0x10
	public Action Function; // 0x18
	private bool Errored; // 0x20
	public string DebugName; // 0x28

}

public class Tick.Entry.List : List<Tick.Entry> // TypeDefIndex: 6605
{
	public void Remove(Object obj) { }

	internal void Tick() { }

	internal void TickTimed() { }

	public void .ctor() { }

}

