public abstract class ProceduralComponent : MonoBehaviour // TypeDefIndex: 12163
{
	[InspectorFlagsAttribute] 
	public ProceduralComponent.Realm Mode; 
	public string Description; 

	public virtual bool RunOnCache { get; }


	public virtual bool get_RunOnCache() { }

	public bool ShouldRun() { }

	public abstract void Process(uint seed);

	protected void .ctor() { }

}

public enum ProceduralComponent.Realm // TypeDefIndex: 12164
{
	public int value__; 
	public const ProceduralComponent.Realm Client = 1;
	public const ProceduralComponent.Realm Server = 2;

}

