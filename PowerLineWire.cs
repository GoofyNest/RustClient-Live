public class PowerLineWire : MonoBehaviour // TypeDefIndex: 10367
{	public List<Transform> poles; // 0x18
	public List<PowerLineWireConnectionDef> connections; // 0x20
	public List<PowerLineWireSpan> spans; // 0x28


	public void Copy(PowerLineWire from, PowerLineWireConnectionHelper helper) { }

	public static PowerLineWire Create(PowerLineWire wire, List<GameObject> objs, GameObjectRef wirePrefab, string name, PowerLineWire copyfrom, float wiresize, float str) { }

	public void Init() { }

	public void .ctor() { }

}

