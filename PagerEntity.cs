public class PagerEntity : BaseEntity, IRFObject // TypeDefIndex: 10318
{
	public static BaseEntity.Flags Flag_Silent; 
	private int frequency; 
	public float beepRepeat; 
	public GameObjectRef pagerEffect; 
	public GameObjectRef silentEffect; 
	private bool wasOn; 


	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	public int GetFrequency() { }

	public void OnParentDestroying() { }

	public override void Load(BaseNetworkable.LoadInfo info) { }

	public override void PostNetworkUpdate() { }

	public void Beep() { }

	public void BeginAlarm() { }

	public void EndAlarm() { }

	public void ClientSetFrequency(int newFreq) { }

	public void .ctor() { }

	private static void .cctor() { }

}

