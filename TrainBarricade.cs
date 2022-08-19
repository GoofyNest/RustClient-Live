public class TrainBarricade : BaseCombatEntity, ITrainCollidable // TypeDefIndex: 9766
{	// Fields
	[FormerlySerializedAsAttribute] // RVA: 0x94690 Offset: 0x93A90 VA: 0x180094690
	[SerializeField] // RVA: 0x94690 Offset: 0x93A90 VA: 0x180094690
	private float trainDamagePerMPS; // 0x240
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private float minVelToDestroy; // 0x244
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private float velReduction; // 0x248
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private GameObjectRef barricadeDamageEffect; // 0x250
	private float nextEffectTime; // 0x258

	// Methods

	// RVA: 0x498AD0 Offset: 0x497ED0 VA: 0x180498AD0 Slot: 145
	public bool CustomCollision(TrainCar train, TriggerTrainCollisions trainTrigger) { }

	// RVA: 0x9E9E60 Offset: 0x9E9260 VA: 0x1809E9E60 Slot: 131
	public override bool DisplayHealthInfo(BasePlayer player) { }

	// RVA: 0x9E9E90 Offset: 0x9E9290 VA: 0x1809E9E90 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x9EA0C0 Offset: 0x9E94C0 VA: 0x1809EA0C0
	public void .ctor() { }

}

