internal struct RegisterEventParamDefInternal : IGettable<RegisterEventParamDef>, ISettable<RegisterEventParamDef>, IDisposable // TypeDefIndex: 9800
{
	private IntPtr m_ParamName; 
	private AntiCheatCommonEventParamType m_ParamType; 

	public Utf8String ParamName { get; set; }
	public AntiCheatCommonEventParamType ParamType { get; set; }


	public Utf8String get_ParamName() { }

	public void set_ParamName(Utf8String value) { }

	public AntiCheatCommonEventParamType get_ParamType() { }

	public void set_ParamType(AntiCheatCommonEventParamType value) { }

	public void Set(ref RegisterEventParamDef other) { }

	public void Set(ref Nullable<RegisterEventParamDef> other) { }

	public void Dispose() { }

	public void Get(out RegisterEventParamDef output) { }

}

