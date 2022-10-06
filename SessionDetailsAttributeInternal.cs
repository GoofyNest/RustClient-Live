internal struct SessionDetailsAttributeInternal : IGettable<SessionDetailsAttribute>, ISettable<SessionDetailsAttribute>, IDisposable // TypeDefIndex: 8539
{
	private int m_ApiVersion; 
	private IntPtr m_Data; 
	private SessionAttributeAdvertisementType m_AdvertisementType; 

	public Nullable<AttributeData> Data { get; set; }
	public SessionAttributeAdvertisementType AdvertisementType { get; set; }


	public Nullable<AttributeData> get_Data() { }

	public void set_Data(Nullable<AttributeData> value) { }

	public SessionAttributeAdvertisementType get_AdvertisementType() { }

	public void set_AdvertisementType(SessionAttributeAdvertisementType value) { }

	public void Set(ref SessionDetailsAttribute other) { }

	public void Set(ref Nullable<SessionDetailsAttribute> other) { }

	public void Dispose() { }

	public void Get(out SessionDetailsAttribute output) { }

}

