public class PowerLineWire : MonoBehaviour // TypeDefIndex: 12098
{
	public List<Transform> poles; 
	public List<PowerLineWireConnectionDef> connections; 
	public List<PowerLineWireSpan> spans; 


	public void Copy(PowerLineWire from, PowerLineWireConnectionHelper helper) { }

	public static PowerLineWire Create(PowerLineWire wire, List<GameObject> objs, GameObjectRef wirePrefab, string name, PowerLineWire copyfrom, float wiresize, float str) { }

	public void Init() { }

	public void .ctor() { }

}

