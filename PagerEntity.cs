public class PagerEntity : BaseEntity, IRFObject // TypeDefIndex: 8611
{	public static BaseEntity.Flags Flag_Silent; // 0x0
	private int frequency; // 0x168
	public float beepRepeat; // 0x16C
	public GameObjectRef pagerEffect; // 0x170
	public GameObjectRef silentEffect; // 0x178
	private bool wasOn; // 0x180


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

