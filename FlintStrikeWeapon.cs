public class FlintStrikeWeapon : BaseProjectile // TypeDefIndex: 9463
{	// Fields
	public float successFraction; // 0x378
	public RecoilProperties strikeRecoil; // 0x380
	private bool _didSparkThisFrame; // 0x388
	private bool _isStriking; // 0x389
	private int strikes; // 0x38C

	// Methods

	// RVA: 0x790B30 Offset: 0x78FF30 VA: 0x180790B30 Slot: 163
	public override RecoilProperties GetRecoil() { }

	// RVA: 0x790830 Offset: 0x78FC30 VA: 0x180790830 Slot: 171
	public override void DoAttack() { }

	// RVA: 0x790B40 Offset: 0x78FF40 VA: 0x180790B40 Slot: 137
	public override void OnFrame() { }

	// RVA: 0x790CD0 Offset: 0x7900D0 VA: 0x180790CD0 Slot: 144
	public override void OnViewmodelEvent(string name) { }

	// RVA: 0x790E80 Offset: 0x790280 VA: 0x180790E80
	public void .ctor() { }

}

