public sealed class SqliteConnection : DbConnection, ICloneable // TypeDefIndex: 4852
{
// Namespace: 
internal class <Module> // TypeDefIndex: 4851

// Namespace: Mono.Data.Sqlite
public sealed class SqliteConnection : DbConnection, ICloneable // TypeDefIndex: 4852
	// Fields
	private ConnectionState _connectionState; // 0x28
	private string _connectionString; // 0x30
	internal int _transactionLevel; // 0x38
	private IsolationLevel _defaultIsolation; // 0x3C
	internal SQLiteEnlistment _enlistment; // 0x40
	internal SQLiteBase _sql; // 0x48
	private string _dataSource; // 0x50
	private byte[] _password; // 0x58
	private int _defaultTimeout; // 0x60
	internal bool _binaryGuid; // 0x64
	internal long _version; // 0x68
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private SQLiteUpdateEventHandler _updateHandler; // 0x70
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private SQLiteCommitHandler _commitHandler; // 0x78
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private EventHandler _rollbackHandler; // 0x80
	private SQLiteUpdateCallback _updateCallback; // 0x88
	private SQLiteCommitCallback _commitCallback; // 0x90
	private SQLiteRollbackCallback _rollbackCallback; // 0x98
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private StateChangeEventHandler StateChange; // 0xA0

	// Properties
	[EditorAttribute] // RVA: 0xDD6D0 Offset: 0xDCAD0 VA: 0x1800DD6D0
	[RefreshPropertiesAttribute] // RVA: 0xDD6D0 Offset: 0xDCAD0 VA: 0x1800DD6D0
	[DefaultValueAttribute] // RVA: 0xDD6D0 Offset: 0xDCAD0 VA: 0x1800DD6D0
	public override string ConnectionString { get; set; }
	public int DefaultTimeout { get; }
	[BrowsableAttribute] // RVA: 0x9E810 Offset: 0x9DC10 VA: 0x18009E810
	[DesignerSerializationVisibilityAttribute] // RVA: 0x9E810 Offset: 0x9DC10 VA: 0x18009E810
	public override ConnectionState State { get; }

	// Methods

	// RVA: 0x1418FA0 Offset: 0x14183A0 VA: 0x181418FA0
	public void .ctor() { }

	// RVA: 0x1418F00 Offset: 0x1418300 VA: 0x181418F00
	public void .ctor(string connectionString) { }

	// RVA: 0x1419060 Offset: 0x1418460 VA: 0x181419060
	public void .ctor(SqliteConnection connection) { }

	// RVA: 0x140D2D0 Offset: 0x140C6D0 VA: 0x18140D2D0 Slot: 22
	public object Clone() { }

	// RVA: 0x140D640 Offset: 0x140CA40 VA: 0x18140D640 Slot: 10
	protected override void Dispose(bool disposing) { }

	// RVA: 0x140E6B0 Offset: 0x140DAB0 VA: 0x18140E6B0
	internal void OnStateChange(ConnectionState newState) { }

	// RVA: 0x140D260 Offset: 0x140C660 VA: 0x18140D260
	public SqliteTransaction BeginTransaction() { }

	// RVA: 0x140D170 Offset: 0x140C570 VA: 0x18140D170 Slot: 15
	protected override DbTransaction BeginDbTransaction(IsolationLevel isolationLevel) { }

	// RVA: 0x140D330 Offset: 0x140C730 VA: 0x18140D330 Slot: 16
	public override void Close() { }

	// RVA: 0x4A2EE0 Offset: 0x4A22E0 VA: 0x1804A2EE0 Slot: 12
	public override string get_ConnectionString() { }

	// RVA: 0x1419570 Offset: 0x1418970 VA: 0x181419570 Slot: 13
	public override void set_ConnectionString(string value) { }

	// RVA: 0x140D520 Offset: 0x140C920 VA: 0x18140D520
	public SqliteCommand CreateCommand() { }

	// RVA: 0x140D630 Offset: 0x140CA30 VA: 0x18140D630 Slot: 17
	protected override DbCommand CreateDbCommand() { }

	// RVA: 0x140E320 Offset: 0x140D720 VA: 0x18140E320
	internal static void MapMonoKeyword(string[] arPiece, SortedList<string, string> ls) { }

	// RVA: 0x140E510 Offset: 0x140D910 VA: 0x18140E510
	internal static string MapMonoUriPath(string path) { }

	// RVA: 0x140E5E0 Offset: 0x140D9E0 VA: 0x18140E5E0
	internal static string MapUriPath(string path) { }

	// RVA: 0x140FE20 Offset: 0x140F220 VA: 0x18140FE20
	internal static SortedList<string, string> ParseConnectionString(string connectionString) { }

	// RVA: 0x140D6A0 Offset: 0x140CAA0 VA: 0x18140D6A0 Slot: 18
	public override void EnlistTransaction(Transaction transaction) { }

	// RVA: 0x140DA90 Offset: 0x140CE90 VA: 0x18140DA90
	internal static string FindKey(SortedList<string, string> items, string key, string defValue) { }

	// RVA: 0x140E750 Offset: 0x140DB50 VA: 0x18140E750 Slot: 21
	public override void Open() { }

	// RVA: 0x58DC10 Offset: 0x58D010 VA: 0x18058DC10
	public int get_DefaultTimeout() { }

	// RVA: 0x4BB390 Offset: 0x4BA790 VA: 0x1804BB390 Slot: 14
	public override ConnectionState get_State() { }

	// RVA: 0x140D850 Offset: 0x140CC50 VA: 0x18140D850
	private string ExpandFileName(string sourceFile) { }

	// RVA: 0x140E2C0 Offset: 0x140D6C0 VA: 0x18140E2C0 Slot: 19
	public override DataTable GetSchema(string collectionName) { }

	// RVA: 0x140DB10 Offset: 0x140CF10 VA: 0x18140DB10 Slot: 20
	public override DataTable GetSchema(string collectionName, string[] restrictionValues) { }

	// RVA: 0x14163F0 Offset: 0x14157F0 VA: 0x1814163F0
	private static DataTable Schema_ReservedWords() { }

	// RVA: 0x14161E0 Offset: 0x14155E0 VA: 0x1814161E0
	private static DataTable Schema_MetaDataCollections() { }

	// RVA: 0x14117D0 Offset: 0x1410BD0 VA: 0x1814117D0
	private DataTable Schema_DataSourceInformation() { }

	// RVA: 0x14104B0 Offset: 0x140F8B0 VA: 0x1814104B0
	private DataTable Schema_Columns(string strCatalog, string strTable, string strColumn) { }

	// RVA: 0x1414AC0 Offset: 0x1413EC0 VA: 0x181414AC0
	private DataTable Schema_Indexes(string strCatalog, string strTable, string strIndex) { }

	// RVA: 0x1416D80 Offset: 0x1416180 VA: 0x181416D80
	private DataTable Schema_Triggers(string catalog, string table, string triggerName) { }

	// RVA: 0x14166A0 Offset: 0x1415AA0 VA: 0x1814166A0
	private DataTable Schema_Tables(string strCatalog, string strTable, string strType) { }

	// RVA: 0x14187E0 Offset: 0x1417BE0 VA: 0x1814187E0
	private DataTable Schema_Views(string strCatalog, string strView) { }

	// RVA: 0x1410080 Offset: 0x140F480 VA: 0x181410080
	private DataTable Schema_Catalogs(string strCatalog) { }

	// RVA: 0x1412440 Offset: 0x1411840 VA: 0x181412440
	private DataTable Schema_DataTypes() { }

	// RVA: 0x1413710 Offset: 0x1412B10 VA: 0x181413710
	private DataTable Schema_IndexColumns(string strCatalog, string strTable, string strIndex, string strColumn) { }

	// RVA: 0x1417330 Offset: 0x1416730 VA: 0x181417330
	private DataTable Schema_ViewColumns(string strCatalog, string strView, string strColumn) { }

	// RVA: 0x14129E0 Offset: 0x1411DE0 VA: 0x1814129E0
	private DataTable Schema_ForeignKeys(string strCatalog, string strTable, string strKeyName) { }

}

public sealed class SqliteFactory : DbProviderFactory, IServiceProvider // TypeDefIndex: 4853
{	// Fields
	private static Type _dbProviderServicesType; // 0x0
	private static object _sqliteServices; // 0x8
	public static readonly SqliteFactory Instance; // 0x10

	// Methods

	// RVA: 0x21ED0C0 Offset: 0x21EC4C0 VA: 0x1821ED0C0
	private static void .cctor() { }

	// RVA: 0x21ECE00 Offset: 0x21EC200 VA: 0x1821ECE00 Slot: 4
	private object System.IServiceProvider.GetService(Type serviceType) { }

	// RVA: 0x21ECC60 Offset: 0x21EC060 VA: 0x1821ECC60
	private object GetSQLiteProviderServicesInstance() { }

	// RVA: 0x7992B0 Offset: 0x7986B0 VA: 0x1807992B0
	public void .ctor() { }

}

internal class SQLite3 : SQLiteBase // TypeDefIndex: 4854
{	// Fields
	protected SqliteConnectionHandle _sql; // 0x18
	protected string _fileName; // 0x20
	protected bool _usePool; // 0x28
	protected int _poolVersion; // 0x2C
	private bool _buildingSchema; // 0x30
	protected SqliteFunction[] _functionsArray; // 0x38

	// Properties
	internal override string Version { get; }
	internal static string SQLiteVersion { get; }
	internal override int Changes { get; }

	// Methods

	// RVA: 0x1407F80 Offset: 0x1407380 VA: 0x181407F80
	internal void .ctor(SQLiteDateFormats fmt) { }

	// RVA: 0x1405210 Offset: 0x1404610 VA: 0x181405210 Slot: 61
	protected override void Dispose(bool bDisposing) { }

	// RVA: 0x1404650 Offset: 0x1403A50 VA: 0x181404650 Slot: 9
	internal override void Close() { }

	// RVA: 0x1408090 Offset: 0x1407490 VA: 0x181408090 Slot: 6
	internal override string get_Version() { }

	// RVA: 0x1408090 Offset: 0x1407490 VA: 0x181408090
	internal static string get_SQLiteVersion() { }

	// RVA: 0x1408020 Offset: 0x1407420 VA: 0x181408020 Slot: 7
	internal override int get_Changes() { }

	// RVA: 0x1405ED0 Offset: 0x14052D0 VA: 0x181405ED0 Slot: 8
	internal override void Open(string strFilename, SQLiteOpenFlagsEnum flags, int maxPoolSize, bool usePool) { }

	// RVA: 0x1407120 Offset: 0x1406520 VA: 0x181407120 Slot: 10
	internal override void SetTimeout(int nTimeoutMS) { }

	// RVA: 0x1407270 Offset: 0x1406670 VA: 0x181407270 Slot: 13
	internal override bool Step(SqliteStatement stmt) { }

	// RVA: 0x14068F0 Offset: 0x1405CF0 VA: 0x1814068F0 Slot: 14
	internal override int Reset(SqliteStatement stmt) { }

	// RVA: 0x1406E70 Offset: 0x1406270 VA: 0x181406E70 Slot: 11
	internal override string SQLiteLastError() { }

	// RVA: 0x1406170 Offset: 0x1405570 VA: 0x181406170 Slot: 12
	internal override SqliteStatement Prepare(SqliteConnection cnn, string strSql, SqliteStatement previous, uint timeoutMS, out string strRemain) { }

	// RVA: 0x1404030 Offset: 0x1403430 VA: 0x181404030 Slot: 15
	internal override void Bind_Double(SqliteStatement stmt, int index, double value) { }

	// RVA: 0x1404120 Offset: 0x1403520 VA: 0x181404120 Slot: 16
	internal override void Bind_Int32(SqliteStatement stmt, int index, int value) { }

	// RVA: 0x1404210 Offset: 0x1403610 VA: 0x181404210 Slot: 17
	internal override void Bind_Int64(SqliteStatement stmt, int index, long value) { }

	// RVA: 0x1404500 Offset: 0x1403900 VA: 0x181404500 Slot: 18
	internal override void Bind_Text(SqliteStatement stmt, int index, string value) { }

	// RVA: 0x1403EC0 Offset: 0x14032C0 VA: 0x181403EC0 Slot: 20
	internal override void Bind_DateTime(SqliteStatement stmt, int index, DateTime dt) { }

	// RVA: 0x1403DA0 Offset: 0x14031A0 VA: 0x181403DA0 Slot: 19
	internal override void Bind_Blob(SqliteStatement stmt, int index, byte[] blobData) { }

	// RVA: 0x1404300 Offset: 0x1403700 VA: 0x181404300 Slot: 21
	internal override void Bind_Null(SqliteStatement stmt, int index) { }

	// RVA: 0x14043E0 Offset: 0x14037E0 VA: 0x1814043E0 Slot: 22
	internal override int Bind_ParamCount(SqliteStatement stmt) { }

	// RVA: 0x1404450 Offset: 0x1403850 VA: 0x181404450 Slot: 23
	internal override string Bind_ParamName(SqliteStatement stmt, int index) { }

	// RVA: 0x14047B0 Offset: 0x1403BB0 VA: 0x1814047B0 Slot: 24
	internal override int ColumnCount(SqliteStatement stmt) { }

	// RVA: 0x1404B00 Offset: 0x1403F00 VA: 0x181404B00 Slot: 25
	internal override string ColumnName(SqliteStatement stmt, int index) { }

	// RVA: 0x1404730 Offset: 0x1403B30 VA: 0x181404730 Slot: 26
	internal override TypeAffinity ColumnAffinity(SqliteStatement stmt, int index) { }

	// RVA: 0x1404D10 Offset: 0x1404110 VA: 0x181404D10 Slot: 27
	internal override string ColumnType(SqliteStatement stmt, int index, out TypeAffinity nAffinity) { }

	// RVA: 0x1404BB0 Offset: 0x1403FB0 VA: 0x181404BB0 Slot: 28
	internal override string ColumnOriginalName(SqliteStatement stmt, int index) { }

	// RVA: 0x1404820 Offset: 0x1403C20 VA: 0x181404820 Slot: 29
	internal override string ColumnDatabaseName(SqliteStatement stmt, int index) { }

	// RVA: 0x1404C60 Offset: 0x1404060 VA: 0x181404C60 Slot: 30
	internal override string ColumnTableName(SqliteStatement stmt, int index) { }

	// RVA: 0x14048D0 Offset: 0x1403CD0 VA: 0x1814048D0 Slot: 31
	internal override void ColumnMetaData(string dataBase, string table, string column, out string dataType, out string collateSequence, out bool notNull, out bool primaryKey, out bool autoIncrement) { }

	// RVA: 0x1405440 Offset: 0x1404840 VA: 0x181405440 Slot: 33
	internal override double GetDouble(SqliteStatement stmt, int index) { }

	// RVA: 0x1405520 Offset: 0x1404920 VA: 0x181405520 Slot: 34
	internal override int GetInt32(SqliteStatement stmt, int index) { }

	// RVA: 0x14055A0 Offset: 0x14049A0 VA: 0x1814055A0 Slot: 35
	internal override long GetInt64(SqliteStatement stmt, int index) { }

	// RVA: 0x14058F0 Offset: 0x1404CF0 VA: 0x1814058F0 Slot: 36
	internal override string GetText(SqliteStatement stmt, int index) { }

	// RVA: 0x1405390 Offset: 0x1404790 VA: 0x181405390 Slot: 38
	internal override DateTime GetDateTime(SqliteStatement stmt, int index) { }

	// RVA: 0x1405230 Offset: 0x1404630 VA: 0x181405230 Slot: 37
	internal override long GetBytes(SqliteStatement stmt, int index, int nDataOffset, byte[] bDest, int nStart, int nLength) { }

	// RVA: 0x1405EB0 Offset: 0x14052B0 VA: 0x181405EB0 Slot: 39
	internal override bool IsNull(SqliteStatement stmt, int index) { }

	// RVA: 0x1405010 Offset: 0x1404410 VA: 0x181405010 Slot: 41
	internal override void CreateFunction(string strFunction, int nArgs, bool needCollSeq, SQLiteCallback func, SQLiteCallback funcstep, SQLiteFinalCallback funcfinal) { }

	// RVA: 0x1404E60 Offset: 0x1404260 VA: 0x181404E60 Slot: 40
	internal override void CreateCollation(string strCollation, SQLiteCollation func, SQLiteCollation func16, IntPtr user_data) { }

	// RVA: 0x1405620 Offset: 0x1404A20 VA: 0x181405620 Slot: 43
	internal override long GetParamValueBytes(IntPtr p, int nDataOffset, byte[] bDest, int nStart, int nLength) { }

	// RVA: 0x1405740 Offset: 0x1404B40 VA: 0x181405740 Slot: 44
	internal override double GetParamValueDouble(IntPtr ptr) { }

	// RVA: 0x14057A0 Offset: 0x1404BA0 VA: 0x1814057A0 Slot: 45
	internal override long GetParamValueInt64(IntPtr ptr) { }

	// RVA: 0x1405800 Offset: 0x1404C00 VA: 0x181405800 Slot: 46
	internal override string GetParamValueText(IntPtr ptr) { }

	// RVA: 0x1405890 Offset: 0x1404C90 VA: 0x181405890 Slot: 47
	internal override TypeAffinity GetParamValueType(IntPtr ptr) { }

	// RVA: 0x1406B00 Offset: 0x1405F00 VA: 0x181406B00 Slot: 48
	internal override void ReturnBlob(IntPtr context, byte[] value) { }

	// RVA: 0x1406BA0 Offset: 0x1405FA0 VA: 0x181406BA0 Slot: 49
	internal override void ReturnDouble(IntPtr context, double value) { }

	// RVA: 0x1406C10 Offset: 0x1406010 VA: 0x181406C10 Slot: 50
	internal override void ReturnError(IntPtr context, string value) { }

	// RVA: 0x1406CC0 Offset: 0x14060C0 VA: 0x181406CC0 Slot: 51
	internal override void ReturnInt64(IntPtr context, long value) { }

	// RVA: 0x1406D30 Offset: 0x1406130 VA: 0x181406D30 Slot: 52
	internal override void ReturnNull(IntPtr context) { }

	// RVA: 0x1406D90 Offset: 0x1406190 VA: 0x181406D90 Slot: 53
	internal override void ReturnText(IntPtr context, string value) { }

	// RVA: 0x1403D40 Offset: 0x1403140 VA: 0x181403D40 Slot: 42
	internal override IntPtr AggregateContext(IntPtr context) { }

	// RVA: 0x1406FC0 Offset: 0x14063C0 VA: 0x181406FC0 Slot: 54
	internal override void SetPassword(byte[] passwordBytes) { }

	// RVA: 0x14071F0 Offset: 0x14065F0 VA: 0x1814071F0 Slot: 55
	internal override void SetUpdateHook(SQLiteUpdateCallback func) { }

	// RVA: 0x1406F40 Offset: 0x1406340 VA: 0x181406F40 Slot: 56
	internal override void SetCommitHook(SQLiteCommitCallback func) { }

	// RVA: 0x14070A0 Offset: 0x14064A0 VA: 0x1814070A0 Slot: 57
	internal override void SetRollbackHook(SQLiteRollbackCallback func) { }

	// RVA: 0x14059A0 Offset: 0x1404DA0 VA: 0x1814059A0 Slot: 60
	internal override object GetValue(SqliteStatement stmt, int index, SQLiteType typ) { }

	// RVA: 0x513D90 Offset: 0x513190 VA: 0x180513D90 Slot: 58
	internal override int GetCursorForTable(SqliteStatement stmt, int db, int rootPage) { }

	// RVA: 0x513D80 Offset: 0x513180 VA: 0x180513D80 Slot: 59
	internal override long GetRowIdForCursor(SqliteStatement stmt, int cursor) { }

	// RVA: 0x14054C0 Offset: 0x14048C0 VA: 0x1814054C0 Slot: 32
	internal override void GetIndexColumnExtendedInfo(string database, string index, string column, out int sortMode, out int onError, out string collationSequence) { }

}

internal class SQLite3_UTF16 : SQLite3 // TypeDefIndex: 4855
{	// Methods

	// RVA: 0x1407F70 Offset: 0x1407370 VA: 0x181407F70
	internal void .ctor(SQLiteDateFormats fmt) { }

	// RVA: 0x1407EA0 Offset: 0x14072A0 VA: 0x181407EA0 Slot: 4
	public override string ToString(IntPtr b, int nbytelen) { }

	// RVA: 0x1407EB0 Offset: 0x14072B0 VA: 0x181407EB0
	public static string UTF16ToString(IntPtr b, int nbytelen) { }

	// RVA: 0x1407BB0 Offset: 0x1406FB0 VA: 0x181407BB0 Slot: 8
	internal override void Open(string strFilename, SQLiteOpenFlagsEnum flags, int maxPoolSize, bool usePool) { }

	// RVA: 0x1407490 Offset: 0x1406890 VA: 0x181407490 Slot: 20
	internal override void Bind_DateTime(SqliteStatement stmt, int index, DateTime dt) { }

	// RVA: 0x14074F0 Offset: 0x14068F0 VA: 0x1814074F0 Slot: 18
	internal override void Bind_Text(SqliteStatement stmt, int index, string value) { }

	// RVA: 0x14079D0 Offset: 0x1406DD0 VA: 0x1814079D0 Slot: 38
	internal override DateTime GetDateTime(SqliteStatement stmt, int index) { }

	// RVA: 0x1407700 Offset: 0x1406B00 VA: 0x181407700 Slot: 25
	internal override string ColumnName(SqliteStatement stmt, int index) { }

	// RVA: 0x1407AC0 Offset: 0x1406EC0 VA: 0x181407AC0 Slot: 36
	internal override string GetText(SqliteStatement stmt, int index) { }

	// RVA: 0x14077F0 Offset: 0x1406BF0 VA: 0x1814077F0 Slot: 28
	internal override string ColumnOriginalName(SqliteStatement stmt, int index) { }

	// RVA: 0x1407610 Offset: 0x1406A10 VA: 0x181407610 Slot: 29
	internal override string ColumnDatabaseName(SqliteStatement stmt, int index) { }

	// RVA: 0x14078E0 Offset: 0x1406CE0 VA: 0x1814078E0 Slot: 30
	internal override string ColumnTableName(SqliteStatement stmt, int index) { }

	// RVA: 0x1407A00 Offset: 0x1406E00 VA: 0x181407A00 Slot: 46
	internal override string GetParamValueText(IntPtr ptr) { }

	// RVA: 0x1407D80 Offset: 0x1407180 VA: 0x181407D80 Slot: 50
	internal override void ReturnError(IntPtr context, string value) { }

	// RVA: 0x1407E00 Offset: 0x1407200 VA: 0x181407E00 Slot: 53
	internal override void ReturnText(IntPtr context, string value) { }

}

internal abstract class SQLiteBase : SqliteConvert, IDisposable // TypeDefIndex: 4856
{	// Fields
	internal static object _lock; // 0x2B0AAB8

	// Properties
	internal abstract string Version { get; }
	internal abstract int Changes { get; }

	// Methods

	// RVA: 0x1408800 Offset: 0x1407C00 VA: 0x181408800
	internal void .ctor(SQLiteDateFormats fmt) { }

	// RVA: -1 Offset: -1 Slot: 6
	internal abstract string get_Version();

	// RVA: -1 Offset: -1 Slot: 7
	internal abstract int get_Changes();

	// RVA: -1 Offset: -1 Slot: 8
	internal abstract void Open(string strFilename, SQLiteOpenFlagsEnum flags, int maxPoolSize, bool usePool);

	// RVA: -1 Offset: -1 Slot: 9
	internal abstract void Close();

	// RVA: -1 Offset: -1 Slot: 10
	internal abstract void SetTimeout(int nTimeoutMS);

	// RVA: -1 Offset: -1 Slot: 11
	internal abstract string SQLiteLastError();

	// RVA: -1 Offset: -1 Slot: 12
	internal abstract SqliteStatement Prepare(SqliteConnection cnn, string strSql, SqliteStatement previous, uint timeoutMS, out string strRemain);

	// RVA: -1 Offset: -1 Slot: 13
	internal abstract bool Step(SqliteStatement stmt);

	// RVA: -1 Offset: -1 Slot: 14
	internal abstract int Reset(SqliteStatement stmt);

	// RVA: -1 Offset: -1 Slot: 15
	internal abstract void Bind_Double(SqliteStatement stmt, int index, double value);

	// RVA: -1 Offset: -1 Slot: 16
	internal abstract void Bind_Int32(SqliteStatement stmt, int index, int value);

	// RVA: -1 Offset: -1 Slot: 17
	internal abstract void Bind_Int64(SqliteStatement stmt, int index, long value);

	// RVA: -1 Offset: -1 Slot: 18
	internal abstract void Bind_Text(SqliteStatement stmt, int index, string value);

	// RVA: -1 Offset: -1 Slot: 19
	internal abstract void Bind_Blob(SqliteStatement stmt, int index, byte[] blobData);

	// RVA: -1 Offset: -1 Slot: 20
	internal abstract void Bind_DateTime(SqliteStatement stmt, int index, DateTime dt);

	// RVA: -1 Offset: -1 Slot: 21
	internal abstract void Bind_Null(SqliteStatement stmt, int index);

	// RVA: -1 Offset: -1 Slot: 22
	internal abstract int Bind_ParamCount(SqliteStatement stmt);

	// RVA: -1 Offset: -1 Slot: 23
	internal abstract string Bind_ParamName(SqliteStatement stmt, int index);

	// RVA: -1 Offset: -1 Slot: 24
	internal abstract int ColumnCount(SqliteStatement stmt);

	// RVA: -1 Offset: -1 Slot: 25
	internal abstract string ColumnName(SqliteStatement stmt, int index);

	// RVA: -1 Offset: -1 Slot: 26
	internal abstract TypeAffinity ColumnAffinity(SqliteStatement stmt, int index);

	// RVA: -1 Offset: -1 Slot: 27
	internal abstract string ColumnType(SqliteStatement stmt, int index, out TypeAffinity nAffinity);

	// RVA: -1 Offset: -1 Slot: 28
	internal abstract string ColumnOriginalName(SqliteStatement stmt, int index);

	// RVA: -1 Offset: -1 Slot: 29
	internal abstract string ColumnDatabaseName(SqliteStatement stmt, int index);

	// RVA: -1 Offset: -1 Slot: 30
	internal abstract string ColumnTableName(SqliteStatement stmt, int index);

	// RVA: -1 Offset: -1 Slot: 31
	internal abstract void ColumnMetaData(string dataBase, string table, string column, out string dataType, out string collateSequence, out bool notNull, out bool primaryKey, out bool autoIncrement);

	// RVA: -1 Offset: -1 Slot: 32
	internal abstract void GetIndexColumnExtendedInfo(string database, string index, string column, out int sortMode, out int onError, out string collationSequence);

	// RVA: -1 Offset: -1 Slot: 33
	internal abstract double GetDouble(SqliteStatement stmt, int index);

	// RVA: -1 Offset: -1 Slot: 34
	internal abstract int GetInt32(SqliteStatement stmt, int index);

	// RVA: -1 Offset: -1 Slot: 35
	internal abstract long GetInt64(SqliteStatement stmt, int index);

	// RVA: -1 Offset: -1 Slot: 36
	internal abstract string GetText(SqliteStatement stmt, int index);

	// RVA: -1 Offset: -1 Slot: 37
	internal abstract long GetBytes(SqliteStatement stmt, int index, int nDataoffset, byte[] bDest, int nStart, int nLength);

	// RVA: -1 Offset: -1 Slot: 38
	internal abstract DateTime GetDateTime(SqliteStatement stmt, int index);

	// RVA: -1 Offset: -1 Slot: 39
	internal abstract bool IsNull(SqliteStatement stmt, int index);

	// RVA: -1 Offset: -1 Slot: 40
	internal abstract void CreateCollation(string strCollation, SQLiteCollation func, SQLiteCollation func16, IntPtr user_data);

	// RVA: -1 Offset: -1 Slot: 41
	internal abstract void CreateFunction(string strFunction, int nArgs, bool needCollSeq, SQLiteCallback func, SQLiteCallback funcstep, SQLiteFinalCallback funcfinal);

	// RVA: -1 Offset: -1 Slot: 42
	internal abstract IntPtr AggregateContext(IntPtr context);

	// RVA: -1 Offset: -1 Slot: 43
	internal abstract long GetParamValueBytes(IntPtr ptr, int nDataOffset, byte[] bDest, int nStart, int nLength);

	// RVA: -1 Offset: -1 Slot: 44
	internal abstract double GetParamValueDouble(IntPtr ptr);

	// RVA: -1 Offset: -1 Slot: 45
	internal abstract long GetParamValueInt64(IntPtr ptr);

	// RVA: -1 Offset: -1 Slot: 46
	internal abstract string GetParamValueText(IntPtr ptr);

	// RVA: -1 Offset: -1 Slot: 47
	internal abstract TypeAffinity GetParamValueType(IntPtr ptr);

	// RVA: -1 Offset: -1 Slot: 48
	internal abstract void ReturnBlob(IntPtr context, byte[] value);

	// RVA: -1 Offset: -1 Slot: 49
	internal abstract void ReturnDouble(IntPtr context, double value);

	// RVA: -1 Offset: -1 Slot: 50
	internal abstract void ReturnError(IntPtr context, string value);

	// RVA: -1 Offset: -1 Slot: 51
	internal abstract void ReturnInt64(IntPtr context, long value);

	// RVA: -1 Offset: -1 Slot: 52
	internal abstract void ReturnNull(IntPtr context);

	// RVA: -1 Offset: -1 Slot: 53
	internal abstract void ReturnText(IntPtr context, string value);

	// RVA: -1 Offset: -1 Slot: 54
	internal abstract void SetPassword(byte[] passwordBytes);

	// RVA: -1 Offset: -1 Slot: 55
	internal abstract void SetUpdateHook(SQLiteUpdateCallback func);

	// RVA: -1 Offset: -1 Slot: 56
	internal abstract void SetCommitHook(SQLiteCommitCallback func);

	// RVA: -1 Offset: -1 Slot: 57
	internal abstract void SetRollbackHook(SQLiteRollbackCallback func);

	// RVA: -1 Offset: -1 Slot: 58
	internal abstract int GetCursorForTable(SqliteStatement stmt, int database, int rootPage);

	// RVA: -1 Offset: -1 Slot: 59
	internal abstract long GetRowIdForCursor(SqliteStatement stmt, int cursor);

	// RVA: -1 Offset: -1 Slot: 60
	internal abstract object GetValue(SqliteStatement stmt, int index, SQLiteType typ);

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 61
	protected virtual void Dispose(bool bDisposing) { }

	// RVA: 0x1408330 Offset: 0x1407730 VA: 0x181408330 Slot: 5
	public void Dispose() { }

	// RVA: 0x1408710 Offset: 0x1407B10 VA: 0x181408710
	internal static string SQLiteLastError(SqliteConnectionHandle db) { }

	// RVA: 0x1408350 Offset: 0x1407750 VA: 0x181408350
	internal static void FinalizeStatement(SqliteStatementHandle stmt) { }

	// RVA: 0x1408110 Offset: 0x1407510 VA: 0x181408110
	internal static void CloseConnection(SqliteConnectionHandle db) { }

	// RVA: 0x14084C0 Offset: 0x14078C0 VA: 0x1814084C0
	internal static void ResetConnection(SqliteConnectionHandle db) { }

	// RVA: 0x14087A0 Offset: 0x1407BA0 VA: 0x1814087A0
	private static void .cctor() { }

}

internal enum SQLiteOpenFlagsEnum // TypeDefIndex: 4858
{	// Fields
	public int value__; // 0x0
	public const SQLiteOpenFlagsEnum None = 0;
	public const SQLiteOpenFlagsEnum ReadOnly = 1;
	public const SQLiteOpenFlagsEnum ReadWrite = 2;
	public const SQLiteOpenFlagsEnum Create = 4;
	public const SQLiteOpenFlagsEnum Default = 6;
	public const SQLiteOpenFlagsEnum FileProtectionComplete = 1048576;
	public const SQLiteOpenFlagsEnum FileProtectionCompleteUnlessOpen = 2097152;
	public const SQLiteOpenFlagsEnum FileProtectionCompleteUntilFirstUserAuthentication = 3145728;
	public const SQLiteOpenFlagsEnum FileProtectionNone = 4194304;

}

public sealed class SqliteCommand : DbCommand, ICloneable // TypeDefIndex: 4859
{	// Fields
	private string _commandText; // 0x28
	private SqliteConnection _cnn; // 0x30
	private long _version; // 0x38
	private WeakReference _activeReader; // 0x40
	internal int _commandTimeout; // 0x48
	private bool _designTimeVisible; // 0x4C
	private UpdateRowSource _updateRowSource; // 0x50
	private SqliteParameterCollection _parameterCollection; // 0x58
	internal List<SqliteStatement> _statementList; // 0x60
	internal string _remainingText; // 0x68
	private SqliteTransaction _transaction; // 0x70

	// Properties
	[DefaultValueAttribute] // RVA: 0xDEEA0 Offset: 0xDE2A0 VA: 0x1800DEEA0
	[RefreshPropertiesAttribute] // RVA: 0xDEEA0 Offset: 0xDE2A0 VA: 0x1800DEEA0
	[EditorAttribute] // RVA: 0xDEEA0 Offset: 0xDE2A0 VA: 0x1800DEEA0
	public override string CommandText { get; set; }
	[DefaultValueAttribute] // RVA: 0xDEFB0 Offset: 0xDE3B0 VA: 0x1800DEFB0
	public override int CommandTimeout { get; set; }
	[DefaultValueAttribute] // RVA: 0xDF130 Offset: 0xDE530 VA: 0x1800DF130
	[RefreshPropertiesAttribute] // RVA: 0xDF130 Offset: 0xDE530 VA: 0x1800DF130
	public override CommandType CommandType { set; }
	[EditorAttribute] // RVA: 0xDF200 Offset: 0xDE600 VA: 0x1800DF200
	[DefaultValueAttribute] // RVA: 0xDF200 Offset: 0xDE600 VA: 0x1800DF200
	public SqliteConnection Connection { get; set; }
	protected override DbConnection DbConnection { get; set; }
	[DesignerSerializationVisibilityAttribute] // RVA: 0x8CB80 Offset: 0x8BF80 VA: 0x18008CB80
	public SqliteParameterCollection Parameters { get; }
	protected override DbParameterCollection DbParameterCollection { get; }
	[DesignerSerializationVisibilityAttribute] // RVA: 0x9E670 Offset: 0x9DA70 VA: 0x18009E670
	[BrowsableAttribute] // RVA: 0x9E670 Offset: 0x9DA70 VA: 0x18009E670
	public SqliteTransaction Transaction { get; set; }
	protected override DbTransaction DbTransaction { get; set; }
	[DefaultValueAttribute] // RVA: 0xDF630 Offset: 0xDEA30 VA: 0x1800DF630
	public override UpdateRowSource UpdatedRowSource { get; set; }
	[DefaultValueAttribute] // RVA: 0xDF690 Offset: 0xDEA90 VA: 0x1800DF690
	[EditorBrowsableAttribute] // RVA: 0xDF690 Offset: 0xDEA90 VA: 0x1800DF690
	[BrowsableAttribute] // RVA: 0xDF690 Offset: 0xDEA90 VA: 0x1800DF690
	[DesignOnlyAttribute] // RVA: 0xDF690 Offset: 0xDEA90 VA: 0x1800DF690
	public override bool DesignTimeVisible { get; set; }

	// Methods

	// RVA: 0x140C1D0 Offset: 0x140B5D0 VA: 0x18140C1D0
	public void .ctor(string commandText, SqliteConnection connection) { }

	// RVA: 0x140BE70 Offset: 0x140B270 VA: 0x18140BE70
	public void .ctor(SqliteConnection connection) { }

	// RVA: 0x140BBC0 Offset: 0x140AFC0 VA: 0x18140BBC0
	private void .ctor(SqliteCommand source) { }

	// RVA: 0x140BF50 Offset: 0x140B350 VA: 0x18140BF50
	public void .ctor(string commandText, SqliteConnection connection, SqliteTransaction transaction) { }

	// RVA: 0x140B4B0 Offset: 0x140A8B0 VA: 0x18140B4B0 Slot: 10
	protected override void Dispose(bool disposing) { }

	// RVA: 0x140B2A0 Offset: 0x140A6A0 VA: 0x18140B2A0
	internal void ClearCommands() { }

	// RVA: 0x140B070 Offset: 0x140A470 VA: 0x18140B070
	internal SqliteStatement BuildNextCommand() { }

	// RVA: 0x140B9C0 Offset: 0x140ADC0 VA: 0x18140B9C0
	internal SqliteStatement GetStatement(int index) { }

	// RVA: 0x7CE230 Offset: 0x7CD630 VA: 0x1807CE230 Slot: 12
	public override string get_CommandText() { }

	// RVA: 0x140C2E0 Offset: 0x140B6E0 VA: 0x18140C2E0 Slot: 13
	public override void set_CommandText(string value) { }

	// RVA: 0x5B1C80 Offset: 0x5B1080 VA: 0x1805B1C80 Slot: 14
	public override int get_CommandTimeout() { }

	// RVA: 0x5B1C90 Offset: 0x5B1090 VA: 0x1805B1C90 Slot: 15
	public override void set_CommandTimeout(int value) { }

	// RVA: 0x140C3A0 Offset: 0x140B7A0 VA: 0x18140C3A0 Slot: 16
	public override void set_CommandType(CommandType value) { }

	// RVA: 0x140B460 Offset: 0x140A860 VA: 0x18140B460 Slot: 26
	protected override DbParameter CreateDbParameter() { }

	// RVA: 0x140B460 Offset: 0x140A860 VA: 0x18140B460
	public SqliteParameter CreateParameter() { }

	// RVA: 0x4A2EE0 Offset: 0x4A22E0 VA: 0x1804A2EE0
	public SqliteConnection get_Connection() { }

	// RVA: 0x140C400 Offset: 0x140B800 VA: 0x18140C400
	public void set_Connection(SqliteConnection value) { }

	// RVA: 0x4A2EE0 Offset: 0x4A22E0 VA: 0x1804A2EE0 Slot: 17
	protected override DbConnection get_DbConnection() { }

	// RVA: 0x140C4C0 Offset: 0x140B8C0 VA: 0x18140C4C0 Slot: 18
	protected override void set_DbConnection(DbConnection value) { }

	// RVA: 0x4CC340 Offset: 0x4CB740 VA: 0x1804CC340
	public SqliteParameterCollection get_Parameters() { }

	// RVA: 0x4CC340 Offset: 0x4CB740 VA: 0x1804CC340 Slot: 19
	protected override DbParameterCollection get_DbParameterCollection() { }

	// RVA: 0x58DC30 Offset: 0x58D030 VA: 0x18058DC30
	public SqliteTransaction get_Transaction() { }

	// RVA: 0x140C610 Offset: 0x140BA10 VA: 0x18140C610
	public void set_Transaction(SqliteTransaction value) { }

	// RVA: 0x58DC30 Offset: 0x58D030 VA: 0x18058DC30 Slot: 20
	protected override DbTransaction get_DbTransaction() { }

	// RVA: 0x140C530 Offset: 0x140B930 VA: 0x18140C530 Slot: 21
	protected override void set_DbTransaction(DbTransaction value) { }

	// RVA: 0x140BA80 Offset: 0x140AE80 VA: 0x18140BA80
	private void InitializeForReader() { }

	// RVA: 0x140B640 Offset: 0x140AA40 VA: 0x18140B640 Slot: 27
	protected override DbDataReader ExecuteDbDataReader(CommandBehavior behavior) { }

	// RVA: 0x140B760 Offset: 0x140AB60 VA: 0x18140B760
	public SqliteDataReader ExecuteReader(CommandBehavior behavior) { }

	// RVA: 0x140B9B0 Offset: 0x140ADB0 VA: 0x18140B9B0
	public SqliteDataReader ExecuteReader() { }

	// RVA: 0x807130 Offset: 0x806530 VA: 0x180807130
	internal void ClearDataReader() { }

	// RVA: 0x140B650 Offset: 0x140AA50 VA: 0x18140B650 Slot: 28
	public override int ExecuteNonQuery() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 29
	public override void Prepare() { }

	// RVA: 0x8C8B80 Offset: 0x8C7F80 VA: 0x1808C8B80 Slot: 24
	public override UpdateRowSource get_UpdatedRowSource() { }

	// RVA: 0x8C8BC0 Offset: 0x8C7FC0 VA: 0x1808C8BC0 Slot: 25
	public override void set_UpdatedRowSource(UpdateRowSource value) { }

	// RVA: 0xC1C200 Offset: 0xC1B600 VA: 0x180C1C200 Slot: 22
	public override bool get_DesignTimeVisible() { }

	// RVA: 0x140C5A0 Offset: 0x140B9A0 VA: 0x18140C5A0 Slot: 23
	public override void set_DesignTimeVisible(bool value) { }

	// RVA: 0x140B400 Offset: 0x140A800 VA: 0x18140B400 Slot: 30
	public object Clone() { }

}

public sealed class SqliteCommandBuilder : DbCommandBuilder // TypeDefIndex: 4860
{	// Properties
	public SqliteDataAdapter DataAdapter { set; }
	[BrowsableAttribute] // RVA: 0x9A790 Offset: 0x99B90 VA: 0x18009A790
	public override CatalogLocation CatalogLocation { get; }
	[BrowsableAttribute] // RVA: 0x9A790 Offset: 0x99B90 VA: 0x18009A790
	public override string CatalogSeparator { get; }
	[DefaultValueAttribute] // RVA: 0xDFA70 Offset: 0xDEE70 VA: 0x1800DFA70
	[BrowsableAttribute] // RVA: 0xDFA70 Offset: 0xDEE70 VA: 0x1800DFA70
	public override string QuotePrefix { get; set; }
	[BrowsableAttribute] // RVA: 0x9A790 Offset: 0x99B90 VA: 0x18009A790
	public override string QuoteSuffix { get; set; }
	[BrowsableAttribute] // RVA: 0x9A790 Offset: 0x99B90 VA: 0x18009A790
	public override string SchemaSeparator { get; }

	// Methods

	// RVA: 0x140AEF0 Offset: 0x140A2F0 VA: 0x18140AEF0
	public void .ctor() { }

	// RVA: 0x140AF70 Offset: 0x140A370 VA: 0x18140AF70
	public void .ctor(SqliteDataAdapter adp) { }

	// RVA: 0x140A0D0 Offset: 0x14094D0 VA: 0x18140A0D0 Slot: 25
	protected override void ApplyParameterInfo(DbParameter parameter, DataRow row, StatementType statementType, bool whereClause) { }

	// RVA: 0x140A270 Offset: 0x1409670 VA: 0x18140A270 Slot: 27
	protected override string GetParameterName(string parameterName) { }

	// RVA: 0x140A1E0 Offset: 0x14095E0 VA: 0x18140A1E0 Slot: 26
	protected override string GetParameterName(int parameterOrdinal) { }

	// RVA: 0x140A2E0 Offset: 0x14096E0 VA: 0x18140A2E0 Slot: 28
	protected override string GetParameterPlaceholder(int parameterOrdinal) { }

	// RVA: 0x140AB90 Offset: 0x1409F90 VA: 0x18140AB90 Slot: 29
	protected override void SetRowUpdatingHandler(DbDataAdapter adapter) { }

	// RVA: 0x140AB80 Offset: 0x1409F80 VA: 0x18140AB80
	private void RowUpdatingEventHandler(object sender, RowUpdatingEventArgs e) { }

	// RVA: 0x140B040 Offset: 0x140A440 VA: 0x18140B040
	public void set_DataAdapter(SqliteDataAdapter value) { }

	// RVA: 0x59C1A0 Offset: 0x59B5A0 VA: 0x18059C1A0 Slot: 13
	public override CatalogLocation get_CatalogLocation() { }

	// RVA: 0x140B000 Offset: 0x140A400 VA: 0x18140B000 Slot: 14
	public override string get_CatalogSeparator() { }

	// RVA: 0x140B010 Offset: 0x140A410 VA: 0x18140B010 Slot: 15
	public override string get_QuotePrefix() { }

	// RVA: 0x140B050 Offset: 0x140A450 VA: 0x18140B050 Slot: 16
	public override void set_QuotePrefix(string value) { }

	// RVA: 0x140B020 Offset: 0x140A420 VA: 0x18140B020 Slot: 17
	public override string get_QuoteSuffix() { }

	// RVA: 0x140B060 Offset: 0x140A460 VA: 0x18140B060 Slot: 18
	public override void set_QuoteSuffix(string value) { }

	// RVA: 0x140A730 Offset: 0x1409B30 VA: 0x18140A730 Slot: 22
	public override string QuoteIdentifier(string unquotedIdentifier) { }

	// RVA: 0x140AD10 Offset: 0x140A110 VA: 0x18140AD10 Slot: 24
	public override string UnquoteIdentifier(string quotedIdentifier) { }

	// RVA: 0x140B030 Offset: 0x140A430 VA: 0x18140B030 Slot: 19
	public override string get_SchemaSeparator() { }

	// RVA: 0x140A300 Offset: 0x1409700 VA: 0x18140A300 Slot: 20
	protected override DataTable GetSchemaTable(DbCommand sourceCommand) { }

	// RVA: 0x140A490 Offset: 0x1409890 VA: 0x18140A490
	private bool HasSchemaPrimaryKey(DataTable schema) { }

	// RVA: 0x140A880 Offset: 0x1409C80 VA: 0x18140A880
	private void ResetIsUniqueSchemaColumn(DataTable schema) { }

}

internal sealed class SQLiteUpdateCallback : MulticastDelegate // TypeDefIndex: 4861
{	// Methods

	// RVA: 0x4971F0 Offset: 0x4965F0 VA: 0x1804971F0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1409AC0 Offset: 0x1408EC0 VA: 0x181409AC0 Slot: 12
	public virtual void Invoke(IntPtr puser, int type, IntPtr database, IntPtr table, long rowid) { }

	// RVA: 0x14099E0 Offset: 0x1408DE0 VA: 0x1814099E0 Slot: 13
	public virtual IAsyncResult BeginInvoke(IntPtr puser, int type, IntPtr database, IntPtr table, long rowid, AsyncCallback callback, object object) { }

	// RVA: 0x497050 Offset: 0x496450 VA: 0x180497050 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

internal sealed class SQLiteCommitCallback : MulticastDelegate // TypeDefIndex: 4862
{	// Methods

	// RVA: 0x4971F0 Offset: 0x4965F0 VA: 0x1804971F0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x14091A0 Offset: 0x14085A0 VA: 0x1814091A0 Slot: 12
	public virtual int Invoke(IntPtr puser) { }

	// RVA: 0x1409120 Offset: 0x1408520 VA: 0x181409120 Slot: 13
	public virtual IAsyncResult BeginInvoke(IntPtr puser, AsyncCallback callback, object object) { }

	// RVA: 0xB95EA0 Offset: 0xB952A0 VA: 0x180B95EA0 Slot: 14
	public virtual int EndInvoke(IAsyncResult result) { }

}

internal sealed class SQLiteRollbackCallback : MulticastDelegate // TypeDefIndex: 4863
{	// Methods

	// RVA: 0x4971F0 Offset: 0x4965F0 VA: 0x1804971F0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1409770 Offset: 0x1408B70 VA: 0x181409770 Slot: 12
	public virtual void Invoke(IntPtr puser) { }

	// RVA: 0x1409960 Offset: 0x1408D60 VA: 0x181409960 Slot: 13
	public virtual IAsyncResult BeginInvoke(IntPtr puser, AsyncCallback callback, object object) { }

	// RVA: 0x497050 Offset: 0x496450 VA: 0x180497050 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

public sealed class SQLiteCommitHandler : MulticastDelegate // TypeDefIndex: 4864
{	// Methods

	// RVA: 0x4971F0 Offset: 0x4965F0 VA: 0x1804971F0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xADFD50 Offset: 0xADF150 VA: 0x180ADFD50 Slot: 12
	public virtual void Invoke(object sender, CommitEventArgs e) { }

	// RVA: 0xADFD10 Offset: 0xADF110 VA: 0x180ADFD10 Slot: 13
	public virtual IAsyncResult BeginInvoke(object sender, CommitEventArgs e, AsyncCallback callback, object object) { }

	// RVA: 0x497050 Offset: 0x496450 VA: 0x180497050 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

public sealed class SQLiteUpdateEventHandler : MulticastDelegate // TypeDefIndex: 4865
{	// Methods

	// RVA: 0x4971F0 Offset: 0x4965F0 VA: 0x1804971F0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xADFD50 Offset: 0xADF150 VA: 0x180ADFD50 Slot: 12
	public virtual void Invoke(object sender, UpdateEventArgs e) { }

	// RVA: 0xADFD10 Offset: 0xADF110 VA: 0x180ADFD10 Slot: 13
	public virtual IAsyncResult BeginInvoke(object sender, UpdateEventArgs e, AsyncCallback callback, object object) { }

	// RVA: 0x497050 Offset: 0x496450 VA: 0x180497050 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

internal static class SqliteConnectionPool // TypeDefIndex: 4868
{
// Namespace: Mono.Data.Sqlite
public class CommitEventArgs : EventArgs // TypeDefIndex: 4867

// Namespace: Mono.Data.Sqlite
internal static class SqliteConnectionPool // TypeDefIndex: 4868
	// Fields
	private static SortedList<string, SqliteConnectionPool.Pool> _connections; // 0x0
	private static int _poolVersion; // 0x8

	// Methods

	// RVA: 0x140CBF0 Offset: 0x140BFF0 VA: 0x18140CBF0
	internal static SqliteConnectionHandle Remove(string fileName, int maxPoolSize, out int version) { }

	// RVA: 0x140C8D0 Offset: 0x140BCD0 VA: 0x18140C8D0
	internal static void Add(string fileName, SqliteConnectionHandle hdl, int version) { }

	// RVA: 0x140CF80 Offset: 0x140C380 VA: 0x18140CF80
	private static void ResizePool(SqliteConnectionPool.Pool queue, bool forAdding) { }

	// RVA: 0x140D070 Offset: 0x140C470 VA: 0x18140D070
	private static void .cctor() { }

}

internal class SqliteConnectionPool.Pool // TypeDefIndex: 4869
{	// Fields
	internal readonly Queue<WeakReference> Queue; // 0x10
	internal int PoolVersion; // 0x18
	internal int MaxPoolSize; // 0x1C

	// Methods

	// RVA: 0x1403CB0 Offset: 0x14030B0 VA: 0x181403CB0
	internal void .ctor(int version, int maxSize) { }

}

public abstract class SqliteConvert // TypeDefIndex: 4870
{	// Fields
	protected static readonly DateTime UnixEpoch; // 0x0
	private static string[] _datetimeFormats; // 0x8
	private static Encoding _utf8; // 0x10
	internal SQLiteDateFormats _datetimeFormat; // 0x10
	private static Type[] _affinitytotype; // 0x18
	private static DbType[] _typetodbtype; // 0x20
	private static int[] _dbtypetocolumnsize; // 0x28
	private static object[] _dbtypetonumericprecision; // 0x30
	private static object[] _dbtypetonumericscale; // 0x38
	private static SQLiteTypeNames[] _dbtypeNames; // 0x40
	private static Type[] _dbtypeToType; // 0x48
	private static TypeAffinity[] _typecodeAffinities; // 0x50
	private static SQLiteTypeNames[] _typeNames; // 0x58

	// Methods

	// RVA: 0x497770 Offset: 0x496B70 VA: 0x180497770
	internal void .ctor(SQLiteDateFormats fmt) { }

	// RVA: 0x141A760 Offset: 0x1419B60 VA: 0x18141A760
	public static byte[] ToUTF8(string sourceText) { }

	// RVA: 0x141A6F0 Offset: 0x1419AF0 VA: 0x18141A6F0
	public byte[] ToUTF8(DateTime dateTimeValue) { }

	// RVA: 0x141A690 Offset: 0x1419A90 VA: 0x18141A690 Slot: 4
	public virtual string ToString(IntPtr nativestring, int nativestringlen) { }

	// RVA: 0x141AE30 Offset: 0x141A230 VA: 0x18141AE30
	public static string UTF8ToString(IntPtr nativestring, int nativestringlen) { }

	// RVA: 0x141A100 Offset: 0x1419500 VA: 0x18141A100
	public DateTime ToDateTime(string dateText) { }

	// RVA: 0x141A3E0 Offset: 0x14197E0 VA: 0x18141A3E0
	public DateTime ToDateTime(double julianDay) { }

	// RVA: 0x141A440 Offset: 0x1419840 VA: 0x18141A440
	public double ToJulianDay(DateTime value) { }

	// RVA: 0x141A470 Offset: 0x1419870 VA: 0x18141A470
	public string ToString(DateTime dateValue) { }

	// RVA: 0x141A0D0 Offset: 0x14194D0 VA: 0x18141A0D0
	internal DateTime ToDateTime(IntPtr ptr, int len) { }

	// RVA: 0x1419B00 Offset: 0x1418F00 VA: 0x181419B00
	public static string[] Split(string source, char separator) { }

	// RVA: 0x1419E80 Offset: 0x1419280 VA: 0x181419E80
	public static bool ToBoolean(string source) { }

	// RVA: 0x14199C0 Offset: 0x1418DC0 VA: 0x1814199C0
	internal static Type SQLiteTypeToType(SQLiteType t) { }

	// RVA: 0x141ACC0 Offset: 0x141A0C0 VA: 0x18141ACC0
	internal static DbType TypeToDbType(Type typ) { }

	// RVA: 0x1419620 Offset: 0x1418A20 VA: 0x181419620
	internal static int DbTypeToColumnSize(DbType typ) { }

	// RVA: 0x14196B0 Offset: 0x1418AB0 VA: 0x1814196B0
	internal static object DbTypeToNumericPrecision(DbType typ) { }

	// RVA: 0x1419740 Offset: 0x1418B40 VA: 0x181419740
	internal static object DbTypeToNumericScale(DbType typ) { }

	// RVA: 0x14197D0 Offset: 0x1418BD0 VA: 0x1814197D0
	internal static string DbTypeToTypeName(DbType typ) { }

	// RVA: 0x1419930 Offset: 0x1418D30 VA: 0x181419930
	internal static Type DbTypeToType(DbType typ) { }

	// RVA: 0x141AB60 Offset: 0x1419F60 VA: 0x18141AB60
	internal static TypeAffinity TypeToAffinity(Type typ) { }

	// RVA: 0x141A870 Offset: 0x1419C70 VA: 0x18141A870
	internal static DbType TypeNameToDbType(string Name) { }

	// RVA: 0x141AF90 Offset: 0x141A390 VA: 0x18141AF90
	private static void .cctor() { }

}

public enum SQLiteDateFormats // TypeDefIndex: 4872
{	// Fields
	public int value__; // 0x0
	public const SQLiteDateFormats Ticks = 0;
	public const SQLiteDateFormats ISO8601 = 1;
	public const SQLiteDateFormats JulianDay = 2;
	public const SQLiteDateFormats UnixEpoch = 3;

}

internal class SQLiteType // TypeDefIndex: 4873
{	// Fields
	internal DbType Type; // 0x10
	internal TypeAffinity Affinity; // 0x14

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

}

internal struct SQLiteTypeNames // TypeDefIndex: 4874
{	// Fields
	internal string typeName; // 0x0
	internal DbType dataType; // 0x8

	// Methods

	// RVA: 0xF9CD0 Offset: 0xF90D0 VA: 0x1800F9CD0
	internal void .ctor(string newtypeName, DbType newdataType) { }

}

public sealed class SqliteDataAdapter : DbDataAdapter // TypeDefIndex: 4875
{	// Fields
	private static object _updatingEventPH; // 0x0
	private static object _updatedEventPH; // 0x8

	// Methods

	// RVA: 0x141F980 Offset: 0x141ED80 VA: 0x18141F980
	public void add_RowUpdating(EventHandler<RowUpdatingEventArgs> value) { }

	// RVA: 0x141FC50 Offset: 0x141F050 VA: 0x18141FC50
	public void remove_RowUpdating(EventHandler<RowUpdatingEventArgs> value) { }

	// RVA: 0x141F800 Offset: 0x141EC00 VA: 0x18141F800
	internal static Delegate FindBuilder(MulticastDelegate mcd) { }

	// RVA: 0x141F8F0 Offset: 0x141ECF0 VA: 0x18141F8F0
	private static void .cctor() { }

}

public sealed class SqliteDataReader : DbDataReader // TypeDefIndex: 4876
{	// Fields
	private SqliteCommand _command; // 0x18
	private int _activeStatementIndex; // 0x20
	private SqliteStatement _activeStatement; // 0x28
	private int _readingState; // 0x30
	private int _rowsAffected; // 0x34
	private int _fieldCount; // 0x38
	private SQLiteType[] _fieldTypeArray; // 0x40
	private CommandBehavior _commandBehavior; // 0x48
	internal bool _disposeCommand; // 0x4C
	private SqliteKeyReader _keyInfo; // 0x50
	internal long _version; // 0x58
	private static bool hasColumnMetadataSupport; // 0x0

	// Properties
	public override int FieldCount { get; }
	public override int VisibleFieldCount { get; }
	public override int RecordsAffected { get; }
	public override object Item { get; }

	// Methods

	// RVA: 0x1423B00 Offset: 0x1422F00 VA: 0x181423B00
	internal void .ctor(SqliteCommand cmd, CommandBehavior behave) { }

	// RVA: 0x141FE70 Offset: 0x141F270 VA: 0x18141FE70 Slot: 21
	public override void Close() { }

	// RVA: 0x141FCE0 Offset: 0x141F0E0 VA: 0x18141FCE0
	private void CheckClosed() { }

	// RVA: 0x141FE00 Offset: 0x141F200 VA: 0x18141FE00
	private void CheckValidRow() { }

	// RVA: 0x1420350 Offset: 0x141F750 VA: 0x181420350 Slot: 24
	public override IEnumerator GetEnumerator() { }

	// RVA: 0x1423BB0 Offset: 0x1422FB0 VA: 0x181423BB0 Slot: 17
	public override int get_FieldCount() { }

	// RVA: 0x1423C20 Offset: 0x1423020 VA: 0x181423C20 Slot: 19
	public override int get_VisibleFieldCount() { }

	// RVA: 0x1423980 Offset: 0x1422D80 VA: 0x181423980
	private TypeAffinity VerifyType(int i, DbType typ) { }

	// RVA: 0x14200C0 Offset: 0x141F4C0 VA: 0x1814200C0 Slot: 28
	public override bool GetBoolean(int i) { }

	// RVA: 0x1420290 Offset: 0x141F690 VA: 0x181420290 Slot: 23
	public override string GetDataTypeName(int i) { }

	// RVA: 0x14203C0 Offset: 0x141F7C0 VA: 0x1814203C0 Slot: 25
	public override Type GetFieldType(int i) { }

	// RVA: 0x1420490 Offset: 0x141F890 VA: 0x181420490 Slot: 29
	public override int GetInt32(int i) { }

	// RVA: 0x1420600 Offset: 0x141FA00 VA: 0x181420600 Slot: 30
	public override long GetInt64(int i) { }

	// RVA: 0x1420770 Offset: 0x141FB70 VA: 0x181420770 Slot: 26
	public override string GetName(int i) { }

	// RVA: 0x1420A20 Offset: 0x141FE20 VA: 0x181420A20 Slot: 27
	public override DataTable GetSchemaTable() { }

	// RVA: 0x1420A30 Offset: 0x141FE30 VA: 0x181420A30
	internal DataTable GetSchemaTable(bool wantUniqueInfo, bool wantDefaultValue) { }

	// RVA: 0x1423170 Offset: 0x1422570 VA: 0x181423170 Slot: 31
	public override string GetString(int i) { }

	// RVA: 0x14232E0 Offset: 0x14226E0 VA: 0x1814232E0 Slot: 32
	public override object GetValue(int i) { }

	// RVA: 0x14233A0 Offset: 0x14227A0 VA: 0x1814233A0 Slot: 33
	public override int GetValues(object[] values) { }

	// RVA: 0x1423490 Offset: 0x1422890 VA: 0x181423490 Slot: 34
	public override bool IsDBNull(int i) { }

	// RVA: 0x14235F0 Offset: 0x14229F0 VA: 0x1814235F0 Slot: 35
	public override bool NextResult() { }

	// RVA: 0x1420810 Offset: 0x141FC10 VA: 0x181420810
	private SQLiteType GetSQLiteType(int i) { }

	// RVA: 0x14238F0 Offset: 0x1422CF0 VA: 0x1814238F0 Slot: 36
	public override bool Read() { }

	// RVA: 0x1423C10 Offset: 0x1423010 VA: 0x181423C10 Slot: 18
	public override int get_RecordsAffected() { }

	// RVA: 0x1423BF0 Offset: 0x1422FF0 VA: 0x181423BF0 Slot: 20
	public override object get_Item(int i) { }

	// RVA: 0x1423530 Offset: 0x1422930 VA: 0x181423530
	private void LoadKeyInfo() { }

	// RVA: 0x1423AC0 Offset: 0x1422EC0 VA: 0x181423AC0
	private static void .cctor() { }

}

internal class SQLiteEnlistment : IEnlistmentNotification // TypeDefIndex: 4877
{	// Fields
	internal SqliteTransaction _transaction; // 0x10
	internal Transaction _scope; // 0x18
	internal bool _disposeConnection; // 0x20

	// Methods

	// RVA: 0x1409620 Offset: 0x1408A20 VA: 0x181409620
	internal void .ctor(SqliteConnection cnn, Transaction scope) { }

	// RVA: 0x14094A0 Offset: 0x14088A0 VA: 0x1814094A0
	private void Cleanup(SqliteConnection cnn) { }

	// RVA: 0x14094F0 Offset: 0x14088F0 VA: 0x1814094F0 Slot: 4
	public void Rollback(Enlistment enlistment) { }

}

public sealed class SqliteException : DbException // TypeDefIndex: 4878
{	// Fields
	private SQLiteErrorCode _errorCode; // 0x88
	private static string[] _errorMessages; // 0x0

	// Methods

	// RVA: 0x21ECAB0 Offset: 0x21EBEB0 VA: 0x1821ECAB0
	private void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x21ECAD0 Offset: 0x21EBED0 VA: 0x1821ECAD0
	public void .ctor(int errorCode, string extendedInformation) { }

	// RVA: 0x21ECC50 Offset: 0x21EC050 VA: 0x1821ECC50
	public void .ctor() { }

	// RVA: 0x21EBE90 Offset: 0x21EB290 VA: 0x1821EBE90
	private static string GetStockErrorMessage(int errorCode, string errorMessage) { }

	// RVA: 0x21EBF90 Offset: 0x21EB390 VA: 0x1821EBF90
	private static void .cctor() { }

}

public enum SQLiteErrorCode // TypeDefIndex: 4879
{	// Fields
	public int value__; // 0x0
	public const SQLiteErrorCode Ok = 0;
	public const SQLiteErrorCode Error = 1;
	public const SQLiteErrorCode Internal = 2;
	public const SQLiteErrorCode Perm = 3;
	public const SQLiteErrorCode Abort = 4;
	public const SQLiteErrorCode Busy = 5;
	public const SQLiteErrorCode Locked = 6;
	public const SQLiteErrorCode NoMem = 7;
	public const SQLiteErrorCode ReadOnly = 8;
	public const SQLiteErrorCode Interrupt = 9;
	public const SQLiteErrorCode IOErr = 10;
	public const SQLiteErrorCode Corrupt = 11;
	public const SQLiteErrorCode NotFound = 12;
	public const SQLiteErrorCode Full = 13;
	public const SQLiteErrorCode CantOpen = 14;
	public const SQLiteErrorCode Protocol = 15;
	public const SQLiteErrorCode Empty = 16;
	public const SQLiteErrorCode Schema = 17;
	public const SQLiteErrorCode TooBig = 18;
	public const SQLiteErrorCode Constraint = 19;
	public const SQLiteErrorCode Mismatch = 20;
	public const SQLiteErrorCode Misuse = 21;
	public const SQLiteErrorCode NOLFS = 22;
	public const SQLiteErrorCode Auth = 23;
	public const SQLiteErrorCode Format = 24;
	public const SQLiteErrorCode Range = 25;
	public const SQLiteErrorCode NotADatabase = 26;
	public const SQLiteErrorCode Row = 100;
	public const SQLiteErrorCode Done = 101;

}

public abstract class SqliteFunction // TypeDefIndex: 4880
{	// Fields
	internal SQLiteBase _base; // 0x10
	private Dictionary<long, SqliteFunction.AggregateData> _contextDataList; // 0x18
	private SQLiteCallback _InvokeFunc; // 0x20
	private SQLiteCallback _StepFunc; // 0x28
	private SQLiteFinalCallback _FinalFunc; // 0x30
	private SQLiteCollation _CompareFunc; // 0x38
	private SQLiteCollation _CompareFunc16; // 0x40
	internal IntPtr _context; // 0x48
	private static List<SqliteFunctionAttribute> _registeredFunctions; // 0x0

	// Methods

	// RVA: 0x513D80 Offset: 0x513180 VA: 0x180513D80 Slot: 4
	public virtual object Invoke(object[] args) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 5
	public virtual void Step(object[] args, int stepNumber, ref object contextData) { }

	// RVA: 0x513D80 Offset: 0x513180 VA: 0x180513D80 Slot: 6
	public virtual object Final(object contextData) { }

	// RVA: 0x513D80 Offset: 0x513180 VA: 0x180513D80 Slot: 7
	public virtual int Compare(string param1, string param2) { }

	// RVA: 0x21ED6F0 Offset: 0x21ECAF0 VA: 0x1821ED6F0
	internal object[] ConvertParams(int nArgs, IntPtr argsptr) { }

	// RVA: 0x21EDDD0 Offset: 0x21ED1D0 VA: 0x1821EDDD0
	private void SetReturnValue(IntPtr context, object returnValue) { }

	// RVA: 0x21EDD70 Offset: 0x21ED170 VA: 0x1821EDD70
	internal void ScalarCallback(IntPtr context, int nArgs, IntPtr argsptr) { }

	// RVA: 0x21ED650 Offset: 0x21ECA50 VA: 0x1821ED650
	internal int CompareCallback(IntPtr ptr, int len1, IntPtr ptr1, int len2, IntPtr ptr2) { }

	// RVA: 0x21ED5F0 Offset: 0x21EC9F0 VA: 0x1821ED5F0
	internal int CompareCallback16(IntPtr ptr, int len1, IntPtr ptr1, int len2, IntPtr ptr2) { }

	// RVA: 0x21EE180 Offset: 0x21ED580 VA: 0x1821EE180
	internal void StepCallback(IntPtr context, int nArgs, IntPtr argsptr) { }

	// RVA: 0x21EDC40 Offset: 0x21ED040 VA: 0x1821EDC40
	internal void FinalCallback(IntPtr context) { }

	// RVA: 0x21EE320 Offset: 0x21ED720 VA: 0x1821EE320
	private static void .cctor() { }

	// RVA: 0x21ED190 Offset: 0x21EC590 VA: 0x1821ED190
	internal static SqliteFunction[] BindFunctions(SQLiteBase sqlbase) { }

}

private class SqliteFunction.AggregateData // TypeDefIndex: 4881
{	// Fields
	internal int _count; // 0x10
	internal object _data; // 0x18

	// Methods

	// RVA: 0x1071990 Offset: 0x1070D90 VA: 0x181071990
	public void .ctor() { }

}

internal sealed class SQLiteCallback : MulticastDelegate // TypeDefIndex: 4884
{	// Methods

	// RVA: 0x4971F0 Offset: 0x4965F0 VA: 0x1804971F0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1408900 Offset: 0x1407D00 VA: 0x181408900 Slot: 12
	public virtual void Invoke(IntPtr context, int nArgs, IntPtr argsptr) { }

	// RVA: 0x1408860 Offset: 0x1407C60 VA: 0x181408860 Slot: 13
	public virtual IAsyncResult BeginInvoke(IntPtr context, int nArgs, IntPtr argsptr, AsyncCallback callback, object object) { }

	// RVA: 0x497050 Offset: 0x496450 VA: 0x180497050 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

internal sealed class SQLiteFinalCallback : MulticastDelegate // TypeDefIndex: 4885
{	// Methods

	// RVA: 0x4971F0 Offset: 0x4965F0 VA: 0x1804971F0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1409770 Offset: 0x1408B70 VA: 0x181409770 Slot: 12
	public virtual void Invoke(IntPtr context) { }

	// RVA: 0x14096F0 Offset: 0x1408AF0 VA: 0x1814096F0 Slot: 13
	public virtual IAsyncResult BeginInvoke(IntPtr context, AsyncCallback callback, object object) { }

	// RVA: 0x497050 Offset: 0x496450 VA: 0x180497050 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

internal sealed class SQLiteCollation : MulticastDelegate // TypeDefIndex: 4886
{	// Methods

	// RVA: 0x4971F0 Offset: 0x4965F0 VA: 0x1804971F0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1408D40 Offset: 0x1408140 VA: 0x181408D40 Slot: 12
	public virtual int Invoke(IntPtr puser, int len1, IntPtr pv1, int len2, IntPtr pv2) { }

	// RVA: 0x1408C60 Offset: 0x1408060 VA: 0x181408C60 Slot: 13
	public virtual IAsyncResult BeginInvoke(IntPtr puser, int len1, IntPtr pv1, int len2, IntPtr pv2, AsyncCallback callback, object object) { }

	// RVA: 0xB95EA0 Offset: 0xB952A0 VA: 0x180B95EA0 Slot: 14
	public virtual int EndInvoke(IAsyncResult result) { }

}

public sealed class SqliteFunctionAttribute : Attribute // TypeDefIndex: 4887
{	// Fields
	private string _name; // 0x10
	private int _arguments; // 0x18
	private FunctionType _functionType; // 0x1C
	internal Type _instanceType; // 0x20

	// Properties
	public string Name { get; }
	public int Arguments { get; }
	public FunctionType FuncType { get; }

	// Methods

	// RVA: 0x4B9460 Offset: 0x4B8860 VA: 0x1804B9460
	public string get_Name() { }

	// RVA: 0x4BE200 Offset: 0x4BD600 VA: 0x1804BE200
	public int get_Arguments() { }

	// RVA: 0x4BE1F0 Offset: 0x4BD5F0 VA: 0x1804BE1F0
	public FunctionType get_FuncType() { }

}

internal sealed class SqliteKeyReader : IDisposable // TypeDefIndex: 4888
{	// Fields
	private SqliteKeyReader.KeyInfo[] _keyInfo; // 0x10
	private SqliteStatement _stmt; // 0x18
	private bool _isValid; // 0x20

	// Properties
	internal int Count { get; }

	// Methods

	// RVA: 0x21EFF20 Offset: 0x21EF320 VA: 0x1821EFF20
	internal void .ctor(SqliteConnection cnn, SqliteDataReader reader, SqliteStatement stmt) { }

	// RVA: 0xD81F30 Offset: 0xD81330 VA: 0x180D81F30
	internal int get_Count() { }

	// RVA: 0x21EFE80 Offset: 0x21EF280 VA: 0x1821EFE80
	internal void Sync(int i) { }

	// RVA: 0x21EFD90 Offset: 0x21EF190 VA: 0x1821EFD90
	internal void Sync() { }

	// RVA: 0x21EFCC0 Offset: 0x21EF0C0 VA: 0x1821EFCC0
	internal void Reset() { }

	// RVA: 0x21EF170 Offset: 0x21EE570 VA: 0x1821EF170 Slot: 4
	public void Dispose() { }

	// RVA: 0x21EF2E0 Offset: 0x21EE6E0 VA: 0x1821EF2E0
	internal string GetDataTypeName(int i) { }

	// RVA: 0x21EF390 Offset: 0x21EE790 VA: 0x1821EF390
	internal Type GetFieldType(int i) { }

	// RVA: 0x21EF6C0 Offset: 0x21EEAC0 VA: 0x1821EF6C0
	internal string GetName(int i) { }

	// RVA: 0x21EF210 Offset: 0x21EE610 VA: 0x1821EF210
	internal bool GetBoolean(int i) { }

	// RVA: 0x21EF460 Offset: 0x21EE860 VA: 0x1821EF460
	internal int GetInt32(int i) { }

	// RVA: 0x21EF590 Offset: 0x21EE990 VA: 0x1821EF590
	internal long GetInt64(int i) { }

	// RVA: 0x21EF700 Offset: 0x21EEB00 VA: 0x1821EF700
	internal string GetString(int i) { }

	// RVA: 0x21EF7D0 Offset: 0x21EEBD0 VA: 0x1821EF7D0
	internal object GetValue(int i) { }

	// RVA: 0x21EFB60 Offset: 0x21EEF60 VA: 0x1821EFB60
	internal bool IsDBNull(int i) { }

	// RVA: 0x21EE760 Offset: 0x21EDB60 VA: 0x1821EE760
	internal void AppendSchemaTable(DataTable tbl) { }

}

private struct SqliteKeyReader.KeyInfo // TypeDefIndex: 4889
{	// Fields
	internal string databaseName; // 0x0
	internal string tableName; // 0x8
	internal string columnName; // 0x10
	internal int database; // 0x18
	internal int rootPage; // 0x1C
	internal int cursor; // 0x20
	internal SqliteKeyReader.KeyQuery query; // 0x28
	internal int column; // 0x30

}

private sealed class SqliteKeyReader.KeyQuery : IDisposable // TypeDefIndex: 4890
{	// Fields
	private SqliteCommand _command; // 0x10
	internal SqliteDataReader _reader; // 0x18

	// Properties
	internal bool IsValid { set; }

	// Methods

	// RVA: 0x21EBAE0 Offset: 0x21EAEE0 VA: 0x1821EBAE0
	internal void .ctor(SqliteConnection cnn, string database, string table, string[] columns) { }

	// RVA: 0x21EBE00 Offset: 0x21EB200 VA: 0x1821EBE00
	internal void set_IsValid(bool value) { }

	// RVA: 0x21EB980 Offset: 0x21EAD80 VA: 0x1821EB980
	internal void Sync(long rowid) { }

	// RVA: 0x21EB900 Offset: 0x21EAD00 VA: 0x1821EB900 Slot: 4
	public void Dispose() { }

}

public sealed class SqliteParameter : DbParameter, ICloneable // TypeDefIndex: 4891
{	// Fields
	internal int _dbType; // 0x18
	private DataRowVersion _rowVersion; // 0x1C
	private object _objValue; // 0x20
	private string _sourceColumn; // 0x28
	private string _parameterName; // 0x30
	private int _dataSize; // 0x38
	private bool _nullable; // 0x3C
	private bool _nullMapping; // 0x3D

	// Properties
	public override bool IsNullable { get; set; }
	[RefreshPropertiesAttribute] // RVA: 0xE08B0 Offset: 0xDFCB0 VA: 0x1800E08B0
	[DbProviderSpecificTypePropertyAttribute] // RVA: 0xE08B0 Offset: 0xDFCB0 VA: 0x1800E08B0
	public override DbType DbType { get; set; }
	public override ParameterDirection Direction { get; set; }
	public override string ParameterName { get; set; }
	[DefaultValueAttribute] // RVA: 0xE0A60 Offset: 0xDFE60 VA: 0x1800E0A60
	public override int Size { set; }
	public override string SourceColumn { get; set; }
	public override bool SourceColumnNullMapping { set; }
	public override DataRowVersion SourceVersion { get; set; }
	[TypeConverterAttribute] // RVA: 0xE0A80 Offset: 0xDFE80 VA: 0x1800E0A80
	[RefreshPropertiesAttribute] // RVA: 0xE0A80 Offset: 0xDFE80 VA: 0x1800E0A80
	public override object Value { get; set; }

	// Methods

	// RVA: 0x21F27E0 Offset: 0x21F1BE0 VA: 0x1821F27E0
	public void .ctor() { }

	// RVA: 0x21F2B60 Offset: 0x21F1F60 VA: 0x1821F2B60
	public void .ctor(string parameterName, object value) { }

	// RVA: 0x21F2AD0 Offset: 0x21F1ED0 VA: 0x1821F2AD0
	public void .ctor(string parameterName, DbType parameterType, int parameterSize, string sourceColumn, DataRowVersion rowVersion) { }

	// RVA: 0x21F2930 Offset: 0x21F1D30 VA: 0x1821F2930
	private void .ctor(SqliteParameter source) { }

	[EditorBrowsableAttribute] // RVA: 0x8CB80 Offset: 0x8BF80 VA: 0x18008CB80
	// RVA: 0x21F2850 Offset: 0x21F1C50 VA: 0x1821F2850
	public void .ctor(string parameterName, DbType parameterType, int parameterSize, ParameterDirection direction, bool isNullable, byte precision, byte scale, string sourceColumn, DataRowVersion rowVersion, object value) { }

	// RVA: 0xC45090 Offset: 0xC44490 VA: 0x180C45090 Slot: 10
	public override bool get_IsNullable() { }

	// RVA: 0xE86630 Offset: 0xE85A30 VA: 0x180E86630 Slot: 11
	public override void set_IsNullable(bool value) { }

	// RVA: 0x21F2BF0 Offset: 0x21F1FF0 VA: 0x1821F2BF0 Slot: 6
	public override DbType get_DbType() { }

	// RVA: 0x7E8E20 Offset: 0x7E8220 VA: 0x1807E8E20 Slot: 7
	public override void set_DbType(DbType value) { }

	// RVA: 0x5CB140 Offset: 0x5CA540 VA: 0x1805CB140 Slot: 8
	public override ParameterDirection get_Direction() { }

	// RVA: 0x21F2CC0 Offset: 0x21F20C0 VA: 0x1821F2CC0 Slot: 9
	public override void set_Direction(ParameterDirection value) { }

	// RVA: 0x4A2EE0 Offset: 0x4A22E0 VA: 0x1804A2EE0 Slot: 12
	public override string get_ParameterName() { }

	// RVA: 0x4A2F10 Offset: 0x4A2310 VA: 0x1804A2F10 Slot: 13
	public override void set_ParameterName(string value) { }

	// RVA: 0xC53FC0 Offset: 0xC533C0 VA: 0x180C53FC0 Slot: 14
	public override void set_Size(int value) { }

	// RVA: 0x7CE230 Offset: 0x7CD630 VA: 0x1807CE230 Slot: 15
	public override string get_SourceColumn() { }

	// RVA: 0x7CE240 Offset: 0x7CD640 VA: 0x1807CE240 Slot: 16
	public override void set_SourceColumn(string value) { }

	// RVA: 0x21F2D20 Offset: 0x21F2120 VA: 0x1821F2D20 Slot: 17
	public override void set_SourceColumnNullMapping(bool value) { }

	// RVA: 0x4BE1F0 Offset: 0x4BD5F0 VA: 0x1804BE1F0 Slot: 18
	public override DataRowVersion get_SourceVersion() { }

	// RVA: 0x95B2E0 Offset: 0x95A6E0 VA: 0x18095B2E0 Slot: 19
	public override void set_SourceVersion(DataRowVersion value) { }

	// RVA: 0x497E00 Offset: 0x497200 VA: 0x180497E00 Slot: 20
	public override object get_Value() { }

	// RVA: 0x21F2D30 Offset: 0x21F2130 VA: 0x1821F2D30 Slot: 21
	public override void set_Value(object value) { }

	// RVA: 0x21F2610 Offset: 0x21F1A10 VA: 0x1821F2610 Slot: 22
	public object Clone() { }

}

public sealed class SqliteParameterCollection : DbParameterCollection // TypeDefIndex: 4892
{	// Fields
	private SqliteCommand _command; // 0x18
	private List<SqliteParameter> _parameterList; // 0x20
	private bool _unboundFlag; // 0x28

	// Properties
	public override bool IsFixedSize { get; }
	public override bool IsReadOnly { get; }
	public override object SyncRoot { get; }
	public override int Count { get; }
	public SqliteParameter Item { get; }

	// Methods

	// RVA: 0x21F24E0 Offset: 0x21F18E0 VA: 0x1821F24E0
	internal void .ctor(SqliteCommand cmd) { }

	// RVA: 0x498AD0 Offset: 0x497ED0 VA: 0x180498AD0 Slot: 22
	public override bool get_IsFixedSize() { }

	// RVA: 0x498AD0 Offset: 0x497ED0 VA: 0x180498AD0 Slot: 23
	public override bool get_IsReadOnly() { }

	// RVA: 0x513D80 Offset: 0x513180 VA: 0x180513D80 Slot: 24
	public override object get_SyncRoot() { }

	// RVA: 0x21F1C80 Offset: 0x21F1080 VA: 0x1821F1C80 Slot: 29
	public override IEnumerator GetEnumerator() { }

	// RVA: 0x21F1A80 Offset: 0x21F0E80 VA: 0x1821F1A80
	public int Add(SqliteParameter parameter) { }

	[EditorBrowsableAttribute] // RVA: 0x7D5E0 Offset: 0x7C9E0 VA: 0x18007D5E0
	// RVA: 0x21F1A10 Offset: 0x21F0E10 VA: 0x1821F1A10 Slot: 25
	public override int Add(object value) { }

	// RVA: 0x21F1930 Offset: 0x21F0D30 VA: 0x1821F1930
	public SqliteParameter AddWithValue(string parameterName, object value) { }

	// RVA: 0x21F1B60 Offset: 0x21F0F60 VA: 0x1821F1B60 Slot: 28
	public override void Clear() { }

	// RVA: 0x21F1BB0 Offset: 0x21F0FB0 VA: 0x1821F1BB0 Slot: 26
	public override bool Contains(object value) { }

	// RVA: 0x21F1C30 Offset: 0x21F1030 VA: 0x1821F1C30 Slot: 27
	public override void CopyTo(Array array, int index) { }

	// RVA: 0x21F2560 Offset: 0x21F1960 VA: 0x1821F2560 Slot: 21
	public override int get_Count() { }

	// RVA: 0x21F25A0 Offset: 0x21F19A0 VA: 0x1821F25A0
	public SqliteParameter get_Item(int index) { }

	// RVA: 0x21F1D00 Offset: 0x21F1100 VA: 0x1821F1D00 Slot: 30
	protected override DbParameter GetParameter(int index) { }

	// RVA: 0x21F1D60 Offset: 0x21F1160 VA: 0x1821F1D60 Slot: 32
	public override int IndexOf(string parameterName) { }

	// RVA: 0x21F1EA0 Offset: 0x21F12A0 VA: 0x1821F1EA0 Slot: 31
	public override int IndexOf(object value) { }

	// RVA: 0x21F1F20 Offset: 0x21F1320 VA: 0x1821F1F20 Slot: 33
	public override void Insert(int index, object value) { }

	// RVA: 0x21F23D0 Offset: 0x21F17D0 VA: 0x1821F23D0 Slot: 34
	public override void Remove(object value) { }

	// RVA: 0x21F2370 Offset: 0x21F1770 VA: 0x1821F2370 Slot: 35
	public override void RemoveAt(int index) { }

	// RVA: 0x21F2450 Offset: 0x21F1850 VA: 0x1821F2450 Slot: 36
	protected override void SetParameter(int index, DbParameter value) { }

	// RVA: 0x49D360 Offset: 0x49C760 VA: 0x18049D360
	internal void Unbind() { }

	// RVA: 0x21F1FB0 Offset: 0x21F13B0 VA: 0x1821F1FB0
	internal void MapParameters(SqliteStatement activeStatement) { }

}

internal sealed class SqliteStatement : IDisposable // TypeDefIndex: 4893
{	// Fields
	internal SQLiteBase _sql; // 0x10
	internal string _sqlStatement; // 0x18
	internal SqliteStatementHandle _sqlite_stmt; // 0x20
	internal int _unnamedParameters; // 0x28
	internal string[] _paramNames; // 0x30
	internal SqliteParameter[] _paramValues; // 0x38
	internal SqliteCommand _command; // 0x40
	private string[] _types; // 0x48

	// Properties
	internal string[] TypeDefinitions { get; }

	// Methods

	// RVA: 0x21F3AE0 Offset: 0x21F2EE0 VA: 0x1821F3AE0
	internal void .ctor(SQLiteBase sqlbase, SqliteStatementHandle stmt, string strCommand, SqliteStatement previous) { }

	// RVA: 0x21F3680 Offset: 0x21F2A80 VA: 0x1821F3680
	internal bool MapParameter(string s, SqliteParameter p) { }

	// RVA: 0x21F3600 Offset: 0x21F2A00 VA: 0x1821F3600 Slot: 4
	public void Dispose() { }

	// RVA: 0x21F3580 Offset: 0x21F2980 VA: 0x1821F3580
	internal void BindParameters() { }

	// RVA: 0x21F2FD0 Offset: 0x21F23D0 VA: 0x1821F2FD0
	private void BindParameter(int index, SqliteParameter param) { }

	// RVA: 0x5DCCA0 Offset: 0x5DC0A0 VA: 0x1805DCCA0
	internal string[] get_TypeDefinitions() { }

	// RVA: 0x21F3890 Offset: 0x21F2C90 VA: 0x1821F3890
	internal void SetTypes(string typedefs) { }

}

public sealed class SqliteTransaction : DbTransaction // TypeDefIndex: 4894
{	// Fields
	internal SqliteConnection _cnn; // 0x18
	internal long _version; // 0x20
	private IsolationLevel _level; // 0x28

	// Properties
	public SqliteConnection Connection { get; }

	// Methods

	// RVA: 0x21F4280 Offset: 0x21F3680 VA: 0x1821F4280
	internal void .ctor(SqliteConnection connection, bool deferredLock) { }

	// RVA: 0x21F3D30 Offset: 0x21F3130 VA: 0x1821F3D30 Slot: 7
	public override void Commit() { }

	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710
	public SqliteConnection get_Connection() { }

	// RVA: 0x21F3E80 Offset: 0x21F3280 VA: 0x1821F3E80 Slot: 8
	protected override void Dispose(bool disposing) { }

	// RVA: 0x21F4230 Offset: 0x21F3630 VA: 0x1821F4230 Slot: 9
	public override void Rollback() { }

	// RVA: 0x21F4120 Offset: 0x21F3520 VA: 0x1821F4120
	internal static void IssueRollback(SqliteConnection cnn) { }

	// RVA: 0x21F3FC0 Offset: 0x21F33C0 VA: 0x1821F3FC0
	internal bool IsValid(bool throwError) { }

}

internal class SqliteConnectionHandle : CriticalHandle // TypeDefIndex: 4897
{	// Properties
	public override bool IsInvalid { get; }

	// Methods

	// RVA: 0x691430 Offset: 0x690830 VA: 0x180691430
	public static IntPtr op_Implicit(SqliteConnectionHandle db) { }

	// RVA: 0x140C850 Offset: 0x140BC50 VA: 0x18140C850
	public static SqliteConnectionHandle op_Implicit(IntPtr db) { }

	// RVA: 0x140C7C0 Offset: 0x140BBC0 VA: 0x18140C7C0
	private void .ctor(IntPtr db) { }

	// RVA: 0x140C780 Offset: 0x140BB80 VA: 0x18140C780
	internal void .ctor() { }

	// RVA: 0x140C710 Offset: 0x140BB10 VA: 0x18140C710 Slot: 7
	protected override bool ReleaseHandle() { }

	// RVA: 0x140C810 Offset: 0x140BC10 VA: 0x18140C810 Slot: 5
	public override bool get_IsInvalid() { }

}

internal class SqliteStatementHandle : CriticalHandle // TypeDefIndex: 4898
{	// Properties
	public override bool IsInvalid { get; }

	// Methods

	// RVA: 0x691430 Offset: 0x690830 VA: 0x180691430
	public static IntPtr op_Implicit(SqliteStatementHandle stmt) { }

	// RVA: 0x21F2F50 Offset: 0x21F2350 VA: 0x1821F2F50
	public static SqliteStatementHandle op_Implicit(IntPtr stmt) { }

	// RVA: 0x21F2E80 Offset: 0x21F2280 VA: 0x1821F2E80
	private void .ctor(IntPtr stmt) { }

	// RVA: 0x21F2ED0 Offset: 0x21F22D0 VA: 0x1821F2ED0
	internal void .ctor() { }

	// RVA: 0x21F2E10 Offset: 0x21F2210 VA: 0x1821F2E10 Slot: 7
	protected override bool ReleaseHandle() { }

	// RVA: 0x21F2F10 Offset: 0x21F2310 VA: 0x1821F2F10 Slot: 5
	public override bool get_IsInvalid() { }

}

public class SqliteException : Exception // TypeDefIndex: 7360
{	// Methods

	// RVA: 0x2319C00 Offset: 0x2319000 VA: 0x182319C00
	public void .ctor(string message) { }

}

