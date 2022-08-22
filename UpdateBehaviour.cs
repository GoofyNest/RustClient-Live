public abstract class UpdateBehaviour : MonoBehaviour // TypeDefIndex: 11335
{	internal float lastUpdate; // 0x18
	internal float nextUpdate; // 0x1C


	public abstract void DeltaUpdate(float deltaTime);

	protected void Sleep(float seconds) { }

	protected void SleepAccumulative(float seconds) { }

	protected virtual void OnEnable() { }

	protected virtual void OnDisable() { }

	protected void .ctor() { }

}

