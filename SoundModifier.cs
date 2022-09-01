public class SoundModifier : MonoBehaviour // TypeDefIndex: 9037
{
	[HideInInspector] 
	public Sound sound; 


	public virtual void Init(Sound targetSound) { }

	public virtual void ApplyModification() { }

	public virtual void OnSoundPlay() { }

	public void .ctor() { }

}

