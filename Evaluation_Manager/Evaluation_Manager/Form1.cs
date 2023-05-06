namespace Evaluation_Manager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "txt files (*.txt)| *.txt";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                UserFileReader filereader = new UserFileReader(ofd.FileName);
                UserFileParser parser = new UserFileParser();
                UserFormInfo forminfo = new UserFormInfo(parser.stringParser(filereader.Readfile()));
                UserDisplayer displayer = new UserDisplayer();
                displayer.DisplayInfo(this, forminfo);

            }
        }
    }
}