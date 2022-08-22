public abstract class ProceduralComponent : MonoBehaviour // TypeDefIndex: 10444
{	[InspectorFlagsAttribute] // RVA: 0x70A20 Offset: 0x6FE20 VA: 0x180070A20
	public ProceduralComponent.Realm Mode; // 0x18
	public string Description; // 0x20

	public virtual bool RunOnCache { get; }


	public virtual bool get_RunOnCache() { }

	public bool ShouldRun() { }

	public abstract void Process(uint seed);

	protected void .ctor() { }

}

public enum ProceduralComponent.Realm // TypeDefIndex: 10445
{	public int value__; // 0x0
	public const ProceduralComponent.Realm Client = 1;
	public const ProceduralComponent.Realm Server = 2;

}

