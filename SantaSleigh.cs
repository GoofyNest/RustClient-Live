public class SantaSleigh : BaseEntity // TypeDefIndex: 10344
{
	public GameObjectRef prefabDrop; 
	public SpawnFilter filter; 
	public Transform dropOrigin; 
	[ServerVar] 
	public static float altitudeAboveTerrain; 
	[ServerVar] 
	public static float desiredAltitude; 
	public Light bigLight; 
	public SoundPlayer hohoho; 
	public float hohohospacing; 
	public float hohoho_additional_spacing; 


	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	[BaseEntity.RPC_Client] 
	public void ClientPlayHoHoHo() { }

	public void Update() { }

	public void .ctor() { }

	private static void .cctor() { }

}

