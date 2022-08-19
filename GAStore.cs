internal class GAStore // TypeDefIndex: 5669
{	// Fields
	private static readonly GAStore _instance; // 0x0
	private string dbPath; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private SqliteConnection <SqlDatabase>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private bool <DbReady>k__BackingField; // 0x20
	private bool _tableReady; // 0x21

	// Properties
	private static GAStore Instance { get; }
	private SqliteConnection SqlDatabase { get; set; }
	private bool DbReady { set; }
	public static bool IsTableReady { get; set; }
	public static bool IsDbTooLargeForEvents { get; }
	public static long DbSizeBytes { get; }

	// Methods

	// RVA: 0x13BDC20 Offset: 0x13BD020 VA: 0x1813BDC20
	private static GAStore get_Instance() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710
	private SqliteConnection get_SqlDatabase() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4D0180 Offset: 0x4CF580 VA: 0x1804D0180
	private void set_SqlDatabase(SqliteConnection value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x7D99E0 Offset: 0x7D8DE0 VA: 0x1807D99E0
	private void set_DbReady(bool value) { }

	// RVA: 0x13BDD40 Offset: 0x13BD140 VA: 0x1813BDD40
	public static bool get_IsTableReady() { }

	// RVA: 0x13BDDF0 Offset: 0x13BD1F0 VA: 0x1813BDDF0
	private static void set_IsTableReady(bool value) { }

	// RVA: 0x13BDCE0 Offset: 0x13BD0E0 VA: 0x1813BDCE0
	public static bool get_IsDbTooLargeForEvents() { }

	// RVA: 0x13BDAF0 Offset: 0x13BCEF0 VA: 0x1813BDAF0
	private void .ctor() { }

	// RVA: 0x13BCD40 Offset: 0x13BC140 VA: 0x1813BCD40
	public static JSONArray ExecuteQuerySync(string sql) { }

	// RVA: 0x13BCE00 Offset: 0x13BC200 VA: 0x1813BCE00
	public static JSONArray ExecuteQuerySync(string sql, Dictionary<string, object> parameters) { }

	// RVA: 0x13BCE70 Offset: 0x13BC270 VA: 0x1813BCE70
	public static JSONArray ExecuteQuerySync(string sql, Dictionary<string, object> parameters, bool useTransaction) { }

	// RVA: 0x13BBF10 Offset: 0x13BB310 VA: 0x1813BBF10
	public static bool EnsureDatabase(bool dropDatabase, string key) { }

	// RVA: 0x13BD6E0 Offset: 0x13BCAE0 VA: 0x1813BD6E0
	public static void SetState(string key, string value) { }

	// RVA: 0x13BDB40 Offset: 0x13BCF40 VA: 0x1813BDB40
	public static long get_DbSizeBytes() { }

	// RVA: 0x13BD850 Offset: 0x13BCC50 VA: 0x1813BD850
	private static void TrimEventTable() { }

	// RVA: 0x13BDA60 Offset: 0x13BCE60 VA: 0x1813BDA60
	private static void .cctor() { }

}

