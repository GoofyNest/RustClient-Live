public class RottingFlies : MonoBehaviour, IClientComponent // TypeDefIndex: 9362
{
	public GameObjectRef effect; 
	public SoundDefinition soundDef; 
	public Transform rootBone; 
	[ClientVar] 
	public static bool Hide; 
	private GameObject particleInstance; 
	private Sound sound; 
	private const float maxDistSq = 10000;


	private void OnEnable() { }

	private void Update() { }

	private void OnDisable() { }

	public void .ctor() { }

	private static void .cctor() { }

}

