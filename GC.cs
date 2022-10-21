public static class GC // TypeDefIndex: 224
{
	internal static readonly object EPHEMERON_TOMBSTONE; 

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

	[ReliabilityContractAttribute] 
	public static int CollectionCount(int generation) { }

	[ReliabilityContractAttribute] 
	public static void KeepAlive(object obj) { }

	public static int get_MaxGeneration() { }

	[ReliabilityContractAttribute] 
	private static void _SuppressFinalize(object o) { }

	[ReliabilityContractAttribute] 
	public static void SuppressFinalize(object obj) { }

	private static void _ReRegisterForFinalize(object o) { }

	public static void ReRegisterForFinalize(object obj) { }

	public static long GetTotalMemory(bool forceFullCollection) { }

	private static void .cctor() { }

}

public class GC : ConsoleSystem // TypeDefIndex: 13675
{
	[ClientVar] 
	public static bool buffer_enabled; 
	[ClientVar] 
	public static int debuglevel; 
	private static int m_buffer; 

	[ClientVar] 
	public static int buffer { get; set; }
	[ServerVar] 
	[ClientVar] 
	public static bool incremental_enabled { get; set; }
	[ServerVar] 
	[ClientVar] 
	public static int incremental_milliseconds { get; set; }
	[ServerVar] 
	[ClientVar] 
	public static bool enabled { get; set; }


	public static int get_buffer() { }

	public static void set_buffer(int value) { }

	public static bool get_incremental_enabled() { }

	public static void set_incremental_enabled(bool value) { }

	public static int get_incremental_milliseconds() { }

	public static void set_incremental_milliseconds(int value) { }

	public static bool get_enabled() { }

	public static void set_enabled(bool value) { }

	[ServerVar] 
	[ClientVar] 
	public static void collect() { }

	[ServerVar] 
	[ClientVar] 
	public static void unload() { }

	[ServerVar] 
	[ClientVar] 
	public static void alloc(ConsoleSystem.Arg args) { }

	public void .ctor() { }

	private static void .cctor() { }

}

public class GC : MonoBehaviour, IClientComponent // TypeDefIndex: 13779
{
	private static float gcTime; 
	private static GarbageCollector.Mode gcMode; 
	private int heapSize; 
	private int heapBaseline; 
	private int collectionCount; 

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

