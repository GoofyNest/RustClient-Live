internal struct DefinitionV2Internal : IGettable<DefinitionV2>, ISettable<DefinitionV2>, IDisposable // TypeDefIndex: 9903
{
	private int m_ApiVersion; 
	private IntPtr m_AchievementId; 
	private IntPtr m_UnlockedDisplayName; 
	private IntPtr m_UnlockedDescription; 
	private IntPtr m_LockedDisplayName; 
	private IntPtr m_LockedDescription; 
	private IntPtr m_FlavorText; 
	private IntPtr m_UnlockedIconURL; 
	private IntPtr m_LockedIconURL; 
	private int m_IsHidden; 
	private uint m_StatThresholdsCount; 
	private IntPtr m_StatThresholds; 

	public Utf8String AchievementId { get; set; }
	public Utf8String UnlockedDisplayName { get; set; }
	public Utf8String UnlockedDescription { get; set; }
	public Utf8String LockedDisplayName { get; set; }
	public Utf8String LockedDescription { get; set; }
	public Utf8String FlavorText { get; set; }
	public Utf8String UnlockedIconURL { get; set; }
	public Utf8String LockedIconURL { get; set; }
	public bool IsHidden { get; set; }
	public StatThresholds[] StatThresholds { get; set; }


	public Utf8String get_AchievementId() { }

	public void set_AchievementId(Utf8String value) { }

	public Utf8String get_UnlockedDisplayName() { }

	public void set_UnlockedDisplayName(Utf8String value) { }

	public Utf8String get_UnlockedDescription() { }

	public void set_UnlockedDescription(Utf8String value) { }

	public Utf8String get_LockedDisplayName() { }

	public void set_LockedDisplayName(Utf8String value) { }

	public Utf8String get_LockedDescription() { }

	public void set_LockedDescription(Utf8String value) { }

	public Utf8String get_FlavorText() { }

	public void set_FlavorText(Utf8String value) { }

	public Utf8String get_UnlockedIconURL() { }

	public void set_UnlockedIconURL(Utf8String value) { }

	public Utf8String get_LockedIconURL() { }

	public void set_LockedIconURL(Utf8String value) { }

	public bool get_IsHidden() { }

	public void set_IsHidden(bool value) { }

	public StatThresholds[] get_StatThresholds() { }

	public void set_StatThresholds(StatThresholds[] value) { }

	public void Set(ref DefinitionV2 other) { }

	public void Set(ref Nullable<DefinitionV2> other) { }

	public void Dispose() { }

	public void Get(out DefinitionV2 output) { }

}

