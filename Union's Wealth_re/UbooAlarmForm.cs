using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.Media;

namespace Union_s_Wealth_re
{
	public partial class UbooAlarmForm : Form
	{
		private const int SECOND = 60;
		private const int PER = 100;

		private static Thread uth = null;
		private static Thread mth = null;

		private SoundPlayer unionPlayer;
		private SoundPlayer mesoPlayer;

		private Color defaultColor;

		private double mesoTime = 100;
		private Thread Uth
		{
			get
			{
				if (uth == null || !uth.IsAlive)
					uth = new Thread(new ParameterizedThreadStart(Process));

				return uth;
			}
			set
			{
				uth = value;
			}
		}

		private Thread Mth
		{
			get
			{
				if (mth == null || !mth.IsAlive)
					mth = new Thread(new ParameterizedThreadStart(Process));

				return mth;
			}
			set
			{
				mth = value;
			}
		}

		public UbooAlarmForm()
		{
			InitializeComponent();
			stopUnionButton.Enabled = false;
			stopMesoButton.Enabled = false;

			unionPlayer = new SoundPlayer(Union_s_Wealth_re.Properties.Resources.union);
			mesoPlayer = new SoundPlayer(Union_s_Wealth_re.Properties.Resources.meso);

			defaultColor = this.BackColor;
		}

		private void executeUnionButton_Click(object sender, EventArgs e)
		{
			ExecuteUnion();
		}

		private void stopUnionButton_Click(object sender, EventArgs e)
		{
			StopUnion();
		}

		private void executeMesoButton_Click(object sender, EventArgs e)
		{
			ExecuteMeso();
		}

		private void stopMesoButton_Click(object sender, EventArgs e)
		{
			StopMeso();
		}

		private void set100secButton_Click(object sender, EventArgs e)
		{
			mesoTime = 100;
			mesoStatusLabel.Text = mesoTime.ToTimeFormat();
		}

		private void set80secButton_Click(object sender, EventArgs e)
		{
			mesoTime = 80;
			mesoStatusLabel.Text = mesoTime.ToTimeFormat();
		}

		private void timeTextBox_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
				ExecuteUnion();
		}

		private void Form1_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (Uth.IsAlive)
			{
				Console.WriteLine("Interrupt  for Form Close");
				Uth.Interrupt();

				Console.WriteLine("Waiting until thread stops  for Form Close");
				Uth.Join();
			}

			if(Mth.IsAlive) {
				Console.WriteLine("Interrupt  for Form Close");
				Mth.Interrupt();

				Console.WriteLine("Waiting until thread stops  for Form Close");
				Mth.Join();
			}
		}

		private void ExecuteUnion()
		{
			Uth.Start(Category.UNION);
			stopUnionButton.Enabled = true;
			executeUnionButton.Enabled = false;
		}

		private void StopUnion()
		{
			Console.WriteLine("Interrupting Union Thread");
			Uth.Interrupt();

			Console.WriteLine("Waiting until Union thread stops");
			Uth.Join();

			this.BackColor = defaultColor;
			stopUnionButton.Enabled = false;
			executeUnionButton.Enabled = true;
		}

		private void ExecuteMeso()
		{
			Mth.Start(Category.MESO);
			stopMesoButton.Enabled = true;
			executeMesoButton.Enabled = false;
			set100secButton.Enabled = false;
			set80secButton.Enabled = false;
		}

		private void StopMeso()
		{
			Console.WriteLine("Interrupting Meso Thread");
			Mth.Interrupt();

			Console.WriteLine("Waiting until Meso thread stops");
			Mth.Join();

			this.BackColor = defaultColor;
			stopMesoButton.Enabled = false;
			executeMesoButton.Enabled = true;
			set100secButton.Enabled = true;
			set80secButton.Enabled = true;
		}

		private void Process(object param)
		{
			Category category = (Category)param;
			int count;
			Thread timeThread = null;

			if (category == Category.UNION)
				count = (int)(Convert.ToDouble(timeTextBox.Text) * SECOND);
			else
				count = (int)mesoTime;

			try
			{
				while (true)
				{
					if (timeThread == null || !timeThread.IsAlive)
					{
						if (category == Category.UNION)
						{
							unionProgressBar.Value = PER;
							if (timeThread != null)
							{
								Color tmp = defaultColor;
								this.BackColor = Color.Red;
								Thread.Sleep(2000);
								this.BackColor = tmp;
							}
						}

						timeThread = new Thread(new ParameterizedThreadStart(TimeProcess));
						object[] parameters = { count, category };
						timeThread.Start(parameters);
					}

					Thread.Sleep(100);
				}

			}
			catch (ThreadInterruptedException e)
			{
				Console.WriteLine(e);
			}
			catch (Exception e)
			{
				Console.WriteLine(e);
			}
			finally
			{
				timeThread.Interrupt();
				timeThread.Join();
				Console.WriteLine("Clean resource : Process");
			}
		}

		private void TimeProcess(object _param)
		{
			object[] param = (object[])_param;
			int goal = (int)param[0];
			int count = (int)param[0];
			Category category = (Category)param[1];
			try
			{
				while (count >= 0)
				{
					int sec = count % SECOND;
					int min = count / SECOND;
					if (category == Category.UNION)
						unionStatusLabel.Text = string.Format("{0}분 {1}초", min, sec);
					else
						mesoStatusLabel.Text = string.Format("{0}분 {1}초", min, sec);

					Console.WriteLine("cnt : {0}", count);
					Console.WriteLine("count : {0}, goal : {1}, percent : {2}", count, goal, (int)(((double)count / goal) * PER));
					try
					{
						if (category == Category.UNION)
							unionProgressBar.Value = (int)(((double)count / goal) * PER);
						else
							mesoProgressBar.Value = (int)(((double)count / goal) * PER);

					}
					catch (InvalidOperationException e)
					{
						Console.WriteLine(e);
					}

					count--;
					Thread.Sleep(1000);
				}
			}
			catch (ThreadInterruptedException e)
			{
				Console.WriteLine(e);
			}
			catch(Exception e) {
				Console.WriteLine(e);
			}
			finally
			{
				if (count <= 0)
				{
					if (category == Category.UNION)
						unionPlayer.Play();
					else
						mesoPlayer.Play();
				}
				Console.WriteLine("TimeProcess Closing");
			}
		}

		enum Category
		{
			UNION,
			MESO
		}
	}
	static class Util
	{
		public static string ToTimeFormat(this double time)
		{
			int sec = (int)(time % 60);
			int min = (int)(time / 60);
			Console.WriteLine("time : " + time);
			return string.Format("{0}분 {1}초", min, sec);
		}
	}
}
