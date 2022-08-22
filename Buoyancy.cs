public class Buoyancy : ListComponent<Buoyancy>, IServerComponent // TypeDefIndex: 9700
{	public BuoyancyPoint[] points; // 0x18
	public GameObjectRef[] waterImpacts; // 0x20
	public Rigidbody rigidBody; // 0x28
	public float buoyancyScale; // 0x30
	public bool doEffects; // 0x34
	public float flowMovementScale; // 0x38
	public float requiredSubmergedFraction; // 0x3C
	public bool useUnderwaterDrag; // 0x40
	[RangeAttribute] // RVA: 0x84380 Offset: 0x83780 VA: 0x180084380
	public float underwaterDrag; // 0x44
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private float <timeOutOfWater>k__BackingField; // 0x48
	public Action<bool> SubmergedChanged; // 0x50
	public BaseEntity forEntity; // 0x58
	public float submergedFraction; // 0x60

	public float timeOutOfWater { get; set; }


	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public float get_timeOutOfWater() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void set_timeOutOfWater(float value) { }

	public void .ctor() { }

}

