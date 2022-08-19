public class PagerEntity : BaseEntity, IRFObject // TypeDefIndex: 8611
{	// Fields
	public static BaseEntity.Flags Flag_Silent; // 0x0
	private int frequency; // 0x168
	public float beepRepeat; // 0x16C
	public GameObjectRef pagerEffect; // 0x170
	public GameObjectRef silentEffect; // 0x178
	private bool wasOn; // 0x180

	// Methods

	// RVA: 0xA4EF10 Offset: 0xA4E310 VA: 0x180A4EF10 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0xA4EE50 Offset: 0xA4E250 VA: 0x180A4EE50 Slot: 132
	public int GetFrequency() { }

	// RVA: 0xA4EEC0 Offset: 0xA4E2C0 VA: 0x180A4EEC0
	public void OnParentDestroying() { }

	// RVA: 0xA4EE60 Offset: 0xA4E260 VA: 0x180A4EE60 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0xA4F000 Offset: 0xA4E400 VA: 0x180A4F000 Slot: 16
	public override void PostNetworkUpdate() { }

	// RVA: 0xA4EBA0 Offset: 0xA4DFA0 VA: 0x180A4EBA0
	public void Beep() { }

	// RVA: 0xA4ECE0 Offset: 0xA4E0E0 VA: 0x180A4ECE0
	public void BeginAlarm() { }

	// RVA: 0xA4EDE0 Offset: 0xA4E1E0 VA: 0x180A4EDE0
	public void EndAlarm() { }

	// RVA: 0xA4ED90 Offset: 0xA4E190 VA: 0x180A4ED90 Slot: 131
	public void ClientSetFrequency(int newFreq) { }

	// RVA: 0xA4F250 Offset: 0xA4E650 VA: 0x180A4F250
	public void .ctor() { }

	// RVA: 0xA4F210 Offset: 0xA4E610 VA: 0x180A4F210
	private static void .cctor() { }

}

