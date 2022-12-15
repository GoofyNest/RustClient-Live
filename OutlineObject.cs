public class OutlineObject : MonoBehaviour, IClientComponent // TypeDefIndex: 11856
{
	public Mesh[] meshes;
	public Transform[] meshTransforms;
	private Collider _col;


	public virtual float SampleVisibility() { }

	public Collider GetCollider() { }

	public virtual void BecomeVisible() { }

	public virtual void BecomeInvisible() { }

	public virtual Color GetColor() { }

	public virtual void Registered() { }

	public virtual bool ShouldDisplay() { }

	public void .ctor() { }

}

