public class BaseLauncher : BaseProjectile // TypeDefIndex: 8521
{	// Fields
	private int lastSpectatorReloadAmmo; // 0x378
	private TimeSince lastSpectatorAmmoInsert; // 0x37C

	// Methods

	// RVA: 0xA21150 Offset: 0xA20550 VA: 0x180A21150 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0xA20CB0 Offset: 0xA200B0 VA: 0x180A20CB0 Slot: 172
	public override void LaunchProjectile() { }

	// RVA: 0xA21020 Offset: 0xA20420 VA: 0x180A21020 Slot: 137
	public override void OnFrame() { }

	// RVA: 0xA21240 Offset: 0xA20640 VA: 0x180A21240 Slot: 153
	public override void ProcessSpectatorViewmodelEvent(ViewModel vm, BaseEntity.Signal signal, string arg) { }

	// RVA: 0xA213E0 Offset: 0xA207E0 VA: 0x180A213E0
	private void SpectatorInsertAmmo() { }

	// RVA: 0x51E690 Offset: 0x51DA90 VA: 0x18051E690
	public void .ctor() { }

}

