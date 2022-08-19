public abstract class PlayableBehaviour : IPlayableBehaviour, ICloneable // TypeDefIndex: 3866
{	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 13
	public virtual void OnGraphStart(Playable playable) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 14
	public virtual void OnGraphStop(Playable playable) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 15
	public virtual void OnPlayableCreate(Playable playable) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 16
	public virtual void OnPlayableDestroy(Playable playable) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 17
	public virtual void OnBehaviourPlay(Playable playable, FrameData info) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 18
	public virtual void OnBehaviourPause(Playable playable, FrameData info) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 19
	public virtual void PrepareFrame(Playable playable, FrameData info) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 20
	public virtual void ProcessFrame(Playable playable, FrameData info, object playerData) { }

	// RVA: 0x18F52D0 Offset: 0x18F46D0 VA: 0x1818F52D0 Slot: 21
	public virtual object Clone() { }

}

