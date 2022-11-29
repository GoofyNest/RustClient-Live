internal struct KeyImageInfoInternal : IGettable<KeyImageInfo>, ISettable<KeyImageInfo>, IDisposable // TypeDefIndex: 9480
{
	private int m_ApiVersion; 
	private IntPtr m_Type; 
	private IntPtr m_Url; 
	private uint m_Width; 
	private uint m_Height; 

	public Utf8String Type { get; set; }
	public Utf8String Url { get; set; }
	public uint Width { get; set; }
	public uint Height { get; set; }


	public Utf8String get_Type() { }

	public void set_Type(Utf8String value) { }

	public Utf8String get_Url() { }

	public void set_Url(Utf8String value) { }

	public uint get_Width() { }

	public void set_Width(uint value) { }

	public uint get_Height() { }

	public void set_Height(uint value) { }

	public void Set(ref KeyImageInfo other) { }

	public void Set(ref Nullable<KeyImageInfo> other) { }

	public void Dispose() { }

	public void Get(out KeyImageInfo output) { }

}

