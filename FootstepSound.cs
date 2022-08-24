public class FootstepSound : MonoBehaviour, IClientComponent // TypeDefIndex: 8992
{
	public SoundDefinition lightSound; 
	public SoundDefinition medSound; 
	public SoundDefinition hardSound; 
	private const float panAmount = 0,05;


	public void PlayFootstep(FootstepSound.Hardness hardness, bool localPlayer = False, GameObject sourceObject, bool left = False) { }

	private SoundDefinition GetSound(FootstepSound.Hardness hardness) { }

	public void .ctor() { }

}

public enum FootstepSound.Hardness // TypeDefIndex: 8993
{
	public int value__; 
	public const FootstepSound.Hardness Light = 1;
	public const FootstepSound.Hardness Medium = 2;
	public const FootstepSound.Hardness Hard = 3;

}

