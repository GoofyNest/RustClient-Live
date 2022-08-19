internal static class Interop // TypeDefIndex: 7359
{	// Fields
	internal const int SQLITE_OK = 0;
	internal const int SQLITE_ROW = 100;
	internal const int SQLITE_DONE = 101;
	internal const int SQLITE_INTEGER = 1;
	internal const int SQLITE_FLOAT = 2;
	internal const int SQLITE_TEXT = 3;
	internal const int SQLITE_BLOB = 4;
	internal const int SQLITE_NULL = 5;
	internal static IntPtr SQLITE_STATIC; // 0x0
	internal static IntPtr SQLITE_TRANSIENT; // 0x8

	// Methods

	// RVA: 0x2319990 Offset: 0x2318D90 VA: 0x182319990
	internal static extern int sqlite3_open(string filename, out IntPtr db) { }

	// RVA: 0x2319310 Offset: 0x2318710 VA: 0x182319310
	internal static extern int sqlite3_close(IntPtr db) { }

	// RVA: 0x2319880 Offset: 0x2318C80 VA: 0x182319880
	internal static extern int sqlite3_extended_result_codes(IntPtr db, int onoff) { }

	// RVA: 0x2319A30 Offset: 0x2318E30 VA: 0x182319A30
	internal static extern int sqlite3_prepare_v2(IntPtr db, string zSql, int nByte, out IntPtr ppStmpt, IntPtr pzTail) { }

	// RVA: 0x2319B80 Offset: 0x2318F80 VA: 0x182319B80
	internal static extern int sqlite3_step(IntPtr stmHandle) { }

	// RVA: 0x2319910 Offset: 0x2318D10 VA: 0x182319910
	internal static extern int sqlite3_finalize(IntPtr stmHandle) { }

	// RVA: 0x2319B00 Offset: 0x2318F00 VA: 0x182319B00
	internal static extern int sqlite3_reset(IntPtr stmHandle) { }

	// RVA: 0x2319800 Offset: 0x2318C00 VA: 0x182319800
	internal static extern IntPtr sqlite3_errmsg(IntPtr db) { }

	// RVA: 0x2319290 Offset: 0x2318690 VA: 0x182319290
	internal static extern int sqlite3_changes(IntPtr db) { }

	// RVA: 0x23194B0 Offset: 0x23188B0 VA: 0x1823194B0
	internal static extern int sqlite3_column_count(IntPtr stmHandle) { }

	// RVA: 0x2319650 Offset: 0x2318A50 VA: 0x182319650
	internal static extern IntPtr sqlite3_column_name(IntPtr stmHandle, int iCol) { }

	// RVA: 0x2319770 Offset: 0x2318B70 VA: 0x182319770
	internal static extern int sqlite3_column_type(IntPtr stmHandle, int iCol) { }

	// RVA: 0x23195C0 Offset: 0x23189C0 VA: 0x1823195C0
	internal static extern long sqlite3_column_int64(IntPtr stmHandle, int iCol) { }

	// RVA: 0x23196E0 Offset: 0x2318AE0 VA: 0x1823196E0
	internal static extern IntPtr sqlite3_column_text16(IntPtr stmHandle, int iCol) { }

	// RVA: 0x2319390 Offset: 0x2318790 VA: 0x182319390
	internal static extern IntPtr sqlite3_column_blob(IntPtr stmHandle, int iCol) { }

	// RVA: 0x2319420 Offset: 0x2318820 VA: 0x182319420
	internal static extern int sqlite3_column_bytes(IntPtr stmHandle, int iCol) { }

	// RVA: 0x2319530 Offset: 0x2318930 VA: 0x182319530
	internal static extern double sqlite3_column_double(IntPtr stmHandle, int iCol) { }

	// RVA: 0x23191E0 Offset: 0x23185E0 VA: 0x1823191E0
	internal static extern int sqlite3_bind_text16(IntPtr stmHandle, int i, IntPtr str, int len, IntPtr dest) { }

	// RVA: 0x23190B0 Offset: 0x23184B0 VA: 0x1823190B0
	internal static extern int sqlite3_bind_int64(IntPtr stmHandle, int i, long val) { }

	// RVA: 0x2318F60 Offset: 0x2318360 VA: 0x182318F60
	internal static extern int sqlite3_bind_blob(IntPtr stmHandle, int i, IntPtr str, int len, IntPtr dest) { }

	// RVA: 0x2319010 Offset: 0x2318410 VA: 0x182319010
	internal static extern int sqlite3_bind_double(IntPtr stmHandle, int i, double val) { }

	// RVA: 0x2319150 Offset: 0x2318550 VA: 0x182319150
	internal static extern int sqlite3_bind_null(IntPtr stmHandle, int i) { }

	// RVA: 0x2318E20 Offset: 0x2318220 VA: 0x182318E20
	public static string GetTypeName(int sqliteType) { }

	// RVA: 0x2318ED0 Offset: 0x23182D0 VA: 0x182318ED0
	private static void .cctor() { }

}

