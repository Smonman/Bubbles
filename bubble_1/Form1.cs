using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bubble_1 {
	public partial class Form1 : Form {
		public Form1() {
			InitializeComponent();
			Setup();
		}

		int startRadius = 0;
		int thickness = 0;

		int intervall = 0;
		int maxCircelsPerTick = 0;
		int maxAttempts = 0;

		int maxSize = 0;

		int totalCircles = 0;

		int width = 0;
		int height = 0;

		Bitmap backImg;
		Bitmap bitmap;
		Graphics graphics;
		Random random = new Random();

		List<Circle> circles;

		Color[,] pixels;

		private void button_start_Click(object sender, EventArgs e) {
			startRadius = (int)numericUpDown_startRadius.Value;
			thickness = (int)numericUpDown_thickness.Value;
			intervall = (int)numericUpDown_Intervall.Value;
			maxCircelsPerTick = (int)numericUpDown_maxCircelsPerTick.Value;
			maxAttempts = (int)numericUpDown_maxAttemptsPerTick.Value;
			maxSize = (int)numericUpDown_maxSize.Value;

			graphics.FillRectangle(new SolidBrush(Color.Black), new Rectangle(0, 0, pictureBox1.Width, pictureBox1.Height)); //Hintergrund mit schwarz gefüllt
			pictureBox1.Image = bitmap;

			timer1.Interval = intervall;
			timer1.Start();
		}
		
		void OpenImageDialog() {
			using(OpenFileDialog dialog = new OpenFileDialog()) {
				dialog.Title = "Open Image";
				dialog.Filter = "Bitmap (*.bmp)|*.bmp|JPEG (*.jpg, *.jpeg)|*.jpg;*.jpeg|PNG (*.png)|*.png|TIFF (*.tif, *.tiff)|*.tif;*.tiff";
				if(dialog.ShowDialog() == DialogResult.OK) {
					backImg = (Bitmap)Bitmap.FromFile(dialog.FileName);
					backImg = new Bitmap(backImg, new Size(width, height));
					pictureBox1.Image = backImg;
					textBox_imagePath.Text = dialog.FileName;
					LoadPixels();
				}
			}
		}

		void LoadPixels() {
			if(backImg != null) {
				pixels = new Color[width, height];
				for(int x = 0; x < width; x++) {
					for(int y = 0; y < height; y++) {
						pixels[x, y] = backImg.GetPixel(x, y);
					}
				}
			}
		}

		void Setup() {
			width = pictureBox1.Width;
			height = pictureBox1.Height;
			backImg = null;
			bitmap = new Bitmap(width, height);
			graphics = Graphics.FromImage(bitmap); //Es wird die Bitmap verändert, und dann in die Picture Box zu laden, um flackern zu verhindern
			circles = new List<Circle>();
			totalCircles = 0;
			label_totalCircles.Text = totalCircles.ToString();
		}

		void CreateCircle() {
			int circlesPerTick = 0;
			int attempts = 0;
			bool valid = true;

			while(circlesPerTick < maxCircelsPerTick) { //Jeden Tick wird versucht eine gewisse anzahl an Kreisen zu  erstellen.
				int x = random.Next(0, pictureBox1.Width); //zufällige Position
				int y = random.Next(0, pictureBox1.Height);

				valid = true;

				if(backImg != null) {
					if(pixels[x,y].GetBrightness() == 1) {
						valid = true;
					} else {
						valid = false;
						attempts++;
						break;
					}
				}

				foreach(Circle c in circles) {
					int distance = Convert.ToInt32(Math.Sqrt(Math.Pow(c.x - x, 2) + Math.Pow(c.y - y, 2)));
					if(distance < c.r) { //Ob die Distanz des neunen Punktes weit genug entfernt ist von allen anderen punkten, damit der punkt nicht in einem anderen Kreis ist.
						valid = false;
						attempts++;
						break;
					}
				}

				if(valid) {
					circles.Add(new Circle(x, y, startRadius, thickness, pictureBox1));
					circlesPerTick++;
					totalCircles++;
				}

				if(attempts > maxAttempts) {
					return;
				}
			}
		}

		void Draw() {
			graphics.FillRectangle(new SolidBrush(Color.Black), new Rectangle(0, 0, width, height)); //Hintergrund mit schwarz gefüllt

			pictureBox1.Image = bitmap;

			foreach(Circle c in circles) { //Für jeden Kreis
				if(c.growing) { //Wenn der Kreis noch wächst
					if(c.r > maxSize) {
						c.growing = false;
					}
					if(c.Edge()) { //dann wird geschaut, ob er eh nicht den Rand berührt
						c.growing = false;
					} else {
						foreach(Circle otherC in circles) { //Wenn nicht, dann wird für jeden Kreis alle Kreise durchgeschaut
							if(c != otherC) { //Wenn der Kreis nicht sich selber anschaut
								int distance = Convert.ToInt32(Math.Sqrt(Math.Pow(otherC.x - c.x, 2) + Math.Pow(otherC.y - c.y, 2)));
								if(distance - c.thickness < c.r + otherC.r) { //Wenn der Kreis von jedem anderen Kreis weit genug entfernt ist, damit sie nicht überlappen
									c.growing = false;
								}
							}
						}
					}
					c.Grow(); //Jeder Kreis Wächst
				}
				c.Show(bitmap, pictureBox1); //Jeder Kreis wird gezeichnet
			}

			label_totalCircles.Text = totalCircles.ToString();
		}

		private void timer1_Tick(object sender, EventArgs e) {
			CreateCircle();
			Draw();
		}

		private void pictureBox1_Resize(object sender, EventArgs e) {
			width = pictureBox1.Width;
			height = pictureBox1.Height;

			if(backImg != null) {
				backImg = new Bitmap(backImg, new Size(width, height));
				LoadPixels();
			}

			bitmap = new Bitmap(width, height, Graphics.FromImage(bitmap));
			graphics = Graphics.FromImage(bitmap); //Die  Graphics muss nochmal  gesetzt werden, nachdem das Bild erneuert wurde.
		}

		private void button_remove_Click(object sender, EventArgs e) {
			backImg = null;
			textBox_imagePath.Text = "";
		}

		private void button_open_Click(object sender, EventArgs e) {
			OpenImageDialog();
		}
	}
}
