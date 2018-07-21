namespace RipeLookup
{
	public partial class TextForm : System.Windows.Forms.Form
	{
		public TextForm() => InitializeComponent();

		public static void Show(string text)
		{
			var t = new TextForm();
			t.textBox1.Text = text;
			t.Show();
		}
	}
}
