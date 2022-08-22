public class BaseCollision : MonoBehaviour, IClientComponent // TypeDefIndex: 9256
{	public BaseEntity Owner; // 0x18
	public Model model; // 0x20


	public virtual void TraceTest(HitTest test, List<TraceInfo> hits) { }

	public void .ctor() { }

}

