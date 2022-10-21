public class SoundPlayer : BaseMonoBehaviour, IClientComponent, IOnParentDestroying // TypeDefIndex: 10755
{
	public SoundDefinition soundDefinition; 
	public bool playImmediately; 
	public float minStartDelay; 
	public float maxStartDelay; 
	public bool debugRepeat; 
	public bool pending; 
	public Vector3 soundOffset; 
	private int playOnFrame; 
	[CompilerGeneratedAttribute] 
	private Sound <sound>k__BackingField; 

	public Sound sound { get; set; }


	[CompilerGeneratedAttribute] 
	public Sound get_sound() { }

	[CompilerGeneratedAttribute] 
	protected void set_sound(Sound value) { }

	protected void Awake() { }

	protected void OnEnable() { }

	public void DoPendingUpdate() { }

	public bool ShouldStartThisFrame() { }

	public void Play() { }

	public void PlayOneshot() { }

	public void PlayOneshotRandomDelay(float min = 0, float max = 1) { }

	public void FadeInAndPlay(float time = 0,5) { }

	public void FadeOutAndRecycle(float time = 0,5) { }

	public virtual void CreateSound() { }

	public bool IsPlaying() { }

	public bool HasSound() { }

	public void DestroySound() { }

	public void Stop() { }

	public void MakeThirdPerson() { }

	public void MakeFirstPerson() { }

	public float GetLength() { }

	public void OnParentDestroying() { }

	public void .ctor() { }

}

