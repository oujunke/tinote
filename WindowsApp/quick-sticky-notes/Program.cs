﻿using System;
using System.Text;
using System.Windows.Forms;

namespace quick_sticky_notes
{
	static class Program
	{
		[STAThread]
		static void Main()
		{
			Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);

            Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new MainForm());
		}
	}
}
