public struct LightDataGI // TypeDefIndex: 3886
{	// Fields
	public int instanceID; // 0x0
	public LinearColor color; // 0x4
	public LinearColor indirectColor; // 0x14
	public Quaternion orientation; // 0x24
	public Vector3 position; // 0x34
	public float range; // 0x40
	public float coneAngle; // 0x44
	public float innerConeAngle; // 0x48
	public float shape0; // 0x4C
	public float shape1; // 0x50
	public LightType type; // 0x54
	public LightMode mode; // 0x55
	public byte shadow; // 0x56
	public FalloffType falloff; // 0x57

	// Methods

	// RVA: 0x2135A0 Offset: 0x2129A0 VA: 0x1802135A0
	public void Init(ref DirectionalLight light) { }

	// RVA: 0x213520 Offset: 0x212920 VA: 0x180213520
	public void Init(ref PointLight light) { }

	// RVA: 0x2135B0 Offset: 0x2129B0 VA: 0x1802135B0
	public void Init(ref SpotLight light) { }

	// RVA: 0x213530 Offset: 0x212930 VA: 0x180213530
	public void Init(ref RectangleLight light) { }

	// RVA: 0x2134B0 Offset: 0x2128B0 VA: 0x1802134B0
	public void Init(ref DiscLight light) { }

	// RVA: 0x2134A0 Offset: 0x2128A0 VA: 0x1802134A0
	public void InitNoBake(int lightInstanceID) { }

}

