namespace Yella.UserControl;

public sealed class ProgressStep
{
	public string Title { get; set; }
	public DateTime StartingDate { get; set; }
	public DateTime EndingDate { get; set; }
	public string Description { get; set; }
	public string Status { get; set; }
	public int Value { get; set; }
}