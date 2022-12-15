public struct LogEventParamPairParamValue // TypeDefIndex: 9771
{
	private AntiCheatCommonEventParamType m_ParamValueType;
	private Nullable<IntPtr> m_ClientHandle;
	private Utf8String m_String;
	private Nullable<uint> m_UInt32;
	private Nullable<int> m_Int32;
	private Nullable<ulong> m_UInt64;
	private Nullable<long> m_Int64;
	private Vec3f m_Vec3f;
	private Quat m_Quat;

	public AntiCheatCommonEventParamType ParamValueType { get; set; }
	public Nullable<IntPtr> ClientHandle { get; set; }
	public Utf8String String { get; set; }
	public Nullable<uint> UInt32 { get; set; }
	public Nullable<int> Int32 { get; set; }
	public Nullable<ulong> UInt64 { get; set; }
	public Nullable<long> Int64 { get; set; }
	public Vec3f Vec3f { get; set; }
	public Quat Quat { get; set; }


	public AntiCheatCommonEventParamType get_ParamValueType() { }

	private void set_ParamValueType(AntiCheatCommonEventParamType value) { }

	public Nullable<IntPtr> get_ClientHandle() { }

	public void set_ClientHandle(Nullable<IntPtr> value) { }

	public Utf8String get_String() { }

	public void set_String(Utf8String value) { }

	public Nullable<uint> get_UInt32() { }

	public void set_UInt32(Nullable<uint> value) { }

	public Nullable<int> get_Int32() { }

	public void set_Int32(Nullable<int> value) { }

	public Nullable<ulong> get_UInt64() { }

	public void set_UInt64(Nullable<ulong> value) { }

	public Nullable<long> get_Int64() { }

	public void set_Int64(Nullable<long> value) { }

	public Vec3f get_Vec3f() { }

	public void set_Vec3f(Vec3f value) { }

	public Quat get_Quat() { }

	public void set_Quat(Quat value) { }

	public static LogEventParamPairParamValue op_Implicit(IntPtr value) { }

	public static LogEventParamPairParamValue op_Implicit(Utf8String value) { }

	public static LogEventParamPairParamValue op_Implicit(string value) { }

	public static LogEventParamPairParamValue op_Implicit(uint value) { }

	public static LogEventParamPairParamValue op_Implicit(int value) { }

	public static LogEventParamPairParamValue op_Implicit(ulong value) { }

	public static LogEventParamPairParamValue op_Implicit(long value) { }

	public static LogEventParamPairParamValue op_Implicit(Vec3f value) { }

	public static LogEventParamPairParamValue op_Implicit(Quat value) { }

	internal void Set(ref LogEventParamPairParamValueInternal other) { }

}

