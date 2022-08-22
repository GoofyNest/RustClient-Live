public static class GC // TypeDefIndex: 224
{	internal static readonly object EPHEMERON_TOMBSTONE; // 0x12F62

	public static int MaxGeneration { get; }


	private static int GetCollectionCount(int generation) { }

	private static int GetMaxGeneration() { }

	private static void InternalCollect(int generation) { }

	private static void RecordPressure(long bytesAllocated) { }

	internal static void register_ephemeron_array(Ephemeron[] array) { }

	private static object get_ephemeron_tombstone() { }

	public static void AddMemoryPressure(long bytesAllocated) { }

	public static void RemoveMemoryPressure(long bytesAllocated) { }

	public static void Collect() { }

	[ReliabilityContractAttribute] // RVA: 0x76C70 Offset: 0x76070 VA: 0x180076C70
	public static int CollectionCount(int generation) { }

	[ReliabilityContractAttribute] // RVA: 0x76C70 Offset: 0x76070 VA: 0x180076C70
	public static void KeepAlive(object obj) { }

	public static int get_MaxGeneration() { }

	[ReliabilityContractAttribute] // RVA: 0x76C70 Offset: 0x76070 VA: 0x180076C70
	private static void _SuppressFinalize(object o) { }

	[ReliabilityContractAttribute] // RVA: 0x76C70 Offset: 0x76070 VA: 0x180076C70
	public static void SuppressFinalize(object obj) { }

	private static void _ReRegisterForFinalize(object o) { }

	public static void ReRegisterForFinalize(object obj) { }

	public static long GetTotalMemory(bool forceFullCollection) { }

	private static void .cctor() { }

}

public class GC : ConsoleSystem // TypeDefIndex: 11921
{	[ClientVar] // RVA: 0x71070 Offset: 0x70470 VA: 0x180071070
	public static bool buffer_enabled; // 0x0
	[ClientVar] // RVA: 0x71070 Offset: 0x70470 VA: 0x180071070
	public static int debuglevel; // 0x4
	private static int m_buffer; // 0x8

	[ClientVar] // RVA: 0x71070 Offset: 0x70470 VA: 0x180071070
	public static int buffer { get; set; }
	[ServerVar] // RVA: 0x8AA10 Offset: 0x89E10 VA: 0x18008AA10
	[ClientVar] // RVA: 0x8AA10 Offset: 0x89E10 VA: 0x18008AA10
	public static bool incremental_enabled { get; set; }
	[ServerVar] // RVA: 0x8AA10 Offset: 0x89E10 VA: 0x18008AA10
	[ClientVar] // RVA: 0x8AA10 Offset: 0x89E10 VA: 0x18008AA10
	public static int incremental_milliseconds { get; set; }
	[ServerVar] // RVA: 0x8AA10 Offset: 0x89E10 VA: 0x18008AA10
	[ClientVar] // RVA: 0x8AA10 Offset: 0x89E10 VA: 0x18008AA10
	public static bool enabled { get; set; }


	public static int get_buffer() { }

	public static void set_buffer(int value) { }

	public static bool get_incremental_enabled() { }

	public static void set_incremental_enabled(bool value) { }

	public static int get_incremental_milliseconds() { }

	public static void set_incremental_milliseconds(int value) { }

	public static bool get_enabled() { }

	public static void set_enabled(bool value) { }

	[ServerVar] // RVA: 0x8AA10 Offset: 0x89E10 VA: 0x18008AA10
	[ClientVar] // RVA: 0x8AA10 Offset: 0x89E10 VA: 0x18008AA10
	public static void collect() { }

	[ServerVar] // RVA: 0x8AA10 Offset: 0x89E10 VA: 0x18008AA10
	[ClientVar] // RVA: 0x8AA10 Offset: 0x89E10 VA: 0x18008AA10
	public static void unload() { }

	[ServerVar] // RVA: 0x8AA10 Offset: 0x89E10 VA: 0x18008AA10
	[ClientVar] // RVA: 0x8AA10 Offset: 0x89E10 VA: 0x18008AA10
	public static void alloc(ConsoleSystem.Arg args) { }

	public void .ctor() { }

	private static void .cctor() { }

}

public class GC : MonoBehaviour, IClientComponent // TypeDefIndex: 12025
{	private static float gcTime; // 0x0
	private static GarbageCollector.Mode gcMode; // 0x4
	private int heapSize; // 0x18
	private int heapBaseline; // 0x1C
	private int collectionCount; // 0x20

	public static bool Enabled { get; }


	public static bool get_Enabled() { }

	public static void Collect() { }

	public static void Pause(float time) { }

	public static void Reset(float time) { }

	private static void SetMode(GarbageCollector.Mode mode) { }

	private static int GetTotalMemory() { }

	private static int CollectionCount() { }

	private void UpdateState() { }

	protected void OnEnable() { }

	protected void OnDisable() { }

	protected void LateUpdate() { }

	public void .ctor() { }

}

