public static class GC // TypeDefIndex: 224
{	// Fields
	internal static readonly object EPHEMERON_TOMBSTONE; // 0x12F62

	// Properties
	public static int MaxGeneration { get; }

	// Methods

	// RVA: 0x10D8C20 Offset: 0x10D8020 VA: 0x1810D8C20
	private static int GetCollectionCount(int generation) { }

	// RVA: 0x10D8C30 Offset: 0x10D8030 VA: 0x1810D8C30
	private static int GetMaxGeneration() { }

	// RVA: 0x10D8C50 Offset: 0x10D8050 VA: 0x1810D8C50
	private static void InternalCollect(int generation) { }

	// RVA: 0x10D8CF0 Offset: 0x10D80F0 VA: 0x1810D8CF0
	private static void RecordPressure(long bytesAllocated) { }

	// RVA: 0xD64770 Offset: 0xD63B70 VA: 0x180D64770
	internal static void register_ephemeron_array(Ephemeron[] array) { }

	// RVA: 0x10D8F50 Offset: 0x10D8350 VA: 0x1810D8F50
	private static object get_ephemeron_tombstone() { }

	// RVA: 0x10D89F0 Offset: 0x10D7DF0 VA: 0x1810D89F0
	public static void AddMemoryPressure(long bytesAllocated) { }

	// RVA: 0x10D8D00 Offset: 0x10D8100 VA: 0x1810D8D00
	public static void RemoveMemoryPressure(long bytesAllocated) { }

	// RVA: 0x10D8AF0 Offset: 0x10D7EF0 VA: 0x1810D8AF0
	public static void Collect() { }

	[ReliabilityContractAttribute] // RVA: 0x76C70 Offset: 0x76070 VA: 0x180076C70
	// RVA: 0x10D8B80 Offset: 0x10D7F80 VA: 0x1810D8B80
	public static int CollectionCount(int generation) { }

	[ReliabilityContractAttribute] // RVA: 0x76C70 Offset: 0x76070 VA: 0x180076C70
	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0
	public static void KeepAlive(object obj) { }

	// RVA: 0x10D8F00 Offset: 0x10D8300 VA: 0x1810D8F00
	public static int get_MaxGeneration() { }

	[ReliabilityContractAttribute] // RVA: 0x76C70 Offset: 0x76070 VA: 0x180076C70
	// RVA: 0x10D8EA0 Offset: 0x10D82A0 VA: 0x1810D8EA0
	private static void _SuppressFinalize(object o) { }

	[ReliabilityContractAttribute] // RVA: 0x76C70 Offset: 0x76070 VA: 0x180076C70
	// RVA: 0x10D8E00 Offset: 0x10D8200 VA: 0x1810D8E00
	public static void SuppressFinalize(object obj) { }

	// RVA: 0x10D8E90 Offset: 0x10D8290 VA: 0x1810D8E90
	private static void _ReRegisterForFinalize(object o) { }

	// RVA: 0x10D8C60 Offset: 0x10D8060 VA: 0x1810D8C60
	public static void ReRegisterForFinalize(object obj) { }

	// RVA: 0x10D8C40 Offset: 0x10D8040 VA: 0x1810D8C40
	public static long GetTotalMemory(bool forceFullCollection) { }

	// RVA: 0x10D8EB0 Offset: 0x10D82B0 VA: 0x1810D8EB0
	private static void .cctor() { }

}

public class GC : ConsoleSystem // TypeDefIndex: 11921
{	// Fields
	[ClientVar] // RVA: 0x71070 Offset: 0x70470 VA: 0x180071070
	public static bool buffer_enabled; // 0x0
	[ClientVar] // RVA: 0x71070 Offset: 0x70470 VA: 0x180071070
	public static int debuglevel; // 0x4
	private static int m_buffer; // 0x8

	// Properties
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

	// Methods

	// RVA: 0x6DE300 Offset: 0x6DD700 VA: 0x1806DE300
	public static int get_buffer() { }

	// RVA: 0x6DE3B0 Offset: 0x6DD7B0 VA: 0x1806DE3B0
	public static void set_buffer(int value) { }

	// RVA: 0x6DE370 Offset: 0x6DD770 VA: 0x1806DE370
	public static bool get_incremental_enabled() { }

	// RVA: 0x6DE4A0 Offset: 0x6DD8A0 VA: 0x1806DE4A0
	public static void set_incremental_enabled(bool value) { }

	// RVA: 0x6DE380 Offset: 0x6DD780 VA: 0x1806DE380
	public static int get_incremental_milliseconds() { }

	// RVA: 0x6DE4F0 Offset: 0x6DD8F0 VA: 0x1806DE4F0
	public static void set_incremental_milliseconds(int value) { }

	// RVA: 0x6DE360 Offset: 0x6DD760 VA: 0x1806DE360
	public static bool get_enabled() { }

	// RVA: 0x6DE450 Offset: 0x6DD850 VA: 0x1806DE450
	public static void set_enabled(bool value) { }

	[ServerVar] // RVA: 0x8AA10 Offset: 0x89E10 VA: 0x18008AA10
	[ClientVar] // RVA: 0x8AA10 Offset: 0x89E10 VA: 0x18008AA10
	// RVA: 0x6DE2F0 Offset: 0x6DD6F0 VA: 0x1806DE2F0
	public static void collect() { }

	[ServerVar] // RVA: 0x8AA10 Offset: 0x89E10 VA: 0x18008AA10
	[ClientVar] // RVA: 0x8AA10 Offset: 0x89E10 VA: 0x18008AA10
	// RVA: 0x6DE560 Offset: 0x6DD960 VA: 0x1806DE560
	public static void unload() { }

	[ServerVar] // RVA: 0x8AA10 Offset: 0x89E10 VA: 0x18008AA10
	[ClientVar] // RVA: 0x8AA10 Offset: 0x89E10 VA: 0x18008AA10
	// RVA: 0x6DE170 Offset: 0x6DD570 VA: 0x1806DE170
	public static void alloc(ConsoleSystem.Arg args) { }

	// RVA: 0x6DE110 Offset: 0x6DD510 VA: 0x1806DE110
	public void .ctor() { }

	// RVA: 0x6DE0B0 Offset: 0x6DD4B0 VA: 0x1806DE0B0
	private static void .cctor() { }

}

public class GC : MonoBehaviour, IClientComponent // TypeDefIndex: 12025
{	// Fields
	private static float gcTime; // 0x0
	private static GarbageCollector.Mode gcMode; // 0x4
	private int heapSize; // 0x18
	private int heapBaseline; // 0x1C
	private int collectionCount; // 0x20

	// Properties
	public static bool Enabled { get; }

	// Methods

	// RVA: 0x4BA820 Offset: 0x4B9C20 VA: 0x1804BA820
	public static bool get_Enabled() { }

	// RVA: 0x4BA040 Offset: 0x4B9440 VA: 0x1804BA040
	public static void Collect() { }

	// RVA: 0x4BA5E0 Offset: 0x4B99E0 VA: 0x1804BA5E0
	public static void Pause(float time) { }

	// RVA: 0x4BA690 Offset: 0x4B9A90 VA: 0x1804BA690
	public static void Reset(float time) { }

	// RVA: 0x4BA740 Offset: 0x4B9B40 VA: 0x1804BA740
	private static void SetMode(GarbageCollector.Mode mode) { }

	// RVA: 0x4BA120 Offset: 0x4B9520 VA: 0x1804BA120
	private static int GetTotalMemory() { }

	// RVA: 0x4BA0D0 Offset: 0x4B94D0 VA: 0x1804BA0D0
	private static int CollectionCount() { }

	// RVA: 0x4BA770 Offset: 0x4B9B70 VA: 0x1804BA770
	private void UpdateState() { }

	// RVA: 0x4BA5D0 Offset: 0x4B99D0 VA: 0x1804BA5D0
	protected void OnEnable() { }

	// RVA: 0x4BA5A0 Offset: 0x4B99A0 VA: 0x1804BA5A0
	protected void OnDisable() { }

	// RVA: 0x4BA180 Offset: 0x4B9580 VA: 0x1804BA180
	protected void LateUpdate() { }

	// RVA: 0x2F91F0 Offset: 0x2F85F0 VA: 0x1802F91F0
	public void .ctor() { }

}

