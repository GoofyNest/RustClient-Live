public class TrainBarricade : BaseCombatEntity, ITrainCollidable // TypeDefIndex: 11486
{
	[FormerlySerializedAsAttribute] 
	[SerializeField] 
	private float trainDamagePerMPS; 
	[SerializeField] 
	private float minVelToDestroy; 
	[SerializeField] 
	private float velReduction; 
	[SerializeField] 
	private GameObjectRef barricadeDamageEffect; 
	private float nextEffectTime; 


	public bool CustomCollision(TrainCar train, TriggerTrainCollisions trainTrigger) { }

	public override bool DisplayHealthInfo(BasePlayer player) { }

	public override void Load(BaseNetworkable.LoadInfo info) { }

	public void .ctor() { }

}

