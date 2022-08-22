public class SoundPlayer : BaseMonoBehaviour, IClientComponent, IOnParentDestroying // TypeDefIndex: 9039
{	public SoundDefinition soundDefinition; // 0x18
	public bool playImmediately; // 0x20
	public float minStartDelay; // 0x24
	public float maxStartDelay; // 0x28
	public bool debugRepeat; // 0x2C
	public bool pending; // 0x2D
	public Vector3 soundOffset; // 0x30
	private int playOnFrame; // 0x3C
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Sound <sound>k__BackingField; // 0x40

	public Sound sound { get; set; }


	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public Sound get_sound() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
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

