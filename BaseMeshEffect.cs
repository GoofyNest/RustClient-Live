public abstract class BaseMeshEffect : UIBehaviour, IMeshModifier // TypeDefIndex: 5031
{	// Fields
	private Graphic m_Graphic; // 0x18

	// Properties
	protected Graphic graphic { get; }

	// Methods

	// RVA: 0x10B1AD0 Offset: 0x10B0ED0 VA: 0x1810B1AD0
	protected Graphic get_graphic() { }

	// RVA: 0x10B1A30 Offset: 0x10B0E30 VA: 0x1810B1A30 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x10B1990 Offset: 0x10B0D90 VA: 0x1810B1990 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x10B18F0 Offset: 0x10B0CF0 VA: 0x1810B18F0 Slot: 13
	protected override void OnDidApplyAnimationProperties() { }

	// RVA: 0x10B17E0 Offset: 0x10B0BE0 VA: 0x1810B17E0 Slot: 19
	public virtual void ModifyMesh(Mesh mesh) { }

	// RVA: -1 Offset: -1 Slot: 20
	public abstract void ModifyMesh(VertexHelper vh);

	// RVA: 0x2F91F0 Offset: 0x2F85F0 VA: 0x1802F91F0
	protected void .ctor() { }

}

