internal struct SessionModificationAddAttributeOptionsInternal : ISettable<SessionModificationAddAttributeOptions>, IDisposable // TypeDefIndex: 8572
{
	private int m_ApiVersion;
	private IntPtr m_SessionAttribute;
	private SessionAttributeAdvertisementType m_AdvertisementType;

	public Nullable<AttributeData> SessionAttribute { set; }
	public SessionAttributeAdvertisementType AdvertisementType { set; }


	public void set_SessionAttribute(Nullable<AttributeData> value) { }

	public void set_AdvertisementType(SessionAttributeAdvertisementType value) { }

	public void Set(ref SessionModificationAddAttributeOptions other) { }

	public void Set(ref Nullable<SessionModificationAddAttributeOptions> other) { }

	public void Dispose() { }

}

