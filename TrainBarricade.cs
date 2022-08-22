public class TrainBarricade : BaseCombatEntity, ITrainCollidable // TypeDefIndex: 9766
{	[FormerlySerializedAsAttribute] // RVA: 0x94690 Offset: 0x93A90 VA: 0x180094690
	[SerializeField] // RVA: 0x94690 Offset: 0x93A90 VA: 0x180094690
	private float trainDamagePerMPS; // 0x240
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private float minVelToDestroy; // 0x244
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private float velReduction; // 0x248
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private GameObjectRef barricadeDamageEffect; // 0x250
	private float nextEffectTime; // 0x258


	public bool CustomCollision(TrainCar train, TriggerTrainCollisions trainTrigger) { }

	public override bool DisplayHealthInfo(BasePlayer player) { }

	public override void Load(BaseNetworkable.LoadInfo info) { }

	public void .ctor() { }

}

