public class Buoyancy : ListComponent<Buoyancy>, IServerComponent // TypeDefIndex: 11411
{
	public BuoyancyPoint[] points; 
	public GameObjectRef[] waterImpacts; 
	public Rigidbody rigidBody; 
	public float buoyancyScale; 
	public bool doEffects; 
	public float flowMovementScale; 
	public float requiredSubmergedFraction; 
	public bool useUnderwaterDrag; 
	[RangeAttribute] 
	public float underwaterDrag; 
	[CompilerGeneratedAttribute] 
	private float <timeOutOfWater>k__BackingField; 
	public Action<bool> SubmergedChanged; 
	public BaseEntity forEntity; 
	public float submergedFraction; 

	public float timeOutOfWater { get; set; }


	[CompilerGeneratedAttribute] 
	public float get_timeOutOfWater() { }

	[CompilerGeneratedAttribute] 
	private void set_timeOutOfWater(float value) { }

	public void .ctor() { }

}

