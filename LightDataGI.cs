public struct LightDataGI // TypeDefIndex: 3886
{	public int instanceID; // 0x0
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


	public void Init(ref DirectionalLight light) { }

	public void Init(ref PointLight light) { }

	public void Init(ref SpotLight light) { }

	public void Init(ref RectangleLight light) { }

	public void Init(ref DiscLight light) { }

	public void InitNoBake(int lightInstanceID) { }

}

