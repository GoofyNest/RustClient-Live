internal struct AddProgressionOptionsInternal : ISettable<AddProgressionOptions>, IDisposable // TypeDefIndex: 8799
{
	private int m_ApiVersion; 
	private uint m_SnapshotId; 
	private IntPtr m_Key; 
	private IntPtr m_Value; 

	public uint SnapshotId { set; }
	public Utf8String Key { set; }
	public Utf8String Value { set; }


	public void set_SnapshotId(uint value) { }

	public void set_Key(Utf8String value) { }

	public void set_Value(Utf8String value) { }

	public void Set(ref AddProgressionOptions other) { }

	public void Set(ref Nullable<AddProgressionOptions> other) { }

	public void Dispose() { }

}

