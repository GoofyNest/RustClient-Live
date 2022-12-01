public static class TaskExtensions // TypeDefIndex: 3193
{

	[ExtensionAttribute]
	public static Task<TResult> Unwrap<TResult>(Task<Task<TResult>> task) { }
	/* GenericInstMethod :
	|
	|-TaskExtensions.Unwrap<Dictionary<string, string>>
	|-TaskExtensions.Unwrap<object>
	*/

}

