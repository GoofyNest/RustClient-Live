public abstract class MaskableGraphic : Graphic, IClippable, IMaskable, IMaterialModifier // TypeDefIndex: 4986
{	// Fields
	protected bool m_ShouldRecalculateStencil; // 0x90
	protected Material m_MaskMaterial; // 0x98
	private RectMask2D m_ParentMask; // 0xA0
	private bool m_Maskable; // 0xA8
	[EditorBrowsableAttribute] // RVA: 0x75D80 Offset: 0x75180 VA: 0x180075D80
	[ObsoleteAttribute] // RVA: 0x75D80 Offset: 0x75180 VA: 0x180075D80
	protected bool m_IncludeForMasking; // 0xA9
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private MaskableGraphic.CullStateChangedEvent m_OnCullStateChanged; // 0xB0
	[EditorBrowsableAttribute] // RVA: 0x75F10 Offset: 0x75310 VA: 0x180075F10
	[ObsoleteAttribute] // RVA: 0x75F10 Offset: 0x75310 VA: 0x180075F10
	protected bool m_ShouldRecalculate; // 0xB8
	protected int m_StencilValue; // 0xBC
	private readonly Vector3[] m_Corners; // 0xC0

	// Properties
	public MaskableGraphic.CullStateChangedEvent onCullStateChanged { get; set; }
	public bool maskable { get; set; }
	private Rect rootCanvasRect { get; }

	// Methods

	// RVA: 0x972280 Offset: 0x971680 VA: 0x180972280
	public MaskableGraphic.CullStateChangedEvent get_onCullStateChanged() { }

	// RVA: 0xA2BE00 Offset: 0xA2B200 VA: 0x180A2BE00
	public void set_onCullStateChanged(MaskableGraphic.CullStateChangedEvent value) { }

	// RVA: 0x7E83F0 Offset: 0x7E77F0 VA: 0x1807E83F0
	public bool get_maskable() { }

	// RVA: 0x1711950 Offset: 0x1710D50 VA: 0x181711950
	public void set_maskable(bool value) { }

	// RVA: 0x1710BA0 Offset: 0x170FFA0 VA: 0x181710BA0 Slot: 57
	public virtual Material GetModifiedMaterial(Material baseMaterial) { }

	// RVA: 0x1710B30 Offset: 0x170FF30 VA: 0x181710B30 Slot: 58
	public virtual void Cull(Rect clipRect, bool validRect) { }

	// RVA: 0x1711300 Offset: 0x1710700 VA: 0x181711300
	private void UpdateCull(bool cull) { }

	// RVA: 0x1711040 Offset: 0x1710440 VA: 0x181711040 Slot: 59
	public virtual void SetClipRect(Rect clipRect, bool validRect) { }

	// RVA: 0x1710E90 Offset: 0x1710290 VA: 0x181710E90 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x1710D90 Offset: 0x1710190 VA: 0x181710D90 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x1710F40 Offset: 0x1710340 VA: 0x181710F40 Slot: 12
	protected override void OnTransformParentChanged() { }

	[EditorBrowsableAttribute] // RVA: 0x75D80 Offset: 0x75180 VA: 0x180075D80
	[ObsoleteAttribute] // RVA: 0x75D80 Offset: 0x75180 VA: 0x180075D80
	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 60
	public virtual void ParentMaskStateChanged() { }

	// RVA: 0x1710D40 Offset: 0x1710140 VA: 0x181710D40 Slot: 15
	protected override void OnCanvasHierarchyChanged() { }

	// RVA: 0x17114A0 Offset: 0x17108A0 VA: 0x1817114A0
	private Rect get_rootCanvasRect() { }

	// RVA: 0x17110A0 Offset: 0x17104A0 VA: 0x1817110A0
	private void UpdateClipParent() { }

	// RVA: 0x1710F90 Offset: 0x1710390 VA: 0x181710F90 Slot: 61
	public virtual void RecalculateClipping() { }

	// RVA: 0x1710FA0 Offset: 0x17103A0 VA: 0x181710FA0 Slot: 62
	public virtual void RecalculateMasking() { }

	// RVA: 0x17113C0 Offset: 0x17107C0 VA: 0x1817113C0
	protected void .ctor() { }

	// RVA: 0x4EC610 Offset: 0x4EBA10 VA: 0x1804EC610 Slot: 50
	private GameObject UnityEngine.UI.IClippable.get_gameObject() { }

}

public class MaskableGraphic.CullStateChangedEvent : UnityEvent<bool> // TypeDefIndex: 4987
{	// Methods

	// RVA: 0x170AAC0 Offset: 0x1709EC0 VA: 0x18170AAC0
	public void .ctor() { }

}

