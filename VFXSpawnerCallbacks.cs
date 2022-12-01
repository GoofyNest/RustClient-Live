public abstract class VFXSpawnerCallbacks : ScriptableObject // TypeDefIndex: 4767
{

[RequiredByNativeCodeAttribute]
[Serializable]
public abstract class VFXSpawnerCallbacks : ScriptableObject

	public abstract void OnPlay(VFXSpawnerState state, VFXExpressionValues vfxValues, VisualEffect vfxComponent);

	public abstract void OnUpdate(VFXSpawnerState state, VFXExpressionValues vfxValues, VisualEffect vfxComponent);

	public abstract void OnStop(VFXSpawnerState state, VFXExpressionValues vfxValues, VisualEffect vfxComponent);

	protected void .ctor() { }

}

