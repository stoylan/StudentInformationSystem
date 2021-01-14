using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Student_Information_System
{
    class Transcript
    {
        private ArrayList LessonNameArray = new ArrayList();
        private string[] GradeArray = new string[6];
        private string[] WordGradeArray = new string[6];
        private string[] OverallAverageArray = new string[6];
        private String transcriptText;
        Database db = new Database();

        public ArrayList LessonNameArray1 { get => LessonNameArray; set => LessonNameArray = value; }
        public string[] GradeArray1 { get => GradeArray; set => GradeArray = value; }
        public string[] WordGradeArray1 { get => WordGradeArray; set => WordGradeArray = value; }
        public string[] OverallAverageArray1 { get => OverallAverageArray; set => OverallAverageArray = value; }
        public string TranscriptText { get => transcriptText; set => transcriptText = value; }

        public String getTranscriptRecord(int studentid,String studentname)
        {
            db.Connection.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT Name,Grade,WordGrade,OverallAverage FROM `lessonlog` WHERE ID = @id", db.Connection);
            cmd.Parameters.AddWithValue("id", studentid);
            db.Datareader = cmd.ExecuteReader();
            ArrayList LessonName = new ArrayList();
            string[] Grade = new string[6];
            string[] WordGrade = new string[6];
            string[] OverallAverage = new string[6];
            int i = 0;
            while (db.Datareader.Read())
            {
                LessonName.Add(db.Datareader.GetValue(0).ToString());
                Grade[i] = (db.Datareader.GetValue(1).ToString());
                WordGrade[i] = (db.Datareader.GetValue(2).ToString());
                OverallAverage[i] = (db.Datareader.GetValue(3).ToString());
                i++;
            }
            db.Connection.Close();

            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "Txt Dosyası|*.txt";
            transcriptText = "          " + studentname.ToUpper() + "\n" +
                         "LESSON NAME      GRADE      WORDGRADE     OVERALL AVERAGE\n";

            int j = 0;
            foreach (string lessons in LessonName)
            {
                transcriptText = transcriptText + lessons + "         " + Grade[j] + "               " + WordGrade[j] + "                 " + OverallAverage[j] + "\n";
                j++;
            }
            return transcriptText;
        }
    }
}
