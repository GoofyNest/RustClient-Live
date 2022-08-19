public abstract class ProceduralComponent : MonoBehaviour // TypeDefIndex: 10444
{	// Fields
	[InspectorFlagsAttribute] // RVA: 0x70A20 Offset: 0x6FE20 VA: 0x180070A20
	public ProceduralComponent.Realm Mode; // 0x18
	public string Description; // 0x20

	// Properties
	public virtual bool RunOnCache { get; }

	// Methods

	// RVA: 0x498AD0 Offset: 0x497ED0 VA: 0x180498AD0 Slot: 4
	public virtual bool get_RunOnCache() { }

	// RVA: 0x9881D0 Offset: 0x9875D0 VA: 0x1809881D0
	public bool ShouldRun() { }

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void Process(uint seed);

	// RVA: 0x988240 Offset: 0x987640 VA: 0x180988240
	protected void .ctor() { }

}

public enum ProceduralComponent.Realm // TypeDefIndex: 10445
{	// Fields
	public int value__; // 0x0
	public const ProceduralComponent.Realm Client = 1;
	public const ProceduralComponent.Realm Server = 2;

}

