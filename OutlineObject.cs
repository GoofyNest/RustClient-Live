public class OutlineObject : MonoBehaviour, IClientComponent // TypeDefIndex: 10093
{	public Mesh[] meshes; // 0x18
	public Transform[] meshTransforms; // 0x20
	private Collider _col; // 0x28


	public virtual float SampleVisibility() { }

	public Collider GetCollider() { }

	public virtual void BecomeVisible() { }

	public virtual void BecomeInvisible() { }

	public virtual Color GetColor() { }

	public virtual void Registered() { }

	public virtual bool ShouldDisplay() { }

	public void .ctor() { }

}

