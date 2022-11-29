public struct SendPlayerBehaviorReportOptions // TypeDefIndex: 8638
{
	[CompilerGeneratedAttribute] 
	private ProductUserId <ReporterUserId>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private ProductUserId <ReportedUserId>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private PlayerReportsCategory <Category>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private Utf8String <Message>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private Utf8String <Context>k__BackingField; 

	public ProductUserId ReporterUserId { get; set; }
	public ProductUserId ReportedUserId { get; set; }
	public PlayerReportsCategory Category { get; set; }
	public Utf8String Message { get; set; }
	public Utf8String Context { get; set; }


	[CompilerGeneratedAttribute] 
	public ProductUserId get_ReporterUserId() { }

	[CompilerGeneratedAttribute] 
	public void set_ReporterUserId(ProductUserId value) { }

	[CompilerGeneratedAttribute] 
	public ProductUserId get_ReportedUserId() { }

	[CompilerGeneratedAttribute] 
	public void set_ReportedUserId(ProductUserId value) { }

	[CompilerGeneratedAttribute] 
	public PlayerReportsCategory get_Category() { }

	[CompilerGeneratedAttribute] 
	public void set_Category(PlayerReportsCategory value) { }

	[CompilerGeneratedAttribute] 
	public Utf8String get_Message() { }

	[CompilerGeneratedAttribute] 
	public void set_Message(Utf8String value) { }

	[CompilerGeneratedAttribute] 
	public Utf8String get_Context() { }

	[CompilerGeneratedAttribute] 
	public void set_Context(Utf8String value) { }

}

