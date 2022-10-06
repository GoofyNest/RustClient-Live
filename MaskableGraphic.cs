public abstract class MaskableGraphic : Graphic, IClippable, IMaskable, IMaterialModifier // TypeDefIndex: 4990
{
	protected bool m_ShouldRecalculateStencil; 
	protected Material m_MaskMaterial; 
	private RectMask2D m_ParentMask; 
	private bool m_Maskable; 
	[EditorBrowsableAttribute] 
	[ObsoleteAttribute] 
	protected bool m_IncludeForMasking; 
	[SerializeField] 
	private MaskableGraphic.CullStateChangedEvent m_OnCullStateChanged; 
	[EditorBrowsableAttribute] 
	[ObsoleteAttribute] 
	protected bool m_ShouldRecalculate; 
	protected int m_StencilValue; 
	private readonly Vector3[] m_Corners; 

	public MaskableGraphic.CullStateChangedEvent onCullStateChanged { get; set; }
	public bool maskable { get; set; }
	private Rect rootCanvasRect { get; }


	public MaskableGraphic.CullStateChangedEvent get_onCullStateChanged() { }

	public void set_onCullStateChanged(MaskableGraphic.CullStateChangedEvent value) { }

	public bool get_maskable() { }

	public void set_maskable(bool value) { }

	public virtual Material GetModifiedMaterial(Material baseMaterial) { }

	public virtual void Cull(Rect clipRect, bool validRect) { }

	private void UpdateCull(bool cull) { }

	public virtual void SetClipRect(Rect clipRect, bool validRect) { }

	protected override void OnEnable() { }

	protected override void OnDisable() { }

	protected override void OnTransformParentChanged() { }

	[EditorBrowsableAttribute] 
	[ObsoleteAttribute] 
	public virtual void ParentMaskStateChanged() { }

	protected override void OnCanvasHierarchyChanged() { }

	private Rect get_rootCanvasRect() { }

	private void UpdateClipParent() { }

	public virtual void RecalculateClipping() { }

	public virtual void RecalculateMasking() { }

	protected void .ctor() { }

	private GameObject UnityEngine.UI.IClippable.get_gameObject() { }

}

public class MaskableGraphic.CullStateChangedEvent : UnityEvent<bool> // TypeDefIndex: 4991
{

	public void .ctor() { }

}

