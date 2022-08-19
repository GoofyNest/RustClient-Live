public class LiquidWobble : MonoBehaviour // TypeDefIndex: 10684
{	// Fields
	private Renderer rend; // 0x18
	private Vector3 lastPos; // 0x20
	private Vector3 velocity; // 0x2C
	private Vector3 lastRot; // 0x38
	private Vector3 angularVelocity; // 0x44
	[RangeAttribute] // RVA: 0x71260 Offset: 0x70660 VA: 0x180071260
	public float CurrentWaterLevelFraction; // 0x50
	public float MinWaterLevel; // 0x54
	public float MaxWaterLevel; // 0x58
	public float MaxWobble; // 0x5C
	public float WobbleSpeed; // 0x60
	public float Recovery; // 0x64
	private float wobbleAmountX; // 0x68
	private float wobbleAmountZ; // 0x6C
	private float wobbleAmountToAddX; // 0x70
	private float wobbleAmountToAddZ; // 0x74
	private float pulse; // 0x78
	private float time; // 0x7C
	public float turbulence; // 0x80
	private static MaterialPropertyBlock propertyBlock; // 0x0
	private static int wobbleXID; // 0x8
	private static int wobbleZID; // 0xC
	private static int waterLevelID; // 0x10
	private static int turbulenceID; // 0x14

	// Methods

	// RVA: 0x4F3DF0 Offset: 0x4F31F0 VA: 0x1804F3DF0
	private void Awake() { }

	// RVA: 0x4F3EF0 Offset: 0x4F32F0 VA: 0x1804F3EF0
	private void Update() { }

	// RVA: 0x4F3ED0 Offset: 0x4F32D0 VA: 0x1804F3ED0
	private float CalculateWaterLevel() { }

	// RVA: 0x4F4470 Offset: 0x4F3870 VA: 0x1804F4470
	public void .ctor() { }

	// RVA: 0x4F43D0 Offset: 0x4F37D0 VA: 0x1804F43D0
	private static void .cctor() { }

}

