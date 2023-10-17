namespace AgileProject.Models.Mail;

public class MailList
{
    public string? Subject { get; set; }
    public int SenderId { get; set; }
    public bool IsRead {get; set;}
    public DateTime DateCreated { get; set; }
}