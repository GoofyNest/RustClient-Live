internal class GAStore // TypeDefIndex: 5674
{
	private static readonly GAStore _instance; 
	private string dbPath; 
	[CompilerGeneratedAttribute] 
	private SqliteConnection <SqlDatabase>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private bool <DbReady>k__BackingField; 
	private bool _tableReady; 

	private static GAStore Instance { get; }
	private SqliteConnection SqlDatabase { get; set; }
	private bool DbReady { set; }
	public static bool IsTableReady { get; set; }
	public static bool IsDbTooLargeForEvents { get; }
	public static long DbSizeBytes { get; }


	private static GAStore get_Instance() { }

	[CompilerGeneratedAttribute] 
	private SqliteConnection get_SqlDatabase() { }

	[CompilerGeneratedAttribute] 
	private void set_SqlDatabase(SqliteConnection value) { }

	[CompilerGeneratedAttribute] 
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

