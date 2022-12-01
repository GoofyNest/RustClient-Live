public struct RegisterEventOptions // TypeDefIndex: 9799
{
	[CompilerGeneratedAttribute]
	private uint <EventId>k__BackingField;
	[CompilerGeneratedAttribute]
	private Utf8String <EventName>k__BackingField;
	[CompilerGeneratedAttribute]
	private AntiCheatCommonEventType <EventType>k__BackingField;
	[CompilerGeneratedAttribute]
	private RegisterEventParamDef[] <ParamDefs>k__BackingField;

	public uint EventId { get; set; }
	public Utf8String EventName { get; set; }
	public AntiCheatCommonEventType EventType { get; set; }
	public RegisterEventParamDef[] ParamDefs { get; set; }


	[CompilerGeneratedAttribute]
	public uint get_EventId() { }

	[CompilerGeneratedAttribute]
	public void set_EventId(uint value) { }

	[CompilerGeneratedAttribute]
	public Utf8String get_EventName() { }

	[CompilerGeneratedAttribute]
	public void set_EventName(Utf8String value) { }

	[CompilerGeneratedAttribute]
	public AntiCheatCommonEventType get_EventType() { }

	[CompilerGeneratedAttribute]
	public void set_EventType(AntiCheatCommonEventType value) { }

	[CompilerGeneratedAttribute]
	public RegisterEventParamDef[] get_ParamDefs() { }

	[CompilerGeneratedAttribute]
	public void set_ParamDefs(RegisterEventParamDef[] value) { }

}

