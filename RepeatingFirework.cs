public class RepeatingFirework : BaseFirework // TypeDefIndex: 8279
{	// Fields
	public float timeBetweenRepeats; // 0x250
	public int maxRepeats; // 0x254
	public SoundPlayer launchSound; // 0x258

	// Methods

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x9337B0 Offset: 0x932BB0 VA: 0x1809337B0
	public void RPCFire(BaseEntity.RPCMessage msg) { }

	// RVA: 0x933340 Offset: 0x932740 VA: 0x180933340 Slot: 145
	public virtual void Fire() { }

	// RVA: 0x933370 Offset: 0x932770 VA: 0x180933370 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x9337D0 Offset: 0x932BD0 VA: 0x1809337D0
	public void .ctor() { }

}

