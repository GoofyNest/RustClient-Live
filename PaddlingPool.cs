public class PaddlingPool : LiquidContainer, ISplashable // TypeDefIndex: 10547
{
	public const BaseEntity.Flags FilledUp = 1024;
	public Transform poolWaterVolume;
	public GameObject poolWaterVisual;
	public float minimumWaterHeight;
	public float maximumWaterHeight;
	public WaterVolume waterVolume;
	public bool alignWaterUp;
	public GameObjectRef destroyedWithWaterEffect;
	public Transform destroyedWithWaterEffectPos;
	public Collider requireLookAt;
	private float lastFillAmount;


	public override void Load(BaseNetworkable.LoadInfo info) { }

	public override bool ShouldShowLootMenus() { }

	public override bool MenuDrink_ShowIf(BasePlayer player) { }

	public override bool CanDrainIntoVessel(BasePlayer player) { }

	private void UpdatePoolFillAmount(float normalisedAmount) { }

	public override int ConsumptionAmount() { }

	public override void DestroyShared() { }

	public void .ctor() { }

}

