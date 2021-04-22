using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace InsertionSortCAA
{
	public partial class MainForm : Form
	{
		private struct myRectangle
		{
			public Rectangle Rect;
			public int rectIndex;
			public Color Color;

			public myRectangle (Rectangle Rect, int rectIndex, Color Color)
			{
				this.Rect = Rect;
				this.rectIndex = rectIndex;
				this.Color = Color;
			}

		} 

		private int[] input;
		private myRectangle[] rectArr;
		private Point startPointRect = new Point(24, 75);
		private Size rectSize = new Size(60, 60);
		private Font drawFont = new Font("Arial", 20);
		private SolidBrush fontColor;
		private SolidBrush rectColor;
		private Pen pen;
		private StringFormat drawFormat;
		private bool isRed = true;
		private int rectToDraw = -1;

		public MainForm()
		{
			InitializeComponent();
			input = new int[StartForm.array.Count];
			rectArr = new myRectangle[StartForm.array.Count];
			pen = new Pen(Color.DeepSkyBlue, 5);
			fontColor = new SolidBrush(Color.DarkBlue);
			rectColor = new SolidBrush(Color.Green);
			drawFormat = new StringFormat();
			drawFormat.FormatFlags = StringFormatFlags.DirectionRightToLeft;
			drawFormat.LineAlignment = StringAlignment.Center;
			drawFormat.Alignment = StringAlignment.Center;
			FillArrays();
			Paint += new PaintEventHandler(DrawArray);
		}

		private void FillArrays()
		{
			for (int i = 0; i < input.Length; i++)
			{
				input[i] = StartForm.array[i];
				rectArr[i].Color = Color.Transparent;
			}
		}
		private void DrawArray(object sender, PaintEventArgs e)
		{
			for (int i = 0; i < StartForm.array.Count; i++)
			{
				rectArr[i].Rect = new Rectangle();
				rectArr[i].Rect.Size = rectSize;
				rectColor.Color = rectArr[i].Color;
				rectArr[i].Rect.Location = new Point(startPointRect.X + i * 60, startPointRect.Y);
				e.Graphics.DrawRectangle(pen, rectArr[i].Rect);
				e.Graphics.FillRectangle(rectColor, rectArr[i].Rect);
				e.Graphics.DrawString(input[i].ToString(), drawFont, fontColor, rectArr[i].Rect, drawFormat);
			}
		}

		private void FillAndUpdateRect(int index, Color color)
		{
			rectToDraw = index;
			rectArr[index].Color = color;
			Invalidate();
			Paint += new PaintEventHandler(DrawArray);
			UpdateAndPaint();
		}

		private void InsertionSort()
		{
			for (int i = 0; i < input.Length - 1; i++)
			{
				int previousNum = i - 1;
				if (previousNum == -1)
				{
					continue;
				}
				for (int j = i + 1; j > 0; j--)
				{
					if (j - 1 == -1 || j )
					{
						break;
					}
						bool foundSmallerNum = false;
					if (input[j - 1] > input[j])
					{
						foundSmallerNum = true;
						SignalizeCurrentState(j - 1, input[i], foundSmallerNum);
						int temp = input[j - 1];
						input[j - 1] = input[j];
						input[j] = temp;
					}
					else
					{
						SignalizeCurrentState(j - 1, input[i],  foundSmallerNum);
					}

					UpdateArray(j, j - 1, foundSmallerNum);
				}
			}

			Thread.Sleep(5000);
			Application.Exit();
		}


		private void DrawRect(object sender, PaintEventArgs e)
		{
			rectColor.Color = rectArr[rectToDraw].Color;
			e.Graphics.FillRectangle(rectColor, rectArr[rectToDraw].Rect);
			e.Graphics.DrawRectangle(pen, rectArr[rectToDraw].Rect);
			e.Graphics.DrawString(input[rectToDraw].ToString(), drawFont, fontColor, rectArr[rectToDraw].Rect, drawFormat);
		}
		private void UpdateArray (int currRecIndex, int prevRecIndex, bool foundSmallerNum)
		{
			for (int i = 0; i < input.Length; i++)
			{
				if (i == currRecIndex || i == prevRecIndex && foundSmallerNum)
				{
					continue;
				}

				rectArr[i].Color = Color.Transparent;
			}

			UpdateAndPaint();
			Thread.Sleep(2000);
			rectArr[currRecIndex].Color = Color.Transparent;
			rectArr[currRecIndex].Color = Color.Transparent;
			UpdateAndPaint();
		}
		private void SignalizeCurrentState (int previousNumIndex, int CurrentNumIndex, bool foundSmallerNum)
		{
			if (foundSmallerNum)
			{
				rectArr[CurrentNumIndex].Color = CurrentNumIndex > previousNumIndex + 1 ? Color.Green : Color.Yellow;
				FillAndUpdateRect(previousNumIndex, rectArr[CurrentNumIndex].Color);
				Thread.Sleep(1000);
				rectArr[previousNumIndex].Color = CurrentNumIndex > previousNumIndex + 1 ? Color.Yellow : Color.Green;
				FillAndUpdateRect(CurrentNumIndex, rectArr[CurrentNumIndex].Color);
				Thread.Sleep(1000);
				rectArr[CurrentNumIndex].Color = Color.Red;
				FillAndUpdateRect(previousNumIndex, rectArr[CurrentNumIndex].Color);
				rectArr[CurrentNumIndex].Color = Color.Red;
				FillAndUpdateRect(CurrentNumIndex, rectArr[CurrentNumIndex].Color);
				Thread.Sleep(2000);
			}
			else
			{
				FillAndUpdateRect(previousNumIndex, Color.Green);
				FillAndUpdateRect(previousNumIndex, rectArr[CurrentNumIndex].Color);
				Thread.Sleep(1000);
				FillAndUpdateRect(CurrentNumIndex, Color.Yellow);
				FillAndUpdateRect(previousNumIndex, rectArr[CurrentNumIndex].Color);
				Thread.Sleep(2000);
			}
		}

		private void UpdateAndPaint ()
		{
			Invalidate();
			Paint += new PaintEventHandler(DrawArray);
			Update();
		}
		private void controlButtonClicked(object sender, EventArgs e)
		{
			InsertionSort();
		}
	}
}

