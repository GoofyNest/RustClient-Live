public class MapMarkerGenericRadius : MapMarker // TypeDefIndex: 8602
{	// Fields
	public float radius; // 0x178
	public Color color1; // 0x17C
	public Color color2; // 0x18C
	public float alpha; // 0x19C
	private UIMapGenericRadius cachedUIMarker; // 0x1A0

	// Methods

	// RVA: 0x580C30 Offset: 0x580030 VA: 0x180580C30 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x580910 Offset: 0x57FD10 VA: 0x180580910
	public void MarkerUpdate(BaseEntity.RPCMessage msg) { }

	// RVA: 0x581080 Offset: 0x580480 VA: 0x180581080 Slot: 131
	public override void SetupUIMarker(GameObject marker) { }

	// RVA: 0x5811A0 Offset: 0x5805A0 VA: 0x1805811A0
	public void .ctor() { }

}

