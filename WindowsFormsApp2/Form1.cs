using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        private List<Shape> shapes = new List<Shape>();

        public Form1()
        {
            InitializeComponent();
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            if (radioButtonCircle.Checked)
            {
                shapeList.Items.Add($"Коло r = {textBoxRadius.Text}");
            } else if (radioButtonRectangle.Checked)
            {
                shapeList.Items.Add($"Прямокутник w = {textBoxWidth.Text} , h = {textBoxHeight.Text}");
            } else if (radioButtonDiamond.Checked)
            {
                shapeList.Items.Add($"Ромб ver/di = {textBoxWidth.Text} , hor/di = {textBoxHeight.Text}");
            } else if (radioButtonTriangle.Checked)
            {
                shapeList.Items.Add($"Трикутник l = {textBoxWidth.Text}");
            }
        }

        private void calculateAreaButton_Click(object sender, EventArgs e)
        {
            if (shapeList.SelectedIndex >= 0)
            {

                    string selectedFigure = shapeList.SelectedItem.ToString().Split()[0];
                    if (selectedFigure == "Коло")
                    {
                        int radius = int.Parse(shapeList.SelectedItem.ToString().Split()[3]);
                        MessageBox.Show($"Площа обраної фігури: {Math.PI * radius * radius}");
                    } else if (selectedFigure == "Прямокутник")
                    {
                        int width = int.Parse(shapeList.SelectedItem.ToString().Split()[3]);
                        int height = int.Parse(shapeList.SelectedItem.ToString().Split()[7]);
                        MessageBox.Show($"Площа обраної фігури: {width * height}");
                    }  else if (selectedFigure == "Ромб")
                    {
                        int horizontalDiagonal = int.Parse(shapeList.SelectedItem.ToString().Split()[3]);
                        int verticalDiagonal = int.Parse(shapeList.SelectedItem.ToString().Split()[7]);
                        MessageBox.Show($"Площа обраної фігури: {(horizontalDiagonal * verticalDiagonal) / 2.0}");

                    } else if (selectedFigure == "Трикутник")
                    {
                        int length = int.Parse(shapeList.SelectedItem.ToString().Split()[3]);
                        MessageBox.Show($"Площа обраної фігури: {(Math.Sqrt(3) / 4) * length * length}");
                    }
                    canvas.Invalidate();
            }
        }

        private void canvas_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            foreach (Shape shape in shapes)
            {
                shape.Draw(g);
            }
        }

        private void canvas_MouseMove(object sender, MouseEventArgs e)
        {
            coordinatesLabel.Text = $"X: {e.X}, Y: {e.Y}";
        }

        private void canvas_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && shapeList.SelectedIndex >= 0)
            {
                Point position = new Point(e.X, e.Y);
                string selectedFigure = shapeList.SelectedItem.ToString().Split()[0];
                if (selectedFigure == "Коло")
                {
                    int radius = int.Parse(shapeList.SelectedItem.ToString().Split()[3]);
                    Circle circle = new Circle(radius, position);
                    shapes.Add(circle);
                } else if (selectedFigure == "Прямокутник")
                {
                    int width = int.Parse(shapeList.SelectedItem.ToString().Split()[3]);
                    int height = int.Parse(shapeList.SelectedItem.ToString().Split()[7]);
                    Rectangle rectangle = new Rectangle(width, height, position);
                    shapes.Add(rectangle);
                }  else if (selectedFigure == "Ромб")
                {
                    int horizontalDiagonal = int.Parse(shapeList.SelectedItem.ToString().Split()[3]);
                    int verticalDiagonal = int.Parse(shapeList.SelectedItem.ToString().Split()[7]);
                    Diamond diamond = new Diamond(position, horizontalDiagonal, verticalDiagonal);
                    shapes.Add(diamond);
                } else if (selectedFigure == "Трикутник")
                {
                    int length = int.Parse(shapeList.SelectedItem.ToString().Split()[3]);
                    Triangle triangle = new Triangle(length, position);
                    shapes.Add(triangle);
                }
                canvas.Invalidate();
            }
        }

        private void radioButtonTriangle_CheckedChanged(object sender, EventArgs e)
        {
            labelWidth.Text = "Length";
            labelHeight.Text = "";
            labelRadius.Text = "";
            textBoxWidth.Enabled = true;
            textBoxHeight.Enabled = false;
            textBoxRadius.Enabled = false;
        }

        private void radioButtonDiamond_CheckedChanged(object sender, EventArgs e)
        {
            labelWidth.Text = "Hor Di";
            labelHeight.Text = "Ver Di";
            labelRadius.Text = "";
            textBoxWidth.Enabled = true;
            textBoxHeight.Enabled = true;
            textBoxRadius.Enabled = false;
        }

        private void radioButtonRectangle_CheckedChanged(object sender, EventArgs e)
        {
            labelWidth.Text = "Width";
            labelHeight.Text = "Height";
            labelRadius.Text = "";
            textBoxHeight.Enabled = true;
            textBoxWidth.Enabled = true;
            textBoxRadius.Enabled = false;
        }

        private void radioButtonCircle_CheckedChanged(object sender, EventArgs e)
        {
            labelWidth.Text = "";
            labelHeight.Text = "";
            labelRadius.Text = "Radius";
            textBoxHeight.Enabled = false;
            textBoxWidth.Enabled = false;
            textBoxRadius.Enabled = true;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            string filePath = "shape_values.txt";
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                foreach (var item in shapeList.Items)   
                {
                    writer.WriteLine(item.ToString());
                }
            }
            MessageBox.Show("Фігури збережені в файл.");
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            string filePath = "shape_values.txt";

            if (File.Exists(filePath))
            {
                shapeList.Items.Clear();
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        shapeList.Items.Add(line);
                    }
                }
                MessageBox.Show("Фігури успішно завантажені.");
            }
            else
            {
                MessageBox.Show("Файл не знайдено.");
            }
        }
    }
}