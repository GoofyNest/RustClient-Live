internal static class UnsafeNativeMethods.ManifestEtw // TypeDefIndex: 91
{

internal static class UnsafeNativeMethods.ManifestEtw 

internal static extern uint EventRegister(in Guid providerId, [In] UnsafeNativeMethods.ManifestEtw.EtwEnableCallback enableCallback, [In] void* callbackContext, ref long registrationHandle) { }

internal static extern uint EventUnregister([In] long registrationHandle) { }

internal static int EventWriteTransferWrapper(long registrationHandle, ref EventDescriptor eventDescriptor, Guid* activityId, Guid* relatedActivityId, int userDataCount, EventProvider.EventData* userData) { }

private static extern int EventWriteTransfer([In] long registrationHandle, in EventDescriptor eventDescriptor, [In] Guid* activityId, [In] Guid* relatedActivityId, [In] int userDataCount, [In] EventProvider.EventData* userData) { }

internal static extern int EventActivityIdControl([In] UnsafeNativeMethods.ManifestEtw.ActivityControl ControlCode, ref Guid ActivityId) { }

internal static extern int EventSetInformation([In] long registrationHandle, [In] UnsafeNativeMethods.ManifestEtw.EVENT_INFO_CLASS informationClass, [In] void* eventInformation, [In] int informationLength) { }

internal static extern int EnumerateTraceGuidsEx(UnsafeNativeMethods.ManifestEtw.TRACE_QUERY_INFO_CLASS TraceQueryInfoClass, void* InBuffer, int InBufferSize, void* OutBuffer, int OutBufferSize, ref int ReturnLength) { }

}

internal sealed class UnsafeNativeMethods.ManifestEtw.EtwEnableCallback : MulticastDelegate // TypeDefIndex: 92
{

public void .ctor(object object, IntPtr method) { }

public virtual void Invoke(in Guid sourceId, [In] int isEnabled, [In] byte level, [In] long matchAnyKeywords, [In] long matchAllKeywords, [In] UnsafeNativeMethods.ManifestEtw.EVENT_FILTER_DESCRIPTOR* filterData, [In] void* callbackContext) { }

public virtual IAsyncResult BeginInvoke(in Guid sourceId, [In] int isEnabled, [In] byte level, [In] long matchAnyKeywords, [In] long matchAllKeywords, [In] UnsafeNativeMethods.ManifestEtw.EVENT_FILTER_DESCRIPTOR* filterData, [In] void* callbackContext, AsyncCallback callback, object object) { }

public virtual void EndInvoke(in Guid sourceId, IAsyncResult result) { }

}

internal struct UnsafeNativeMethods.ManifestEtw.EVENT_FILTER_DESCRIPTOR // TypeDefIndex: 93
{
	public long Ptr; 
	public int Size; 
	public int Type; 

}

internal enum UnsafeNativeMethods.ManifestEtw.ActivityControl // TypeDefIndex: 94
{
	public uint value__; 
public const UnsafeNativeMethods.ManifestEtw.ActivityControl EVENT_ACTIVITY_CTRL_GET_ID = 1;
public const UnsafeNativeMethods.ManifestEtw.ActivityControl EVENT_ACTIVITY_CTRL_SET_ID = 2;
public const UnsafeNativeMethods.ManifestEtw.ActivityControl EVENT_ACTIVITY_CTRL_CREATE_ID = 3;
public const UnsafeNativeMethods.ManifestEtw.ActivityControl EVENT_ACTIVITY_CTRL_GET_SET_ID = 4;
public const UnsafeNativeMethods.ManifestEtw.ActivityControl EVENT_ACTIVITY_CTRL_CREATE_SET_ID = 5;

}

internal enum UnsafeNativeMethods.ManifestEtw.EVENT_INFO_CLASS // TypeDefIndex: 95
{
	public int value__; 
public const UnsafeNativeMethods.ManifestEtw.EVENT_INFO_CLASS BinaryTrackInfo = 0;
public const UnsafeNativeMethods.ManifestEtw.EVENT_INFO_CLASS SetEnableAllKeywords = 1;
public const UnsafeNativeMethods.ManifestEtw.EVENT_INFO_CLASS SetTraits = 2;

}

internal enum UnsafeNativeMethods.ManifestEtw.TRACE_QUERY_INFO_CLASS // TypeDefIndex: 96
{
	public int value__; 
public const UnsafeNativeMethods.ManifestEtw.TRACE_QUERY_INFO_CLASS TraceGuidQueryList = 0;
public const UnsafeNativeMethods.ManifestEtw.TRACE_QUERY_INFO_CLASS TraceGuidQueryInfo = 1;
public const UnsafeNativeMethods.ManifestEtw.TRACE_QUERY_INFO_CLASS TraceGuidQueryProcess = 2;
public const UnsafeNativeMethods.ManifestEtw.TRACE_QUERY_INFO_CLASS TraceStackTracingInfo = 3;
public const UnsafeNativeMethods.ManifestEtw.TRACE_QUERY_INFO_CLASS MaxTraceSetInfoClass = 4;

}

internal struct UnsafeNativeMethods.ManifestEtw.TRACE_GUID_INFO // TypeDefIndex: 97
{
	public int InstanceCount; 
	public int Reserved; 

}

internal struct UnsafeNativeMethods.ManifestEtw.TRACE_PROVIDER_INSTANCE_INFO // TypeDefIndex: 98
{
	public int NextOffset; 
	public int EnableCount; 
	public int Pid; 
	public int Flags; 

}

internal struct UnsafeNativeMethods.ManifestEtw.TRACE_ENABLE_INFO // TypeDefIndex: 99
{
	public int IsEnabled; 
	public byte Level; 
	public byte Reserved1; 
	public ushort LoggerId; 
	public int EnableProperty; 
	public int Reserved2; 
	public long MatchAnyKeyword; 
	public long MatchAllKeyword; 

}

internal static class UnsafeNativeMethods // TypeDefIndex: 4896
{
	internal static readonly bool use_sqlite3_close_v2; 
	internal static readonly bool use_sqlite3_open_v2; 
	internal static readonly bool use_sqlite3_create_function_v2; 


private static void .cctor() { }

internal static extern int sqlite3_close(IntPtr db) { }

internal static extern int sqlite3_close_v2(IntPtr db) { }

internal static extern int sqlite3_create_function(IntPtr db, byte[] strName, int nArgs, int nType, IntPtr pvUser, SQLiteCallback func, SQLiteCallback fstep, SQLiteFinalCallback ffinal) { }

internal static extern int sqlite3_finalize(IntPtr stmt) { }

internal static extern int sqlite3_open_v2(byte[] utf8Filename, out IntPtr db, int flags, IntPtr vfs) { }

internal static extern int sqlite3_open(byte[] utf8Filename, out IntPtr db) { }

internal static extern int sqlite3_open16(string fileName, out IntPtr db) { }

internal static extern int sqlite3_reset(IntPtr stmt) { }

internal static extern IntPtr sqlite3_bind_parameter_name(IntPtr stmt, int index) { }

internal static extern IntPtr sqlite3_column_database_name(IntPtr stmt, int index) { }

internal static extern IntPtr sqlite3_column_database_name16(IntPtr stmt, int index) { }

internal static extern IntPtr sqlite3_column_decltype(IntPtr stmt, int index) { }

internal static extern IntPtr sqlite3_column_name(IntPtr stmt, int index) { }

internal static extern IntPtr sqlite3_column_name16(IntPtr stmt, int index) { }

internal static extern IntPtr sqlite3_column_origin_name(IntPtr stmt, int index) { }

internal static extern IntPtr sqlite3_column_origin_name16(IntPtr stmt, int index) { }

internal static extern IntPtr sqlite3_column_table_name(IntPtr stmt, int index) { }

internal static extern IntPtr sqlite3_column_table_name16(IntPtr stmt, int index) { }

internal static extern IntPtr sqlite3_column_text(IntPtr stmt, int index) { }

internal static extern IntPtr sqlite3_column_text16(IntPtr stmt, int index) { }

internal static extern IntPtr sqlite3_errmsg(IntPtr db) { }

internal static extern int sqlite3_prepare(IntPtr db, IntPtr pSql, int nBytes, out IntPtr stmt, out IntPtr ptrRemain) { }

internal static extern int sqlite3_table_column_metadata(IntPtr db, byte[] dbName, byte[] tblName, byte[] colName, out IntPtr ptrDataType, out IntPtr ptrCollSeq, out int notNull, out int primaryKey, out int autoInc) { }

internal static extern IntPtr sqlite3_value_text(IntPtr p) { }

internal static extern IntPtr sqlite3_value_text16(IntPtr p) { }

internal static extern IntPtr sqlite3_libversion() { }

internal static extern int sqlite3_changes(IntPtr db) { }

internal static extern int sqlite3_busy_timeout(IntPtr db, int ms) { }

internal static extern int sqlite3_bind_blob(IntPtr stmt, int index, byte[] value, int nSize, IntPtr nTransient) { }

internal static extern int sqlite3_bind_double(IntPtr stmt, int index, double value) { }

internal static extern int sqlite3_bind_int(IntPtr stmt, int index, int value) { }

internal static extern int sqlite3_bind_int64(IntPtr stmt, int index, long value) { }

internal static extern int sqlite3_bind_null(IntPtr stmt, int index) { }

internal static extern int sqlite3_bind_text(IntPtr stmt, int index, byte[] value, int nlen, IntPtr pvReserved) { }

internal static extern int sqlite3_bind_parameter_count(IntPtr stmt) { }

internal static extern int sqlite3_column_count(IntPtr stmt) { }

internal static extern int sqlite3_step(IntPtr stmt) { }

internal static extern double sqlite3_column_double(IntPtr stmt, int index) { }

internal static extern int sqlite3_column_int(IntPtr stmt, int index) { }

internal static extern long sqlite3_column_int64(IntPtr stmt, int index) { }

internal static extern IntPtr sqlite3_column_blob(IntPtr stmt, int index) { }

internal static extern int sqlite3_column_bytes(IntPtr stmt, int index) { }

internal static extern TypeAffinity sqlite3_column_type(IntPtr stmt, int index) { }

internal static extern int sqlite3_create_collation(IntPtr db, byte[] strName, int nType, IntPtr pvUser, SQLiteCollation func) { }

internal static extern IntPtr sqlite3_value_blob(IntPtr p) { }

internal static extern int sqlite3_value_bytes(IntPtr p) { }

internal static extern double sqlite3_value_double(IntPtr p) { }

internal static extern long sqlite3_value_int64(IntPtr p) { }

internal static extern TypeAffinity sqlite3_value_type(IntPtr p) { }

internal static extern void sqlite3_result_blob(IntPtr context, byte[] value, int nSize, IntPtr pvReserved) { }

internal static extern void sqlite3_result_double(IntPtr context, double value) { }

internal static extern void sqlite3_result_error(IntPtr context, byte[] strErr, int nLen) { }

internal static extern void sqlite3_result_int64(IntPtr context, long value) { }

internal static extern void sqlite3_result_null(IntPtr context) { }

internal static extern void sqlite3_result_text(IntPtr context, byte[] value, int nLen, IntPtr pvReserved) { }

internal static extern IntPtr sqlite3_aggregate_context(IntPtr context, int nBytes) { }

internal static extern int sqlite3_bind_text16(IntPtr stmt, int index, string value, int nlen, IntPtr pvReserved) { }

internal static extern void sqlite3_result_error16(IntPtr context, string strName, int nLen) { }

internal static extern void sqlite3_result_text16(IntPtr context, string strName, int nLen, IntPtr pvReserved) { }

internal static extern int sqlite3_key(IntPtr db, byte[] key, int keylen) { }

internal static extern IntPtr sqlite3_update_hook(IntPtr db, SQLiteUpdateCallback func, IntPtr pvUser) { }

internal static extern IntPtr sqlite3_commit_hook(IntPtr db, SQLiteCommitCallback func, IntPtr pvUser) { }

internal static extern IntPtr sqlite3_rollback_hook(IntPtr db, SQLiteRollbackCallback func, IntPtr pvUser) { }

internal static extern IntPtr sqlite3_next_stmt(IntPtr db, IntPtr stmt) { }

internal static extern int sqlite3_exec(IntPtr db, byte[] strSql, IntPtr pvCallback, IntPtr pvParam, out IntPtr errMsg) { }

internal static extern int sqlite3_free(IntPtr ptr) { }

internal static extern int sqlite3_libversion_number() { }

}

