internal struct LogEventParamPairParamValueInternal : IGettable<LogEventParamPairParamValue>, ISettable<LogEventParamPairParamValue>, IDisposable // TypeDefIndex: 9724
{
	private AntiCheatCommonEventParamType m_ParamValueType; 
	private IntPtr m_ClientHandle; 
	private IntPtr m_String; 
	private uint m_UInt32; 
	private int m_Int32; 
	private ulong m_UInt64; 
	private long m_Int64; 
	private Vec3fInternal m_Vec3f; 
	private QuatInternal m_Quat; 

	public Nullable<IntPtr> ClientHandle { get; set; }
	public Utf8String String { get; set; }
	public Nullable<uint> UInt32 { get; set; }
	public Nullable<int> Int32 { get; set; }
	public Nullable<ulong> UInt64 { get; set; }
	public Nullable<long> Int64 { get; set; }
	public Vec3f Vec3f { get; set; }
	public Quat Quat { get; set; }


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

	public void Set(ref LogEventParamPairParamValue other) { }

	public void Set(ref Nullable<LogEventParamPairParamValue> other) { }

	public void Dispose() { }

	public void Get(out LogEventParamPairParamValue output) { }

}

