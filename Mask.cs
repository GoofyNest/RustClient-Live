public class Mask : UIBehaviour, ICanvasRaycastFilter, IMaterialModifier // TypeDefIndex: 4984
{	// Fields
	private RectTransform m_RectTransform; // 0x18
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private bool m_ShowMaskGraphic; // 0x20
	private Graphic m_Graphic; // 0x28
	private Material m_MaskMaterial; // 0x30
	private Material m_UnmaskMaterial; // 0x38

	// Properties
	public RectTransform rectTransform { get; }
	public bool showMaskGraphic { get; set; }
	public Graphic graphic { get; }

	// Methods

	// RVA: 0x17109D0 Offset: 0x170FDD0 VA: 0x1817109D0
	public RectTransform get_rectTransform() { }

	// RVA: 0xB0BB80 Offset: 0xB0AF80 VA: 0x180B0BB80
	public bool get_showMaskGraphic() { }

	// RVA: 0x1710A40 Offset: 0x170FE40 VA: 0x181710A40
	public void set_showMaskGraphic(bool value) { }

	// RVA: 0x1710960 Offset: 0x170FD60 VA: 0x181710960
	public Graphic get_graphic() { }

	// RVA: 0x58DFB0 Offset: 0x58D3B0 VA: 0x18058DFB0
	protected void .ctor() { }

	// RVA: 0x1710480 Offset: 0x170F880 VA: 0x181710480 Slot: 19
	public virtual bool MaskEnabled() { }

	[ObsoleteAttribute] // RVA: 0x75C00 Offset: 0x75000 VA: 0x180075C00
	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 20
	public virtual void OnSiblingGraphicEnabledDisabled() { }

	// RVA: 0x17107C0 Offset: 0x170FBC0 VA: 0x1817107C0 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x1710550 Offset: 0x170F950 VA: 0x181710550 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x1710380 Offset: 0x170F780 VA: 0x181710380 Slot: 21
	public virtual bool IsRaycastLocationValid(Vector2 sp, Camera eventCamera) { }

	// RVA: 0x1710070 Offset: 0x170F470 VA: 0x181710070 Slot: 22
	public virtual Material GetModifiedMaterial(Material baseMaterial) { }

}

