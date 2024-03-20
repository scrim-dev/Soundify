using System.Media;

namespace Soundify.Utils
{
    internal class Alerts
    {
        public static void SuccessTone()
        {
            Stream str = Resources.Success;
            SoundPlayer snd = new(str);
            try { snd.Play(); } catch { }
        }

        public static void ErrorTone()
        {
            Stream str = Resources.Failure;
            SoundPlayer snd = new(str);
            try { snd.Play(); } catch { }
        }
    }
}
