public struct LeaderboardRecord // TypeDefIndex: 9299
{
	[CompilerGeneratedAttribute]
	private ProductUserId <UserId>k__BackingField;
	[CompilerGeneratedAttribute]
	private uint <Rank>k__BackingField;
	[CompilerGeneratedAttribute]
	private int <Score>k__BackingField;
	[CompilerGeneratedAttribute]
	private Utf8String <UserDisplayName>k__BackingField;

	public ProductUserId UserId { get; set; }
	public uint Rank { get; set; }
	public int Score { get; set; }
	public Utf8String UserDisplayName { get; set; }


	[CompilerGeneratedAttribute]
	public ProductUserId get_UserId() { }

	[CompilerGeneratedAttribute]
	public void set_UserId(ProductUserId value) { }

	[CompilerGeneratedAttribute]
	public uint get_Rank() { }

	[CompilerGeneratedAttribute]
	public void set_Rank(uint value) { }

	[CompilerGeneratedAttribute]
	public int get_Score() { }

	[CompilerGeneratedAttribute]
	public void set_Score(int value) { }

	[CompilerGeneratedAttribute]
	public Utf8String get_UserDisplayName() { }

	[CompilerGeneratedAttribute]
	public void set_UserDisplayName(Utf8String value) { }

	internal void Set(ref LeaderboardRecordInternal other) { }

}

