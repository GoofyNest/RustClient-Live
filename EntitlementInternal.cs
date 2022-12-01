internal struct EntitlementInternal : IGettable<Entitlement>, ISettable<Entitlement>, IDisposable // TypeDefIndex: 9460
{
	private int m_ApiVersion;
	private IntPtr m_EntitlementName;
	private IntPtr m_EntitlementId;
	private IntPtr m_CatalogItemId;
	private int m_ServerIndex;
	private int m_Redeemed;
	private long m_EndTimestamp;

	public Utf8String EntitlementName { get; set; }
	public Utf8String EntitlementId { get; set; }
	public Utf8String CatalogItemId { get; set; }
	public int ServerIndex { get; set; }
	public bool Redeemed { get; set; }
	public long EndTimestamp { get; set; }


	public Utf8String get_EntitlementName() { }

	public void set_EntitlementName(Utf8String value) { }

	public Utf8String get_EntitlementId() { }

	public void set_EntitlementId(Utf8String value) { }

	public Utf8String get_CatalogItemId() { }

	public void set_CatalogItemId(Utf8String value) { }

	public int get_ServerIndex() { }

	public void set_ServerIndex(int value) { }

	public bool get_Redeemed() { }

	public void set_Redeemed(bool value) { }

	public long get_EndTimestamp() { }

	public void set_EndTimestamp(long value) { }

	public void Set(ref Entitlement other) { }

	public void Set(ref Nullable<Entitlement> other) { }

	public void Dispose() { }

	public void Get(out Entitlement output) { }

}

