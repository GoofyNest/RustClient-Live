internal class ReadContentAsBinaryHelper // TypeDefIndex: 1860
{
	private XmlReader reader; 
	private ReadContentAsBinaryHelper.State state; 
	private int valueOffset; 
	private bool isEnd; 


	internal void Finish() { }

	internal void Reset() { }

	private bool MoveToNextContentNode(bool moveIfOnContentNode) { }

}

private enum ReadContentAsBinaryHelper.State // TypeDefIndex: 1861
{
	public int value__; 
	public const ReadContentAsBinaryHelper.State None = 0;
	public const ReadContentAsBinaryHelper.State InReadContent = 1;
	public const ReadContentAsBinaryHelper.State InReadElementContent = 2;

}

