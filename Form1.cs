using System;
using System.Linq;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Timer1_Tick()
        {
            const int TagsCount = 30;
            string[,] Tags = new string[2, TagsCount];
            string[,] Values = new string[TagsCount, 1000];

            string put = inputText.Text;

            textBoxResult.Clear();
            string[] files = Directory.GetFiles(put, "*.txt");
            foreach (string file in files)
            {
                textBoxResult.AppendText(Path.GetFileName(file) + Environment.NewLine);
            }

            for (int load = 0; load < textBoxResult.Lines.Length; load++)
            {
                if (string.IsNullOrEmpty(textBoxResult.Lines[load]))
                    break;

                textBoxOriginal.Clear();
                textBoxOriginal.Lines = File.ReadAllLines(put + textBoxResult.Lines[load]);

                Tags[0, 0] = "{1:F01K055640000000000000000}";
                Tags[1, 0] = "СЕКЦИЯДОКУМЕНТ";
                Tags[0, 1] = "{2:O1000000000000SGROSS00000000000000000000000000U}";
                Tags[1, 1] = "";
                Tags[0, 2] = "{4:";
                Tags[1, 2] = "";
                Tags[0, 3] = ":20:";
                Tags[1, 3] = "";
                Tags[0, 4] = ":32A:";
                Tags[1, 4] = "ДАТАДОКУМЕНТА";
                Tags[0, 5] = ":50:/D/";
                Tags[1, 5] = "ПЛАТЕЛЬЩИКИК";
                Tags[0, 6] = "/NAME/";
                Tags[1, 6] = "ПЛАТЕЛЬЩИКНАИМЕНОВАНИЕ";
                Tags[0, 7] = "/IDN/";
                Tags[1, 7] = "ПЛАТЕЛЬЩИКБИН_ИИН";
                Tags[0, 8] = "/CHIEF/";
                Tags[1, 8] = "";
                Tags[0, 9] = "/IRS/";
                Tags[1, 9] = "ПЛАТЕЛЬЩИККБЕ";
                Tags[0, 10] = "/SECO/";
                Tags[1, 10] = "ПОЛУЧАТЕЛЬКБЕ";
                Tags[0, 11] = ":52B:";
                Tags[1, 11] = "ПЛАТЕЛЬЩИКБАНКБИК";
                Tags[0, 12] = ":57B:";
                Tags[1, 12] = "ПОЛУЧАТЕЛЬБАНКБИК";
                Tags[0, 13] = ":59:";
                Tags[1, 13] = "ПОЛУЧАТЕЛЬИИК";
                Tags[0, 14] = "/NAME/";
                Tags[1, 14] = "ПОЛУЧАТЕЛЬНАИМЕНОВАНИЕ";
                Tags[0, 15] = "/IDN/";
                Tags[1, 15] = "ПОЛУЧАТЕЛЬБИН_ИИН";
                Tags[0, 16] = "/IRS/";
                Tags[1, 16] = "ПОЛУЧАТЕЛЬКБЕ";
                Tags[0, 17] = "/SECO/";
                Tags[1, 17] = "ПОЛУЧАТЕЛЬКБЕ";
                Tags[0, 18] = ":70:/NUM/";
                Tags[1, 18] = "НОМЕРДОКУМЕНТА";
                Tags[0, 19] = "/DATE/";
                Tags[1, 19] = "ДАТАДОКУМЕНТА";
                Tags[0, 20] = "/KNP/";
                Tags[1, 20] = "КОДНАЗНАЧЕНИЯПЛАТЕЖА";
                Tags[0, 21] = "/ASSIGN/";
                Tags[1, 21] = "НАЗНАЧЕНИЕПЛАТЕЖА";
                Tags[0, 22] = "-}";
                Tags[1, 22] = "КОНЕЦДОКУМЕНТА";
                Tags[0, 24] = "";
                Tags[1, 24] = "СУММАРАСХОД";
                Tags[0, 25] = "";
                Tags[1, 25] = "СУММАПРИХОД";


                int CurPD = 0;
                int j = 0;
                for (int i = 0; i < textBoxOriginal.Lines.Length; i++)
                {
                    string CurLine = textBoxOriginal.Lines[i];
                    string CurLineUpper = CurLine.ToUpper();
                    if (CurLineUpper.Contains(Tags[1, 0]))
                        CurPD++;

                    for (j = 0; j < TagsCount; j++)
                    {
                        if (CurLineUpper.Contains(Tags[1, j]))
                            Values[j, CurPD] = CurLine.Substring(Tags[1, j].Length + 1);
                    }
                }

                textBoxOriginal.Clear();
                for (int i = 0; i < CurPD; i++)
                {
                    for (int u = 0; j < TagsCount; u++)
                    {
                        string CurLine = "";
                        if (j == 3)
                            CurLine = Tags[0, j] + Values[4, i].Substring(8, 2) + Values[4, i].Substring(3, 2) + Values[4, i].Substring(0, 2) + Values[5, i].Substring(11, 9);
                        else if (j == 4)
                            CurLine = Tags[0, j] + Values[j, i].Substring(8, 2) + Values[j, i].Substring(3, 2) + Values[j, i].Substring(0, 2) + "KZT" + Values[24, i] + Values[25, i];
                        else if (j == 9)
                            CurLine = Tags[0, j] + Values[j, i].Substring(0, 1);
                        else if (j == 10)
                            CurLine = Tags[0, j] + Values[j, i].Substring(1, 1);
                        else if (j == 16)
                            CurLine = Tags[0, j] + Values[j, i].Substring(0, 1);
                        else if (j == 17)
                            CurLine = Tags[0, j] + Values[j, i].Substring(1, 1);
                        else if (j == 18)
                            CurLine = Tags[0, j] + Values[j, i].Substring(8, 2) + Values[j, i].Substring(3, 2) + Values[j, i].Substring(0, 2);
                        else if (j == 23)
                            CurLine = Tags[0, j] + "       ";
                        else
                            CurLine = Tags[0, j] + Values[j, i];

                        if (CurLine.Length > 0)
                            textBoxOriginal.AppendText(CurLine + Environment.NewLine);
                    }

                    if (textBoxOriginal.Lines[0].Length > 0)
                    {
                        string fileName = put + "kik" + (i + 1).ToString() + textBoxResult.Lines[load].Substring(0, textBoxResult.Lines[load].Length - 4) + ".mt";
                        File.WriteAllLines(fileName, textBoxOriginal.Lines);
                        textBoxOriginal.Clear();
                    }
                }
                //File.Delete(put + textBoxResult.Lines[load]);
            }
        }


            private void inputButton_Click(object sender, EventArgs e)
            {
                DialogResult dialogIn = folderBrowserDialog1.ShowDialog();
                if (dialogIn == DialogResult.OK)
                {
                    inputText.Text = folderBrowserDialog1.SelectedPath;
                }
            }

            private void outputButton_Click(object sender, EventArgs e)
            {
                DialogResult dialogOut = folderBrowserDialog4.ShowDialog();
                if (dialogOut == DialogResult.OK)
                {
                    outputText.Text = folderBrowserDialog4.SelectedPath;
                }
            }

            private void readButton_Click(object sender, EventArgs e)
            {
                string[] files = Directory.GetFiles(inputText.Text, "*.txt");

                textBoxFolder.Clear();
                foreach (string file in files)
                {
                    textBoxFolder.AppendText(Path.GetFileName(file) + "\r\n");
                }
            }

            private void convertButton_Click(object sender, EventArgs e)
            {
                Timer1_Tick();
            }
        }
    }
