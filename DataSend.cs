using System;

namespace WinFormsApp1
{
    public class DataSend
    {
        public static void Datasend()
        {
            using (var context = new ApplicationContext())
            {
                var NewDate = new DataModel { ConvertDateAndTime = DateTime.Now, FileOriginalName = "", FileConvertedName = "" };
                context.DataModel.Add(NewDate);
                context.SaveChanges();
            }
        }
    }
}
