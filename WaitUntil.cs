public sealed class WaitUntil : CustomYieldInstruction // TypeDefIndex: 3542
{	private Func<bool> m_Predicate; // 0x10

	public override bool keepWaiting { get; }


	public override bool get_keepWaiting() { }

	public void .ctor(Func<bool> predicate) { }

}

