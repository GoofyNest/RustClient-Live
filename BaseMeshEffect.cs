public abstract class BaseMeshEffect : UIBehaviour, IMeshModifier // TypeDefIndex: 5031
{	private Graphic m_Graphic; // 0x18

	protected Graphic graphic { get; }


	protected Graphic get_graphic() { }

	protected override void OnEnable() { }

	protected override void OnDisable() { }

	protected override void OnDidApplyAnimationProperties() { }

	public virtual void ModifyMesh(Mesh mesh) { }

	public abstract void ModifyMesh(VertexHelper vh);

	protected void .ctor() { }

}

