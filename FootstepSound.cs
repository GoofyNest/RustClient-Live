public class FootstepSound : MonoBehaviour, IClientComponent // TypeDefIndex: 10719
{
	public SoundDefinition lightSound; 
	public SoundDefinition medSound; 
	public SoundDefinition hardSound; 
	private const float panAmount = 0,05;


	public void PlayFootstep(FootstepSound.Hardness hardness, bool localPlayer = False, GameObject sourceObject, bool left = False) { }

	private SoundDefinition GetSound(FootstepSound.Hardness hardness) { }

	public void .ctor() { }

}

public enum FootstepSound.Hardness // TypeDefIndex: 10720
{
	public int value__; 
	public const FootstepSound.Hardness Light = 1;
	public const FootstepSound.Hardness Medium = 2;
	public const FootstepSound.Hardness Hard = 3;

}

