internal class ConstraintEnumerator // TypeDefIndex: 4182
{

internal class ConstraintEnumerator
	private IEnumerator _tables; 
	private IEnumerator _constraints; 
	private Constraint _currentObject; 

	protected Constraint CurrentObject { get; }


	public void .ctor(DataSet dataSet) { }

	public bool GetNext() { }

	public Constraint GetConstraint() { }

	protected virtual bool IsValidCandidate(Constraint constraint) { }

	protected Constraint get_CurrentObject() { }

}

