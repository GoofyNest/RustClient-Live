public class BaseCollision : MonoBehaviour, IClientComponent // TypeDefIndex: 9256
{	// Fields
	public BaseEntity Owner; // 0x18
	public Model model; // 0x20

	// Methods

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 4
	public virtual void TraceTest(HitTest test, List<TraceInfo> hits) { }

	// RVA: 0x2F91F0 Offset: 0x2F85F0 VA: 0x1802F91F0
	public void .ctor() { }

}

