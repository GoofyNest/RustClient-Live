public class WaterInteraction : MonoBehaviour // TypeDefIndex: 10615
{	// Fields
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Texture2D texture; // 0x18
	[RangeAttribute] // RVA: 0x71260 Offset: 0x70660 VA: 0x180071260
	public float Displacement; // 0x20
	[RangeAttribute] // RVA: 0x71260 Offset: 0x70660 VA: 0x180071260
	public float Disturbance; // 0x24
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private WaterDynamics.Image <Image>k__BackingField; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Vector2 <Position>k__BackingField; // 0x30
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Vector2 <Scale>k__BackingField; // 0x38
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private float <Rotation>k__BackingField; // 0x40
	private Transform cachedTransform; // 0x48

	// Properties
	public Texture2D Texture { get; set; }
	public WaterDynamics.Image Image { get; set; }
	public Vector2 Position { get; set; }
	public Vector2 Scale { get; set; }
	public float Rotation { get; set; }

	// Methods

	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710
	public Texture2D get_Texture() { }

	// RVA: 0xC107E0 Offset: 0xC0FBE0 VA: 0x180C107E0
	public void set_Texture(Texture2D value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x7CE230 Offset: 0x7CD630 VA: 0x1807CE230
	public WaterDynamics.Image get_Image() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x7CE240 Offset: 0x7CD640 VA: 0x1807CE240
	private void set_Image(WaterDynamics.Image value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xC10780 Offset: 0xC0FB80 VA: 0x180C10780
	public Vector2 get_Position() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xC107C0 Offset: 0xC0FBC0 VA: 0x180C107C0
	private void set_Position(Vector2 value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xC107A0 Offset: 0xC0FBA0 VA: 0x180C107A0
	public Vector2 get_Scale() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xC107D0 Offset: 0xC0FBD0 VA: 0x180C107D0
	private void set_Scale(Vector2 value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x54D6A0 Offset: 0x54CAA0 VA: 0x18054D6A0
	public float get_Rotation() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x54D6B0 Offset: 0x54CAB0 VA: 0x18054D6B0
	private void set_Rotation(float value) { }

	// RVA: 0xC10190 Offset: 0xC0F590 VA: 0x180C10190
	protected void OnEnable() { }

	// RVA: 0xC10180 Offset: 0xC0F580 VA: 0x180C10180
	protected void OnDisable() { }

	// RVA: 0xC10000 Offset: 0xC0F400 VA: 0x180C10000
	public void CheckRegister() { }

	// RVA: 0xC10490 Offset: 0xC0F890 VA: 0x180C10490
	private void UpdateImage() { }

	// RVA: 0xC10360 Offset: 0xC0F760 VA: 0x180C10360
	private void Register() { }

	// RVA: 0xC10410 Offset: 0xC0F810 VA: 0x180C10410
	private void Unregister() { }

	// RVA: 0xC10500 Offset: 0xC0F900 VA: 0x180C10500
	public void UpdateTransform() { }

	// RVA: 0xC106D0 Offset: 0xC0FAD0 VA: 0x180C106D0
	public void .ctor() { }

}

