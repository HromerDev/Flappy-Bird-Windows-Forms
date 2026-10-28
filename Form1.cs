using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test
{
	public partial class Form1 : Form
	{
		const int resolution = 750; // forms resolution (1:1)
		//
		
		public static Random rng = new Random();
		public static int pipeSpeed = 3;
		//	
		int score = 0;
		short frameCounter = 0;
		short frameCounterSpeed = 0;
				
		public Form1()
		{
			InitializeComponent();
		}

		class Player 
		{
			public int acceleration = 0;
			const int gravity = 2;
			public PictureBox player;
			public Player(PictureBox player) 
			{
				this.player = player;
			}

			public void Movement() 
			{
				if (!(player.Location.Y + acceleration * gravity < resolution - player.Height)) // floor check
				{
					player.Location = new Point(player.Location.X, resolution - player.Height - 20);
					return;
				}
				player.Location = new Point(player.Location.X, player.Location.Y + acceleration * gravity); // gravity 
				acceleration++;
			}
			public void Jump() 
			{
				if (player.Location.Y > 0) //jump
					acceleration = -9;
			}
		}

		class PipeArrays 
		{				
			public int x;
			public PictureBox[] pipes = new PictureBox[2];
			public PipeArrays(PictureBox pipe1, PictureBox pipe2) 
			{				
				pipes[0] = pipe1;
				pipes[1] = pipe2;
			}
			public void MovePipes()
			{
				foreach (PictureBox pipe in pipes) 
				{
					x -= pipeSpeed;
					pipe.Location = new Point(x, pipe.Location.Y); 
				}

				if (pipes[0].Location.X < -pipes[0].Width) // move back to right				
					PipeInnit();																	
			}
			public void PipeInnit()
			{
				int i = Random(220, 720); // 220 is minimum required for bird to fit in

				x = pipes[0].Width + resolution + Random(400,600); //initial position

				pipes[0].Location = new Point(x, i); // lower pipe

				if(pipes[0].Location.Y - 480  < 20)
					pipes[1].Location = new Point(x, 20 - 480); // upper pipe is too high, put lower
				else
					pipes[1].Location = new Point(x, pipes[0].Location.Y - 480 - 350); // upper pipe is just fine, keep
			}
		}
		Player player;
		PipeArrays[] pipeArrays = new PipeArrays[3];
		Label[] debugValues = new Label[3];

		private void Form1_Load(object sender, EventArgs e)
		{
			debugValues[0] = Debug0;
			debugValues[1] = Debug1;
			debugValues[2] = Debug2;

			debugValues[0].Location = new Point(resolution - debugValues[0].Width * 2, 0);

			for (int i = 1; i < debugValues.Length; i++)
			{
				debugValues[i].Location = new Point((debugValues[0].Location.X), i * debugValues[0].Height);
			}

			player = new Player(birb);
			EndText.Location = new Point(750 / 2 - EndText.Width / 2, 250);
			EndText.Hide();
			this.FormBorderStyle = FormBorderStyle.FixedSingle;
			this.Height = resolution;
			this.Width = resolution;
						
			pipeArrays[0] = new PipeArrays(LowerPipe1, UpperPipe1);
			pipeArrays[1] = new PipeArrays(LowerPipe2, UpperPipe2);
			pipeArrays[2] = new PipeArrays(LowerPipe3, UpperPipe3);

			foreach (PipeArrays arrays in pipeArrays)
				arrays.PipeInnit();

			pipeArrays[0].x = resolution + 160; //initial pipe placement
			pipeArrays[1].x = resolution + 160 * 5;
			pipeArrays[2].x = resolution + 160 * 8;						
		}

		private void FrameTimer_Tick(object sender, EventArgs e)
		{
			//debug stuff
			
			//ObjectCollision();

			if (ObjectCollision()) 
			{
				FrameTimer.Enabled = false;
				EndText.Show();
			}

			//interface values
			debugValues[0].Text =  1000 / FrameTimer.Interval + "fps";
			debugValues[1].Text = "X:" + player.player.Location.X + " Y:" + player.player.Location.Y;
			debugValues[2].Text = "Difficulty:" + pipeSpeed + "/10";
			label1.Text = score.ToString(); // score

			foreach (PipeArrays pipeArrays in pipeArrays) //moving pipes
				pipeArrays.MovePipes();
			
			//lazy way of handling desync between pipe arrays
			if (Math.Abs(pipeArrays[0].x - pipeArrays[2].x) < 720)
				pipeArrays[0].x = pipeArrays[2].x + 720;
			if (Math.Abs(pipeArrays[1].x - pipeArrays[0].x) < 480)
				pipeArrays[1].x = pipeArrays[0].x + 480;
			if (Math.Abs(pipeArrays[2].x - pipeArrays[1].x) < 480)
				pipeArrays[2].x = pipeArrays[1].x + 480;

			player.Movement();
			
			if (frameCounterSpeed > 450 && pipeSpeed < 10) // speed increase
			{
				pipeSpeed++;				
				frameCounterSpeed = 0;
			}
			frameCounterSpeed++;
		}
		private void jumpButton_Click(object sender, EventArgs e)
		{
			player.Jump();
		}
		bool ObjectCollision() 
		{			
			for (int i = 0; i < pipeArrays.Length; i++)	
				for (int y = 0; y < 2; y++)				
					if (birb.Location.X + birb.Width > pipeArrays[i].pipes[y].Location.X && // X axis collision check
						birb.Location.X + birb.Width < pipeArrays[i].pipes[y].Location.X + pipeArrays[i].pipes[y].Width)
					{
						switch (y) 
						{
							case 0: // Y axis lower check
								if (birb.Location.Y + birb.Height / 4 * 3 > pipeArrays[i].pipes[y].Location.Y)
									return true;
								break;
							case 1: // Y axis upper check
								if (birb.Location.Y + birb.Height / 4 * 3 < pipeArrays[i].pipes[y].Location.Y + pipeArrays[i].pipes[y].Height)
									return true;						
								break;
						}

						if (frameCounter >= 20 && // inbetween check + adding score 
							birb.Location.X + birb.Location.X / 2 > pipeArrays[i].pipes[y].Location.X + pipeArrays[i].pipes[y].Location.X / 2 - 10 &&
							birb.Location.X + birb.Location.X / 2 > pipeArrays[i].pipes[y].Location.X + pipeArrays[i].pipes[y].Location.X / 2 - 10)
						{
							score++;
							frameCounter = 0;							
						}
					}

			frameCounter++;
			return false;
		}
		static int Random(int min, int max)
		{
			return rng.Next(min, max);
		}
		private void label2_Click(object sender, EventArgs e)
		{
			FrameTimer.Enabled = true;

			pipeArrays[0].x = resolution + 160; //initial pipe placement
			pipeArrays[1].x = resolution + 160 * 5;
			pipeArrays[2].x = resolution + 160 * 8;

			EndText.Hide();						
			player.player.Location = new Point(player.player.Location.X, 150);
			pipeSpeed = 3;
			player.acceleration = 0;
			score = 0;		
		}
	}
}
