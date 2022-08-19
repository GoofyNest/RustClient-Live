internal class ConstraintEnumerator // TypeDefIndex: 4177
{
// Namespace: System.Data
internal class ConstraintEnumerator // TypeDefIndex: 4177
	// Fields
	private IEnumerator _tables; // 0x10
	private IEnumerator _constraints; // 0x18
	private Constraint _currentObject; // 0x20

	// Properties
	protected Constraint CurrentObject { get; }

	// Methods

	// RVA: 0x1223C20 Offset: 0x1223020 VA: 0x181223C20
	public void .ctor(DataSet dataSet) { }

	// RVA: 0x1223990 Offset: 0x1222D90 VA: 0x181223990
	public bool GetNext() { }

	// RVA: 0x497E00 Offset: 0x497200 VA: 0x180497E00
	public Constraint GetConstraint() { }

	// RVA: 0x4D1BF0 Offset: 0x4D0FF0 VA: 0x1804D1BF0 Slot: 4
	protected virtual bool IsValidCandidate(Constraint constraint) { }

	// RVA: 0x497E00 Offset: 0x497200 VA: 0x180497E00
	protected Constraint get_CurrentObject() { }

}

