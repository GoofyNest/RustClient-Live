public class RawImage : MaskableGraphic // TypeDefIndex: 4992
{	// Fields
	[FormerlySerializedAsAttribute] // RVA: 0x76880 Offset: 0x75C80 VA: 0x180076880
	[SerializeField] // RVA: 0x76880 Offset: 0x75C80 VA: 0x180076880
	private Texture m_Texture; // 0xC8
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Rect m_UVRect; // 0xD0

	// Properties
	public override Texture mainTexture { get; }
	public Texture texture { get; set; }
	public Rect uvRect { get; set; }

	// Methods

	// RVA: 0x17128B0 Offset: 0x1711CB0 VA: 0x1817128B0
	protected void .ctor() { }

	// RVA: 0x17129D0 Offset: 0x1711DD0 VA: 0x1817129D0 Slot: 35
	public override Texture get_mainTexture() { }

	// RVA: 0xD9B0A0 Offset: 0xD9A4A0 VA: 0x180D9B0A0
	public Texture get_texture() { }

	// RVA: 0x1712B70 Offset: 0x1711F70 VA: 0x181712B70
	public void set_texture(Texture value) { }

	// RVA: 0x1712B60 Offset: 0x1711F60 VA: 0x181712B60
	public Rect get_uvRect() { }

	// RVA: 0x1712C30 Offset: 0x1712030 VA: 0x181712C30
	public void set_uvRect(Rect value) { }

	// RVA: 0x17126E0 Offset: 0x1711AE0 VA: 0x1817126E0 Slot: 45
	public override void SetNativeSize() { }

	// RVA: 0x17121F0 Offset: 0x17115F0 VA: 0x1817121F0 Slot: 44
	protected override void OnPopulateMesh(VertexHelper vh) { }

	// RVA: 0x17121B0 Offset: 0x17115B0 VA: 0x1817121B0 Slot: 13
	protected override void OnDidApplyAnimationProperties() { }

}

