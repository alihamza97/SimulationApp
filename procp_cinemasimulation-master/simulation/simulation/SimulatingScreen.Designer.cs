namespace simulation
{
	public partial class SimulatingScreen
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.simulatetimer = new System.Windows.Forms.Timer(this.components);
			this.timerobj = new System.Windows.Forms.Timer(this.components);
			this.SuspendLayout();
			// 
			// timer1
			// 
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// simulatetimer
			// 
			this.simulatetimer.Tick += new System.EventHandler(this.simulatetimer_Tick);
			// 
			// timerobj
			// 
			this.timerobj.Tick += new System.EventHandler(this.timerobj_Tick);
			// 
			// SimulatingScreen
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Black;
			this.ClientSize = new System.Drawing.Size(586, 306);
			this.DoubleBuffered = true;
			this.ForeColor = System.Drawing.Color.White;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "SimulatingScreen";
			this.Text = "SimulatingScreen";
			this.Load += new System.EventHandler(this.SimulatingScreen_Load);
			this.Paint += new System.Windows.Forms.PaintEventHandler(this.SimulatingScreen_Paint);
			this.ResumeLayout(false);

		}

		#endregion
		public System.Windows.Forms.Timer timer1;
		public System.Windows.Forms.Timer simulatetimer;
		public System.Windows.Forms.Timer timerobj;
	}
}