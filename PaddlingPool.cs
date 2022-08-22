public class PaddlingPool : LiquidContainer, ISplashable // TypeDefIndex: 8818
{	public const BaseEntity.Flags FilledUp = 1024;
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


	public override void Load(BaseNetworkable.LoadInfo info) { }

	public override bool ShouldShowLootMenus() { }

	public override bool MenuDrink_ShowIf(BasePlayer player) { }

	public override bool CanDrainIntoVessel(BasePlayer player) { }

	private void UpdatePoolFillAmount(float normalisedAmount) { }

	public override int ConsumptionAmount() { }

	public override void DestroyShared() { }

	public void .ctor() { }

}

