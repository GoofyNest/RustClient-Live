public class Impostor : MonoBehaviour, IClientComponent // TypeDefIndex: 12446
{
	public ImpostorAsset asset;
	[HeaderAttribute]
	public GameObject reference;
	public float angle;
	public int resolution;
	public int padding;
	public bool spriteOutlineAsMesh;
	[CompilerGeneratedAttribute]
	private ImpostorInstanceData <InstanceData>k__BackingField;
	public bool keepTrying;

	public ImpostorInstanceData InstanceData { get; set; }


	[CompilerGeneratedAttribute]
	public ImpostorInstanceData get_InstanceData() { }

	[CompilerGeneratedAttribute]
	private void set_InstanceData(ImpostorInstanceData value) { }

	private void Awake() { }

	private void OnEnable() { }

	private void OnDisable() { }

	private void InitializeInstanceData() { }

	public void UpdateInstance() { }

	public void .ctor() { }

}

