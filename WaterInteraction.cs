public class WaterInteraction : MonoBehaviour // TypeDefIndex: 12374
{
	[SerializeField]
	private Texture2D texture;
	[RangeAttribute]
	public float Displacement;
	[RangeAttribute]
	public float Disturbance;
	[CompilerGeneratedAttribute]
	private WaterDynamics.Image <Image>k__BackingField;
	[CompilerGeneratedAttribute]
	private Vector2 <Position>k__BackingField;
	[CompilerGeneratedAttribute]
	private Vector2 <Scale>k__BackingField;
	[CompilerGeneratedAttribute]
	private float <Rotation>k__BackingField;
	private Transform cachedTransform;

	public Texture2D Texture { get; set; }
	public WaterDynamics.Image Image { get; set; }
	public Vector2 Position { get; set; }
	public Vector2 Scale { get; set; }
	public float Rotation { get; set; }


	public Texture2D get_Texture() { }

	public void set_Texture(Texture2D value) { }

	[CompilerGeneratedAttribute]
	public WaterDynamics.Image get_Image() { }

	[CompilerGeneratedAttribute]
	private void set_Image(WaterDynamics.Image value) { }

	[CompilerGeneratedAttribute]
	public Vector2 get_Position() { }

	[CompilerGeneratedAttribute]
	private void set_Position(Vector2 value) { }

	[CompilerGeneratedAttribute]
	public Vector2 get_Scale() { }

	[CompilerGeneratedAttribute]
	private void set_Scale(Vector2 value) { }

	[CompilerGeneratedAttribute]
	public float get_Rotation() { }

	[CompilerGeneratedAttribute]
	private void set_Rotation(float value) { }

	protected void OnEnable() { }

	protected void OnDisable() { }

	public void CheckRegister() { }

	private void UpdateImage() { }

	private void Register() { }

	private void Unregister() { }

	public void UpdateTransform() { }

	public void .ctor() { }

}

