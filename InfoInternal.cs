internal struct InfoInternal : IGettable<Info>, ISettable<Info>, IDisposable // TypeDefIndex: 8832
{
	private int m_ApiVersion; 
	private Status m_Status; 
	private IntPtr m_UserId; 
	private IntPtr m_ProductId; 
	private IntPtr m_ProductVersion; 
	private IntPtr m_Platform; 
	private IntPtr m_RichText; 
	private int m_RecordsCount; 
	private IntPtr m_Records; 
	private IntPtr m_ProductName; 
	private IntPtr m_IntegratedPlatform; 

	public Status Status { get; set; }
	public EpicAccountId UserId { get; set; }
	public Utf8String ProductId { get; set; }
	public Utf8String ProductVersion { get; set; }
	public Utf8String Platform { get; set; }
	public Utf8String RichText { get; set; }
	public DataRecord[] Records { get; set; }
	public Utf8String ProductName { get; set; }
	public Utf8String IntegratedPlatform { get; set; }


	public Status get_Status() { }

	public void set_Status(Status value) { }

	public EpicAccountId get_UserId() { }

	public void set_UserId(EpicAccountId value) { }

	public Utf8String get_ProductId() { }

	public void set_ProductId(Utf8String value) { }

	public Utf8String get_ProductVersion() { }

	public void set_ProductVersion(Utf8String value) { }

	public Utf8String get_Platform() { }

	public void set_Platform(Utf8String value) { }

	public Utf8String get_RichText() { }

	public void set_RichText(Utf8String value) { }

	public DataRecord[] get_Records() { }

	public void set_Records(DataRecord[] value) { }

	public Utf8String get_ProductName() { }

	public void set_ProductName(Utf8String value) { }

	public Utf8String get_IntegratedPlatform() { }

	public void set_IntegratedPlatform(Utf8String value) { }

	public void Set(ref Info other) { }

	public void Set(ref Nullable<Info> other) { }

	public void Dispose() { }

	public void Get(out Info output) { }

}

