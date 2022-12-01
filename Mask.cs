public class Mask : UIBehaviour, ICanvasRaycastFilter, IMaterialModifier // TypeDefIndex: 4990
{
	private RectTransform m_RectTransform;
	[SerializeField]
	private bool m_ShowMaskGraphic;
	private Graphic m_Graphic;
	private Material m_MaskMaterial;
	private Material m_UnmaskMaterial;

	public RectTransform rectTransform { get; }
	public bool showMaskGraphic { get; set; }
	public Graphic graphic { get; }


	public RectTransform get_rectTransform() { }

	public bool get_showMaskGraphic() { }

	public void set_showMaskGraphic(bool value) { }

	public Graphic get_graphic() { }

	protected void .ctor() { }

	public virtual bool MaskEnabled() { }

	[ObsoleteAttribute]
	public virtual void OnSiblingGraphicEnabledDisabled() { }

	protected override void OnEnable() { }

	protected override void OnDisable() { }

	public virtual bool IsRaycastLocationValid(Vector2 sp, Camera eventCamera) { }

	public virtual Material GetModifiedMaterial(Material baseMaterial) { }

}

