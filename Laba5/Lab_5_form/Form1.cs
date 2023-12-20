namespace Lab_5_form
{
    public partial class Form1 : Form
    {
        private Square square;
        private Rhomb rhomb;
        private Circle circle;

        public Form1()
        {
            InitializeComponent();

            square = new Square(400, 150, 100);
            rhomb = new Rhomb(400, 150, 100, 100);
            circle = new Circle(400, 150, 60);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            square.MoveRight();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            rhomb.MoveRight();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            circle.MoveRight();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }
    }

}