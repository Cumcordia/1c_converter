using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        const int TagsCount = 30;
        string[,] tags = new string[2, TagsCount];
        string[,] Values = new string[TagsCount, 100];

        public Form1()
        {
            InitializeComponent();
            InitializeTags();
        }

        private void m()
        {
            try
            {
                string put = @"C:\Users\praktikant_dikt\Desktop\in\";
                string[] files = Directory.GetFiles(put, "*.txt");

                using (StreamWriter writer = new StreamWriter(put + "output.txt"))
                {
                    foreach (string file in files)
                    {
                        string[] lines = File.ReadAllLines(file);
                        int curPD = 0;

                        for (int i = 0; i < lines.Length; i++)
                        {
                            string curLine = lines[i];
                            string curLineUpper = curLine.ToUpper();

                            if (curLineUpper.Contains(tags[1, 0]))
                                curPD++;

                            for (int j = 0; j < TagsCount; j++)
                            {
                                if (tags[1, j] != null && curLineUpper.Contains(tags[1, j]))
                                {
                                    if (Values.GetLength(1) > curPD)
                                        Values[j, curPD] = curLine.Substring(tags[1, j].Length).Trim();
                                    else
                                        throw new IndexOutOfRangeException("Values array index out of range.");
                                }
                            }
                        }

                        for (int i = 0; i < curPD; i++)
                        {
                            for (int j = 0; j < TagsCount; j++)
                            {
                                string curLine = "";
                                switch (j)
                                {
                                    case 3:
                                        curLine = tags[0, j] + Values[4, i].Substring(9, 2) + Values[4, i].Substring(4, 2) + Values[4, i].Substring(0, 2) + Values[5, i].Substring(11);
                                        break;
                                    case 4:
                                        curLine = tags[0, j] + Values[j, i].Substring(9, 2) + Values[j, i].Substring(4, 2) + Values[j, i].Substring(0, 2) + "KZT" + Values[24, i] + Values[25, i];
                                        break;
                                    case 5:
                                        curLine = tags[0, j] + Values[j, i].Substring(9, 2);
                                        break;
                                    case 9:
                                        curLine = tags[0, j] + Values[j, i].Substring(0, 1);
                                        break;
                                    case 10:
                                        curLine = tags[0, j] + Values[j, i].Substring(0, 2);
                                        break;
                                    case 16:
                                        curLine = tags[0, j] + Values[j, i].Substring(0, 1);
                                        break;
                                    case 17:
                                        curLine = tags[0, j] + Values[j, i].Substring(0, 2);
                                        break;
                                    case 19:
                                        curLine = tags[0, j] + Values[j, i].Substring(9, 2) + Values[j, i].Substring(4, 2) + Values[j, i].Substring(0, 2);
                                        break;
                                    case 25:
                                        curLine = tags[0, j];
                                        break;
                                }
                                if (!string.IsNullOrEmpty(curLine))
                                    writer.WriteLine(curLine);
                            }
                        }
                        File.Delete(file);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void InitializeTags()
        {
            tags[0, 0] = "{1:F01K055640000000000000000}"; tags[1, 0] = "СЕКЦИЯДОКУМЕНТ";
            tags[0, 1] = "{2:O1000000000000SGROSS00000000000000000000000000U}"; tags[1, 1] = "";
            tags[0, 2] = "{4:"; tags[1, 2] = "";
            tags[0, 3] = ":20:"; tags[1, 3] = "";
            tags[0, 4] = ":32A:"; tags[1, 4] = "ДАТАДОКУМЕНТА";
            tags[0, 5] = ":50:/D/"; tags[1, 5] = "ПЛАТЕЛЬЩИКИК";
            tags[0, 6] = "/NAME/"; tags[1, 6] = "ПЛАТЕЛЬЩИКНАИМЕНОВАНИЕ";
            tags[0, 7] = "/IDN/"; tags[1, 7] = "ПЛАТЕЛЬЩИКБИН_ИИН";
            tags[0, 8] = "/CHIEF/"; tags[1, 8] = "";
            tags[0, 9] = "/IRS/"; tags[1, 9] = "ПЛАТЕЛЬЩИККБЕ";
            tags[0, 10] = "/SECO/"; tags[1, 10] = "ПОЛУЧАТЕЛЬКБЕ";
            tags[0, 11] = ":52B:"; tags[1, 11] = "ПЛАТЕЛЬЩИКБАНКБИК";
            tags[0, 12] = ":57B:"; tags[1, 12] = "ПОЛУЧАТЕЛЬБАНКБИК";
            tags[0, 13] = ":59:"; tags[1, 13] = "ПОЛУЧАТЕЛЬИИК";
            tags[0, 14] = "/NAME/"; tags[1, 14] = "ПОЛУЧАТЕЛЬНАИМЕНОВАНИЕ";
            tags[0, 15] = "/IDN/"; tags[1, 15] = "ПОЛУЧАТЕЛЬБИН_ИИН";
            tags[0, 16] = "/IRS/"; tags[1, 16] = "ПОЛУЧАТЕЛЬКБЕ";
            tags[0, 17] = "/SECO/"; tags[1, 17] = "ПОЛУЧАТЕЛЬКБЕ";
            tags[0, 18] = ":70:/NUM/"; tags[1, 18] = "НОМЕРДОКУМЕНТА";
            tags[0, 19] = "/DATE/"; tags[1, 19] = "ДАТАДОКУМЕНТА";
            tags[0, 20] = "/KNP/"; tags[1, 20] = "КОДНАЗНАЧЕНИЯПЛАТЕЖА";
            tags[0, 21] = "/ASSIGN/"; tags[1, 21] = "НАЗНАЧЕНИЕПЛАТЕЖА";
            tags[0, 22] = "-}"; tags[1, 22] = "КОНЕЦДОКУМЕНТА";
            tags[0, 24] = ""; tags[1, 24] = "СУММАРАСХОД";
            tags[0, 25] = ""; tags[1, 25] = "СУММАПРИХОД";
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}