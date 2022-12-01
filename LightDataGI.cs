public struct LightDataGI // TypeDefIndex: 3891
{
	public int instanceID;
	public LinearColor color;
	public LinearColor indirectColor;
	public Quaternion orientation;
	public Vector3 position;
	public float range;
	public float coneAngle;
	public float innerConeAngle;
	public float shape0;
	public float shape1;
	public LightType type;
	public LightMode mode;
	public byte shadow;
	public FalloffType falloff;


	public void Init(ref DirectionalLight light) { }

	public void Init(ref PointLight light) { }

	public void Init(ref SpotLight light) { }

	public void Init(ref RectangleLight light) { }

	public void Init(ref DiscLight light) { }

	public void InitNoBake(int lightInstanceID) { }

}

