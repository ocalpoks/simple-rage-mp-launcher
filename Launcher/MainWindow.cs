using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Launcher
{
    public partial class MainWindow : Form
    {
        public string pathGTA;
        public string pathRAGE;

        public string ip;
        public string port;
        public string name;

        public bool IsEpic;
        public bool IsSteam;
        public bool IsSocial;

        public Process rage;

        public MainWindow()
        {
            InitializeComponent();

            showDirectory.Text = SelectDirectory.SelectedPath;
        }

        private void SelectDirectoryGTA5_Click(object sender, EventArgs e)
        {
            if (SelectDirectory.ShowDialog() == DialogResult.OK)
            {
                showDirectory.Text = SelectDirectory.SelectedPath;
            }
        }

        private void Connect_Click(object sender, EventArgs e)
        {
            pathGTA = SelectDirectory.SelectedPath;

            if (!System.IO.File.Exists(Path.Combine(pathGTA, "GTA5.exe")))
            {
                int error = (int)MessageBox.Show("Неверный путь к игре. Укажите в настройках правильный", "Ошибка запуска", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }

            ip = ip_textbox.Text;
            port = port_textbox.Text;
            name = name_textbox.Text;

            Launch();

        }

        
        private void Launch()
        {
            RegistryKey reg = Registry.CurrentUser.CreateSubKey("Software\\RAGE-MP");

            reg.SetValue("player_name", name);

            pathRAGE = reg.GetValue("rage_path").ToString();

            this.rage = new Process();

            this.rage.StartInfo = new ProcessStartInfo()
            {
                FileName = Path.Combine(this.pathRAGE, "updater.exe"),
                UseShellExecute = true,
                WorkingDirectory = pathRAGE
            };

            this.rage.EnableRaisingEvents = true;
            this.rage.Start();
            this.Hide();
            this.rage.Exited += (EventHandler)((a, b) =>
            {
                foreach (Process process in Process.GetProcessesByName("ragemp_v"))
                    process.Kill();

                object obj = Registry.CurrentUser.OpenSubKey("Software\\RAGE-MP").GetValue("type");

                if (obj == null)
                {
                    int num = (int)MessageBox.Show("Запустите клиент RAGE и дождитесь обновления.");
                }
                else
                {
                    string str = obj.ToString();
                    IsEpic = str == "egs";
                    IsSteam = str == "steam";
                    IsSocial = str != "egs" && str != "steam";
                }

                Process gta5 = new Process();
                if (IsEpic)
                {
                    gta5.StartInfo = new ProcessStartInfo()
                    {
                        FileName = "com.epicgames.launcher://apps/9d2d0eb64d5c44529cece33fe2a46482?action=launch&silent=true",
                        UseShellExecute = true
                    };
                    gta5.Start();
                }
                else if (this.IsSteam)
                {
                    gta5.StartInfo = new ProcessStartInfo()
                    {
                        FileName = "steam://rungameid/271590",
                        UseShellExecute = true
                    };
                    gta5.Start();
                }
                else
                {
                    gta5.StartInfo = new ProcessStartInfo()
                    {
                        FileName = Path.Combine(pathGTA, "PlayGTAV.exe"),
                        WorkingDirectory = pathGTA
                    };
                    gta5.Start();
                }
                System.Threading.Timer timer = new System.Threading.Timer((TimerCallback)(aa =>
                {
                    while (true)
                    {
                        do
                            ;
                        while (((IEnumerable<Process>)Process.GetProcessesByName("GTA5")).Count<Process>() == 0);
                        reg.SetValue("launch.ip", (object)ip);
                        reg.SetValue("launch.port", (object)port.ToString());
                        reg.SetValue("launch.password", (object)"");
                        reg.SetValue("launch.type", (object)"connect");
                        reg.SetValue("rage-type", (object)"legacy");
                        ProcessStartInfo processStartInfo1 = new ProcessStartInfo();
                        processStartInfo1.Arguments = "--process-name GTA5.exe";
                        ProcessStartInfo processStartInfo2 = processStartInfo1;
                        processStartInfo2.Arguments = processStartInfo2.Arguments + " --inject \"" + Path.Combine(this.pathRAGE, "loader.dll") + "\"";
                        processStartInfo1.FileName = "Injector.exe";
                        processStartInfo1.CreateNoWindow = true;
                        processStartInfo1.UseShellExecute = false;
                        new Process() { StartInfo = processStartInfo1 }.Start();
                        Environment.Exit(0);
                    }
                }), (object)null, 0, -1);
            });
        }
        
        
    }
}
