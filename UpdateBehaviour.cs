public abstract class UpdateBehaviour : MonoBehaviour // TypeDefIndex: 13087
{
	internal float lastUpdate; 
	internal float nextUpdate; 


	public abstract void DeltaUpdate(float deltaTime);

	protected void Sleep(float seconds) { }

	protected void SleepAccumulative(float seconds) { }

	protected virtual void OnEnable() { }

	protected virtual void OnDisable() { }

	protected void .ctor() { }

}

