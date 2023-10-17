namespace AgileProject.Models.Mail;

public class MailCreate
{
    public string? Subject { get; set; }
    public string? Body { get; set; }
    public int SenderId { get; set; }
    public int RecipientId { get; set; }
    public int ContactId {get; set;}
    public bool IsRead = false;
}