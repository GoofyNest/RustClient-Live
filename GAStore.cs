internal class GAStore // TypeDefIndex: 5669
{	private static readonly GAStore _instance; // 0x0
	private string dbPath; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private SqliteConnection <SqlDatabase>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private bool <DbReady>k__BackingField; // 0x20
	private bool _tableReady; // 0x21

	private static GAStore Instance { get; }
	private SqliteConnection SqlDatabase { get; set; }
	private bool DbReady { set; }
	public static bool IsTableReady { get; set; }
	public static bool IsDbTooLargeForEvents { get; }
	public static long DbSizeBytes { get; }


	private static GAStore get_Instance() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private SqliteConnection get_SqlDatabase() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void set_SqlDatabase(SqliteConnection value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void set_DbReady(bool value) { }

	public static bool get_IsTableReady() { }

	private static void set_IsTableReady(bool value) { }

	public static bool get_IsDbTooLargeForEvents() { }

	private void .ctor() { }

	public static JSONArray ExecuteQuerySync(string sql) { }

	public static JSONArray ExecuteQuerySync(string sql, Dictionary<string, object> parameters) { }

	public static JSONArray ExecuteQuerySync(string sql, Dictionary<string, object> parameters, bool useTransaction) { }

	public static bool EnsureDatabase(bool dropDatabase, string key) { }

	public static void SetState(string key, string value) { }

	public static long get_DbSizeBytes() { }

	private static void TrimEventTable() { }

	private static void .cctor() { }

}

