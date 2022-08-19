public class PaddlingPool : LiquidContainer, ISplashable // TypeDefIndex: 8818
{	// Fields
	public const BaseEntity.Flags FilledUp = 1024;
	public Transform poolWaterVolume; // 0x3F8
	public GameObject poolWaterVisual; // 0x400
	public float minimumWaterHeight; // 0x408
	public float maximumWaterHeight; // 0x40C
	public WaterVolume waterVolume; // 0x410
	public bool alignWaterUp; // 0x418
	public GameObjectRef destroyedWithWaterEffect; // 0x420
	public Transform destroyedWithWaterEffectPos; // 0x428
	public Collider requireLookAt; // 0x430
	private float lastFillAmount; // 0x438

	// Methods

	// RVA: 0xA4E670 Offset: 0xA4DA70 VA: 0x180A4E670 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0xA4E860 Offset: 0xA4DC60 VA: 0x180A4E860 Slot: 164
	public override bool ShouldShowLootMenus() { }

	// RVA: 0x498AD0 Offset: 0x497ED0 VA: 0x180498AD0 Slot: 167
	public override bool MenuDrink_ShowIf(BasePlayer player) { }

	// RVA: 0xA4E350 Offset: 0xA4D750 VA: 0x180A4E350 Slot: 169
	public override bool CanDrainIntoVessel(BasePlayer player) { }

	// RVA: 0xA4E9B0 Offset: 0xA4DDB0 VA: 0x180A4E9B0
	private void UpdatePoolFillAmount(float normalisedAmount) { }

	// RVA: 0x513D80 Offset: 0x513180 VA: 0x180513D80 Slot: 150
	public override int ConsumptionAmount() { }

	// RVA: 0xA4E460 Offset: 0xA4D860 VA: 0x180A4E460 Slot: 31
	public override void DestroyShared() { }

	// RVA: 0xA4EB70 Offset: 0xA4DF70 VA: 0x180A4EB70
	public void .ctor() { }

}

