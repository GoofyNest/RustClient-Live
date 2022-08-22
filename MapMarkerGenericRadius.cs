public class MapMarkerGenericRadius : MapMarker // TypeDefIndex: 8602
{	public float radius; // 0x178
	public Color color1; // 0x17C
	public Color color2; // 0x18C
	public float alpha; // 0x19C
	private UIMapGenericRadius cachedUIMarker; // 0x1A0


	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void MarkerUpdate(BaseEntity.RPCMessage msg) { }

	public override void SetupUIMarker(GameObject marker) { }

	public void .ctor() { }

}

