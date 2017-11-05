using System.Runtime.InteropServices;
using System.Windows.Forms;

public partial class BeepSoundGen
{

    [DllImport("kernel32.dll")]
    public static extern bool Beep(int n, int m);

    public void BeepGen(int Freq,int TimeinMillis)
    {
        Beep(Freq,TimeinMillis);
    }
}