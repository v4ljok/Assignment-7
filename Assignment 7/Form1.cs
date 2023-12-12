namespace Assignment_7
{
    public partial class Form1 : Form
    {
        private char[] correctAnswers;
        private char[] studentAnswers;
        public Form1()
        {
            InitializeComponent();

            string correctAnswersFilePath = "C:\\Users\\Unluc\\IdeaProjects\\assignment 7\\CorrectAnswers.txt";
            LoadCorrectAnswers(correctAnswersFilePath);
        }

        private void LoadCorrectAnswers(string filePath)
        {
            try
            {
                correctAnswers = File.ReadAllText(filePath).ToCharArray();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading correct answers: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadStudentAnswers(string filePath)
        {
            try
            {
                studentAnswers = File.ReadAllText(filePath).ToCharArray();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading student answers: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GradeExam()
        {
            if (studentAnswers == null)
            {
                MessageBox.Show("Please load student answers first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int correctCount = 0;
            int incorrectCount = 0;
            string incorrectQuestions = "";

            for (int i = 0; i < correctAnswers.Length; i++)
            {
                if (i < studentAnswers.Length && studentAnswers[i] == correctAnswers[i])
                {
                    correctCount++;
                }
                else
                {
                    incorrectCount++;
                    incorrectQuestions += (i + 1) + ", ";
                }
            }

            incorrectQuestions = incorrectQuestions.TrimEnd(' ', ',');

            bool passed = correctCount >= 15;

            MessageBox.Show($"Student {(passed ? "passed" : "failed")} the exam.\n\n" +
                            $"Total Correct Answers: {correctCount}\n" +
                            $"Total Incorrect Answers: {incorrectCount}\n" +
                            $"Incorrect Question Numbers: {incorrectQuestions}",
                            "Exam Results", MessageBoxButtons.OK, passed ? MessageBoxIcon.Information : MessageBoxIcon.Warning);
        }

        private void btnLoadStudentAnswers_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog.Title = "Select Student Answers File";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                LoadStudentAnswers(openFileDialog.FileName);
            }
            label1.Text = "File chosen";
        }

        private void btnCheckAnswers_Click(object sender, EventArgs e)
        {
            GradeExam();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}