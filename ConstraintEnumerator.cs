internal class ConstraintEnumerator // TypeDefIndex: 4177
{
internal class ConstraintEnumerator // TypeDefIndex: 4177
	private IEnumerator _tables; // 0x10
	private IEnumerator _constraints; // 0x18
	private Constraint _currentObject; // 0x20

	protected Constraint CurrentObject { get; }


	public void .ctor(DataSet dataSet) { }

	public bool GetNext() { }

	public Constraint GetConstraint() { }

	protected virtual bool IsValidCandidate(Constraint constraint) { }

	protected Constraint get_CurrentObject() { }

}

