public struct QueryLeaderboardUserScoresOptions // TypeDefIndex: 9274
{
	[CompilerGeneratedAttribute] 
	private ProductUserId[] <UserIds>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private UserScoresQueryStatInfo[] <StatInfo>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private Nullable<DateTimeOffset> <StartTime>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private Nullable<DateTimeOffset> <EndTime>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private ProductUserId <LocalUserId>k__BackingField; 

	public ProductUserId[] UserIds { get; set; }
	public UserScoresQueryStatInfo[] StatInfo { get; set; }
	public Nullable<DateTimeOffset> StartTime { get; set; }
	public Nullable<DateTimeOffset> EndTime { get; set; }
	public ProductUserId LocalUserId { get; set; }


	[CompilerGeneratedAttribute] 
	public ProductUserId[] get_UserIds() { }

	[CompilerGeneratedAttribute] 
	public void set_UserIds(ProductUserId[] value) { }

	[CompilerGeneratedAttribute] 
	public UserScoresQueryStatInfo[] get_StatInfo() { }

	[CompilerGeneratedAttribute] 
	public void set_StatInfo(UserScoresQueryStatInfo[] value) { }

	[CompilerGeneratedAttribute] 
	public Nullable<DateTimeOffset> get_StartTime() { }

	[CompilerGeneratedAttribute] 
	public void set_StartTime(Nullable<DateTimeOffset> value) { }

	[CompilerGeneratedAttribute] 
	public Nullable<DateTimeOffset> get_EndTime() { }

	[CompilerGeneratedAttribute] 
	public void set_EndTime(Nullable<DateTimeOffset> value) { }

	[CompilerGeneratedAttribute] 
	public ProductUserId get_LocalUserId() { }

	[CompilerGeneratedAttribute] 
	public void set_LocalUserId(ProductUserId value) { }

}

