using System;
using System.Linq;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void MainMethod()
        {
            const int TagsCount = 27;
            string[,] Tags = new string[2, TagsCount];
            string[,] Values = new string[TagsCount, 1000];

            string put = inputText.Text;

            string[] files = Directory.GetFiles(put, "*.txt");
            foreach (string file in files)
            {
                textBoxFolder.AppendText(Path.GetFileName(file) + Environment.NewLine);
            }

            for (int load = 0; load < textBoxFolder.Lines.Length; load++)
            {
                textBoxOriginal.Clear();
                string vInputFile = textBoxFolder.Lines[0];
                textBoxOriginal.Lines = File.ReadAllLines(put + "\\" + textBoxFolder.Lines[load]);

                Datasend(vInputFile);

                Tags[0, 0] = "{1:F01K055640000000000000000}";                           Tags[1, 0] = "СЕКЦИЯДОКУМЕНТ";
                Tags[0, 1] = "{2:O1000000000000SGROSS00000000000000000000000000U}";     Tags[1, 1] = "";
                Tags[0, 2] = "{4:";                                                     Tags[1, 2] = "";
                Tags[0, 3] = ":20:";                                                    Tags[1, 3] = "";
                Tags[0, 4] = ":32A:";                                                   Tags[1, 4] = "ДАТАДОКУМЕНТА";
                Tags[0, 5] = ":50:/D/";                                                 Tags[1, 5] = "ПЛАТЕЛЬЩИКИИК";
                Tags[0, 6] = "/NAME/";                                                  Tags[1, 6] = "ПЛАТЕЛЬЩИКНАИМЕНОВАНИЕ";
                Tags[0, 7] = "/IDN/";                                                   Tags[1, 7] = "ПЛАТЕЛЬЩИКБИН_ИИН";
                Tags[0, 8] = "/CHIEF/";                                                 Tags[1, 8] = "";
                Tags[0, 9] = "/MAINBK/";                                                Tags[1, 9] = "";
                Tags[0, 10] = "/IRS/";                                                  Tags[1, 10] = "ПЛАТЕЛЬЩИККБЕ";
                Tags[0, 11] = "/SECO/";                                                 Tags[1, 11] = "ПЛАТЕЛЬЩИККБЕ";
                Tags[0, 12] = ":52B:";                                                  Tags[1, 12] = "ПЛАТЕЛЬЩИКБАНКБИК";
                Tags[0, 13] = ":57B:";                                                  Tags[1, 13] = "ПОЛУЧАТЕЛЬБАНКБИК";
                Tags[0, 14] = ":59:";                                                   Tags[1, 14] = "ПОЛУЧАТЕЛЬИИК";
                Tags[0, 15] = "/NAME/";                                                 Tags[1, 15] = "ПОЛУЧАТЕЛЬНАИМЕНОВАНИЕ";
                Tags[0, 16] = "/IDN/";                                                  Tags[1, 16] = "ПОЛУЧАТЕЛЬБИН_ИИН";
                Tags[0, 17] = "/IRS/";                                                  Tags[1, 17] = "ПОЛУЧАТЕЛЬКБЕ";
                Tags[0, 18] = "/SECO/";                                                 Tags[1, 18] = "ПОЛУЧАТЕЛЬКБЕ";
                Tags[0, 19] = ":70:/NUM/";                                              Tags[1, 19] = "НОМЕРДОКУМЕНТА";
                Tags[0, 20] = "/DATE/";                                                 Tags[1, 20] = "ДАТАДОКУМЕНТА";
                Tags[0, 21] = "/KNP/";                                                  Tags[1, 21] = "КОДНАЗНАЧЕНИЯПЛАТЕЖА";
                Tags[0, 22] = "/ASSIGN/";                                               Tags[1, 22] = "НАЗНАЧЕНИЕПЛАТЕЖА";
                Tags[0, 23] = "-}";                                                     Tags[1, 23] = "КОНЕЦДОКУМЕНТА";
                Tags[0, 24] = "";                                                       Tags[1, 24] = "";
                Tags[0, 25] = "";                                                       Tags[1, 25] = "СУММАРАСХОД";
                Tags[0, 26] = "";                                                       Tags[1, 26] = "СУММАПРИХОД";



                int CurPD = 0;

                for (int i = 0; i < textBoxOriginal.Lines.Length; i++)
                {
                    string curLine = textBoxOriginal.Lines[i];
                    string curLineUpper = curLine.ToUpper();

                    if (curLineUpper.Contains(Tags[1, 0]))
                    {
                        CurPD++;
                    }

                    for (int j = 0; j < Tags.GetLength(1); j++)
                    {
                        if (curLineUpper.Contains(Tags[1, j]))
                        {
                            int startIndex = curLineUpper.IndexOf(Tags[1, j]) + Tags[1, j].Length;
                            string value = curLine.Substring(startIndex);

                            Values[j, CurPD] = value;
/*                            string res = string.Join("\r\n", value);
                            MessageBox.Show(res);*/

                        }
                    }
                }


                //textBoxOriginal.Clear();
                for (int i = 0; i < CurPD; i++)
                {
                    for (int j = 0; j < TagsCount; j++)
                    {
                        string CurLine;

                        if (j == 4)
                            CurLine = Tags[0, 3] + Values[19, 2].Substring(1) + Values[4, 2].Substring(9, 2) + Values[4, 2].Substring(4, 2) + Values[4, 2].Substring(1, 2);
                        else if (j == 5)
                            CurLine = Tags[0, 4] + Values[4, 2].Substring(9, 2) + Values[4, 2].Substring(4, 2) + Values[4, 2].Substring(1, 2) + "KZT" + Values[26, 2].Substring(1);
                        else if (j == 6)
                            CurLine = Tags[0, 5] + Values[5, 2].Substring(1);
                        else if (j == 7)
                            CurLine = Tags[0, 6] + Values[6, 2].Substring(1);
                        else if (j == 8)
                            CurLine = Tags[0, 7] + Values[7, 2].Substring(1);
                        else if (j == 9)
                            CurLine = Tags[0, 8] + Values[8, 2].Substring(1);
                        else if (j == 10)
                            CurLine = Tags[0, 9] + Values[9, 2].Substring(1);
                        else if (j == 11)
                            CurLine = Tags[0, 10] + Values[10, 2].Substring(1);
                        else if (j == 12)
                            //исправить
                            CurLine = Tags[0, 11] + Values[10, 2].Substring(1);
                        else if (j == 13)
                            CurLine = Tags[0, 12] + Values[12, 2].Substring(1);
                        else if (j == 14)
                            CurLine = Tags[0, 13] + Values[13, 2].Substring(1);
                        else if (j == 15)
                            CurLine = Tags[0, 14] + Values[14, 2].Substring(1);
                        else if (j == 16)
                            CurLine = Tags[0, 15] + Values[15, 2].Substring(1);
                        else if (j == 17)
                            CurLine = Tags[0, 16] + Values[16, 2].Substring(1);
                        else if (j == 18)
                            CurLine = Tags[0, 17] + Values[17, 2].Substring(1);
                        else if (j == 19)
                            CurLine = Tags[0, 18] + Values[18, 2].Substring(1);
                        else if (j == 20)
                            CurLine = Tags[0, 19] + Values[19, 2].Substring(1);
                        else if (j == 21)
                            CurLine = Tags[0, 20] + Values[20, 2].Substring(9, 2) + Values[20, 2].Substring(4, 2) + Values[20, 2].Substring(1, 2);
                        else if (j == 22)
                            CurLine = Tags[0, 21] + Values[21, 2].Substring(1);
                        else if (j == 23)
                            CurLine = Tags[0, 22] + Values[22, 2].Substring(1);
                        else if (j == 24)
                            CurLine = Tags[0, 23];

                        else
                            CurLine = Tags[0, j] + Values[j, i];

                        if (CurLine.Length > 0)
                            textBoxResult.AppendText(CurLine + Environment.NewLine);
                    }

                    if (textBoxResult.Lines[0].Length > 0)
                    {
                        string fileName = put + "kik" + (i + 1).ToString() + textBoxResult.Lines[load].Substring(0, textBoxResult.Lines[load].Length - 4) + ".mt";
                        File.WriteAllLines(fileName, textBoxResult.Lines);
                        textBoxResult.Clear();
                    }
                }
                //File.Delete(put + "\\" + textBoxFolder.Lines[load]);
            }
        }

        public static void Datasend(string vinputFile)
        {
            using (var context = new ApplicationContext())
            {
                var NewDate = new DataModel { ConvertDateAndTime = DateTime.Now, FileOriginalName = vinputFile, FileConvertedName = "" };
                context.DataModel.Add(NewDate);
                context.SaveChanges();
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

        private void convertButton_Click(object sender, EventArgs e)
        {
            MainMethod();
        }
    }
}
