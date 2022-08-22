public class Mask : UIBehaviour, ICanvasRaycastFilter, IMaterialModifier // TypeDefIndex: 4984
{	private RectTransform m_RectTransform; // 0x18
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private bool m_ShowMaskGraphic; // 0x20
	private Graphic m_Graphic; // 0x28
	private Material m_MaskMaterial; // 0x30
	private Material m_UnmaskMaterial; // 0x38

	public RectTransform rectTransform { get; }
	public bool showMaskGraphic { get; set; }
	public Graphic graphic { get; }


	public RectTransform get_rectTransform() { }

	public bool get_showMaskGraphic() { }

	public void set_showMaskGraphic(bool value) { }

	public Graphic get_graphic() { }

	protected void .ctor() { }

	public virtual bool MaskEnabled() { }

	[ObsoleteAttribute] // RVA: 0x75C00 Offset: 0x75000 VA: 0x180075C00
	public virtual void OnSiblingGraphicEnabledDisabled() { }

	protected override void OnEnable() { }

	protected override void OnDisable() { }

	public virtual bool IsRaycastLocationValid(Vector2 sp, Camera eventCamera) { }

	public virtual Material GetModifiedMaterial(Material baseMaterial) { }

}

