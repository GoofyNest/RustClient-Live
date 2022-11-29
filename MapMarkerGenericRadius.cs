public class MapMarkerGenericRadius : MapMarker // TypeDefIndex: 10322
{
	public float radius; 
	public Color color1; 
	public Color color2; 
	public float alpha; 
	private UIMapGenericRadius cachedUIMarker; 


	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	[BaseEntity.RPC_Client] 
	public void MarkerUpdate(BaseEntity.RPCMessage msg) { }

	public override void SetupUIMarker(GameObject marker) { }

	public void .ctor() { }

}

