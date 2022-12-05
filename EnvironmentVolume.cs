public class EnvironmentVolume : MonoBehaviour // TypeDefIndex: 11608
{
	[InspectorFlagsAttribute]
	public EnvironmentType Type;
	public Vector3 Center;
	public Vector3 Size;
	[CompilerGeneratedAttribute]
	private Collider <trigger>k__BackingField;

	public Collider trigger { get; set; }


	[CompilerGeneratedAttribute]
	public Collider get_trigger() { }

	[CompilerGeneratedAttribute]
	private void set_trigger(Collider value) { }

	protected virtual void Awake() { }

	public void UpdateTrigger() { }

	public void .ctor() { }

}

