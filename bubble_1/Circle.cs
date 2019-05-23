using System.Drawing;
using System.Windows.Forms;

namespace bubble_1 {
	class Circle {
		public int x;
		public int y;
		public int r;

		public int thickness;

		int realX; //The x value to draw the circle from the center. This is not the center x value
		int realY;

		int width;
		int height;

		public bool growing = true;

		public Circle(int x, int y, int radius, int thickness, PictureBox px) {
			this.x = x;
			this.y = y;
			this.r = radius;
			this.thickness = thickness;

			width = px.Width;
			height = px.Height;
		}

		public void Show(Bitmap b, PictureBox px) {
			Graphics g = Graphics.FromImage(b);
			g.DrawEllipse(new Pen(Color.White, thickness), new Rectangle(realX, realY, r * 2, r * 2));
			//g.DrawRectangle(new Pen(Color.Red, 1), new Rectangle(x, y, 1, 1));
			//g.DrawLine(new Pen(Color.Green, 1), x, y, x + r, y);
			px.Image = b;
		}

		public void Grow() {
			if(growing) {
				r += 1;
				realX = x - r;
				realY = y - r;
			}
		}

		public bool Edge() {
			return (x + r + thickness > width || x - r - thickness < 0 || y + r + thickness > height || y - r - thickness < 0);
		}

	}
}
