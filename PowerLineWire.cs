public class PowerLineWire : MonoBehaviour // TypeDefIndex: 10367
{	// Fields
	public List<Transform> poles; // 0x18
	public List<PowerLineWireConnectionDef> connections; // 0x20
	public List<PowerLineWireSpan> spans; // 0x28

	// Methods

	// RVA: 0x97E610 Offset: 0x97DA10 VA: 0x18097E610
	public void Copy(PowerLineWire from, PowerLineWireConnectionHelper helper) { }

	// RVA: 0x97E930 Offset: 0x97DD30 VA: 0x18097E930
	public static PowerLineWire Create(PowerLineWire wire, List<GameObject> objs, GameObjectRef wirePrefab, string name, PowerLineWire copyfrom, float wiresize, float str) { }

	// RVA: 0x97EE80 Offset: 0x97E280 VA: 0x18097EE80
	public void Init() { }

	// RVA: 0x97F1A0 Offset: 0x97E5A0 VA: 0x18097F1A0
	public void .ctor() { }

}

