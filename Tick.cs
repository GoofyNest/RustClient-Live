public static class Tick // TypeDefIndex: 6603
{	// Fields
	private static Tick.Entry.List Timed; // 0x0
	private static Tick.Entry.List Update; // 0x8
	private static Tick.Entry.List Late; // 0x10
	private static List<Object> RemoveList; // 0x18

	// Methods

	// RVA: 0x1BA9160 Offset: 0x1BA8560 VA: 0x181BA9160
	public static void AddTimed(Object obj, float minDelay, float maxDelay, Action action, string DebugName) { }

	// RVA: 0x1BA92D0 Offset: 0x1BA86D0 VA: 0x181BA92D0
	public static void Add(Object obj, Action action, string DebugName) { }

	// RVA: 0x1BA9010 Offset: 0x1BA8410 VA: 0x181BA9010
	public static void AddLateUpdate(Object obj, Action action, string DebugName) { }

	// RVA: 0x1BA96F0 Offset: 0x1BA8AF0 VA: 0x181BA96F0
	public static void RemoveAll(Object obj) { }

	// RVA: 0x1BA9420 Offset: 0x1BA8820 VA: 0x181BA9420
	private static void Cleanup() { }

	// RVA: 0x1BA9660 Offset: 0x1BA8A60 VA: 0x181BA9660
	internal static void OnFrame() { }

	// RVA: 0x1BA95F0 Offset: 0x1BA89F0 VA: 0x181BA95F0
	internal static void OnFrameLate() { }

	// RVA: 0x1BA9770 Offset: 0x1BA8B70 VA: 0x181BA9770
	private static void .cctor() { }

}

public struct Tick.Entry // TypeDefIndex: 6604
{	// Fields
	public Object TargetObject; // 0x0
	public float MinDelay; // 0x8
	public float RandDelay; // 0xC
	public float NextCall; // 0x10
	public Action Function; // 0x18
	private bool Errored; // 0x20
	public string DebugName; // 0x28

}

public class Tick.Entry.List : List<Tick.Entry> // TypeDefIndex: 6605
{	// Methods

	// RVA: 0x1B9F0E0 Offset: 0x1B9E4E0 VA: 0x181B9F0E0
	public void Remove(Object obj) { }

	// RVA: 0x1B9F3E0 Offset: 0x1B9E7E0 VA: 0x181B9F3E0
	internal void Tick() { }

	// RVA: 0x1B9F1E0 Offset: 0x1B9E5E0 VA: 0x181B9F1E0
	internal void TickTimed() { }

	// RVA: 0x1B9F510 Offset: 0x1B9E910 VA: 0x181B9F510
	public void .ctor() { }

}

