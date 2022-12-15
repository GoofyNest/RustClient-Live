public class BaseCollision : MonoBehaviour, IClientComponent // TypeDefIndex: 11001
{
	public BaseEntity Owner;
	public Model model;


	public virtual void TraceTest(HitTest test, List<TraceInfo> hits) { }

	public void .ctor() { }

}

