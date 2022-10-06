public sealed class WaitUntil : CustomYieldInstruction // TypeDefIndex: 3544
{
	private Func<bool> m_Predicate; 

	public override bool keepWaiting { get; }


	public override bool get_keepWaiting() { }

	public void .ctor(Func<bool> predicate) { }

}

