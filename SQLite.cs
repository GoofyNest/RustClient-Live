public sealed class SqliteConnection : DbConnection, ICloneable // TypeDefIndex: 4852
{

internal class <Module> 

public sealed class SqliteConnection : DbConnection, ICloneable 
	private ConnectionState _connectionState; 
	private string _connectionString; 
	internal int _transactionLevel; 
	private IsolationLevel _defaultIsolation; 
	internal SQLiteEnlistment _enlistment; 
	internal SQLiteBase _sql; 
	private string _dataSource; 
	private byte[] _password; 
	private int _defaultTimeout; 
	internal bool _binaryGuid; 
	internal long _version; 
	[CompilerGeneratedAttribute] 
	private SQLiteUpdateEventHandler _updateHandler; 
	[CompilerGeneratedAttribute] 
	private SQLiteCommitHandler _commitHandler; 
	[CompilerGeneratedAttribute] 
	private EventHandler _rollbackHandler; 
	private SQLiteUpdateCallback _updateCallback; 
	private SQLiteCommitCallback _commitCallback; 
	private SQLiteRollbackCallback _rollbackCallback; 
	[CompilerGeneratedAttribute] 
	private StateChangeEventHandler StateChange; 

	[EditorAttribute] 
	[RefreshPropertiesAttribute] 
	[DefaultValueAttribute] 
public override string ConnectionString { get; set; }
public int DefaultTimeout { get; }
	[BrowsableAttribute] 
	[DesignerSerializationVisibilityAttribute] 
public override ConnectionState State { get; }


public void .ctor() { }

public void .ctor(string connectionString) { }

public void .ctor(SqliteConnection connection) { }

public object Clone() { }

protected override void Dispose(bool disposing) { }

internal void OnStateChange(ConnectionState newState) { }

public SqliteTransaction BeginTransaction() { }

protected override DbTransaction BeginDbTransaction(IsolationLevel isolationLevel) { }

public override void Close() { }

public override string get_ConnectionString() { }

public override void set_ConnectionString(string value) { }

public SqliteCommand CreateCommand() { }

protected override DbCommand CreateDbCommand() { }

internal static void MapMonoKeyword(string[] arPiece, SortedList<string, string> ls) { }

internal static string MapMonoUriPath(string path) { }

internal static string MapUriPath(string path) { }

internal static SortedList<string, string> ParseConnectionString(string connectionString) { }

public override void EnlistTransaction(Transaction transaction) { }

internal static string FindKey(SortedList<string, string> items, string key, string defValue) { }

public override void Open() { }

public int get_DefaultTimeout() { }

public override ConnectionState get_State() { }

private string ExpandFileName(string sourceFile) { }

public override DataTable GetSchema(string collectionName) { }

public override DataTable GetSchema(string collectionName, string[] restrictionValues) { }

private static DataTable Schema_ReservedWords() { }

private static DataTable Schema_MetaDataCollections() { }

private DataTable Schema_DataSourceInformation() { }

private DataTable Schema_Columns(string strCatalog, string strTable, string strColumn) { }

private DataTable Schema_Indexes(string strCatalog, string strTable, string strIndex) { }

private DataTable Schema_Triggers(string catalog, string table, string triggerName) { }

private DataTable Schema_Tables(string strCatalog, string strTable, string strType) { }

private DataTable Schema_Views(string strCatalog, string strView) { }

private DataTable Schema_Catalogs(string strCatalog) { }

private DataTable Schema_DataTypes() { }

private DataTable Schema_IndexColumns(string strCatalog, string strTable, string strIndex, string strColumn) { }

private DataTable Schema_ViewColumns(string strCatalog, string strView, string strColumn) { }

private DataTable Schema_ForeignKeys(string strCatalog, string strTable, string strKeyName) { }

}

public sealed class SqliteFactory : DbProviderFactory, IServiceProvider // TypeDefIndex: 4853
{
	private static Type _dbProviderServicesType; 
	private static object _sqliteServices; 
	public static readonly SqliteFactory Instance; 


private static void .cctor() { }

private object System.IServiceProvider.GetService(Type serviceType) { }

private object GetSQLiteProviderServicesInstance() { }

public void .ctor() { }

}

internal class SQLite3 : SQLiteBase // TypeDefIndex: 4854
{
	protected SqliteConnectionHandle _sql; 
	protected string _fileName; 
	protected bool _usePool; 
	protected int _poolVersion; 
	private bool _buildingSchema; 
	protected SqliteFunction[] _functionsArray; 

internal override string Version { get; }
internal static string SQLiteVersion { get; }
internal override int Changes { get; }


internal void .ctor(SQLiteDateFormats fmt) { }

protected override void Dispose(bool bDisposing) { }

internal override void Close() { }

internal override string get_Version() { }

internal static string get_SQLiteVersion() { }

internal override int get_Changes() { }

internal override void Open(string strFilename, SQLiteOpenFlagsEnum flags, int maxPoolSize, bool usePool) { }

internal override void SetTimeout(int nTimeoutMS) { }

internal override bool Step(SqliteStatement stmt) { }

internal override int Reset(SqliteStatement stmt) { }

internal override string SQLiteLastError() { }

internal override SqliteStatement Prepare(SqliteConnection cnn, string strSql, SqliteStatement previous, uint timeoutMS, out string strRemain) { }

internal override void Bind_Double(SqliteStatement stmt, int index, double value) { }

internal override void Bind_Int32(SqliteStatement stmt, int index, int value) { }

internal override void Bind_Int64(SqliteStatement stmt, int index, long value) { }

internal override void Bind_Text(SqliteStatement stmt, int index, string value) { }

internal override void Bind_DateTime(SqliteStatement stmt, int index, DateTime dt) { }

internal override void Bind_Blob(SqliteStatement stmt, int index, byte[] blobData) { }

internal override void Bind_Null(SqliteStatement stmt, int index) { }

internal override int Bind_ParamCount(SqliteStatement stmt) { }

internal override string Bind_ParamName(SqliteStatement stmt, int index) { }

internal override int ColumnCount(SqliteStatement stmt) { }

internal override string ColumnName(SqliteStatement stmt, int index) { }

internal override TypeAffinity ColumnAffinity(SqliteStatement stmt, int index) { }

internal override string ColumnType(SqliteStatement stmt, int index, out TypeAffinity nAffinity) { }

internal override string ColumnOriginalName(SqliteStatement stmt, int index) { }

internal override string ColumnDatabaseName(SqliteStatement stmt, int index) { }

internal override string ColumnTableName(SqliteStatement stmt, int index) { }

internal override void ColumnMetaData(string dataBase, string table, string column, out string dataType, out string collateSequence, out bool notNull, out bool primaryKey, out bool autoIncrement) { }

internal override double GetDouble(SqliteStatement stmt, int index) { }

internal override int GetInt32(SqliteStatement stmt, int index) { }

internal override long GetInt64(SqliteStatement stmt, int index) { }

internal override string GetText(SqliteStatement stmt, int index) { }

internal override DateTime GetDateTime(SqliteStatement stmt, int index) { }

internal override long GetBytes(SqliteStatement stmt, int index, int nDataOffset, byte[] bDest, int nStart, int nLength) { }

internal override bool IsNull(SqliteStatement stmt, int index) { }

internal override void CreateFunction(string strFunction, int nArgs, bool needCollSeq, SQLiteCallback func, SQLiteCallback funcstep, SQLiteFinalCallback funcfinal) { }

internal override void CreateCollation(string strCollation, SQLiteCollation func, SQLiteCollation func16, IntPtr user_data) { }

internal override long GetParamValueBytes(IntPtr p, int nDataOffset, byte[] bDest, int nStart, int nLength) { }

internal override double GetParamValueDouble(IntPtr ptr) { }

internal override long GetParamValueInt64(IntPtr ptr) { }

internal override string GetParamValueText(IntPtr ptr) { }

internal override TypeAffinity GetParamValueType(IntPtr ptr) { }

internal override void ReturnBlob(IntPtr context, byte[] value) { }

internal override void ReturnDouble(IntPtr context, double value) { }

internal override void ReturnError(IntPtr context, string value) { }

internal override void ReturnInt64(IntPtr context, long value) { }

internal override void ReturnNull(IntPtr context) { }

internal override void ReturnText(IntPtr context, string value) { }

internal override IntPtr AggregateContext(IntPtr context) { }

internal override void SetPassword(byte[] passwordBytes) { }

internal override void SetUpdateHook(SQLiteUpdateCallback func) { }

internal override void SetCommitHook(SQLiteCommitCallback func) { }

internal override void SetRollbackHook(SQLiteRollbackCallback func) { }

internal override object GetValue(SqliteStatement stmt, int index, SQLiteType typ) { }

internal override int GetCursorForTable(SqliteStatement stmt, int db, int rootPage) { }

internal override long GetRowIdForCursor(SqliteStatement stmt, int cursor) { }

internal override void GetIndexColumnExtendedInfo(string database, string index, string column, out int sortMode, out int onError, out string collationSequence) { }

}

internal class SQLite3_UTF16 : SQLite3 // TypeDefIndex: 4855
{

internal void .ctor(SQLiteDateFormats fmt) { }

public override string ToString(IntPtr b, int nbytelen) { }

public static string UTF16ToString(IntPtr b, int nbytelen) { }

internal override void Open(string strFilename, SQLiteOpenFlagsEnum flags, int maxPoolSize, bool usePool) { }

internal override void Bind_DateTime(SqliteStatement stmt, int index, DateTime dt) { }

internal override void Bind_Text(SqliteStatement stmt, int index, string value) { }

internal override DateTime GetDateTime(SqliteStatement stmt, int index) { }

internal override string ColumnName(SqliteStatement stmt, int index) { }

internal override string GetText(SqliteStatement stmt, int index) { }

internal override string ColumnOriginalName(SqliteStatement stmt, int index) { }

internal override string ColumnDatabaseName(SqliteStatement stmt, int index) { }

internal override string ColumnTableName(SqliteStatement stmt, int index) { }

internal override string GetParamValueText(IntPtr ptr) { }

internal override void ReturnError(IntPtr context, string value) { }

internal override void ReturnText(IntPtr context, string value) { }

}

internal abstract class SQLiteBase : SqliteConvert, IDisposable // TypeDefIndex: 4856
{
	internal static object _lock; 

internal abstract string Version { get; }
internal abstract int Changes { get; }


internal void .ctor(SQLiteDateFormats fmt) { }

internal abstract string get_Version();

internal abstract int get_Changes();

internal abstract void Open(string strFilename, SQLiteOpenFlagsEnum flags, int maxPoolSize, bool usePool);

internal abstract void Close();

internal abstract void SetTimeout(int nTimeoutMS);

internal abstract string SQLiteLastError();

internal abstract SqliteStatement Prepare(SqliteConnection cnn, string strSql, SqliteStatement previous, uint timeoutMS, out string strRemain);

internal abstract bool Step(SqliteStatement stmt);

internal abstract int Reset(SqliteStatement stmt);

internal abstract void Bind_Double(SqliteStatement stmt, int index, double value);

internal abstract void Bind_Int32(SqliteStatement stmt, int index, int value);

internal abstract void Bind_Int64(SqliteStatement stmt, int index, long value);

internal abstract void Bind_Text(SqliteStatement stmt, int index, string value);

internal abstract void Bind_Blob(SqliteStatement stmt, int index, byte[] blobData);

internal abstract void Bind_DateTime(SqliteStatement stmt, int index, DateTime dt);

internal abstract void Bind_Null(SqliteStatement stmt, int index);

internal abstract int Bind_ParamCount(SqliteStatement stmt);

internal abstract string Bind_ParamName(SqliteStatement stmt, int index);

internal abstract int ColumnCount(SqliteStatement stmt);

internal abstract string ColumnName(SqliteStatement stmt, int index);

internal abstract TypeAffinity ColumnAffinity(SqliteStatement stmt, int index);

internal abstract string ColumnType(SqliteStatement stmt, int index, out TypeAffinity nAffinity);

internal abstract string ColumnOriginalName(SqliteStatement stmt, int index);

internal abstract string ColumnDatabaseName(SqliteStatement stmt, int index);

internal abstract string ColumnTableName(SqliteStatement stmt, int index);

internal abstract void ColumnMetaData(string dataBase, string table, string column, out string dataType, out string collateSequence, out bool notNull, out bool primaryKey, out bool autoIncrement);

internal abstract void GetIndexColumnExtendedInfo(string database, string index, string column, out int sortMode, out int onError, out string collationSequence);

internal abstract double GetDouble(SqliteStatement stmt, int index);

internal abstract int GetInt32(SqliteStatement stmt, int index);

internal abstract long GetInt64(SqliteStatement stmt, int index);

internal abstract string GetText(SqliteStatement stmt, int index);

internal abstract long GetBytes(SqliteStatement stmt, int index, int nDataoffset, byte[] bDest, int nStart, int nLength);

internal abstract DateTime GetDateTime(SqliteStatement stmt, int index);

internal abstract bool IsNull(SqliteStatement stmt, int index);

internal abstract void CreateCollation(string strCollation, SQLiteCollation func, SQLiteCollation func16, IntPtr user_data);

internal abstract void CreateFunction(string strFunction, int nArgs, bool needCollSeq, SQLiteCallback func, SQLiteCallback funcstep, SQLiteFinalCallback funcfinal);

internal abstract IntPtr AggregateContext(IntPtr context);

internal abstract long GetParamValueBytes(IntPtr ptr, int nDataOffset, byte[] bDest, int nStart, int nLength);

internal abstract double GetParamValueDouble(IntPtr ptr);

internal abstract long GetParamValueInt64(IntPtr ptr);

internal abstract string GetParamValueText(IntPtr ptr);

internal abstract TypeAffinity GetParamValueType(IntPtr ptr);

internal abstract void ReturnBlob(IntPtr context, byte[] value);

internal abstract void ReturnDouble(IntPtr context, double value);

internal abstract void ReturnError(IntPtr context, string value);

internal abstract void ReturnInt64(IntPtr context, long value);

internal abstract void ReturnNull(IntPtr context);

internal abstract void ReturnText(IntPtr context, string value);

internal abstract void SetPassword(byte[] passwordBytes);

internal abstract void SetUpdateHook(SQLiteUpdateCallback func);

internal abstract void SetCommitHook(SQLiteCommitCallback func);

internal abstract void SetRollbackHook(SQLiteRollbackCallback func);

internal abstract int GetCursorForTable(SqliteStatement stmt, int database, int rootPage);

internal abstract long GetRowIdForCursor(SqliteStatement stmt, int cursor);

internal abstract object GetValue(SqliteStatement stmt, int index, SQLiteType typ);

protected virtual void Dispose(bool bDisposing) { }

public void Dispose() { }

internal static string SQLiteLastError(SqliteConnectionHandle db) { }

internal static void FinalizeStatement(SqliteStatementHandle stmt) { }

internal static void CloseConnection(SqliteConnectionHandle db) { }

internal static void ResetConnection(SqliteConnectionHandle db) { }

private static void .cctor() { }

}

internal enum SQLiteOpenFlagsEnum // TypeDefIndex: 4858
{
	public int value__; 
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
{
	private string _commandText; 
	private SqliteConnection _cnn; 
	private long _version; 
	private WeakReference _activeReader; 
	internal int _commandTimeout; 
	private bool _designTimeVisible; 
	private UpdateRowSource _updateRowSource; 
	private SqliteParameterCollection _parameterCollection; 
	internal List<SqliteStatement> _statementList; 
	internal string _remainingText; 
	private SqliteTransaction _transaction; 

	[DefaultValueAttribute] 
	[RefreshPropertiesAttribute] 
	[EditorAttribute] 
public override string CommandText { get; set; }
	[DefaultValueAttribute] 
public override int CommandTimeout { get; set; }
	[DefaultValueAttribute] 
	[RefreshPropertiesAttribute] 
public override CommandType CommandType { set; }
	[EditorAttribute] 
	[DefaultValueAttribute] 
public SqliteConnection Connection { get; set; }
protected override DbConnection DbConnection { get; set; }
	[DesignerSerializationVisibilityAttribute] 
public SqliteParameterCollection Parameters { get; }
protected override DbParameterCollection DbParameterCollection { get; }
	[DesignerSerializationVisibilityAttribute] 
	[BrowsableAttribute] 
public SqliteTransaction Transaction { get; set; }
protected override DbTransaction DbTransaction { get; set; }
	[DefaultValueAttribute] 
public override UpdateRowSource UpdatedRowSource { get; set; }
	[DefaultValueAttribute] 
	[EditorBrowsableAttribute] 
	[BrowsableAttribute] 
	[DesignOnlyAttribute] 
public override bool DesignTimeVisible { get; set; }


public void .ctor(string commandText, SqliteConnection connection) { }

public void .ctor(SqliteConnection connection) { }

private void .ctor(SqliteCommand source) { }

public void .ctor(string commandText, SqliteConnection connection, SqliteTransaction transaction) { }

protected override void Dispose(bool disposing) { }

internal void ClearCommands() { }

internal SqliteStatement BuildNextCommand() { }

internal SqliteStatement GetStatement(int index) { }

public override string get_CommandText() { }

public override void set_CommandText(string value) { }

public override int get_CommandTimeout() { }

public override void set_CommandTimeout(int value) { }

public override void set_CommandType(CommandType value) { }

protected override DbParameter CreateDbParameter() { }

public SqliteParameter CreateParameter() { }

public SqliteConnection get_Connection() { }

public void set_Connection(SqliteConnection value) { }

protected override DbConnection get_DbConnection() { }

protected override void set_DbConnection(DbConnection value) { }

public SqliteParameterCollection get_Parameters() { }

protected override DbParameterCollection get_DbParameterCollection() { }

public SqliteTransaction get_Transaction() { }

public void set_Transaction(SqliteTransaction value) { }

protected override DbTransaction get_DbTransaction() { }

protected override void set_DbTransaction(DbTransaction value) { }

private void InitializeForReader() { }

protected override DbDataReader ExecuteDbDataReader(CommandBehavior behavior) { }

public SqliteDataReader ExecuteReader(CommandBehavior behavior) { }

public SqliteDataReader ExecuteReader() { }

internal void ClearDataReader() { }

public override int ExecuteNonQuery() { }

public override void Prepare() { }

public override UpdateRowSource get_UpdatedRowSource() { }

public override void set_UpdatedRowSource(UpdateRowSource value) { }

public override bool get_DesignTimeVisible() { }

public override void set_DesignTimeVisible(bool value) { }

public object Clone() { }

}

public sealed class SqliteCommandBuilder : DbCommandBuilder // TypeDefIndex: 4860
{
public SqliteDataAdapter DataAdapter { set; }
	[BrowsableAttribute] 
public override CatalogLocation CatalogLocation { get; }
	[BrowsableAttribute] 
public override string CatalogSeparator { get; }
	[DefaultValueAttribute] 
	[BrowsableAttribute] 
public override string QuotePrefix { get; set; }
	[BrowsableAttribute] 
public override string QuoteSuffix { get; set; }
	[BrowsableAttribute] 
public override string SchemaSeparator { get; }


public void .ctor() { }

public void .ctor(SqliteDataAdapter adp) { }

protected override void ApplyParameterInfo(DbParameter parameter, DataRow row, StatementType statementType, bool whereClause) { }

protected override string GetParameterName(string parameterName) { }

protected override string GetParameterName(int parameterOrdinal) { }

protected override string GetParameterPlaceholder(int parameterOrdinal) { }

protected override void SetRowUpdatingHandler(DbDataAdapter adapter) { }

private void RowUpdatingEventHandler(object sender, RowUpdatingEventArgs e) { }

public void set_DataAdapter(SqliteDataAdapter value) { }

public override CatalogLocation get_CatalogLocation() { }

public override string get_CatalogSeparator() { }

public override string get_QuotePrefix() { }

public override void set_QuotePrefix(string value) { }

public override string get_QuoteSuffix() { }

public override void set_QuoteSuffix(string value) { }

public override string QuoteIdentifier(string unquotedIdentifier) { }

public override string UnquoteIdentifier(string quotedIdentifier) { }

public override string get_SchemaSeparator() { }

protected override DataTable GetSchemaTable(DbCommand sourceCommand) { }

private bool HasSchemaPrimaryKey(DataTable schema) { }

private void ResetIsUniqueSchemaColumn(DataTable schema) { }

}

internal sealed class SQLiteUpdateCallback : MulticastDelegate // TypeDefIndex: 4861
{

public void .ctor(object object, IntPtr method) { }

public virtual void Invoke(IntPtr puser, int type, IntPtr database, IntPtr table, long rowid) { }

public virtual IAsyncResult BeginInvoke(IntPtr puser, int type, IntPtr database, IntPtr table, long rowid, AsyncCallback callback, object object) { }

public virtual void EndInvoke(IAsyncResult result) { }

}

internal sealed class SQLiteCommitCallback : MulticastDelegate // TypeDefIndex: 4862
{

public void .ctor(object object, IntPtr method) { }

public virtual int Invoke(IntPtr puser) { }

public virtual IAsyncResult BeginInvoke(IntPtr puser, AsyncCallback callback, object object) { }

public virtual int EndInvoke(IAsyncResult result) { }

}

internal sealed class SQLiteRollbackCallback : MulticastDelegate // TypeDefIndex: 4863
{

public void .ctor(object object, IntPtr method) { }

public virtual void Invoke(IntPtr puser) { }

public virtual IAsyncResult BeginInvoke(IntPtr puser, AsyncCallback callback, object object) { }

public virtual void EndInvoke(IAsyncResult result) { }

}

public sealed class SQLiteCommitHandler : MulticastDelegate // TypeDefIndex: 4864
{

public void .ctor(object object, IntPtr method) { }

public virtual void Invoke(object sender, CommitEventArgs e) { }

public virtual IAsyncResult BeginInvoke(object sender, CommitEventArgs e, AsyncCallback callback, object object) { }

public virtual void EndInvoke(IAsyncResult result) { }

}

public sealed class SQLiteUpdateEventHandler : MulticastDelegate // TypeDefIndex: 4865
{

public void .ctor(object object, IntPtr method) { }

public virtual void Invoke(object sender, UpdateEventArgs e) { }

public virtual IAsyncResult BeginInvoke(object sender, UpdateEventArgs e, AsyncCallback callback, object object) { }

public virtual void EndInvoke(IAsyncResult result) { }

}

internal static class SqliteConnectionPool // TypeDefIndex: 4868
{

public class CommitEventArgs : EventArgs 

internal static class SqliteConnectionPool 
	private static SortedList<string, SqliteConnectionPool.Pool> _connections; 
	private static int _poolVersion; 


internal static SqliteConnectionHandle Remove(string fileName, int maxPoolSize, out int version) { }

internal static void Add(string fileName, SqliteConnectionHandle hdl, int version) { }

private static void ResizePool(SqliteConnectionPool.Pool queue, bool forAdding) { }

private static void .cctor() { }

}

internal class SqliteConnectionPool.Pool // TypeDefIndex: 4869
{
	internal readonly Queue<WeakReference> Queue; 
	internal int PoolVersion; 
	internal int MaxPoolSize; 


internal void .ctor(int version, int maxSize) { }

}

public abstract class SqliteConvert // TypeDefIndex: 4870
{
	protected static readonly DateTime UnixEpoch; 
	private static string[] _datetimeFormats; 
	private static Encoding _utf8; 
	internal SQLiteDateFormats _datetimeFormat; 
	private static Type[] _affinitytotype; 
	private static DbType[] _typetodbtype; 
	private static int[] _dbtypetocolumnsize; 
	private static object[] _dbtypetonumericprecision; 
	private static object[] _dbtypetonumericscale; 
	private static SQLiteTypeNames[] _dbtypeNames; 
	private static Type[] _dbtypeToType; 
	private static TypeAffinity[] _typecodeAffinities; 
	private static SQLiteTypeNames[] _typeNames; 


internal void .ctor(SQLiteDateFormats fmt) { }

public static byte[] ToUTF8(string sourceText) { }

public byte[] ToUTF8(DateTime dateTimeValue) { }

public virtual string ToString(IntPtr nativestring, int nativestringlen) { }

public static string UTF8ToString(IntPtr nativestring, int nativestringlen) { }

public DateTime ToDateTime(string dateText) { }

public DateTime ToDateTime(double julianDay) { }

public double ToJulianDay(DateTime value) { }

public string ToString(DateTime dateValue) { }

internal DateTime ToDateTime(IntPtr ptr, int len) { }

public static string[] Split(string source, char separator) { }

public static bool ToBoolean(string source) { }

internal static Type SQLiteTypeToType(SQLiteType t) { }

internal static DbType TypeToDbType(Type typ) { }

internal static int DbTypeToColumnSize(DbType typ) { }

internal static object DbTypeToNumericPrecision(DbType typ) { }

internal static object DbTypeToNumericScale(DbType typ) { }

internal static string DbTypeToTypeName(DbType typ) { }

internal static Type DbTypeToType(DbType typ) { }

internal static TypeAffinity TypeToAffinity(Type typ) { }

internal static DbType TypeNameToDbType(string Name) { }

private static void .cctor() { }

}

public enum SQLiteDateFormats // TypeDefIndex: 4872
{
	public int value__; 
public const SQLiteDateFormats Ticks = 0;
public const SQLiteDateFormats ISO8601 = 1;
public const SQLiteDateFormats JulianDay = 2;
public const SQLiteDateFormats UnixEpoch = 3;

}

internal class SQLiteType // TypeDefIndex: 4873
{
	internal DbType Type; 
	internal TypeAffinity Affinity; 


public void .ctor() { }

}

internal struct SQLiteTypeNames // TypeDefIndex: 4874
{
	internal string typeName; 
	internal DbType dataType; 


internal void .ctor(string newtypeName, DbType newdataType) { }

}

public sealed class SqliteDataAdapter : DbDataAdapter // TypeDefIndex: 4875
{
	private static object _updatingEventPH; 
	private static object _updatedEventPH; 


public void add_RowUpdating(EventHandler<RowUpdatingEventArgs> value) { }

public void remove_RowUpdating(EventHandler<RowUpdatingEventArgs> value) { }

internal static Delegate FindBuilder(MulticastDelegate mcd) { }

private static void .cctor() { }

}

public sealed class SqliteDataReader : DbDataReader // TypeDefIndex: 4876
{
	private SqliteCommand _command; 
	private int _activeStatementIndex; 
	private SqliteStatement _activeStatement; 
	private int _readingState; 
	private int _rowsAffected; 
	private int _fieldCount; 
	private SQLiteType[] _fieldTypeArray; 
	private CommandBehavior _commandBehavior; 
	internal bool _disposeCommand; 
	private SqliteKeyReader _keyInfo; 
	internal long _version; 
	private static bool hasColumnMetadataSupport; 

public override int FieldCount { get; }
public override int VisibleFieldCount { get; }
public override int RecordsAffected { get; }
public override object Item { get; }


internal void .ctor(SqliteCommand cmd, CommandBehavior behave) { }

public override void Close() { }

private void CheckClosed() { }

private void CheckValidRow() { }

public override IEnumerator GetEnumerator() { }

public override int get_FieldCount() { }

public override int get_VisibleFieldCount() { }

private TypeAffinity VerifyType(int i, DbType typ) { }

public override bool GetBoolean(int i) { }

public override string GetDataTypeName(int i) { }

public override Type GetFieldType(int i) { }

public override int GetInt32(int i) { }

public override long GetInt64(int i) { }

public override string GetName(int i) { }

public override DataTable GetSchemaTable() { }

internal DataTable GetSchemaTable(bool wantUniqueInfo, bool wantDefaultValue) { }

public override string GetString(int i) { }

public override object GetValue(int i) { }

public override int GetValues(object[] values) { }

public override bool IsDBNull(int i) { }

public override bool NextResult() { }

private SQLiteType GetSQLiteType(int i) { }

public override bool Read() { }

public override int get_RecordsAffected() { }

public override object get_Item(int i) { }

private void LoadKeyInfo() { }

private static void .cctor() { }

}

internal class SQLiteEnlistment : IEnlistmentNotification // TypeDefIndex: 4877
{
	internal SqliteTransaction _transaction; 
	internal Transaction _scope; 
	internal bool _disposeConnection; 


internal void .ctor(SqliteConnection cnn, Transaction scope) { }

private void Cleanup(SqliteConnection cnn) { }

public void Rollback(Enlistment enlistment) { }

}

public sealed class SqliteException : DbException // TypeDefIndex: 4878
{
	private SQLiteErrorCode _errorCode; 
	private static string[] _errorMessages; 


private void .ctor(SerializationInfo info, StreamingContext context) { }

public void .ctor(int errorCode, string extendedInformation) { }

public void .ctor() { }

private static string GetStockErrorMessage(int errorCode, string errorMessage) { }

private static void .cctor() { }

}

public enum SQLiteErrorCode // TypeDefIndex: 4879
{
	public int value__; 
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
{
	internal SQLiteBase _base; 
	private Dictionary<long, SqliteFunction.AggregateData> _contextDataList; 
	private SQLiteCallback _InvokeFunc; 
	private SQLiteCallback _StepFunc; 
	private SQLiteFinalCallback _FinalFunc; 
	private SQLiteCollation _CompareFunc; 
	private SQLiteCollation _CompareFunc16; 
	internal IntPtr _context; 
	private static List<SqliteFunctionAttribute> _registeredFunctions; 


public virtual object Invoke(object[] args) { }

public virtual void Step(object[] args, int stepNumber, ref object contextData) { }

public virtual object Final(object contextData) { }

public virtual int Compare(string param1, string param2) { }

internal object[] ConvertParams(int nArgs, IntPtr argsptr) { }

private void SetReturnValue(IntPtr context, object returnValue) { }

internal void ScalarCallback(IntPtr context, int nArgs, IntPtr argsptr) { }

internal int CompareCallback(IntPtr ptr, int len1, IntPtr ptr1, int len2, IntPtr ptr2) { }

internal int CompareCallback16(IntPtr ptr, int len1, IntPtr ptr1, int len2, IntPtr ptr2) { }

internal void StepCallback(IntPtr context, int nArgs, IntPtr argsptr) { }

internal void FinalCallback(IntPtr context) { }

private static void .cctor() { }

internal static SqliteFunction[] BindFunctions(SQLiteBase sqlbase) { }

}

private class SqliteFunction.AggregateData // TypeDefIndex: 4881
{
	internal int _count; 
	internal object _data; 


public void .ctor() { }

}

internal sealed class SQLiteCallback : MulticastDelegate // TypeDefIndex: 4884
{

public void .ctor(object object, IntPtr method) { }

public virtual void Invoke(IntPtr context, int nArgs, IntPtr argsptr) { }

public virtual IAsyncResult BeginInvoke(IntPtr context, int nArgs, IntPtr argsptr, AsyncCallback callback, object object) { }

public virtual void EndInvoke(IAsyncResult result) { }

}

internal sealed class SQLiteFinalCallback : MulticastDelegate // TypeDefIndex: 4885
{

public void .ctor(object object, IntPtr method) { }

public virtual void Invoke(IntPtr context) { }

public virtual IAsyncResult BeginInvoke(IntPtr context, AsyncCallback callback, object object) { }

public virtual void EndInvoke(IAsyncResult result) { }

}

internal sealed class SQLiteCollation : MulticastDelegate // TypeDefIndex: 4886
{

public void .ctor(object object, IntPtr method) { }

public virtual int Invoke(IntPtr puser, int len1, IntPtr pv1, int len2, IntPtr pv2) { }

public virtual IAsyncResult BeginInvoke(IntPtr puser, int len1, IntPtr pv1, int len2, IntPtr pv2, AsyncCallback callback, object object) { }

public virtual int EndInvoke(IAsyncResult result) { }

}

public sealed class SqliteFunctionAttribute : Attribute // TypeDefIndex: 4887
{
	private string _name; 
	private int _arguments; 
	private FunctionType _functionType; 
	internal Type _instanceType; 

public string Name { get; }
public int Arguments { get; }
public FunctionType FuncType { get; }


public string get_Name() { }

public int get_Arguments() { }

public FunctionType get_FuncType() { }

}

internal sealed class SqliteKeyReader : IDisposable // TypeDefIndex: 4888
{
	private SqliteKeyReader.KeyInfo[] _keyInfo; 
	private SqliteStatement _stmt; 
	private bool _isValid; 

internal int Count { get; }


internal void .ctor(SqliteConnection cnn, SqliteDataReader reader, SqliteStatement stmt) { }

internal int get_Count() { }

internal void Sync(int i) { }

internal void Sync() { }

internal void Reset() { }

public void Dispose() { }

internal string GetDataTypeName(int i) { }

internal Type GetFieldType(int i) { }

internal string GetName(int i) { }

internal bool GetBoolean(int i) { }

internal int GetInt32(int i) { }

internal long GetInt64(int i) { }

internal string GetString(int i) { }

internal object GetValue(int i) { }

internal bool IsDBNull(int i) { }

internal void AppendSchemaTable(DataTable tbl) { }

}

private struct SqliteKeyReader.KeyInfo // TypeDefIndex: 4889
{
	internal string databaseName; 
	internal string tableName; 
	internal string columnName; 
	internal int database; 
	internal int rootPage; 
	internal int cursor; 
	internal SqliteKeyReader.KeyQuery query; 
	internal int column; 

}

private sealed class SqliteKeyReader.KeyQuery : IDisposable // TypeDefIndex: 4890
{
	private SqliteCommand _command; 
	internal SqliteDataReader _reader; 

internal bool IsValid { set; }


internal void .ctor(SqliteConnection cnn, string database, string table, string[] columns) { }

internal void set_IsValid(bool value) { }

internal void Sync(long rowid) { }

public void Dispose() { }

}

public sealed class SqliteParameter : DbParameter, ICloneable // TypeDefIndex: 4891
{
	internal int _dbType; 
	private DataRowVersion _rowVersion; 
	private object _objValue; 
	private string _sourceColumn; 
	private string _parameterName; 
	private int _dataSize; 
	private bool _nullable; 
	private bool _nullMapping; 

public override bool IsNullable { get; set; }
	[RefreshPropertiesAttribute] 
	[DbProviderSpecificTypePropertyAttribute] 
public override DbType DbType { get; set; }
public override ParameterDirection Direction { get; set; }
public override string ParameterName { get; set; }
	[DefaultValueAttribute] 
public override int Size { set; }
public override string SourceColumn { get; set; }
public override bool SourceColumnNullMapping { set; }
public override DataRowVersion SourceVersion { get; set; }
	[TypeConverterAttribute] 
	[RefreshPropertiesAttribute] 
public override object Value { get; set; }


public void .ctor() { }

public void .ctor(string parameterName, object value) { }

public void .ctor(string parameterName, DbType parameterType, int parameterSize, string sourceColumn, DataRowVersion rowVersion) { }

private void .ctor(SqliteParameter source) { }

	[EditorBrowsableAttribute] 
public void .ctor(string parameterName, DbType parameterType, int parameterSize, ParameterDirection direction, bool isNullable, byte precision, byte scale, string sourceColumn, DataRowVersion rowVersion, object value) { }

public override bool get_IsNullable() { }

public override void set_IsNullable(bool value) { }

public override DbType get_DbType() { }

public override void set_DbType(DbType value) { }

public override ParameterDirection get_Direction() { }

public override void set_Direction(ParameterDirection value) { }

public override string get_ParameterName() { }

public override void set_ParameterName(string value) { }

public override void set_Size(int value) { }

public override string get_SourceColumn() { }

public override void set_SourceColumn(string value) { }

public override void set_SourceColumnNullMapping(bool value) { }

public override DataRowVersion get_SourceVersion() { }

public override void set_SourceVersion(DataRowVersion value) { }

public override object get_Value() { }

public override void set_Value(object value) { }

public object Clone() { }

}

public sealed class SqliteParameterCollection : DbParameterCollection // TypeDefIndex: 4892
{
	private SqliteCommand _command; 
	private List<SqliteParameter> _parameterList; 
	private bool _unboundFlag; 

public override bool IsFixedSize { get; }
public override bool IsReadOnly { get; }
public override object SyncRoot { get; }
public override int Count { get; }
public SqliteParameter Item { get; }


internal void .ctor(SqliteCommand cmd) { }

public override bool get_IsFixedSize() { }

public override bool get_IsReadOnly() { }

public override object get_SyncRoot() { }

public override IEnumerator GetEnumerator() { }

public int Add(SqliteParameter parameter) { }

	[EditorBrowsableAttribute] 
public override int Add(object value) { }

public SqliteParameter AddWithValue(string parameterName, object value) { }

public override void Clear() { }

public override bool Contains(object value) { }

public override void CopyTo(Array array, int index) { }

public override int get_Count() { }

public SqliteParameter get_Item(int index) { }

protected override DbParameter GetParameter(int index) { }

public override int IndexOf(string parameterName) { }

public override int IndexOf(object value) { }

public override void Insert(int index, object value) { }

public override void Remove(object value) { }

public override void RemoveAt(int index) { }

protected override void SetParameter(int index, DbParameter value) { }

internal void Unbind() { }

internal void MapParameters(SqliteStatement activeStatement) { }

}

internal sealed class SqliteStatement : IDisposable // TypeDefIndex: 4893
{
	internal SQLiteBase _sql; 
	internal string _sqlStatement; 
	internal SqliteStatementHandle _sqlite_stmt; 
	internal int _unnamedParameters; 
	internal string[] _paramNames; 
	internal SqliteParameter[] _paramValues; 
	internal SqliteCommand _command; 
	private string[] _types; 

internal string[] TypeDefinitions { get; }


internal void .ctor(SQLiteBase sqlbase, SqliteStatementHandle stmt, string strCommand, SqliteStatement previous) { }

internal bool MapParameter(string s, SqliteParameter p) { }

public void Dispose() { }

internal void BindParameters() { }

private void BindParameter(int index, SqliteParameter param) { }

internal string[] get_TypeDefinitions() { }

internal void SetTypes(string typedefs) { }

}

public sealed class SqliteTransaction : DbTransaction // TypeDefIndex: 4894
{
	internal SqliteConnection _cnn; 
	internal long _version; 
	private IsolationLevel _level; 

public SqliteConnection Connection { get; }


internal void .ctor(SqliteConnection connection, bool deferredLock) { }

public override void Commit() { }

public SqliteConnection get_Connection() { }

protected override void Dispose(bool disposing) { }

public override void Rollback() { }

internal static void IssueRollback(SqliteConnection cnn) { }

internal bool IsValid(bool throwError) { }

}

internal class SqliteConnectionHandle : CriticalHandle // TypeDefIndex: 4897
{
public override bool IsInvalid { get; }


public static IntPtr op_Implicit(SqliteConnectionHandle db) { }

public static SqliteConnectionHandle op_Implicit(IntPtr db) { }

private void .ctor(IntPtr db) { }

internal void .ctor() { }

protected override bool ReleaseHandle() { }

public override bool get_IsInvalid() { }

}

internal class SqliteStatementHandle : CriticalHandle // TypeDefIndex: 4898
{
public override bool IsInvalid { get; }


public static IntPtr op_Implicit(SqliteStatementHandle stmt) { }

public static SqliteStatementHandle op_Implicit(IntPtr stmt) { }

private void .ctor(IntPtr stmt) { }

internal void .ctor() { }

protected override bool ReleaseHandle() { }

public override bool get_IsInvalid() { }

}

public class SqliteException : Exception // TypeDefIndex: 7360
{

public void .ctor(string message) { }

}

