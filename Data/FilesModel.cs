using System;

public class FileModel
{
    public int Id { get; set; }
    public DateTime upload_date { get; set; }
    public string filename { get; set; }
    public byte[] filedata { get; set; }
}
