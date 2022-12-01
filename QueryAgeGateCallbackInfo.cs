public struct QueryAgeGateCallbackInfo : ICallbackInfo // TypeDefIndex: 9354
{
	[CompilerGeneratedAttribute]
	private Result <ResultCode>k__BackingField;
	[CompilerGeneratedAttribute]
	private object <ClientData>k__BackingField;
	[CompilerGeneratedAttribute]
	private Utf8String <CountryCode>k__BackingField;
	[CompilerGeneratedAttribute]
	private uint <AgeOfConsent>k__BackingField;

	public Result ResultCode { get; set; }
	public object ClientData { get; set; }
	public Utf8String CountryCode { get; set; }
	public uint AgeOfConsent { get; set; }


	[CompilerGeneratedAttribute]
	public Result get_ResultCode() { }

	[CompilerGeneratedAttribute]
	public void set_ResultCode(Result value) { }

	[CompilerGeneratedAttribute]
	public object get_ClientData() { }

	[CompilerGeneratedAttribute]
	public void set_ClientData(object value) { }

	[CompilerGeneratedAttribute]
	public Utf8String get_CountryCode() { }

	[CompilerGeneratedAttribute]
	public void set_CountryCode(Utf8String value) { }

	[CompilerGeneratedAttribute]
	public uint get_AgeOfConsent() { }

	[CompilerGeneratedAttribute]
	public void set_AgeOfConsent(uint value) { }

	public Nullable<Result> GetResultCode() { }

	internal void Set(ref QueryAgeGateCallbackInfoInternal other) { }

}

