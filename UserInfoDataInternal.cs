internal struct UserInfoDataInternal : IGettable<UserInfoData>, ISettable<UserInfoData>, IDisposable // TypeDefIndex: 8330
{
	private int m_ApiVersion;
	private IntPtr m_UserId;
	private IntPtr m_Country;
	private IntPtr m_DisplayName;
	private IntPtr m_PreferredLanguage;
	private IntPtr m_Nickname;
	private IntPtr m_DisplayNameSanitized;

	public EpicAccountId UserId { get; set; }
	public Utf8String Country { get; set; }
	public Utf8String DisplayName { get; set; }
	public Utf8String PreferredLanguage { get; set; }
	public Utf8String Nickname { get; set; }
	public Utf8String DisplayNameSanitized { get; set; }


	public EpicAccountId get_UserId() { }

	public void set_UserId(EpicAccountId value) { }

	public Utf8String get_Country() { }

	public void set_Country(Utf8String value) { }

	public Utf8String get_DisplayName() { }

	public void set_DisplayName(Utf8String value) { }

	public Utf8String get_PreferredLanguage() { }

	public void set_PreferredLanguage(Utf8String value) { }

	public Utf8String get_Nickname() { }

	public void set_Nickname(Utf8String value) { }

	public Utf8String get_DisplayNameSanitized() { }

	public void set_DisplayNameSanitized(Utf8String value) { }

	public void Set(ref UserInfoData other) { }

	public void Set(ref Nullable<UserInfoData> other) { }

	public void Dispose() { }

	public void Get(out UserInfoData output) { }

}

