internal static class UnsafeNativeMethods.ManifestEtw // TypeDefIndex: 91
{
// Namespace: 
internal static class UnsafeNativeMethods.ManifestEtw // TypeDefIndex: 91
	// Methods

	// RVA: 0x1640E80 Offset: 0x1640280 VA: 0x181640E80
	internal static extern uint EventRegister(in Guid providerId, [In] UnsafeNativeMethods.ManifestEtw.EtwEnableCallback enableCallback, [In] void* callbackContext, ref long registrationHandle) { }

	// RVA: 0x1640FD0 Offset: 0x16403D0 VA: 0x181640FD0
	internal static extern uint EventUnregister([In] long registrationHandle) { }

	// RVA: 0x1641050 Offset: 0x1640450 VA: 0x181641050
	internal static int EventWriteTransferWrapper(long registrationHandle, ref EventDescriptor eventDescriptor, Guid* activityId, Guid* relatedActivityId, int userDataCount, EventProvider.EventData* userData) { }

	// RVA: 0x1641150 Offset: 0x1640550 VA: 0x181641150
	private static extern int EventWriteTransfer([In] long registrationHandle, in EventDescriptor eventDescriptor, [In] Guid* activityId, [In] Guid* relatedActivityId, [In] int userDataCount, [In] EventProvider.EventData* userData) { }

	// RVA: 0x1640DF0 Offset: 0x16401F0 VA: 0x181640DF0
	internal static extern int EventActivityIdControl([In] UnsafeNativeMethods.ManifestEtw.ActivityControl ControlCode, ref Guid ActivityId) { }

	// RVA: 0x1640F30 Offset: 0x1640330 VA: 0x181640F30
	internal static extern int EventSetInformation([In] long registrationHandle, [In] UnsafeNativeMethods.ManifestEtw.EVENT_INFO_CLASS informationClass, [In] void* eventInformation, [In] int informationLength) { }

	// RVA: 0x1640D30 Offset: 0x1640130 VA: 0x181640D30
	internal static extern int EnumerateTraceGuidsEx(UnsafeNativeMethods.ManifestEtw.TRACE_QUERY_INFO_CLASS TraceQueryInfoClass, void* InBuffer, int InBufferSize, void* OutBuffer, int OutBufferSize, ref int ReturnLength) { }

}

internal sealed class UnsafeNativeMethods.ManifestEtw.EtwEnableCallback : MulticastDelegate // TypeDefIndex: 92
{	// Methods

	// RVA: 0x4971F0 Offset: 0x4965F0 VA: 0x1804971F0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x16378D0 Offset: 0x1636CD0 VA: 0x1816378D0 Slot: 12
	public virtual void Invoke(in Guid sourceId, [In] int isEnabled, [In] byte level, [In] long matchAnyKeywords, [In] long matchAllKeywords, [In] UnsafeNativeMethods.ManifestEtw.EVENT_FILTER_DESCRIPTOR* filterData, [In] void* callbackContext) { }

	// RVA: 0x16377B0 Offset: 0x1636BB0 VA: 0x1816377B0 Slot: 13
	public virtual IAsyncResult BeginInvoke(in Guid sourceId, [In] int isEnabled, [In] byte level, [In] long matchAnyKeywords, [In] long matchAllKeywords, [In] UnsafeNativeMethods.ManifestEtw.EVENT_FILTER_DESCRIPTOR* filterData, [In] void* callbackContext, AsyncCallback callback, object object) { }

	// RVA: 0x16378B0 Offset: 0x1636CB0 VA: 0x1816378B0 Slot: 14
	public virtual void EndInvoke(in Guid sourceId, IAsyncResult result) { }

}

internal struct UnsafeNativeMethods.ManifestEtw.EVENT_FILTER_DESCRIPTOR // TypeDefIndex: 93
{	// Fields
	public long Ptr; // 0x0
	public int Size; // 0x8
	public int Type; // 0xC

}

internal enum UnsafeNativeMethods.ManifestEtw.ActivityControl // TypeDefIndex: 94
{	// Fields
	public uint value__; // 0x0
	public const UnsafeNativeMethods.ManifestEtw.ActivityControl EVENT_ACTIVITY_CTRL_GET_ID = 1;
	public const UnsafeNativeMethods.ManifestEtw.ActivityControl EVENT_ACTIVITY_CTRL_SET_ID = 2;
	public const UnsafeNativeMethods.ManifestEtw.ActivityControl EVENT_ACTIVITY_CTRL_CREATE_ID = 3;
	public const UnsafeNativeMethods.ManifestEtw.ActivityControl EVENT_ACTIVITY_CTRL_GET_SET_ID = 4;
	public const UnsafeNativeMethods.ManifestEtw.ActivityControl EVENT_ACTIVITY_CTRL_CREATE_SET_ID = 5;

}

internal enum UnsafeNativeMethods.ManifestEtw.EVENT_INFO_CLASS // TypeDefIndex: 95
{	// Fields
	public int value__; // 0x0
	public const UnsafeNativeMethods.ManifestEtw.EVENT_INFO_CLASS BinaryTrackInfo = 0;
	public const UnsafeNativeMethods.ManifestEtw.EVENT_INFO_CLASS SetEnableAllKeywords = 1;
	public const UnsafeNativeMethods.ManifestEtw.EVENT_INFO_CLASS SetTraits = 2;

}

internal enum UnsafeNativeMethods.ManifestEtw.TRACE_QUERY_INFO_CLASS // TypeDefIndex: 96
{	// Fields
	public int value__; // 0x0
	public const UnsafeNativeMethods.ManifestEtw.TRACE_QUERY_INFO_CLASS TraceGuidQueryList = 0;
	public const UnsafeNativeMethods.ManifestEtw.TRACE_QUERY_INFO_CLASS TraceGuidQueryInfo = 1;
	public const UnsafeNativeMethods.ManifestEtw.TRACE_QUERY_INFO_CLASS TraceGuidQueryProcess = 2;
	public const UnsafeNativeMethods.ManifestEtw.TRACE_QUERY_INFO_CLASS TraceStackTracingInfo = 3;
	public const UnsafeNativeMethods.ManifestEtw.TRACE_QUERY_INFO_CLASS MaxTraceSetInfoClass = 4;

}

internal struct UnsafeNativeMethods.ManifestEtw.TRACE_GUID_INFO // TypeDefIndex: 97
{	// Fields
	public int InstanceCount; // 0x0
	public int Reserved; // 0x4

}

internal struct UnsafeNativeMethods.ManifestEtw.TRACE_PROVIDER_INSTANCE_INFO // TypeDefIndex: 98
{	// Fields
	public int NextOffset; // 0x0
	public int EnableCount; // 0x4
	public int Pid; // 0x8
	public int Flags; // 0xC

}

internal struct UnsafeNativeMethods.ManifestEtw.TRACE_ENABLE_INFO // TypeDefIndex: 99
{	// Fields
	public int IsEnabled; // 0x0
	public byte Level; // 0x4
	public byte Reserved1; // 0x5
	public ushort LoggerId; // 0x6
	public int EnableProperty; // 0x8
	public int Reserved2; // 0xC
	public long MatchAnyKeyword; // 0x10
	public long MatchAllKeyword; // 0x18

}

internal static class UnsafeNativeMethods // TypeDefIndex: 4896
{	// Fields
	internal static readonly bool use_sqlite3_close_v2; // 0x0
	internal static readonly bool use_sqlite3_open_v2; // 0x1
	internal static readonly bool use_sqlite3_create_function_v2; // 0x2

	// Methods

	// RVA: 0x21F4490 Offset: 0x21F3890 VA: 0x1821F4490
	private static void .cctor() { }

	// RVA: 0x21F4DF0 Offset: 0x21F41F0 VA: 0x1821F4DF0
	internal static extern int sqlite3_close(IntPtr db) { }

	// RVA: 0x21F4E70 Offset: 0x21F4270 VA: 0x1821F4E70
	internal static extern int sqlite3_close_v2(IntPtr db) { }

	// RVA: 0x21F5A70 Offset: 0x21F4E70 VA: 0x1821F5A70
	internal static extern int sqlite3_create_function(IntPtr db, byte[] strName, int nArgs, int nType, IntPtr pvUser, SQLiteCallback func, SQLiteCallback fstep, SQLiteFinalCallback ffinal) { }

	// RVA: 0x21F5CB0 Offset: 0x21F50B0 VA: 0x1821F5CB0
	internal static extern int sqlite3_finalize(IntPtr stmt) { }

	// RVA: 0x21F6100 Offset: 0x21F5500 VA: 0x1821F6100
	internal static extern int sqlite3_open_v2(byte[] utf8Filename, out IntPtr db, int flags, IntPtr vfs) { }

	// RVA: 0x21F6060 Offset: 0x21F5460 VA: 0x1821F6060
	internal static extern int sqlite3_open(byte[] utf8Filename, out IntPtr db) { }

	// RVA: 0x21F5FC0 Offset: 0x21F53C0 VA: 0x1821F5FC0
	internal static extern int sqlite3_open16(string fileName, out IntPtr db) { }

	// RVA: 0x21F6270 Offset: 0x21F5670 VA: 0x1821F6270
	internal static extern int sqlite3_reset(IntPtr stmt) { }

	// RVA: 0x21F4AD0 Offset: 0x21F3ED0 VA: 0x1821F4AD0
	internal static extern IntPtr sqlite3_bind_parameter_name(IntPtr stmt, int index) { }

	// RVA: 0x21F5120 Offset: 0x21F4520 VA: 0x1821F5120
	internal static extern IntPtr sqlite3_column_database_name(IntPtr stmt, int index) { }

	// RVA: 0x21F5090 Offset: 0x21F4490 VA: 0x1821F5090
	internal static extern IntPtr sqlite3_column_database_name16(IntPtr stmt, int index) { }

	// RVA: 0x21F51B0 Offset: 0x21F45B0 VA: 0x1821F51B0
	internal static extern IntPtr sqlite3_column_decltype(IntPtr stmt, int index) { }

	// RVA: 0x21F5480 Offset: 0x21F4880 VA: 0x1821F5480
	internal static extern IntPtr sqlite3_column_name(IntPtr stmt, int index) { }

	// RVA: 0x21F53F0 Offset: 0x21F47F0 VA: 0x1821F53F0
	internal static extern IntPtr sqlite3_column_name16(IntPtr stmt, int index) { }

	// RVA: 0x21F55A0 Offset: 0x21F49A0 VA: 0x1821F55A0
	internal static extern IntPtr sqlite3_column_origin_name(IntPtr stmt, int index) { }

	// RVA: 0x21F5510 Offset: 0x21F4910 VA: 0x1821F5510
	internal static extern IntPtr sqlite3_column_origin_name16(IntPtr stmt, int index) { }

	// RVA: 0x21F56C0 Offset: 0x21F4AC0 VA: 0x1821F56C0
	internal static extern IntPtr sqlite3_column_table_name(IntPtr stmt, int index) { }

	// RVA: 0x21F5630 Offset: 0x21F4A30 VA: 0x1821F5630
	internal static extern IntPtr sqlite3_column_table_name16(IntPtr stmt, int index) { }

	// RVA: 0x21F57E0 Offset: 0x21F4BE0 VA: 0x1821F57E0
	internal static extern IntPtr sqlite3_column_text(IntPtr stmt, int index) { }

	// RVA: 0x21F5750 Offset: 0x21F4B50 VA: 0x1821F5750
	internal static extern IntPtr sqlite3_column_text16(IntPtr stmt, int index) { }

	// RVA: 0x21F5B70 Offset: 0x21F4F70 VA: 0x1821F5B70
	internal static extern IntPtr sqlite3_errmsg(IntPtr db) { }

	// RVA: 0x21F61B0 Offset: 0x21F55B0 VA: 0x1821F61B0
	internal static extern int sqlite3_prepare(IntPtr db, IntPtr pSql, int nBytes, out IntPtr stmt, out IntPtr ptrRemain) { }

	// RVA: 0x21F6900 Offset: 0x21F5D00 VA: 0x1821F6900
	internal static extern int sqlite3_table_column_metadata(IntPtr db, byte[] dbName, byte[] tblName, byte[] colName, out IntPtr ptrDataType, out IntPtr ptrCollSeq, out int notNull, out int primaryKey, out int autoInc) { }

	// RVA: 0x21F6D30 Offset: 0x21F6130 VA: 0x1821F6D30
	internal static extern IntPtr sqlite3_value_text(IntPtr p) { }

	// RVA: 0x21F6CB0 Offset: 0x21F60B0 VA: 0x1821F6CB0
	internal static extern IntPtr sqlite3_value_text16(IntPtr p) { }

	// RVA: 0x21F5E50 Offset: 0x21F5250 VA: 0x1821F5E50
	internal static extern IntPtr sqlite3_libversion() { }

	// RVA: 0x21F4D70 Offset: 0x21F4170 VA: 0x1821F4D70
	internal static extern int sqlite3_changes(IntPtr db) { }

	// RVA: 0x21F4CE0 Offset: 0x21F40E0 VA: 0x1821F4CE0
	internal static extern int sqlite3_busy_timeout(IntPtr db, int ms) { }

	// RVA: 0x21F4720 Offset: 0x21F3B20 VA: 0x1821F4720
	internal static extern int sqlite3_bind_blob(IntPtr stmt, int index, byte[] value, int nSize, IntPtr nTransient) { }

	// RVA: 0x21F47E0 Offset: 0x21F3BE0 VA: 0x1821F47E0
	internal static extern int sqlite3_bind_double(IntPtr stmt, int index, double value) { }

	// RVA: 0x21F4920 Offset: 0x21F3D20 VA: 0x1821F4920
	internal static extern int sqlite3_bind_int(IntPtr stmt, int index, int value) { }

	// RVA: 0x21F4880 Offset: 0x21F3C80 VA: 0x1821F4880
	internal static extern int sqlite3_bind_int64(IntPtr stmt, int index, long value) { }

	// RVA: 0x21F49C0 Offset: 0x21F3DC0 VA: 0x1821F49C0
	internal static extern int sqlite3_bind_null(IntPtr stmt, int index) { }

	// RVA: 0x21F4C20 Offset: 0x21F4020 VA: 0x1821F4C20
	internal static extern int sqlite3_bind_text(IntPtr stmt, int index, byte[] value, int nlen, IntPtr pvReserved) { }

	// RVA: 0x21F4A50 Offset: 0x21F3E50 VA: 0x1821F4A50
	internal static extern int sqlite3_bind_parameter_count(IntPtr stmt) { }

	// RVA: 0x21F5010 Offset: 0x21F4410 VA: 0x1821F5010
	internal static extern int sqlite3_column_count(IntPtr stmt) { }

	// RVA: 0x21F6880 Offset: 0x21F5C80 VA: 0x1821F6880
	internal static extern int sqlite3_step(IntPtr stmt) { }

	// RVA: 0x21F5240 Offset: 0x21F4640 VA: 0x1821F5240
	internal static extern double sqlite3_column_double(IntPtr stmt, int index) { }

	// RVA: 0x21F5360 Offset: 0x21F4760 VA: 0x1821F5360
	internal static extern int sqlite3_column_int(IntPtr stmt, int index) { }

	// RVA: 0x21F52D0 Offset: 0x21F46D0 VA: 0x1821F52D0
	internal static extern long sqlite3_column_int64(IntPtr stmt, int index) { }

	// RVA: 0x21F4EF0 Offset: 0x21F42F0 VA: 0x1821F4EF0
	internal static extern IntPtr sqlite3_column_blob(IntPtr stmt, int index) { }

	// RVA: 0x21F4F80 Offset: 0x21F4380 VA: 0x1821F4F80
	internal static extern int sqlite3_column_bytes(IntPtr stmt, int index) { }

	// RVA: 0x21F5870 Offset: 0x21F4C70 VA: 0x1821F5870
	internal static extern TypeAffinity sqlite3_column_type(IntPtr stmt, int index) { }

	// RVA: 0x21F59A0 Offset: 0x21F4DA0 VA: 0x1821F59A0
	internal static extern int sqlite3_create_collation(IntPtr db, byte[] strName, int nType, IntPtr pvUser, SQLiteCollation func) { }

	// RVA: 0x21F6AB0 Offset: 0x21F5EB0 VA: 0x1821F6AB0
	internal static extern IntPtr sqlite3_value_blob(IntPtr p) { }

	// RVA: 0x21F6B30 Offset: 0x21F5F30 VA: 0x1821F6B30
	internal static extern int sqlite3_value_bytes(IntPtr p) { }

	// RVA: 0x21F6BB0 Offset: 0x21F5FB0 VA: 0x1821F6BB0
	internal static extern double sqlite3_value_double(IntPtr p) { }

	// RVA: 0x21F6C30 Offset: 0x21F6030 VA: 0x1821F6C30
	internal static extern long sqlite3_value_int64(IntPtr p) { }

	// RVA: 0x21F6DB0 Offset: 0x21F61B0 VA: 0x1821F6DB0
	internal static extern TypeAffinity sqlite3_value_type(IntPtr p) { }

	// RVA: 0x21F62F0 Offset: 0x21F56F0 VA: 0x1821F62F0
	internal static extern void sqlite3_result_blob(IntPtr context, byte[] value, int nSize, IntPtr pvReserved) { }

	// RVA: 0x21F63A0 Offset: 0x21F57A0 VA: 0x1821F63A0
	internal static extern void sqlite3_result_double(IntPtr context, double value) { }

	// RVA: 0x21F64D0 Offset: 0x21F58D0 VA: 0x1821F64D0
	internal static extern void sqlite3_result_error(IntPtr context, byte[] strErr, int nLen) { }

	// RVA: 0x21F6570 Offset: 0x21F5970 VA: 0x1821F6570
	internal static extern void sqlite3_result_int64(IntPtr context, long value) { }

	// RVA: 0x21F6600 Offset: 0x21F5A00 VA: 0x1821F6600
	internal static extern void sqlite3_result_null(IntPtr context) { }

	// RVA: 0x21F6730 Offset: 0x21F5B30 VA: 0x1821F6730
	internal static extern void sqlite3_result_text(IntPtr context, byte[] value, int nLen, IntPtr pvReserved) { }

	// RVA: 0x21F4690 Offset: 0x21F3A90 VA: 0x1821F4690
	internal static extern IntPtr sqlite3_aggregate_context(IntPtr context, int nBytes) { }

	// RVA: 0x21F4B60 Offset: 0x21F3F60 VA: 0x1821F4B60
	internal static extern int sqlite3_bind_text16(IntPtr stmt, int index, string value, int nlen, IntPtr pvReserved) { }

	// RVA: 0x21F6430 Offset: 0x21F5830 VA: 0x1821F6430
	internal static extern void sqlite3_result_error16(IntPtr context, string strName, int nLen) { }

	// RVA: 0x21F6680 Offset: 0x21F5A80 VA: 0x1821F6680
	internal static extern void sqlite3_result_text16(IntPtr context, string strName, int nLen, IntPtr pvReserved) { }

	// RVA: 0x21F5DB0 Offset: 0x21F51B0 VA: 0x1821F5DB0
	internal static extern int sqlite3_key(IntPtr db, byte[] key, int keylen) { }

	// RVA: 0x21F6A10 Offset: 0x21F5E10 VA: 0x1821F6A10
	internal static extern IntPtr sqlite3_update_hook(IntPtr db, SQLiteUpdateCallback func, IntPtr pvUser) { }

	// RVA: 0x21F5900 Offset: 0x21F4D00 VA: 0x1821F5900
	internal static extern IntPtr sqlite3_commit_hook(IntPtr db, SQLiteCommitCallback func, IntPtr pvUser) { }

	// RVA: 0x21F67E0 Offset: 0x21F5BE0 VA: 0x1821F67E0
	internal static extern IntPtr sqlite3_rollback_hook(IntPtr db, SQLiteRollbackCallback func, IntPtr pvUser) { }

	// RVA: 0x21F5F30 Offset: 0x21F5330 VA: 0x1821F5F30
	internal static extern IntPtr sqlite3_next_stmt(IntPtr db, IntPtr stmt) { }

	// RVA: 0x21F5BF0 Offset: 0x21F4FF0 VA: 0x1821F5BF0
	internal static extern int sqlite3_exec(IntPtr db, byte[] strSql, IntPtr pvCallback, IntPtr pvParam, out IntPtr errMsg) { }

	// RVA: 0x21F5D30 Offset: 0x21F5130 VA: 0x1821F5D30
	internal static extern int sqlite3_free(IntPtr ptr) { }

	// RVA: 0x21F5EC0 Offset: 0x21F52C0 VA: 0x1821F5EC0
	internal static extern int sqlite3_libversion_number() { }

}

