namespace Soundify
{
    internal class Info
    {
        public static string Name { get; } = "Soundify";
        public const string AppVersion = "1.0";
        public const string GUID = "5dc5efe6-53e6-4f36-b917-c4ab552f9624";
        public const string Author = "Scrim (Scrimmane) & Terkoshi (TK)";
        public const string Description = "A multi-streaming tool";
    }

    internal static class Program
    {
        private static readonly Mutex mutex = new(true, Info.GUID);
        [STAThread]
        static void Main()
        {
            if (mutex.WaitOne(TimeSpan.Zero, true))
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new MainWindow());
                Application.DoEvents();
                mutex.ReleaseMutex();
            }
            else
            {
                MessageBox.Show("Soundify is already running!", Info.Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
