internal struct RegisterEventOptionsInternal : ISettable<RegisterEventOptions>, IDisposable // TypeDefIndex: 9802
{
	private int m_ApiVersion;
	private uint m_EventId;
	private IntPtr m_EventName;
	private AntiCheatCommonEventType m_EventType;
	private uint m_ParamDefsCount;
	private IntPtr m_ParamDefs;

	public uint EventId { set; }
	public Utf8String EventName { set; }
	public AntiCheatCommonEventType EventType { set; }
	public RegisterEventParamDef[] ParamDefs { set; }


	public void set_EventId(uint value) { }

	public void set_EventName(Utf8String value) { }

	public void set_EventType(AntiCheatCommonEventType value) { }

	public void set_ParamDefs(RegisterEventParamDef[] value) { }

	public void Set(ref RegisterEventOptions other) { }

	public void Set(ref Nullable<RegisterEventOptions> other) { }

	public void Dispose() { }

}

